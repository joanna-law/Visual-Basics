﻿'program that outputs the latin square of the order you want
Module Module1

    Sub Main()
        Dim num, newstart As Integer
        Console.Write("Input the order of latin square you want: ")
        num = Console.ReadLine
        newstart = 1
        For j = 1 To num

            For i = newstart To num + newstart - 1
                If i <= num Then
                    Console.Write(i & " ")
                ElseIf i > num Then
                    Console.Write(i - num & " ")
                End If
            Next
            newstart = newstart + 1
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub

End Module
