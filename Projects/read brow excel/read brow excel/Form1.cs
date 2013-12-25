using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
                {
                // Mo hop thoai Dialog de tim den file Excel
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Title = "Chon file chua danh sach so dien thoai";
                ofd.Filter = "Các file Excel (*.xls) và *.txt|*.xls|*.txt|";
                ofd.ShowDialog();

                // Khai bao chuoi ket noi csdl
                string ConnectionString;

                ConnectionString = "provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Excel 8.0; " + "data source='" + ofd.FileName + "'; ";


                // Tao doi tuong ket noi
                OleDbConnection cn = new OleDbConnection(ConnectionString);
                cn.Open();

                // Tao doi tuong thuc thi cau lenh
                OleDbCommand cmd = new OleDbCommand("Select * from [Sheet1$] ", cn);
                DataSet ds = new DataSet();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(ds, "Danhsach");

                // gan du lieu vao dieu khien
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Danhsach";

                }
                catch (Exception ex) { MessageBox.Show("Khong ket noi duoc CSDL: " + ex.Message); }

                }
          }

    }