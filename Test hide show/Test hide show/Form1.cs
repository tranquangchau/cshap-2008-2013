using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_hide_show
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checktext(textBox1)==1)
            {
                return;   
            }            
            string st = textBox1.Text;
            string[] s1 = st.Split(',');
            for (int i = 0; i < s1.Length; i++)
            {
                anpanner(int.Parse(s1[i].ToString()));    
            }            
        }
        private void anpanner(int p)
        {
            switch (p)
            {
                case 1:
                    panel1.Hide();
                    break;
                case 2:
                    panel2.Hide();
                    break;
                case 3:
                    panel3.Hide();
                    break;
                case 4://have boss
                    //panel4.Hide();
                    break;
                case 5:
                    panel5.Hide();
                    break;
                case 6:
                    panel6.Hide();
                    break;
                case 7: //boss
                    //panel7.Hide();
                    break;
                case 8:
                    panel8.Hide();
                    break;
                case 9:
                    panel9.Hide();
                    break;
                case 10:
                    panel10.Hide();
                    break;
                case 11:
                    panel11.Hide();
                    break;
                default:                    
                    break;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checktext(textBox1) == 1)
            {
                return;
            }
            string st = textBox1.Text;
            string[] s1 = st.Split(',');
            for (int i = 0; i < s1.Length; i++)
            {
                hienpanner(int.Parse(s1[i].ToString()));
            }   
        }
        // ham check cac lai, neu rong thi xuat ra 1.
        // neu so thi xuat ra 2.?
        //neu chu thi xuat ra 3.?
        //neu thap cam chu so thi ra 4.?
        private int checktext(TextBox textBoxcheck)
        {
            if (textBoxcheck.Text.Trim() == "")
            {
                return 1;
            }
            return 0;
        }

        private void hienpanner(int p)
        {
            switch (p)
            {
                case 1:
                    panel1.Show();
                    break;
                case 2:
                    panel2.Show();
                    break;
                case 3:
                    panel3.Show();
                    break;
                case 4: //have boss
                    panel4.Show();
                    break;
                case 5:
                    panel5.Show();
                    break;
                case 6:
                    panel6.Show();
                    break;
                case 7: //boss
                    panel7.Show();
                    break;
                case 8:
                    panel8.Show();
                    break;
                case 9:
                    panel9.Show();
                    break;
                case 10:
                    panel10.Show();
                    break;
                case 11:
                    panel11.Show();
                    break;                
                default:                   
                    break;
            }
        }

    }
}
