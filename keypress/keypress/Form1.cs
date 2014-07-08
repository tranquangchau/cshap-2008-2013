using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keypress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
           /// this.form.KeyPress += new System.Windows.Forms.KeyPressEventHandler(check1);            
           // this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
        }

        private void Form1_KeyPress(object sender,System.Windows.Forms.KeyPressEventArgs e)
        {
            if ((e.KeyChar>='0')&&(e.KeyChar<='9'))
            {
                MessageBox.Show("Key P{resse");
            }
        }

        private void check1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.W)
            {
                MessageBox.Show("chau");
                button1.Top -= 10;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                MessageBox.Show("chau");
                button1.Top -= 10;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("chau");
                button1.Top -= 10;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
