using System;
using System.Collections.Generic;
//using System.Collections.Generic.List<t>;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("server=QUANGCHAU; database=ELEMENTARY; user id=sa; password=123");
            connection.Open();
            //SqlCommand command = new SqlCommand("select *from dogs1",connection);
            SqlDataAdapter a = new SqlDataAdapter("select * from dogs1",connection);
            DataTable t = new DataTable();
            a.Fill(t);
            dataGridView1.DataSource = t;
           /* lam sao co the viet duoc 1 ham de ma ke thua goi di goi lai co te.
            * co nghia la ke thua dung lai do 
            * 
            */
            dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Gray;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //connectdatabase();
            //TryCreateTable();
            //AddDog(2,"do","11 can");
            //textBox1.Text=DisplayDogs();
            //textBox1.Text=testlist();
            //user1();
            //user2(textBox1.Text, textBox2.Text);
            //DisplayDogs1(); dang xu ly
            AddDog(Convert.ToInt32(textBox1.Text),textBox2.Text,textBox3.Text);
            //Form1_Load(

            SqlConnection connection = new SqlConnection("server=QUANGCHAU; database=ELEMENTARY; user id=sa; password=123");
            connection.Open();
            //SqlCommand command = new SqlCommand("select *from dogs1",connection);
            SqlDataAdapter a = new SqlDataAdapter("select * from dogs1", connection);
            DataTable t = new DataTable();
            a.Fill(t);
            dataGridView1.DataSource = t;
            dataGridView1.ForeColor = Color.Red;
            dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Gray;
            

        }


        // ham kiem tra ket noi ok chua
        private void connectdatabase()
        {
            SqlConnection myconnection = new SqlConnection("server=QUANGCHAU; Database=QLNHANSU; user id=sa;password=123");
            try
            {
                myconnection.Open();
                MessageBox.Show("Well Done!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // ham them 1 table trong database
        static void TryCreateTable()
        {
            SqlConnection connect = new SqlConnection("server=QUANGCHAU; database=ELEMENTARY; user id=sa;password=123");
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand("create table dogs1 (weight int,name text, breed text)",connect);
                command.ExecuteNonQuery();
                MessageBox.Show("Ok");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //them 1 table voi cac cot truyen vao
        static void user1()
        {
            SqlConnection connect = new SqlConnection("server=QUANGCHAU; database=ELEMENTARY; user id=sa;password=123");
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand("create table taikhoan (user1 text, pass1 text)", connect);
                command.ExecuteNonQuery();
                MessageBox.Show("Ok create success table taikhoan-user,pass");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //add variablae
        static void AddDog(int weight,string name,string breed)
        {
            SqlConnection connect = new SqlConnection("server=QUANGCHAU; database=ELEMENTARY; user id=sa; password=123");
            connect.Open();
            try
            {
                SqlCommand command = new SqlCommand("insert into dogs1 values(@Weight,@name,@breed)",connect);
                command.Parameters.Add(new SqlParameter("Weight",weight));
                command.Parameters.Add(new SqlParameter("Name", name));
                command.Parameters.Add(new SqlParameter("Breed", breed));
                command.ExecuteNonQuery();
                MessageBox.Show("OK");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //add userpass
        static void user2(string user, string pass)
        {
            SqlConnection connect = new SqlConnection("server=QUANGCHAU; database=ELEMENTARY; user id=sa; password=123");
            connect.Open();
            try
            {
                SqlCommand command = new SqlCommand("insert into taikhoan values(@user1,@pass1)", connect);             
                command.Parameters.Add(new SqlParameter("user1", user));
                command.Parameters.Add(new SqlParameter("pass1", pass));
                command.ExecuteNonQuery();
                MessageBox.Show("OK tao userpass thanh cong");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // reader data
        static string DisplayDogs()
        {
            
            SqlConnection connection = new SqlConnection("server=QUANGCHAU; database=ELEMENTARY; user id=sa; password=123");
            connection.Open();
            SqlCommand command = new SqlCommand("select *from dogs1",connection);
            SqlDataReader reader = command.ExecuteReader();
            string str="";
            while (reader.Read())
            {
                int weight = reader.GetInt32(0);
                //string name = reader.GetString(1);
                //string breed = reader.GetString(2);
                //str += weight.ToString() + name + breed;
                str += weight.ToString();
            }
            return str;
        }
        // girl view
        static void DisplayDogs1()
        {
            SqlConnection connection = new SqlConnection("server=QUANGCHAU; database=ELEMENTARY; user id=sa; password=123");
            connection.Open();
            SqlCommand command = new SqlCommand("select *from dogs1", connection);
            SqlDataReader reader = command.ExecuteReader();
        }

        //test list
        private string testlist()
        {
            string str = "";
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(7);
            //foreach (int prime in list)
            //{
            //    str += prime;
            //}
            for (int i = 0; i < list.Count; i++)
            {
                //if (list[i] == 7) kiem tra xem co 7 trong chuoi khong
                //    return "ok";
                str +=list[i];
            }
                return str;
        }



    }
}
