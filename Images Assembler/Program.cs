using System;
using System.Drawing;
using System.IO;
using Image_Assembler;
using ImageProcessor;
using ImageProcessor.Imaging.Formats;

namespace Images_Assembler
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor proco = new Processor();

            proco.Assemble("niko.png", "logopull.png");
        }
    }
}
