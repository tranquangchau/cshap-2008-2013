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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                SqlConnection connection = new SqlConnection("server=QUANGCHAU; database=ELEMENTARY; user id=sa; password=123");
                connection.Open();
                string userText=textBox1.Text;
                string passText = textBox2.Text;
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(Username, '') AS Username, ISNULL(Password,'') AS Password FROM Users WHERE Username='" + userText + "' and Password='" + passText + "'", connection);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   // MessageBox.Show(userText + " / " + dr["Username"].ToString());
                   // MessageBox.Show(passText + " / " + dr["Password"].ToString());
                    if (dr["Username"].ToString().Trim() == userText && dr["Password"].ToString().Trim() == passText)
                    {
                        
                        //Dashboard dashboard = new Dashboard();
                        Form1 fr=new Form1();
                        fr.Show();
                       // dashboard.ShowDialog();
                        //this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                }
                dr.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
