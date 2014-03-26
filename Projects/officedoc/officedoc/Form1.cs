using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System;

namespace officedoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = "*.rtf|*.txt";
            open.Filter = "RTF Files (.rtf)|*.rtf|TXT Files (.txt)|*.txt";

            if (open.ShowDialog() == System.Windows.Forms.DialogResult.OK && open.FileName.Length > 0)
                if (open.FileName.Contains(".rtf"))
                    richTextBox1.LoadFile(open.FileName);                    
                else
                {
                    StreamReader sr = new StreamReader(open.FileName);
                    richTextBox1.Text = sr.ReadToEnd();
                    sr.Dispose();
                }
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            richTextBox1.Text = null;
        }
    }
}
