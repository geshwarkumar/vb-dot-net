Imports System.Data.OleDb

Public Class Form1
    Dim ds As New DataSet
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Table As String = "Authors"
        Dim query As String = "SELECT * FROM " & Table
        Dim MDBConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\amit\VB.Net_Project\DatabaseOLEDB\Authors.mdb;"

        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnString)
        cnn.Open()

        Dim cmd As New OleDbCommand(query, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, Table)
        cnn.Close()

        Dim dt As DataTable = ds.Tables(Table)
        Dim row As DataRow
        For Each row In dt.Rows
            cmbAID.Items.Add(row(0))
            cmbName.Items.Add(row(1))
            cmbYear.Items.Add(row(2))
        Next

        'Dim i As Integer
        'For i = 0 To ds.Tables(Table).Rows.Count - 1
        '    cmbAID.Items.Add(ds.Tables(Table).Rows(i).Item(0))
        '    cmbAID.Items.Add(ds.Tables(Table).Rows(i).Item("AU_ID"))
        '    cmbName.Items.Add(ds.Tables(Table).Rows(i).Item(1))
        '    cmbName.Items.Add(ds.Tables(Table).Rows(i).Item("Author"))
        '    cmbYear.Items.Add(ds.Tables(Table).Rows(i).Item(2))
        '    cmbYear.Items.Add(ds.Tables(Table).Rows(i).Item("YearBorn"))
        'Next

        cmbAID.Text = cmbAID.Items(0)
        cmbName.Text = cmbName.Items(0)
        cmbYear.Text = cmbYear.Items(2)
    End Sub

    ' Insert a record
    'Dim cb As New OleDb.OleDbCommandBuilder(da)
    'Dim dsNewRow As DataRow

    'dsNewRow = ds.Tables("AddressBook").NewRow()

    'dsNewRow.Item("FirstName") = txtFirstName.Text
    'dsNewRow.Item("Surname") = txtSurname.Text

    'ds.Tables("AddressBook").Rows.Add(dsNewRow)

    'da.Update(ds, "AddressBook")

    'MessageBox.Show("New Record added to the Database")

    ' Delete a Record
    'ds.Tables("AddressBook").Rows(inc).Delete()
    'da.Update(ds, "AddressBook")

    'Public Sub creates()
    '   cmd.CommandText = "INSERT INTO table1(Neyms) VALUES('" + var1 + "')"
    '  cmd.ExecuteNonQuery()

    'End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim Table As String = "Authors"
        Dim query As String = "SELECT * FROM " & Table
        Dim MDBConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\amit\VB.Net_Project\DatabaseOLEDB\Authors.mdb;"

        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnString)
        cnn.Open()

        Dim cmd As New OleDbCommand(query, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        
        ' Insert a record
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dsNewRow As DataRow

        dsNewRow = ds.Tables(Table).NewRow()

        dsNewRow.Item("AU_ID") = txtAUID.Text
        dsNewRow.Item("Author") = txtAuthorName.Text
        dsNewRow.Item("YearBorn") = Val(txtYearBorn.Text)

        ds.Tables(Table).Rows.Add(dsNewRow)

        da.Update(ds, Table)

        MessageBox.Show("New Record added to the Database")


        'query = "INSERT INTO table1(Neyms) VALUES('" + var1 + "')"
        'Dim cmd As New OleDbCommand(query, cnn)

    End Sub
End Class
