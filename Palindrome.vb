'Program that tells you if the word you input is a palindrome or not

Module Module1

    Sub Main()
        Dim rev, word As String
        Dim letter As Char
        Console.Write("Input your word and we will tell you if it is a palindrome: ")
        word = Console.ReadLine
        rev = ""
        For i = Len(word) To 1 Step -1
            letter = Mid(word, i)
            rev = rev & letter
        Next
        If rev.ToUpper = word.ToUpper Then
            Console.WriteLine(word & " is a palindrome.")
        Else
            Console.WriteLine(word & " is not a palindrome.")
        End If
        Console.ReadLine()

    End Sub

End Module
