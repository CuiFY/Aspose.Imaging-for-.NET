﻿Imports Aspose.Imaging.FileFormats.Tiff.Enums
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class TiffOptionsConfiguration
        Public Shared Sub Run()
            ' ExStart:TiffOptionsConfiguration           
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an image through file path location or stream
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("SampleTiff1.tiff"))
                ' Create an instance of TiffOptions while specifying desired format Passsing TiffExpectedFormat.TiffJpegRGB will set the compression to Jpeg and BitsPerPixel according to the RGB color space.
                Dim options As New TiffOptions(TiffExpectedFormat.TiffJpegRgb)
                image__1.Save(dataDir & Convert.ToString("SampleTiff_out.tiff"), options)
            End Using
            ' ExEnd:TiffOptionsConfiguration
        End Sub
    End Class
End Namespace