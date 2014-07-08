using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace file_folder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // xu ly file
        string file1 = "";
        private void button1_Click(object sender, EventArgs e)
        {
            file1 = textBox1.Text.Trim();
            if (file1 == "") //check file luu co chua.
            {
                MessageBox.Show("Chua nhap gi");
            }
            else
            {
                file1 = textBox1.Text;
                taofile(file1);
            }
        }

        private void taofile(string file)
        {            
            try
            {
                if (File.Exists(file)==false)
                {
                    File.Create(file).Close();
                    MessageBox.Show("Tao thanh cong");
                    file.Clone();
                }
                else
                    MessageBox.Show("File Ko tao duoc Vi da co roi!");
            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.ToString());
            }           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (file1 == "") //check file luu co chua.
            {
                MessageBox.Show("Chua nhap file luu");
            }
            else
            {
                richTextBox1.SaveFile(file1, RichTextBoxStreamType.RichText);
                MessageBox.Show("save OK");
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (file1 == "") //check file luu co chua.
            {
                MessageBox.Show("Chua Co file");
            }
            else
            Process.Start(file1);
        }
        // xu ly folder
        string folder = "";
        private void button3_Click(object sender, EventArgs e)
        {
            folder = textBox2.Text;
            taofolder(folder);
        }

        private void taofolder(string f)
        {
            if (Directory.Exists(folder) == false)
            {
                if (folder == "")
                {
                    MessageBox.Show("Folor chua co");
                }
                else
                {
                    Directory.CreateDirectory(f);
                    MessageBox.Show("Tao OK");
                }
            }
            else
                MessageBox.Show("Loi tao folder");            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (folder == "") //check file luu co chua.
            {
                MessageBox.Show("Chua co folder");
            }
            else
            Process.Start(folder);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //loadtxt();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            renamefolder(textBox2.Text,textBox3.Text);
        }

        private void renamefolder(string p,string p1)
        {

            if (p.Trim() == "" || p1.Trim() == "" || p.Trim() == null || p1.Trim() == null)
            {
                MessageBox.Show("Ten Folder Sai");
                return;
            }
            else
                //ne folder p chua co thi bao loio
                if (Directory.Exists(p)!=true)
                {
                    MessageBox.Show("Chua co file goc" + p.ToString());
                    return;
                }                
                //neu Folder p1 co roi xoa di va di chuyen p toi
                if ( Directory.Exists(p1) == true)
                {
                    Directory.Delete(p1);
                    MessageBox.Show("Da xoa Folder cu " + p1.ToString());
                }
            Directory.Move(p, p1);
            MessageBox.Show(p.ToString() + " folder -> " + p1.ToString());    
        }

        private void button7_Click(object sender, EventArgs e)
        {
            renamefile(textBox1.Text,textBox4.Text);
        }
        // doi ten file
        private void renamefile(string p, string p_2)
        {
            if (p.Trim() == "" || p_2.Trim() == "" || p.Trim() == null || p_2.Trim() == null)
            {
                MessageBox.Show("Ten File Sai");
                return;
            }
            else
                //neu file p_2 co roi xoa di va di chuyen p toi
                if (File.Exists(p)!=true)
                {
                    MessageBox.Show("Chua co file goc");
                    return;
                }
                if (File.Exists(p_2)==true)
                {
                    File.Delete(p_2);
                    MessageBox.Show("Da xoa file cu "+p_2.ToString());
                }                
                    File.Move(p, p_2);
                    MessageBox.Show(p.ToString() + " file -> " + p_2.ToString());                
        }
    }
}