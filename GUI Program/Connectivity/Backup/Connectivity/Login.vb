Imports System.Data.OleDb
Public Class Login
    Dim ds As New DataSet
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim query As String = "SELECT User,Pass FROM login"

        Dim constr As String = "Provider = Microsoft.Jet.OLEDB.4.0 ; Data Source = D:\MCAII\STLAB\GUI\Connectivity\login.mdb"
        Dim cnn As OleDbConnection = New OleDbConnection(constr)
        cnn.Open()

        Dim cmd As New OleDbCommand(query, cnn)
        cnn.Close()

        Dim user, pass As String

        user = txtUser.Text
        pass = txtPass.Text

        Dim dt As DataTable = ds.Tables("login")
        Dim row As DataRow

        For Each row In dt.Rows
            If user = row(0) And pass = row(1) Then
                MsgBox("Login Successfull")
                Exit
            End If
        Next

    End Sub
End Class