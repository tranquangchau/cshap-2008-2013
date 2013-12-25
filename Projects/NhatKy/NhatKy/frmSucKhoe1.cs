using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace NhatKy
{
    public partial class frmCamXuc1 : Form
    {
        public frmCamXuc1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSucKhoe1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("data/ghichepsuckhoe.txt", Encoding.Default);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Red;
        }
    }
}
