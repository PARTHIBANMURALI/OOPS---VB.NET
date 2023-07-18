Imports System
Imports System.Collections.Specialized
Imports System.IO
Imports System.Security.Cryptography.X509Certificates
Imports System.Text.RegularExpressions
Imports System.Xml.Serialization
Module Program
    Sub Main(args As String())
        'Dim obj As New phdStudent
        'obj.takeExam()
        'Dim ojb As New gratuate
        'ojb.takeExam()

        'Dim obj As employee = New employee
        'Console.WriteLine("enter the number of eemployees want to print:")
        'Dim count As Int16 = Console.ReadLine()
        'For i As Int16 = 1 To count
        '    obj.empInfo()
        '    obj.showEmpinfo()
        'Next

        'obj.empInfo()
        'obj.showEmpinfo()

        'withoutUsingmatch()
        'passvalid()
        'emailIDvalid()
        'Excephand()

        'Console.WriteLine("ENTER THE PATIENT IS ")
        'Console.WriteLine("1. INPATIENT")
        'Console.WriteLine("2. OUTPATIENT")
        'Dim op As Int16 = Console.ReadLine()
        'If op = 1 Then
        '    Dim obj As inpatient = New inpatient
        '    obj.GetinpatientDetAILS()
        '    obj.generatebills()
        'Else
        '    Dim ibo As outpatient = New outpatient
        '    ibo.getoutpatientdetails()
        '    ibo.generatebills()
        'End If



        'Dim audiCar As New audi()
        'Dim fordCar As New ford()
        'Dim TvsBike As New tvs()
        'Dim BajajBike As New bajaJ()
        'Console.WriteLine("enter the 1. car/ 2. bike want to print")
        'Dim str As Int16 = Console.ReadLine()
        'If str = 1 Then
        '    Console.WriteLine("enter the car type want to print 1.audi / 2. ford")
        '    Dim c As Int16 = Console.ReadLine()
        '    If c = 1 Then
        '        audiCar.getdetails()
        '        audiCar.displayDetails()
        '    Else
        '        fordCar.getdetails()
        '        fordCar.displayDetails()
        '    End If
        'Else
        '    Console.WriteLine("enter the bike type want to print 1.bajaj / 2. tvs")
        '    Dim s As Int16 = Console.ReadLine()
        '    If s = 1 Then
        '        BajajBike.getdetails()
        '        BajajBike.displayDetails()
        '    Else
        '        TvsBike.getdetails()
        '        TvsBike.displayDetails()
        '    End If
        'End If




        'Dim bank1 As BankAccount = New BankAccount()
        'Dim accNumber, accType As String
        'Console.WriteLine("ENTER THE ACCOUNT NUMBER")
        'accNumber = Console.ReadLine()
        'Console.WriteLine("ACCOUNT TYPE SAVING / CURRENT")
        'accType = Console.ReadLine()
        'Dim bankAcc2 As New BankAccount(accNumber, accType)
        'bankAcc2.getBankDetails()
        'Console.WriteLine("ENTER THE AMOUNT TO DEPOSITE ")
        'Dim depositAmount As Decimal = Convert.ToDecimal(Console.ReadLine())
        'bankAcc2.Deposit(depositAmount)
        'Console.WriteLine("ENTER THE AMMOUNT TO WITHDRAW")
        'Dim withdrawAmount As Decimal = Convert.ToDecimal(Console.ReadLine())
        'bankAcc2.Withdraw(withdrawAmount)
        'Console.WriteLine()
        'Console.WriteLine("BANK ACCOUNT DETAILS")
        'bankAcc2.Display()
        'Dim aacoutbal As Bank = New Bank()
        'aacoutbal.getAccountBalance()



        'Dim list As Queue = New Queue()
        'Console.WriteLine("enter the number of elemnt")
        'Dim n As Int16 = Console.ReadLine()
        'Console.WriteLine("enter the values")
        'For i = 1 To n
        '    list.Enqueue(Console.ReadLine)
        'Next
        'Dim ca As Queue = list.Clone()
        'For Each i In ca
        '    Console.WriteLine(i)
        'Next

        'Dim c As Int16 = list.Count
        '    Console.WriteLine(c)
        'Dim ele As String
        'ele = List.Dequeue()
        'c = List.Count
        'Console.WriteLine(c)
        'Console.WriteLine(ele)
        'For Each i In List
        '    Console.WriteLine(i)
        'Next

        'Dim col As NameValueCollection = New NameValueCollection
        'col.Add("mobile", "ramm")
        'col.Add("mobile", "rgrtggtr")
        'col.Add("mobile", "turyu")
        'col.Add("laptop", "rtyi")
        'col.Add("laptop", "sfgg")
        'col.Add("laptop", "dsfgdf")
        'col.Remove("mobile")
        'For Each KEY In col
        '    Console.WriteLine("KEY NAME :{0}", KEY)
        '    Console.WriteLine("{0}", col(KEY))
        'Next

        'Dim col As LinkedList(Of Integer) = New LinkedList(Of Integer)
        'Dim sol2 As Stack(Of String) = New Stack(Of String)
        'Dim col3 As New Queue(Of String)

        Dim path = "demo.txt"
        File.Create(path)
        If File.Exists(path) Then
            Console.WriteLine("file is createed")
        End If


    End Sub
    Sub usingmatch()
        Dim regex As Regex = New Regex("\d+")
        Dim input As String = Console.ReadLine()
        Dim match As Match = regex.Match(input)
        If match.Success Then
            Console.WriteLine(match.Value)
        End If
    End Sub
    Sub withoutUsingmatch()
        Dim input As String = Console.ReadLine()
        Dim pattern As String = "\d+"
        Dim matche As MatchCollection = Regex.Matches(input, pattern)
        For Each m As Match In matche
            Console.WriteLine(m.Value)
        Next
    End Sub
    Sub emailIDvalid()
        Dim email As String = Console.ReadLine()
        Dim pattern As String = "*[a-z][a-zA-Z0-9+_.]+@[a-z]+.(com|in)$"
        Dim match As Match = Regex.Match(email, pattern)
        If match.Success Then
            Console.WriteLine("VALID EMAIL ADDRESS")
        Else
            Console.WriteLine(match.Value)
        End If
    End Sub
    Sub passvalid()
        Dim input As String = Console.ReadLine()
        Dim pattern As String = "(*(A-Z)*(a-z)*(0-9)*[@$%*&#!]){8,15}"
        Dim s As Long = input.Length
        Dim ismatch As Boolean = Regex.IsMatch(input, pattern)
        If ismatch Then
            Console.WriteLine("CORRECT PASSWORD")
        End If
        Console.WriteLine("ENTER THE PASSSWORD ABOVE 8 CHARACTER")

    End Sub
    Sub Excephand()
        Dim num1, num2, res1 As Int16
        Dim arr() As Int16 = New Int16(10) {}
        Dim val As String = "1234"
        num1 = 2
        num2 = 0
        Dim result As Int16 = 0
        Try
            result = num1 / num2
            arr(8) = 38
            res1 = Convert.ToInt16(val)
        Catch ex As Exception
            Console.WriteLine("SOME ERROR OCCURS DUR TO :{0} ", ex)
        End Try

        Console.WriteLine("result:" & result)
        Console.WriteLine("array val :{0}", arr(3))
        Console.WriteLine("after conversion:")

    End Sub
End Module
