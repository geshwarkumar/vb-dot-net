Imports System.Data.OleDb
Public Class Login1
    Dim ds As New DataSet
    Private Sub Login1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim query As String = "SELECT User,Pass FROM login"

        Dim constr As String = "Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = D:\MCAII\STLAB\GUI\Connectivity\login.mdb"
        Dim cnn As OleDbConnection = New OleDbConnection(constr)
        cnn.Open()

        Dim cmd As New OleDbCommand(query, cnn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        Dim user, pass As String

        user = txtUser.Text
        pass = txtPass.Text

        Dim username, password As String
        username = ""
        password = ""

        While dr.Read
            username = dr("user").ToString
            password = dr("pass").ToString
            'Continue While
        End While
        cnn.Close()
        'checking the result
        If txtUser.Text = username And txtPass.Text = password Then
            MsgBox("Welcome ")
        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid Login")
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

    End Sub
End Class