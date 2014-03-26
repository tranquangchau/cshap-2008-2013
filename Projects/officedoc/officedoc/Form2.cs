//using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
//using System.Drawing;
using System;
//System.Diagnostics.Process.Start(Application.StartupPath); open folder debug

namespace officedoc
{    
    public partial class Form2 : Form
    {
        string file1 ;
        string st = "";        
        DirectoryInfo directoryInfo = new DirectoryInfo(@"D:\test");
        public Form2()
        {
            
            InitializeComponent();
            
            
            if (directoryInfo.Exists)
            {
                treeView1.AfterSelect += treeView1_AfterSelect;
                BuildTree(directoryInfo, treeView1.Nodes);
            }
        }       
        
        protected void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {
            textBox1.Visible = false;

            TreeNode curNode = addInMe.Add(directoryInfo.Name);

            foreach (FileInfo file in directoryInfo.GetFiles()) //add file (.rtf,.txt) for tree
            {
                if (file.Extension.ToLower() == ".rtf" || file.Extension.ToLower() == ".txt")
                curNode.Nodes.Add(file.FullName, file.Name);
            }
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories()) //add subdir
            {
                BuildTree(subdir, curNode.Nodes);                
            }            
            
        }
        
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) //open file txt goout richtextbox after select treeview
        {
            richTextBox1.ZoomFactor = 1.0f;
            try
            {
                if (e.Node.Name.EndsWith("txt"))
                {
                    this.richTextBox1.Clear();
                    StreamReader reader = new StreamReader(e.Node.Name);
                    this.richTextBox1.Text = reader.ReadToEnd();
                    reader.Close();
                    st = e.Node.Name;                                        
                }
                if (e.Node.Name.EndsWith("rtf"))
                {
                    this.richTextBox1.Clear();
                    //StreamReader reader = new StreamReader(e.Node.Name);
                    //this.richTextBox1.Text = reader.ReadToEnd();
                    //reader.Close();
                    richTextBox1.LoadFile(e.Node.Name,RichTextBoxStreamType.RichText);
                    st = e.Node.Name;                    
                }                
                
                //saveToolStripMenuItem_Click(sender, e,st);                
                
            }
            catch (Exception ex)
            {
                if (e.Node.Name.EndsWith("rtf"))
                {
                    this.richTextBox1.Clear();
                    richTextBox1.LoadFile(e.Node.Name, RichTextBoxStreamType.PlainText);
                }
                else
                MessageBox.Show(ex.ToString());
            }
        }

        private void clodeToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void hideToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            treeView1.Hide();           
            //richTextBox1.Location=new Point(this.ClientSize.Width,this.ClientSize.Height);
        }

        private void showToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            treeView1.Show();
        }

        private void toolStripMenuItem1_Click(object sender, System.EventArgs e)
        {

            //richTextBox1.Select(0,richTextBox1.Text.Length);            
            richTextBox1.ZoomFactor = 2.0f;
        }

        private void toolStripMenuItem2_Click(object sender, System.EventArgs e)
        {
            richTextBox1.ZoomFactor = 0.5f;
        }

        private void toolStripMenuItem3_Click(object sender, System.EventArgs e)
        {
            richTextBox1.ZoomFactor = 1.0f;
        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            BuildTree(directoryInfo, treeView1.Nodes);
            treeView1.ExpandAll(); //mo tree ra
        }
        


        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //int found=0;
            //found=st.IndexOf("txt");            
            
            if(st.Contains(".txt"))
            {
                //richTextBox1.SaveFile(st,Encoding.Unicode);
                //richTextBox1.read
                StreamWriter sr = new StreamWriter(st.ToString());
                //richTextBox1.Text=sr.Write;
                //UTF8Encoding utf=new UTF8Encoding();
                //richTextBox1.SaveFile(st, RichTextBoxStreamType.PlainText);
                for (int i=0;i<richTextBox1.Lines.Length;i ++)
                {
                   sr.WriteLine(richTextBox1.Lines[i],Encoding.UTF8);
                }
                sr.Flush();sr.Close();
                MessageBox.Show("Save ok "+st.ToString());
            }
            else
            if (st.Contains(".rtf"))
            {
                richTextBox1.SaveFile(st, RichTextBoxStreamType.RichText);
                MessageBox.Show("Save ok " + st.ToString());
            }
            else
            {
                MessageBox.Show("Error " + st.ToString());
            }
          
            
        }
        
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {                      
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog(); //what?
            if (result == DialogResult.OK)
            {
                 file1 = fbd.SelectedPath;                
                MessageBox.Show(file1.ToString());
            }            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }

        //private void save1ToolStripMenuItem_Click(object sender, EventArgs e)
        //{                                 

        //    //string s1 = st.Substring(0, st.LastIndexOf(("\\"))); //get a substring from a file path  
        //    //string s2 = s1.ToString() + textBox1.Text + ".txt";
        //    //StreamWriter sr = new StreamWriter(s2);
        //    //sr.Close();
        //    //MessageBox.Show(s1.ToString());
        //    //MessageBox.Show(sr.ToString());
        //    //loadToolStripMenuItem1_Click(sender, e);

        //    //saveFileDialog1.ShowDialog(); OK
        //    FileStream fs = new FileStream("D:\\test\\save1.txt",FileMode.Create);
           
        //}

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {            
            saveFileDialog1.Filter = "Text File|.txt";
            //Empty the FileName text box of the dialog
            //saveFileDialog1.FileName = S;
            //Set default extension as .txt
            saveFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            //saveFileDialog1.FilterIndex = 1;

            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.FileName = textBox1.Text;
            //Open the dialog and determine which button was pressed
            DialogResult result = saveFileDialog1.ShowDialog();
            //If the user presses the Save button
            if (result == DialogResult.OK)
            {
                //Create a file stream using the file name
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);        
                //Create a writer that will write to the stream
                StreamWriter writer = new StreamWriter(fs);
                //Write the contents of the text box to the stream
                writer.Write(textBox1.Text);
                //Close the writer and the stream
                writer.Close();
            }
            textBox1.Visible = false;
            textBox1.Text = "";
        }

    }
}
