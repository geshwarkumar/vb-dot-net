Public Class DailogControl

    Private Sub btnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColor.Click
        dlgColor.ShowDialog()
        txtEdit.ForeColor = dlgColor.Color
        MsgBox(dlgColor.Color.ToString)
    End Sub

    Private Sub btnFont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFont.Click
        dlgFont.ShowDialog()
        txtEdit.Font = dlgFont.Font
        MsgBox(dlgFont.Font.ToString)
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Dim leng As Integer
        dlgOpen.Multiselect = True 'FOR MULTIPLE FILE SELECT AT A TIME
        dlgOpen.ShowDialog()
        txtEdit.Text = dlgOpen.FileName
        leng = dlgOpen.FileNames.Length
        Dim fname(leng), fnam() As String
        fname = dlgOpen.FileNames
        For i = 0 To fname.Length - 1
            fnam = fname(i).Split("\") 'FOR SPLIT/FILTER THE ONLY FILE NAME
            cmbFile.Items.Add(fnam(fnam.Length - 1))
        Next
        cmbFile.Text = cmbFile.Items(0)
    End Sub
End Class
