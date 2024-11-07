using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Drawing;

namespace RtspStreamClientApp.Support.Helpers
{
    public class ImageConverter
    {
        // Mat to BitmapImage
        // 1. Mat to Bitmap
        // 2. Bitmap to BitmapImage
        public static BitmapImage MatToBitmapImage(Mat mat)
        {
            if (mat.Empty())
                throw new ArgumentException("Mat is empty.");
            var bitmap = MatToBitmap(mat);
            return BitmapToBitmapImage(bitmap);
        }

        // Mat to Bitmap
        private static Bitmap MatToBitmap(Mat mat)
        {
            if (mat.Empty())
                throw new ArgumentException("Mat is empty.");

            return OpenCvSharp.Extensions.BitmapConverter.ToBitmap(mat);
        }

        private static BitmapImage BitmapToBitmapImage(Bitmap bitmap)
        {
            if (bitmap == null)
                throw new ArgumentException("Bitmap is null.");

            using (var memory = new System.IO.MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;

                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = memory;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                bitmapImage.Freeze();

                return bitmapImage;
            }
        }

        // Mat to BitmapSource
        public static BitmapSource ColorConvertMatToBitmapSource(Mat mat)
        {
            if (mat.Empty())
                throw new ArgumentException("Mat is empty.");

            int width = mat.Width;
            int height = mat.Height;
            int stride = width * (mat.ElemSize());

            var ptr = mat.Data;

            return BitmapSource.Create(width, height, 96, 96, PixelFormats.Bgr24, null, ptr, stride * height, stride);
        }
    }
}
