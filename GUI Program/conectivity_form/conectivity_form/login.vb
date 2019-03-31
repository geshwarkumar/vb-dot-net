Imports System.Data.OleDb
Public Class Login_form
    Dim ds As New DataSet
    Private Sub btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim table As String = "login"
        Dim query As String = "SELECT user,pass FROM login"

        Dim constr As String = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = E:\conectivity_form\login.mdb"
        Dim cnn As OleDbConnection = New OleDbConnection(constr)

        cnn.Open()

        Dim cmd As New OleDbCommand(query, cnn)

        Dim dr As OleDbDataReader = cmd.ExecuteReader


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
        If txtuser.Text = username And txtpass.Text = password Then
            MsgBox("Welcome ")
        Else
            MsgBox("Sorry, username or password not found", MsgBoxStyle.OkOnly, "Invalid Login")
        End If



        Dim dt As DataTable = ds.Tables(table)


        'cnn.Close()
    End Sub

    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        End
    End Sub
End Class