Imports System.Transactions
Imports Microsoft.VisualBasic.FileIO

Public Class vechicle
    Public milage As Double
    Public price As Long

End Class
Public Class car
    Inherits vechicle
    Public ownership_cost As String
    Public seating_capacity As Int16
    Public fuel_type As String

End Class
Public Class bike
    Inherits vechicle
    Public number_cilnder As Int16
    Public number_gears As Int16
    Public cooling_type As String
    Public wheel_type As String
    Public fuel_tank As Double

End Class
Public Class audi
    Inherits car
    Public model_type As String
    Sub getdetails()
        Console.WriteLine("ENTER THE CAR MODEL TYPE:")
        model_type = Console.ReadLine()
        Console.WriteLine("ENTER THE MILLAGE OF CAR:")
        milage = Console.ReadLine()
        Console.WriteLine("ENTER THE PRICE OF CAR:")
        price = Console.ReadLine()
        Console.WriteLine("ENTER THE OWNERSHIP OF CAR:")
        ownership_cost = Console.ReadLine()
        Console.WriteLine("ENTER THE SEATING CAPACITY:")
        seating_capacity = Console.ReadLine()
        Console.WriteLine("ENTER THE FUEL TYPE:")
        fuel_type = Console.ReadLine()
    End Sub
    Sub displayDetails()
        Console.WriteLine("++++++++++AUDI CAR DETAILS+++++++++++")
        Console.WriteLine("MODEL TYPE :" & model_type)
        Console.WriteLine("PRICE  :" & price)
        Console.WriteLine("MILLAGE :" & milage)
        Console.WriteLine("OWNER SHIP OF CAR :" & ownership_cost)
        Console.WriteLine("SEATING CAPACITY :" & seating_capacity)
        Console.WriteLine("FUEL TYPE :" & fuel_type)
    End Sub

End Class
Public Class ford
    Inherits car
    Dim model_type As String
    Sub getdetails()
        Console.WriteLine("ENTER THE CAR MODEL TYPE:")
        model_type = Console.ReadLine()
        Console.WriteLine("ENTER THE MILLAGE OF CAR:")
        milage = Console.ReadLine()
        Console.WriteLine("ENTER THE PRICE OF CAR:")
        price = Console.ReadLine()
        Console.WriteLine("ENTER THE OWNERSHIP OF CAR:")
        ownership_cost = Console.ReadLine()
        Console.WriteLine("ENTER THE SEATING CAPACITY:")
        seating_capacity = Console.ReadLine()
        Console.WriteLine("ENTER THE FUEL TYPE:")
        fuel_type = Console.ReadLine()
    End Sub
    Sub displayDetails()
        Console.WriteLine("++++++++++ FORD DETAILS +++++++++++")
        Console.WriteLine("MODEL TYPE :" & model_type)
        Console.WriteLine("PRICE  :" & price)
        Console.WriteLine("MILLAGE :" & milage)
        Console.WriteLine("OWNER SHIP OF CAR :" & ownership_cost)
        Console.WriteLine("SEATING CAPACITY :" & seating_capacity)
        Console.WriteLine("FUEL TYPE :" & fuel_type)
    End Sub

End Class
Public Class bajaJ
    Inherits bike
    Dim model_type As String
    Sub getdetails()
        Console.WriteLine("ENTER THE BIKE MODEL TYPE:")
        model_type = Console.ReadLine()
        Console.WriteLine("ENTER THE MILLAGE OF BIKE:")
        milage = Console.ReadLine()
        Console.WriteLine("ENTER THE PRICE OF BIKE:")
        price = Console.ReadLine()
        Console.WriteLine("ENTER THE NUMBER CILYINDER:")
        number_cilnder = Console.ReadLine()
        Console.WriteLine("ENTER THE NUMBER OF GEARS CAPACITY:")
        number_gears = Console.ReadLine()
        Console.WriteLine("ENTER THE COOLING TYPE:")
        cooling_type = Console.ReadLine()
        Console.WriteLine("ENTER THE WHEEL TYPE:")
        wheel_type = Console.ReadLine()
        Console.WriteLine("ENTER THE FUEL TYPE:")
        fuel_tank = Console.ReadLine()
    End Sub
    Sub displayDetails()
        Console.WriteLine("++++++++++ BAJAJ DETAILS +++++++++++")
        Console.WriteLine("MODEL TYPE :" & model_type)
        Console.WriteLine("PRICE  :" & price)
        Console.WriteLine("MILLAGE :" & milage)
        Console.WriteLine("NUMBER OF CILIDER :" & number_cilnder)
        Console.WriteLine("NUMBER OF GEARS :" & number_gears)
        Console.WriteLine("COOLING TYPE :" & cooling_type)
        Console.WriteLine("WHEEL TYPE :" & wheel_type)
        Console.WriteLine("FUEL TYPE :" & fuel_tank)
    End Sub

End Class
Public Class tvs
    Inherits bike
    Dim model_type As String
    Sub getdetails()
        Console.WriteLine("ENTER THE MODEL TYPE:")
        model_type = Console.ReadLine()
        Console.WriteLine("ENTER THE MILLAGE OF BIKE:")
        milage = Console.ReadLine()
        Console.WriteLine("ENTER THE PRICE OF BIKE:")
        price = Console.ReadLine()
        Console.WriteLine("ENTER THE NUMBER CILYINDER:")
        number_cilnder = Console.ReadLine()
        Console.WriteLine("ENTER THE NUMBER OF GEARS CAPACITY:")
        number_gears = Console.ReadLine()
        Console.WriteLine("ENTER THE COOLING TYPE:")
        cooling_type = Console.ReadLine()
        Console.WriteLine("ENTER THE WHEEL TYPE:")
        wheel_type = Console.ReadLine()
        Console.WriteLine("ENTER THE FUEL TYPE:")
        fuel_tank = Console.ReadLine()
    End Sub
    Sub displayDetails()
        Console.WriteLine("++++++++++ BAJAJ DETAILS +++++++++++")
        Console.WriteLine("MODEL TYPE :" & model_type)
        Console.WriteLine("PRICE  :" & price)
        Console.WriteLine("MILLAGE :" & milage)
        Console.WriteLine("NUMBER OF CILIDER :" & number_cilnder)
        Console.WriteLine("NUMBER OF GEARS :" & number_gears)
        Console.WriteLine("COOLING TYPE :" & cooling_type)
        Console.WriteLine("WHEEL TYPE :" & wheel_type)
        Console.WriteLine("FUEL TYPE :" & fuel_tank)
    End Sub

End Class