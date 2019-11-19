using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClient
{
    public partial class ChooseServer : Form
    {
        public string ipAddressServer { get; set; }
        public ChooseServer()
        {
            InitializeComponent();
            Controls.SetChildIndex(pictureBox1, -1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ipAddressServer = textBox1.Text;
            this.Close();
        }
    }
}
