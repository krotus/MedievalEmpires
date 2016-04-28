Public MustInherit Class Person
    Private name As String
    Private surname As String

    Public Sub New(name As String, surname As String)
        Me.pName = name
        Me.pSurname = surname
    End Sub

    Public Property pName As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property pSurname As String
        Get
            Return surname
        End Get
        Set(value As String)
            surname = value
        End Set
    End Property
End Class
