Imports System
Imports System.Runtime.Serialization.Json

Module Факториалы
    Sub Main(args As String())
        Const INMAX As Integer = 2147483647
        Console.WriteLine("Я умею считать факториалы. Введите число n: ")
        Dim N, F As Integer
        F = 1
        N = CInt(Console.ReadLine())
        For i = 1 To N
            If (F < INMAX / i) Then
                F = F * i
            Else
                Console.Write("Переполнение памяти, расчет выполниния для N=")
                Console.WriteLine(i - 1)
                Exit For
            End If
        Next
        Console.Write("N!=")
        Console.Write(F)



    End Sub
End Module
