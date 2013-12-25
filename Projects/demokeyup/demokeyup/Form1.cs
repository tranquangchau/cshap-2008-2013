using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace demokeyup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                MessageBox.Show("Hoho");
            if (e.KeyCode == Keys.F2)
                MessageBox.Show("Hehe");

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F12)
            {
             //   this.OnMaximumSizeChange;d
            }
            if (e.KeyCode == Keys.F11)
                //MessageBox.Show("OK");
                Help.ShowPopup(textBox1, "Enter now", new Point(textBox1.Left, this.textBox1.Bottom));
        }
        private bool nonNumberEnter = false;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(nonNumberEnter==true)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEnter = false;
            if(e.KeyCode<Keys.D0|| e.KeyCode>Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode!=Keys.Back)
                    {
                        nonNumberEnter = true;
                    }
                }
            }
            if (Control.ModifierKeys==Keys.Shift)
            {
                nonNumberEnter = true;
            }
        }
    }
}
