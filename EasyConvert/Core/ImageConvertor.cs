using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace EasyConvert.Core
{
    public static class ImageConvertor
    {
        public enum EnConvertResult
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

        private static EnConvertResult ConvertImageToKnownFormat(Image ImageToConvert, ImageFormat TargetFormat, string TargetName)
        {
            try
            {
                ImageToConvert.Save(TargetName, TargetFormat);
                return EnConvertResult.Successful;
            }
            catch
            {
                return EnConvertResult.Failed;
            }
        }

        private static EnConvertResult ConvertImageToIco(Image ImageToConvert, string TargetName)
        {
            IcoBuilder icoBuilder = new IcoBuilder();

            icoBuilder.AddImage(ImageToConvert, 16, 16);
            icoBuilder.AddImage(ImageToConvert, 24, 24);
            icoBuilder.AddImage(ImageToConvert, 32, 32);
            icoBuilder.AddImage(ImageToConvert, 48, 48);
            icoBuilder.AddImage(ImageToConvert, 64, 64);
            icoBuilder.AddImage(ImageToConvert, 0, 0); // for 256x256

            if (icoBuilder.Save(TargetName))
                return EnConvertResult.Successful;
            else
                return EnConvertResult.Failed;
        }

        public static EnConvertResult ConvertImage(Image ImageToConvert, ImageFormats TargetFormat, string TargetName)
        {
            if (ImageToConvert == null || TargetFormat == null || string.IsNullOrWhiteSpace(TargetName)) return EnConvertResult.Failed;

            if (File.Exists(TargetName)) return EnConvertResult.FileAlreadyExists;

            switch (TargetFormat.RawFormat)
            {
                case ImageFormats.EnImageFormats.Bmp:
                case ImageFormats.EnImageFormats.Gif:
                case ImageFormats.EnImageFormats.Jpeg:
                case ImageFormats.EnImageFormats.Png:
                case ImageFormats.EnImageFormats.Tiff:
                    return ConvertImageToKnownFormat(ImageToConvert, TargetFormat.ImageFormatRawFormat, TargetName);
                case ImageFormats.EnImageFormats.Ico:
                    return ConvertImageToIco(ImageToConvert, TargetName);
                default:
                    return EnConvertResult.Failed; // not implemented yet       
            }
        } 
    }
}
