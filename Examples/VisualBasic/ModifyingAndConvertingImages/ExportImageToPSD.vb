Imports Aspose.Imaging.FileFormats.Psd
Imports Aspose.Imaging.ImageOptions

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Public Class ExportImageToPSD
        Public Shared Sub Run()
            ' ExStart:ExportImageToPSD
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()

            ' Load an existing image
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("sample.bmp"))
                ' Create an instance of PsdOptions and set it�s various properties and Save image to disk in PSD format
                Dim psdOptions As New PsdOptions()
                psdOptions.ColorMode = ColorModes.Rgb
                psdOptions.CompressionMethod = CompressionMethod.Raw
                psdOptions.Version = 4
                image__1.Save(dataDir & Convert.ToString("ExportImageToPSD_output.psd"), psdOptions)
            End Using
            ' ExEnd:ExportImageToPSD
        End Sub
    End Class
End Namespace