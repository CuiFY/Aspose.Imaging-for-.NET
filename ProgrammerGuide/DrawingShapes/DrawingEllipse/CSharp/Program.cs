//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Imaging. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.Imaging;

namespace DrawingEllipse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            //Creates an instance of FileStream
            using (System.IO.FileStream stream = new System.IO.FileStream(dataDir + "output.bmp", System.IO.FileMode.Create))
            {
                //Create an instance of BmpOptions and set its various properties
                Aspose.Imaging.ImageOptions.BmpOptions saveOptions = new Aspose.Imaging.ImageOptions.BmpOptions();
                saveOptions.BitsPerPixel = 32;

                //Set the Source for BmpOptions
                saveOptions.Source = new Aspose.Imaging.Sources.StreamSource(stream);

                //Create an instance of Image
                using (Aspose.Imaging.Image image = Aspose.Imaging.Image.Create(saveOptions, 100, 100))
                {
                    //Create and initialize an instance of Graphics class
                    Aspose.Imaging.Graphics graphic = new Aspose.Imaging.Graphics(image);
                    //Clear Graphics surface
                    graphic.Clear(Color.Yellow);

                    //Draw a dotted ellipse shape by specifying the Pen object having red color and a surrounding Rectangle
                    graphic.DrawEllipse(new Pen(Color.Red), new Rectangle(30, 10, 40, 80));

                    //Draw a continuous ellipse shape by specifying the Pen object having solid brush with blue color and a surrounding Rectangle
                    graphic.DrawEllipse(new Pen(new Aspose.Imaging.Brushes.SolidBrush(Color.Blue)), new Rectangle(10, 30, 80, 40));

                    // save all changes.
                    image.Save();
                }
                stream.Close();
            }
        }
    }
}