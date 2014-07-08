using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace keykaraoke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //LoadFilesInDirectory(currentDirectory);
        }
        private void button1_Click(object sender, EventArgs e)
        {            
        }
        public void LoadFilesInDirectory(string currentDirectoryValue)
        {
            try
            {
                browserListView.Items.Clear();
               /// browserListView.Items.Add();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

    }
}
