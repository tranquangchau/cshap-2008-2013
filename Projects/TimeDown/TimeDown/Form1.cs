using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeDown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.TopMost = true;
            InitializeComponent();
            panel2.Hide();
            timer1.Interval = 1000;
            label1.Text = (DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString());
            timer2.Interval = 60000;
            timer2.Start();
            //timer2.Enabled = true;
        }

        int gio, phut, giay;
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
                return;
            gio=int.Parse(this.textBox1.Text);
            phut=int.Parse(this.textBox2.Text);
            giay=int.Parse(this.textBox3.Text);
            timer1.Enabled = true;
            timer1.Start();            
            button1.Enabled = false;
            panel2.Show();
            checkBox1.Checked = true;
            textBox4.Enabled = false;
        }

        private void ghichep()
        {
            //write file, line new first, font utf8
            StreamWriter wr = new StreamWriter("filedrap.txt");
            StreamReader wd = new StreamReader("oldtask.txt");
            wr.WriteLine((DateTime.Now + " " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text), true, Encoding.UTF8);
            while (!wd.EndOfStream)
                wr.WriteLine(wd.ReadLine());
            wr.Close();
            wd.Close();
            File.Copy("filedrap.txt", "oldtask.txt", true);
        }
        //timer run sources
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(gio>=0)
            {
                if(phut>=0)
                {
                    if(giay>0)
                    {
                        giay--;
                    }
                    else
                    {
                        giay=59;
                        phut--;
                    }
                }
                    else
                    {
                        phut=59;
                        gio--;
                    }
                //this.textBox1.Text = gio.ToString();
                //this.textBox2.Text = phut.ToString();
                //this.textBox3.Text = giay.ToString();
                this.button3.Text = gio.ToString() + ":" + phut.ToString() + ":" + giay.ToString();
            }                    
                  if (gio == 0 && phut == 0 && giay == 0)                        
                    {
                        timer1.Stop();
//                        MessageBox.Show("Ket Thuc Thanh Cong","Configuration!");
                        Form3 frm = new Form3();
                        frm.Show();
                        Form1 fr = new Form1();
                        fr.Close();
                      ghichep();
                        button1.Enabled = true;
                        panel2.Hide();
                        checkBox1.Checked=false;

                        MP3Player nhac = new MP3Player();
                        nhac.Open("media.mp3");
                        nhac.Play(false);
                        textBox4.Enabled = true;
                    }
                }
        //open form2 show writed
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 ch=new Form2();
            ch.Show();
        }
        //Xu ly nut stop
        private void button2_Click(object sender, EventArgs e)
        {
            
            timer1.Stop();
            button1.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            button3.Text = "::";
            panel2.Hide();
            checkBox1.Checked = false;
            StreamWriter sr = new StreamWriter("oldtask.txt",true);
            sr.WriteLine("Fails Task" +" "+DateTime.Now);
            sr.Close();

            textBox4.Enabled = true;
        }                       
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MP3Player mp3 = new MP3Player();
            if (checkBox1.Checked==true)
            {
                mp3.Open("work.mp3");
                mp3.Play(true);
            }
            else mp3.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = (DateTime.Now.Hour.ToString()+":"+DateTime.Now.Minute.ToString());
            //timer2.Start();
        }      
    }            
}
