using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace lear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loada();
        }

        private void loada()
        {            
            // Must sort file 
            // loa du lieu tu a le listbox1.
            using (StreamReader sr=new StreamReader("a.txt"))
            {
                while (!sr.EndOfStream)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }   
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(listBox1.SelectedIndex.ToString());
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(listBox1.SelectedItem.ToString());
            //if (listBox1.SelectedItem.ToString()=="toan")
            //{

             loadb(listBox1.SelectedItem.ToString());

            //}
        }
        string s1 = "";
        private void loadb(string str)
        {
            s1 = "b/"+str;
            listBox2.Items.Clear();
            try
            {
                using (StreamReader sr = new StreamReader( s1 + ".txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        listBox2.Items.Add(sr.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadc(listBox2.SelectedIndex.ToString()); //load c
            loadd(listBox2.SelectedIndex.ToString()); //load d
        }

        private void loadd(string p)
        {
            listBox3.Items.Clear();                        
            try
            {
                using (StreamReader sr = new StreamReader(s1.ToString() + "/" + "key/" + p.ToString() + ".txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        listBox3.Items.Add(sr.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void loadc(string p)
        {
            richTextBox1.Clear();
            try
            {
                //using (StreamReader sr=new StreamReader(s1.ToString()+"/"+"data/"+p.ToString()+".rtf"))
                {
                   // richTextBox1.Text = sr.ReadToEnd();
                    //sr.Dispose();
                    richTextBox1.LoadFile(s1.ToString() + "/" + "data/" + p.ToString() + ".rtf",RichTextBoxStreamType.RichText);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
