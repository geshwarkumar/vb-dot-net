Imports DevExpress.XtraReports.UI
Imports System.Data.SqlClient
Public Class rpt_UserInfo
    Public Sub showUserInfo()

        Dim query As String = String.Format("SELECT [Fullname],[EmailID],[Contact] FROM [db_ConnectivityDemo].[dbo].[tbl_UserInfo]")
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        Dim connection As New SqlConnection("Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=db_ConnectivityDemo;Integrated Security=True")
        connection.Open()
        Try
            da = New SqlDataAdapter(query, connection)
            da.Fill(ds)
            Me.DataSource = ds
            Me.DataMember = ds.Tables(0).TableName
            ShowPreview()
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
            ds = Nothing
        Finally
            connection.Close()
            connection.Dispose()
            connection = Nothing
        End Try

    End Sub
End Class