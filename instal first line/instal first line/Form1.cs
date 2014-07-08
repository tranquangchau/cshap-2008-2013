using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace instal_first_line
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // xu ly load
        private void button1_Click(object sender, EventArgs e)
        {
            loadfile();
        }

        private void loadfile()
        {
            StreamReader sr = new StreamReader("t.txt");
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }
        // xu ly nut them
        private void button2_Click(object sender, EventArgs e)
        {
            themdata(textBox1.Text);
            textBox1.Text = "";
            loadfile();
        }

        private void themdata(string p)
        {
            using (var input=new StreamReader("t.txt"))
            using (var output=new StreamWriter("t.txt.tep",true,Encoding.UTF8))
            {
                var buf= new char[4096];
                int read = 0;
                output.WriteLine(p);
                do
                {
                    read = input.ReadBlock(buf, 0, buf.Length);
                    output.Write(buf, 0, read);
                } while (read>0);
                output.Flush();
                output.Close();
                input.Close();
            }
            File.Replace("t.txt.tep", "t.txt", "t.txt.back");
            File.Delete("t.txt.back");
        }
    }
}
