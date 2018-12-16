using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HtmlRichTextBox
{
    public partial class Form3 : Form
    {
        string main_folder = "./data/";
        string sub_folder = "php/";
        string lists_file_lv1 = "a.txt";
        string folder_content_lv11 = "content/";        
        string folder_lv13_key = "key/";
        string folder_lv12_history = "history/";
        string folder_lv12_21_keylist = "keylist/";
        string[] glb_listcurrent = new string[7];

        public Form3()
        {
            InitializeComponent();
            

            glb_listcurrent[0] = "";//richtext1 name file
            glb_listcurrent[1] = "";//listbox 2 name file
            glb_listcurrent[2] = "";//listbox 3 name file
            
            glb_listcurrent[4] = main_folder + sub_folder + lists_file_lv1; //listbox 1 name file
            glb_listcurrent[5] =""; //listbox 3 name file            
            glb_listcurrent[3] = "";//richtext 2 name file
            glb_listcurrent[6] = "";//folder of history file

            //string tem_file = main_folder + sub_folder + lists_file_lv1;
            loadlistbox(listBox1, glb_listcurrent[4]);
            active_0_listbox(listBox1);
        }
        private void text_bool(RichTextBox html_text, string type)
        {
            switch (type)
            {
                case "Bold":
                    {
                        if (html_text.SelectionFont != null)
                        {
                            html_text.SelectionFont = new Font(html_text.SelectionFont, html_text.SelectionFont.Style ^ FontStyle.Bold);
                        }

                    }
                    break;
                case "Italic":
                    {
                        if (html_text.SelectionFont != null)
                        {
                            html_text.SelectionFont = new Font(html_text.SelectionFont, html_text.SelectionFont.Style ^ FontStyle.Italic);
                        }
                    }
                    break;

                case "Underline":
                    {
                        if (html_text.SelectionFont != null)
                        {
                            html_text.SelectionFont = new Font(html_text.SelectionFont, html_text.SelectionFont.Style ^ FontStyle.Underline);
                        }
                    }
                    break;
                case "Font":
                    {
                        if (html_text.SelectionFont != null)
                            fontDialog1.Font = html_text.SelectionFont;
                        else
                            fontDialog1.Font = html_text.Font;

                        if (fontDialog1.ShowDialog() == DialogResult.OK)
                        {
                            if (html_text.SelectionFont != null)
                                html_text.SelectionFont = fontDialog1.Font;
                            else
                                html_text.Font = fontDialog1.Font;
                        }
                    }
                    break;

                case "Color":
                    {
                        colorDialog1.Color = html_text.SelectionColor;

                        if (colorDialog1.ShowDialog() == DialogResult.OK)
                        {
                            html_text.SelectionColor = colorDialog1.Color;
                        }
                    }
                    break;
            }

        }

        private void check_create_file_folder(string file_name) {
            if (!Directory.Exists(Path.GetDirectoryName(file_name)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(file_name));
            }
            if (File.Exists(file_name) == false)
            {
                File.Create(file_name).Close();
            }
        }
        
        //load data for list box
        private void loadlistbox(ListBox tem_listbox, string file_name)
        {
            check_create_file_folder(file_name);

            tem_listbox.Items.Clear();
            
            int z0 = 0;
            using (StreamReader sr = new StreamReader(file_name))
            {
                z0 = -1;
                while (!sr.EndOfStream)
                {
                    tem_listbox.Items.Add(sr.ReadLine());
                    z0 = z0 + 1;
                }
            }
        }
        //add line data for list box (add new line file)
        private void add_line_listbox(ListBox tem_listbox, string file_name, string str_line)
        {
            if (str_line != "")
            {
                StreamWriter sw = new StreamWriter(file_name, true, Encoding.UTF8);
                sw.WriteLine(str_line);
                sw.Close();
                //textBox1.Text = "";
                //textBox1.Focus();
            }
            else return;
        }
        private void update_list_box(ListBox tem_listbox, string file_name, int index, string new_text)
        {
            if (new_text.Trim() != "")
            {
                tem_listbox.Items[index] = new_text;
                int k = 0;
                using (StreamWriter sw = new StreamWriter(file_name, false, Encoding.UTF8))
                {
                    foreach (string item in tem_listbox.Items)
                    {
                        if (k == index)
                        {
                            sw.WriteLine(new_text.Trim());
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
        private void load_content_richtext(HtmlRichText.HtmlRichTextBox htmlrichtext,string file_name) {
            check_create_file_folder(file_name);


            //load
            // Read the HTML format
            //string strname = "a.html";
            string strname = file_name;
            StreamReader sr = File.OpenText(strname);
            string strHTML = sr.ReadToEnd();
            sr.Close();
            //htmlRichTextBox2.Clear();
            //htmlRichTextBox2.AddHTML(strHTML);
            htmlrichtext.Clear();
            htmlrichtext.AddHTML(strHTML);
        }
        private void save_content_richtext(HtmlRichText.HtmlRichTextBox htmlrichtext, string file_name)
        {
            check_create_file_folder(file_name);
            /*
            //load
            // Read the HTML format
            //string strname = "a.html";
            string strname = file_name;
            StreamReader sr = File.OpenText(strname);
            string strHTML = sr.ReadToEnd();
            sr.Close();
            //htmlRichTextBox2.Clear();
            //htmlRichTextBox2.AddHTML(strHTML);
            htmlrichtext.Clear();
            htmlrichtext.AddHTML(strHTML);
            */
            ///////////
            //save
            //string strname = "a.html";
            //string strExt = System.IO.Path.GetExtension(file_name).ToLower();
            try
            {
                // save as HTML format
                
                string strText = htmlrichtext.GetHTML(true, true);
                
                if (File.Exists(file_name))
                    File.Delete(file_name);

                StreamWriter sr = File.CreateText(file_name);
                sr.Write(strText);
                sr.Close();
                
                //StreamWriter sw = new StreamWriter(file_name, true, Encoding.UTF8);
                //sw.WriteLine(strText);
                //sw.Close();
            }
            catch
            {
                MessageBox.Show("There was an error saving the file: " + file_name);
            }
        }
        private void save_list_box(ListBox temlistbox,string file_name) {
            if (file_name!="" && temlistbox.Items.Count>0)
            using (StreamWriter sw = new StreamWriter(file_name))
            {
                foreach (string item in temlistbox.Items)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.Close();
            }
        }
        private void active_0_listbox(ListBox tem_listbox) {            
            if (tem_listbox.Items.Count > 0) {
                tem_listbox.SelectedIndex = 0;
            }            
        }
        
        //end function list 

        Boolean is_show_history = true;
        private void button10_Click(object sender, EventArgs e)
        {

            if (is_show_history)
            {
                splitContainer3.Panel2Collapsed = true;
                this.splitContainer3.IsSplitterFixed = true;
                this.splitContainer3.Panel2.Hide();
                is_show_history = false;
            }
            else
            {
                is_show_history = true;
                this.splitContainer3.Panel2.Show();
                splitContainer3.Panel2Collapsed = false;
                this.splitContainer3.IsSplitterFixed = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            text_bool(htmlRichTextBox1, "Bold");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text_bool(htmlRichTextBox1, "Italic");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text_bool(htmlRichTextBox1, "Underline");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            text_bool(htmlRichTextBox1, "Font");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            text_bool(htmlRichTextBox1, "Color");
        }

        private void button8_Click(object sender, EventArgs e)
        {

            save_content_richtext(htmlRichTextBox1,glb_listcurrent[0]);

            //save listbox3 new record
            string date_at = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
            listBox3.Items.Add(date_at);
            string tem_file = glb_listcurrent[5];
            save_list_box(listBox3, tem_file);
            //save richtext2 data rictech 1
            //glb_listcurrent[3] = glb_listcurrent[6] + listBox3.SelectedIndex.ToString() + ".html";
            glb_listcurrent[3] = glb_listcurrent[6] + (listBox3.Items.Count-1).ToString() + ".html";
            
            //save richtextbox1 for file rictext2
            save_content_richtext(htmlRichTextBox1, glb_listcurrent[3]);            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //load
            // Read the HTML format
            //string strname = "a.html";
            /*
            StreamReader sr = File.OpenText(strname);
            string strHTML = sr.ReadToEnd();
            sr.Close();
            htmlRichTextBox2.Clear();
            htmlRichTextBox2.AddHTML(strHTML);
            */
            //tesxt
            load_content_richtext(htmlRichTextBox2, glb_listcurrent[0]);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //two center split
            this.splitContainer3.SplitterDistance = this.splitContainer3.ClientSize.Width/2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //add list left
            //add list right           
            if (textBox1.Text.Trim() != "")
            {
                listBox1.Items.Add(textBox1.Text.Trim());
                string tem_file = glb_listcurrent[4];
                //glb_listcurrent[4]
                save_list_box(listBox1, tem_file);
                //MessageBox.Show(tem_file);
            }
            textBox1.Text = "";
            htmlRichTextBox1.Text="";
            htmlRichTextBox2.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //add list right           
            if (textBox2.Text.Trim() != "")
            {
                listBox2.Items.Add(textBox2.Text.Trim());
                string tem_file = glb_listcurrent[1];
                save_list_box(listBox2, tem_file);
            }
            textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update list left
            string txt_tem=textBox1.Text;
            update_list_box(listBox1,glb_listcurrent[4], listBox1.SelectedIndex, txt_tem);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //delete right
            listBox2.Items.Remove(listBox2.SelectedItem);
            //savelist(folder2 + file);
            //readfile1(folder2 + file);
            string tem_file = glb_listcurrent[1];
            save_list_box(listBox2, tem_file);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string indexid_file = listBox1.SelectedIndex.ToString() + ".html";
            //load richtext for 1

            //old change
            if (glb_listcurrent[0]!="") {
                save_content_richtext(htmlRichTextBox1, glb_listcurrent[0]);
            }
            
            //new change

            glb_listcurrent[0] = main_folder + sub_folder + folder_content_lv11 + listBox1.SelectedIndex.ToString() + ".html";
            glb_listcurrent[1] = main_folder + sub_folder + folder_lv13_key + listBox1.SelectedIndex.ToString() + ".txt";
            glb_listcurrent[2] = main_folder + sub_folder + folder_lv12_history + listBox1.SelectedIndex.ToString() + ".txt";
            //glb_listcurrent[3] = main_folder + sub_folder + folder_lv12_history + listBox1.SelectedIndex.ToString() + ".html";
            glb_listcurrent[5] = main_folder + sub_folder + folder_lv12_history + folder_lv12_21_keylist + listBox1.SelectedIndex.ToString() + ".txt";
            glb_listcurrent[6] = main_folder + sub_folder + folder_lv12_history +  listBox1.SelectedIndex.ToString() + "/";

            load_content_richtext(htmlRichTextBox1, glb_listcurrent[0]);
            
            loadlistbox(listBox2, glb_listcurrent[1]);
            //active_0_listbox(listBox2);

            loadlistbox(listBox3, glb_listcurrent[5]);
            //active_0_listbox(listBox3);
            
            //load listBox2

            //load listBox3
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //save richtext curent history

            if (glb_listcurrent[3] != "") {
                //save_content_richtext(htmlRichTextBox2, glb_listcurrent[3]);
            }
            

            //load richtext new
            glb_listcurrent[3] = glb_listcurrent[6] + listBox3.SelectedIndex.ToString() + ".html";            
            load_content_richtext(htmlRichTextBox2, glb_listcurrent[3]);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            save_content_richtext(htmlRichTextBox2, glb_listcurrent[3]);
        }        
       
    }
}
