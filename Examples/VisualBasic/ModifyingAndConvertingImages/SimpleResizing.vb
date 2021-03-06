﻿Imports Aspose.Imaging

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Imaging for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Imaging for .NET API from http://www.aspose.com/downloads, 
'Install it and then add its reference to this project. For any issues, questions or suggestions 
'Please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Imaging.Examples.VisualBasic.ModifyingAndConvertingImages
    Class SimpleResizing
        Public Shared Sub Run()
            ' ExStart:SimpleResizing
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_ModifyingAndConvertingImages()
            Using image__1 As Image = Image.Load(dataDir & Convert.ToString("aspose-logo.jpg"))
                image__1.Resize(300, 300)
                image__1.Save(dataDir & Convert.ToString("SimpleResizing_out.jpg"))
            End Using
            ' ExEnd:SimpleResizing
        End Sub
    End Class
End Namespace