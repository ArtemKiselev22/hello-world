Imports System
Imports System.Linq.Expressions
Imports System.Runtime.InteropServices
Imports System.Text

Module Program
    Sub Main(args As String())
        Dim N, ver As String
        'TODO: ���������� �����
        N = 1234
        Console.WriteLine("������ �����")
        Do
            ver = Console.ReadLine()
            For i = 0 To 3
                If (N.Chars(i) = ver.Chars(0)) Then
                    If i = 0 Then
                        Console.WriteLine("������ ����� ����� ������ - ���")
                    Else
                        Console.WriteLine("������ ����� ����� ������ - ������")


                    End If


                End If
            Next
        Loop Until N = ver

    End Sub
End Module
