using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NhatKy
{
    public partial class frmVanHoa1 : Form
    {
        public frmVanHoa1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVanHoa1_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
            StreamReader sr = new StreamReader("data/ghichepvanhoa.txt");
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
