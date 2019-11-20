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
using System.Xml;
using System.Xml.Serialization;
using LibraryForTest;

namespace ExamVCE
{
    public partial class TestDesigner : Form
    {
        List<MakeTest> tests = new List<MakeTest>();
        List<Question> questions = new List<Question>();
        List<List<Answer>> packageAnswer = new List<List<Answer>>();
        public TestDesigner()
        {
            InitializeComponent();

           
        }
    
        private void buttonNextAnswer_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxCondition.Text))
            {
                if(!string.IsNullOrEmpty(textBoxAnswer.Text))
                {
                    checkedListBoxAnswer.Items.Add(textBoxAnswer.Text, checkBoxIsCorrectAnswer.Checked);
                    
                    packageAnswer[packageAnswer.Count - 1].Add(new Answer() 
                    {
                        Question = textBoxAnswer.Text,
                        IsCorrect = checkBoxIsCorrectAnswer.Checked
                    });
                }
            }
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {

            buttonNewAsk.Enabled = true;
            buttonNextAnswer.Enabled = false;
            buttonAddQuestion.Enabled = false;


            textBoxAnswer.Enabled = false;
            textBoxCondition.Enabled = false;
            numericUpDownCost.Enabled = !true;
            checkBoxIsCorrectAnswer.Enabled = !true;

            questions.Add(new Question { Condition = textBoxCondition.Text, answers = packageAnswer[packageAnswer.Count - 1], Weight = (int)numericUpDownCost.Value });
            tests.Clear();

            textBoxQuestion.Clear();
            tests.Add(new MakeTest() { NameTeacher = "Melnychuk Vasyl", questions = questions, Subject = "Programing" });
            foreach (var test in tests)
            {
                textBoxQuestion.Text += $"Subject: {test.Subject} Name: {test.NameTeacher}";
                textBoxQuestion.Text += '\n';
                foreach (var q in test.questions)
                {
                    textBoxQuestion.Text += $"Question: {q.Condition} Mark: {q.Weight}";
                    textBoxQuestion.Text += '\n';
                    foreach (var a in q.answers)
                    {
                        textBoxQuestion.Text += $"Anser: {a.Question} : is correct {a.IsCorrect}";
                        textBoxQuestion.Text += '\n';
                    }
                    textBoxQuestion.Text += '\n';
                }
            }
            checkedListBoxAnswer.Items.Clear();
        }

        private void buttonNewAsk_Click(object sender, EventArgs e)
        {
            packageAnswer.Add(new List<Answer>());
            buttonAddQuestion.Enabled = true;
            buttonNextAnswer.Enabled = true;
            buttonNewAsk.Enabled = false;

            textBoxAnswer.Enabled = true;
            textBoxCondition.Enabled = true;
            numericUpDownCost.Enabled = true;
            checkBoxIsCorrectAnswer.Enabled = true;
        }

        

        private void checkedListBoxAnswer_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(checkedListBoxAnswer.SelectedItem.ToString());
        }

        private void textBoxCondition_TextChanged(object sender, EventArgs e)
        {
            labelReadyCondition.Text = textBoxCondition.Text;
        }

        private void buttonCreateXml_Click(object sender, EventArgs e)
        {
            try
            {
                var xmlSerializer = new XmlSerializer(typeof(MakeTest));
                var stringWriter = new StringWriter();
                xmlSerializer.Serialize(stringWriter, tests[0]);
                SaveFileDialog save = new SaveFileDialog();
                save.ShowDialog();
                save.Filter = "Data Files (*.xml)|*.xml";
                save.DefaultExt = "xml";
                save.AddExtension = true;
                File.WriteAllText(save.FileName, stringWriter.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
