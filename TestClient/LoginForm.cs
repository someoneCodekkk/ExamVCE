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

namespace TestClient
{
    public partial class LoginForm : Form
    {
        Socket server;
        string ipAddressServer = "192.168.43.175";
        int port = 7412;

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
    }
}
