using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace winform
{
    public partial class Flistbox : Form
    {
        public Flistbox()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Ban da cho web site";
            richTextBox1.Text += listBox1.SelectedIndex.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.ResetText();
        }
    }
}
