using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;

namespace q2a_now
{
    public partial class Form1 : Form
    {
        Class1 cl1 = new Class1();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl1.random1(richTextBox1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cl1.random1(richTextBox1);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
