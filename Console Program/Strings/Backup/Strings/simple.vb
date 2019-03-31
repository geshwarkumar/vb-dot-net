Imports System.Console
Module simple

    Sub Main()
        Dim fname, lname, fullname As String
        'INPUT
        fname = "Ram"
        lname = "Kumar"
        fullname = fname + "" + lname
        'OUTPUT
        WriteLine("Fullname : {0}", fullname)
        ReadLine()
    End Sub

End Module
