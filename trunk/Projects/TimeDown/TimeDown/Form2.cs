using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeDown
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.TopMost = true;
            //Test files
            if (!File.Exists("oldtask.txt"))
                MessageBox.Show("Error");
            //read file
            using (StreamReader sr = new StreamReader("oldtask.txt"))
            {
                richTextBox1.Text = sr.ReadToEnd();
            }
        }
    }
}
