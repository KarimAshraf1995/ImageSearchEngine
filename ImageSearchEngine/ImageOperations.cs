using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSearchEngine
{
    class ImageOperations
    {
        public static Bitmap rgb2gray(Bitmap original)
        {
            //make an empty bitmap the same size as original
            Bitmap newBitmap = new Bitmap(original.Width, original.Height);

            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    //get the pixel from the original image
                    Color originalColor = original.GetPixel(i, j);

                    //create the grayscale version of the pixel
                    int grayScale = (int)((originalColor.R * .3) + (originalColor.G * .59) + (originalColor.B * .11));

                    //create the color object
                    Color newColor = Color.FromArgb(grayScale, grayScale, grayScale);

                    //set the new image's pixel to the grayscale version
                    newBitmap.SetPixel(i, j, newColor);
                }
            }
            return newBitmap;
        }

        //Gets 256-deminisoin LBP descriptor
        public double[] LBP_Descriptor(Bitmap bitmap)
        {
            //LBP descriptor is 128 vector of histogram values
            double[] lbp_hist = new double[128];

            //for simplicity, ignore corner pixels for now.

            for (int i = 1; i < bitmap.Width - 1; i++)
            {
                for (int j = 1; j < bitmap.Height - 1; j++)
                {
                    byte value = 0;
                    //Left-middle pixel
                    if ((bitmap.GetPixel(i, j).R < bitmap.GetPixel(i - 1, j).R))
                        value |= 0x01;
                    //Left-top pixel
                    if ((bitmap.GetPixel(i, j).R < bitmap.GetPixel(i - 1, j - 1).R))
                        value |= 0x01 << 1;
                    //top pixel
                    if ((bitmap.GetPixel(i, j).R < bitmap.GetPixel(i, j - 1).R))
                        value |= 0x01 << 2;
                    //Right-top pixel
                    if ((bitmap.GetPixel(i, j).R < bitmap.GetPixel(i + 1, j - 1).R))
                        value |= 0x01 << 3;
                    //Right-middle pixel
                    if ((bitmap.GetPixel(i, j).R < bitmap.GetPixel(i + 1, j).R))
                        value |= 0x01 << 4;
                    //Right-bottom pixel
                    if ((bitmap.GetPixel(i, j).R < bitmap.GetPixel(i + 1, j + 1).R))
                        value |= 0x01 << 5;
                    //bottom pixel
                    if ((bitmap.GetPixel(i, j).R < bitmap.GetPixel(i, j + 1).R))
                        value |= 0x01 << 6;
                    //Left-bottom pixel
                    if ((bitmap.GetPixel(i, j).R < bitmap.GetPixel(i - 1, j + 1).R))
                        value |= 0x01 << 7;

                    //count in histogram
                    lbp_hist[value]++;
                }
            }
            //Normalize histogram
            int size = bitmap.Width * bitmap.Height;
            for (int i = 0; i < 256; i++)
            {
                lbp_hist[i] = lbp_hist[i] / size;
            }
            return lbp_hist;
        }
        public double dotProduct(double[] descriptor1, double[] descriptor2)
        {
            double product = 0;
            double magAsq = 0, magBsq = 0;
            for (int i = 0; i < 256; i++)
            {
                product += descriptor1[i] * descriptor2[i];
                magAsq += descriptor1[i] * descriptor1[i];
                magBsq += descriptor2[i] * descriptor2[i];
            }
            return product/(Math.Sqrt(magAsq)*Math.Sqrt(magBsq));
        }
    }
}
