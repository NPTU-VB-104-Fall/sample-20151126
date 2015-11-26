Public MustInherit Class Employee

    Protected _name As String
    Protected _address As String
    Protected _phone As String
    Protected _level As Integer

    Public Sub New()

    End Sub

    Public Sub New(ByVal Name As String, ByVal Phone As String, ByVal Address As String)
        _name = Name
        _address = Address
        _phone = Phone
    End Sub

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Phone() As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return _address
        End Get
        Set(value As String)
            _address = value
        End Set
    End Property

    Public ReadOnly Property Level() As Integer
        Get
            Return _level
        End Get
    End Property


End Class
