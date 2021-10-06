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
            using (MemoryStream inStream = new MemoryStream(photoBytes))
            {             
                    using (ImageFactory imageFactory = new ImageFactory(preserveExifData: true))
                    {
                        // Load, resize, set the format and quality and save an image.
                        imageFactory.Load(inStream)
                                    .Rotate(90)
                                    .Save("created/niko2.png");
                    }
                    // Do something with the stream
            }

        }
    }
}
