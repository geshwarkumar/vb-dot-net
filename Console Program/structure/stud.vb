Imports System.Console
Structure student
    Dim cona As Integer
    Dim mgt As Integer
    Dim os As Integer
    Dim ds As Integer
    Dim dbms As Integer
End Structure
Public Class record
    Dim std As student
    Shared Sub main()
        Dim c As New record
        c.cals()
        c.acceptdata()
        c.display()
        ReadKey()
    End Sub
    Sub acceptdata()
        Write("Enter the marks obtain in cona(100): ")
        std.cona = ReadLine()
        Write("Enter the marks obtain in ds(100): ")
        std.ds = ReadLine()
        Write("Enter the marks obtain in os(100): ")
        std.os = ReadLine()
        Write("Enter the marks obtain in imf(100): ")
        std.mgt = ReadLine()
        Write("Enter the marks obtain in dbms(100): ")
        std.dbms = ReadLine()
    End Sub
    Sub display()
        WriteLine("Result is:" & vbNewLine & "Obtain marks in :" & vbNewLine & "CONA = {0}" & vbNewLine & "DS = {1}" & vbNewLine & "OS = {2}" & vbNewLine & "DBMS = {3}" & vbNewLine & "IMF = {4}", std.cona, std.ds, std.os, std.dbms, std.mgt)
    End Sub
    Sub cals()
        Dim total, avg As Integer
        total = std.cona + std.ds + std.os + std.dbms + std.mgt
    End Sub
End Class