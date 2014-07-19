using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace level_thing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {           
           

        }

        private void loaddirectory(string s1, ListBox listBox1)
        {
           // foreach (System.IO.DirectoryInfo g in Directory.GetDirectories(s1))
            MessageBox.Show(s1);
        }
        //ham show
        private void viewtext(ListBox lbox)
        {
            label1.Text = lbox.Text;
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewtext(listBox1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
