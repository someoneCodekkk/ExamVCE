using LibraryForTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TestAdminServer
{
    public partial class PassExams : Form
    {
        public PassExams()
        {
            InitializeComponent();
            FillTable();
        }
        void FillTable()
        {
            using(ExamVceDB pass = new ExamVceDB())
            {
                //var query = pass.PassExams.Join(pass.Students, c => c.Student.Name);
                foreach (var item in pass.PassExams)
                {
                    try
                    {

                        ListViewItem i = new ListViewItem(item.ID.ToString());
                        var studentName = pass.Students.Where(q => q.ID == item.Id_Student).ToList();
                        i.SubItems.Add(studentName[0].Name);
                        string testForm = pass.TestDBs.First(q => q.ID == item.Id_Test).Test;
                        MakeTest test = DeserialiseFromString(testForm);
                        i.SubItems.Add(test.Subject);
                        i.SubItems.Add(item.Date_Pass.ToString());
                        i.SubItems.Add(item.Mark.ToString());

                        listViewPassExam.Items.Add(i);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
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
    }
}
