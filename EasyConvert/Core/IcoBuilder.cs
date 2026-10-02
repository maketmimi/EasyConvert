using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace EasyConvert.Core
{
    public class IcoBuilder
    {
        private class IconImage
        {
            private Image _Image;
            public byte Width { get; }
            public byte Height { get; }

            public byte[] IconImageData { get; private set; }

            public IconImage(Image image, byte width, byte height)
            {
                if (image == null) throw new ArgumentNullException();

                this._Image = image;
                Width = width;
                Height = height;
                InitializeIconImageData();
            }

            public void InitializeIconImageData()
            {
                Bitmap IconImageBitmap = new Bitmap(_Image, 
                    (Width == 0) ? 256 : Width,
                    (Height == 0) ? 256 : Height);

                MemoryStream IconImageStream = new MemoryStream();
                
                IconImageBitmap.Save(IconImageStream, ImageFormat.Png);
                
                IconImageData = IconImageStream.ToArray();

                IconImageBitmap.Dispose();
                IconImageStream.Close();
            }
        }

        private readonly List<IconImage> _LIconImages = new List<IconImage>();

        /// <summary>
        /// Adds image to the ico file
        /// </summary>
        /// <param name="ImageToAdd">image to add to the ico file</param>
        /// <param name="Width">new width of the image in the ico file (from 0 to 255) and 0 means 256</param>
        /// <param name="Height">new heigth of the image in the ico file (from 0 to 255) and 0 means 256</param>
        public void AddImage(Image ImageToAdd, byte Width, byte Height)
        {
            if (ImageToAdd == null) return;

            if (_LIconImages.Count == ushort.MaxValue) return;

            _LIconImages.Add(new IconImage(ImageToAdd, Width, Height));
        }
    
        private byte[] GetIcoHeader()
        {
            byte[] IcoHeader = new byte[6];

            BinaryWriter Writer = new BinaryWriter(new MemoryStream(IcoHeader));

            Writer.Write((ushort)0); // reserved 2 bytes
            Writer.Write((ushort)1); // Type 2 bytes
            Writer.Write((ushort)_LIconImages.Count); // Number of images 2 bytes

            Writer.Close();

            return IcoHeader;
        }

        private byte[] GetIcoEntryForImage(IconImage iconImage, uint ImageDataOffset)
        {
            byte[] IcoImageEntry = new byte[16];

            BinaryWriter Writer = new BinaryWriter(new MemoryStream(IcoImageEntry));

            Writer.Write((byte)iconImage.Width); // image width
            Writer.Write((byte)iconImage.Height); // image height
            Writer.Write((byte)0); // Color count - we do not need this
            Writer.Write((byte)0); // Reserved
            Writer.Write((ushort)1); // Color planes - we do not need this just 1 for convention  
            Writer.Write((ushort)32); // bbp - this is not importent
            Writer.Write((uint)iconImage.IconImageData.Length); // the size of the image data in bytes
            Writer.Write((uint)ImageDataOffset); // the offste of the image data

            Writer.Close();
            
            return IcoImageEntry;
        }

        public bool Save(Stream TargetStream)
        {
            if (TargetStream == null) return false;

            BinaryWriter Writer = new BinaryWriter(TargetStream, Encoding.UTF8, true);

            Writer.Write(GetIcoHeader());

            // first image data offset
            uint ImageDataOffset = 6u + (16u * ((uint)_LIconImages.Count)); 

            foreach (var image in _LIconImages)
            {
                Writer.Write(GetIcoEntryForImage(image, ImageDataOffset));
                ImageDataOffset += ((uint)image.IconImageData.Length);
            }

            foreach (var image in _LIconImages)
            {
                Writer.Write(image.IconImageData);
            }

            Writer.Dispose();
            return true;
        }
    
        public bool Save(string FileName)
        {
            FileStream IconFileStream = null;
            try
            {
                IconFileStream = new FileStream(FileName, FileMode.Create);

                return Save(IconFileStream);
            }
            catch
            {
                return false;
            }
            finally
            {
                IconFileStream?.Close();
            }
        }
    }
}
