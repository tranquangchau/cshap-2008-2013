using System;
//using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text;
//using System.Threading;

namespace Manage_qa
{
    class DungChung
    {
        //load subfolder in listbox1
        public static void folderload(ListBox listBox1)
        {
            listBox1.Items.Clear();
            DirectoryInfo directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            DirectoryInfo[] directories = directory.GetDirectories();
            foreach (DirectoryInfo folder in directories)
            {
                listBox1.Items.Add(folder.Name);
            }            
        }
        //them folder
        public static void folderadd(string st)
        {
            if (st.Trim() == "")
            {
                MessageBox.Show("Ten La Rong");
                return;
            }
            else
            {
                if (Directory.Exists(st.Trim()) == false)
                {
                    try
                    {
                        Directory.CreateDirectory(st.Trim());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }                    
                }
                else
                {
                    MessageBox.Show("Da Ton Tai Thu Muc " + st.ToString());
                }
            }
        }
        //doi ten folder p folder cu, p1 folder moi
        public static void folderrename(string p,string p1)
        {
            if (p.Length == 0 || p1.Length == 0)
            {
                MessageBox.Show("Rong");
                return;
            }
            if (p.Trim()==p1.Trim())
            {
                MessageBox.Show("Trung Nhau");
                return;
            }
            if (p.Trim() == "" || p1.Trim() == "" || p == null || p1 == null)
            {
                MessageBox.Show("Ten Folder Sai");
                return;
            }
            else
                //ne folder p chua co thi bao loio
                if (Directory.Exists(p) != true)
                {
                    MessageBox.Show("Chua co Folder goc" + p.ToString());
                    return;
                }
            //neu Folder p1 co roi xoa di va di chuyen p toi
            if (Directory.Exists(p1) == true)
            {
                try
                {
                    Directory.Delete(p1);
                }
                catch (Exception)
                {                                      
                    MessageBox.Show("Da Ton Tai Folder");
                    return;
                }
                
                //MessageBox.Show("Da xoa Folder cu " + p1.ToString());
            }
            Directory.Move(p, p1);
            MessageBox.Show(p.ToString() + " folder -> " + p1.ToString());    
        }
        //listbox load st la file, listboxload la Listbox truyen vao.
        public static void listboxload(string st, ListBox listBoxload)
        {
            listBoxload.Items.Clear();
            if (st.Trim()=="")
            {
                return;
            }
            else
            {
                if (File.Exists(st)==false)
                {
                    File.Create(st).Close();
                }
                using (StreamReader sd = new StreamReader(st))
                {
                    while (!sd.EndOfStream)
                    {
                        listBoxload.Items.Add(sd.ReadLine());
                    }                    
                }                
            }
        }
        //listbox add
        public static void listboxadd(string st,string file)
        {
            if (st.Trim() != "")
            {
                StreamWriter sw = new StreamWriter(file, true, Encoding.UTF8);
                sw.WriteLine(st);
                sw.Close();                
            }
            else return;            
        }
        //listbox update.
        public static void listboxupdate(ListBox listboxUpdate, int p, string st, string file)
        {
            if (st.Trim() != "")
            {
                int k = 0;
                using (StreamWriter sw = new StreamWriter(file, false, Encoding.UTF8))
                {
                    foreach (var item in listboxUpdate.Items)
                    {
                        if (k == p)
                        {
                            sw.WriteLine(st);
                        }
                        else
                        {
                            sw.WriteLine(item.ToString());
                        }
                        k++;
                    }
                    sw.Close();
                }
            }
            else
                return; 
        }
		// new a file 
        public static void fileadd(string file)
        {
            if (file.Trim() != "")
            {
                if (File.Exists(file) == false)
                {
                    File.Create(file);
                }
                else
                    MessageBox.Show("File Da Co Roi!");
            }
            else 
                return;
        }
        // do lon cua file.
        public static int k=0;
        //load cac file index.
        public static string fileati(int i1, string file)
        {
            if (File.Exists(file) == false)
            {
                File.Create(file).Close();
                File.AppendAllText(file, DateTime.Now.ToString() + "\n");
            }
            string[] st = File.ReadAllLines(file);
            k = st.Length;
            if (st.Length==0)
            {
                File.AppendAllText(file, DateTime.Now.ToString() + "\n");
                return DateTime.Now.ToString();
            }
           // MessageBox.Show("i1,k"+i1.ToString()+k.ToString());
            return st[i1];
        }
		
		// load data from file txt to richtexbox
        public static void richtextloadtxt(RichTextBox richtexbox, string file)
        {
            if (File.Exists(file)==false)
            {
                File.Create(file).Close();
               // File.AppendAllText(file, "Noi dung" + "\n");
            }
            StreamReader sd = new StreamReader(file);
            richtexbox.Text=sd.ReadToEnd() ;
            sd.Close();
        }
		// save richtexbox to file txt		
        public static void richtextsavetxt(RichTextBox richtexbox, string file)
        {
            StreamWriter sw = new StreamWriter(file, false, Encoding.UTF8);
            for (int i = 0; i < richtexbox.Lines.Length; i++)
            {
                sw.WriteLine(richtexbox.Lines[i]);
            }
            sw.Flush(); sw.Close();
        }
		// insert "\n" in to string
        public static string stringcatchuoi(string st)
        {
            string s2="";
            s2 = st;
            if (s2.Length <= 60)
            {
                return s2;
            }
            else
                return s2.Insert(60, "\n");
        }
    }
}
