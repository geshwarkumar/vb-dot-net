Imports System.Console
Module Constructor

    Sub Main()
        Dim greetings As String
        'ASSIGNING VALUE
        Dim letters As Char() = {"H", "E", "L", "L", "O"}
        'OPERATION
        greetings = New String(letters)
        'OUTPUT
        WriteLine("Greetings : {0}", greetings)
        ReadLine()
    End Sub

End Module
