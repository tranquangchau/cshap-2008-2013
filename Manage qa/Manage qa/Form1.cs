using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            this.TopMost=true;
            DungChung.folderload(listBox1);
            //listBox1.SelectedIndex = -1;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
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
            
            string sz=DungChung.fileati(i, listBox1.SelectedItem.ToString() + "/index.txt" );
            label1.Text = DungChung.stringcatchuoi(sz);
            DungChung.richtextloadtxt(richTextBox1, listBox1.SelectedItem.ToString() + "/" + i.ToString()+".txt");
            label2.Text = (i+1).ToString() + "/" + DungChung.k.ToString();                                                  
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
            label1.Text = DungChung.stringcatchuoi(sz) ;
            DungChung.richtextloadtxt(richTextBox1, listBox1.SelectedItem.ToString() + "/" + i.ToString()+".txt");
            label2.Text =(i+1).ToString()+"/"+ DungChung.k.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DungChung.richtextsavetxt(richTextBox1, listBox1.SelectedItem.ToString() + "/" + i.ToString() + ".txt");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            i = 0;
            button2.PerformClick();
            label2.Text = DungChung.k.ToString();
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
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
        // click khi form kia close
    }
}
