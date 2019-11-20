using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using LibraryForTest;
using System.Xml.Serialization;
using System.IO;
using System.Net.Sockets;
using UserLibrary;
using System.Net;
using NetworkAppLibrary;

namespace TestClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MakeTest test;
        List<List<TypeQuestion>> typeQuestions = new List<List<TypeQuestion>>();

        Socket server;
        string ipAddressServer = "192.168.43.175";
        int port = 7412;

        User Iam;
        public MainWindow()
        {
            
            //LoginForm loginForm = new LoginForm();
            //loginForm.ShowDialog();
            InitializeComponent();

            if (Iam == null)
            {
                LoginForm login = new LoginForm();
                login.ShowDialog();
                if (login.isLogin)
                    Iam = login.user;
                else
                    Close();
            }

            

            ConnectToServer();
        }
        //зєднання з сервером
        void ConnectToServer()
        {
            try
            {
                var serverIP = IPAddress.Parse(ipAddressServer);
                server = new Socket(serverIP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                server.Connect(new IPEndPoint(serverIP, port));

                server.Send(Encoding.UTF8.GetBytes(Iam.Login));
                Task.Run(() => ReceiveMessages());
            }
            catch (SocketException se)
            {
                //MessageBox.Show(se.Message);
                ChooseServer choose = new ChooseServer();
                choose.ShowDialog();
                ipAddressServer = choose.ipAddressServer;
                ConnectToServer();
            }

        }
        //надсилання повідомлення
        void SendMessage(string msg, MessageType type)
        {
            if (server == null)
                return;

            byte[] data = Encoding.UTF8.GetBytes(msg);
            var info = new TransferInfo(data.Length, type);
            server.Send(info.ToBytes()); //інформація 
            server.Send(data); //повідомлення

        }
        //отримання повідомлення
        void ReceiveMessages()
        {
            try
            {
                while (true)
                {
                    byte[] infoBytes = new byte[8];
                    server.Receive(infoBytes);


                    var info = TransferInfo.FromBytes(infoBytes);


                    byte[] buffer = new byte[250];

                    MemoryStream memoryStream = new MemoryStream();

                    int left = info.Size;
                    int count = 0;


                    while (left > 0)
                    {
                        int download = left < buffer.Length ? left : buffer.Length;
                        count = server.Receive(buffer, download, SocketFlags.None);
                        memoryStream.Write(buffer, 0, count);
                        left -= count;
                    }
                    string recive = Encoding.UTF8.GetString(memoryStream.ToArray());
                    
                    switch (info.Type)
                    {
                        case MessageType.Test:
                            {
                                var serializer = new XmlSerializer(typeof(MakeTest));
                                //MakeTest desr;
                                using (TextReader reader = new StringReader(recive))
                                {
                                    test = (MakeTest)serializer.Deserialize(reader);
                                }
                                Dispatcher.Invoke(() =>
                                {
                                    mainWindow.Children.Clear();
                                    FillFild();
                                    FillRadioAnswer();
                                    FillQuestions();
                                    EndExamButton.IsEnabled = true;
                                });
                                
                                break;
                            }
                    }
                }
            }
            catch(Exception ex)
            {
                System.Windows.MessageBox.Show(ex.Message);
                System.Windows.MessageBox.Show("Connection with server is lost");
            }
        }
        private void ExitFromProgram_Click(object sender, RoutedEventArgs e)
        {

        }

        private void prevQuestion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nextQuestion_Click(object sender, RoutedEventArgs e)
        {
            //SendMessage();
        }
        //Завершення екзамену надсилання відповідей
        private void EndExamButton_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            int j = 0;
            foreach (var item in test.questions)
            {
                foreach (var a in item.answers)
                {
                    if((typeQuestions[i][j] as RadioQuestion).Choose.IsChecked.Value)
                    {
                        a.IsCorrect = true;
                    }
                    j++;
                }
                i++;
                j = 0;
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(MakeTest));

            using (StringWriter textWriter = new StringWriter())
            {
                xmlSerializer.Serialize(textWriter, test);

                //System.Windows.MessageBox.Show(textWriter.ToString());
                SendMessage(textWriter.ToString(), MessageType.CheckTestFromStudent);
            }
            
            
        }
        //непотрібний вже метод був як тест
        private void ChooseStartExam_Click(object sender, RoutedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.ShowDialog();
                string path = openFileDialog.FileName;

                XmlSerializer serializer = new XmlSerializer(typeof(MakeTest));

                StreamReader reader = new StreamReader(path);
                test = (MakeTest)serializer.Deserialize(reader);
            }
            FillFild();
            FillQuestions();
            FillRadioAnswer();
            
            mainWindow.Children.Clear();
        }
        void FillFild()
        {
            numberQuestion.Text = $"0/{test.questions.Count.ToString()} subject: {test.Subject}";
        }
        //заповнення запитань
        void FillQuestions()
        {
            for (int i = 0; i < test.questions.Count; i++)
            {
                //questions.Add(new ReadyQuestion($"Question: {i}", qq[i]));
                //Button b = new Button();
                System.Windows.Controls.Button b = new System.Windows.Controls.Button();
                //checkMark.Add(new CheckBox());
                //checkMark[i].Content = "Mark";
                //checkMark[i].Click += MarkCheck_click;
                b.Name = $"button{i}";
                b.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                b.Content = $"Запитання {i + 1}";
                b.Tag = test.questions[i].Condition;
                b.Click += B_Click;
                questionPanel.Children.Add(b);

            }
            for (int i = 0; i < test.questions.Count; i++)
            {
                for (int j = 0; j < test.questions[i].answers.Count; j++)
                {
                    (typeQuestions[i][j] as RadioQuestion).Choose.Click += Choose_Click;
                }
            }
        }

        private void Choose_Click(object sender, RoutedEventArgs e)
        {
            var rb = sender as System.Windows.Controls.RadioButton;
            for (int i = 0; i < typeQuestions.Count; i++)
            {
                for (int j = 0; j < typeQuestions[i].Count; j++)
                {
                    try
                    {
                        if (rb.Name == (typeQuestions[i][j] as RadioQuestion).Choose.Name)
                        {
                            (typeQuestions[i][j] as RadioQuestion).Choose.IsChecked = true;
                        }
                    }
                    catch { }
                }
            }
        }

        //заповнення радіобатонів
        void FillRadioAnswer()
        {
            foreach (var question in test.questions)
            {
                typeQuestions.Add(new List<TypeQuestion>());
                foreach (var answer in question.answers)
                {
                    typeQuestions[typeQuestions.Count - 1].Add(new RadioQuestion(answer.Question));
                }
            }
        }

        //зміна запитання
        private void B_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button b = sender as System.Windows.Controls.Button;
            mainWindow.Children.Clear();
            var choose = test.questions.Where(i => i.Condition.Equals(b.Tag));
            TextBlock text = new TextBlock();
            text.Text = b.Tag.ToString();
            mainWindow.Children.Add(text);
            //foreach (var item in choose)
            //{
            //    foreach (var a in item.answers)
            //    {
            //        //var radioButton = new System.Windows.Controls.RadioButton()
            //        //{
            //        //    Content = a.Question
            //        //};
            //        //mainWindow.Children.Add(radioButton);

            //    }
            //    numberQuestion.Text = $"{test.questions.IndexOf(item) + 1}/{test.questions.Count.ToString()} subject: {test.Subject}";
            //}
            foreach (var item in choose)
            {
                for (int i = 0; i < item.answers.Count; i++)
                {
                    var rab = (RadioQuestion)typeQuestions[test.questions.IndexOf(item)][i];
                    mainWindow.Children.Add(rab.Place);
                }
                numberQuestion.Text = $"{test.questions.IndexOf(item) + 1}/{test.questions.Count.ToString()} subject: {test.Subject}";
            }
            
            
        }

        private void GetExam_Click(object sender, RoutedEventArgs e)
        {
            SendMessage("get exam", MessageType.Test);
            //ReceiveMessages();
        }
    }
}
