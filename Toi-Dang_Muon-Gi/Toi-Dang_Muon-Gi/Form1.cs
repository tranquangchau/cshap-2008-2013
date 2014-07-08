using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Toi_Dang_Muon_Gi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            docfile();            
            changephoto();            
        }
        private void changephoto()
        {                            
            Random r = new Random();
            int i = r.Next(1, 7);
            switch (i)
            {
                case 1:
                    pictureBox2.Image = Toi_Dang_Muon_Gi.Properties.Resources.want;
                    break;
                case 2:
                    pictureBox2.Image = Toi_Dang_Muon_Gi.Properties.Resources.want1;
                    break;
                case 3:
                    pictureBox2.Image = Toi_Dang_Muon_Gi.Properties.Resources.want2;
                    break;
                case 4:
                    pictureBox2.Image = Toi_Dang_Muon_Gi.Properties.Resources.want4;
                    break;
                case 5:
                    pictureBox2.Image = Toi_Dang_Muon_Gi.Properties.Resources.want5;
                    break;
                default:
                    pictureBox2.Image = Toi_Dang_Muon_Gi.Properties.Resources.want6;
                    break;                
            }
            //MessageBox.Show(i.ToString());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "I MUST WANT NOW~ \n Save OK";
            vietfile();
            docfile();
            richTextBox2.Text = null;
        }
        private void vietfile()
        {
            
            if (richTextBox1.Text == "")
            {
                return;
            }
            else
            {
                StreamWriter sw = new StreamWriter("data.txt", true, Encoding.UTF8);
                //sw.WriteLine("\n");
                foreach (string line in richTextBox2.Lines)
                {
                    sw.WriteLine(line);
                }
                sw.Close();                
                System.Threading.Thread.Sleep(1000);
               // label1.Text = "YOU MUST WANT NOW~";    
            }
        }
        private void docfile()
        {
            StreamReader sr = new StreamReader("data.txt");
            richTextBox1.Text = sr.ReadToEnd();
            sr.Dispose();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = comboBox1.SelectedItem.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            changephoto();
        }
    }
}
