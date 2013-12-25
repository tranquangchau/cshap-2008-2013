using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            StreamReader re = new StreamReader("dulieu/traloi.txt", Encoding.Default);
            string doc;
            doc = re.ReadLine();
            while (doc != null)
            {
                this.richTextBox1.AppendText(doc + "\n");
                doc = re.ReadLine();
            }            
            re.Close();
            StreamReader re1 = new StreamReader("dulieu/traloi.txt", Encoding.Default);
            string slen = re1.ReadToEnd();
            label2.Text = slen.Length.ToString();
            re1.Close();
        }
    }
}
