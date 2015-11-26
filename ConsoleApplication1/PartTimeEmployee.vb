Public Class PartTimeEmployee
    Inherits Employee
    Implements ISalary

    Private _hours As Integer

    Public WriteOnly Property Hours() As Integer
        Set(value As Integer)
            _hours = value
        End Set
    End Property

    Public Function GetSalary() As Integer Implements ISalary.GetSalary

        Return 150 * _hours

    End Function

End Class
