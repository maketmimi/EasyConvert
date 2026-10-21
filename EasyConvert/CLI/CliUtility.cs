using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace EasyConvert.CLI
{
    public static class CliUtility
    {
        private static readonly string[] _HelpFlags = { "-h", "-help", "help", "h" }; 

        private enum EnArgumentsCheckResult : byte
        {
            InvalidArgumentsList,
            HelpRequested,
            ConvertArguments
        }

        private static EnArgumentsCheckResult CheckArgs(string[] args)
        {
            // args structure
            // EasyConvert.exe "Path of source image" "path fo converted image with new name and extention"

            if (args == null) return EnArgumentsCheckResult.InvalidArgumentsList;

            if (args.Length == 1 && _HelpFlags.Contains(args[0].ToLower())) return EnArgumentsCheckResult.HelpRequested;

            if (args.Length == 2) return EnArgumentsCheckResult.ConvertArguments;

            return EnArgumentsCheckResult.InvalidArgumentsList;
        }

        // returns null if failed to load
        private static Image LoadSourceImage(string SourceImagePath)
        {
            try
            {
                Image SourceImage = Image.FromFile(SourceImagePath);
                return SourceImage;
            }
            catch
            {
                return null;
            }
        }

        private static void ShowConvertResultMessage(Core.ImageConvertor.EnConvertResult Result)
        {
            switch (Result)
            {
                case Core.ImageConvertor.EnConvertResult.Successful:
                    Console.WriteLine("Done, Image Converted Successfully.");
                    break;
                case Core.ImageConvertor.EnConvertResult.Failed_FileAlreadyExists:
                    Console.WriteLine("ERROR: Image Already Exists!");
                    break;
                case Core.ImageConvertor.EnConvertResult.Failed_InvalidPath:
                    Console.WriteLine("ERROR: Invalid target path!");
                    Console.WriteLine("if you want to save it on the same directory put \".\\\" in front of the target name");
                    break;
                case Core.ImageConvertor.EnConvertResult.Failed_NotSupportedTargetFormat:
                    Console.WriteLine("ERROR: Target format is not supported!");
                    break;
                default:
                    Console.WriteLine("ERROR: Cannot convert image");
                    break;
            }
        }

        private static void ShowHelpMessage()
        {
            Console.WriteLine();
            Console.WriteLine("=====================================");
            Console.WriteLine("          EasyConvert CLI");
            Console.WriteLine("  Copyright (c) 2026 Malek Altamimi");
            Console.WriteLine("=====================================");

            Console.WriteLine("\nAbout:\n");
            Console.WriteLine("EasyConvert is an easy to use utility to convert Images to diffrent supported formats.");

            Console.WriteLine("\nSupported Target Formats:\n");

            foreach (var extention in Core.ImageFormats.GetSupportedExtentions())
            {
                Console.WriteLine(extention);
            }

            Console.WriteLine("\nExcpected command line arguments:\n");

            Console.WriteLine("EasyConvert.exe <Source Image Path> <Target Image Path with Target extention>");

            Console.WriteLine("\nExample:\n");

            Console.WriteLine("EasyConvert.exe c:\\MyFolder\\koko.png c:\\MyOtherFolder\\NewKoko.ico");
           
            Console.WriteLine("\nThis converts an image named \"koko.png\" that is located in \"c:\\MyFolder\" and saves it as .ico file inside \"c:\\MyOtherFolder\"");
        }

        private static void ShowInvalidArgumentsListMessage()
        {
            Console.WriteLine("ERROR: Wrong argument list!");
            Console.WriteLine("Use \"-h\" for more info.");
        }

        private static void ConvertImage(string SourceImagePath, string TargetImagePath)
        {
            Image SourceImage = LoadSourceImage(SourceImagePath);

            if (SourceImage == null)
            {
                Console.WriteLine("ERROR: Cannot Load source image!");
                Console.WriteLine($"Invalid path: {SourceImagePath}");
                return;
            }

            Core.ImageConvertor.EnConvertResult ConvertResult =
                Core.ImageConvertor.ConvertImage(
                    SourceImage,
                    Core.ImageFormats.GetFormatFromExtension(Path.GetExtension(TargetImagePath)),
                    TargetImagePath
                );

            ShowConvertResultMessage(ConvertResult);

            SourceImage?.Dispose();
        }

        public static void Run(string[] args)
        {
            switch (CheckArgs(args))
            {
                case EnArgumentsCheckResult.HelpRequested:
                    ShowHelpMessage();
                    break;
                case EnArgumentsCheckResult.ConvertArguments:
                    ConvertImage(args[0], args[1]);
                    break;
                default:
                    ShowInvalidArgumentsListMessage();
                    break;
            }
        }
    }
}
