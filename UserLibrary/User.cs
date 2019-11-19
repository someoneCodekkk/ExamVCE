using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace UserLibrary
{
    public class User
    {
        public Socket SocketUser { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public string Login { get; set; }
        public DateTime Date { get; set; }
        public string Gender { get; set; }
        public string Password { get; set; }
        public bool IsOnline { get; set; }

        public User()
        {

        }
        public User(Socket socet, string login)
        {
            SocketUser = socet;
            Login = login;
            IsOnline = true;
        }
        public static bool isExist(string login, List<User> list)
        {
            foreach (var item in list)
            {
                if (item.Login.Equals(login))
                    return true;
            }
            return false;
        }
        public static bool isCorrectLoginPassword(string login, string password, List<User> list)
        {
            foreach (var item in list)
            {
                if (item.Login.Equals(login) && item.Password.Equals(password))
                    return true;
            }
            return false;
        }
    }
}
