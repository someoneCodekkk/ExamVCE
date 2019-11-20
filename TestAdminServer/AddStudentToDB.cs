using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAdminServer
{
    public partial class AddStudentToDB : Form
    {
        public AddStudentToDB()
        {
            InitializeComponent();
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
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxLogin.Text) && !string.IsNullOrEmpty(textBoxPassword.Text) && !string.IsNullOrEmpty(textBoxCourse.Text) && !string.IsNullOrEmpty(textBoxGroup.Text) && !string.IsNullOrEmpty(textBoxSpecialisation.Text))
            {
                string password;
                using (MD5 md5Hash = MD5.Create())
                {
                     password = GetMd5Hash(md5Hash, textBoxPassword.Text);

                }
                using (ExamVceDB student = new ExamVceDB())
                {
                    try
                    {

                        student.Students.Add(new Student()
                        {
                            Name = textBoxName.Text,
                            Course = textBoxCourse.Text,
                            Password = password,
                            Login = textBoxLogin.Text,
                            Specialisation = textBoxSpecialisation.Text,
                            GroupName = textBoxGroup.Text

                        });
                        student.SaveChanges();
                        MessageBox.Show("Student was added");
                        textBoxCourse.Clear();
                        textBoxGroup.Clear();
                        textBoxLogin.Clear();
                        textBoxName.Clear();
                        textBoxPassword.Clear();
                        textBoxSpecialisation.Clear();
                    } catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
            }
            else
                MessageBox.Show("Заповніть всі поля");
        }
    }
}
