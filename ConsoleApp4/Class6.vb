Class Bank
    Protected Account_name, Account_Type, yes_no As String
    Protected Account_number, Balance As Long
    Sub GetDetails()
        Console.WriteLine("ENTER THE ACOUNT NUMBER : ")
        Account_number = Convert.ToInt64(Console.ReadLine())
        Console.WriteLine("ENTER THE ACCOUNT NAME : ")
        Account_name = Convert.ToString(Console.ReadLine())
        Console.WriteLine("ENTER THE TYPE SAVING / CURRENT : ")
        Account_Type = Convert.ToString(Console.ReadLine())
        Console.WriteLine("ENTER MAIN BALANCE : ")
        Balance = Convert.ToUInt64(Console.ReadLine())
    End Sub
    Sub getAccountBalance()
        Console.WriteLine("DO YOU WANR CREDIT CARD YES/NO:")
        yes_no = Console.ReadLine()
        If yes_no = "NO" Then
            Console.WriteLine("YOUR PROCESS ENDED")
        Else
            If Balance > 800000 Then
                Console.WriteLine("YOUR ELIGIBLE FOR CREDIT CARD")

            ElseIf Balance > 500000 Then
                Console.WriteLine("YOUR ELIGIBLE FOR GLOD CREDIT CARD")

            ElseIf Balance > 200000 Then
                Console.WriteLine("YOUR ELIGIBLE FOR SILVER CREDIT CARD")

            Else
                Console.WriteLine("NOT ELIGIBLE")
            End If
        End If
    End Sub
End Class
Class BankAccount
    Dim accNumber As String
    Dim accType As String
    Dim accBalance As Decimal

    ' Constructor without arguments
    Public Sub New()
        Console.WriteLine("++++++++ Getting Account Details +++++++++")
    End Sub

    ' Constructor with two arguments
    Public Sub New(number As String, type As String)
        accNumber = number
        accType = type
    End Sub

    Public Sub getBankDetails()
        Console.WriteLine("Enter Account Balance:")
        accBalance = Convert.ToDecimal(Console.ReadLine())
    End Sub

    Public Sub Display()
        Console.WriteLine("Account Number: " & accNumber)
        Console.WriteLine("Account Type: " & accType)
        Console.WriteLine("Account Balance: " & accBalance)
    End Sub

    Public Sub Deposit(amount As Decimal)
        accBalance += amount
        Console.WriteLine("Amount deposited successfully.")
    End Sub

    Public Sub Withdraw(amount As Decimal)
        If amount <= accBalance Then
            accBalance -= amount
            Console.WriteLine("Amount withdrawn successfully.")
        Else
            Console.WriteLine("Insufficient balance.")
        End If
    End Sub
End Class