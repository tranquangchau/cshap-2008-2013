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
    public partial class frmKienThuc : Form
    {
        public frmKienThuc()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKienThuc_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("data/hdkienthuc.txt");
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKienThuc1 fr = new frmKienThuc1();
            fr.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox2.Text == "")
            {
                MessageBox.Show("Chua nhap gi ca");
            }
            else
            {
                StreamWriter sw = new StreamWriter("data/ghichepkienthuc.txt", true, Encoding.UTF8);
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
