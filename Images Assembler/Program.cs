using System;
using System.IO;

namespace Images_Assembler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] photoBytes = File.ReadAllBytes("niko.png");
            Console.WriteLine(photoBytes[0]);
        }
    }
}
