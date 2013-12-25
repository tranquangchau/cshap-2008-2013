using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winform
{
    public partial class F_DemNguoc : Form
    {
        int i = 100;
        public F_DemNguoc()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //tu dong chay
            //label1.Text = i.ToString();
            //i--;
            //if (i <= 90) 
            //{
            //    label1.Text = "Chúc";
            //    timer1.Enabled = false;
            //}

            //label1.Text = i.ToString();
            i--;
            if (i == 80)
            {
                label1.Text = "Chúc";
                //timer1.Enabled = false;
            }
            if (i < 60)
            {
                label2.Text = "Mừng";
                label1.Text = null;
                //timer1.Enabled = false;
            }
            if (i < 40)
            {
                label3.Text = "Năm";
                label2.Text = null;
                // timer1.Enabled = false;
            }
            if (i < 20)
            {
                label4.Text = "Mới";

                label3.Text = null;
            }
            if (i < 0)
            {
                label5.Text = "2014";
                timer1.Enabled = false;
                label4.Text = null;
            }

        }


    }
}
