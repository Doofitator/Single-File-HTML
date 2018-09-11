Public Class frm_imagesToBase64
    Dim inlineimages As String() = Nothing
    Private Sub modifyHTML()
        Dim modifiedfile As String = Nothing
        Dim tmpFile As String = System.IO.Path.GetTempFileName
        If System.IO.File.Exists(tmpFile) Then
            If Not System.IO.File.Exists(txt_htmlFile.Text) Then
                MsgBox("Fatal error: No file path selected!", vbAbort, "ERROR")
                End
            End If
            Dim fileinfo As New System.IO.FileInfo(txt_htmlFile.Text)
            Dim HTML As String = My.Computer.FileSystem.ReadAllText(fileinfo.FullName)
            If fbd_images.SelectedPath = "" Then
                If txt_folder.Text = "" Then
                    MsgBox("Fatal error: No image path selected!", vbAbort, "ERROR")
                    End
                Else
                    inlineimages = System.IO.Directory.GetFiles(txt_folder.Text)
                End If
            Else
                inlineimages = System.IO.Directory.GetFiles(fbd_images.SelectedPath)
            End If

            For Each item In inlineimages
                If item.EndsWith(".png") Or item.EndsWith(".jpg") Or item.EndsWith(".bmp") Then
                    Dim tmpBase64 As String = convertImageToBase64(item)
                    Dim fileinfo2 As New System.IO.FileInfo(item)
                    Dim newImageText As String = "cid:" & fileinfo2.Name
                    Dim directoryinfo As System.IO.DirectoryInfo = New System.IO.DirectoryInfo(fileinfo2.DirectoryName)
                    HTML = HTML.Replace("./" & directoryinfo.Name & "/" & fileinfo2.Name, tmpBase64)
                    HTML = HTML.Replace(fileinfo2.Name, tmpBase64)
                End If
            Next

            Dim objWriter As New System.IO.StreamWriter(tmpFile)
            objWriter.Write(HTML)
            objWriter.Close()
            modifiedfile = tmpFile
        Else
            MsgBox("Fatal error: Attempt to write to temporary file " & tmpFile & " failed.", vbAbort, "ALERT")
            End
        End If
        Process.Start(tmpFile)
    End Sub

    Private Function convertImageToBase64(ByVal imagePath As String)
        Return "data:image/gif;base64," & Convert.ToBase64String(System.IO.File.ReadAllBytes(imagePath))
    End Function


    Private Sub btn_browseHTML_Click(sender As Object, e As EventArgs) Handles btn_browseHTML.Click
        ofd_htmlFile.ShowDialog()
    End Sub

    Private Sub btn_browseFolder_Click(sender As Object, e As EventArgs) Handles btn_browseFolder.Click
        fbd_images.ShowDialog()
    End Sub

    Private Sub ofd_htmlFile_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofd_htmlFile.FileOk
        txt_htmlFile.Text = ofd_htmlFile.FileName
        Dim fileinfo As New System.IO.FileInfo(txt_htmlFile.Text)
        Dim dirinfo As New System.IO.DirectoryInfo(fileinfo.Directory.ToString)

        Dim folders As System.IO.DirectoryInfo() = dirinfo.GetDirectories()
        For Each folder In folders
            If folder.FullName = fileinfo.DirectoryName & "\" & System.IO.Path.GetFileNameWithoutExtension(fileinfo.FullName) & "_files" Then
                txt_folder.Text = folder.FullName
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        modifyHTML()
    End Sub
End Class
