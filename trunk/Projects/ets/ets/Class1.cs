/*
Professional Windows GUI Programming Using C#
by Jay Glynn, Csaba Torok, Richard Conway, Wahid Choudhury, 
   Zach Greenvoss, Shripad Kulkarni, Neil Whitlow

Publisher: Peer Information
ISBN: 1861007663
*/
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Text;
using System.IO;
using System.Xml;

//
// Read an XML Document and display the file as a Tree.
//
// Shripad Kulkarni 
// Date : May 15, 2002
// 

namespace XMLTree
{
    /// <summary>
    /// Summary description for XMLTreeForm.
    /// </summary>
    public class XMLTreeForm : System.Windows.Forms.Form
    {
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.MenuItem menuItem3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        enum VIEW { TREE_VIEW = 0 } ;
        string XMLInputFile = null;
        string FileSize = "";
        string WorkingDir = Directory.GetCurrentDirectory();
        string OrigFormTitle = "";
        bool bFileLoaded = false;
        int CurrentView = (int)VIEW.TREE_VIEW;
        Object NodeTag = null;
        Thread t = null;
        TreeNode RootNode = null;
        Point ClickedPoint = new Point(0, 0);
        ArrayList TreeNodeArray = new ArrayList();
        ImageList tr_il = new ImageList();
        ImageList tb_il = new ImageList();

        Bitmap img_fileopen, img_exit, img_collapse, img_expand, img_about;

        private System.Windows.Forms.MenuItem menuItem4;
        private System.Windows.Forms.MenuItem menuItem5;
        private System.Windows.Forms.ToolBar toolBar1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolBarButton Open;
        private System.Windows.Forms.ToolBarButton Exit;
        private System.Windows.Forms.ToolBarButton About;
        private System.Windows.Forms.ToolBarButton SEPARATOR1;
        private System.Windows.Forms.ToolBarButton ExpandAll;
        private System.Windows.Forms.ToolBarButton CollapseAll;
        private System.Windows.Forms.ToolBarButton Stop;

        private System.Windows.Forms.ToolBarButton SEPARATOR2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ToolBarButton SEPARATOR3;
        delegate void MyDelegate();

        public XMLTreeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolBar1 = new System.Windows.Forms.ToolBar();
            this.Open = new System.Windows.Forms.ToolBarButton();
            this.SEPARATOR1 = new System.Windows.Forms.ToolBarButton();
            this.ExpandAll = new System.Windows.Forms.ToolBarButton();
            this.CollapseAll = new System.Windows.Forms.ToolBarButton();
            this.Stop = new System.Windows.Forms.ToolBarButton();
            this.SEPARATOR3 = new System.Windows.Forms.ToolBarButton();
            this.Exit = new System.Windows.Forms.ToolBarButton();
            this.About = new System.Windows.Forms.ToolBarButton();
            this.SEPARATOR2 = new System.Windows.Forms.ToolBarButton();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                            this.menuItem1,
                                            this.menuItem4});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                            this.menuItem3,
                                            this.menuItem2});
            this.menuItem1.OwnerDraw = true;
            this.menuItem1.Text = "File";
            this.menuItem1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.menuItem1_DrawItem);
            this.menuItem1.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.menuItem1_MeasureItem);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.OwnerDraw = true;
            this.menuItem3.Text = "Open";
            this.menuItem3.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.menuItem3_DrawItem);
            this.menuItem3.Click += new System.EventHandler(this.menuItem3_Click);
            this.menuItem3.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.menuItem3_MeasureItem);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.OwnerDraw = true;
            this.menuItem2.Text = "Exit";
            this.menuItem2.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.menuItem3_DrawItem);
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            this.menuItem2.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.menuItem3_MeasureItem);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
                                            this.menuItem5});
            this.menuItem4.OwnerDraw = true;
            this.menuItem4.Text = "Help";
            this.menuItem4.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.menuItem1_DrawItem);
            this.menuItem4.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.menuItem1_MeasureItem);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.OwnerDraw = true;
            this.menuItem5.Text = "About";
            this.menuItem5.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.menuItem3_DrawItem);
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            this.menuItem5.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.menuItem3_MeasureItem);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "XML FILES| *.xml";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // toolBar1
            // 
            this.toolBar1.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this.toolBar1.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
                                            this.Open,
                                            this.SEPARATOR1,
                                            this.ExpandAll,
                                            this.CollapseAll,
                                            this.Stop,
                                            this.SEPARATOR3,
                                            this.Exit,
                                            this.About,
                                            this.SEPARATOR2});
            this.toolBar1.ButtonSize = new System.Drawing.Size(16, 16);
            this.toolBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toolBar1.DropDownArrows = true;
            this.toolBar1.Name = "toolBar1";
            this.toolBar1.ShowToolTips = true;
            this.toolBar1.Size = new System.Drawing.Size(840, 25);
            this.toolBar1.TabIndex = 0;
            this.toolBar1.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this.toolBar1_ButtonClick);
            // 
            // Open
            // 
            this.Open.ImageIndex = 0;
            this.Open.ToolTipText = "Open XML File";
            // 
            // SEPARATOR1
            // 
            this.SEPARATOR1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // ExpandAll
            // 
            this.ExpandAll.Enabled = false;
            this.ExpandAll.ImageIndex = 3;
            this.ExpandAll.ToolTipText = "Expand All Nodes";
            // 
            // CollapseAll
            // 
            this.CollapseAll.Enabled = false;
            this.CollapseAll.ImageIndex = 4;
            this.CollapseAll.ToolTipText = "Collapse All Nodes";
            // 
            // Stop
            // 
            this.Stop.Enabled = false;
            this.Stop.ImageIndex = 5;
            this.Stop.ToolTipText = "Stop";
            // 
            // SEPARATOR3
            // 
            this.SEPARATOR3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // Exit
            // 
            this.Exit.ImageIndex = 1;
            this.Exit.ToolTipText = "Exit Application";
            // 
            // About
            // 
            this.About.ImageIndex = 2;
            this.About.ToolTipText = "Help About";
            // 
            // SEPARATOR2
            // 
            this.SEPARATOR2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.treeView1.FullRowSelect = true;
            this.treeView1.HotTracking = true;
            this.treeView1.ImageIndex = -1;
            this.treeView1.ItemHeight = 16;
            this.treeView1.Location = new System.Drawing.Point(0, 25);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = -1;
            this.treeView1.Size = new System.Drawing.Size(360, 472);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Maroon;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(368, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(472, 468);
            this.listBox1.TabIndex = 12;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(360, 25);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 472);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // XMLTreeForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(840, 497);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                                      this.listBox1,
                                      this.splitter1,
                                      this.treeView1,
                                      this.toolBar1});
            this.Menu = this.mainMenu1;
            this.Name = "XMLTreeForm";
            this.Text = "XML Viewer";
            this.Resize += new System.EventHandler(this.XMLTreeForm_Resize);
            this.Load += new System.EventHandler(this.XMLTreeForm_Load);
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new XMLTreeForm());
        }

        private void XMLTreeForm_Load(object sender, System.EventArgs e)
        {
            // Add images to the imageList for treeView
            tr_il.Images.Add(new Icon(WorkingDir + "\\ROOT.ICO"));    //ROOT    0
            tr_il.Images.Add(new Icon(WorkingDir + "\\ELEMENT.ICO"));  //ELEMENT  1
            tr_il.Images.Add(new Icon(WorkingDir + "\\EQUAL.ICO"));    //ATTRIBUTE  2
            treeView1.ImageList = tr_il;

            // Add images to the imageList for Toolbar
            tb_il.Images.Add(new Bitmap(WorkingDir + "\\FileOpen.bmp"));    //ROOT    0
            tb_il.Images.Add(new Bitmap(WorkingDir + "\\exit.bmp"));      //ELEMENT  1
            tb_il.Images.Add(new Bitmap(WorkingDir + "\\about.bmp"));    //ATTRIBUTE  2
            tb_il.Images.Add(new Bitmap(WorkingDir + "\\ExpandTree.bmp"));  //ATTRIBUTE  3
            tb_il.Images.Add(new Bitmap(WorkingDir + "\\CollapseTree.bmp"));  //ATTRIBUTE  4
            tb_il.Images.Add(new Bitmap(WorkingDir + "\\Stop.bmp"));      //ATTRIBUTE  5
            toolBar1.ImageList = tb_il;

            // Add images to the imageList for the MenuBar
            img_fileopen = new Bitmap("FileOpen.bmp");
            img_exit = new Bitmap("exit.bmp");
            img_expand = new Bitmap("ExpandTree.bmp");
            img_collapse = new Bitmap("CollapseTree.bmp");
            img_about = new Bitmap("about.bmp");

            OrigFormTitle = this.Text;

        }

        private void menuItem3_Click(object sender, System.EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Initialize Buttons
            EnableDisableControls();

            // Initialize All the Arrays
            treeView1.Nodes.Clear();
            listBox1.Items.Clear();
            TreeNodeArray.Clear();

            bFileLoaded = false;

            XMLInputFile = openFileDialog1.FileName;
            this.Text = OrigFormTitle + " ..." + XMLInputFile;
            openFileDialog1.Dispose();

            // Get the filename and filesize
            FileInfo f = new FileInfo(XMLInputFile);
            FileSize = f.Length.ToString();

            // Begin thread to read input file and load into the ListBox
            Thread t = new Thread(new ThreadStart(PopulateList));
            t.Start();

            // Begin thread to read input file and populate the Tree
            Thread tt = new Thread(new ThreadStart(PopulateTree));
            tt.Start();
        }

        private void PopulateList()
        {
            // Load the File
            LoadFileIntoListBox();
        }

        private void PopulateTree()
        {
            // TreeView Nodes cannot be added in a thread , until the thread is marshalled
            // using an Invoke or beginInvoke call.
            // We create a delegate ( Funtion Pointer ) and invoke the thread using he delegate
            MyDelegate dlg_obj;
            dlg_obj = new MyDelegate(ParseFile);
            treeView1.Invoke(dlg_obj);
        }

        private void ParseFile()
        {
            // Use the XMLReader class to read the XML File and populate the
            // treeview
            try
            {
                XmlTextReader reader = null;
                reader = new XmlTextReader(XMLInputFile);
                reader.WhitespaceHandling = WhitespaceHandling.None;
                string readerName = "";
                bool start_node = false;
                int depth = 0;
                TreeNode WORKINGNODE = null;
                RootNode = null;
                TreeNode AttrNode = null;
                TreeNode newNode = null;
                bool bIsEmpty = false;
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            readerName = reader.Name;
                            bIsEmpty = reader.IsEmptyElement;

                            if (!start_node)
                            {
                                start_node = true;
                                RootNode = this.treeView1.Nodes.Add(readerName);
                                AssociateTag(RootNode, reader.LineNumber);
                                RootNode.SelectedImageIndex = 0;
                                RootNode.ImageIndex = 0;
                                continue;
                            }
                            depth = reader.Depth;

                            if (reader.IsStartElement() && depth == 1)
                            {
                                WORKINGNODE = RootNode.Nodes.Add(reader.Name);
                                AssociateTag(WORKINGNODE, reader.LineNumber);
                            }
                            else
                            {
                                TreeNode parent = WORKINGNODE;
                                WORKINGNODE = parent.Nodes.Add(reader.Name);
                                AssociateTag(WORKINGNODE, reader.LineNumber);
                            }

                            WORKINGNODE.SelectedImageIndex = 1;
                            WORKINGNODE.ImageIndex = 1;

                            for (int i = 0; i < reader.AttributeCount; i++)
                            {
                                reader.MoveToAttribute(i);
                                string rValue = reader.Value.Replace("\r\n", " ");
                                AttrNode = WORKINGNODE.Nodes.Add(reader.Name);
                                //                AttrNode = WORKINGNODE.Nodes.Add(reader.Name +"="+rValue);
                                AssociateTag(AttrNode, reader.LineNumber);

                                AttrNode.SelectedImageIndex = 1;
                                AttrNode.ImageIndex = 1;
                                TreeNode tmp = AttrNode.Nodes.Add(rValue);
                                tmp.SelectedImageIndex = 2;
                                tmp.ImageIndex = 2;
                                AssociateTag(tmp, reader.LineNumber);

                                AttrNode.SelectedImageIndex = 2;
                                AttrNode.ImageIndex = 2;

                            }

                            if (bIsEmpty)
                                WORKINGNODE = WORKINGNODE.Parent;

                            break;
                        case XmlNodeType.Text:
                            {
                                string rValue = reader.Value.Replace("\r\n", " ");
                                newNode = WORKINGNODE.Nodes.Add(rValue);
                                AssociateTag(newNode, reader.LineNumber);
                                newNode.SelectedImageIndex = 2;
                                newNode.ImageIndex = 2;
                            }
                            break;
                        case XmlNodeType.EndElement:
                            WORKINGNODE = WORKINGNODE.Parent;
                            break;
                    }
                }
                reader.Close();
                RootNode.Expand();

            }
            catch (Exception eee)
            {
                Console.WriteLine(eee.Message);
            }
        }

        private void treeView1_Click(object sender, System.EventArgs e)
        {
        }

        private void treeView1_AfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e)
        {
            if (!bFileLoaded) return;

            // The treenode is selected. Every node is tagged with LineNumber ( from input file ).
            // This allows us to jump to the line in the file.

            TreeNode tn;
            tn = (TreeNode)e.Node;
            Object ln = tn.Tag;
            int line = Convert.ToInt32(ln.ToString());
            MoveToLine(line);
        }

        private void menuItem2_Click(object sender, System.EventArgs e)
        {
            AppExit();
        }

        private void AppExit()
        {
            Application.Exit();
        }

        private void LoadFileIntoListBox()
        {
            // Load the xml file into a listbox.
            try
            {
                StreamReader sr = new StreamReader(XMLInputFile, Encoding.ASCII);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while (sr.Peek() > -1)
                {
                    Thread.Sleep(5);
                    string str = sr.ReadLine();
                    listBox1.Items.Add(str);
                }
                sr.Close();
                bFileLoaded = true;
                listBox1.SetSelected(1, true);
            }
            catch (Exception ee)
            {
                Console.WriteLine("Error Reading File into ListBox " + ee.Message);
            }
        }

        private void MoveToLine(int ln)
        {
            // Select the input line from the file in the listbox
            listBox1.SetSelected(ln - 1, true);
        }

        private void AssociateTag(TreeNode t, int l)
        {
            // Associate a line number Tag with every node in the tree
            NodeTag = new Object();
            NodeTag = l;
            t.Tag = NodeTag;
        }

        private void menuItem5_Click(object sender, System.EventArgs e)
        {
            // About Box is clicked
            ShowAboutBox();
        }

        private void ShowAboutBox()
        {
            //About abt = new About();
            //Mess.ShowDialog();
            MessageBox.Show("Hello");
        }

        private void EnableDisableControls()
        {
            // Enable Disable Buttons

            switch (CurrentView)
            {
                case 0:  // TREE VIEW
                    {
                        ExpandAll.Enabled = true;
                        CollapseAll.Enabled = true;
                        Stop.Enabled = true;
                        treeView1.Visible = true;
                    }
                    break;
                case 1:  // REPORT VIEW
                    {
                        ExpandAll.Enabled = false;
                        CollapseAll.Enabled = false;
                        Stop.Enabled = false;
                    }
                    break;
            }
        }

        private void toolBar1_ButtonClick(object sender, System.Windows.Forms.ToolBarButtonClickEventArgs e)
        {
            // Invoke the function upon clicking the toolbar button
            int x = int.Parse(toolBar1.Buttons.IndexOf(e.Button).ToString());

            switch (toolBar1.Buttons.IndexOf(e.Button))
            {
                case 0:
                    openFileDialog1.ShowDialog(this);
                    break;
                case 1:
                    //separator
                    break;
                case 2:
                    TExpandAll();
                    break;
                case 3:
                    TCollapseAll();
                    break;
                case 4:
                    if (t != null && t.IsAlive)
                    {
                        t.Abort();
                        t = null;
                        EnableDisableControls();
                    }
                    break;
                case 5:
                    break;
                case 6:
                    AppExit();
                    break;
                case 7:
                    ShowAboutBox();
                    break;
                case 8:  // separator
                    //separator
                    break;
                case 9:  // Go Back 
                    break;
                case 10:// separator
                    break;
                case 11:// Go Back 
                    CurrentView = (int)VIEW.TREE_VIEW;
                    EnableDisableControls();
                    break;
            }
        }

        private void TExpandAll()
        {
            t = new Thread(new ThreadStart(TE));
            t.Start();
        }

        private void TE()
        {
            // Expand all nodes in the tree
            treeView1.ExpandAll();
        }

        private void TCollapseAll()
        {
            // Collapse all nodes in the tree
            treeView1.CollapseAll();
        }

        void Clear()
        {
            TreeNodeArray.Clear();
        }

        private void menuItem1_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            //Owner Draw Menu Items

            //Get the bounding rectangle
            Rectangle rc = new Rectangle(e.Bounds.X + 1, e.Bounds.Y + 1, e.Bounds.Width - 5, e.Bounds.Height - 1);
            //Fill the rectangle
            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), rc);
            //Unbox the menu item
            MenuItem s = (MenuItem)sender;
            string s1 = s.Text;
            //Set the stringformat object
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(s1, new Font("Ariel", 10), new SolidBrush(Color.Black), rc, sf);
            Console.WriteLine(e.State.ToString());

            //Check if the object is selected. 
            if (e.State == (DrawItemState.NoAccelerator | DrawItemState.Selected) ||
              e.State == (DrawItemState.NoAccelerator | DrawItemState.HotLight))
            {
                // Draw selected menu item
                e.Graphics.FillRectangle(new SolidBrush(Color.LightYellow), rc);
                e.Graphics.DrawString(s1, new Font("Veranda", 10, FontStyle.Bold), new SolidBrush(Color.Red), rc, sf);
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), rc);
            }
            e.DrawFocusRectangle();
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black), 1), rc);
        }

        private void menuItem1_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
        {
            // Set the menu item height
            e.ItemWidth = 75;
        }

        private void menuItem3_MeasureItem(object sender, System.Windows.Forms.MeasureItemEventArgs e)
        {
            // Set the sub menu item height and width
            e.ItemWidth = 95;
            e.ItemHeight = 25;
        }

        private void menuItem3_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            //Owner Draw Sub Menu Items

            Rectangle rc = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);
            e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), rc);
            MenuItem s = (MenuItem)sender;
            string s1 = s.Text;
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Far;
            sf.LineAlignment = StringAlignment.Center;


            Image useImage = null;

            if (s1 == "Open")
            {
                useImage = img_fileopen;
            }
            if (s1 == "ExpandAll")
            {
                if (CurrentView == (int)VIEW.TREE_VIEW)
                    s.Enabled = true;
                else
                    s.Enabled = false;
                useImage = img_expand;
            }
            if (s1 == "Exit")
            {
                useImage = img_exit;
            }
            if (s1 == "CollapseAll")
            {
                if (CurrentView == (int)VIEW.TREE_VIEW)
                    s.Enabled = true;
                else
                    s.Enabled = false;
                useImage = img_collapse;
            }
            if (s1 == "About")
            {
                useImage = img_about;
            }

            Rectangle rcText = rc;
            rcText.Width -= 5;
            e.Graphics.DrawString(s1, new Font("Veranda", 10), new SolidBrush(Color.Blue), rcText, sf);
            e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.LightGray)), rc);

            if (e.State == (DrawItemState.NoAccelerator | DrawItemState.Selected))
            {
                Rectangle rc1 = rc;
                rc1.X = rc1.X + useImage.Width + 5;
                rc1.Width = rc.Width - 25;
                rc1.Height = rc.Height - 2;
                e.Graphics.FillRectangle(new SolidBrush(Color.LightYellow), rc);
                e.Graphics.DrawString(s1, new Font("Veranda", 10, FontStyle.Bold | FontStyle.Underline), new SolidBrush(Color.Red), rcText, sf);
                e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black), 3), rc);
                e.DrawFocusRectangle();
            }

            if (useImage != null)
            {
                SizeF sz = useImage.PhysicalDimension;
                e.Graphics.DrawImage(useImage, e.Bounds.X + 5, (e.Bounds.Bottom + e.Bounds.Top) / 2 - sz.Height / 2);
            }
        }

        private void XMLTreeForm_Resize(object sender, System.EventArgs e)
        {
        }
    }
}
