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
                foreach (var item in pass.PassExams)
                {
                    ListViewItem i = new ListViewItem(item.ID.ToString());
                    i.SubItems.Add(pass.Students.Where(q => q.ID == item.Id_Student).First().Name);
                    //i.SubItems.Add(item.Id_Student.ToString());
                    MakeTest test = DeserialiseFromString(pass.TestDBs.First(q => q.ID == item.Id_Test).Test);
                    i.SubItems.Add(test.Subject);
                    //i.SubItems.Add(item.Id_Test.ToString());
                    i.SubItems.Add(item.Date_Pass.ToString());
                    i.SubItems.Add(item.Mark.ToString());

                    listViewPassExam.Items.Add(i);
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
