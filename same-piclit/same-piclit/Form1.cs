﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace same_piclit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Construct the ImageList.
            ImageList1 = new ImageList();

            // Set the ImageSize property to a larger size  
            // (the default is 16 x 16).
            ImageList1.ImageSize = new Size(112, 112);

            // Add two images to the list.
            
            ImageList1.Images.Add(
                Image.FromFile("d:\\smile\\1.jpg"));
            ImageList1.Images.Add(
                Image.FromFile("d:\\smile\\2.jpg"));

            ImageList1.Images.Add(
                Image.FromFile("d:\\smile\\3.jpg"));

            ImageList1.Images.Add(
                Image.FromFile("d:\\smile\\4.jpg"));

            // Get a Graphics object from the form's handle.
            Graphics theGraphics = Graphics.FromHwnd(this.Handle);

            // Loop through the images in the list, drawing each image. 
            for (int count = 0; count < ImageList1.Images.Count; count++)
            {
                ImageList1.Draw(theGraphics, new Point(count*55+85, 85), count);

                // Call Application.DoEvents to force a repaint of the form.
                Application.DoEvents();

                // Call the Sleep method to allow the user to see the image.
                System.Threading.Thread.Sleep(1000);
            }

        }
    }
}
