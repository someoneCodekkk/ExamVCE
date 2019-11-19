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
    public partial class AddStudentToDB : Form
    {
        public AddStudentToDB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text) && !string.IsNullOrEmpty(textBoxLogin.Text) && !string.IsNullOrEmpty(textBoxPassword.Text) && !string.IsNullOrEmpty(textBoxCourse.Text) && !string.IsNullOrEmpty(textBoxGroup.Text) && !string.IsNullOrEmpty(textBoxSpecialisation.Text))
                using (ExamVceDB student = new ExamVceDB())
                {
                    try
                    {
                        student.Students.Add(new Student()
                        {
                            Name = textBoxName.Text,
                            Course = textBoxCourse.Text,
                            Password = textBoxPassword.Text,
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
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                    
                }
            else
                MessageBox.Show("Заповніть всі поля");
        }
    }
}
