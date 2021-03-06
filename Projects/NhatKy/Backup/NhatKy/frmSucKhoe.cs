﻿using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NhatKy
{
    public partial class frmSucKhoe : Form
    {
        public frmSucKhoe()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSucKhoe_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("data/hdsuckhoe.txt");            
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "")
            {
                MessageBox.Show("Chua nhap gi ca");
            }
            else
            {
                StreamWriter sw = new StreamWriter("data/ghichepsuckhoe.txt", true, Encoding.UTF8);
                sw.WriteLine(DateTime.Now.ToString());
                foreach (string line in richTextBox2.Lines)
                {
                    sw.WriteLine(line);
                }
                sw.WriteLine();
                sw.Close();

                MessageBox.Show("Đã ghi chép thành công");
                richTextBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSucKhoe1 sk1 = new frmSucKhoe1();            
            sk1.Show();
            this.Close();
        }
    }
}
