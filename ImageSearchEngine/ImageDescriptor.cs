using System.Drawing;


namespace ImageSearchEngine
{
    interface IDescriptor
    {
        double[] GetDescriptor(Bitmap bitmap);
    }
}
