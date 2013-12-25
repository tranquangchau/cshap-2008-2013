using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TimeManagee
{
    public partial class Second : Form
    {
        public Second()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
     
        public int i1 = bientoancuc.i10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            lblgoaler.Text = i1.ToString();
            i1--;
            timer1.Enabled = true;
        }
    }
}
