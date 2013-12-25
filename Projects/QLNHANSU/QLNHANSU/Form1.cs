using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNhanSu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void load()
        {
            ketnoi.openketnoi();
            //load listBox
            listBox1.DataSource = ketnoi.gettable("select *from phongban");
            listBox1.DisplayMember = "tenpb";
            listBox1.ValueMember = "mapb";
            //load datagirdview
            dataGridView1.DataSource = ketnoi.gettable("select *from nhanvien");
            btbchapnhan.Enabled = false;
            btbhuy.Enabled = false;
            ketnoi.dongketnoi();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dataGridView1.CurrentCell.RowIndex;
            textBox1.Text = dataGridView1.Rows[t].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[t].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[t].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[t].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[t].Cells[4].Value.ToString();
        }
        private int chon = 0;
        //Button sua
        private void btbsua_Click(object sender, EventArgs e)
        {
            chon = 2;
            btbchapnhan.Enabled = true;
            btbhuy.Enabled = true;
        }

        //Button them
        private void btbthem_Click(object sender, EventArgs e)
        {
            chon = 1;
            btbchapnhan.Enabled = true;
            btbhuy.Enabled = true;                
        }
        //thoat
        private void btbthoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?","Thông Báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
                Application.Exit();
        }

        private void btbxoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xoá!","Thông Báo", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                ketnoi.openketnoi();
                ketnoi.executeQuery("delete from nhanvien where manv="+dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()+"");
                load();
                ketnoi.dongketnoi();
            }
        }
        //nut chapnhan
        private void btbchapnhan_Click(object sender, EventArgs e)
        {
            if (chon == 1)//goi button them
            {
                ketnoi.openketnoi();
                ketnoi.executeQuery("insert into nhanvien values("+textBox1.Text+","+textBox2.Text+"," + DateTime.Parse(textBox3.Text)+","+int.Parse(textBox4.Text)+","+textBox5.Text+")");
                load();
                btbchapnhan.Enabled = true;
                btbhuy.Enabled = true;
            }
            else if (chon == 2)//goi button sua
            {
                ketnoi.openketnoi();
                ketnoi.executeQuery("update nhanvien set manv=" + textBox1.Text + "," + textBox2.Text + "," + DateTime.Parse(textBox3.Text) + "," + int.Parse(textBox4.Text) + "," + textBox5.Text +
                    "where textBox1=" + dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString() + ")");
                load();
                btbchapnhan.Enabled = true;
                btbhuy.Enabled = true;
                //textBox1=dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString()
            }
            else
            {
                chon = 0;
            }
        }

        private void btbhuy_Click(object sender, EventArgs e)
        {
            chon = 0;
        }
    }
}
