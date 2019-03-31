Public Class frmStud
    Dim brc() As String = {"BE", "B.TECH", "ME", "M.TECH", "MBA", "MCA"} 'Dim brc As String()={.......}
    Dim submca1 As String() = {"Prg in C", "COA", "PCE", "MFCS", "IWT"}
    Dim submca2 As String() = {"CONA", "DS", "OS", "DBMS", "IMF"}

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'FOR BRANCH
        For i = 0 To 5
            cmbBranch.Items.Add(brc(i))
            'cmbBranch1.Items.Add(brc(i)) 
        Next
        'FOR MARKS
        For i = 0 To 100
            cmbMarks.Items.Add(i)
        Next
    End Sub

    Private Sub btnReset1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        cmbMarks.SelectedIndex = 0
        cmbSem.SelectedIndex = 0
        cmbSub.SelectedIndex = 0
        cmbBranch.SelectedIndex = 0
    End Sub

    Private Sub cmbBranch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBranch.SelectedIndexChanged
        'FOR SEMESTER
        'FOR BE & B.TECH
        cmbSem.Items.Clear()
        cmbSem.Items.Add("Semester")
        If cmbBranch.SelectedIndex = 1 Or cmbBranch.SelectedIndex = 2 Then
            'cmbSem.Items.Clear()
            For i = 1 To 8
                cmbSem.Items.Add(i & " Sem")
            Next
            'FOR ME & M.TECH
        ElseIf cmbBranch.SelectedIndex = 3 Or cmbBranch.SelectedIndex = 4 Or cmbBranch.SelectedIndex = 5 Then
            'cmbSem.Items.Clear()
            For i = 1 To 4
                cmbSem.Items.Add(i & " Sem")
            Next
            'FOR MCA
        ElseIf cmbBranch.SelectedIndex = 6 Then
            'cmbSem.Items.Clear()
            For i = 1 To 6
                cmbSem.Items.Add(i & "Sem")
            Next
        End If
    End Sub

    Private Sub cmbSem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSem.SelectedIndexChanged
        'FOR SUBJECT SELECTION
        cmbSub.Items.Clear()
        cmbSub.Items.Add("Subjects")
        'FOR MCA 1SEM SUBJECTS
        If cmbSem.SelectedIndex = 1 Then
            For i = 0 To 4
                cmbSub.Items.Add(submca1(i))
            Next
            'FOR MCA 2SEM SUBJECTS
        ElseIf cmbSem.SelectedIndex = 2 Then
            For i = 0 To 4
                cmbSub.Items.Add(submca2(i))
            Next
        End If
    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        'FOR DISPLAY MARKS DETAILS
        'If cmbSem.SelectedIndex = 1 Then
        'lblBranch.Text = cmbBranch.Text
        'lblSem.Text = cmbSem.Text
        'For i = 0 To 4
        'lblSub.Text = lblSub.Text & vbCr & cmbSub.Text
        'lblMarks.Text = lblMarks.Text & vbCr & cmbMarks.SelectedText(i)
        'Next
        'End If
    End Sub

    Private Sub cmbBranch1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBranch1.SelectedIndexChanged

    End Sub
End Class
