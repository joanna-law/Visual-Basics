Module Module1



    Sub Main()
        Dim mystring, search, temp As String
        Dim count As Integer

        temp = ""
        count = 0

        Console.WriteLine("Input your sentence.")
        mystring = Console.ReadLine

        Console.WriteLine("Input word to be searched.")
        search = Console.ReadLine

        For i = 1 To Len(mystring)

            If Mid(mystring, i, 1) = Mid(search, 1, 1) Then

                For k = 1 To Len(search)

                    If Mid(mystring, i, 1) = Mid(search, k, 1) Then
                        temp = temp & Mid(mystring, i, 1)
                        i = i + 1

                        If k = Len(search) Then
                            If Mid(mystring, i, 1) = " " Or Mid(mystring, i, 1) = "." Or Mid(mystring, i, 1) = "," Or Mid(mystring, i - 1, 1) = Mid(mystring, Len(mystring), 1) Then
                                If temp = search Then
                                    count = count + 1

                                End If

                            End If

                        End If

                    End If

                Next
                temp = ""
            End If


        Next

        Console.WriteLine("The word {0} was encountered {1} number of time.", search, count)
        Console.WriteLine(temp)
        Console.ReadLine()

    End Sub

End Module
