using System;
//using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Manage_qa
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        string foldernow = Directory.GetCurrentDirectory();
        private void Add_Load(object sender, EventArgs e)
        {
            DungChung.folderload(listBox1);
            this.TopMost = true;
        }
        //private void Add_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    MessageBox.Show("CLose");
        //    Form1 fr = new Form1();
        //    fr.Refresh();
        //}

        private void button1_Click(object sender, EventArgs e)
        {            
            DungChung.folderadd(textBox1.Text);
            // tu dong load
            DungChung.folderload(listBox1);
            listBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            DungChung.folderrename(listBox1.SelectedItem.ToString(), textBox1.Text);
            //tu dong load.
            DungChung.folderload(listBox1);
            listBox1.SelectedIndex = 0;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DungChung.listboxload(listBox1.SelectedItem.ToString()+"/index.txt", listBox2);
            //listBox2.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DungChung.listboxadd(textBox2.Text, listBox1.SelectedItem.ToString() + "/index.txt");
            DungChung.listboxload(listBox1.SelectedItem.ToString() + "/index.txt", listBox2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DungChung.listboxupdate(listBox2, listBox2.SelectedIndex, textBox2.Text, listBox1.SelectedItem.ToString() + "/index.txt");
            DungChung.listboxload(listBox1.SelectedItem.ToString() + "/index.txt", listBox2);
        }

        private void Add_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Click Max question.");          
        }
    }
}
