'Program that counts the number of words in a sentence that start with the letter d
Module Module1

    Sub Main()
        Dim count As Integer
        Dim sentence As String
        count = 0
        Console.WriteLine("Input your sentence.")
        sentence = Console.ReadLine
        If Mid(sentence, 1) = "D" Then
            count = count + 1
        End If
        For i = 1 To Len(sentence)
            If Mid(sentence, i) = "D" Or Mid(sentence, i) = "d" Then
                If Mid(sentence, i - 1) = " " Then
                    count = count + 1
                End If
            End If
        Next
        Console.WriteLine("There are " & count & " words starting with d.")
        Console.ReadLine()
    End Sub

End Module
