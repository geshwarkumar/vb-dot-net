Imports System.Console
Module _2DArr

    Sub Main()
        Dim arr(2, 2), iter, j, x As Integer
        x = 10
        'for input operation
        For iter = 1 To 2
            For j = 1 To 2
                arr(iter, j) = x
                x = x + 20
            Next
        Next
        'for output
        WriteLine("The given Matrix elements are :" & vbNewLine)
        For iter = 1 To 2
            For j = 1 To 2
                Write(" {0}", arr(iter, j))
            Next
            WriteLine(vbNewLine)
        Next
        ReadKey()
    End Sub

End Module