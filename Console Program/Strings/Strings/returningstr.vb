Imports System.Console
Module Returningstr

    Sub Main()
        'ASSIGNING VALUE
        Dim sarr() As String = {"Hello", "GK", "Your", "Wel-Come", "..."}
        Dim msg As String = String.Join(" ", sarr)
        'OUTPUT
        WriteLine("Message : {0}", msg)
        ReadLine()
    End Sub

End Module
