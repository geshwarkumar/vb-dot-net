Imports System.Console
Module Add_Element
    Sub main()
        Dim mat1(3, 3), res As Integer
        'Dim iter, j As Integer
        'INPUT OPERATION
        WriteLine("Enter the element for matrix:")
        For i = 1 To 3
            For j = 1 To 3
                mat1(i, j) = ReadLine()
            Next
        Next
        'OUTPUT OPERATION
        WriteLine("Given Matrix is :" & vbNewLine)
        For i = 1 To 3
            For j = 1 To 3
                Write(" {0}", mat1(i, j))
            Next
            WriteLine(vbNewLine)
        Next
        res = 0
        'Addtion Operation
        For i = 1 To 3
            For j = 1 To 3
                res = mat1(i, j) + res
            Next
        Next
        'OUTPUT RESULT
        WriteLine("Result: Sum of all number in given matrix is:{0}", res)
       
        ReadKey()
    End Sub
End Module