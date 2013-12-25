using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KetNoiCSDL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection();
            connection = DB.getConnection();
            if (connection.State.ToString() == "Open")
                this.label1.Text = "Da ket noi thanh cong";
            else
                this.label1.Text = "Khong the ket noi toi CSDL";

        }
    }
}
