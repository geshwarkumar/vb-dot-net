Imports System.Data.OleDb
Public Class OLEDB
    Dim ds As New DataSet

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Table As String = "Authors"
        Dim query As String = "SELECT * FROM " & Table
        'For display name start with A'Dim query As String = "SELECT * FROM Authors WHERE Author LIKE 'A%'"
        Dim MDBConnString As String = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = D:\MCAII\STLAB\GUI\Connectivity\Authors.mdb"

        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnString)
        cnn.Open()

        Dim cmd As New OleDbCommand(query, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, Table)
        cnn.Close()

        Dim dt As DataTable = ds.Tables(Table)
        Dim row As DataRow
        'FOR ADD DATA INTO THE COMBOBOX FROM DATABASE
        For Each row In dt.Rows
            cmbAID.Items.Add(row(0))
            cmbAName.Items.Add(row(1))
            cmbABYear.Items.Add(row(2))
        Next

        'For i = 0 To ds.Tables(Table).Rows.Count - 1
        'cmbAID.Items.Add(ds.Tables(Table).Rows(i).items(0))
        'cmbAID.Items.Add(ds.Tables(Table).Rows(i).items("Au_ID"))
        'cmbAName.Items.Add(ds.Tables(Table).Rows(i).items(1))
        'cmbAName.Items.Add(ds.Tables(Table).Rows(i).items("Author"))
        'cmbABYear.Items.Add(ds.Tables(Table).Rows(i).items(2))
        'cmbABYear.Items.Add(ds.Tables(Table).Rows(i).items("YearBorn"))
        'Next

        'cmbAID.Text = cmbAID.Items(0)
        'cmbAName.Text = cmbAName.Items(0)
        'cmbABYear.Text = cmbABYear.Items(0)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

    End Sub
End Class
