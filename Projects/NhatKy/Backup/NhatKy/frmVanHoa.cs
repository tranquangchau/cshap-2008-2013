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
    public partial class frmVanHoa : Form
    {
        public frmVanHoa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmVanHoa_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("data/hdvanhoa.txt");
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
                StreamWriter sw = new StreamWriter("data/ghichepvanhoa.txt", true, Encoding.UTF8);
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
            frmVanHoa1 vh = new frmVanHoa1();
            vh.Show();
            this.Close();
        }
    }
}
