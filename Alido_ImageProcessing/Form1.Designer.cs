
namespace Alido_ImageProcessing
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            menuStrip1 = new MenuStrip();
            imageToolStripMenuItem = new ToolStripMenuItem();
            imageAToolStripMenuItem = new ToolStripMenuItem();
            imageBToolStripMenuItem = new ToolStripMenuItem();
            optionToolStripMenuItem = new ToolStripMenuItem();
            subtractToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            imageAToolStripMenuItem1 = new ToolStripMenuItem();
            imageBToolStripMenuItem1 = new ToolStripMenuItem();
            greyscaleToolStripMenuItem = new ToolStripMenuItem();
            imageAToolStripMenuItem2 = new ToolStripMenuItem();
            imageBToolStripMenuItem2 = new ToolStripMenuItem();
            colorInversionToolStripMenuItem = new ToolStripMenuItem();
            imageAToolStripMenuItem3 = new ToolStripMenuItem();
            imageBToolStripMenuItem3 = new ToolStripMenuItem();
            histogramToolStripMenuItem = new ToolStripMenuItem();
            imageAToolStripMenuItem4 = new ToolStripMenuItem();
            imageBToolStripMenuItem4 = new ToolStripMenuItem();
            sepiaToolStripMenuItem = new ToolStripMenuItem();
            imageAToolStripMenuItem5 = new ToolStripMenuItem();
            imageBToolStripMenuItem5 = new ToolStripMenuItem();
            webcamToolStripMenuItem = new ToolStripMenuItem();
            startToolStripMenuItem = new ToolStripMenuItem();
            stopToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(65, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(597, 322);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(65, 406);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(594, 313);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(674, 171);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(605, 430);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { imageToolStripMenuItem, optionToolStripMenuItem, webcamToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1291, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // imageToolStripMenuItem
            // 
            imageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imageAToolStripMenuItem, imageBToolStripMenuItem });
            imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            imageToolStripMenuItem.Size = new Size(52, 20);
            imageToolStripMenuItem.Text = "Image";
            // 
            // imageAToolStripMenuItem
            // 
            imageAToolStripMenuItem.Name = "imageAToolStripMenuItem";
            imageAToolStripMenuItem.Size = new Size(115, 22);
            imageAToolStripMenuItem.Text = "ImageA";
            imageAToolStripMenuItem.Click += imageAToolStripMenuItem_Click;
            // 
            // imageBToolStripMenuItem
            // 
            imageBToolStripMenuItem.Name = "imageBToolStripMenuItem";
            imageBToolStripMenuItem.Size = new Size(115, 22);
            imageBToolStripMenuItem.Text = "ImageB";
            imageBToolStripMenuItem.Click += imageBToolStripMenuItem_Click;
            // 
            // optionToolStripMenuItem
            // 
            optionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { subtractToolStripMenuItem, copyToolStripMenuItem, greyscaleToolStripMenuItem, colorInversionToolStripMenuItem, histogramToolStripMenuItem, sepiaToolStripMenuItem });
            optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            optionToolStripMenuItem.Size = new Size(56, 20);
            optionToolStripMenuItem.Text = "Option";
            // 
            // subtractToolStripMenuItem
            // 
            subtractToolStripMenuItem.Name = "subtractToolStripMenuItem";
            subtractToolStripMenuItem.Size = new Size(154, 22);
            subtractToolStripMenuItem.Text = "Subtract";
            subtractToolStripMenuItem.Click += subtractToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imageAToolStripMenuItem1, imageBToolStripMenuItem1 });
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(154, 22);
            copyToolStripMenuItem.Text = "Copy";
            // 
            // imageAToolStripMenuItem1
            // 
            imageAToolStripMenuItem1.Name = "imageAToolStripMenuItem1";
            imageAToolStripMenuItem1.Size = new Size(115, 22);
            imageAToolStripMenuItem1.Text = "ImageA";
            imageAToolStripMenuItem1.Click += imageAToolStripMenuItem1_Click;
            // 
            // imageBToolStripMenuItem1
            // 
            imageBToolStripMenuItem1.Name = "imageBToolStripMenuItem1";
            imageBToolStripMenuItem1.Size = new Size(115, 22);
            imageBToolStripMenuItem1.Text = "ImageB";
            imageBToolStripMenuItem1.Click += imageBToolStripMenuItem1_Click;
            // 
            // greyscaleToolStripMenuItem
            // 
            greyscaleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imageAToolStripMenuItem2, imageBToolStripMenuItem2 });
            greyscaleToolStripMenuItem.Name = "greyscaleToolStripMenuItem";
            greyscaleToolStripMenuItem.Size = new Size(154, 22);
            greyscaleToolStripMenuItem.Text = "Greyscale";
            // 
            // imageAToolStripMenuItem2
            // 
            imageAToolStripMenuItem2.Name = "imageAToolStripMenuItem2";
            imageAToolStripMenuItem2.Size = new Size(115, 22);
            imageAToolStripMenuItem2.Text = "ImageA";
            imageAToolStripMenuItem2.Click += imageAToolStripMenuItem2_Click;
            // 
            // imageBToolStripMenuItem2
            // 
            imageBToolStripMenuItem2.Name = "imageBToolStripMenuItem2";
            imageBToolStripMenuItem2.Size = new Size(115, 22);
            imageBToolStripMenuItem2.Text = "ImageB";
            imageBToolStripMenuItem2.Click += imageBToolStripMenuItem2_Click;
            // 
            // colorInversionToolStripMenuItem
            // 
            colorInversionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imageAToolStripMenuItem3, imageBToolStripMenuItem3 });
            colorInversionToolStripMenuItem.Name = "colorInversionToolStripMenuItem";
            colorInversionToolStripMenuItem.Size = new Size(154, 22);
            colorInversionToolStripMenuItem.Text = "Color Inversion";
            // 
            // imageAToolStripMenuItem3
            // 
            imageAToolStripMenuItem3.Name = "imageAToolStripMenuItem3";
            imageAToolStripMenuItem3.Size = new Size(115, 22);
            imageAToolStripMenuItem3.Text = "ImageA";
            imageAToolStripMenuItem3.Click += imageAToolStripMenuItem3_Click;
            // 
            // imageBToolStripMenuItem3
            // 
            imageBToolStripMenuItem3.Name = "imageBToolStripMenuItem3";
            imageBToolStripMenuItem3.Size = new Size(115, 22);
            imageBToolStripMenuItem3.Text = "ImageB";
            imageBToolStripMenuItem3.Click += imageBToolStripMenuItem3_Click;
            // 
            // histogramToolStripMenuItem
            // 
            histogramToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imageAToolStripMenuItem4, imageBToolStripMenuItem4 });
            histogramToolStripMenuItem.Name = "histogramToolStripMenuItem";
            histogramToolStripMenuItem.Size = new Size(154, 22);
            histogramToolStripMenuItem.Text = "Histogram";
            // 
            // imageAToolStripMenuItem4
            // 
            imageAToolStripMenuItem4.Name = "imageAToolStripMenuItem4";
            imageAToolStripMenuItem4.Size = new Size(115, 22);
            imageAToolStripMenuItem4.Text = "ImageA";
            imageAToolStripMenuItem4.Click += imageAToolStripMenuItem4_Click;
            // 
            // imageBToolStripMenuItem4
            // 
            imageBToolStripMenuItem4.Name = "imageBToolStripMenuItem4";
            imageBToolStripMenuItem4.Size = new Size(115, 22);
            imageBToolStripMenuItem4.Text = "ImageB";
            imageBToolStripMenuItem4.Click += imageBToolStripMenuItem4_Click;
            // 
            // sepiaToolStripMenuItem
            // 
            sepiaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imageAToolStripMenuItem5, imageBToolStripMenuItem5 });
            sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            sepiaToolStripMenuItem.Size = new Size(154, 22);
            sepiaToolStripMenuItem.Text = "Sepia";
            // 
            // imageAToolStripMenuItem5
            // 
            imageAToolStripMenuItem5.Name = "imageAToolStripMenuItem5";
            imageAToolStripMenuItem5.Size = new Size(115, 22);
            imageAToolStripMenuItem5.Text = "ImageA";
            imageAToolStripMenuItem5.Click += imageAToolStripMenuItem5_Click;
            // 
            // imageBToolStripMenuItem5
            // 
            imageBToolStripMenuItem5.Name = "imageBToolStripMenuItem5";
            imageBToolStripMenuItem5.Size = new Size(115, 22);
            imageBToolStripMenuItem5.Text = "ImageB";
            imageBToolStripMenuItem5.Click += imageBToolStripMenuItem5_Click;
            // 
            // webcamToolStripMenuItem
            // 
            webcamToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { startToolStripMenuItem, stopToolStripMenuItem });
            webcamToolStripMenuItem.Name = "webcamToolStripMenuItem";
            webcamToolStripMenuItem.Size = new Size(66, 20);
            webcamToolStripMenuItem.Text = "Webcam";
            // 
            // startToolStripMenuItem
            // 
            startToolStripMenuItem.Name = "startToolStripMenuItem";
            startToolStripMenuItem.Size = new Size(97, 22);
            startToolStripMenuItem.Text = "start";
            startToolStripMenuItem.Click += startToolStripMenuItem_Click;
            // 
            // stopToolStripMenuItem
            // 
            stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            stopToolStripMenuItem.Size = new Size(97, 22);
            stopToolStripMenuItem.Text = "stop";
            stopToolStripMenuItem.Click += stopToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1291, 770);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem imageToolStripMenuItem;
        private ToolStripMenuItem imageAToolStripMenuItem;
        private ToolStripMenuItem imageBToolStripMenuItem;
        private ToolStripMenuItem optionToolStripMenuItem;
        private ToolStripMenuItem subtractToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem greyscaleToolStripMenuItem;
        private ToolStripMenuItem colorInversionToolStripMenuItem;
        private ToolStripMenuItem webcamToolStripMenuItem;
        private ToolStripMenuItem histogramToolStripMenuItem;
        private ToolStripMenuItem sepiaToolStripMenuItem;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem imageAToolStripMenuItem1;
        private ToolStripMenuItem imageBToolStripMenuItem1;
        private ToolStripMenuItem imageAToolStripMenuItem2;
        private ToolStripMenuItem imageBToolStripMenuItem2;
        private ToolStripMenuItem imageAToolStripMenuItem3;
        private ToolStripMenuItem imageBToolStripMenuItem3;
        private ToolStripMenuItem imageAToolStripMenuItem4;
        private ToolStripMenuItem imageBToolStripMenuItem4;
        private ToolStripMenuItem imageAToolStripMenuItem5;
        private ToolStripMenuItem imageBToolStripMenuItem5;
    }
}
