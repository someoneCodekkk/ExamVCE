using LibraryForTest;
using NetworkAppLibrary;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using UserLibrary;

namespace TestAdminServer
{
    public partial class MainForm : Form
    {
        Socket socket;
        int port = 7412;
        bool isServerWork;
        Staff loginPerson;
        List<User> users = new List<User>();


        List<int> whereNeedSend = new List<int>();

        int idChooseExam = 0;
        
        public MainForm()
        {

            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            loginPerson = loginForm.person;

            InitializeComponent();
            if (loginPerson == null)
                this.Close();
            else
            {
                loginPerson = loginForm.person;
                labelWhoIs.Text = $"{loginPerson.Name} - {loginPerson.Login} - ";
                FillPermit();
            }
            if (!NetworkInterface.GetIsNetworkAvailable())
                MessageBox.Show("Немає підключення");

            CheckForIllegalCrossThreadCalls = false;
            FillUserFromDataBase();


        }
        //написання дозволів
        void FillPermit()
        {
            switch (loginPerson.Status)
            {
                case 1:
                    comboBoxAct.Items.Add("Delete smn from DB");
                    comboBoxAct.Items.Add("Add student to DB");
                    comboBoxAct.Items.Add("Show smth");
                    break;
                case 2:
                    comboBoxAct.Items.Add("Send test to");
                    break;
            }
            comboBoxAct.Items.Add("Add test to DB");
            comboBoxAct.Items.Add("Choose exam");

        }
        //запуск сервера
        private void buttonStartServer_Click(object sender, EventArgs e)
        {
            if (socket == null)
            {
                isServerWork = true;
                IPAddress myIp = Connection.GetMyIp();

                labelStatusServer.Text = $"Server: {myIp.ToString()}:{port}";

                socket = Connection.SetSocket(myIp, port);

                Task.Run(() =>
                {
                    while (isServerWork)
                    {
                        Socket client = socket.Accept();
                        byte[] loginClient = new byte[512];
                        int countBytes = 0;
                        try
                        {
                            countBytes = client.Receive(loginClient);
                        }
                        catch
                        {

                        }
                        string loginUser = Encoding.UTF8.GetString(loginClient, 0, countBytes);
                        User user = null;
                        try
                        {
                            int id = int.Parse(loginUser);
                             user = new User(client, id);
                        }
                        catch
                        {
                             user = new User(client, loginUser);
                        }
                        
                        

                        users.Add(user);
                        Task.Run(() => ConnectClient(user));

                    }

                });
            }
        }
        //зєднання клієнта
        void ConnectClient(User client)
        {
            try
            {
                while (true)
                {
                    byte[] infoBytes = new byte[8];
                    client.SocketUser.Receive(infoBytes);
                    
                    
                    var info = TransferInfo.FromBytes(infoBytes);


                    byte[] buffer = new byte[250];

                    MemoryStream memoryStream = new MemoryStream();

                    int left = info.Size;
                    int count = 0;


                    while (left > 0)
                    {
                        int download = left < buffer.Length ? left : buffer.Length;
                        count = client.SocketUser.Receive(buffer, download, SocketFlags.None);
                        memoryStream.Write(buffer, 0, count);
                        left -= count;
                    }
                    string recive = Encoding.UTF8.GetString(memoryStream.ToArray());
                    
                    FunctionForSwich(info, recive, client);
                }

            }
            catch (SocketException se)
            {
                client.SocketUser.Shutdown(SocketShutdown.Both);
                client.SocketUser.Close();
                //users.Remove(client);
                //string error = se.Message;
                //labelListError.Text += $"{error}\n";
                MessageBox.Show(se.Message);
            }
        }

        //запис айди тесту
        void ChangeIDForTest()
        {
            using(ExamVceDB test = new ExamVceDB())
            {
                //var last = test.TestDBs.Last();
                TestDB last = null;
                foreach (var item in test.TestDBs)
                {
                    last = item;
                }
                var result = test.TestDBs.FirstOrDefault(i => i.ID == last.ID);

                var serializer = new XmlSerializer(typeof(MakeTest));
                MakeTest desr;

                using (TextReader reader = new StringReader(result.Test))
                {
                    desr = (MakeTest)serializer.Deserialize(reader);
                }
                desr.IdTest = last.ID;
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(MakeTest));
                var stringWriter = new StringWriter();
                xmlSerializer.Serialize(stringWriter, desr);
                last.Test = stringWriter.ToString();
                test.SaveChanges();
            }
        }
        //вибір дії
        private void comboBoxAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            string act = comboBoxAct.SelectedItem.ToString();

            switch (act)
            {
                case "Add test to DB":
                    {
                        OpenFileDialog file = new OpenFileDialog();
                        file.ShowDialog();

                        string xmlTest = File.ReadAllText(file.FileName);
                        var time = DateTime.Now;
                        using (ExamVceDB test = new ExamVceDB())
                        {
                            test.TestDBs.Add(new TestDB()
                            {
                                IdFromPerson = loginPerson.ID,
                                Test = xmlTest,
                                DateLoad = time,
                            });
                            test.SaveChanges();
                            MessageBox.Show("test was added");
                        }
                        ChangeIDForTest();
                        break;
                    }
                case "Send test to":
                    {

                        break;
                    }
                case "Add student to DB":
                    {
                        AddStudentToDB addStudent = new AddStudentToDB();
                        addStudent.ShowDialog();
                        break;
                    }
                case "Choose exam":
                    {
                        listBoxExam.Enabled = true;
                        using (ExamVceDB exam = new ExamVceDB())
                        {
                            foreach (var item in exam.TestDBs)
                            {
                                MakeTest subject = DeserialiseFromString(item.Test);
                                listBoxExam.Items.Add($"{item.ID}* {subject.Subject}");
                            }
                            
                        }
                        
                        break;
                    }
            }

            if(comboBoxAct.SelectedItem.Equals("Add test to DB"))
            {
                
            }
        }
        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        void SendExam(User client)
        {
            using (ExamVceDB test = new ExamVceDB())
            {
                try
                {
                    if (idChooseExam < 0)
                        new Exception();
                    SendAnswer(GetTestForSendStudent(idChooseExam), client, MessageType.Test);
                }
                catch { SendAnswer("error xml", client, MessageType.Error); }
            }
        }
        //вибір типу отриманого повідомлення
        void FunctionForSwich(TransferInfo info, string recive, User client)
        {
            switch (info.Type)
            {
                case MessageType.CheckLogIn:
                    {
                        User reciveUser = JsonConvert.DeserializeObject<User>(recive);
                        string passRecive;
                        using (MD5 md5Hash = MD5.Create())
                        {
                            passRecive = GetMd5Hash(md5Hash, reciveUser.Password);
                        }
                            using (ExamVceDB userLogin = new ExamVceDB())
                        {
                            var student = userLogin.Students.Where(i => i.Login == reciveUser.Login).FirstOrDefault();
                            
                                char[] login = student.Login.ToCharArray();
                                var password = student.Password.ToCharArray();
                                int endPosLogin = 0;
                                int endPosPass = 0;
                                while (true)
                                {
                                    if (login[endPosLogin] == ' ' || endPosLogin > student.Login.Length - 1)
                                    {
                                        break;
                                    }
                                    endPosLogin++;
                                }
                                while (true)
                                {
                                    if (password[endPosPass] == ' ' || endPosPass > student.Login.Length - 1)
                                    {
                                        break;
                                    }
                                    endPosPass++;
                                }
                                string log = new string(login, 0, endPosLogin);

                                string pass = new string(password, 0, endPosPass);


                                bool isCorrectMD5 = false;

                                if (reciveUser.Login.Equals(log) && passRecive.Equals(pass))
                                {
                                    client.ID = student.ID;
                                    
                                    SendAnswer(student.ID.ToString(), client, MessageType.GetAnswer);
                                    
                                    return;
                                };
                            
                            
                            SendAnswer("not correct", client, MessageType.GetAnswer);
                        }
                        
                        break;
                    }
                case MessageType.Test:
                    {
                        using(ExamVceDB test = new ExamVceDB())
                        {
                            try
                            {
                                if (idChooseExam < 0)
                                    new Exception();
                                SendAnswer(GetTestForSendStudent(idChooseExam), client, MessageType.Test);
                            }
                            catch  { SendAnswer("error xml", client, MessageType.Error); }
                            
                            
                        }
                        break;
                    }
                case MessageType.CheckTestFromStudent:
                    {
                        MakeTest testFromUser = DeserialiseFromString(recive);
                        int mark = 0;
                        bool isWriteToDB = true;
                        using (ExamVceDB test = new ExamVceDB())
                        {
                            try
                            {
                                var result = test.TestDBs.FirstOrDefault(i => i.ID == testFromUser.IdTest);
                                MakeTest correctTest = DeserialiseFromString(result.Test);
                                
                                for (int i = 0; i < correctTest.questions.Count; i++)
                                {
                                    for (int j = 0; j < correctTest.questions[i].answers.Count; j++)
                                    {
                                        if(correctTest.questions[i].answers[j].IsCorrect)
                                        {
                                            if (testFromUser.questions[i].answers[j].IsCorrect)
                                            {
                                                mark += correctTest.questions[i].Weight;
                                            }
                                        }
                                    }
                                }
                                //MessageBox.Show(mark.ToString());
                               
                            }
                            catch
                            {
                                isWriteToDB = false;
                                MessageBox.Show("Test not foudn");
                            }
                        }
                        if(isWriteToDB)
                        {
                            try
                            {
                                using (ExamVceDB passExam = new ExamVceDB())
                                {
                                    passExam.PassExams.Add(new PassExam()
                                    {
                                        Id_Sender = loginPerson.ID,
                                        Id_Student = client.ID,
                                        Id_Test = testFromUser.IdTest,
                                        Mark = mark,
                                        Date_Pass = DateTime.Now
                                    });
                                    passExam.SaveChanges();
                                    MessageBox.Show("Test pass writed in DB");
                                }
                            }catch(Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                            
                        }
                        SendAnswer($"Your mark is: {mark}", client, MessageType.SendMark);
                            break;
                    }
            }
        }
        MakeTest DeserialiseFromString(string str)
        {
            var serializer = new XmlSerializer(typeof(MakeTest));
            MakeTest desr;

            using (TextReader reader = new StringReader(str))
            {
                return desr = (MakeTest)serializer.Deserialize(reader);
            }
        }

        //надсилання відповіді
        void SendAnswer(string answer, User client, MessageType info)
        {
            byte[] answerByte = Encoding.UTF8.GetBytes(answer);
            var infoAnswer = new TransferInfo(answerByte.Length, info);
            SendRegistrarion(client, infoAnswer, answerByte);
        }
        //продавження надсилання відповіді
        void SendRegistrarion(User send, TransferInfo info, byte[] data)
        {
            try
            {
                send.SocketUser.Send(info.ToBytes());
                send.SocketUser.Send(data);
            }
            catch
            {
                users.Remove(send);
            }
            
        }

       //приховування відповідей
        private string GetTestForSendStudent(int idTest)
        {
            using (ExamVceDB test = new ExamVceDB())
            {
                try
                {
                    var result = test.TestDBs.FirstOrDefault(i => i.ID == idTest);

                    var serializer = new XmlSerializer(typeof(MakeTest));
                    MakeTest desr;

                    using (TextReader reader = new StringReader(result.Test))
                    {
                        desr = (MakeTest)serializer.Deserialize(reader);
                    }

                    //var jsonMakeTest = JsonConvert.SerializeObject(desr);
                    //MakeTest testFromJson = JsonConvert.DeserializeObject<MakeTest>(jsonMakeTest);
                    foreach (var item in desr.questions)
                    {
                        foreach (var a in item.answers)
                        {
                            if (a.IsCorrect)
                                a.IsCorrect = !a.IsCorrect;
                        }
                    }
                    //var readyResult = JsonConvert.SerializeObject(testFromJson);
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(MakeTest));

                    using (StringWriter textWriter = new StringWriter())
                    {
                        xmlSerializer.Serialize(textWriter, desr);
                        return textWriter.ToString();
                    }
                }catch
                {
                    MessageBox.Show("Test not foudn");
                }
                return "";
               
            }
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListBoxExam_SelectedIndexChanged(object sender, EventArgs e)
        {
            char[] number = new char[7];
            for (int i = 0; i < number.Length; i++)
            {
                if(listBoxExam.SelectedItem.ToString()[i] == '*')
                {
                    break;
                }
                number[i] += listBoxExam.SelectedItem.ToString()[i];
            }
            string str = new string(number);
            idChooseExam = int.Parse(str);
        }
        void FillUserFromDataBase()
        {
            using(ExamVceDB users = new ExamVceDB())
            {
                foreach (var item in users.Students)
                {
                    ListViewItem list = new ListViewItem(item.ID.ToString());
                    list.SubItems.Add(item.Login);
                    list.SubItems.Add(item.Name);
                    list.SubItems.Add(item.Specialisation);

                    listViewUsers.Items.Add(list);
                }
            }
        }

        private void ListViewUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            whereNeedSend.Clear();
            foreach (var item in listViewUsers.SelectedItems)
            {
                char[] number = new char[7];
                for (int i = 0; i < item.ToString().Length; i++)
                {
                    
                    if (item.ToString()[i] == '{')
                    {
                        i++;
                        int j = 0;
                        do
                        {
                            number[j] += item.ToString()[i];
                            i++;
                            j++;
                            if (item.ToString()[i] == '}')
                                break;
                        }
                        while (item.ToString()[i] == '}');
                        
                        break;
                    }
                    
                }


                string str = new string(number);
                int id = int.Parse(str);

                whereNeedSend.Add(id);
            }
            
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < users.Count; i++)
            {
                for (int j = 0; j < whereNeedSend.Count; j++)
                {
                    if (users[i].ID == whereNeedSend[j])
                    {
                        SendExam(users[i]);
                    }
                }

            }
        }

        private void ButtonShowPassExam_Click(object sender, EventArgs e)
        {

        }
    }
}
