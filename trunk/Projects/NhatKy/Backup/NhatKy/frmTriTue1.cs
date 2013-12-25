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
    public partial class frmTriTue1 : Form
    {
        public frmTriTue1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTriTue1_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
            StreamReader sr = new StreamReader("data/ghicheptritue.txt");
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }
    }
}
