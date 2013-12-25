using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int demso()
        {
            int num1;
            StreamReader re = new StreamReader("line.txt");
            string num = re.ReadLine();
            num1 = int.Parse(num.Trim());
            re.Close();
            return num1;
        }
        //cập nhật lại số sau khi thêm một lưu với số int vào 
        public void demso1(int sohientai)
        {            
            StreamWriter wr = new StreamWriter("line.txt");
            wr.WriteLine(sohientai.ToString());
            wr.Close();
        }
        //public luu cac so tu 1 den so hien tai moi luu va file list
        public void luulist(string s)
        {
            StreamWriter wr = new StreamWriter("list.txt",true, Encoding.Default);
            wr.WriteLine(s);
            wr.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Kiểm tra ô nhập vào gì chưa mà đòi lưu
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Chưa nhập gì cả");
            }
            else            
            {
                //kiểm tra xem có thu mucj cauhoi chua neu chua thi tao moi
                if (!Directory.Exists("cauhoi"))
                    Directory.CreateDirectory("cauhoi");
                //tao moi file 
                FileStream fs;
                int sohientai=demso();
                string a = " "+textBox1.Text;
                string st1 = string.Format("cauhoi/"+@"{0}{1}.txt",sohientai.ToString(),a);
                int leng = st1.Length;
                luulist(st1);
                //bat dau tao file
                fs = new FileStream(st1, FileMode.Create);
                fs.Close();
                fs.Dispose();
                // viết tiếp kết quả vào file trả lời
                StreamWriter tex = new StreamWriter(st1, true, Encoding.UTF8);
                tex.WriteLine(DateTime.Now);
                foreach (string line in richTextBox1.Lines)
                {
                    tex.WriteLine("\t" + line);
                }
                tex.Close();
                tex.Dispose();
                MessageBox.Show("OK");
                demso1(sohientai + 1);
                this.Close();                
            }
        }
    }
}
