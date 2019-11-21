namespace TestAdminServer
{
    partial class MainForm
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
            this.buttonStartServer = new System.Windows.Forms.Button();
            this.labelStatusServer = new System.Windows.Forms.Label();
            this.labelActing = new System.Windows.Forms.Label();
            this.comboBoxAct = new System.Windows.Forms.ComboBox();
            this.labelWhoIs = new System.Windows.Forms.Label();
            this.listBoxExam = new System.Windows.Forms.ListBox();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonShowPassExam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.buttonStartServer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelActing, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxAct, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelStatusServer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelWhoIs, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.listViewUsers, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.listBoxExam, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonShowPassExam, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSend, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 309);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // buttonStartServer
            // 
            this.buttonStartServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStartServer.Location = new System.Drawing.Point(3, 3);
            this.buttonStartServer.Name = "buttonStartServer";
            this.buttonStartServer.Size = new System.Drawing.Size(117, 32);
            this.buttonStartServer.TabIndex = 1;
            this.buttonStartServer.Text = "Start server";
            this.buttonStartServer.UseVisualStyleBackColor = true;
            this.buttonStartServer.Click += new System.EventHandler(this.buttonStartServer_Click);
            // 
            // labelStatusServer
            // 
            this.labelStatusServer.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelStatusServer, 2);
            this.labelStatusServer.Location = new System.Drawing.Point(126, 0);
            this.labelStatusServer.Name = "labelStatusServer";
            this.labelStatusServer.Size = new System.Drawing.Size(54, 13);
            this.labelStatusServer.TabIndex = 2;
            this.labelStatusServer.Text = "Server is :";
            this.labelStatusServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelActing
            // 
            this.labelActing.AutoSize = true;
            this.labelActing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelActing.Location = new System.Drawing.Point(3, 38);
            this.labelActing.Name = "labelActing";
            this.labelActing.Size = new System.Drawing.Size(79, 16);
            this.labelActing.TabIndex = 4;
            this.labelActing.Text = "Choose act:";
            // 
            // comboBoxAct
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.comboBoxAct, 2);
            this.comboBoxAct.FormattingEnabled = true;
            this.comboBoxAct.Location = new System.Drawing.Point(126, 41);
            this.comboBoxAct.Name = "comboBoxAct";
            this.comboBoxAct.Size = new System.Drawing.Size(178, 21);
            this.comboBoxAct.TabIndex = 6;
            this.comboBoxAct.SelectedIndexChanged += new System.EventHandler(this.comboBoxAct_SelectedIndexChanged);
            // 
            // labelWhoIs
            // 
            this.labelWhoIs.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelWhoIs, 3);
            this.labelWhoIs.Location = new System.Drawing.Point(372, 0);
            this.labelWhoIs.Name = "labelWhoIs";
            this.labelWhoIs.Size = new System.Drawing.Size(49, 13);
            this.labelWhoIs.TabIndex = 3;
            this.labelWhoIs.Text = "Who is ?";
            // 
            // listBoxExam
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.listBoxExam, 2);
            this.listBoxExam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxExam.Enabled = false;
            this.listBoxExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxExam.FormattingEnabled = true;
            this.listBoxExam.ItemHeight = 16;
            this.listBoxExam.Location = new System.Drawing.Point(495, 117);
            this.listBoxExam.Name = "listBoxExam";
            this.tableLayoutPanel1.SetRowSpan(this.listBoxExam, 5);
            this.listBoxExam.Size = new System.Drawing.Size(244, 189);
            this.listBoxExam.TabIndex = 9;
            this.listBoxExam.SelectedIndexChanged += new System.EventHandler(this.ListBoxExam_SelectedIndexChanged);
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.tableLayoutPanel1.SetColumnSpan(this.listViewUsers, 4);
            this.listViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUsers.HideSelection = false;
            this.listViewUsers.Location = new System.Drawing.Point(3, 117);
            this.listViewUsers.Name = "listViewUsers";
            this.tableLayoutPanel1.SetRowSpan(this.listViewUsers, 5);
            this.listViewUsers.Size = new System.Drawing.Size(486, 189);
            this.listViewUsers.TabIndex = 10;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            this.listViewUsers.SelectedIndexChanged += new System.EventHandler(this.ListViewUsers_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Login";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Course";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(372, 79);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(117, 23);
            this.buttonSend.TabIndex = 11;
            this.buttonSend.Text = "Надіслати екзамен ";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // buttonShowPassExam
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.buttonShowPassExam, 3);
            this.buttonShowPassExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowPassExam.Location = new System.Drawing.Point(372, 41);
            this.buttonShowPassExam.Name = "buttonShowPassExam";
            this.buttonShowPassExam.Size = new System.Drawing.Size(270, 28);
            this.buttonShowPassExam.TabIndex = 12;
            this.buttonShowPassExam.Text = "показати здані екзамени";
            this.buttonShowPassExam.UseVisualStyleBackColor = true;
            this.buttonShowPassExam.Click += new System.EventHandler(this.ButtonShowPassExam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(495, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Спосок Тестів";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label3, 2);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Список студентів";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 309);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonStartServer;
        private System.Windows.Forms.Label labelStatusServer;
        private System.Windows.Forms.Label labelWhoIs;
        private System.Windows.Forms.Label labelActing;
        private System.Windows.Forms.ComboBox comboBoxAct;
        private System.Windows.Forms.ListBox listBoxExam;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonShowPassExam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

