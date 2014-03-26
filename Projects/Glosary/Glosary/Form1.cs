using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Glosary
{
    public partial class Learning : Form
    {
        public Learning()
        {
            InitializeComponent();

            checkBox1.Checked = false;
            richTextBox1.Visible = false;
        }
        //string st = "5.JPG";
        //string st2 = "6.JPG";
        public int j=-3;

        List<string> lines = new List<string>();
        int k = 0;
        public void getdata(int bien)
        {
            using (var sr = new StreamReader("data/structure.txt"))
            {
                while (sr.Peek()>0)
                {
                    lines.Add(sr.ReadLine());
                }
                k = lines.Count-3;                
            }
            for (int i = 0; i < lines.Count; i++)
            {
                if (i == j)
                {
                    pictureBox1.ImageLocation = lines[i];                    
                    richTextBox1.Text = lines[i + 2];
                    switch (Int32.Parse(lines[i+1]))
                    {
                        case 1:
                            nut1.BackgroundImage = Image.FromFile(@"image\no1.jpg"); nut2.BackgroundImage = base.BackgroundImage; nut3.BackgroundImage = base.BackgroundImage; nut4.BackgroundImage = base.BackgroundImage; nut1.Text = ""; nut2.Text = "2"; nut3.Text = "3"; nut4.Text = "4";
                            break;
                        case 2:
                            nut1.BackgroundImage = base.BackgroundImage; nut2.BackgroundImage = Image.FromFile(@"image\shallow1.PNG"); nut3.BackgroundImage = base.BackgroundImage; nut4.BackgroundImage = base.BackgroundImage; nut1.Text = "1"; nut2.Text = ""; nut3.Text = "3"; nut4.Text = "4";
                            break;
                        case 3:
                            nut1.BackgroundImage = base.BackgroundImage; nut2.BackgroundImage = base.BackgroundImage; nut3.BackgroundImage = Image.FromFile(@"image\deep1.png"); nut4.BackgroundImage = base.BackgroundImage; nut1.Text = "1"; nut2.Text = "2"; nut3.Text = ""; nut4.Text = "4";
                            break;
                        case 4:
                            nut1.BackgroundImage = base.BackgroundImage; nut2.BackgroundImage = base.BackgroundImage; nut3.BackgroundImage = base.BackgroundImage; nut4.BackgroundImage = Image.FromFile(@"image\expert2.gif"); nut1.Text = "1"; nut2.Text = "2"; nut3.Text = "3"; nut4.Text = "";
                            break;                        
                    }// end switch

                    label1.Text = ((i + 4) / 3).ToString() + "/" + ((k + 3) / 3).ToString();
                
                } //end if (i==j)
            } //end for            
            
            lines.Clear();
        }// end ggetdata()

        
        
        private void button2_Click(object sender, EventArgs e)
        {
            //pictureBox1.ImageLocation = st;
            if (j < k)
            {
                j = j + 3;
                getdata(0);
                //button2.Text = j.ToString();
            }
            checkBox1.Checked = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = true;
        }

        //nút <
        private void button1_Click(object sender, EventArgs e)
        {
            //pictureBox1.ImageLocation = st2;
            if (j > 0)
            {
                j = j - 3;
                getdata(0);
            }
               // button1.Text = j.ToString();
            //else return;
            checkBox1.Checked = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = true;
        }

        //số 5
        private void button3_Click(object sender, EventArgs e)
        {

        }

        //số 4
        private void button4_Click(object sender, EventArgs e)
        {

        }

        //số 0
        bool bl = false;
        private void button8_Click(object sender, EventArgs e)
        {
            if (bl == true)
            {
                panel1.Visible = false; bl = false;
                richTextBox1.Visible = false;
                richTextBox2.Visible = false;
                this.BackColor = Color.Empty;
                nut0.Text = "0";
            }
            else
            {
                panel1.Visible = true; bl = true;
                richTextBox2.Visible = true;
                nut0.Text = "1";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {                
                richTextBox1.Visible = true;
                richTextBox2.Visible = false;
            }
            else
            {                
                richTextBox1.Visible = false;
                richTextBox2.Visible = true;
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"data/welcome.txt");
            richTextBox2.Text= sr.ReadToEnd() ;
            sr.Close();
            sr.Dispose();
            richTextBox2.EnableAutoDragDrop = true;
            panel1.Visible = false;
            this.MaximizeBox = false;
            //this.MaximizedBounds = ;
            richTextBox2.Visible = false;
           // Graphics g = new Graphics();
            //Graphics.DrawLines(new Pen(Color.Red), 0, 0, 10, 10);
            

            //using (Graphics g=Graphics.)
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Phần mềm sử dụng học tập các môn học\n Số 4: Tương ứng với kiến thức expert \n Số 3: Tương ứng với kiến thức deept,"
            + "\n Số 2: Tương ứng với kiến thức Shallow, \n Số 1: Tương ứng với kiến thức No","Copyrighted By @-----Chau+155----_.",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
        }

        


    }
}
