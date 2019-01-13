Module Module1

    Sub Main()
        Dim sen, newsen, word, newword As String
        Dim pos1, pos2 As Integer
        Console.WriteLine("Input the sentence")
        sen = Console.Read
        newsen = " "
        newword = ""
        For i = Len(sen) To 1 Step -1
            newsen = newsen + Mid(sen, i, 1)
        Next
        newsen = newsen + " "
        pos1 = 1
        COnsole.writeline("The reversed version is: ")
        Do Until pos1 = Len(newsen)
            pos2 = InStr(pos1 + 1, newsen, " ")
            word = Mid(newsen, pos1 + 1, pos2 - pos1 - 1)
            For j = Len(newsen) To 1 Step -1
                newword = newword + Mid(word, j, 1)
            Next
            pos1 = pos2
            newword = ""
        Loop
        Console.Read()

    End Sub

End Module
