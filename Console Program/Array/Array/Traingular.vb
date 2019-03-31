Imports System.Console
Module Traingular_Mat

    Sub main()
        'VARIABLE DECLARATION
        Dim mat(3, 3) As Integer
        'INPUT OPERATION
        WriteLine("Enter the element for matrix:")
        For i = 1 To 3
            For j = 1 To 3
                mat(i, j) = ReadLine()
            Next
        Next
        'OUTPUT OPERATION
        WriteLine("Given Matrix is :" & vbNewLine)
        For i = 1 To 3
            For j = 1 To 3
                Write("  {0}", mat(i, j))
            Next
            WriteLine(vbNewLine)
        Next

        'OUTPUT UPPER TRAINGULAR MATRIX
        WriteLine(vbNewLine & "Upper Traingular Matrix are:" & vbNewLine)
        For i = 1 To 3
            For j = 1 To 3
                If i <= j Then
                    Write(" {0}", mat(i, j))
                Else
                    Write("  ")
                End If
            Next
            WriteLine(vbNewLine)
        Next
        'OUTPUT LOWER TRAINGULER MATRIX
        WriteLine(vbNewLine & "Lower Traingular Matrix are:" & vbNewLine)
        For i = 1 To 3
            For j = 1 To 3
                If i >= j Then
                    Write(" {0}", mat(i, j))
                Else
                    Write("  ")
                End If
            Next
            WriteLine(vbNewLine)
        Next
        ReadKey()
    End Sub
End Module