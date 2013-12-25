using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NhatKy
{
    public partial class frmMucTieu : Form
    {
        public frmMucTieu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            button3.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter("data/muctieunganhan.txt", false, Encoding.UTF8);
            foreach (string line in richTextBox1.Lines)
            {
                sr.WriteLine(line);
            }
            sr.Close();
            richTextBox1.ReadOnly = true;
            button3.Enabled = false;
            button2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox2.ReadOnly = false;
            button5.Enabled = true;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter("data/muctieudaihan.txt", false, Encoding.UTF8);
            foreach (string line in richTextBox2.Lines)
            {
                sr.WriteLine(line);
            }
            sr.Close();
            richTextBox2.ReadOnly = true;
            button5.Enabled = false;
            button4.Enabled = true;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    StreamReader sr1 = new StreamReader("data/muctieudaihan.txt");
                    richTextBox2.Text = sr1.ReadToEnd();
                    richTextBox2.ReadOnly = true;
                    sr1.Close();
                    button5.Enabled = false; 
                    break;               
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            richTextBox1.ReadOnly = true;
            StreamReader sr = new StreamReader("data/muctieunganhan.txt");
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
            button3.Enabled = false;
        }
    }
}
