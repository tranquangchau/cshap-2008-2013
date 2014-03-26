using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using TimeDown;
using System.Reflection;

namespace TimeDown
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            this.ControlBox = false;
            this.TopMost=true;
            InitializeComponent();            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MP3Player mp3 = new MP3Player();
            mp3.Close();
            this.Close();                                   
        }
    }
}
