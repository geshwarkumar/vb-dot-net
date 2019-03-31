Imports System.Console
Module Count
    Sub main()
        'VARIABLE DECLARATION
        Dim str As String
        Dim noc, nov, noco, nos, nol As Integer
        'INPUT STRING
        WriteLine("Enter the some paragraph :")
        str = ReadLine()
        'METHOD FOR COUNT VOWEL,CONSONENET,CHARACTER,SPACE,LINE
        For i = 1 To EOF(str)
            If str = EOF(str) Then
                noc = noc + 1
            ElseIf str(i) = "a" Or str(i) = "A" Or str(i) = "e" Or str(i) = "E" Or str(i) = "i" Or str(i) = "I" Or str(i) = "o" Or str(i) = "O" Or str(i) = "U" Or str(i) = "U" Then
                nov = nov + 1
            ElseIf str(i) = " " Then
                nos = nos + 1
            ElseIf str(i) = vbNewLine Then
                nol = nol + 1
            Else
                noco = noco + 1
            End If
        Next
        WriteLine("Total no of Character:{0}", noc)
        WriteLine("Total no of Vowel:{0}", nov)
        WriteLine("Total no of Consonant:{0}", noco)
        WriteLine("Total no of Line:{0}", nol)
        WriteLine("Total no of Space:{0}", nos)
        ReadKey()
    End Sub
End Module
