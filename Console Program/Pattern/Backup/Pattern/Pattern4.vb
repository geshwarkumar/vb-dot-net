'Print follwing pattern
'* * * * *
' * * * *
'  * * *
'   * *
'    *
Imports System.Console
Module Pattern4

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
            For j = 0 To i - 1
                Write(" ")
            Next
            For k = num To i
                Write("* ")
            Next
            WriteLine(" ")
        Next
        ReadKey()
    End Sub

End Module