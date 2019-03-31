Imports System.Console
Module dow

    Sub Main()
        Dim day As Integer
        Write("Enter any number between o-6 : ")
        day = ReadLine()
        If day = 0 Then
            WriteLine("Sunday.")
        ElseIf day = 1 Then
            WriteLine("Monday.")
        ElseIf day = 2 Then
            WriteLine("Tuesday.")
        ElseIf day = 3 Then
            WriteLine("Wednesday.")
        ElseIf day = 4 Then
            WriteLine("Thursday.")
        ElseIf day = 5 Then
            WriteLine("Friday.")
        ElseIf day = 6 Then
            WriteLine("Saterday.")
        Else
            WriteLine("Wrong input.try again...")
        End If
        ReadKey()
    End Sub

End Module
