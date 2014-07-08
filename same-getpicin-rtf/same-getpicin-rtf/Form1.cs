using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;

namespace same_getpicin_rtf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // rtfImage_Paint(sender, e);
        }
        private void rtfImage_Paint(object sender, PaintEventArgs e)
        {
            string rtfStr = System.IO.File.ReadAllText("MySampleFile.rtf");
            string imageDataHex = ExtractImgHex(rtfStr);
            byte[] imageBuffer = ToBinary(imageDataHex);
            Image image;
            using (MemoryStream stream = new MemoryStream(imageBuffer))
            {
                image = Image.FromStream(stream);
            }
            Rectangle rect = new Rectangle(0, 0, 100, 100);
            e.Graphics.DrawImage(image, rect);
        }

    }
}
