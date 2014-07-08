using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace search_in_richtext
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool checkclear = true;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (checkclear==true)
            {
                tem = richTextBox1.Text;  
            }            
            int len = this.richTextBox1.TextLength;
            int index = 0;
            int lastIndex = this.richTextBox1.Text.LastIndexOf(this.textBox1.Text);

            while (index < lastIndex)
            {
                this.richTextBox1.Find(this.textBox1.Text, index, len, RichTextBoxFinds.None);
                this.richTextBox1.SelectionBackColor = Color.Yellow;
                index = this.richTextBox1.Text.IndexOf(this.textBox1.Text, index) + 1;
            }

        }
        string tem;
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = tem;
            checkclear = false;
        }
    }
}
