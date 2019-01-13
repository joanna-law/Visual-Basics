'program that lets you choose the number of students in a class, input their marks then tell you the minimum, maximum and average mark
Module Module1
    Function max(ByVal number As Integer, ByRef min As Integer, ByRef average As Single) As Integer
        Dim temp, sum As Integer
        max = 0
        min = 100
        sum = 0
        average = 0
        For i = 1 To number
            Console.Write("Input the mark of student " & i & " is :")
            temp = Console.ReadLine
            If temp > max Then
                max = temp
            End If
            If temp < min Then
                min = temp
            End If
            sum = sum + temp
        Next
        average = sum / number

    End Function
    Sub Main()
        Dim number, x, min As Integer
        Dim average As Single
        number = 0
        x = 0
        min = 0
        average = 0
        Console.Write("Input number of students: ")
        number = Console.ReadLine
        x = max(number, min, average)
        Console.WriteLine("The max is " & x & ", the min is " & min & " and the average is " & average)
        Console.ReadLine()
    End Sub

End Module
