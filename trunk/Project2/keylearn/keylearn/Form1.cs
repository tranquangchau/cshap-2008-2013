using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
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
            listBox2.Show();
            listView1.Hide();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox2.Hide();
            listView1.Show();
        }
        string s1 = "data/";
        string s2;
        string s3,s4;
        private void Form1_Load(object sender, EventArgs e)
        {
          
            PopulateListBox(listBox1,"d", @s1, "*");
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            s2 = s1 + listBox1.Text;
            PopulateListBox(listBox2,"f", @s2, "*.txt");               
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //read file richtexbox 1
            s3 = s2 +"/"+ listBox2.Text;
            readfile(richTextBox1,"/" +@s3);
            // read file picture
            s4=listBox2.Text.Substring(0,listBox2.Text.Length-4);
            //s4=listBox2.Text.
          // MessageBox.Show(s2 + "/" + s4+".jpeg");
          
           if (System.IO.File.Exists(s2 + "/" + s4 + ".jpeg"))
           {
               pictureBox1.Image = System.Drawing.Image.FromFile(s2 + "/" + s4 + ".jpeg");
           } 
            else
            pictureBox1.Image = System.Drawing.Image.FromFile(@"Default/error.jpeg");
        }

        private void readfile(RichTextBox textbox, string p)
        {
           textbox.LoadFile(Environment.CurrentDirectory+p, RichTextBoxStreamType.PlainText);            
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
    }
}
