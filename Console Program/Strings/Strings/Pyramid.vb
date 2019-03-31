Imports System.Console
Module Pyramid
    Sub main()
        'INITIALIZE VALUE
        Dim ch As Char() = {"H", "E", "L", "L", "O"}
        'Costruct string
        Dim str As String = New String(ch)
        'OUTPUT
        WriteLine("Given string is : {0}", str)
        'OPERATION & OUTPUT
        WriteLine("String Pyramid Are:" & vbNewLine)
        For i = 1 To 5
            For j = 0 To 5 - i
                Write(" ")
            Next j
            For k = 0 To i - 1
                Write("{0} ", ch(k))
            Next k
            WriteLine()
        Next
        ReadKey()
    End Sub
End Module
