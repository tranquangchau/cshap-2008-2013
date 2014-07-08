using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace file_folder
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            loadtxt();
        }
        private void loadtxt()
        {            
            listBox1.Items.Clear();
            try
            {
                using (StreamReader sr = new StreamReader("t.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        listBox1.Items.Add(sr.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loadtxt();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("t.txt",true,Encoding.UTF8);
            sw.WriteLine(textBox3.Text);
            sw.Close();
            loadtxt();
            textBox3.Text = "";
            textBox3.Focus(); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            savelist();
            loadtxt();  
        }

        private void savelist()
        {
            using (StreamWriter sw=new StreamWriter("t.txt"))
            {
                foreach (var item in listBox1.Items)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //listBox1.SelectedValue = textBox3.Text;
            //listBox1.SelectedValue
            //MessageBox.Show(listBox1.SelectedItem.ToString()); //lay duoc gia tri cua item do
            //MessageBox.Show(listBox1.SelectedIndex.ToString()); //lay doc so tu tu cua no.
            //savelist();
            updatelist(listBox1.SelectedIndex,textBox3.Text);
            loadtxt();
        }

        private void updatelist(int p, string p_2)
        {
            int k = 0;
            using (StreamWriter sw = new StreamWriter("t.txt", false, Encoding.UTF8))
            {
                foreach (var item in listBox1.Items)
                {                    
                    if (k== p)
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fn=new Form1();
            fn.Show();
        }

    }
}
