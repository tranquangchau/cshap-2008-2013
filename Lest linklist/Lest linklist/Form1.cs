using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lest_linklist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Focus();
            //comboBox1.Focused;
            loadcompobox(comboBox1,"x.txt");
        }

        private void loadcompobox(ComboBox comboBoxload, string p)
        {
            comboBoxload.Items.Clear();
            if (File.Exists(p)==false)
            {
                File.Create(p).Close();
            }
            using (StreamReader sr = new StreamReader(p))
            {
                while (!sr.EndOfStream)
                {
                    comboBoxload.Items.Add(sr.ReadLine().Trim());
                }
            }                        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //catchuoi(comboBox1,textBox1.Text);
            themvaocombobox(textBox1.Text,"x.txt");
        }

        private void themvaocombobox(string p, string p_2)
        {
            if (p.Trim() != "")
            {
                StreamWriter sw = new StreamWriter(p_2, true, Encoding.UTF8);
                sw.WriteLine(p);
                sw.Close();                                
            }
            else return;            
        }

        //cat chuoi voi cac dau cach vi du: load, b, c ,dehkadf ajhdf, computer,
        //trim no
        private void catchuoi(ComboBox comboBox1, string p)
        {
            comboBox1.Items.Clear();
            string[] catphai = p.Split(',');
            foreach (string item in catphai)
            {
                comboBox1.Items.Add(item.Trim());
            }
            //MessageBox.Show(comboBox1.Items[-1].ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = comboBox1.SelectedItem.ToString();
            
        }

        private void savechuoi(ComboBox comboBox1, string p)
        {
            if (File.Exists(p)==false)
            {
                File.Create(p).Close();
            }
            StreamWriter sw = new StreamWriter(p);
            foreach (var item in comboBox1.Items)
            {
                sw.WriteLine(item);    
            }            
            sw.Close();
        }
        //update
        private void button3_Click(object sender, EventArgs e)
        {
            updatecombobox(comboBox1,comboBox1.SelectedIndex,textBox1.Text,"x.txt");
        }

        //update combobox save txt
        private void updatecombobox(ComboBox comboBoxupdate, int p, string p_3, string p_4)
        {
            if (p_3.Trim() !="")
            {
                if (p>=0)
                {                                    
                    int k = 0;
                    using (StreamWriter sw=new StreamWriter(p_4,false,Encoding.UTF8))
                    {
                        foreach (var item in comboBoxupdate.Items)
                        {
                            if (k == p)
                            {
                                sw.WriteLine(p_3.Trim());
                            }
                            else
                            {
                                sw.WriteLine(item.ToString().Trim());
                            }
                            k++;
                        }
                    }
                }
            }
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
        //    savechuoi(comboBox1, "x.txt");
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            savechuoi(comboBox1, "x.txt");
            loadcompobox(comboBox1, "x.txt");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadcompobox(comboBox1, "x.txt");
        }

    }
}
