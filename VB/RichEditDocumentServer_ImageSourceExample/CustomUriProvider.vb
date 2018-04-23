#Region "#usings"
Imports DevExpress.Office.Services
Imports DevExpress.Office.Utils
Imports System
#End Region ' #usings

Namespace RichEditDocumentServer_ImageSourceExample
#Region "#customuriprovider"
    Public Class CustomUriProvider
        Implements IUriProvider

        Private Function IUriProvider_CreateImageUri(rootUri As String, image As OfficeImage, relativeUri As String) As String Implements IUriProvider.CreateImageUri
            Return image.Uri
        End Function

        Private Function IUriProvider_CreateCssUri(rootUri As String, styleText As String, relativeUri As String) As String Implements IUriProvider.CreateCssUri
            Return String.Empty
        End Function
    End Class
#End Region ' #customuriprovider    
End Namespace
