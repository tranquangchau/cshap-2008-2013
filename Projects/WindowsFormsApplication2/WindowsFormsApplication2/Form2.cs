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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            //doc file quiz.txt lên listBox1
                StreamReader Re = new StreamReader("quiz.txt", Encoding.Default);
                string input;
                input = Re.ReadLine();
                while (input != null)
                {
                    listBox1.Items.Add(input);
                    input = Re.ReadLine();
                }
                Re.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Kiểm tra ô nhập vào gì chưa mà đòi lưu
            if (richTextBox1.Text == "")
            {
                MessageBox.Show("Chưa nhập gì cả");
            }
            else
            //kiểm tra xem có file nào traloi.txt không nếu không có thì tạo và đóng các luồng xử lý tới file traloi.txt này
            {                
                if (!File.Exists("dulieu/traloi.txt"))
                {
                    if (!Directory.Exists("dulieu"))
                        Directory.CreateDirectory("dulieu");

                    FileStream fs;
                    fs = new FileStream("dulieu/traloi.txt", FileMode.Create);
                    fs.Close();
                    fs.Dispose();
                }
                // viết tiếp kết quả vào file trả lời
                StreamWriter tex = new StreamWriter("dulieu/traloi.txt", true, Encoding.UTF8);
                
                tex.WriteLine(DateTime.Now);
                foreach (string line in richTextBox1.Lines)
                {
                    tex.WriteLine("\t" + line);
                }
                tex.Close();
                tex.Dispose();
                MessageBox.Show("Đã trả lời thành công");
                this.Close();
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 fr = new Form3();
            fr.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //StreamReader re1 = new StreamReader("dulieu/traloi.txt", Encoding.Default);
            //string slen = re1.ReadToEnd();
            //label2.Text = slen.Length.ToString();
            //re1.Close();
            //label1.Text = richTextBox1.SelectionLength.ToString();
            label1.Text = richTextBox1.TextLength.ToString();
        }
    }
}
