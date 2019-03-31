Imports System.Data.OleDb

Public Class Connectivity_Form
    Dim ds As New DataSet
    Private Sub Connectivity_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Table As String = "Authors"
        Dim query As String = "SELECT * FROM " & Table
        'ONLY SHOW WHICH DATA WILL STARTS ALPHBATE A AUTHORS NAME
        ' Dim query As String = "SELECT * FROM Authors where author like'a%'"

        Dim MDBConnString As String = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = D:\Nupendra\Connectivity\Authors.mdb"

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
            comaid.Items.Add(row(0))
            comaname.Items.Add(row(1))
            comayear.Items.Add(row(2))
        Next

        'For i = 0 To ds.Tables(Table).Rows.Count - 1
        'cmbAID.Items.Add(ds.Tables(Table).Rows(i).items(0))
        'cmbAID.Items.Add(ds.Tables(Table).Rows(i).items("Au_ID"))
        'cmbAName.Items.Add(ds.Tables(Table).Rows(i).items(1))
        'cmbAName.Items.Add(ds.Tables(Table).Rows(i).items("Author"))
        'cmbABYear.Items.Add(ds.Tables(Table).Rows(i).items(2))
        'cmbABYear.Items.Add(ds.Tables(Table).Rows(i).items("YearBorn"))
        'Next

        comaid.Text = comaid.Items(0)
        comaname.Text = comaname.Items(0)
        comayear.Text = comayear.Items(0)

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click

    End Sub
End Class
