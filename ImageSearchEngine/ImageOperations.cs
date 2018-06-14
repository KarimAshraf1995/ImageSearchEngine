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
        public static byte[,] rgb2gray(Bitmap original)
        {
            //make an empty bitmap the same size as original
            byte[,] newBitmap = new byte[original.Width, original.Height];

            for (int i = 0; i < original.Width; i++)
            {
                for (int j = 0; j < original.Height; j++)
                {
                    //get the pixel from the original image
                    Color originalColor = original.GetPixel(i, j);

                    //create the grayscale version of the pixel
                    byte grayScale = (byte)((originalColor.R * .3) + (originalColor.G * .59) + (originalColor.B * .11));


                    //set the new image's pixel to the grayscale version
                    newBitmap[i, j] = grayScale;

                    if (SearchOperation.cancelled)
                        return newBitmap;
                }
            }
            return newBitmap;
        }

        /*
        public static byte[,,] bitmap2byte(Bitmap bitmap)
        {
            byte[,,] rgb_matrix = new byte[bitmap.Width, bitmap.Height, 3];

            for(int i=0;i<bitmap.Width;i++)
            {
                for(int j=0;j<bitmap.Height;j++)
                {
                    rgb_matrix[i,j,0]=bitmap.get
                }
            }

            return rgb_matrix;
        }

    */

        //Returns the value of cosine the angle between the 2 vectors
        //Larger value indicates higher similarity between the 2 vectors
        public static double dotProduct(double[] descriptor1, double[] descriptor2)
        {
            double product = 0;
            double magAsq = 0, magBsq = 0;
            for (int i = 0; i < descriptor1.Length; i++)
            {
                product += descriptor1[i] * descriptor2[i];
                magAsq += descriptor1[i] * descriptor1[i];
                magBsq += descriptor2[i] * descriptor2[i];
                if (SearchOperation.cancelled)
                    return 0;
            }
            return product / (Math.Sqrt(magAsq) * Math.Sqrt(magBsq));
        }


        public static double ManhattanDistance(double[] descriptor1, double[] descriptor2)
        {
            double difference = 0;

            for (int i = 0; i < descriptor1.Length; i++)
            {
                difference += Math.Abs(descriptor1[i] - descriptor2[i]);

                if (SearchOperation.cancelled)
                    return 0;
            }
            return difference;
        }
    }
}
