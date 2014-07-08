using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace get_metapic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            label1.Text= GetImageTitle("test.jpeg");
            test();
        }

        private void test()
        {
           
        }

        private string GetImageTitle(string im)
        {
            //string sw="";
            if (System.IO.File.Exists(im))
            {
                Image im1 = Image.FromFile(im);
                ImageFormat imgf = im1.RawFormat;

                //System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
                //var allPoprItem = im1.PropertyItems;
                //const int metTitle = 0x0110;
                //MessageBox.Show(metTitle.ToString());
                //var Title = allPoprItem.FirstOrDefault(x => x.Id == metTitle);
                //return encoding.GetString(Title.Value);
                
                //im1.Tag = "chau";
                //sw = im1.Tag.ToString();
                //return sw;
                
                //return im1.GetPropertyItem()..ToString();
                return im1.GetPropertyItem(0x0320).ToString();
            }
            else return "0";
           
           
        }        
    }
}
