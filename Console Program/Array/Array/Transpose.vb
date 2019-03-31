Imports System.Console
Module Transpose_Mat

    Sub main()
        'VARIABLE DECLARATION
        Dim mat(3, 3), temp As Integer
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

        'METHOD FOR TRANSPOSE MATRIX
        For i = 1 To 3
            For j = 1 To i

                temp = mat(i, j)
                mat(i, j) = mat(j, i)
                mat(j, i) = temp

            Next
        Next
        'OUTPUT OPERATION TRANSPOSE MATRIX
        WriteLine(vbNewLine & "After Transpose Matrix are:" & vbNewLine)
        For i = 1 To 3
            For j = 1 To 3
                Write("  {0}", mat(i, j))
            Next
            WriteLine(vbNewLine)
        Next
        ReadKey()
    End Sub
End Module