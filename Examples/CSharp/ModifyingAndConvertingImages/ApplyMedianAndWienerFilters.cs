﻿using Aspose.Imaging.ImageFilters.FilterOptions;
using Aspose.Imaging;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.Imaging.Examples.CSharp.ModifyingAndConvertingImages
{
    class ApplyMedianAndWienerFilters
    {
        public static void Run()
        {
            // To get proper output please apply a valid Aspose.Imaging License. You can purchase full license or get 30 day temporary license from http:// Www.aspose.com/purchase/default.aspx.");
            // ExStart:ApplyMedianAndWienerFilters
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ModifyingAndConvertingImages();

            // Load the noisy image 
            using (Image image = Image.Load(dataDir + "asposelogo.gif"))
            {
                // caste the image into RasterImage
                RasterImage rasterImage = image as RasterImage;

                if (rasterImage == null)
                {
                    return;
                }

                // Create an instance of MedianFilterOptions class and set the size.
                MedianFilterOptions options = new MedianFilterOptions(4);

                // Apply MedianFilterOptions filter to RasterImage object.
                rasterImage.Filter(image.Bounds, options);

                // Save the resultant image
                image.Save(dataDir + "median_test_denoise_out.gif");
            }
        }
    } // ExEnd:ApplyMedianAndWienerFilters
}