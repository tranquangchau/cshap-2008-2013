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
    public partial class frmGhiChep : Form
    {
        
        public frmGhiChep()
        {
            InitializeComponent();
        }

        private void frmTHOIQUEN_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("data/ghichep.txt");
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();            
            richTextBox1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (luuthoiquen())
            {
                StreamWriter sw = new StreamWriter("data/ghichep.txt",false,Encoding.UTF8);
                foreach (string line in richTextBox1.Lines)
                {
                    sw.WriteLine(line);
                }
                sw.Close();
                MessageBox.Show("Đã lưu thành công");
                button1.Text = "Đóng";
                richTextBox1.ReadOnly = true;
            }
            else
            {
                this.Close();
            }
        }

        //bool luu = false;
        private void button2_Click(object sender, EventArgs e)
        {           
            richTextBox1.ReadOnly = false;
            button1.Text = "Lưu";
        }
        public bool luuthoiquen()
        {
            if (button1.Text == "Lưu")
                return true;
            else
            return false;
        }

    }
}
