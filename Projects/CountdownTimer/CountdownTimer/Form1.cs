using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CountdownTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public int seconds;
        public int minutes;
        public int hours;
        public bool paused;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //xy ly paused van co the tiep tuc chay tiep
            if (paused !=true)
            {
                //kiem tra chuoi nhap vao the nao
                if((textBox1.Text!="")&&(textBox2.Text!="")&&(textBox3.Text!=""))
                {
                    timer1.Enabled=true;
                    button1.Enabled=false;
                    button2.Enabled=true;
                    button3.Enabled=true;
                    textBox1.Enabled=false;
                    textBox2.Enabled=false;
                    textBox3.Enabled=false;
                    textBox4.Enabled=false;
                    try
                    {
                        minutes=System.Convert.ToInt32(textBox2.Text);
                        seconds=System.Convert.ToInt32(textBox3.Text);
                        hours=System.Convert.ToInt32(textBox1.Text);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Incomplete Setting!");
                }
            }
            else
            {
                timer1.Enabled=true;
                paused=false;
                button2.Enabled=true;
                button1.Enabled=false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Pause the timer.
            timer1.Enabled = false;
            paused = true;
            button1.Enabled = true;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Stop the timer
            paused = false;
            timer1.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = false;
            button2.Enabled = false;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            lblHr.Text = "00";
            lblMin.Text = "00";
            lblSec.Text = "00";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Veryfy if the time didn't pass.
            if ((minutes == 0) && (seconds == 0) && (hours == 0))
            {
                //if the time is over, clear all setting and fields.
                //Also, show the message, notying that the time is over.
                timer1.Enabled = false;
                MessageBox.Show(textBox4.Text);
                button1.Enabled = true;
                button3.Enabled = false;
                button2.Enabled = false;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                lblHr.Text = "00";
                lblMin.Text = "00";
                lblSec.Text = "00";
            }
            else
            {
                //else contiue conuting.
                if (seconds < 1)
                {
                    seconds = 59;
                    if (minutes == 0)
                    {
                        minutes = 59;
                        if (hours != 0)
                            hours -= 1;
                    }
                    else
                    {
                        minutes -= 1;
                    }
                }
                else
                    seconds -= 1;
                // Display the current values of hourse
                //the corresponding files.
                lblHr.Text = hours.ToString();
                lblMin.Text = minutes.ToString();
                lblSec.Text = seconds.ToString();
            }
        }
    }
}
