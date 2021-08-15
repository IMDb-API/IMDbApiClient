using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace IMDbAPI_Client
{
    public class ClientUtils
    {
        public static byte[] ImageToBytes(Image img)
        {
            return ImageToBytes(img, ImageFormat.Png);
        }

        public static byte[] ImageToBytes(Image img, Size size)
        {
            if (img == null)
                return null;

            if (img.Width > size.Width || img.Height > size.Height)
                img = ResizeImage(img, size);

            return ImageToBytes(img, ImageFormat.Png);
        }

        public static byte[] ImageToBytes(Image img, ImageFormat imgFormat)
        {
            if (img == null)
                return null;

            var ms = new MemoryStream();
            img.Save(ms, imgFormat);
            return ms.ToArray();
        }

        public static Image BytesToImage(byte[] bytes)
        {
            if (bytes == null)
                return null;

            var ms = new MemoryStream(bytes);
            var returnImage = Image.FromStream(ms);
            return returnImage;
        }

        public static Image BytesToImage(byte[] bytes, Size size)
        {
            if (bytes == null)
                return null;

            var img = BytesToImage(bytes);
            if (img.Width > size.Width || img.Height > size.Height)
                return ResizeImage(img, size);

            return img;
        }

        public static Image ResizeImage(Image img, Size size)
        {
            var ratioX = (double)size.Width / img.Width;
            var ratioY = (double)size.Height / img.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(img.Width * ratio);
            var newHeight = (int)(img.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(img, 0, 0, newWidth, newHeight);

            return newImage;
        }
    }
}
