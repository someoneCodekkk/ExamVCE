namespace ExamVCE
{
    partial class TestDesigner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelCondition = new System.Windows.Forms.Label();
            this.textBoxCondition = new System.Windows.Forms.TextBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.numericUpDownCost = new System.Windows.Forms.NumericUpDown();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.checkBoxIsCorrectAnswer = new System.Windows.Forms.CheckBox();
            this.buttonNewAsk = new System.Windows.Forms.Button();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.buttonNextAnswer = new System.Windows.Forms.Button();
            this.checkedListBoxAnswer = new System.Windows.Forms.CheckedListBox();
            this.labelReadyCondition = new System.Windows.Forms.Label();
            this.buttonCreateXml = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.labelCondition, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCondition, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxQuestion, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDownCost, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelAnswer, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxAnswer, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxIsCorrectAnswer, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonNewAsk, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonAddQuestion, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonNextAnswer, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.checkedListBoxAnswer, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelReadyCondition, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonCreateXml, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 258);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelCondition
            // 
            this.labelCondition.AutoSize = true;
            this.labelCondition.Location = new System.Drawing.Point(339, 0);
            this.labelCondition.Name = "labelCondition";
            this.labelCondition.Size = new System.Drawing.Size(44, 13);
            this.labelCondition.TabIndex = 0;
            this.labelCondition.Text = "Умова:";
            // 
            // textBoxCondition
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxCondition, 2);
            this.textBoxCondition.Location = new System.Drawing.Point(451, 3);
            this.textBoxCondition.Name = "textBoxCondition";
            this.textBoxCondition.Size = new System.Drawing.Size(218, 20);
            this.textBoxCondition.TabIndex = 1;
            this.textBoxCondition.TextChanged += new System.EventHandler(this.textBoxCondition_TextChanged);
            // 
            // textBoxQuestion
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxQuestion, 3);
            this.textBoxQuestion.Enabled = false;
            this.textBoxQuestion.Location = new System.Drawing.Point(3, 3);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.tableLayoutPanel1.SetRowSpan(this.textBoxQuestion, 4);
            this.textBoxQuestion.Size = new System.Drawing.Size(330, 138);
            this.textBoxQuestion.TabIndex = 7;
            // 
            // numericUpDownCost
            // 
            this.numericUpDownCost.Location = new System.Drawing.Point(675, 3);
            this.numericUpDownCost.Name = "numericUpDownCost";
            this.numericUpDownCost.Size = new System.Drawing.Size(106, 20);
            this.numericUpDownCost.TabIndex = 2;
            // 
            // labelAnswer
            // 
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Location = new System.Drawing.Point(339, 36);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(57, 13);
            this.labelAnswer.TabIndex = 0;
            this.labelAnswer.Text = "Відповідь:";
            // 
            // textBoxAnswer
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxAnswer, 2);
            this.textBoxAnswer.Location = new System.Drawing.Point(451, 39);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(218, 20);
            this.textBoxAnswer.TabIndex = 5;
            // 
            // checkBoxIsCorrectAnswer
            // 
            this.checkBoxIsCorrectAnswer.AutoSize = true;
            this.checkBoxIsCorrectAnswer.Location = new System.Drawing.Point(675, 39);
            this.checkBoxIsCorrectAnswer.Name = "checkBoxIsCorrectAnswer";
            this.checkBoxIsCorrectAnswer.Size = new System.Drawing.Size(70, 17);
            this.checkBoxIsCorrectAnswer.TabIndex = 9;
            this.checkBoxIsCorrectAnswer.Text = "is Correct";
            this.checkBoxIsCorrectAnswer.UseVisualStyleBackColor = true;
            // 
            // buttonNewAsk
            // 
            this.buttonNewAsk.Location = new System.Drawing.Point(115, 183);
            this.buttonNewAsk.Name = "buttonNewAsk";
            this.buttonNewAsk.Size = new System.Drawing.Size(106, 23);
            this.buttonNewAsk.TabIndex = 6;
            this.buttonNewAsk.Text = "Нове запитання";
            this.buttonNewAsk.UseVisualStyleBackColor = true;
            this.buttonNewAsk.Click += new System.EventHandler(this.buttonNewAsk_Click);
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Location = new System.Drawing.Point(227, 183);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(106, 23);
            this.buttonAddQuestion.TabIndex = 8;
            this.buttonAddQuestion.Text = "Добавити запитання";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // buttonNextAnswer
            // 
            this.buttonNextAnswer.Location = new System.Drawing.Point(675, 219);
            this.buttonNextAnswer.Name = "buttonNextAnswer";
            this.buttonNextAnswer.Size = new System.Drawing.Size(109, 27);
            this.buttonNextAnswer.TabIndex = 6;
            this.buttonNextAnswer.Text = "Записати";
            this.buttonNextAnswer.UseVisualStyleBackColor = true;
            this.buttonNextAnswer.Click += new System.EventHandler(this.buttonNextAnswer_Click);
            // 
            // checkedListBoxAnswer
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.checkedListBoxAnswer, 4);
            this.checkedListBoxAnswer.Enabled = false;
            this.checkedListBoxAnswer.FormattingEnabled = true;
            this.checkedListBoxAnswer.Location = new System.Drawing.Point(339, 111);
            this.checkedListBoxAnswer.Name = "checkedListBoxAnswer";
            this.tableLayoutPanel1.SetRowSpan(this.checkedListBoxAnswer, 3);
            this.checkedListBoxAnswer.Size = new System.Drawing.Size(445, 94);
            this.checkedListBoxAnswer.TabIndex = 10;
            this.checkedListBoxAnswer.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxAnswer_SelectedIndexChanged);
            // 
            // labelReadyCondition
            // 
            this.labelReadyCondition.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelReadyCondition, 3);
            this.labelReadyCondition.Location = new System.Drawing.Point(339, 72);
            this.labelReadyCondition.Name = "labelReadyCondition";
            this.labelReadyCondition.Size = new System.Drawing.Size(51, 13);
            this.labelReadyCondition.TabIndex = 11;
            this.labelReadyCondition.Text = "Condition";
            // 
            // buttonCreateXml
            // 
            this.buttonCreateXml.Location = new System.Drawing.Point(3, 183);
            this.buttonCreateXml.Name = "buttonCreateXml";
            this.buttonCreateXml.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateXml.TabIndex = 12;
            this.buttonCreateXml.Text = "Save";
            this.buttonCreateXml.UseVisualStyleBackColor = true;
            this.buttonCreateXml.Click += new System.EventHandler(this.buttonCreateXml_Click);
            // 
            // TestDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 258);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TestDesigner";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelCondition;
        private System.Windows.Forms.TextBox textBoxCondition;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label labelAnswer;
        private System.Windows.Forms.Button buttonNewAsk;
        private System.Windows.Forms.Button buttonNextAnswer;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.NumericUpDown numericUpDownCost;
        private System.Windows.Forms.CheckBox checkBoxIsCorrectAnswer;
        private System.Windows.Forms.CheckedListBox checkedListBoxAnswer;
        private System.Windows.Forms.Label labelReadyCondition;
        private System.Windows.Forms.Button buttonCreateXml;
    }
}

