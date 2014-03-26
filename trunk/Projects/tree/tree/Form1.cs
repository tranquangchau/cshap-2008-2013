using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using System.Reflection;

namespace tree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //DirectoryInfo directoryInfo = new DirectoryInfo(@"D:Photo");
            DirectoryInfo directoryInfo = new DirectoryInfo(@"\New Folder");
            
            if (directoryInfo.Exists)
            {
                treeView1.AfterSelect += treeView1_AfterSelect;
                BuildTree(directoryInfo, treeView1.Nodes);
            }
        }
        private void BuildTree(DirectoryInfo directoryInfo, TreeNodeCollection addInMe)
        {
            TreeNode curNode = addInMe.Add(directoryInfo.Name);

            foreach (FileInfo file in directoryInfo.GetFiles())
            {
                curNode.Nodes.Add(file.FullName, file.Name);
            }
            foreach (DirectoryInfo subdir in directoryInfo.GetDirectories())
            {
                BuildTree(subdir, curNode.Nodes);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name.EndsWith("txt"))
            {
                this.richTextBox1.Clear();
                StreamReader reader = new StreamReader(e.Node.Name);
                this.richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
            if (e.Node.Name.EndsWith("rtf"))
            {
                this.richTextBox1.Clear();
                richTextBox1.LoadFile(e.Node.Name,RichTextBoxStreamType.RichText);
            }
            if (e.Node.Name.EndsWith("jpg"))
            {
               // this.pictureBox1.Image = new Bitmap(typeof(Button), e.Node.Name);
                this.richTextBox1.Clear();
                Clipboard.SetImage(Image.FromFile(e.Node.Name));
                richTextBox1.Paste();  
            }
        }
    }
}
