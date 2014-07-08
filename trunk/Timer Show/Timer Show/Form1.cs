// Code by chau tran-Nghe an: Date create 17/04/2014
// Project Timer Show txt, photo
// Project Goal learning english

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Timer_Show
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 2000;
            timer1.Start();
            button1.Hide();            
            this.TopMost = true;
        }
        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {            
            
            string s1 = linefile(i).Trim();
            string s2;
            string filepic;                        
            //xu ly link file anh.
            if (s1.IndexOf(" ") == -1)
            {
                filepic = "File/" + taolink(s1).ToString() + ".gif";
                label1.Text = s1.ToString();
                label2.Text = s1.ToString();
                label3.Text = daochuoi(s1);
            }
            else
            {
                s2 = s1.Substring(0,s1.IndexOf(" "));
                filepic = "File/" + taolink(s2).ToString()+ ".gif";
                label1.Text = s2.ToString();
                label2.Text=(s1.Substring(s1.IndexOf(" "),s1.Length-s1.IndexOf(" "))).ToString();
                label3.Text = daochuoi(s2);
            }            
            //label1.Text = filepic;

            // Kiem tra file anh co ton tai hay khong va xu dep no
            if (File.Exists(filepic))
            {
                pictureBox1.Image = Image.FromFile(filepic);
            }
            else
                pictureBox1.Image = Image.FromFile("File/error-404.jpg");
            
            if (i > k - 2)
            {
                timer1.Stop(); 
                //MessageBox.Show("End");
                button1.Show();
                button2.Hide();
            }            
            i++;
        }

        private string daochuoi(string s1)
        {
            string s2="";
            for (int i1 = 0; i1 < s1.Length; i1++)
            {
                s2=s2+ s1[s1.Length - i1 - 1].ToString();
            }
            return s2;             
        }
        int k;
        private string linefile(int j)
        {
            string[] st = File.ReadAllLines("data.txt");
            k = st.Length;
            return st[j];
        }
        public string taolink(string st)
        {
            string sr=st.Substring(0,1).ToLower();
            string sout="";
            switch (sr)
            {
                case "a":
                    sout = "a-file/" + st;
                    break;
                case "b":
                    sout = "b-file/" + st;
                    break;
                case "c":
                    sout = "c-file/" + st;
                    break;
                case "d":
                    sout = "d-file/" + st;
                    break;
                case "e":
                    sout = "e-file/" + st;
                    break;
                case "f":
                    sout = "f-file/" + st;
                    break;
                case "g":
                    sout = "g-file/" + st;
                    break;
                case "h":
                    sout = "h-file/" + st;
                    break;
                case "i":
                    sout = "i-file/" + st;
                    break;
                case "j":
                    sout = "j-file/" + st;
                    break;
                case "k":
                    sout = "k-file/" + st;
                    break;
                case "l":
                    sout = "l-file/" + st;
                    break;
                case "m":
                    sout = "m-file/" + st;
                    break;
                case "n":
                    sout = "n-file/" + st;
                    break;
                case "o":
                    sout = "o-file/" + st;
                    break;
                case "p":
                    sout = "p-file/" + st;
                    break;
                case "q":
                    sout = "q-file/" + st;
                    break;
                case "r":
                    sout = "r-file/" + st;
                    break;
                case "s":
                    sout = "s-file/" + st;
                    break;
                case "t":
                    sout = "t-file/" + st;
                    break;
                case "u":
                    sout = "u-file/" + st;
                    break;
                case "v":
                    sout = "v-file/" + st;
                    break;
                case "w":
                    sout = "w-file/" + st;
                    break;
                case "x":
                    sout = "x-file/" + st;
                    break;
                case "y":
                    sout = "y-file/" + st;
                    break;
                case "z":
                    sout = "z-file/" + st;
                    break;
            }
            return sout;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            timer1.Start();
            button2.Show();
            i = 0;
        }
        bool pau = true;
        private void button2_Click(object sender, EventArgs e)
        {
            if (pau == true)
            {
                timer1.Enabled = false;
                pau = false;
                button2.Text = "P";
            }
            else
            {
                timer1.Enabled = true;
                pau = true;
                button2.Text = "pause";
            }
        }
    }
}
