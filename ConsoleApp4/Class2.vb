Imports System.Runtime.CompilerServices

MustInherit Class patient
    Private name As String
    Private age As Int16
    Private addresss As String
    Private mobilenumber As Long
    Private problem As String

    Public Property patientName As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property
    Public Property patientAddress As String
        Get
            Return addresss
        End Get
        Set(value As String)
            addresss = value
        End Set
    End Property
    Public Property patientage As String
        Get
            Return age
        End Get
        Set(value As String)
            age = value
        End Set
    End Property
    Public Property PatientNumber As String
        Get
            Return mobilenumber
        End Get
        Set(value As String)
            mobilenumber = value
        End Set
    End Property
    Public Property problemName As String
        Get
            Return problem
        End Get
        Set(value As String)
            problem = value
        End Set
    End Property
    Sub getdetails()
        Console.WriteLine("ENTER THE NAME OF THE PATIENT")
        name = Console.ReadLine()
        Console.WriteLine("ENTER PATIENT AGE")
        age = Console.ReadLine()
        Console.WriteLine("ENTER PETIRNT ADDRESS")
        addresss = Console.ReadLine()
        Console.WriteLine("ENTER PATIENT MOBILENUMBER")
        mobilenumber = Console.ReadLine()
        Console.WriteLine("ENTER PATIENT PROBLEM")
        problemName = Console.ReadLine()
    End Sub
    MustOverride Sub generatebills()
    Sub showpatientdetails()
        Console.WriteLine("PATIENT NAME :" & patientName)
        Console.WriteLine("PATIENT AGE :" & patientage)
        Console.WriteLine("PATIENT LOCAION :" & addresss)
        Console.WriteLine("PATIENT PROBLEM:" & problemName)
    End Sub

End Class
Class inpatient
    Inherits patient
    Private doctorfee As Double = 200
    Private nursefee As Double = 100
    Dim roomcharge As Int16 = 400
    Private roomtype As String
    Private scanreportcost As Double = 250
    Private Noofstay As Int16
    Private noofscan As Int16
    Dim rent As Long

    Public Property DocterFee As String
        Get
            Return doctorfee
        End Get
        Set(value As String)
            doctorfee = value
        End Set
    End Property
    Public Property nursepaid As String
        Get
            Return nursefee
        End Get
        Set(value As String)
            nursefee = value
        End Set
    End Property
    Public Property RoomFee As String
        Get
            Return roomcharge
        End Get
        Set(value As String)
            roomcharge = value
        End Set
    End Property
    Public Property roomformat As String
        Get
            Return roomtype
        End Get
        Set(value As String)
            roomtype = value
        End Set
    End Property
    Public Sub GetinpatientDetAILS()
        getdetails()
        Console.WriteLine("ENTER THE TYPE OF ROOM :")
        Console.WriteLine("1.GENERAL WARD  ")
        Console.WriteLine("2.ICU")
        Console.WriteLine("3.SEPRATE WARD")
        roomtype = Console.ReadLine()
        Console.WriteLine("ENTER THE NUMBER OF DAYS")
        Noofstay = Console.ReadLine()
        Console.WriteLine("ENTER TNUMBER OF SDCAN TAKEN")
        noofscan = Console.ReadLine()

    End Sub
    Overrides Sub generatebills()
        If roomtype = 1 Then
            rent += 1000 * Noofstay
        ElseIf roomtype = 2 Then
            rent += 500 * Noofstay
        Else
            rent += 800 * Noofstay
        End If
        showpatientdetails()
        Console.WriteLine("++++BILL FOR IINPATIENT ++++")
        Console.WriteLine("dOCTER FEE :" & DocterFee * Noofstay)
        Console.WriteLine("NURSE FEE :" & nursefee * Noofstay)
        Console.WriteLine("RENT AS TO PAY  FOR ROOM IS :" & rent)
        Console.WriteLine("SCAN COST :" & scanreportcost * noofscan)
        Console.WriteLine("TOTAL FEE AS TO PAY :" & (DocterFee + nursefee + rent + scanreportcost))
    End Sub
End Class
Class outpatient
    Inherits patient
    Private docterconFee As Double = 300
    Private medicinefee As Double = 40
    Private noofmedcine As Int16
    Public Property docconfee As Double
        Get
            Return docterconFee
        End Get
        Set(value As Double)
            docterconFee = value
        End Set
    End Property
    Public Property medfee As Double
        Get
            Return medicinefee
        End Get
        Set(value As Double)
            medicinefee = value
        End Set
    End Property
    Public Property numberofmed As Double
        Get
            Return noofmedcine
        End Get
        Set(value As Double)
            noofmedcine = value
        End Set
    End Property
    Sub getoutpatientdetails()
        getdetails()
        Console.WriteLine("ENTER THE NUMBER OF MEDICINE: ")
        noofmedcine =Console.ReadLine()
    End Sub
    Public Overrides Sub generatebills()
        showpatientdetails()
        Console.WriteLine("++++++++ BILL FOR OUTPATIENT ++++++")
        Console.WriteLine("DOCTOR FEE :" & docterconFee)
        Console.WriteLine("MEDICINE FEE :" & medicinefee)
        Console.WriteLine("TOTAL BILL : " & docterconFee + medicinefee)
    End Sub
End Class