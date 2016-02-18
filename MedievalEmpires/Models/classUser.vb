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

    Public Function checkCredentials(ByVal username As String, ByVal password As String) As Boolean
        Dim valid As Boolean
        If pUsername = username And pPassword = password Then
            valid = True
        Else
            valid = False
        End If
        Return valid
    End Function

    'Retorna un array d'enters amb la quantitat de soldats que te per cadascun
    Public Function getForEachSoldiersHave(ByVal listSoldiers) As List(Of Integer)
        Dim cont As Integer = 0
        Dim listCounts As New List(Of Integer) From {}
        For Each s In listSoldiers
            For Each soldier In Me.pEmpire.pSoldiers
                If s.GetType Is soldier.GetType Then
                    cont += 1
                End If
            Next
            listCounts.Add(cont)
            cont = 0
        Next
        Return listCounts
    End Function

End Class
