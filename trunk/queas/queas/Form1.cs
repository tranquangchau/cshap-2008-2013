using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace queas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //button2_Click(sender,e);            
        }
        public int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {            
            if (i >= k-1 )
            {                
                i = k-1 ;
            }
            else
            {
                i=i+1;
            }
            label1.Text = loadlist(i);
            loadfile1(richTextBox1, i.ToString());
        }
        int k = 0; //bien max cua file x.txt
        private string loadlist(int i1)
        {
            if (File.Exists("x.txt")==false)
            {
                File.Create("x.txt").Close();
                File.AppendAllText("x.txt", DateTime.Now.ToString()+"\n");
            }
            string[] st = File.ReadAllLines("x.txt");
            k = st.Length;
            //MessageBox.Show("i,k"+i.ToString()+k.ToString());
            return st[i1];
        }
        private void button2_Click(object sender, EventArgs e)
        {                      
            if (i <= 0)
            {                
                i = 0;
            }
            else
            {
                i--;
            }
            label1.Text = loadlist(i);
            loadfile1(richTextBox1, i.ToString());
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button2.PerformClick();
        }
        string folder = "./data/";
        private void taofile(string file)
        {
            try
            {
                if (Directory.Exists(folder)==false)
                {
                    Directory.CreateDirectory(folder);
                }
                if (File.Exists(file) == false)
                {
                    File.Create(file).Close();
                    //MessageBox.Show("Da tao file thanh cong"+file);
                    file.Clone();
                }
                else
                    return;
                    //MessageBox.Show("File Ko tao duoc Vi da co roi!");
                //loadfile1(richTextBox1,);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void loadfile1(RichTextBox richTextBox_1, string p)
        {
            taofile(folder+p+".txt");
            StreamReader sr = new StreamReader(folder+p+".txt");
            richTextBox_1.Text = sr.ReadToEnd();            
            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            savefileok(richTextBox1,i.ToString());
        }

        private void savefileok(RichTextBox richTextBoxok, string p)
        {
            StreamWriter sw = new StreamWriter(folder+p+".txt",false,Encoding.UTF8);
            for (int i = 0; i < richTextBoxok.Lines.Length; i++)
            {
                sw.WriteLine(richTextBoxok.Lines[i]);
            }
            //foreach (var item in collection)            
            sw.Flush();
            sw.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {            
            Form2 fr = new Form2();
            fr.Show();
        }       
    }
}
