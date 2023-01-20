Imports System
Imports System.Linq.Expressions
Imports System.Runtime.Intrinsics.Arm

Module Program
    Sub Main(args As String())
        Dim p, i As Long
        Console.WriteLine(" Умею считать произведение")
        Console.WriteLine("Напиши 1 если ты закончил ")
        i = 0
        p = 1
        While (i <> 1)
            i = CInt(Console.ReadLine())
            p = p * i
            If (i = 1) Then


            End If
            If p > (Int64.MaxValue / p) Then
                Console.Write(" Память перегружина !!!  =   ")
                Console.Write(p)

            End If








        End While


















        Console.WriteLine(" Произведение N введенных Вами чисел равно ")
        Console.WriteLine(p)


    End Sub
End Module
