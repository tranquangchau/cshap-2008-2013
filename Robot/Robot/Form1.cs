using System;
using System.Drawing;
using System.Windows.Forms;

namespace Robot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            button1.Location = new Point(10,10);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard. 
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad. 
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace. 
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed. 
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                        button1.Text = "true";
                    }
                }
            }
            //If shift key was pressed, it's not a number. 
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
            if (e.KeyCode==someKey)
            {
                MessageBox.Show("chau");
            }
        }

        bool nonNumberEntered = false;
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar==13)
            {
                MessageBox.Show("Helo");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            
        }
    }
}
