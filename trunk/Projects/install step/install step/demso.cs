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
    public partial class demso : Form
    {
        public demso()
        {
            InitializeComponent();
        }

        public int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            i = i + 1;
            label1.Text = i.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = i - 1;
            label1.Text = i.ToString();
        }
    }
}
