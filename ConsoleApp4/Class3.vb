Public Class employee
    Dim empName, empId, destination, officeLocation, city As String
    Public Sub empInfo()
        Console.WriteLine("ENTER THE EMPLOYEE NAME: ")
        empName = Console.ReadLine()
        Console.WriteLine("ENTER THE EMPLOYEE ID: ")
        empId = Console.ReadLine()
        Console.WriteLine("ENTER THE EMPLOYEE DESTINATION: ")
        destination = Console.ReadLine()
        Console.WriteLine("ENTER THE EMPLOYEE OFFICCE LOCATION: ")
        officeLocation = Console.ReadLine()
        Console.WriteLine("ENTER THE EMPLOYEE CITY: ")
        city = Console.ReadLine()
    End Sub
    Sub showEmpinfo()
        Console.WriteLine("EMPLOYEE'S NAME : {0}", empName)
        Console.WriteLine("EMPLOYEE'S EMP ID : {0}", empId)
        Console.WriteLine("EMPLOYEE'S DESTINATION : {0}", destination)
        Console.WriteLine("EMPLOYEE'S OFFICE LOCATION : {0}", officeLocation)
        Console.WriteLine("EMPLOYEE'S CITY : {0}", city)
    End Sub
End Class
