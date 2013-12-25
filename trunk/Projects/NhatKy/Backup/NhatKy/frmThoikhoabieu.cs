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
    public partial class frmThoikhoabieu : Form
    {
        public frmThoikhoabieu()
        {
            InitializeComponent();
        }

        private void frmThoikhoabieu_Load(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = true;
            StreamReader sr = new StreamReader("data/thoikhoabieu.txt");
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            button1.Text = "Lưu";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Close")
            {
                this.Close();
            }
            else
            {
                StreamWriter sw = new StreamWriter("data/thoikhoabieu.txt", false, Encoding.UTF8);
                foreach (string line in richTextBox1.Lines)
                    sw.WriteLine(line);
                sw.Close();
                button1.Text = "Close";
                richTextBox1.ReadOnly = true;
                MessageBox.Show("Lưu Thành Công");
            }
        }
    }
}
