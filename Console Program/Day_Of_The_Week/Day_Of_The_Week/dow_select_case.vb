Imports System.Console
Module dow_sel_case

    Sub Main()
        Dim day As Integer
        Write("Enter any number between o-6 : ")
        day = ReadLine()
        Select Case day
            Case 0 : WriteLine("Sunday.")
            Case 1 : WriteLine("Monday.")
            Case 2 : WriteLine("Tuesday.")
            Case 3 : WriteLine("Wednesday.")
            Case 4 : WriteLine("Thursday.")
            Case 5 : WriteLine("Friday.")
            Case 6 : WriteLine("Saturday.")
            Case Else : WriteLine("Wrong input.try again...")
        End Select
        ReadKey()
    End Sub

End Module
