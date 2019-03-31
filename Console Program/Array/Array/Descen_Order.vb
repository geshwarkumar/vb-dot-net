Imports System.Console
Module Descen_Order
    Sub main()
        'VARIABLE DECLARATION
        Dim arr(10), temp As Integer
        'INPUT OPERATION
        WriteLine("Enter the 10 elements :")
        For i = 0 To 9
            arr(i) = ReadLine()
        Next
        'OUTPUT ARRARY ELEMENTS
        WriteLine("Given array elements are:" & vbNewLine)
        For i = 0 To 9
            Write(" {0}", arr(i))
        Next
        'METHOD FOR ARRANGE IN ASCENDING ORDER
        For i = 0 To 9
            For j = 0 To 9
                If (arr(j) < arr(j + 1)) Then
                    temp = arr(j + 1)
                    arr(j + 1) = arr(j)
                    arr(j) = temp
                End If
            Next
        Next
        'OUTPUT OPERATION
        WriteLine(vbNewLine & "Array in Ascending order:", vbNewLine)
        For i = 0 To 9
            Write(" {0}", arr(i))
        Next
        ReadKey()
    End Sub

End Module
