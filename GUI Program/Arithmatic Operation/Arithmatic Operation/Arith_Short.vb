Public Class Arith_Short
    Dim a, b As Integer
    Dim res As Double
    Dim msg As String

    Private Sub addbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addbtn.Click
        msg = ("Addtion of two number is: " & Val(txtfirst.Text) + Val(txtsec.Text))
        MsgBox(msg)
    End Sub
End Class