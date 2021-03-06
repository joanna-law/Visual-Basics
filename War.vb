﻿Module Module1
    Class ship
        Private length As String
        Private weight As Single

        Public Sub setlength(ByVal l As String)
            length = l
        End Sub

        Public Sub basicweight()
            Select Case getlength()
                Case 0 To 100
                    weight = 12000
                Case 101 To 130
                    weight = 28000
                Case 131 To 250
                    weight = 85000
                Case Else
                    weight = 99000
            End Select
        End Sub

        Public Function getlength()
            Return length
        End Function

        Public Overridable Sub defineweight()
            basicweight()
        End Sub

        Public Function getweight()
            defineweight()
            Return weight
        End Function

    End Class

    Class carrier : Inherits ship

        Private weapons As Integer
        Private miss As Integer
        Private weight As Single

        Public Overrides Sub defineweight()
            basicweight()
            weight = (weight * 1.03) + (2.5 * getweapon()) + (3.5 * getmiss())
        End Sub

        Public Sub setweapon(ByVal w As Integer)
            weapons = w
        End Sub

        Public Function getweapon()
            Return weapons
        End Function

        Public Sub setmiss(ByVal m As String)
            miss = m
        End Sub

        Public Function getmiss()
            Return miss
        End Function

    End Class

    Class aircraft : Inherits carrier

        Private planes As Integer
        Private weight As Single

        Public Sub setplanes(ByVal p As Integer)
            planes = p
        End Sub

        Public Function getplanes()
            Return planes
        End Function

        Public Overrides Sub defineweight()
            basicweight()
            weight = (weight * 1.05) + (30 * planes) + (2.5 * getweapon()) + (3.5 * getmiss())
        End Sub

    End Class

    Sub Main()

        Dim ship1 As New ship
        Dim carrier1 As New carrier
        Dim aircraft As New aircraft

        Console.WriteLine("Ship 1")
        Console.Write("Length: ")
        ship1.setlength(Console.ReadLine)

        Console.WriteLine()
        Console.WriteLine("Facts on ship 1")
        Console.Write("Length: ")
        Console.WriteLine(ship1.getlength)
        Console.Write("Weight: ")
        Console.WriteLine(ship1.getweight)

        Console.WriteLine()

        Console.WriteLine("Carrier 1")
        Console.Write("Length: ")
        carrier1.setlength(Console.ReadLine)
        Console.Write("No of missiles: ")
        carrier1.setmiss(Console.ReadLine)
        Console.Write("No of weapons: ")
        carrier1.setweapon(Console.ReadLine)

        Console.WriteLine()

        Console.WriteLine("Facts on carrier 1")
        Console.Write("Length: ")
        Console.WriteLine(carrier1.getlength)
        Console.Write("Weight: ")
        Console.WriteLine(carrier1.getweight)
        Console.Write("Missiles: ")
        Console.WriteLine(carrier1.getmiss)
        Console.Write("Weapon: ")
        Console.WriteLine(carrier1.getweapon)

        Console.WriteLine()


        Console.WriteLine("Aircraft 1")
        Console.Write("Length: ")
        aircraft.setlength(Console.ReadLine)
        Console.Write("No of missiles: ")
        aircraft.setmiss(Console.ReadLine)
        Console.Write("No of weapons: ")
        aircraft.setweapon(Console.ReadLine)
        Console.Write("No of planes: ")
        aircraft.setplanes(Console.ReadLine)

        Console.WriteLine()

        Console.WriteLine("Facts on Aircraft 1")
        Console.Write("Length: ")
        Console.WriteLine(aircraft.getlength)
        Console.Write("Weight: ")
        Console.WriteLine(aircraft.getweight)
        Console.Write("Missiles: ")
        Console.WriteLine(aircraft.getmiss)
        Console.Write("Weapon: ")
        Console.WriteLine(aircraft.getweapon)
        Console.Write("Planes: ")
        Console.WriteLine(aircraft.getplanes)

        Console.WriteLine()

        Console.ReadKey()


    End Sub

End Module
