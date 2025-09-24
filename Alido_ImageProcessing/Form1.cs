using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Alido_ImageProcessing
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog1 = new OpenFileDialog();
        OpenFileDialog openFileDialog2 = new OpenFileDialog();
        Bitmap imageB, imageA, imageC;
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;

        // filter flags for webcam
        bool greyscaleEnabled = false;
        bool invertEnabled = false;
        bool sepiaEnabled = false;
        bool histogramEnabled = false;
        bool greenscreenEnabled = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void imageAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog1.Title = "Select Image A";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageA = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = imageA;
            }
        }

        private void imageBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog2.Title = "Select Image B";

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                imageB = new Bitmap(openFileDialog2.FileName);
                pictureBox2.Image = imageB;
            }
        }


        private void subtractToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageB == null)
            {
                MessageBox.Show("Please load Image B (background) first.");
                return;
            }

            if (videoSource != null && videoSource.IsRunning)
            {
                greenscreenEnabled = true;
            }
            else
            {
                ApplyGreenScreen();
            }
        }

        private void imageAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (imageA == null)
            {
                MessageBox.Show("Please load Image A first or start webcam.");
                return;
            }

            imageC = new Bitmap(imageA);
            pictureBox3.Image = imageC;
        }
        private void imageBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (imageB == null)
            {
                MessageBox.Show("Please load Image A first or start webcam.");
                return;
            }

            imageC = new Bitmap(imageB);
            pictureBox3.Image = imageC;
        }
        private void imageAToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (imageA == null)
            {
                MessageBox.Show("Please load Image A or start webcam first.");
                return;
            }

            if (videoSource != null && videoSource.IsRunning)
                greyscaleEnabled = true;
            else
                ApplyGreyscale(imageA);
        }

        private void imageBToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (imageB == null)
            {
                MessageBox.Show("Please load Image A or start webcam first.");
                return;
            }
            ApplyGreyscale(imageB);
        }

        private void imageAToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (imageA == null)
            {
                MessageBox.Show("Please load Image A or start webcam first.");
                return;
            }

            if (videoSource != null && videoSource.IsRunning)
                invertEnabled = true;
            else
                ApplyInvert(imageA);
        }

        private void imageBToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (imageB == null)
            {
                MessageBox.Show("Please load Image A or start webcam first.");
                return;
            }
            ApplyInvert(imageB);
        }
       
        private void imageAToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (imageA == null)
            {
                MessageBox.Show("Please load Image A or start webcam first.");
                return;
            }

            if (videoSource != null && videoSource.IsRunning)
                sepiaEnabled = true;
            else
                ApplyHistogram(imageA);
        }

         private void imageBToolStripMenuItem4_Click(object sender, EventArgs e)
         {
            if (imageB == null)
            {
                MessageBox.Show("Please load Image A or start webcam first.");
                return;
            }
            ApplyHistogram(imageB);
        }

         private void imageAToolStripMenuItem5_Click(object sender, EventArgs e)
         {
            if (imageA == null)
            {
                MessageBox.Show("Please load Image A or start webcam first.");
                return;
            }

            if (videoSource != null && videoSource.IsRunning)
                sepiaEnabled = true;
            else
                ApplySepia(imageA);
        }

         private void imageBToolStripMenuItem5_Click(object sender, EventArgs e)
         {
            if (imageB == null)
            {
                MessageBox.Show("Please load Image A or start webcam first.");
                return;
            }
            ApplySepia(imageB);
        }
        private void ApplyInvert(Bitmap Image)
        {
            imageC = new Bitmap(Image.Width, Image.Height);

            for (int x = 0; x < Image.Width; x++)
            {
                for (int y = 0; y < Image.Height; y++)
                {
                    Color pixel = Image.GetPixel(x, y);
                    Color inverted = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    imageC.SetPixel(x, y, inverted);
                }
            }

            pictureBox3.Image = imageC;
        }
        private void ApplyGreyscale(Bitmap Image)
        {
            imageC = new Bitmap(Image.Width, Image.Height);

            for (int x = 0; x < Image.Width; x++)
            {
                for (int y = 0; y < Image.Height; y++)
                {
                    Color pixel = Image.GetPixel(x, y);
                    int grey = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
                    imageC.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }
            }

            pictureBox3.Image = imageC;
        }
        private void ApplySepia(Bitmap Image)
        {
            imageC = new Bitmap(Image.Width, Image.Height);

            for (int x = 0; x < Image.Width; x++)
            {
                for (int y = 0; y < Image.Height; y++)
                {
                    Color pixel = Image.GetPixel(x, y);

                    int tr = (int)(0.393 * pixel.R + 0.769 * pixel.G + 0.189 * pixel.B);
                    int tg = (int)(0.349 * pixel.R + 0.686 * pixel.G + 0.168 * pixel.B);
                    int tb = (int)(0.272 * pixel.R + 0.534 * pixel.G + 0.131 * pixel.B);

                    tr = Math.Min(255, tr);
                    tg = Math.Min(255, tg);
                    tb = Math.Min(255, tb);

                    imageC.SetPixel(x, y, Color.FromArgb(tr, tg, tb));
                }
            }

            pictureBox3.Image = imageC;
        }

        private void ApplyHistogram(Bitmap Image)
        {
            int[] histogram = new int[256];

            for (int x = 0; x < Image.Width; x++)
            {
                for (int y = 0; y < Image.Height; y++)
                {
                    Color pixel = Image.GetPixel(x, y);
                    int grey = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
                    histogram[grey]++;
                }
            }

            int max = histogram.Max();
            Bitmap histImage = new Bitmap(256, 100);

            using (Graphics g = Graphics.FromImage(histImage))
            {
                g.Clear(Color.White);
                for (int i = 0; i < 256; i++)
                {
                    int height = (int)(histogram[i] * 100.0 / max);
                    g.DrawLine(Pens.Black, new Point(i, 100), new Point(i, 100 - height));
                }
            }

            pictureBox3.Image = histImage;
        }
           
        private void ApplyGreenScreen()
        {
            int width = Math.Min(imageA.Width, imageB.Width);
            int height = Math.Min(imageA.Height, imageB.Height);
            imageC = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color pixelA = imageA.GetPixel(x, y);

                    if (pixelA.G > 100 && pixelA.G > pixelA.R + 40 && pixelA.G > pixelA.B + 40)
                    {
                        Color pixelB = imageB.GetPixel(x, y);
                        imageC.SetPixel(x, y, pixelB);
                    }
                    else
                    {
                        imageC.SetPixel(x, y, pixelA);
                    }
                }
            }

            pictureBox3.Image = imageC;
        }


        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No webcam found.");
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            videoSource.Start();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoSource != null && videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.WaitForStop();
                    videoSource = null;
                }

                pictureBox1.Image = null;
                MessageBox.Show("Webcam stopped.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error stopping webcam: " + ex.Message);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            base.OnFormClosing(e);
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            Bitmap processed = (Bitmap)frame.Clone();

            if (greyscaleEnabled) processed = ProcessGreyscale(processed);
            if (invertEnabled) processed = ProcessInvert(processed);
            if (sepiaEnabled) processed = ProcessSepia(processed);
            if (greenscreenEnabled && imageB != null) processed = ProcessGreenScreen(processed, imageB);

            pictureBox1.Invoke(new Action(() =>
            {
                if (imageA != null) imageA.Dispose();
                imageA = processed;
                pictureBox1.Image = imageA;
            }));
        }


        private Bitmap ProcessGreyscale(Bitmap src)
        {
            Bitmap result = new Bitmap(src.Width, src.Height);
            for (int x = 0; x < src.Width; x++)
                for (int y = 0; y < src.Height; y++)
                {
                    Color p = src.GetPixel(x, y);
                    int g = (int)(0.3 * p.R + 0.59 * p.G + 0.11 * p.B);
                    result.SetPixel(x, y, Color.FromArgb(g, g, g));
                }
            return result;
        }

        private Bitmap ProcessInvert(Bitmap src)
        {
            Bitmap result = new Bitmap(src.Width, src.Height);
            for (int x = 0; x < src.Width; x++)
                for (int y = 0; y < src.Height; y++)
                {
                    Color p = src.GetPixel(x, y);
                    result.SetPixel(x, y, Color.FromArgb(255 - p.R, 255 - p.G, 255 - p.B));
                }
            return result;
        }

        private Bitmap ProcessSepia(Bitmap src)
        {
            Bitmap result = new Bitmap(src.Width, src.Height);
            for (int x = 0; x < src.Width; x++)
                for (int y = 0; y < src.Height; y++)
                {
                    Color p = src.GetPixel(x, y);
                    int tr = Math.Min(255, (int)(0.393 * p.R + 0.769 * p.G + 0.189 * p.B));
                    int tg = Math.Min(255, (int)(0.349 * p.R + 0.686 * p.G + 0.168 * p.B));
                    int tb = Math.Min(255, (int)(0.272 * p.R + 0.534 * p.G + 0.131 * p.B));
                    result.SetPixel(x, y, Color.FromArgb(tr, tg, tb));
                }
            return result;
        }

        private Bitmap ProcessGreenScreen(Bitmap src, Bitmap bg)
        {
            int width = Math.Min(src.Width, bg.Width);
            int height = Math.Min(src.Height, bg.Height);
            Bitmap result = new Bitmap(width, height);

            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                {
                    Color pA = src.GetPixel(x, y);
                    if (pA.G > 100 && pA.G > pA.R + 40 && pA.G > pA.B + 40)
                    {
                        Color pB = bg.GetPixel(x, y);
                        result.SetPixel(x, y, pB);
                    }
                    else
                    {
                        result.SetPixel(x, y, pA);
                    }
                }
            return result;
        }

        
    }
}
