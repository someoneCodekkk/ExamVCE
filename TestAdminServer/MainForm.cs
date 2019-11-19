using NetworkAppLibrary;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        }
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

                        
                        User user = new User(client, loginUser);

                        users.Add(user);
                        Task.Run(() => ConnectClient(user));

                    }

                });
            }
        }

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
                    MessageBox.Show(recive);
                    //FunctionForSwich(info, recive, client);
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
                                DateLoad = time
                            });
                            //test.SaveChanges();
                        }
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
            }

            if(comboBoxAct.SelectedItem.Equals("Add test to DB"))
            {
                
            }
        }
        //void FunctionForSwich(TransferInfo info, string recive, UserDB client)
        //{
        //    switch (info.Type)
        //    {
        //        case (MessageType.Message):
        //            {
        //                SendMessage msg = JsonConvert.DeserializeObject<SendMessage>(recive);
        //                Forwarding(msg, client);
        //                break;
        //            }
        //        case (MessageType.RegistrationForm):

        //            {
        //                //string login = Encoding.UTF8.GetString(memoryStream.ToArray());
        //                string answer;
        //                UpDateUserDB();
        //                answer = UserDB.isExist(recive, alredyRegistered) ? "login exist" : "success";
        //                //byte[] answerByte = Encoding.UTF8.GetBytes(answer);
        //                //var infoAnswer = new TransferInfo(answerByte.Length, MessageType.RegistrationForm);
        //                //SendRegistrarion(client, infoAnswer, answerByte);
        //                SendAnswer(answer, client);
        //                break;
        //            }
        //        case MessageType.RegisteryFormSuccess:
        //            {
        //                //string str = Encoding.UTF8.GetString(memoryStream.ToArray());
        //                UserDB reciveData = JsonConvert.DeserializeObject<UserDB>(recive);
        //                alredyRegistered.Add(reciveData);
        //                WriteDataBase();
        //                break;
        //            }
        //        case MessageType.CheckLogIn:
        //            {
        //                UserDB reciveUser = JsonConvert.DeserializeObject<UserDB>(recive);
        //                string answer = UserDB.isCorrectLoginPassword(reciveUser.Login, reciveUser.Password, alredyRegistered) ? "correct" : "error";
        //                SendAnswer(answer, client);
        //                break;
        //            }
        //    }
        //}
    }
}
