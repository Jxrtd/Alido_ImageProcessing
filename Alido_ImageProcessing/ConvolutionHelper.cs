using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Alido_ImageProcessing
{
    public class ConvMatrix
    {
        public int[,] Matrix;
        public int Size;
        public int Factor;
        public int Offset;

        public ConvMatrix(int size)
        {
            Size = size;
            Matrix = new int[size, size];
            Factor = 1;
            Offset = 0;
        }

        public void SetAll(int value)
        {
            for (int y = 0; y < Size; y++)
                for (int x = 0; x < Size; x++)
                    Matrix[y, x] = value;
        }

        public static Bitmap ApplyConvolution(Bitmap src, ConvMatrix m)
        {
            if (m.Factor == 0) return src;

            Bitmap newImage = new Bitmap(src.Width, src.Height, PixelFormat.Format24bppRgb);
            int radius = m.Size / 2;

            for (int y = radius; y < src.Height - radius; y++)
            {
                for (int x = radius; x < src.Width - radius; x++)
                {
                    int r = 0, g = 0, b = 0;

                    for (int fy = -radius; fy <= radius; fy++)
                    {
                        for (int fx = -radius; fx <= radius; fx++)
                        {
                            Color c = src.GetPixel(x + fx, y + fy);
                            int weight = m.Matrix[fy + radius, fx + radius];

                            r += c.R * weight;
                            g += c.G * weight;
                            b += c.B * weight;
                        }
                    }

                    r = r / m.Factor + m.Offset;
                    g = g / m.Factor + m.Offset;
                    b = b / m.Factor + m.Offset;

                    r = Math.Min(Math.Max(r, 0), 255);
                    g = Math.Min(Math.Max(g, 0), 255);
                    b = Math.Min(Math.Max(b, 0), 255);

                    newImage.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return newImage;
        }

        public static ConvMatrix GetSmoothingMatrix()
        {
            ConvMatrix m = new ConvMatrix(3);
            m.SetAll(1);
            m.Factor = 9;
            return m;
        }

        public static ConvMatrix GetGaussianBlurMatrix()
        {
            ConvMatrix m = new ConvMatrix(7);
            m.Matrix = new int[,]
            {
                { 0, 0, 1, 2, 1, 0, 0 },
                { 0, 3, 13,22,13, 3, 0 },
                { 1,13, 59,97,59,13, 1 },
                { 2,22, 97,159,97,22, 2 },
                { 1,13, 59,97,59,13, 1 },
                { 0, 3, 13,22,13, 3, 0 },
                { 0, 0, 1, 2, 1, 0, 0 }
            };
            m.Factor = 1003;
            return m;
        }

        public static ConvMatrix GetSharpenMatrix()
        {
            ConvMatrix m = new ConvMatrix(3);
            m.Matrix = new int[,]
            {
                { 0, -2, 0 },
                { -2,11,-2 },
                { 0, -2, 0 }
            };
            m.Factor = 3;
            return m;
        }

        public static ConvMatrix GetMeanRemovalMatrix()
        {
            ConvMatrix m = new ConvMatrix(3);
            m.Matrix = new int[,]
            {
                { -1, -1, -1 },
                { -1,  9, -1 },
                { -1, -1, -1 }
            };
            m.Factor = 1;
            return m;
        }

        public static ConvMatrix GetEmbossMatrix()
        {
            ConvMatrix m = new ConvMatrix(3);
            m.Matrix = new int[,]
            {
                { -1,  0, -1 },
                {  0,  4,  0 },
                { -1,  0, -1 }
            };
            m.Factor = 1;
            m.Offset = 127;
            return m;
        }

        public static ConvMatrix GetEmbossLaplacianMatrix()
        {
            ConvMatrix m = new ConvMatrix(3);
            m.Matrix = new int[,]
            {
                { -1, -1, -1 },
                { -1,  8, -1 },
                { -1, -1, -1 }
            };
            m.Factor = 1;
            m.Offset = 127;
            return m;
        }

        public static ConvMatrix GetLaplacianMatrix()
        {
            ConvMatrix m = new ConvMatrix(3);
            m.Matrix = new int[,]
            {
                { 0, -1, 0 },
                { -1, 4, -1 },
                { 0, -1, 0 }
            };
            m.Factor = 1;
            return m;
        }

        public static ConvMatrix GetEmbossAllDirectionsMatrix()
        {
            ConvMatrix m = new ConvMatrix(3);
            m.Matrix = new int[,]
            {
                { -1, -1, -1 },
                { -1,  8, -1 },
                { -1, -1, -1 }
            };
            m.Factor = 1;
            m.Offset = 127;
            return m;
        }

        public static ConvMatrix GetEmbossHorizontalMatrix()
        {
            ConvMatrix m = new ConvMatrix(3);
            m.Matrix = new int[,]
            {
                { 0, 0, 0 },
                { -1, 2, -1 },
                { 0, 0, 0 }
            };
            m.Factor = 1;
            m.Offset = 127;
            return m;
        }

        public static ConvMatrix GetEmbossVerticalMatrix()
        {
            ConvMatrix m = new ConvMatrix(3);
            m.Matrix = new int[,]
            {
                { 0, -1, 0 },
                { 0, 0, 0 },
                { 0, 1, 0 }
            };
            m.Factor = 1;
            m.Offset = 127;
            return m;
        }

        public static ConvMatrix GetEmbossHorizontalVerticalMatrix()
        {
            ConvMatrix m = new ConvMatrix(3);
            m.Matrix = new int[,]
            {
        { -1, -2, -1 },
        {  0,  0,  0 },
        {  1,  2,  1 }
            };
            m.Factor = 1;
            m.Offset = 127;
            return m;
        }

        public static ConvMatrix GetLossyMatrix()
        {
            ConvMatrix m = new ConvMatrix(3);
            m.Matrix = new int[,]
            {
        {  1,  1,  1 },
        {  1,  5,  1 },
        {  1,  1,  1 }
            };
            m.Factor = 13; 
            return m;
        }
    }
}
