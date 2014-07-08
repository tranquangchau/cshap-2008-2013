using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 500;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            sdem1 = Int32.Parse(textBox1.Text);
            sdem = 180;
        }
        int sdem1=0;
        int sdem ;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sdem1 >= 0)
            {
                label1.Text = sdem1.ToString();
                sdem1--;
            }
            else
            {
                sdem--;
                label2.Text = demolui(sdem) + "\n " + sdem.ToString() + "\n " + (abs(sdem-180)).ToString();
                if (sdem==0)
                {
                    timer1.Stop();
                }
            }                 
        }
        private int abs(int p)
        {
            int i = p;
            if (p<0)
            i = (-p);
            return i;
        }
        int giay=0;
        int phut=0;        
        public string demolui(int i)
        {
            int i1=i;            
            
            if (i1>=60)
            {
                if (i1 / 60 == 0)
                {
                    giay = 0;
                    phut = i1 / 60;
                }
                else
                {
                   
                    giay = i1 % 60;
                    phut = i1 / 60;

                }
            }
            else
            {               
                    giay = i1;
                    phut = 0;
            }
            return phut.ToString() + ":" + giay.ToString();
        }
      
    }
}
