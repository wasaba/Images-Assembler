using System;
using System.Drawing;
using System.IO;
using ImageProcessor;
using ImageProcessor.Imaging.Formats;

namespace Images_Assembler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] photoBytes = File.ReadAllBytes("niko.png");
            
            ISupportedImageFormat format = new JpegFormat { Quality = 70 };
            Size size = new Size(150, 0);
            using (MemoryStream inStream = new MemoryStream(photoBytes))
            {
                using (MemoryStream outStream = new MemoryStream())
                {
                    
                    using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
                    {
                        // Load, resize, set the format and quality and save an image.
                        imageFactory.Load(inStream)
                                    .Resize(size)
                                    .Vignette(new Color())
                                    .Save(outStream);
                    }
                    // Do something with the stream.
                }
            }

        }
    }
}
