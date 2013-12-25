using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // Kiểm tra có file đề bài quiz.txt hay chưa
            if (!File.Exists("quiz.txt"))
            {
                MessageBox.Show("Chưa có file quiz.txt trong thư mục gốc");
                return;
            }
            //cho phép mở Form2
            Form2 fr2 = new Form2();
            fr2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 fr = new Form4();
            fr.Show();
        }
    }
}
