using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keydown
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

      

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar=='W')
            {
                pictureBox1.Top -= 10;
             
            }
            if (e.KeyChar == 'S')
            {
                pictureBox1.Top += 10;
             
            }
            if (e.KeyChar == 'A')
            {
               pictureBox1.Left -= 10;
            }
            if (e.KeyChar == 'D')
            {
                pictureBox1.Left += 10;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode==Keys.F)
            //{
            //    MessageBox.Show("a");
            //}
             if ((e.KeyCode==Keys.A) && (e.Alt==true))
            {
                e.Handled = true;
                MessageBox.Show("adf");
            }
           
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            //Form1_KeyDown( sender,  e);
           // this.KeyDown+=new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (keydown.Form1.ActiveForm.Activate()==Keys.F)
            //{
              //  MessageBox.Show("chau");
            //}
            Form1.ActiveForm.KeyPress += new KeyPressEventHandler(Form1_KeyPress); 
        }
}

        

    

       
    }

