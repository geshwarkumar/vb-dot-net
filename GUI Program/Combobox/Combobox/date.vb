Public Class Form1

    Dim mm() As String = {"JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JULY", "AUG", "SEP", "OCT", "NOV", "DEC"}
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'FOR DATE
        For i = 1 To 31
            cmbDD.Items.Add(i)
        Next
        'FOR MONTH
        For i = 0 To 11
            cmbMM.Items.Add(mm(i)) 'OR FOR DIGIT USE =>loop 1 to 12: cmbMM.Items.Add(i)
        Next
        'FOR YEAR
        For i = 1950 To 2020
            cmbYY.Items.Add(i)
        Next
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        'FOR SET BY DEFAULT VALUE
        cmbDD.SelectedIndex = 0
        cmbMM.SelectedIndex = 0
        cmbYY.SelectedIndex = 0
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        'FOR VALIDATION
        If (cmbDD.SelectedIndex = 0 And cmbMM.SelectedIndex = 0 And cmbYY.SelectedIndex = 0) Then
            MsgBox("You not select date ... Please select proper date...")
            'FOR DATE
        ElseIf cmbDD.SelectedIndex = 0 Then 'OR cmbDD.Text = "Date"
            MsgBox("Please select date...")
            cmbDD.Focus()
            'FOR MONTH
        ElseIf cmbMM.SelectedIndex = 0 Then 'OR cmbMM.Text = "Month"
            MsgBox("Please select month...")
            cmbMM.Focus()
            'FOR YEAR
        ElseIf cmbYY.SelectedIndex = 0 Then 'OR cmbYY.Text = "Year"
            MsgBox("Please select Year...")
            cmbYY.Focus()
        Else
            'FOR DISPLAY DATE
            MsgBox("Entered date is :: " & cmbDD.Text & "/" & cmbMM.Text & "/" & cmbYY.Text)
        End If
    End Sub
End Class
