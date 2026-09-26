using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace EasyConvert.Core
{
    public static class ImageConvertor
    {
        public enum EnCovertResult
        {
            Successful,
            FileAlreadyExists,
            Failed
        }

        private static Bitmap CopyImage(Image ImageToCopy)
        {
            Bitmap CopiedImage
                = new Bitmap(ImageToCopy.Width, ImageToCopy.Height, PixelFormat.Format32bppRgb);

            Graphics CopiedImageGrapghics = Graphics.FromImage(CopiedImage);
            
            CopiedImageGrapghics.DrawImage(ImageToCopy, 0, 0);

            return CopiedImage;
        }

        public static EnCovertResult ConvertImage(Image ImageToConvert, ImageFormat TargetFormat, string TargetName)
        {
            if (ImageToConvert == null || TargetFormat == null || string.IsNullOrWhiteSpace(TargetName)) return EnCovertResult.Failed;

            if (File.Exists(TargetName)) return EnCovertResult.FileAlreadyExists;

            try
            {
                ImageToConvert.Save(TargetName, TargetFormat);
                return EnCovertResult.Successful;
            }
            catch
            {
                return EnCovertResult.Failed;
            }
        } 
    }
}
