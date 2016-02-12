Imports MedievalEmpires

Public MustInherit Class Empire
    Private id As Integer
    Private name As String
    Private population As Integer
    Private coins As Integer
    Private soldiers As List(Of Soldier)

    Public Sub New(name As String, population As Integer, coins As Integer)
        Me.pName = name
        Me.pPopulation = population
        Me.pCoins = coins
        Me.pSoldiers = New List(Of Soldier) From {}
    End Sub

    Public Sub New(name As String, population As Integer, coins As Integer, soldiers As List(Of Soldier))
        Me.pName = name
        Me.pPopulation = population
        Me.pCoins = coins
        Me.pSoldiers = soldiers
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

    Public Property pPopulation As Integer
        Get
            Return population
        End Get
        Set(value As Integer)
            population = value
        End Set
    End Property

    Public Property pCoins As Integer
        Get
            Return coins
        End Get
        Set(value As Integer)
            coins = value
        End Set
    End Property

    Public Property pSoldiers As List(Of Soldier)
        Get
            Return soldiers
        End Get
        Set(value As List(Of Soldier))
            soldiers = value
        End Set
    End Property

    'Comprem el soldat i l'afeguim a la llista sempre i quan l'imperi tingui monedes suficients
    Public Overridable Function buySoldier(soldier As Soldier) As Boolean
        Dim bought As Boolean = False
        pCoins = pCoins - soldier.pPrice
        If pCoins < 0 Then
            bought = False
        Else
            pSoldiers.Add(soldier)
            bought = True
        End If
        Return bought
    End Function

    Public Sub addSoldier(soldier As Soldier)
        pSoldiers.Add(soldier)
    End Sub
End Class
