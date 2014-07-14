using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test_splitercontener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            richTextBox1.Hide();
        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Hide();
        }

        private void toolStripStatusLabel1_Click_2(object sender, EventArgs e)
        {
          // groupBox1.Hide();
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            //groupBox1.Show();
        }

        private void toolStripStatusLabel1_Click_3(object sender, EventArgs e)
        {
            panel4.Hide();
           
        }

        private void toolStripStatusLabel2_Click_1(object sender, EventArgs e)
        {
            panel4.Show();
        }
    }
}
