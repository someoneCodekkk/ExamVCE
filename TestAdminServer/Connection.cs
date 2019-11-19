using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TestAdminServer
{
    class Connection
    {
        public static IPAddress GetMyIp()
        {
            IPHostEntry entry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress myIP = entry.AddressList.First(a => a.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            return myIP;
        }
        public static Socket SetSocket(IPAddress myIP, int port)
        {
            Socket socket = new Socket(myIP.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(new IPEndPoint(myIP, port));
            socket.Listen(10);

            return socket;
        }
    }
}
