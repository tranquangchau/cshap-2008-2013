using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Test_nhac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = load1(i);
            //label1.BackColor = Color.LightCoral;
            colorrandom(label1);
            if (i == k-1)
            {
                label1.Text = "♥♥♥♥♥♥♥♥♥----- Hãy Về Đây Bên Anh ??";
                label1.BackColor = Color.Khaki;
                return;                
            }
            else
                i++;            
        }
        private void colorrandom(Label label1)
        {
            Random rd = new Random();
            int r1=rd.Next(1,6);
            
            switch (r1)
            {
                case 1:
                    label1.BackColor = Color.DarkOrange;
                    break;               
                case 2:
                    label1.BackColor = Color.Cyan;
                    break;
                case 3:
                    label1.BackColor = Color.Cornsilk;
                    break;                
                case 4:
                    label1.BackColor = Color.Coral;
                    break;                
                case 5:
                    label1.BackColor = Color.Chartreuse;
                    break;
                default:
                    label1.BackColor = Color.HotPink;
                    break;
            }
        }
        int k = 0;
        private string load1(int i1)
        {
            string[] st = File.ReadAllLines("lyric.txt");
            k = st.Length;
            return st[i1];
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label1.Text = load1(i);
            //label1.BackColor = Color.LightCoral;
            colorrandom(label1);
            if (i == k - 1)
            {
                label1.Text = "♥♥♥♥♥♥♥♥♥----- Hãy Về Đây Bên Anh ??";
                label1.BackColor = Color.Khaki;
                pictureBox1.Image = Image.FromFile(@"anh/end.jpg");
                timer1.Stop();
                return;
            }
            else
                i++;           
            thistext();           
        }

        private void playmusic()
        {
            using (SoundPlayer play = new SoundPlayer("music.wav"))
            {
                play.Play();
            }
        }

        private void thistext()
        {
            Random sr = new Random();
            //sr.Next(1,10);
            switch (sr.Next(1,10))
            {
                case 1:
                    this.Text = "là BT nè"; break;
                case 2:
                    this.Text = "Đà Lạt"; break;
                case 3:
                    this.Text = "173"; break;
                case 4:
                    this.Text = "98"; break;
                case 5:
                    this.Text = "Mạc ĐĨnh Chi"; break;
                case 6:
                    this.Text = "1 em trai"; break;
                case 7:
                    this.Text = "Song Ngư"; break;
                case 8:
                    this.Text = "Hot"; break;
                case 9:
                    this.Text = "Zô"; break;                
                default:
                    this.Text = "Teen"; break;                    
            }
        }
        private void picbchage()
        {
            Random rd = new Random();
            int i = rd.Next(1, 7);                         
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            switch (i)
            {
                case 1:
                    pictureBox1.Image = Image.FromFile(@"anh/1.jpg");
                    break;
                case 2:
                    pictureBox1.Image = Image.FromFile(@"anh/2.jpg");
                    break;
                case 3:
                    pictureBox1.Image = Image.FromFile(@"anh/3.jpg");
                    break;
                case 4:
                    pictureBox1.Image = Image.FromFile(@"anh/4.jpg");
                    break;
                case 5:
                    pictureBox1.Image = Image.FromFile(@"anh/5.jpg");
                    break;
                case 6:
                    pictureBox1.Image = Image.FromFile(@"anh/6.jpg");
                    break;
                default:
                    pictureBox1.Image = Image.FromFile(@"anh/7.jpg");
                    break;                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel2.Show();
            playmusic();
            timer1.Interval = 5000;
            timer1.Start();
            //pictureBox1.BackgroundImageLayout = ImageLayout.Tile;
            //pictureBox1.Size = panel1.BackgroundImage.Size;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            picbchage();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel1.Show();
            panel2.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
