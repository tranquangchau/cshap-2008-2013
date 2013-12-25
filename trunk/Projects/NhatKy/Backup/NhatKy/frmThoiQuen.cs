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
    public partial class frmThoiQuen : Form
    {
        public frmThoiQuen()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {

                //case 0:
                //    richTextBox1.ReadOnly = true;
                //    StreamReader sr = new StreamReader("data/thoiquenhangngay.txt");
                //    richTextBox1.Text = sr.ReadToEnd();
                //    sr.Close();                    
                //    break;
                case 1:
                    StreamReader sr1 = new StreamReader("data/thoiquenhangtuan.txt");
                    richTextBox2.Text = sr1.ReadToEnd();
                    richTextBox2.ReadOnly = true;
                    sr1.Close();                    
                    button6.Enabled = false;                    
                    break;
                case 2:
                    StreamReader sr3 = new StreamReader("data/thoiquenhangthang.txt");
                    richTextBox3.Text = sr3.ReadToEnd();
                    richTextBox3.ReadOnly = true;
                    sr3.Close();
                    button7.Enabled = false;
                    break;                    
                case 3:
                    StreamReader sr4 = new StreamReader("data/thoiquenhangnam.txt");
                    richTextBox4.Text = sr4.ReadToEnd();
                    richTextBox4.ReadOnly = true;
                    sr4.Close();
                    button8.Enabled = false;
                    break;
            }           
        }

        private void frmThoiQuen_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;            
            StreamReader sr = new StreamReader("data/thoiquenhangngay.txt");
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
            Lưu.Enabled = false;
        }
        //xu ly hang ngay
        private void button2_Click(object sender, EventArgs e)
        {                        
                richTextBox1.ReadOnly = false;
                Lưu.Enabled = true;
                button2.Enabled = false;
        }

        private void Lưu_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter("data/thoiquenhangngay.txt", false, Encoding.UTF8);
            foreach (string line in richTextBox1.Lines)
            {
                sr.WriteLine(line);
            }
            sr.Close();
            Lưu.Enabled = false;
            button2.Enabled = true;
        }
        //xu ly hang tuan
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.ReadOnly = false;
            button6.Enabled = true;
            button3.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter("data/thoiquenhangtuan.txt", false, Encoding.UTF8);
            foreach (string line in richTextBox2.Lines)
            {
                sr.WriteLine(line);
            }
            sr.Close();
            richTextBox2.ReadOnly = true;
            button6.Enabled = false;
            button3.Enabled = true;
        }

        //xu ly hang thang
        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox3.ReadOnly = false;
            button7.Enabled = true;
            button4.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter("data/thoiquenhangthang.txt", false, Encoding.UTF8);
            foreach (string line in richTextBox3.Lines)
            {
                sr.WriteLine(line);
            }
            sr.Close();
            richTextBox3.ReadOnly = true;
            button7.Enabled = false;
            button4.Enabled = true;
        }

        //xu ly hang nam
        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox4.ReadOnly = false;
            button8.Enabled = true;
            button5.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter("data/thoiquenhangnam.txt", false, Encoding.UTF8);
            foreach (string line in richTextBox4.Lines)
            {
                sr.WriteLine(line);
            }
            sr.Close();
            richTextBox4.ReadOnly = true;
            button8.Enabled = false;
            button5.Enabled = true;
        }

    }
}
