using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace length_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            //create datagirl view nodata.
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name="text";
            dataGridView1.Columns[1].Name = "length";
            dataGridView1.Font = new Font("Tomato", 12);
            //dataGridView1.Size=new Size(400,500);
            richTextBox1.Text = "Chuong Trinh Dem So Chu Trong Text Nhap vao Va Export Da Nhap Ra File Text";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string[] row = new string [] {textBox1.Text.ToString(),textBox1.Text.Length.ToString() };
            dataGridView1.Rows.Add(row);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        //private void textBox1_Enter(object sender, EventArgs e)
        //{
        //    //this.button1_Click();
        //    //button2_Click(object sender,EventArgs e);
        //    this.button1_Click(sender,e);
        //}

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                this.button1_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //http://vspro1.wordpress.com/2011/02/28/export-to-a-text-file-from-a-datagridview-control/
            System.IO.StreamWriter file = new System.IO.StreamWriter(@"TextFile.txt");
            try
            {
                string sLine = "";
                //This for loop loops through each row in the table
                for (int r = 0; r <= dataGridView1.Rows.Count - 1; r++)
                {
                    //This for loop loops through each column, and the row number
                    //is passed from the for loop above.
                    for (int c = 0; c <= dataGridView1.Columns.Count - 1; c++)
                    {
                        sLine = sLine + dataGridView1.Rows[r].Cells[c].Value;
                        if (c != dataGridView1.Columns.Count - 1)
                        {
                            //A comma is added as a text delimiter in order
                            //to separate each field in the text file.
                            //You can choose another character as a delimiter.
                            sLine = sLine + ",";
                        }
                    }
                    //The exported text is written to the text file, one line at a time.
                    file.WriteLine(sLine);
                    sLine = "";
                }
                file.Close();
               // System.Windows.Forms.MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                file.Close();
            }
            DialogResult show1 = MessageBox.Show("Muon Mo Folder Khong","Important",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            switch (show1)
            {
                case DialogResult.Abort:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Yes:
                    System.Diagnostics.Process.Start(System.Environment.CurrentDirectory);
                    break;
                default:
                    break;
            }
        }
    }
}
