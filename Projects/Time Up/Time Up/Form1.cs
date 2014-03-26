using System;

using System.Windows.Forms;

namespace Time_Up
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1;
            timer1.Start();
        }

        int ngay=0, gio, phut, giay;
        private void timer1_Tick(object sender, EventArgs e)
        {
            giay++;
            if (giay > 4)
            {
                phut++;
                giay = 0;
                if (phut > 4)
                {
                    gio++;
                    phut = 0;
                    if (gio > 4)
                    {
                        ngay++;
                        gio = 0;                        
                    }
                }
            }          
                          
            if (ngay > 0)
            {
                label1.Text = (ngay.ToString() + " Day " + gio.ToString()+":"+ phut.ToString() + ":" + giay.ToString());
            }
            if (gio>0)
            {
                label1.Text = gio.ToString()+":"+(phut.ToString() + ":" + giay.ToString());
            }
            if (phut >0)
            {
                label1.Text = (phut.ToString() + ":" + giay.ToString());
            }
        }

        //int ngay,phut, giay;
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    giay++;
        //    if (giay > 29)
        //    {
        //        phut++;
        //        giay = 0;      
      
        //        if (phut > 29)
        //        {
        //            ngay++;                    
        //            phut = 0;                    
        //        }
                
        //    }
        //    if (ngay != 0)
        //    {
        //        label1.Text = (ngay.ToString() + "ngay " + ":" + phut.ToString() + ":" + giay.ToString());
        //    }
        //    else
        //    {
        //        label1.Text = (phut.ToString() + ":" + giay.ToString());
        //    }
            
        //}

    }
}
