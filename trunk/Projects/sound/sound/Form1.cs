using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using sound;


namespace sound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MP3Player mp3 = new MP3Player();
            
            mp3.Open("media3.mid");
            mp3.Play(true);
            ////mp3.Close();

            

        }
    }
}
