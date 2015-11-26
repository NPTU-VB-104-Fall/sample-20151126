Public Class Manager
    Inherits Employee
    Implements ISalary


    Public Function GetSalary() As Integer Implements ISalary.GetSalary

        Return 40000

    End Function

End Class
