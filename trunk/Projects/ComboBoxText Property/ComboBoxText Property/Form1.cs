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
        internal System.Windows.Forms.ComboBox comboBox1;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1 = new ComboBox();
            this.comboBox1.Location = new System.Drawing.Point(128,48);
            //this.comboBox1.Name = "ComboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "Typical";
            string[] installs = new string[] { "Typical", "Compact", "Custom" };
            comboBox1.Items.AddRange(installs);
            this.Controls.Add(this.comboBox1);
            //this.comboBox1.DropDown += new System.EventHandler(comboBox1_DragDrop);
        }

        private void comboBox1_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("Typical installation is strong", "Install information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
