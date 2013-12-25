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
    public partial class F_RadioButon : Form
    {
        public F_RadioButon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                textBox2.Text = textBox1.Text.ToUpper().ToString();
            }
            else
                textBox2.Text = textBox1.Text.ToLower().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
