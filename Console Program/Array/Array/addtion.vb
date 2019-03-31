Imports System.Console
Module addtion
    Sub main()
        Dim mat1(3, 3), mat2(3, 3), res(3, 3) As Integer
        Dim i, j As Integer
        'INPUT OPERATION
        WriteLine("Enter the element for first matrix:")
        For i = 1 To 3
            For j = 1 To 3
                mat1(i, j) = ReadLine()
            Next
        Next
        WriteLine("Enter the element for second matrix:")
        For i = 1 To 3
            For j = 1 To 3
                mat2(i, j) = ReadLine()
            Next
        Next
        'OUTPUT OPERATION
        WriteLine(" Given Matrix are :" & vbCr & "Fisrt Matrix" & vbTab & vbTab & "Second Matrix" & vbNewLine)
        For i = 1 To 3
            For j = 1 To 3
                Write(" {0}", mat1(i, j))
            Next
            Write(vbTab & vbTab & vbTab)
            For j = 1 To 3
                Write(" {0}", mat2(i, j))
            Next
            WriteLine(vbNewLine)
        Next
        'Addtion Operation
        WriteLine("Result: Addition of given two matrix are:" & vbNewLine)
        For i = 1 To 3
            For j = 1 To 3
                res(i, j) = mat1(i, j) + mat2(i, j)
                Write(" {0}", res(i, j))
            Next
            WriteLine(vbNewLine)
        Next
        ReadKey()
    End Sub
End Module
