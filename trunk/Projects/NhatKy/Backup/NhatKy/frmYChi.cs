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
    public partial class frmYChi : Form
    {
        public frmYChi()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmYChi1 yc = new frmYChi1();
            yc.Show();
            this.Close();
        }

        private void frmYChi_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("data/hdychi.txt");
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "")
            {
                MessageBox.Show("Chua nhap gi ca");
            }
            else
            {
                StreamWriter sw = new StreamWriter("data/ghichepychi.txt", true, Encoding.UTF8);
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
    }
}
