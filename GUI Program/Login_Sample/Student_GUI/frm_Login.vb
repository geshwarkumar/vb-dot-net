Public Class Login

    

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If txtUser.Text = "user" And txtPass.Text = "pass" Then
            MsgBox("Successfuly login" & vbNewLine & "Your...Welcome...")
        Else
            MsgBox("UnSuccessfuly login" & vbNewLine & "Please enter right username or password...")
            txtPass.Text = ""
            txtUser.Text = ""
            txtUser.TabIndex = 0
        End If
    End Sub

    Private Sub btnReset_Click() Handles btnReset.Click
        txtUser.Text = ""
        txtPass.Text = ""
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        End
    End Sub
End Class
