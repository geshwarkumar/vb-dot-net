Imports System.Console
Public Structure student
    'Dim cona,os,ds,dbms,imf As Integer
    Dim cona As Integer
    Dim ds As Integer
    Dim os As Integer
    Dim dbms As Integer
    Dim imf As Integer
End Structure
Class stud
    Dim st As student
    Shared Sub main()
        Dim cls As New stud
        cls.input()
        cls.result()
        ReadKey()
    End Sub
    Sub input()
        WriteLine("Enter the marks upto 100:")
        Write("CONA : ")
        st.cona = ReadLine()
        Write("DS : ")
        st.ds = ReadLine()
        Write("OS : ")
        st.os = ReadLine()
        Write("DBMS : ")
        st.dbms = ReadLine()
        Write("IMF : ")
        st.imf = ReadLine()
    End Sub
    Sub result()
        Dim total As Integer
        Dim per As Double
        total = st.cona + st.dbms + st.ds + st.imf + st.os
        per = total / 5
        WriteLine("Total obtained number of all subjects : {0}" & vbNewLine & "Obtained percent is : {1}", total, per)

        Write("Grade : ")
        If (per <= 100 And per >= 90) Then
            WriteLine("A+")
        ElseIf (per < 90 And per >= 65) Then
            WriteLine("A")
        ElseIf (per < 65 And per >= 50) Then
            WriteLine("B")
        ElseIf (per < 50 And per >= 40) Then
            WriteLine("C")
        Else
            WriteLine("FAIL")
        End If

    End Sub
End Class