﻿'Program that asks you to input countries and capitals, saves it in an array and also quizzes you on it.
'In the end, it asks you if you want to save it in a text file. (Please add the path of the location where you want to save it(line 49))

Imports System.IO
Module Module1
    Dim newnum As New Random

    Sub input(ByVal array(,) As String)
        Dim country, capital As String
        For j = 1 To 5
            Console.Write("Input country: ")
            country = Console.ReadLine
            array(1, j) = country
            Console.Write("Input capital of the country: ")
            capital = Console.ReadLine
            array(2, j) = capital
        Next
    End Sub
    Sub question(ByVal array(,) As String)
        Dim temp, countgood As Integer
        Dim ans As String
        countgood = 0
        For i = 1 To 3
            temp = newnum.Next(1, 6)
            Console.WriteLine("What is the capital of " & array(1, temp) & "?")
            ans = Console.ReadLine
            If UCase(ans) = UCase(array(2, temp)) Then
                Console.WriteLine("Good answer")
                countgood = countgood + 1
            Else
                Console.WriteLine("Wrong answer")
            End If
            Console.WriteLine()
        Next
        Console.WriteLine("The number of good answers is: " & countgood)
    End Sub
    Sub Main()
        Dim array(2, 10), ans, writing As String
       
        input(array)
        Console.WriteLine()
        question(array)
        Console.WriteLine()
        Console.WriteLine("Do you want to save the countries input in a file? [YES/NO]")
        ans = Console.ReadLine

        If ans = "YES" Then
            Dim twodcountry As StreamWriter
            twodcountry = New StreamWriter("Insert the path of location where you want to save the file here\Country's Capital.txt")
            For i = 1 To 5
                writing = array(1, i) + ":  " + array(2, i)
                twodcountry.WriteLine(writing)
            Next
            twodcountry.Close()
        End If

        Console.ReadLine()

    End Sub

End Module
