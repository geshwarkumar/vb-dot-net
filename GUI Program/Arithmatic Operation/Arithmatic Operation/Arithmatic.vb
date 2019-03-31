Public Class Form1
    Dim msg As String

    Private Sub addbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addbtn.Click
        msg = ("First value is:" & txtfirst.Text & vbCr & "Second value is:" & txtsec.Text & vbCr & "Both Addtion value is :" & Val(txtfirst.Text) + Val(txtsec.Text) & " ")
        MsgBox(msg)
    End Sub

    Private Sub endbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles endbtn.Click
        'If MsgBox("Are you sure for closeing this window", MsgBoxStyle.YesNo, "close warning") = MsgBoxResult.Yes Then
        'Me.Close()
        '  Else
        'MsgBox("To be continue your calculation....", )
        If MessageBox.Show("Are you sure want to close this window", _
           "Close window", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Me.Close()
        Else
            MessageBox.Show("To be continue your calculation")
        End If
    End Sub

    Private Sub clrbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clrbtn.Click
        txtfirst.Text = ""
        txtsec.Text = ""
    End Sub

    Private Sub subbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subbtn.Click
        msg = ("First value is:" & txtfirst.Text & vbCr & "Second value is:" & txtsec.Text & vbCr & "Both Substraction value is :" & Val(txtfirst.Text) - Val(txtsec.Text) & " ")
        MsgBox(msg)
    End Sub

    Private Sub divbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divbtn.Click
        msg = ("First value is:" & txtfirst.Text & vbCr & "Second value is:" & txtsec.Text & vbCr & "Both Division value is :" & Val(txtfirst.Text) / Val(txtsec.Text) & " ")
        MsgBox(msg)
    End Sub

    Private Sub mulbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mulbtn.Click
        msg = ("First value is:" & txtfirst.Text & vbCr & "Second value is:" & txtsec.Text & vbCr & "Both Multiplication value is :" & Val(txtfirst.Text) * Val(txtsec.Text) & " ")
        MsgBox(msg)
    End Sub
End Class
