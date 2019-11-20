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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSendToUser = new System.Windows.Forms.TextBox();
            this.listBoxExam = new System.Windows.Forms.ListBox();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonShowPassExam = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.buttonStartServer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelStatusServer, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelActing, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxAct, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelWhoIs, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSendToUser, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.listBoxExam, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.listViewUsers, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonSend, 4, 7);
            this.tableLayoutPanel1.Controls.Add(this.buttonShowPassExam, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(742, 309);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            // 
            // buttonStartServer
            // 
            this.buttonStartServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStartServer.Location = new System.Drawing.Point(3, 3);
            this.buttonStartServer.Name = "buttonStartServer";
            this.buttonStartServer.Size = new System.Drawing.Size(86, 28);
            this.buttonStartServer.TabIndex = 1;
            this.buttonStartServer.Text = "Start server";
            this.buttonStartServer.UseVisualStyleBackColor = true;
            this.buttonStartServer.Click += new System.EventHandler(this.buttonStartServer_Click);
            // 
            // labelStatusServer
            // 
            this.labelStatusServer.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelStatusServer, 2);
            this.labelStatusServer.Location = new System.Drawing.Point(95, 0);
            this.labelStatusServer.Name = "labelStatusServer";
            this.labelStatusServer.Size = new System.Drawing.Size(54, 13);
            this.labelStatusServer.TabIndex = 2;
            this.labelStatusServer.Text = "Server is :";
            this.labelStatusServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelActing
            // 
            this.labelActing.AutoSize = true;
            this.labelActing.Location = new System.Drawing.Point(3, 34);
            this.labelActing.Name = "labelActing";
            this.labelActing.Size = new System.Drawing.Size(64, 13);
            this.labelActing.TabIndex = 4;
            this.labelActing.Text = "Choose act:";
            // 
            // comboBoxAct
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.comboBoxAct, 2);
            this.comboBoxAct.FormattingEnabled = true;
            this.comboBoxAct.Location = new System.Drawing.Point(3, 71);
            this.comboBoxAct.Name = "comboBoxAct";
            this.comboBoxAct.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAct.TabIndex = 6;
            this.comboBoxAct.SelectedIndexChanged += new System.EventHandler(this.comboBoxAct_SelectedIndexChanged);
            // 
            // labelWhoIs
            // 
            this.labelWhoIs.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelWhoIs, 4);
            this.labelWhoIs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWhoIs.Location = new System.Drawing.Point(371, 0);
            this.labelWhoIs.Name = "labelWhoIs";
            this.labelWhoIs.Size = new System.Drawing.Size(368, 34);
            this.labelWhoIs.TabIndex = 3;
            this.labelWhoIs.Text = "Who is ?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Send to:";
            // 
            // textBoxSendToUser
            // 
            this.textBoxSendToUser.Location = new System.Drawing.Point(3, 139);
            this.textBoxSendToUser.Name = "textBoxSendToUser";
            this.textBoxSendToUser.Size = new System.Drawing.Size(86, 20);
            this.textBoxSendToUser.TabIndex = 8;
            // 
            // listBoxExam
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.listBoxExam, 2);
            this.listBoxExam.Enabled = false;
            this.listBoxExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxExam.FormattingEnabled = true;
            this.listBoxExam.ItemHeight = 16;
            this.listBoxExam.Location = new System.Drawing.Point(555, 71);
            this.listBoxExam.Name = "listBoxExam";
            this.tableLayoutPanel1.SetRowSpan(this.listBoxExam, 5);
            this.listBoxExam.Size = new System.Drawing.Size(184, 164);
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
            this.listViewUsers.Location = new System.Drawing.Point(187, 71);
            this.listViewUsers.Name = "listViewUsers";
            this.tableLayoutPanel1.SetRowSpan(this.listViewUsers, 5);
            this.listViewUsers.Size = new System.Drawing.Size(362, 164);
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
            this.buttonSend.Location = new System.Drawing.Point(371, 241);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(86, 23);
            this.buttonSend.TabIndex = 11;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // buttonShowPassExam
            // 
            this.buttonShowPassExam.Location = new System.Drawing.Point(3, 173);
            this.buttonShowPassExam.Name = "buttonShowPassExam";
            this.buttonShowPassExam.Size = new System.Drawing.Size(86, 23);
            this.buttonShowPassExam.TabIndex = 12;
            this.buttonShowPassExam.Text = "show pass exam";
            this.buttonShowPassExam.UseVisualStyleBackColor = true;
            this.buttonShowPassExam.Click += new System.EventHandler(this.ButtonShowPassExam_Click);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSendToUser;
        private System.Windows.Forms.ListBox listBoxExam;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonShowPassExam;
    }
}

