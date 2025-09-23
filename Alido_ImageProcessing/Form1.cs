using System;
using System.Drawing;
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
            if (imageA == null || imageB == null)
            {
                MessageBox.Show("Please load both images first or start webcam for Image A.");
                return;
            }

            Bitmap source = new Bitmap(imageA);
            imageC = new Bitmap(imageB.Width, imageB.Height);

            for (int x = 0; x < imageB.Width; x++)
            {
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);

                    if (pixel.G > 100 && pixel.G > pixel.R + 40 && pixel.G > pixel.B + 40)
                    {
                        Color backpixel = source.GetPixel(x, y);
                        imageC.SetPixel(x, y, backpixel);
                    }
                    else
                    {
                        imageC.SetPixel(x, y, pixel);
                    }
                }
            }

            pictureBox3.Image = imageC;
            source.Dispose();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageA == null)
            {
                MessageBox.Show("Please load Image A first or start webcam.");
                return;
            }

            Bitmap source = new Bitmap(imageA);
            imageC = new Bitmap(source);
            pictureBox2.Image = imageC;
            source.Dispose();
        }

        private void greyscaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageA == null)
            {
                MessageBox.Show("Please load Image A first or start webcam.");
                return;
            }

            Bitmap source = new Bitmap(imageB);
            imageC = new Bitmap(source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixel = source.GetPixel(x, y);
                    int grey = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
                    imageC.SetPixel(x, y, Color.FromArgb(grey, grey, grey));
                }
            }

            pictureBox3.Image = imageC;
            source.Dispose();
        }

        private void colorInversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageA == null)
            {
                MessageBox.Show("Please load Image A first or start webcam.");
                return;
            }

            Bitmap source = new Bitmap(imageB);
            imageC = new Bitmap(source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixel = source.GetPixel(x, y);
                    Color inverted = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    imageC.SetPixel(x, y, inverted);
                }
            }

            pictureBox3.Image = imageC;
            source.Dispose();
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

            if (imageA != null) imageA.Dispose();
            imageA = frame;

            pictureBox1.Image = imageA;
        }

        private void histogramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageA == null)
            {
                MessageBox.Show("Please load Image A first or start webcam.");
                return;
            }

            Bitmap source = new Bitmap(imageB);
            int[] histogram = new int[256];

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixel = source.GetPixel(x, y);
                    int grey = (int)(0.3 * pixel.R + 0.59 * pixel.G + 0.11 * pixel.B);
                    histogram[grey]++;
                }
            }

            int max = 0;
            for (int i = 0; i < 256; i++)
                if (histogram[i] > max) max = histogram[i];

            int histWidth = 256, histHeight = 200;
            Bitmap histImage = new Bitmap(histWidth, histHeight);

            using (Graphics g = Graphics.FromImage(histImage))
            {
                g.Clear(Color.White);
                for (int i = 0; i < 256; i++)
                {
                    float value = (float)histogram[i] / max;
                    int barHeight = (int)(value * histHeight);
                    g.DrawLine(Pens.Black, new Point(i, histHeight), new Point(i, histHeight - barHeight));
                }
            }

            pictureBox3.Image = histImage;
            source.Dispose();
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imageA == null)
            {
                MessageBox.Show("Please load Image A first or start webcam.");
                return;
            }

            Bitmap source = new Bitmap(imageB);
            imageC = new Bitmap(source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color pixel = source.GetPixel(x, y);

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
            source.Dispose();
        }
    }
}
