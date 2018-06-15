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
        public static Bitmap Resize(int width, Bitmap bitmap)
        {
            return new Bitmap(bitmap, new Size(width, bitmap.Height * width / bitmap.Width));
        }
        public static double[,] rgb2gray(Bitmap original)
        {
            //make an empty bitmap the same size as original
            double[,] newBitmap = new double[original.Width, original.Height];

            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    //get the pixel from the original image
                    Color originalColor = original.GetPixel(i, j);

                    //create the grayscale version of the pixel
                    double grayScale = (double)((originalColor.R * .3) + (originalColor.G * .59) + (originalColor.B * .11));


                    //set the new image's pixel to the grayscale version
                    newBitmap[i, j] = grayScale;

                    if (SearchOperation.cancelled)
                        return newBitmap;
                }
            }
            return newBitmap;
        }

    }
}
