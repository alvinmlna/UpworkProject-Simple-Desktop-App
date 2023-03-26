using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpworkProject
{
    public partial class FileUploadWithResize : Form
    {
        public FileUploadWithResize()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                //check image validation
                if (!CheckIfImage(openFileDialog1.FileName))
                {
                    MessageBox.Show("File is not image!");
                    return;
                }

                var fileNameTxt = openFileDialog1.FileName;
                var size = new FileInfo(openFileDialog1.FileName).Length;
                var extension = Path.GetExtension(openFileDialog1.FileName);

                //UI
                filename.Text = "Filename: " + openFileDialog1.SafeFileName;
                Size.Text = "Size: " + SizeSuffix(size, 2);
                Extension.Text = "Extension: " + extension;
                OrgPath.Text = "Original Path: " + openFileDialog1.FileName;

                //Picturebox handling
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                //if size > 1mb
                if (size > 1048576)
                {
                    var image = new Bitmap(fileNameTxt);
                    Image i = resizeImage(image, new Size(985, 445));
                    pictureBox1.Image = i;
                    compressed.Text = "Compressed! - New size: " + SizeSuffix(CheckSize(i),2);
                    compressed.Visible = true;
                } else
                {
                    var image = new Bitmap(fileNameTxt);
                    pictureBox1.Image = image;
                    compressed.Text = "";
                    compressed.Visible = false;
                }

                //Save image to server
                //Save image to db
            }
        }

         readonly string[] SizeSuffixes =
                   { "bytes", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };

         string SizeSuffix(Int64 value, int decimalPlaces = 1)
        {
            if (decimalPlaces < 0) { throw new ArgumentOutOfRangeException("decimalPlaces"); }
            if (value < 0) { return "-" + SizeSuffix(-value, decimalPlaces); }
            if (value == 0) { return string.Format("{0:n" + decimalPlaces + "} bytes", 0); }

            // mag is 0 for bytes, 1 for KB, 2, for MB, etc.
            int mag = (int)Math.Log(value, 1024);

            // 1L << (mag * 10) == 2 ^ (10 * mag) 
            // [i.e. the number of bytes in the unit corresponding to mag]
            decimal adjustedSize = (decimal)value / (1L << (mag * 10));

            // make adjustment when the value is large enough that
            // it would round up to 1000 or more
            if (Math.Round(adjustedSize, decimalPlaces) >= 1000)
            {
                mag += 1;
                adjustedSize /= 1024;
            }

            return string.Format("{0:n" + decimalPlaces + "} {1}",
                adjustedSize,
                SizeSuffixes[mag]);
        }

        private static Image resizeImage(Image imgToResize, Size size)
        {
            //Get the image current width  
            int sourceWidth = imgToResize.Width;
            //Get the image current height  
            int sourceHeight = imgToResize.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }

        private long CheckSize(Image image)
        {
            long jpegByteSize;
            using (var ms = new MemoryStream()) // estimatedLength can be original fileLength
            {
                image.Save(ms, ImageFormat.Jpeg); // save image to stream in Jpeg format
                jpegByteSize = ms.Length;
            }

            return jpegByteSize;
        }

        private bool CheckIfImage(string filePath)
        {
            bool result = false;

            List<string> ImageExtensions = new List<string> { ".JPG", ".JPEG", ".JPE", ".BMP", ".GIF", ".PNG" };

            if (ImageExtensions.Contains(Path.GetExtension(filePath).ToUpperInvariant()))
                result = true;

            return result;
        }
    }
}
