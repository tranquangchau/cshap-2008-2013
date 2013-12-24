using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("file rtf", "Thông Báo Mở File");
            //OpenFileDialog openFile1 = new OpenFileDialog();
            //openFile1.DefaultExt = "*.rtf";
            //openFile1.Filter = "RTF Files|*.rtf";
            //if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFile1.FileName.Length > 0)
            //{
            //    richTextBox1.LoadFile(openFile1.FileName);
            //}
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(@"C:\Documents and Settings\Admin\Desktop\imageAdoNetModel.GIF");
            OpenFileDialog openFile1 = new OpenFileDialog();
            openFile1.DefaultExt = "*.rtf";
            openFile1.Filter = "RTF Files|*.rtf";
            if (openFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFile1.FileName.Length > 0)
            {
                richTextBox1.LoadFile(openFile1.FileName);
            }
           
        }
    }
}
