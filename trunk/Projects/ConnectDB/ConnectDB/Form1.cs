using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=QUANGCHAU; user ID=sa;password =123; Database=dbusername;");
            try
            {
                con.Open();
                MessageBox.Show("Ket Noi Thanh Cong");
            }
            catch
            {
                MessageBox.Show("KEt Noi that bai");
            }
        }
    }
}
