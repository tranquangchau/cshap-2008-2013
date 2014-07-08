using System;
using System.Windows.Forms;
using System.IO;
/*
 * 2-7/2014 by @Chau
 * Title SoloGoal (picture show in folder)
 * IN: design 1 picturebox,1 lable
 * IN: file picture +file error
 * ACTION: Formload, click,close,max,minwindow
 * * error 
 * - file type check? -> sumfile ->loadfile
 * - sub file .thumail
 * */

namespace picgoal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        int i = 1; //first pic show.
        int k = 0; //sum file correct. (check error)     
        int k1=0;// variable drap
       //picturebox click left?? right
        //reuse function
        private void xaike(int i, PictureBox pictureBox1)
        {
            imagenext(i, pictureBox1);
            this.Text = i.ToString();
        }
        //find max file in folder (jpg,png,gif,JPG,PNG,GIF?)
        public int findk(string sz)
        {
            k1 = System.IO.Directory.GetFiles("pic", "*."+sz, SearchOption.AllDirectories).Length;
            return k1;
        }
        //show next file
        private void imagenext(int i,PictureBox pictureBoxvao)
        {
            pictureBoxvao.ImageLocation = checkfile(i); ;            
        }

        //check file type
        private string checkfile(int i)
        {
            string s1="pic/"+i;
            if (File.Exists(s1+".jpg"))
            {
                return s1 + ".jpg";
            }
            else
                if (File.Exists(s1 + ".png"))
                {
                    return s1+".png";
                }
                else
                    if (File.Exists(s1 + ".gif"))
                    {
                        return s1 + ".gif";
                    }
                    else
                        if (File.Exists(s1 + ".jpeg"))
                        {
                            return s1 + ".jpeg";
                        }
            return s1;//chage file picture error default
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            k = findk("jpg") + findk("jpeg") + findk("png") + findk("gif");
            label1.Text = k.ToString();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            label1.Hide();
            if (i == k)
            {
                xaike(i, pictureBox1);
                i = 0;
            }
            else
                xaike(i, pictureBox1);
            i++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists("pic/" + this.Text + ".txt") == false)
            {
                File.Create("pic/" + this.Text + ".txt").Close();                
            }
            //System.Diagnostics.Process.Start("pic/" + (i ).ToString() + ".txt");
            System.Diagnostics.Process.Start("pic/"+this.Text+".txt");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("D:\\Final All\\soft\\sologoal\\2014-07-08_085911.jpg");
        }
    }
}
