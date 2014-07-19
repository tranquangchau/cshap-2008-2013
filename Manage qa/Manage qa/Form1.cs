using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Manage_qa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Add fr = new Add();
            fr.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //pictureBox1.ImageLocation = "c#.jpeg";
            //pictureBox1.Image = Image.FromFile("c#.jpeg");
            this.TopMost=true;
            DungChung.folderload(listBox1);
            //listBox1.SelectedIndex = -1;
            
            if (listBox1.Items.Count > 0)
            {
                listBox1.SelectedIndex = 0;
            }
            else
            {

            }
            //button2.PerformClick();
        }
        int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (i <= 0)
            {
                i = 0;                
            }
            else
            {
                i--;
            }
            //listBox1.SelectedIndex = 0;
            //MessageBox.Show(i.ToString() +" / "+listBox1.SelectedItem.ToString());
            sz = DungChung.fileati(i, listBox1.SelectedItem.ToString() + "/index.txt");
            label1.Text = DungChung.stringcatchuoi(sz);
            DungChung.richtextloadtxt(richTextBox1, listBox1.SelectedItem.ToString() + "/" + i.ToString() + ".txt");
            label2.Text = (i + 1).ToString() + "/" + DungChung.k.ToString();                                 
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (i >= DungChung.k - 1)
            {
                i = DungChung.k - 1;
                return;
            }
            else
            {
                i = i + 1;
            }
            string sz = DungChung.fileati(i, listBox1.SelectedItem.ToString() + "/index.txt");
            label1.Text = DungChung.stringcatchuoi(sz);
            DungChung.richtextloadtxt(richTextBox1, listBox1.SelectedItem.ToString() + "/" + i.ToString() + ".txt");
            label2.Text = (i + 1).ToString() + "/" + DungChung.k.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DungChung.richtextsavetxt(richTextBox1, listBox1.SelectedItem.ToString() + "/" + i.ToString() + ".txt");
        }
        string sz;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = 0;
            //button2.PerformClick();
            label2.Text = DungChung.k.ToString();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;

            sz = DungChung.fileati(i, listBox1.SelectedItem.ToString() + "/index.txt");
            //label1.Text = DungChung.stringcatchuoi(sz);
            //DungChung.richtextloadtxt(richTextBox1, listBox1.SelectedItem.ToString() + "/" + i.ToString() + ".txt");
            label2.Text = (i + 1).ToString() + "/" + DungChung.k.ToString(); 

            //MessageBox.Show(DungChung.k.ToString()); //check k max.
            listBox2.Items.Clear();
            for (int i1 = 1; i1 <= DungChung.k; i1++)
            {
                listBox2.Items.Add(i1);
            }

            if (listBox2.Items.Count > 0)
            {
                listBox2.SelectedIndex = 0;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            //load picture thing.
            string filela =listBox1.SelectedItem.ToString() +"/"+listBox1.SelectedItem.ToString() + ".jpeg";
            //MessageBox.Show(filela.ToString());
            if (System.IO.Directory.Exists(filela))
            {
                pictureBox1.ImageLocation = filela;
            }
            else
                pictureBox1.Image = Manage_qa.Properties.Resources.qa;
        }

        internal void Contains(object p)
        {
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DungChung.folderload(listBox1);
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            //listBox1.SelectedIndex = 0;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = listBox2.SelectedIndex;
            string sz = DungChung.fileati(i, listBox1.SelectedItem.ToString() + "/index.txt");

            label1.Text = DungChung.stringcatchuoi(sz);
            //DungChung.richtextloadtxt(richTextBox1, listBox1.SelectedItem.ToString() + "/" + listBox2.SelectedIndex.ToString() + ".txt");
            ////DungChung.ric
            //label2.Text = (listBox2.SelectedIndex+1).ToString() + "/" + DungChung.k.ToString();
            label1.Text = DungChung.stringcatchuoi(sz);
            DungChung.richtextloadtxt(richTextBox1, listBox1.SelectedItem.ToString() + "/" + i.ToString() + ".txt");
            label2.Text = (i + 1).ToString() + "/" + DungChung.k.ToString();
        }
        // click khi form kia close
    }
}
