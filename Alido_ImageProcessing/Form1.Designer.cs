
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
            covoltionToolStripMenuItem = new ToolStripMenuItem();
            imageAToolStripMenuItem6 = new ToolStripMenuItem();
            smoothingToolStripMenuItem = new ToolStripMenuItem();
            gaussianBlurToolStripMenuItem = new ToolStripMenuItem();
            sharpenToolStripMenuItem = new ToolStripMenuItem();
            meanRemovalToolStripMenuItem = new ToolStripMenuItem();
            embossingToolStripMenuItem = new ToolStripMenuItem();
            laplascianToolStripMenuItem = new ToolStripMenuItem();
            allDerectionToolStripMenuItem = new ToolStripMenuItem();
            horizontalVericalToolStripMenuItem = new ToolStripMenuItem();
            lossyToolStripMenuItem = new ToolStripMenuItem();
            horizontalOnllyToolStripMenuItem = new ToolStripMenuItem();
            verticalOnlyToolStripMenuItem = new ToolStripMenuItem();
            imageBToolStripMenuItem6 = new ToolStripMenuItem();
            smoothingToolStripMenuItem1 = new ToolStripMenuItem();
            gaussianBlurToolStripMenuItem1 = new ToolStripMenuItem();
            sharpenToolStripMenuItem1 = new ToolStripMenuItem();
            meanRemovalToolStripMenuItem1 = new ToolStripMenuItem();
            embossingToolStripMenuItem1 = new ToolStripMenuItem();
            laplacianToolStripMenuItem = new ToolStripMenuItem();
            allDirectionToolStripMenuItem = new ToolStripMenuItem();
            horizontalVerticalToolStripMenuItem = new ToolStripMenuItem();
            lossyToolStripMenuItem1 = new ToolStripMenuItem();
            horizontalOnlyToolStripMenuItem = new ToolStripMenuItem();
            verticalOnlyToolStripMenuItem1 = new ToolStripMenuItem();
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
            pictureBox2.Location = new Point(65, 394);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(597, 322);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(682, 171);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(597, 322);
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
            optionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { subtractToolStripMenuItem, copyToolStripMenuItem, greyscaleToolStripMenuItem, colorInversionToolStripMenuItem, histogramToolStripMenuItem, sepiaToolStripMenuItem, covoltionToolStripMenuItem });
            optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            optionToolStripMenuItem.Size = new Size(56, 20);
            optionToolStripMenuItem.Text = "Option";
            // 
            // subtractToolStripMenuItem
            // 
            subtractToolStripMenuItem.Name = "subtractToolStripMenuItem";
            subtractToolStripMenuItem.Size = new Size(180, 22);
            subtractToolStripMenuItem.Text = "Subtract";
            subtractToolStripMenuItem.Click += subtractToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imageAToolStripMenuItem1, imageBToolStripMenuItem1 });
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(180, 22);
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
            greyscaleToolStripMenuItem.Size = new Size(180, 22);
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
            colorInversionToolStripMenuItem.Size = new Size(180, 22);
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
            histogramToolStripMenuItem.Size = new Size(180, 22);
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
            sepiaToolStripMenuItem.Size = new Size(180, 22);
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
            // covoltionToolStripMenuItem
            // 
            covoltionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { imageAToolStripMenuItem6, imageBToolStripMenuItem6 });
            covoltionToolStripMenuItem.Name = "covoltionToolStripMenuItem";
            covoltionToolStripMenuItem.Size = new Size(180, 22);
            covoltionToolStripMenuItem.Text = "Covolution";
            // 
            // imageAToolStripMenuItem6
            // 
            imageAToolStripMenuItem6.DropDownItems.AddRange(new ToolStripItem[] { smoothingToolStripMenuItem, gaussianBlurToolStripMenuItem, sharpenToolStripMenuItem, meanRemovalToolStripMenuItem, embossingToolStripMenuItem });
            imageAToolStripMenuItem6.Name = "imageAToolStripMenuItem6";
            imageAToolStripMenuItem6.Size = new Size(180, 22);
            imageAToolStripMenuItem6.Text = "ImageA";
            // 
            // smoothingToolStripMenuItem
            // 
            smoothingToolStripMenuItem.Name = "smoothingToolStripMenuItem";
            smoothingToolStripMenuItem.Size = new Size(180, 22);
            smoothingToolStripMenuItem.Text = "Smoothing ";
            smoothingToolStripMenuItem.Click += smoothingToolStripMenuItem_Click;
            // 
            // gaussianBlurToolStripMenuItem
            // 
            gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            gaussianBlurToolStripMenuItem.Size = new Size(180, 22);
            gaussianBlurToolStripMenuItem.Text = "Gaussian Blur ";
            gaussianBlurToolStripMenuItem.Click += gaussianBlurToolStripMenuItem_Click;
            // 
            // sharpenToolStripMenuItem
            // 
            sharpenToolStripMenuItem.Name = "sharpenToolStripMenuItem";
            sharpenToolStripMenuItem.Size = new Size(180, 22);
            sharpenToolStripMenuItem.Text = "Sharpen ";
            sharpenToolStripMenuItem.Click += sharpenToolStripMenuItem_Click;
            // 
            // meanRemovalToolStripMenuItem
            // 
            meanRemovalToolStripMenuItem.Name = "meanRemovalToolStripMenuItem";
            meanRemovalToolStripMenuItem.Size = new Size(180, 22);
            meanRemovalToolStripMenuItem.Text = "Mean Removal ";
            meanRemovalToolStripMenuItem.Click += meanRemovalToolStripMenuItem_Click;
            // 
            // embossingToolStripMenuItem
            // 
            embossingToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { laplascianToolStripMenuItem, allDerectionToolStripMenuItem, horizontalVericalToolStripMenuItem, lossyToolStripMenuItem, horizontalOnllyToolStripMenuItem, verticalOnlyToolStripMenuItem });
            embossingToolStripMenuItem.Name = "embossingToolStripMenuItem";
            embossingToolStripMenuItem.Size = new Size(180, 22);
            embossingToolStripMenuItem.Text = "Embossing ";
            // 
            // laplascianToolStripMenuItem
            // 
            laplascianToolStripMenuItem.Name = "laplascianToolStripMenuItem";
            laplascianToolStripMenuItem.Size = new Size(180, 22);
            laplascianToolStripMenuItem.Text = "Laplascian";
            laplascianToolStripMenuItem.Click += laplascianToolStripMenuItem_Click;
            // 
            // allDerectionToolStripMenuItem
            // 
            allDerectionToolStripMenuItem.Name = "allDerectionToolStripMenuItem";
            allDerectionToolStripMenuItem.Size = new Size(180, 22);
            allDerectionToolStripMenuItem.Text = "All Direction";
            allDerectionToolStripMenuItem.Click += allDerectionToolStripMenuItem_Click;
            // 
            // horizontalVericalToolStripMenuItem
            // 
            horizontalVericalToolStripMenuItem.Name = "horizontalVericalToolStripMenuItem";
            horizontalVericalToolStripMenuItem.Size = new Size(180, 22);
            horizontalVericalToolStripMenuItem.Text = "Horizontal/Verical";
            horizontalVericalToolStripMenuItem.Click += horizontalVericalToolStripMenuItem_Click;
            // 
            // lossyToolStripMenuItem
            // 
            lossyToolStripMenuItem.Name = "lossyToolStripMenuItem";
            lossyToolStripMenuItem.Size = new Size(180, 22);
            lossyToolStripMenuItem.Text = "Lossy";
            lossyToolStripMenuItem.Click += lossyToolStripMenuItem_Click;
            // 
            // horizontalOnllyToolStripMenuItem
            // 
            horizontalOnllyToolStripMenuItem.Name = "horizontalOnllyToolStripMenuItem";
            horizontalOnllyToolStripMenuItem.Size = new Size(180, 22);
            horizontalOnllyToolStripMenuItem.Text = "Horizontal Only";
            horizontalOnllyToolStripMenuItem.Click += horizontalOnllyToolStripMenuItem_Click;
            // 
            // verticalOnlyToolStripMenuItem
            // 
            verticalOnlyToolStripMenuItem.Name = "verticalOnlyToolStripMenuItem";
            verticalOnlyToolStripMenuItem.Size = new Size(180, 22);
            verticalOnlyToolStripMenuItem.Text = "Vertical Only";
            verticalOnlyToolStripMenuItem.Click += verticalOnlyToolStripMenuItem_Click;
            // 
            // imageBToolStripMenuItem6
            // 
            imageBToolStripMenuItem6.DropDownItems.AddRange(new ToolStripItem[] { smoothingToolStripMenuItem1, gaussianBlurToolStripMenuItem1, sharpenToolStripMenuItem1, meanRemovalToolStripMenuItem1, embossingToolStripMenuItem1 });
            imageBToolStripMenuItem6.Name = "imageBToolStripMenuItem6";
            imageBToolStripMenuItem6.Size = new Size(180, 22);
            imageBToolStripMenuItem6.Text = "ImageB";
            // 
            // smoothingToolStripMenuItem1
            // 
            smoothingToolStripMenuItem1.Name = "smoothingToolStripMenuItem1";
            smoothingToolStripMenuItem1.Size = new Size(156, 22);
            smoothingToolStripMenuItem1.Text = "Smoothing ";
            // 
            // gaussianBlurToolStripMenuItem1
            // 
            gaussianBlurToolStripMenuItem1.Name = "gaussianBlurToolStripMenuItem1";
            gaussianBlurToolStripMenuItem1.Size = new Size(156, 22);
            gaussianBlurToolStripMenuItem1.Text = "Gaussian Blur ";
            // 
            // sharpenToolStripMenuItem1
            // 
            sharpenToolStripMenuItem1.Name = "sharpenToolStripMenuItem1";
            sharpenToolStripMenuItem1.Size = new Size(156, 22);
            sharpenToolStripMenuItem1.Text = "Sharpen ";
            // 
            // meanRemovalToolStripMenuItem1
            // 
            meanRemovalToolStripMenuItem1.Name = "meanRemovalToolStripMenuItem1";
            meanRemovalToolStripMenuItem1.Size = new Size(156, 22);
            meanRemovalToolStripMenuItem1.Text = "Mean Removal ";
            // 
            // embossingToolStripMenuItem1
            // 
            embossingToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { laplacianToolStripMenuItem, allDirectionToolStripMenuItem, horizontalVerticalToolStripMenuItem, lossyToolStripMenuItem1, horizontalOnlyToolStripMenuItem, verticalOnlyToolStripMenuItem1 });
            embossingToolStripMenuItem1.Name = "embossingToolStripMenuItem1";
            embossingToolStripMenuItem1.Size = new Size(156, 22);
            embossingToolStripMenuItem1.Text = "Embossing ";
            // 
            // laplacianToolStripMenuItem
            // 
            laplacianToolStripMenuItem.Name = "laplacianToolStripMenuItem";
            laplacianToolStripMenuItem.Size = new Size(172, 22);
            laplacianToolStripMenuItem.Text = "Laplacian";
            laplacianToolStripMenuItem.Click += laplacianToolStripMenuItem_Click;
            // 
            // allDirectionToolStripMenuItem
            // 
            allDirectionToolStripMenuItem.Name = "allDirectionToolStripMenuItem";
            allDirectionToolStripMenuItem.Size = new Size(172, 22);
            allDirectionToolStripMenuItem.Text = "All Direction";
            allDirectionToolStripMenuItem.Click += allDirectionToolStripMenuItem_Click;
            // 
            // horizontalVerticalToolStripMenuItem
            // 
            horizontalVerticalToolStripMenuItem.Name = "horizontalVerticalToolStripMenuItem";
            horizontalVerticalToolStripMenuItem.Size = new Size(172, 22);
            horizontalVerticalToolStripMenuItem.Text = "Horizontal/Vertical";
            horizontalVerticalToolStripMenuItem.Click += horizontalVerticalToolStripMenuItem_Click;
            // 
            // lossyToolStripMenuItem1
            // 
            lossyToolStripMenuItem1.Name = "lossyToolStripMenuItem1";
            lossyToolStripMenuItem1.Size = new Size(172, 22);
            lossyToolStripMenuItem1.Text = "Lossy";
            lossyToolStripMenuItem1.Click += lossyToolStripMenuItem1_Click;
            // 
            // horizontalOnlyToolStripMenuItem
            // 
            horizontalOnlyToolStripMenuItem.Name = "horizontalOnlyToolStripMenuItem";
            horizontalOnlyToolStripMenuItem.Size = new Size(172, 22);
            horizontalOnlyToolStripMenuItem.Text = "Horizontal Only";
            horizontalOnlyToolStripMenuItem.Click += horizontalOnlyToolStripMenuItem_Click;
            // 
            // verticalOnlyToolStripMenuItem1
            // 
            verticalOnlyToolStripMenuItem1.Name = "verticalOnlyToolStripMenuItem1";
            verticalOnlyToolStripMenuItem1.Size = new Size(172, 22);
            verticalOnlyToolStripMenuItem1.Text = "Vertical only";
            verticalOnlyToolStripMenuItem1.Click += verticalOnlyToolStripMenuItem1_Click;
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
        private ToolStripMenuItem covoltionToolStripMenuItem;
        private ToolStripMenuItem imageAToolStripMenuItem6;
        private ToolStripMenuItem imageBToolStripMenuItem6;
        private ToolStripMenuItem smoothingToolStripMenuItem;
        private ToolStripMenuItem gaussianBlurToolStripMenuItem;
        private ToolStripMenuItem sharpenToolStripMenuItem;
        private ToolStripMenuItem meanRemovalToolStripMenuItem;
        private ToolStripMenuItem embossingToolStripMenuItem;
        private ToolStripMenuItem smoothingToolStripMenuItem1;
        private ToolStripMenuItem gaussianBlurToolStripMenuItem1;
        private ToolStripMenuItem sharpenToolStripMenuItem1;
        private ToolStripMenuItem meanRemovalToolStripMenuItem1;
        private ToolStripMenuItem embossingToolStripMenuItem1;
        private ToolStripMenuItem laplascianToolStripMenuItem;
        private ToolStripMenuItem allDerectionToolStripMenuItem;
        private ToolStripMenuItem horizontalVericalToolStripMenuItem;
        private ToolStripMenuItem lossyToolStripMenuItem;
        private ToolStripMenuItem horizontalOnllyToolStripMenuItem;
        private ToolStripMenuItem verticalOnlyToolStripMenuItem;
        private ToolStripMenuItem laplacianToolStripMenuItem;
        private ToolStripMenuItem allDirectionToolStripMenuItem;
        private ToolStripMenuItem horizontalVerticalToolStripMenuItem;
        private ToolStripMenuItem lossyToolStripMenuItem1;
        private ToolStripMenuItem horizontalOnlyToolStripMenuItem;
        private ToolStripMenuItem verticalOnlyToolStripMenuItem1;
    }
}
