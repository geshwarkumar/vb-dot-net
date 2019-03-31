'Print follwing pattern
'*****
' ****
'  ***
'   **
'    *
Imports System.Console
Module Pattern3

    Sub Main()
        'Variable declaration
        Dim num As Integer
        'INPUT LINE
        Write("How many terms : ")
        num = ReadLine()
        'OUTPUT OPERATION
        WriteLine("Pattern are :")
        'METHOD FOR PRINT PATTERN
        For i = 0 To num
            For j = i To num
                Write(" ")
            Next
            For k = 1 To i
                Write("*")
            Next
            WriteLine(" ")
        Next
        ReadKey()
    End Sub

End Module