using DevExpress.Office.Services;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.Export;
using System;
using DevExpress.XtraEditors;

namespace RichEditDocumentServer_ImageSourceExample
{
    public partial class Form1 : XtraForm
    {
        RichEditDocumentServer server;
        public Form1()
        {
            InitializeComponent();
            server = new RichEditDocumentServer();
            server.CreateNewDocument();
            server.Document.Images.Append
                (DocumentImageSource.FromUri("http://www.devexpress.com/i/pagetitles/xtrarichedit.png", null));
            embedImagesCheck.EditValue = true;
            server.ContentChanged += new EventHandler(richEditControl1_ContentChanged);
        }

        private void richEditControl1_ContentChanged(object sender, EventArgs e)
        {
            ReloadHtml();
        }

        private void ReloadHtml()
        {
            #region #GetHtmlText
            HtmlDocumentExporterOptions exportOptions = new HtmlDocumentExporterOptions();
            exportOptions.EmbedImages = embedImagesCheck.Checked;
            string sText = server.Document.GetHtmlText(server.Document.Range, new CustomUriProvider(), exportOptions);
            #endregion #GetHtmlText
            memoEdit1.Text = sText;
        }

        #region #documentloaded
        private void server_DocumentLoaded(object sender, EventArgs e)
        {
            IUriProviderService service = server.GetService<IUriProviderService>();
            if (service != null)
            {
                service.RegisterProvider(new CustomUriProvider());
            }
        }
        #endregion #documentloaded

        private void embedImagesCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (embedImagesCheck.Checked)
                lblText.Text = "CustomUriProvider is idle.";
            else
                lblText.Text = "The CustomUriProvider.CreateImageUri method is called to write the original image uri.";
            ReloadHtml();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            server.SaveDocument("result.docx", DocumentFormat.OpenXml);
            System.Diagnostics.Process.Start("result.docx");
        }
    }
}
