Public Class FullTimeEmployee
    Inherits Employee
    Implements ISalary

    Public Function GetSalary() As Integer Implements ISalary.GetSalary

        Return 22000

    End Function

End Class
