using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NhatKy
{
    public partial class frmLearNing : Form
    {
        public frmLearNing()
        {
            InitializeComponent();
        }

        private void frmLearNing_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("data/list1.txt");
            string str = sr.ReadLine();
            while (str != null)
            {
                listBox1.Items.Add(str);
                str = sr.ReadLine();
            }
            sr.Close();
            richTextBox1.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            if (button3.Text=="Cancel")
                this.Close();
            else
            {
                if (listBox1.SelectedIndex < 0)
                {
                    return;
                }
                else
                {
                    string str = listBox1.SelectedItem.ToString();
                    string str1 = string.Format("learning/" + str + ".txt");
                    StreamWriter sw = new StreamWriter(str1, false, Encoding.UTF8);
                    foreach (string line in richTextBox1.Lines)
                    {
                        sw.WriteLine(line);
                    }
                    sw.Close();
                    button3.Text = "Cancel";
                    richTextBox1.ReadOnly = true;
                    MessageBox.Show("Đã lưu " + str);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                string str = listBox1.SelectedItem.ToString();
                string str1 = string.Format("learning/"+str+".txt");
                StreamReader sr = new StreamReader(str1);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                richTextBox1.ReadOnly = false;
                button3.Text = "Lưu";
            }
        }
    }
}
