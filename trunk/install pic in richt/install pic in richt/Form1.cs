using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace install_pic_in_richt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           InitializeComponent();
           button1.Text = ""; button2.Text = ""; button3.Text = "";
           button1.Image = install_pic_in_richt.Properties.Resources._1;
           button2.Image = install_pic_in_richt.Properties.Resources._2;
           button3.Image = install_pic_in_richt.Properties.Resources._3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            createImage(richTextBox1, install_pic_in_richt.Properties.Resources._1);
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            createImage(richTextBox1, install_pic_in_richt.Properties.Resources._2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            createImage(richTextBox1, install_pic_in_richt.Properties.Resources._3);
        }

        // dau vao la loai richtech,file
        private void createImage(Control item, object st)
        {
            Hashtable image = new Hashtable(1);
            image.Add(item, st);
            Clipboard.SetImage((Image)image[item]);
            ((RichTextBox)item).Paste();
        }
    }
}
