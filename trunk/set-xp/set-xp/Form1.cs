using System;
//using System.Collections.Generic;
using System.Windows.Forms;
//http://stackoverflow.com/questions/2079813/c-sharp-put-pc-to-sleep-or-hibernate

namespace set_xp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Suspend ,true,true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.SetSuspendState(PowerState.Hibernate, true, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Cho Máy Nghỉ \n Tạm Thời";
            label2.Text = "Cho Máy Tắt và \n Lưu Lại Chương Trình";
        }
    }
}
