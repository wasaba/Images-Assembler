using System.Drawing;
using System.IO;
using ImageProcessor;
using ImageProcessor.Imaging;

namespace Image_Assembler
{
    public class Processor
	{

		public void Assemble(string PathFirst, string PathSecond)
		{
			Image ImageOverlay = Image.FromFile(PathSecond);

			Image bit = new Bitmap(PathFirst);

			using(Graphics gr = Graphics.FromImage(bit))
            {
				gr.DrawImage(ImageOverlay, new Point(0, 0));
            }
			if(Directory.Exists("rendered"))
            {
				bit.Save("rendered/output.png");
			}
            else
            {
				Directory.CreateDirectory("rendered");
            }

			bit.Save("rendered/output1.png");
        }
	}
}
