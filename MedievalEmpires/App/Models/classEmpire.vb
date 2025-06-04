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
    Public MustOverride Sub buySoldier(soldier As Soldier)


    Public Overridable Sub buyNSoldiers(soldier As Soldier, quantity As Integer)
        For i = 1 To quantity
            Me.buySoldier(soldier)
        Next
    End Sub


    Public Sub addSoldier(soldier As Soldier)
        pSoldiers.Add(soldier)
    End Sub

    Public Function getTypeEmpire() As String
        Dim typeEmpire As String = ""
        If TypeOf Me Is Roman Then
            typeEmpire = "Roman"
        ElseIf TypeOf Me Is Teuton Then
            typeEmpire = "Teuton"
        Else
            typeEmpire = "Gaul"
        End If
        Return typeEmpire
    End Function

    Public Sub spendMoney(ByVal goldToSpend As Integer)
        pCoins -= goldToSpend
    End Sub

    Public Function getTotalDamage() As Integer
        Dim damage As Integer = 0
        For Each soldier In Me.pSoldiers
            damage += soldier.pAttack
        Next
        Return damage
    End Function

    Public Function getTotalDefense() As Integer
        Dim defense As Integer = 0
        For Each soldier In Me.pSoldiers
            defense += soldier.pDefense
        Next
        Return defense
    End Function



End Class
