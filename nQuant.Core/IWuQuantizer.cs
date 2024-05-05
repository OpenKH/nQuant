#if WINDOWS || NETSTANDARD2_0_OR_GREATER // Please note that the System.Drawing.Common library is designed to be used exclusively in a Windows environment.
using System.Drawing;

namespace nQuant
{
    public interface IWuQuantizer
    {
        Image QuantizeImage(Bitmap image, int alphaThreshold, int alphaFader);
        Image QuantizeImage(Bitmap image, int alphaThreshold, int alphaFader, int maxColors);
    }
}
#endif
