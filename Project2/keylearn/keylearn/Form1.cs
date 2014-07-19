using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Media;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace keylearn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (blhide == true)
            {
                listBox1.Hide();
                blhide = false;
            }
            else
            {
                listBox1.Show();
                blhide = true;
            }
            
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Hide();
           
        }
        string s1 = "data/";
        string s2;
        string s3,s4;
        bool bllist1 = true;
        private void Form1_Load(object sender, EventArgs e)
        {         
            PopulateListBox(listBox1,"d", @s1, "*");
            richTextBox1.ReadOnly = true;
            //Kiem tra list box 1 have data
            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;               
            }
            else
            {
             
                return;

            }
        }


        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            bllist1 = true;
            s2 = s1 + listBox1.Text;
            PopulateListBox(listBox2, "d", @s2, "*.");
            //MessageBox.Show(listBox2.Items.Count.ToString());

            if (listBox2.Items.Count > 0)
            {
                listBox2.SelectedIndex = 0;
                toolStripStatusLabel1.Text = listBox2.Items.Count.ToString();
                //MessageBox.Show("1");
            }
            else
            {
                // MessageBox.Show("2");
                toolStripStatusLabel1.Text = "0";
                return;
            }
            //richTextBox2.Text = "";
            readfile(richTextBox2, "/" + @s3 + "/" + listBox2.Text + ".txt");
        }
        //SoundPlayer nhac = new SoundPlayer();
        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //code play music

            try
            {
                Random r = new Random();
                int inhac = r.Next(1, 8);
                SoundPlayer nhac = new SoundPlayer();
                string linknhac = "Default/" + inhac.ToString() + ".wav";
                // MessageBox.Show(linknhac.ToString());
                nhac.SoundLocation = linknhac;
                nhac.Play();
                musicToolStripMenuItem.Text = inhac.ToString();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            
            //code

            if (bllist1==false)
            {
                s2 = s1 + listBox2.Text.Substring(0, 1);
            }
            else
            {
                //MessageBox.Show("bllistb1");
            }
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            richTextBox3.Text = "";
            i = 1;
            //read file richtexbox 1
            s3 = s2 +"/"+ listBox2.Text;
            PopulateListBox(listBox3, "f", @s3, "*.txt");            
            //gan mach dinh chon Listbox3=0
            if (listBox3.Items.Count>0)
            {
                listBox3.SelectedIndex = 0;
            }
            else
            {
                
                //MessageBox.Show(listBox3.Items.Count.ToString());
            }
            readfile(richTextBox2, "/" + @s3 + "/" + listBox2.Text + ".txt");
           
            s4 = @s3 + "/" + listBox2.Text;
            if (System.IO.File.Exists(s3 + "/" + listBox2.Text + "_1" + ".jpeg"))
           {             
               pictureBox1.Image = System.Drawing.Image.FromFile(s3 + "/" + listBox2.Text + "_1" + ".jpeg");
           } 
            else
                if (System.IO.File.Exists(s3 + "/" + listBox2.Text + "_1" + ".jpg"))
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(s3 + "/" + listBox2.Text + "_1" + ".jpg");
                }
                else
                {
                    pictureBox1.Image = keylearn.Properties.Resources.error;              
                }    
           
        }
        
        /// <summary>
        /// De doc file 1
        /// </summary>
        /// <param name="textbox"></param>
        /// <param name="p"></param>
        private void readfile(RichTextBox textbox, string p)
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + p))
            {
                //textbox.LoadFile(Environment.CurrentDirectory + p, RichTextBoxStreamType.PlainText);
                StreamReader sr = new StreamReader((Environment.CurrentDirectory + p).ToString());                
                string s1 = sr.ReadLine();
                richTextBox3.Text = sr.ReadToEnd();
                sr.Close();
                textbox.Text = s1.Replace(";", "\n");
                
                
                // luu file da viet cap nhat               
            }
            else
            {
                //MessageBox.Show("Error File");
                return;
            }
        }
        /// <summary>
        /// read file have know
        /// </summary>
        /// <param name="textbox"></param>
        /// <param name="p"></param>
        private void readfile1(RichTextBox textbox, string p)
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + p))
            {
                //textbox.LoadFile(Environment.CurrentDirectory + p, RichTextBoxStreamType.PlainText);
                StreamReader sr = new StreamReader((Environment.CurrentDirectory + p).ToString());
                //string s1 = sr.ReadLine();
                textbox.Text = sr.ReadToEnd();
                sr.Close();
                //textbox.Text = s1.Replace(";", "\n");
                // luu file da viet cap nhat               
            }
            else
            {
                //MessageBox.Show("Error File");
                return;
            }
        }
        private void readfile(RichTextBox textbox, string p,string check)
        {
            if (System.IO.File.Exists(Environment.CurrentDirectory + p))
            {
                textbox.LoadFile(Environment.CurrentDirectory + p, RichTextBoxStreamType.PlainText);
                
            }
            else
            {
                // luu file da viet cap nhat
                StreamWriter sw = new StreamWriter("Computerlist.txt", true);
                sw.WriteLine(listBox2.Text.ToString());
                sw.Close();
               // MessageBox.Show("Error File No have file");
                return;
            }
        }

        private void PopulateListBox(ListBox lsb, string s, string p, string p_3)
        {
            lsb.Items.Clear();
            if (s == "d")
            {
                System.IO.DirectoryInfo dinfo = new System.IO.DirectoryInfo(p);
                System.IO.DirectoryInfo[] Files = dinfo.GetDirectories(p_3);
                foreach (System.IO.DirectoryInfo fle in Files)
                {
                    lsb.Items.Add(fle.Name);
                }
            }
            if (s == "f")
            {
                System.IO.DirectoryInfo dinfo = new System.IO.DirectoryInfo(p);
                if (System.IO.Directory.Exists(p_3)==true)
                {
                    Directory.CreateDirectory(p_3);
                }
                else
                {

                }
                System.IO.FileInfo[] Files = dinfo.GetFiles(p_3);
                foreach (System.IO.FileInfo fle in Files)
                {
                    lsb.Items.Add(fle.Name);
                }
            }
            else
            {
                return;
            }

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            readfile1(richTextBox1, "/" + @s3 + "/" + listBox3.Text);
        }

        int i = 1;

        private void button1_Click_1(object sender, EventArgs e)
        {
            i++;
            if (System.IO.File.Exists(s3 + "/" +listBox2.Text+"_"+ i + ".jpeg"))
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(s3 + "/" +listBox2.Text+"_"+ i + ".jpeg");                
                button1.Text = i.ToString();                
            }
            else
                if (System.IO.File.Exists(s3 + "/" + listBox2.Text + "_" + i + ".jpg"))
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(s3 + "/" + listBox2.Text + "_" + i + ".jpg");
                    button1.Text = i.ToString();
                }
                else
                {
                    i--; //ngoai vong phap luat thi gan gi po
                    return;
                }                                    
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            i--;
            if (System.IO.File.Exists(s3 + "/" + listBox2.Text + "_"+(i) + ".jpeg"))
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(s3 + "/" +listBox2.Text+"_"+ (i) + ".jpeg");               
                button1.Text = i.ToString();                
            }
            else
	
               if (System.IO.File.Exists(s3 + "/" + listBox2.Text + "_"+(i) + ".jpg"))
                {
                    pictureBox1.Image = System.Drawing.Image.FromFile(s3 + "/" +listBox2.Text+"_"+ (i) + ".jpg");               
                    button1.Text = i.ToString();    
                    
                }
	
                else
                {
                    i++;//ngoai vong phap luat thi gan gi po
                    return;
                }
             
        }
        bool bl = true;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (bl == true)
            {
                pictureBox1.Height = panel11.Height;
                pictureBox1.Width = panel11.Width;
                //pictureBox1.Height += 100;
                //pictureBox1.Width +=100 ;
                bl = false;
               
            }
            else
            {
                pictureBox1.Height = pictureBox1.Image.Height;
                pictureBox1.Width = pictureBox1.Image.Width;
                bl = true;
            }
        }
        bool addfile = true;
        string s13;
        private void button3_Click_1(object sender, EventArgs e)
        {
            //true edit
            
            richTextBox1.Focus();
            string s12 = "/" + @s3 + "/" + listBox2.Text + "_" + Environment.MachineName + ".txt";
            s13 = Environment.CurrentDirectory + "/" + @s3 + "/" + listBox2.Text + "_" + Environment.MachineName + ".txt";          
            if (addfile==true)
	        {
		        //MessageBox.Show(s3+"/"+listBox2.Text+"_"+Environment.MachineName+".txt");
                //if (System.IO.File.Exists(s12) == false)
                //{
                //    System.IO.File.Create(s12).Close();
                //}
                //else
                //{ }
                richTextBox1.BackColor = System.Drawing.Color.Bisque;
                richTextBox1.ReadOnly = false;
                //richTextBox1.Enabled = true;  
              
                //MessageBox.Show(s12);
                readfile(richTextBox1, s12,"check old");
                button3.Text = "Save";
                addfile=false;
                //MessageBox.Show("edit");
                
	        }
            else 
            {
                
                luu();
                // refersh lish box 3 when save click
            }
            
        }

        private void luu()
        {
            if (richTextBox1.ReadOnly==true)
            {
                return;
            }
            else
            {
                button3.Text = "Edit";
                savefilertf(s13, richTextBox1);
                MessageBox.Show("save");
                addfile = true;
                PopulateListBox(listBox3, "f", @s3, "*.txt");
                
                richTextBox1.ReadOnly = true;
                richTextBox1.BackColor = System.Drawing.Color.White;
            }
            
           
        }

        private void savefilertf(string p, RichTextBox invao)
        {
            try
            {
                invao.SaveFile(p, RichTextBoxStreamType.PlainText);
                //MessageBox.Show("save OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            luu();
        }

        private void fileAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bllist1 = false;
            listboxload(listBox2, "Computerlist.txt");
        }

        private void listboxload(ListBox listBoxload, string p)
        {
            listBoxload.Items.Clear();
            if (File.Exists(p) == false)
            {
                File.Create(p).Close();
            }
            using (StreamReader sr = new StreamReader(p))
            {
                while (!sr.EndOfStream)
                {
                    listBoxload.Items.Add(sr.ReadLine());
                }
            }
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            notifyIcon1.Text = "hello";
        }
        bool blhide = true;
        private void hisroryViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (blhide==true)
            {
                //panel5.Hide();
                ////panel4.Dock = DockStyle.Fill;
                listBox3.Hide();
                blhide = false;                
            }
            else
            {
                
              //  //splitter4.Margin =marg;
              //  //splitter4.MinExtra = 3;
              //  //splitter4.Height = 12;
              //  //splitter4.fix
              //  //splitter4.Location = new System.Drawing.Point(100,200);
                 
              //  //splitter4.
              //  panel5.Show();
              //  panel5.Dock=DockStyle.Bottom;
              //  panel4.Dock = DockStyle.Top;
              //  splitter4.Dock = DockStyle.Top;
              ////  panel5.Dock = DockStyle.Bottom;
                listBox3.Show();
                blhide = true;
            }
            
        }

        //private void panel7_Leave(object sender, EventArgs e)
        //{
        //    button1.Text = ">";
        //}

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult sr= MessageBox.Show("Create By -8- -----Chau+155----_ \n\n Check Vision new", "11/07/2014 ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            switch (sr)
            {                
                case DialogResult.Yes:
                    System.Diagnostics.Process.Start("http://xn--trnquangchu-57a8710h.vn/codes");
                    break;
                default:
                    break;
            }
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
             DialogResult sr =MessageBox.Show("Email: tranquangchau155@gmail.com", "Connect+SUpporT", MessageBoxButtons.OK, MessageBoxIcon.Question);           
           
        }

        //private void panel11_Leave(object sender, EventArgs e)
        //{
        //    button1.Text = ">";
        //}

        private void panel7_Leave(object sender, EventArgs e)
        {
            button1.Text = ">";
            i = 1;
        }

        private void abcdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bllist1 = false;
            listboxload(listBox2, "abc.txt");
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopulateListBox(listBox1, "d", @s1, "*");
        }
    }
}
