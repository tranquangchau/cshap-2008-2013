using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace NhatKy
{
    public partial class frmDayli : Form
    {
        public frmDayli()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {         
            richTextBox1.Clear();
            if (listBox1.SelectedIndex<0)
            {
                return;
            }
            else
            {
                string str = listBox1.SelectedItem.ToString();
                string str1 = string.Format("dayli/" + str + ".txt");
                StreamReader sr = new StreamReader(str1);
                richTextBox1.Text = sr.ReadToEnd();
                //MessageBox.Show(sr.ReadToEnd());
                sr.Close();
                sr.Dispose();
                //button4.Enabled = true;
                label1.Text = DateTime.Now.ToString();
                //button5.Enabled = true;
            }
        }

        //load du lieu ngay trong nam
        public void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            richTextBox1.ReadOnly = true;
            StreamReader sr = new StreamReader("data/list.txt");
            string input;
            input=sr.ReadLine();
            while(input != null)
            {
                listBox1.Items.Add(input);
                input = sr.ReadLine();
            }
            sr.Close();
            sr.Dispose();
            listBox1.SelectedItem = 1;
           // button5.Enabled = false;            
        }
        // tao file trong 1 thang nhap vao i1 la so ngay i2 la thang
        private void taofile(int i1,int i2)
        {
            string str; string st ;
            StreamWriter sw = new StreamWriter("data/list.txt",true,Encoding.Default);
            for (int i=1; i <= i1; i++)
            {
                str = string.Format("dayli/"+i2+"-" + i.ToString() + ".txt");
                st = string.Format(i2+ "-" + i.ToString());
                sw.WriteLine(st);
                FileStream fs;
                fs = new FileStream(str, FileMode.Create);
                fs.Close();
            }
            sw.Close();
            sw.Dispose();
            //MessageBox.Show("Xong roi");
        }
        // ham tra ra chuoi string ngay hien tai theo dinh dang 12-10
        private string subngay()
        {
            string str = DateTime.Now.ToString();            
            int a = 0, b = 0;
            string str2 = null, str3;
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i, 1) == "/")
                    a = a + 1;
                if (a == 2)
                {
                    b = i;
                    break;
                }
            }
            str2 = str.Substring(0, b);
            str3 = str2.Replace('/', '-');
            return str3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string str0 = string.Format("dayli/"+subngay()+".txt");
            //richTextBox1.Clear();           
            //StreamReader sr1 = new StreamReader(str0);
            //richTextBox1.Text = sr1.ReadToEnd();            
            //sr1.Close();
            //sr1.Dispose();
            //richTextBox1.ReadOnly = true;
            //label1.Text = DateTime.Now.ToString();
            //listBox1.SelectedItem = subngay();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //richTextBox1.ReadOnly = false;
            //button2.Enabled = false;
            //button5.Enabled = true;
            //button4.Enabled = false;
            //richTextBox1.AppendText("\n"+DateTime.Now.ToString()+"\n");
        }

        private void button5_Click(object sender, EventArgs e)
        {            
            if ((listBox1.SelectedIndex < 0)||(richTextBox2.Text==""))
            {
                return;
            }
            else
            {
                string str11 = listBox1.SelectedItem.ToString();
                string str = string.Format("dayli/" + str11 + ".txt");
                StreamWriter sw = new StreamWriter(str, true, Encoding.UTF8);                
                foreach (string line in richTextBox2.Lines)
                {
                    sw.WriteLine(line);
                }                
                sw.Close();
                sw.Dispose();
                MessageBox.Show("Đã lưu ngày của bạn " + str11);
                string str1 = string.Format("dayli/" + str11 + ".txt");
                StreamReader sr = new StreamReader(str1);
                richTextBox1.Text = sr.ReadToEnd();                
                sr.Close();
                sr.Dispose();
                richTextBox2.Clear();
            }
        }

        private void frmDayli_Load(object sender, EventArgs e)
        {
            //load cac danh muc roi cho vao listbox1
            richTextBox1.ReadOnly = true;
            StreamReader sr = new StreamReader("data/list.txt");
            string input;
            input = sr.ReadLine();
            while (input != null)
            {
                listBox1.Items.Add(input);
                input = sr.ReadLine();
            }
            sr.Close();
            sr.Dispose();
            listBox1.SelectedItem = 1;

            //tu load ngay hom nay

            string str0 = string.Format("dayli/" + subngay() + ".txt");
            richTextBox1.Clear();
            StreamReader sr1 = new StreamReader(str0);
            richTextBox1.Text = sr1.ReadToEnd();
            sr1.Close();
            sr1.Dispose();
            richTextBox1.ReadOnly = true;
            label1.Text = DateTime.Now.ToString();
            listBox1.SelectedItem = subngay();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            richTextBox2.AppendText(DateTime.Now.ToString()+"\n");            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //xu li chon tung dong va thay open
            richTextBox1.Clear();
            if (listBox1.SelectedIndex < 0)
            {
                return;
            }
            else
            {
                string str = listBox1.SelectedItem.ToString();
                string str1 = string.Format("dayli/" + str + ".txt");
                StreamReader sr = new StreamReader(str1);
                richTextBox1.Text = sr.ReadToEnd();
                //MessageBox.Show(sr.ReadToEnd());
                sr.Close();
                sr.Dispose();
                //button4.Enabled = true;
                label1.Text = DateTime.Now.ToString();
                //button5.Enabled = true;
            }
        }        
    }
}
