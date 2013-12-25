using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TimeManagee
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }
        //protected int i;
        public string str;
        private void First_Load(object sender, EventArgs e)
        {
            //i =Convert.ToInt32(comboBox1.SelectedIndexChanged.tostring);
            //khai bao noi doc file
            string filetxt = "text.txt";
            //kiem tra file ton tain
            FileStream fs=null;
            if (!File.Exists(filetxt))
            {
                using (fs = File.Create(filetxt))
                { }
            }
            // doc file ra richtextbox
            try 
            {
                using (StreamReader sr = new StreamReader(filetxt))
                {
                    // .Text = sr.ReadToEnd();
                }
            }
            catch
            {
                MessageBox.Show("The file could not be read:");
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Second se = new Second();
            se.Show();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            str = comboBox1.Text;
        }
    }
    public static class bientoancuc
    {
       public static int i10 = 10;
        
    }
}
