using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;

namespace EasyConvert.Core
{
    public class ImageFormats
    {
        public static ImageFormats Bmp { get; } =
            new ImageFormats(EnImageFormats.Bmp, new string[] { ".bmp", ".dib" }, ImageFormat.Bmp);
        public static ImageFormats Png { get; } =
            new ImageFormats(EnImageFormats.Png, new string[] { ".png" }, ImageFormat.Png);
        public static ImageFormats Jpeg { get; } =
            new ImageFormats(EnImageFormats.Jpeg, new string[] { ".jpg", ".jpeg", ".jpe", ".jfif", ".jif", ".jfi" }, ImageFormat.Jpeg);
        public static ImageFormats Tiff { get; } =
            new ImageFormats(EnImageFormats.Tiff, new string[] { ".tif", ".tiff" }, ImageFormat.Tiff);
        public static ImageFormats Gif { get; } =
            new ImageFormats(EnImageFormats.Gif, new string[] { ".gif" }, ImageFormat.Gif);
        public static ImageFormats Ico { get; } =
            new ImageFormats(EnImageFormats.Ico, new string[] { ".ico" });

        public static ImageFormats[] SupportedFormats { get; } =
            new ImageFormats[]
            {
                Bmp,
                Png,
                Jpeg,
                Tiff,
                Gif,
                Ico
            };

        public static string[] GetSupportedExtentions()
        {
            List<string> LExtentions = new List<string>();

            foreach (var format in SupportedFormats)
            {
                LExtentions.AddRange(format.Extensions);
            }

            //TODO: we need to add a way that prevents the public user from modifing the underlying objects

            return LExtentions.ToArray();
        }

        /// <summary>
        /// method to get the format of the provided extention
        /// </summary>
        /// <param name="Extension">
        /// the extention to check
        /// </param>
        /// <returns>
        /// The ImageFormats object that corresponds to the provided exetention 
        /// </returns>
        public static ImageFormats GetFormatFromExtension(string Extension)
        {
            foreach (var format in SupportedFormats)
            {
                if (format.Extensions.Contains(Extension))
                    return format;
            }

            return null;
        }

        public enum EnImageFormats
        {
            UnKnown,
            Bmp,
            Gif,
            Jpeg,
            Ico,
            Png,
            Tiff
        }

        public EnImageFormats RawFormat { get; }
        public string[] Extensions { get; }
        public ImageFormat ImageFormatRawFormat { get; } = null;

        private ImageFormats(EnImageFormats rawFormat, string[] extensions)
        {
            RawFormat = rawFormat;
            Extensions = extensions;
        }

        private ImageFormats(EnImageFormats rawFormat, string[] extensions, ImageFormat imageFormatRawFormat) : this(rawFormat, extensions)
        {
            ImageFormatRawFormat = imageFormatRawFormat;
        }
    }
}
