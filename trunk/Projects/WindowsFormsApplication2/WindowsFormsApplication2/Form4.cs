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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            StreamReader re = new StreamReader("list.txt");
            string str;
            str = re.ReadLine();
            while (str != null)
            {
                listBox1.Items.Add(str.Trim());
                str = re.ReadLine();
            }
            re.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 fr = new Form5();
            fr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
