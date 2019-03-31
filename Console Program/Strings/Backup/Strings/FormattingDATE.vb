Imports System.Console
Module FormattingDATE
    Sub main()
        Dim waiting As DateTime = New DateTime(2016, 1, 28, 12, 30, 5)
        Dim chat As String = String.Format("Message sent at {0:t} on {0:D}", waiting)
        WriteLine("Message :{0}", chat)
        readline()
    End Sub
End Module
