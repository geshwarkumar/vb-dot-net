Imports System.Console
Structure student
    Dim name As String
    Dim dob As Date
End Structure
Public Class record
    Dim std As student
    Shared Sub main()
        Dim c As New record
        'WriteLine("One={0}, Two={1} and Three={2}", 1, 2, 3)
        c.acceptdata()
        c.display()
        ReadKey()
    End Sub
    Sub acceptdata()
        Write("Enter the student name: ")
        std.name = ReadLine()
        Write("Enter DOB: ")
        std.dob = ReadLine()
    End Sub
    Sub display()
        WriteLine("Student name is {0}" & vbNewLine & "Date of birth is {1}", std.name, std.dob)
        'WriteLine("Student name is {0}", std.name)
        'WriteLine("Date of birth is {0}", std.dob)
    End Sub
End Class