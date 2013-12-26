using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace toidanglamgi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
            label2.Text="";
        }
        private bool bl = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (bl == true)
            {                                             
                if (textBox1.Text == "")
                { }
                else
                {
                    //Xu ly start
                    button1.Text = "Stop";
                    bl = false;
                    this.textBox1.Hide();
                    this.label2.Show();
                    label2.Text = textBox1.Text;
                }
            }
            else
            {                
                button1.Text = "Start";
                bl = true;
                // Xu ly stop
                this.label2.Hide();                
                this.textBox1.Show();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
