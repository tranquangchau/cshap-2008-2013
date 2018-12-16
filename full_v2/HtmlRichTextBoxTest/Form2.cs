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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            text_bool(htmlRichTextBox1, "Bold");
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            text_bool(htmlRichTextBox1, "Italic");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            text_bool(htmlRichTextBox1, "Underline");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            text_bool(htmlRichTextBox1, "Font");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            text_bool(htmlRichTextBox1, "Color");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string strname= "a.html";
            string strExt = System.IO.Path.GetExtension(strname).ToLower();
            try
            {
                // save as HTML format
                string strText = htmlRichTextBox1.GetHTML(true, true);

                if (File.Exists(strname))
                    File.Delete(strname);

                StreamWriter sr = File.CreateText(strname);
                sr.Write(strText);
                sr.Close();
            }
            catch
            {
                MessageBox.Show("There was an error saving the file: " + strname);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Read the HTML format
            string strname = "a.html";
            StreamReader sr = File.OpenText(strname);
            string strHTML = sr.ReadToEnd();
            sr.Close();
            htmlRichTextBox2.Clear();
            htmlRichTextBox2.AddHTML(strHTML);
        }
        Boolean is_show_history = true;
        private void button10_Click(object sender, EventArgs e)
        {
            if (is_show_history)
            {
                splitContainer3.Panel1Collapsed = true;
                this.splitContainer3.IsSplitterFixed = true;                
                this.splitContainer3.Panel1.Hide();              
                is_show_history = false;
            }
            else {
                is_show_history = true;
                this.splitContainer3.Panel1.Show();
                splitContainer3.Panel1Collapsed = false;
                this.splitContainer3.IsSplitterFixed = false; 
            }
        }
    }
}
