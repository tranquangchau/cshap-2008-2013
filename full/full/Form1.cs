using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing;// Color.

namespace full
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button6.Enabled = false;
            button7.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            loadlistbox("a.txt");
            textBox2.Enabled = false;
        }
        int z0 = 0; // dung de save file txt trong thu muc nao do voi ten file+1.
        private void loadlistbox(string st)
        {
            listBox1.Items.Clear();
            if (File.Exists(st)==false)
            {
                File.Create(st).Close();
            }
            using (StreamReader sr = new StreamReader(st))
            {
                z0 = -1;
                while (!sr.EndOfStream)
                {
                    listBox1.Items.Add(sr.ReadLine());
                    z0 = z0+1;
                }
            }        
        }
        // nut them
        string folder1 = "./data/";
        string folder2 = "./key/";
        //them listbox1
        private void button1_Click(object sender, EventArgs e)
        {
            themlistbox("a.txt");
            loadlistbox("a.txt");
            listBox1.Focus();
            taofile(folder1,z0.ToString()+".txt");
            taofile(folder2, z0.ToString() + ".txt");
        }

        // themlisbox vao file
        private void themlistbox(string st)
        {
            if (textBox1.Text.Trim() != "")
            {
                StreamWriter sw = new StreamWriter(st, true, Encoding.UTF8);
                sw.WriteLine(textBox1.Text);
                sw.Close();                
                textBox1.Text = "";
                textBox1.Focus();
            }
            else return;
        }
        // tao file
        private void taofile(string folder,string file)
        {                         
            try
            {
                if (Directory.Exists(folder)==false)
                {
                    Directory.CreateDirectory(folder);
                }
                if (File.Exists(file)==false)
                {
                    File.Create(folder+file).Close();
                    //MessageBox.Show("Tao thanh cong");
                    file.Clone(); //clone de lam gi?
                }
                else
                    MessageBox.Show("File Ko tao duoc Vi da co roi!");
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.ToString());
            }           
        }

        // update
        private void button2_Click(object sender, EventArgs e)
        {
            updatelistbox("a.txt",listBox1.SelectedIndex,textBox1.Text);
            loadlistbox("a.txt");
            textBox1.Text = "";
            listBox1.Focus();
        }

        private void updatelistbox(string st,int p, string p_2)
        {
            if (textBox1.Text.Trim() !="")
            {
                int k = 0;
                using (StreamWriter sw = new StreamWriter(st, false, Encoding.UTF8))
                {
                    foreach (var item in listBox1.Items)
                    {
                        if (k == p)
                        {
                            sw.WriteLine(p_2);
                        }
                        else
                        {
                            sw.WriteLine(item.ToString());
                        }
                        k++;
                    }
                    sw.Close();
                }      
                
            }
            else
                return;
                             
        }

        string file = "";
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (button7.Enabled==true)
            {
                savefile(folder1 + file);
            }
            richTextBox1.Text = "";
            richTextBox1.ReadOnly = true;
            file = listBox1.SelectedIndex.ToString() + ".txt";
            readfile(folder1+listBox1.SelectedIndex.ToString()+".txt");
            readfile1(folder2 + listBox1.SelectedIndex.ToString() + ".txt");
            button6.Enabled = true;
            button7.Enabled = false;
            button3.Enabled = true;
            button5.Enabled = true;
            textBox2.Enabled = true;
        }

        private void readfile1(string p)
        {
            listBox2.Items.Clear();
            if (File.Exists(p) == false)
            {
                File.Create(p).Close();
            }
            using (StreamReader sr = new StreamReader(p))
            {
                while (!sr.EndOfStream)
                {
                    listBox2.Items.Add(sr.ReadLine());
                }
            }        
        }
        private void readfile(string st) 
        {
            if (File.Exists(st)==false)
            {
                File.Create(st);
            }
            StreamReader sr = new StreamReader(st);
            richTextBox1.Text=sr.ReadToEnd();            
            sr.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.ReadOnly = false;
            button7.Enabled = true;
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(file.ToString());
            savefile(folder1+file);
            richTextBox1.ReadOnly = true;
            button6.Enabled = true;
            button7.Enabled = false;
            MessageBox.Show("save OK file" + file);
        }
        private void savefile(string file)
        {
            StreamWriter sw = new StreamWriter(file);
            for (int i = 0; i < richTextBox1.Lines.Length; i++)
            {
                sw.WriteLine(richTextBox1.Lines[i]);
            }            
            sw.Flush();
            sw.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            themlistbox1(folder2+file);
            readfile1(folder2+file);
        }

        private void themlistbox1(string p)
        {
            if (textBox2.Text.Trim() != "")
            {
                StreamWriter sw = new StreamWriter(p, true, Encoding.UTF8);
                sw.WriteLine(textBox2.Text);
                sw.Close();
                //loadlistbox(p);
                textBox2.Text = "";
                textBox2.Focus();
            }
            else return;    
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        // remove list
        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);            
            savelist(folder2+file);
            readfile1(folder2 +file);            
        }

        private void savelist(string p)
        {
            using (StreamWriter sw = new StreamWriter(p))
            {
                foreach (var item in listBox2.Items)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            findtext(richTextBox1,textBox3.Text.Trim());            
        }
        //bool checkclear = true;
        private void findtext(RichTextBox richTextBoxfind, string p)
        {
            //if (checkclear==true)
            //{
            //    tem = richTextBox1.Text;
            //}
            int len = richTextBoxfind.TextLength;
            int index = 0;
            int lastIndex = richTextBoxfind.Text.LastIndexOf(p);
            while (index < lastIndex)
            {
                richTextBoxfind.Find(p, index, len, RichTextBoxFinds.None);
                richTextBoxfind.SelectionBackColor = Color.Yellow;//system.draw
                index = richTextBoxfind.Text.IndexOf(p, index) + 1;
            }            
        }
        // xu ly nt clear.
        private void button4_Click_1(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Black;//system.draw
            clearrichtexbox(richTextBox1);
        }
        //string tem;
        private void clearrichtexbox(RichTextBox richTextBoxclear)
        {
            if (button6.Enabled==false)
            {
                savefile(folder1 + file);
                button6.Enabled = false;
                button7.Enabled = true;
            }
            //buoc 1 luu
            //savefile(folder1 + file);
            //file = listBox1.SelectedIndex.ToString() + ".txt";
            readfile(folder1 + listBox1.SelectedIndex.ToString() + ".txt");
            //richTextBoxclear.SelectionBackColor = Color.Blue;//system.draw
            //readfile1(folder2 + listBox1.SelectedIndex.ToString() + ".txt");

            //buoc 2 load
        }

    }
}
