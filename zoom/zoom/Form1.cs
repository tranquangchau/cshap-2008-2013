using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace zoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool bl = true;
        int i1;
        int i2;
        private void Form1_Load(object sender, EventArgs e)
        {
           pictureBox1.Image = Image.FromFile("22.jpeg");
           i1 = Image.FromFile("22.jpeg").Height;
           i2 = Image.FromFile("22.jpeg").Width;
           //MessageBox.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
            if (bl == true)
            {
                pictureBox1.Height = panel1.Height;
                pictureBox1.Width = panel1.Width;
                bl = false;
                pictureBox1.Top=0;
                pictureBox1.Left = 0;
            }
            else
            {
                pictureBox1.Height = i1;
                pictureBox1.Width = i2;
                bl = true;
            }
        }
    }
}
