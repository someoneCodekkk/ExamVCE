using System;
using System.Collections.Generic;
using NetworkAppLibrary;
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
using Newtonsoft.Json;

namespace TestClient
{
    public partial class LoginForm : Form
    {
        public Socket server { get; private set; }
        string ipAddressServer = "192.168.43.175";
        int port = 7412;


        public User user { get; private set; }
        string reciveAnswer;

        public bool isLogin { get; private set; }
        public LoginForm()
        {
            InitializeComponent();

            Controls.SetChildIndex(pictureBoxBackground, -1);

            if (!NetworkInterface.GetIsNetworkAvailable())
                MessageBox.Show("Connect to network");

            ConnectToServer();
        }
        void ConnectToServer()
        {
            try
            {
                var serverIP = IPAddress.Parse(ipAddressServer);
                server = new Socket(serverIP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                server.Connect(new IPEndPoint(serverIP, port));

                server.Send(Encoding.UTF8.GetBytes("New user"));
                //Task.Run(() => ReceiveMessages());
            }
            catch (SocketException se)
            {
                MessageBox.Show(se.Message);
                ChooseServer choose = new ChooseServer();
                choose.ShowDialog();
                ipAddressServer = choose.ipAddressServer;
                ConnectToServer();

            }

        }
        void ReceiveMessages()
        {
            try
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
                switch (info.Type)
                {
                    case (MessageType.GetAnswer):
                        reciveAnswer = Encoding.UTF8.GetString(memoryStream.ToArray());
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Connection with server is lost");
            }

        }
        void SendRequest()
        {
            user = new User()
            {
                Login = textBoxLogin.Text,
                Password = textBoxPassword.Text
            };

            byte[] userByte = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(user));
            var info = new TransferInfo(userByte.Length, MessageType.CheckLogIn);
            server.Send(info.ToBytes());
            server.Send(userByte);

            ReceiveMessages();
        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            SendRequest();
            int tmp = 0;
            if (int.TryParse(reciveAnswer, out tmp))
            {
                isLogin = true;
                user.ID = int.Parse(reciveAnswer);
                MessageBox.Show("uhhhu success");
                server.Close();
                Close();
            }
            else
            {
                MessageBox.Show("Check your login and password");
            }
        }
    }
}
