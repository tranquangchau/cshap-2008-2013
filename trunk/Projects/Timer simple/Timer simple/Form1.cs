using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int i=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            label1.Text = i.ToString();
            i--;
            if (i == 0)
            {
                timer1.Enabled = false;
                label1.Text = "Het Gio";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = 10;
            timer1.Enabled = true;
        }
    }
}
