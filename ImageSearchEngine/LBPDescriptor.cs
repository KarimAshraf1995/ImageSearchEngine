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
            bitmap = new Bitmap(bitmap, new Size(128, bitmap.Height * 128 / bitmap.Width));
            //LBP descriptor is 128 vector of histogram values
            double[] lbp_hist = new double[256];


            //Compare 8 neighbours of each pixel with it, if larger set the corresponding bit 
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

                    if (SearchOperation.cancelled)
                        return lbp_hist;
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
    }
}
