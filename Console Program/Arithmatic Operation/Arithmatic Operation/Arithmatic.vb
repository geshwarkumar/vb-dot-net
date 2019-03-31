Imports System.Console
Module Arithmatic

    Sub Main()
        Dim num1, num2, res As Integer
        Write("Enter the first number")
        num1 = ReadLine()
        Write("Enter the second number")
        num2 = ReadLine()
        res = Add(num1, num2)
        WriteLine("Addition is : ", res)
        ReadKey()
    End Sub
    Function Add(ByVal x As Integer, ByVal y As Integer)
        Dim res As Integer
        res = x + y
        Return res
    End Function
End Module
