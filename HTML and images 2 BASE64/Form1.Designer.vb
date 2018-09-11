<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_imagesToBase64
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ofd_htmlFile = New System.Windows.Forms.OpenFileDialog()
        Me.fbd_images = New System.Windows.Forms.FolderBrowserDialog()
        Me.txt_htmlFile = New System.Windows.Forms.TextBox()
        Me.txt_folder = New System.Windows.Forms.TextBox()
        Me.btn_browseHTML = New System.Windows.Forms.Button()
        Me.btn_browseFolder = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ofd_htmlFile
        '
        '
        'txt_htmlFile
        '
        Me.txt_htmlFile.Location = New System.Drawing.Point(41, 50)
        Me.txt_htmlFile.Name = "txt_htmlFile"
        Me.txt_htmlFile.Size = New System.Drawing.Size(128, 20)
        Me.txt_htmlFile.TabIndex = 0
        '
        'txt_folder
        '
        Me.txt_folder.Location = New System.Drawing.Point(41, 100)
        Me.txt_folder.Name = "txt_folder"
        Me.txt_folder.Size = New System.Drawing.Size(128, 20)
        Me.txt_folder.TabIndex = 1
        '
        'btn_browseHTML
        '
        Me.btn_browseHTML.Location = New System.Drawing.Point(175, 46)
        Me.btn_browseHTML.Name = "btn_browseHTML"
        Me.btn_browseHTML.Size = New System.Drawing.Size(75, 23)
        Me.btn_browseHTML.TabIndex = 2
        Me.btn_browseHTML.Text = "Browse"
        Me.btn_browseHTML.UseVisualStyleBackColor = True
        '
        'btn_browseFolder
        '
        Me.btn_browseFolder.Location = New System.Drawing.Point(175, 96)
        Me.btn_browseFolder.Name = "btn_browseFolder"
        Me.btn_browseFolder.Size = New System.Drawing.Size(75, 23)
        Me.btn_browseFolder.TabIndex = 3
        Me.btn_browseFolder.Text = "Browse"
        Me.btn_browseFolder.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(41, 136)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(209, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Open converted file"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "HTML file"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Image folder"
        '
        'frm_imagesToBase64
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(301, 195)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_browseFolder)
        Me.Controls.Add(Me.btn_browseHTML)
        Me.Controls.Add(Me.txt_folder)
        Me.Controls.Add(Me.txt_htmlFile)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_imagesToBase64"
        Me.Text = "HTML and Images to HTML and Base64"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ofd_htmlFile As OpenFileDialog
    Friend WithEvents fbd_images As FolderBrowserDialog
    Friend WithEvents txt_htmlFile As TextBox
    Friend WithEvents txt_folder As TextBox
    Friend WithEvents btn_browseHTML As Button
    Friend WithEvents btn_browseFolder As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
