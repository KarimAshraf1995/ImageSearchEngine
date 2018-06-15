using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSearchEngine
{
    class LBPDescriptor : IDescriptor
    {
        //Gets 256-dimension LBP descriptor
        public double[] GetDescriptor(Bitmap bitmap)
        {
            //LBP descriptor is 128 vector of histogram values
            double[] lbp_hist = new double[256 * 3];
            int[,] im_matrix = new int[bitmap.Width, bitmap.Height];

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    im_matrix[i, j] = bitmap.GetPixel(i, j).ToArgb();
                }
            }


            //Compare 8 neighbours of each pixel with it, if larger set the corresponding bit 
            //for simplicity, ignore corner pixels for now.
            for (int i = 1; i < bitmap.Width - 1; i++)
            {
                for (int j = 1; j < bitmap.Height - 1; j++)
                {

                    int current = im_matrix[i, j];//Current pixel value
                    int[] neighbours = {    //Current pixels 8 neighbours starting left pixel moving in clockwise 
                        im_matrix[i - 1, j],          //Left-middle pixel
                        im_matrix[i - 1, j - 1],      //Left-top pixel
                        im_matrix[i, j - 1],          //top pixel
                        im_matrix[i + 1, j - 1],      //Right-top pixel
                        im_matrix[i + 1, j],          //Right-middle pixel
                        im_matrix[i + 1, j + 1],      //Right-bottom pixel
                        im_matrix[i, j + 1],          //bottom pixel
                        im_matrix[i - 1, j + 1]       //Left-bottom pixel
                    };

                    int color_mask = 0x000000FF;    //current color to check

                    for (int M = 0; M < 3; M++)//For three colors
                    {
                        byte value = 0;     //8 bit value for current color
                        byte bit = 0x01;    //current bit to be set if condition is met

                        for (int N = 0; N < 8; N++)//For 8 neighbours
                        {
                            if ((current & color_mask) < (neighbours[N] & color_mask))
                                value |= bit;
                            bit <<= 1; //Next bit 
                        }
                        color_mask <<= 8; //Next color

                        lbp_hist[M * 256 + value]++; //count for current color in histogram
                    }

                    if (SearchOperation.cancelled)
                        return lbp_hist;
                }
            }
            //Normalize histogram
            int size = bitmap.Width * bitmap.Height;
            for (int i = 0; i < lbp_hist.Length; i++)
            {
                lbp_hist[i] = lbp_hist[i] / size;
            }
            return lbp_hist;
        }
    }
}
