Imports System.Console
Module _1DArr

    Sub Main()
        Dim arr(5), iter, x As Integer
        x = 10
        'for input operation
        For iter = 1 To 5
            arr(iter) = x
            x = x + 20
        Next
        'for output
        WriteLine("Given numbers are :")
        For iter = 1 To 5
            Write(" {0}", arr(iter))
        Next
        ReadKey()
    End Sub

End Module
