using System.Drawing;


namespace ImageSearchEngine
{
    interface IDescriptor
    {
        //Descriptor vector
        double[] GetDescriptor(Bitmap bitmap);

        //Compares other Descriptor and return a score from 0 to 1 according to similarity
        double Compare(double[] descriptor1, double[] descriptor2);
    }
}
