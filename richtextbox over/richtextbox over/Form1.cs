using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace richtextbox_over
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
    //        if (e.Clicks==1 && e.Button==MouseButtons.Left)
    //        {
    //            int post=richTextBox1.GetCharFromPosition(new Point(e.X,e.Y));
    //         MessageBox.Show(post.ToString());
    //{
		 
    //}
    //        }
        }

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("Oh mem");
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {
            //MessageBox.Show("Oh mem");
        }

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
//            MessageBox.Show("Oh mem");
        }

        private void richTextBox1_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Oh mem");
        }
    }
}
