using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace queas
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //savelist(listBox1,"x.txt");
            listboxload(listBox1, "x.txt");
        }

        //private void savelist(ListBox listBoxsave, string p)
        //{
        //    using (StreamWriter sw = new StreamWriter(p,false,Encoding.UTF8))
        //    {
        //        foreach (var item in listBoxsave.Items)
        //        {
        //            sw.WriteLine(item.ToString());
        //        }
        //        sw.Close();
        //    }
        //}
        private void listboxload(ListBox listBoxload,string p)
        {
            listBox1.Items.Clear();
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

        private void themde( TextBox textBoxadd,string file)
        {
            if (textBoxadd.Text.Trim() != "")
            {
                StreamWriter sw = new StreamWriter(file, true, Encoding.UTF8);
                sw.WriteLine(textBoxadd.Text);
                sw.Close();                
                textBoxadd.Text = "";
                textBoxadd.Focus();
            }
            else return;            

        }


        private void updatelist(ListBox listBoxupdate, int p, string p_3,string file)
        {
            if (p_3.Trim() != "")
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
                return;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            themde(textBox1, "x.txt");
            listboxload(listBox1, "x.txt");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            updatelist(listBox1, listBox1.SelectedIndex, textBox1.Text, "x.txt");
            listboxload(listBox1, "x.txt");
        }        
    }
}
