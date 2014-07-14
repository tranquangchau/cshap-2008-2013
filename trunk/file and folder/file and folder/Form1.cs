using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Drawing.Imaging;

namespace file_and_folder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            taofolder(textBox1.Text);
            //taofile(textBox1.Text, textBox1.Text+".txt");
            luufile(richTextBox1, textBox1.Text+"/"+textBox1.Text+".txt");
            richTextBox1.Text = "";
            textBox1.Text = "";
        }

        private void luufile(RichTextBox richTextBox1, string p)
        {
            richTextBox1.SaveFile(p, RichTextBoxStreamType.PlainText);
        }
        //tao file
        //private void taofile(string folder,string file)
        //{
        //    try
        //    {
        //        if (File.Exists(folder+"/"+file) == false)
        //        {
        //            File.Create(folder + "/" + file).Close();
        //            MessageBox.Show("Tao thanh cong");
        //            //file.Clone();
        //        }
        //        else
        //            MessageBox.Show("File Ko tao duoc Vi da co roi!");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}


        //tao folder        
        private void taofolder(string f)
        {
            if (Directory.Exists(f) == false)
            {
                if (f == "")
                {
                    //  MessageBox.Show("Folor chua co");
                }
                else
                {
                    Directory.CreateDirectory(f);
                    // MessageBox.Show("Tao OK");
                }
            }
            else
            { }
                //MessageBox.Show("Loi tao folder");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //GetImageFromUrl(textBox2.Text).Save(textBox1.Text+"/"+textBox1.Text+"_1"+".jpeg");
            //LoadImage(textBox2.Text).Save(textBox1.Text + "/" + textBox1.Text + "_1" + ".jpeg");
            //SaveJpeg("j.jpg", textBox2.Text, 100);
            saveBucanh(textBox2.Text,textBox1.Text+".jpeg");
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void saveBucanh(string p, string p_2)
        {

            var bytes = Convert.FromBase64String(p);
            using (var imageFile = new FileStream(p_2, FileMode.Create))
            {
                imageFile.Write(bytes, 0, bytes.Length);
                imageFile.Flush();
            }
        }
        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        public static void SaveJpeg(string path, Image img, int quality)
        {
            EncoderParameter qualityParam  = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);

            ImageCodecInfo jpegCodec = GetEncoderInfo(@"image/jpeg");

            EncoderParameters encoderParams  = new EncoderParameters(1);

            encoderParams.Param[0] = qualityParam;

            System.IO.MemoryStream mss = new System.IO.MemoryStream();

            System.IO.FileStream fs= new System.IO.FileStream(path, System.IO.FileMode.Create
            , System.IO.FileAccess.ReadWrite);

            img.Save(mss, jpegCodec, encoderParams);
            byte[] matriz = mss.ToArray();
            fs.Write(matriz, 0, matriz.Length);

            mss.Close();
            fs.Close();
        }
        private static ImageCodecInfo GetEncoderInfo(String mimeType)
        {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }

        public Image LoadImage(string s1)
        {
            //get a temp image from bytes, instead of loading from disk
            //data:image/gif;base64,
            //this image is a single pixel (black)
            byte[] bytes = Convert.FromBase64String(s1);

            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }

            return image;
        }

        public static Image GetImageFromUrl(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);

            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    return Image.FromStream(stream);
                }
            }
        }

    }
}
