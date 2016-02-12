Imports MedievalEmpires

Public MustInherit Class Soldier
    Private id As Integer
    Private name As String
    Private attack As Integer
    Private defense As Integer
    Private price As Integer
    Private Empire As Empire

    Public Sub New(name As String, attack As Integer, defense As Integer, price As Integer, empire As Empire)
        Me.pName = name
        Me.pAttack = attack
        Me.pDefense = defense
        Me.pPrice = price
        Me.pEmpire = empire
    End Sub
    Public Property pId As Integer
        Get
            Return id
        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property

    Public Property pName As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property pAttack As Integer
        Get
            Return attack
        End Get
        Set(value As Integer)
            attack = value
        End Set
    End Property

    Public Property pDefense As Integer
        Get
            Return defense
        End Get
        Set(value As Integer)
            defense = value
        End Set
    End Property

    Public Property pPrice As Integer
        Get
            Return price
        End Get
        Set(value As Integer)
            price = value
        End Set
    End Property

    Public Property pEmpire As Empire
        Get
            Return Empire
        End Get
        Set(value As Empire)
            Empire = value
        End Set
    End Property
End Class
