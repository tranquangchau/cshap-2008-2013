using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();
        }
        int giay=0, phut=0, gio=0,ngay=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            giay++;
            if (giay>60)
            {
                phut++;
                giay = 0;
                if (phut>60)
                {
                    gio++;
                    phut = 0;
                    if (gio>24)
                    {
                        ngay++;
                        gio = 0;
                    }
                }
            }//end time
            label1.Text = ngay.ToString() + "-" + gio.ToString() + "-" + phut.ToString() + "-" + giay.ToString();
        }
        //xu ly text nhap vao
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "1" || textBox1.Text == "2" || textBox1.Text == "3" || textBox1.Text == "4")
            {
                switch (int.Parse(textBox1.Text.ToString().Trim()))
                {
                    case 1:
                        button1.Text = "Save";
                        break;
                    case 2:
                        button1.Text = "Edit";
                        break;
                    case 3:
                        button1.Text = "Next";
                        break;
                    case 4:
                        button1.Text = "Back";
                        break;
                    default:
                        button1.Text = "Helo";
                        break;
                }
            }
            else
            {
                button1.Text = "Funny!";
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkbutton(button1.Text.ToString().Trim(),"123",richTextBox1);
        }

        private void checkbutton(string p, string p_2, RichTextBox richTextBoxMen)
        {
            switch (p)
            {
                case "Save":
                    luufile(richTextBoxMen,p_2);
                    break;
                case "Edit":
                    editfile(richTextBoxMen, p_2);
                    break;
                case "Back":
                    backfile(richTextBoxMen, p_2);
                    break;
                case "Next":
                    nextfile(richTextBoxMen, p_2);
                    break;
                default:
                    break;
            }
        }

        private void checkbutton(string p, string p_2)
        {
            
        }     
    }
}
