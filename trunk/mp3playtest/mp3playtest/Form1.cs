using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using NAudio;
using NAudio.Wave;
using NAudio.Gui;
//http://naudio.codeplex.com/wikipage?title=MP3

using System.Windows.Forms;

namespace mp3playtest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            playnhac();
        }
        private void playnhac()
        {
            IWavePlayer waveOutDevice;
            AudioFileReader audioFileReader;
            waveOutDevice = new WaveOut();
            audioFileReader = new AudioFileReader("animal.mp3");
            waveOutDevice.Init(audioFileReader);
            waveOutDevice.Play();
            
        }
    }
}
