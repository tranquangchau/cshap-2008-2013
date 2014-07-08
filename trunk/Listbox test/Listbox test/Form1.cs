using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Listbox_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listload(listBox1,"x.txt");
            textBox1.Focus();
            listBox1.Focus();
        }
        private void listload(ListBox listBoxload, string p)
        {
            if (p.Trim() == "")
            {
                return;
            }
            else
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

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listboxthem(listBox1,5,textBox1.Text,"x.txt");
        }
        // Xu ly them
        private void listboxthem(ListBox listBoxthem, int p, string p_3,string file)
        {
            if (p_3.Trim() != " " || (p < 0) == false)
            {
                int k = 0;
                using (StreamWriter sw = new StreamWriter(file, false, Encoding.UTF8))
                {
                    foreach (var item in listBoxthem.Items)
                    {
                        if (k>=p)
                        {
                            sw.WriteLine(item.ToString());
                        }
                        if (k == p+1)
                        {
                            sw.WriteLine(p_3);
                        }
                        else
                            sw.WriteLine(item.ToString());
                        k++;
                    }
                    sw.Close();
                }
            }
            else
                return;
        }
        // Update
        private void button4_Click(object sender, EventArgs e)
        {
            listboxupdat(listBox1,listBox1.SelectedIndex,textBox1.Text,"x.txt");
        }

        private void listboxupdat(ListBox listBoxupdate, int p, string p_3, string file)
        {
            if (p_3.Trim() != "" || (p < 0) == false)
            {
                int k = 0;
                using (StreamWriter sw = new StreamWriter(file, false, Encoding.UTF8))
                {
                    foreach (var item in listBoxupdate.Items)
                    {
                        if (k == p)
                        {
                            sw.WriteLine(p_3);
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
            {
                MessageBox.Show("Loi so 1");
                return;
            }
        }
        //xoa nut
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
