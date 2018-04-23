Namespace RichEditDocumentServer_ImageSourceExample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.lblText = New DevExpress.XtraEditors.LabelControl()
            Me.embedImagesCheck = New DevExpress.XtraEditors.CheckEdit()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            DirectCast(Me.embedImagesCheck.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.lblText)
            Me.panelControl1.Controls.Add(Me.embedImagesCheck)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(784, 42)
            Me.panelControl1.TabIndex = 3
            ' 
            ' lblText
            ' 
            Me.lblText.Appearance.BackColor = System.Drawing.SystemColors.Info
            Me.lblText.Appearance.Options.UseBackColor = True
            Me.lblText.Appearance.Options.UseTextOptions = True
            Me.lblText.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lblText.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lblText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lblText.Location = New System.Drawing.Point(330, 5)
            Me.lblText.Name = "lblText"
            Me.lblText.Size = New System.Drawing.Size(442, 31)
            Me.lblText.TabIndex = 1
            Me.lblText.Text = "labelControl1"
            ' 
            ' embedImagesCheck
            ' 
            Me.embedImagesCheck.Location = New System.Drawing.Point(13, 13)
            Me.embedImagesCheck.Name = "embedImagesCheck"
            Me.embedImagesCheck.Properties.Caption = "EmbedImagesInHTML"
            Me.embedImagesCheck.Size = New System.Drawing.Size(127, 19)
            Me.embedImagesCheck.TabIndex = 0
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Top
            Me.memoEdit1.Location = New System.Drawing.Point(0, 42)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Properties.ReadOnly = True
            Me.memoEdit1.Size = New System.Drawing.Size(784, 398)
            Me.memoEdit1.TabIndex = 4
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.simpleButton1.Location = New System.Drawing.Point(0, 500)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(784, 61)
            Me.simpleButton1.TabIndex = 5
            Me.simpleButton1.Text = "Generate Document"
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 561)
            Me.Controls.Add(Me.simpleButton1)
            Me.Controls.Add(Me.memoEdit1)
            Me.Controls.Add(Me.panelControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
            Me.Name = "Form1"
            Me.ShowIcon = False
            DirectCast(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            DirectCast(Me.embedImagesCheck.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private panelControl1 As DevExpress.XtraEditors.PanelControl
        Private WithEvents embedImagesCheck As DevExpress.XtraEditors.CheckEdit
        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
        Private lblText As DevExpress.XtraEditors.LabelControl
        Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

