﻿'program that gives you the length of the longest word in the sentence
Module Module1

    Sub Main()
        Dim sen As String
        Dim pos1, pos2, diff, high As Integer
        high = 0
        Console.Write("Input your sentence: ")
        sen = Console.ReadLine
        sen = sen + " "
        pos1 = 0
        Do Until pos2 = Len(sen)
            pos2 = InStr(pos1 + 1, sen, " ")
            diff = pos2 - pos1
            If diff > high Then
                high = diff
            End If
            pos1 = pos2
        Loop
        Console.WriteLine(high - 1 & " is the length of the longest word")
        Console.ReadLine()
    End Sub

End Module
