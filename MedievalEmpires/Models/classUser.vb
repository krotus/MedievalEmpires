Imports MedievalEmpires

Public Class User
    Inherits Person

    Private username As String
    Private password As String
    Private empire As Empire

    Public Sub New(username As String, password As String)
        MyBase.New("someone", "somelse")
        pUsername = username
        pPassword = password
    End Sub
    Public Sub New(name As String, surname As String, username As String, password As String, empire As Empire)
        MyBase.New(name, surname)
        pUsername = username
        pPassword = password
        pEmpire = empire
    End Sub

    Public Property pUsername As String
        Get
            Return username
        End Get
        Set(value As String)
            username = value
        End Set
    End Property

    Public Property pPassword As String
        Get
            Return password
        End Get
        Set(value As String)
            password = value
        End Set
    End Property

    Public Property pEmpire As Empire
        Get
            Return empire
        End Get
        Set(value As Empire)
            empire = value
        End Set
    End Property

    Public Function authenticate(ByVal username As String, ByVal password As String) As Boolean
        Dim valid As Boolean
        If pUsername = username And pPassword = password Then
            valid = True
        Else
            valid = False
        End If
        Return valid
    End Function

End Class
