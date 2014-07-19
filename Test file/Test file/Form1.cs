using System;
//using System.Collections.Generic;
//using System.ComponentModel;
using System.Media;
using System.Drawing;
using System.IO;
//using System.Text;
using System.Windows.Forms;

namespace Test_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.helpProvider1.SetHelpString(panel1, "by TranQuangChau155@gmail.com, SaiGon 19-7-2014");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            loadfolder(listBox1, link1);
            try
            {
                SoundPlayer nhac = new SoundPlayer();
                nhac.SoundLocation = "music/iloveyou.wav";
                nhac.Play();
            }
            catch (Exception)
            {
            }
        }
                
             
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            loadfolder(listBox1,listBox2,1);
            label1.Text = listBox1.Text;
        }


        string link1 = "data";
        private void loadfolder(ListBox listBox1, string p)
        {
            listBox1.Items.Clear();
            DirectoryInfo directo = new DirectoryInfo(p);
            DirectoryInfo[] directories = directo.GetDirectories();
            foreach (DirectoryInfo folder in directories)
            {
                listBox1.Items.Add(folder.Name);
            }
        }
        string thumuccha = "";
        private void loadfolder(ListBox listBoxx, ListBox listBoxy,int i)
        {
            SoundPlayer nhac = new SoundPlayer();            
            string linkfolder="";
            label2.Text = "";
            listBox1.BackColor = Color.White;
            listBox2.BackColor = Color.White;
            listBox3.BackColor = Color.White;
            listBox4.BackColor = Color.White;
            listBox5.BackColor = Color.White;


            switch (i)
            
            {   case 1:
                    try
                    {
                        linkfolder = link1 +"/"+listBox1.Text;
                        thumuccha = Directory.GetCurrentDirectory();
                        realfileindexx(linkfolder); //doc file index trong folder

                        listBox1.BackColor = Color.Tomato;
                        listBox2.Items.Clear();
                        listBox3.Items.Clear();
                        listBox4.Items.Clear();
                        listBox5.Items.Clear();
                    
                   
                        nhac.SoundLocation = "music/do.wav";
                        nhac.Play();
                    }
                    catch (Exception)
                    {                                                
                    }
                    break;
                case 2:
                    try
                    {
                        linkfolder = link1 + "/" + listBox1.Text + "/" + listBox2.Text;
                        realfileindexx(linkfolder); //doc file index trong folder
                        listBox3.Items.Clear();
                        listBox4.Items.Clear();
                        listBox5.Items.Clear();
                        listBox2.BackColor = Color.Orange;
                    
                        nhac.SoundLocation = "music/re.wav";
                        nhac.Play();
                    }
                    catch (Exception)
                    {
                    }
                        break;
                case 3:
                        try
                        {
                            linkfolder = link1 + "/" + listBox1.Text + "/" + listBox2.Text + "/" + listBox3.Text;
                            realfileindexx(linkfolder); //doc file index trong folder
                            listBox4.Items.Clear();
                            listBox5.Items.Clear();
                            listBox3.BackColor = Color.Yellow;
                       
                            nhac.SoundLocation = "music/mi.wav";
                            nhac.Play();
                        }
                        catch (Exception)
                        {
                        }
                        break;
                case 4:
                        try
                        {
                            linkfolder = link1 + "/" + listBox1.Text + "/" + listBox2.Text + "/" + listBox3.Text + "/" + listBox4.Text;
                            listBox5.Items.Clear();
                            listBox4.BackColor = Color.Blue;
                       
                            string[] array1 = Directory.GetFiles(linkfolder);
                            string[] array2 = Directory.GetFiles(linkfolder, "*.mp3");
                            string[] array3 = Directory.GetFiles(linkfolder, "*.gif");
                            foreach (string item in array1)
                            {
                                //richTextBox1.Text = item;
                                //listBox5.Items.Add(Path.GetFileName(item));
                                listBox5.Items.Add(item);
                            }
                        }
                        catch (Exception)
                        {
                            
                            //throw;
                        }
                        
                        try
                        {
                            nhac.SoundLocation = "music/fa.wav";
                            nhac.Play();
                        }
                        catch (Exception)
                        {
                        }    

                        return;
                       // break;
                case 5:
                //        linkfolder = link1 + "/" + listBox1.Text + "/" + listBox2.Text + "/" + listBox3.Text + "/" + listBox4.Text + "/" + listBox5.Text;
                        listBox5.BackColor = Color.Plum;
                        return;
                    default:
                    break;
            }
            DirectoryInfo directo = new DirectoryInfo(linkfolder.ToString());
            DirectoryInfo[] directories = directo.GetDirectories();
            foreach (DirectoryInfo folder in directories)
            {
                listBoxy.Items.Add(folder.Name);
            }
        }

        private void realfileindexx(string linkfolder1)
        {
            try
            {
                StreamReader sr1 = new StreamReader(linkfolder1 + "/index.txt");
                richTextBox1.Text = sr1.ReadToEnd().ToString();
            }
            catch (Exception)
            {
                
                //throw;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadfolder(listBox2, listBox3,2);
            label1.Text = listBox2.Text;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadfolder(listBox3, listBox4,3);
                label1.Text = listBox3.Text;
            }
            catch (Exception)
            {
                
                //throw;
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadfolder(listBox4, listBox5,4);
            label1.Text = listBox4.Text;
            //MessageBox.Show("Hello");
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadfolder(listBox4, listBox5, 5);
            label2.Text = listBox5.Text;
            try
            {
                SoundPlayer nhac = new SoundPlayer();
                nhac.SoundLocation = "music/son.wav";
                nhac.Play();
            }
            catch (Exception)
            {
            }   
            //error ???
        }

        private void listBox5_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(listBox5.Text);
                label2.Text = listBox5.Text;
            }
            catch (Exception)
            {
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer nhac = new SoundPlayer();
                nhac.SoundLocation = "music/la.wav";
                nhac.Play();
            }
            catch (Exception)
            {
            }  
        }

        private void label2_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer nhac = new SoundPlayer();
                nhac.SoundLocation = "music/si.wav";
                nhac.Play();
            }
            catch (Exception)
            {
            }  
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            try
            {
                SoundPlayer nhac = new SoundPlayer();
                nhac.SoundLocation = "music/dos.wav";
                nhac.Play();
            }
            catch (Exception)
            {
            }  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox4_DoubleClick(object sender, EventArgs e)
        {
            string foloder;
            foloder =System.IO.Directory.GetCurrentDirectory()+"/"+ link1 + "/" + listBox1.Text + "/" + listBox2.Text + "/" + listBox3.Text + "/" + listBox4.Text;
            System.Diagnostics.Process.Start(foloder);
        }

       

        

        
    }
}
