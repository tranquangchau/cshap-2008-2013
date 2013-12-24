using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
        }
        public static int j=0;
        public static bool co;
        private void button1_Click(object sender, EventArgs e)
        {
            
            capnhattex();
            if (co == true) return;
            j = j + 1;
            button1.Text = "";
            button1.Text = j.ToString();
        }

        private void capnhattex()
        {
            List<string> lines = new List<string>();
            using (var sr = new StreamReader("t.txt"))
            {
                while (sr.Peek() > 0)
                    lines.Add(sr.ReadLine());
            }
            for (int i = 0; i < lines.Count; i++)
            {
                if (i == j) richTextBox1.Text =lines[i];
                if (i < j) co = true;
                else co = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = "";
            button3.Text = j.ToString();            
            if (j < 1)
            { return; }
            else                        
            j = j - 1;
            capnhattex();
        }
    }
}
