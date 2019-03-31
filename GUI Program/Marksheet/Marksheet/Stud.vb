Imports System.Console

Public Class Stud
    Dim msg, std_info, marks As String
    'Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
    Private Sub btnClear_Click()
        txtName.Text = ""
        txtBranch.Text = ""
        txtCona.Text = ""
        txtDbms.Text = ""
        txtDs.Text = ""
        txtImf.Text = ""
        txtOs.Text = ""
        'cmbSem.SelectedIndex = "0"
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        'MessageBox("Are you sure to exit this application ")
        msg = MsgBox("Are you sure to exit this application ", vbYesNo, "Exit Info")
        If msg = vbYes Then
            End
        End If
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Dim total As Integer
        Dim per As Double
        total = Val(txtCona.Text) + Val(txtDbms.Text) + Val(txtDs.Text) + Val(txtImf.Text) + Val(txtOs.Text)
        per = total / 5
        std_info = ("Name of the student : " & txtName.Text & vbCr & "Branch : " & txtBranch.Text & vbCr & "Semester : " & cmbSem.SelectedItem & vbCr & "Date Of Birth : " & dtpDOB.Text)
        marks = ("~~~~~Marks Details~~~~~" & vbCr & "Cona :" & vbTab & txtCona.Text & vbCr & "Os :" & vbTab & txtOs.Text & vbCr & "Ds :" & vbTab & txtDs.Text & vbCr & "Dbms :" & vbTab & txtDbms.Text & vbCr & "Imf : " & vbTab & txtImf.Text & vbCr & vbTab & vbTab & "Total : " & total & "  Percent : " & per & "%")
        MsgBox(std_info & vbCr & marks)
    End Sub
End Class
