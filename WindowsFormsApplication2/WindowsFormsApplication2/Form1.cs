using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {

                case 0:
                    richTextBox1.ReadOnly = true;
                    //richTextBox1.Enabled = false;
                    StreamReader sr = new StreamReader("data/1.txt");
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Close();
                    button2.Enabled = false;
                    button1.Enabled = true;
                    break;
                case 1:
                    StreamReader sr1 = new StreamReader("data/2.txt");
                    richTextBox2.Text = sr1.ReadToEnd();
                    richTextBox2.ReadOnly = true;
                    sr1.Close();
                    
                    break;
                case 2:
                    StreamReader sr3 = new StreamReader("data/3.txt");
                    richTextBox3.Text = sr3.ReadToEnd();
                    richTextBox3.ReadOnly = true;
                    sr3.Close();
                    break;
                case 3:
                    StreamReader sr4 = new StreamReader("data/4.txt");
                    richTextBox4.Text = sr4.ReadToEnd();
                    richTextBox4.ReadOnly = true;
                    sr4.Close();                    
                    break;
            }           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1_SelectedIndexChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter("data/1.txt", false, Encoding.UTF8);
            foreach (string line in richTextBox1.Lines)
            {
                sr.WriteLine(line);
            }
            sr.Close();
            button2.Enabled = false;
            button1.Enabled = true;
        }
    }
}
