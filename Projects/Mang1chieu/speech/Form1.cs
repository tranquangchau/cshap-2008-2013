using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpeechLib;
namespace speech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 3;
            trackBar1.Value = 60;
        }

        private void txt1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                SpVoice voice = new SpVoice();
                if (checkBox1.Checked == true)
                {
                   voice.Volume = 0;
                    //return;
                }
                else
                {
                    voice.Volume = trackBar1.Value;
                    //voice.Volume = 40;
                }
                voice.Speak(richTextBox1.Text, SpeechVoiceSpeakFlags.SVSFNLPMask);
            }
            else
                return;
        }

    }
}
