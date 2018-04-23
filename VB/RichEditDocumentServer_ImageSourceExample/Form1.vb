Imports DevExpress.Office.Services
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraRichEdit.API.Native
Imports DevExpress.XtraRichEdit.Export
Imports System
Imports DevExpress.XtraEditors

Namespace RichEditDocumentServer_ImageSourceExample
    Partial Public Class Form1
        Inherits XtraForm

        Private server As RichEditDocumentServer
        Public Sub New()
            InitializeComponent()
            server = New RichEditDocumentServer()
            server.CreateNewDocument()
            server.Document.Images.Append(DocumentImageSource.FromUri("http://www.devexpress.com/i/pagetitles/xtrarichedit.png", Nothing))
            embedImagesCheck.EditValue = True
            AddHandler server.ContentChanged, AddressOf richEditControl1_ContentChanged
        End Sub

        Private Sub richEditControl1_ContentChanged(ByVal sender As Object, ByVal e As EventArgs)
            ReloadHtml()
        End Sub

        Private Sub ReloadHtml()
'            #Region "#GetHtmlText"
            Dim exportOptions As New HtmlDocumentExporterOptions()
            exportOptions.EmbedImages = embedImagesCheck.Checked
            Dim sText As String = server.Document.GetHtmlText(server.Document.Range, New CustomUriProvider(), exportOptions)
'            #End Region ' #GetHtmlText
            memoEdit1.Text = sText
        End Sub

        #Region "#documentloaded"
        Private Sub server_DocumentLoaded(ByVal sender As Object, ByVal e As EventArgs)
            Dim service As IUriProviderService = server.GetService(Of IUriProviderService)()
            If service IsNot Nothing Then
                service.RegisterProvider(New CustomUriProvider())
            End If
        End Sub
        #End Region ' #documentloaded

        Private Sub embedImagesCheck_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles embedImagesCheck.CheckedChanged
            If embedImagesCheck.Checked Then
                lblText.Text = "CustomUriProvider is idle."
            Else
                lblText.Text = "The CustomUriProvider.CreateImageUri method is called to write the original image uri."
            End If
            ReloadHtml()
        End Sub

        Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
            server.SaveDocument("result.docx", DocumentFormat.OpenXml)
            System.Diagnostics.Process.Start("result.docx")
        End Sub
    End Class
End Namespace
