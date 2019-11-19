using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAdminServer
{
    public partial class LoginForm : Form
    {
        public Staff person { private set; get; }
        bool isSuccess = false;
        public LoginForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            buttonLogin.Enabled = false;
            Task.Run(() =>
            {
                using (ExamVceDB staff = new ExamVceDB())
                {
                    foreach (var item in staff.Staffs)
                    {
                        char[] login = item.Login.ToCharArray();
                        var password = item.Password.ToCharArray();
                        int endPosLogin = 0;
                        int endPosPass = 0;
                        while(true)
                        {
                            if(login[endPosLogin] == ' ' || endPosLogin > item.Login.Length - 1)
                            {
                                break;
                            }
                            endPosLogin++;
                        }
                        while (true)
                        {
                            if (password[endPosPass] == ' ' || endPosPass > item.Login.Length - 1)
                            {
                                break;
                            }
                            endPosPass++;
                        }
                        string log = new string(login, 0, endPosLogin);

                        string pass = new string(password, 0, endPosPass);
                        if (textBoxLogin.Text.Equals(log) && textBoxPassword.Text.Equals(pass))
                        {
                            person = item;
                            isSuccess = true;
                            break;
                        }
                    }
                    
                }
                if (isSuccess)
                {
                    MessageBox.Show("Success");
                    this.Close();
                    return;
                }
                MessageBox.Show($"Login: {textBoxLogin.Text} not found. Check your password and login");
                buttonLogin.Enabled = true;
            });
           
        }

    }
}
