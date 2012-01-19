using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace QuantumCode.CAPTCHAReader.Common
{
    public static class BmpExtension
    {
        public static Bitmap ConvertGray(this Bitmap target)
        {
            int NumRow = target.Height;
            int numCol = target.Width;
            Bitmap GRAY = new Bitmap(target.Width, target.Height);

            for (int i = 0; i < NumRow; i++)
            {
                for (int j = 0; j < numCol; j++)
                {
                    Color c = target.GetPixel(j, i);
                    int rd = c.R; 
                    int gr = c.G; 
                    int bl = c.B;
                    double d1 = 0.2989 * (double)rd + 0.5870 * (double)gr + 0.1140 * (double)bl;
                    int c1 = (int)Math.Round(d1);
                    Color c2 = Color.FromArgb(c1, c1, c1);
                    GRAY.SetPixel(j, i, c2);
                }
            }

            return GRAY;
        }

        public static byte[] ScanImage(this Bitmap target)
        {
            int width = target.Width;
            int height = target.Height;

            byte[] scalBytes = new byte[width * height];

            for (int y = 0; y < height; y++)
            {
                int yh = y * width;

                for (int x = 0; x < width; x++)
                {
                    scalBytes[yh + x] = (byte)target.GetPixel(x, y).ToArgb();
                }

                y++;

                if (y == height)
                    break;

                yh = y * width;

                for (int x = width - 1; x >= 0; x--)
                {
                    scalBytes[yh + x] = (byte)target.GetPixel(x, y).ToArgb();
                }
            }

            return scalBytes;
        }

        public static byte[] ComputerThreshoding(this byte[] srcBytes, int width, int height)
        {
            return (new QuickAdaptiveThreshold()).ComputeThreshold(srcBytes, width, height);
        }

        public static Bitmap WriteBitmap(this byte[] srcBytes, int width, int height)
        {
            Bitmap retValue = new Bitmap(width, height);

            for (int y = 0; y < height; y++)
            {
                int yh = y * width;

                for (int x = 0; x < width; x++)
                {
                    int c = (int)srcBytes[yh + x];
                    retValue.SetPixel(x, y, Color.FromArgb(c, c, c));
                }

                y++;

                if (y == height)
                    break;

                yh = y * width;

                for (int x = width - 1; x >= 0; x--)
                {
                    int c = (int)srcBytes[yh + x];
                    retValue.SetPixel(x, y, Color.FromArgb(c, c, c));
                }
            }

            return retValue;
        }
    }
}
