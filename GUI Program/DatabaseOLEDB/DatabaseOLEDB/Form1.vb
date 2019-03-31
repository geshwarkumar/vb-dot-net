Imports System.Data.OleDb

Public Class Form1
    Dim ds As New DataSet
    Dim i, nRecord As Integer
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Table As String = "Authors"
        Dim query As String = "SELECT * FROM " & Table
        'FOR NEW VERSION MS ACCESS (/.ACCDB)"Provider=Microsoft.ACE.OLEDB.12.0;
        Dim MDBConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\MCAII\STLAB\GUI\DatabaseOLEDB\Authors.mdb;"

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
        Next
        i = 0
        nRecord = ds.Tables("Authors").Rows.Count

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
        Dim MDBConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\MCAII\STLAB\GUI\DatabaseOLEDB\Authors.mdb;"

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

        Me.Refresh()
        cmbAID.Refresh()


        'query = "INSERT INTO table1(Neyms) VALUES('" + var1 + "')"
        'Dim cmd As New OleDbCommand(query, cnn)

    End Sub

    Private Sub cmbAID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAID.SelectedIndexChanged
        Dim Table As String = "Authors"
        Dim query As String = "SELECT Author,YearBorn FROM " & Table & " WHERE Au_ID = " & cmbAID.Text
        Dim MDBConnString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\MCAII\STLAB\GUI\DatabaseOLEDB\Authors.mdb;"

        Dim cnn As OleDbConnection = New OleDbConnection(MDBConnString)
        cnn.Open()

        Dim cmd As New OleDbCommand(query, cnn)
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(ds, Table)
        cnn.Close()

        Dim dt As DataTable = ds.Tables(Table)
        Dim row As DataRow
        For Each row In dt.Rows
            txtAName.Text = row(1)
            txtBYear.Text = row(2)
        Next

        'txtAName.Text = dt.Rows.Item(1).ToString
        'txtBYear.Text = dt.Rows.Item(1).ToString

    End Sub

    Private Sub btnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirst.Click
        i = 0
        txtAUID.Text = ds.Tables("Authors").Rows(i).Item(0).ToString
        txtAuthorName.Text = ds.Tables("Authors").Rows(i).Item(1).ToString
        txtYearBorn.Text = ds.Tables("Authors").Rows(i).Item(2).ToString
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        i = i - 1
        If i >= 0 Then
            txtAUID.Text = ds.Tables("Authors").Rows(i).Item(0).ToString
            txtAuthorName.Text = ds.Tables("Authors").Rows(i).Item(1).ToString
            txtYearBorn.Text = ds.Tables("Authors").Rows(i).Item(2).ToString
        Else
            i = 0
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        i = i + 1
        If i <= nRecord - 1 Then
            txtAUID.Text = ds.Tables("Authors").Rows(i).Item(0).ToString
            txtAuthorName.Text = ds.Tables("Authors").Rows(i).Item(1).ToString
            txtYearBorn.Text = ds.Tables("Authors").Rows(i).Item(2).ToString
        Else
            i = nRecord - 1
        End If
    End Sub

    Private Sub btnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLast.Click
        i = nRecord - 1

        txtAUID.Text = ds.Tables("Authors").Rows(i).Item(0).ToString
        txtAuthorName.Text = ds.Tables("Authors").Rows(i).Item(1).ToString
        txtYearBorn.Text = ds.Tables("Authors").Rows(i).Item(2).ToString
       
    End Sub
End Class
