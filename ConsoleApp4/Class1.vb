MustInherit Class student
    MustOverride Sub takeExam()

End Class
Class phdStudent
    Inherits student

    Public Overrides Sub takeExam()
        Console.WriteLine("PHD STUDENT TAKE EXAM BY GIVING PRESENTATION")
    End Sub
End Class
Class gratuate
    Inherits student

    Public Overrides Sub takeExam()
        Console.WriteLine("GRATUATE STUDENT GIVES A WITHEPAPER")
    End Sub
End Class