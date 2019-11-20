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
    }
}

