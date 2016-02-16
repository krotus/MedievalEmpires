Imports MedievalEmpires

Public Class MedievalEmpires
    Private empires As List(Of Empire)
    Private users As List(Of User)

    Public Sub New()
        Me.pEmpires = New List(Of Empire) From {}
        Me.pUsers = New List(Of User) From {}
    End Sub
    Public Sub New(empires As List(Of Empire))
        Me.pEmpires = empires
    End Sub

    Public Property pEmpires As List(Of Empire)
        Get
            Return empires
        End Get
        Set(value As List(Of Empire))
            empires = value
        End Set
    End Property

    Public Property pUsers As List(Of User)
        Get
            Return users
        End Get
        Set(value As List(Of User))
            users = value
        End Set
    End Property

    Public Sub addEmpire(empire As Empire)
        Me.pEmpires.Add(empire)
    End Sub

    Public Sub addUser(ByVal user)
        Me.pUsers.Add(user)
    End Sub

    Public Sub populate()
        'Users
        'Dim account = New User("Andreu", "Sala", "Krotus", "1234", New Roman("Roman Town"))
        'Dim account2 = New User("Marc", "Perez", "Mperez", "4321", New Teuton("Teuton Town"))
        For i = 1 To 9
            Dim account = New User("Name" & i, "Surname" & i, "username" & i, "password" & i, New Teuton("Teuton Town"))
            Me.addUser(account)
        Next i
        'Empires
        Dim romanEmpire As New Roman("Romans", 4999, 1000)
        Dim teutonsEmpire As New Teuton("Teutons", 6400, 1000)
        Dim gaulEmpire As New Gaul("Gauls", 5234, 1000)

        'Types of Soldiers
        Dim legionary As New Knight("Legionary", 40, 35, 120, romanEmpire) 'name, attack, defense, cost, empire
        Dim equitesImperatoris As New Cavalry("Equites Imperatoris", 120, 65, 550, romanEmpire)
        Dim archerCaesaris As New Archer("Archer Caesaris", 70, 20, 150, romanEmpire)

        romanEmpire.addSoldier(legionary)
        romanEmpire.addSoldier(equitesImperatoris)
        romanEmpire.addSoldier(archerCaesaris)

        Dim clubSwinger As New Knight("Clubswinger", 40, 20, 95, teutonsEmpire)
        Dim paladin As New Cavalry("Paladin", 55, 100, 370, teutonsEmpire)
        Dim crossbowman As New Archer("Crossbowman", 60, 30, 130, teutonsEmpire)

        teutonsEmpire.addSoldier(clubSwinger)
        teutonsEmpire.addSoldier(paladin)
        teutonsEmpire.addSoldier(crossbowman)

        Dim phalanx As New Knight("Phalanx", 25, 40, 100, gaulEmpire)
        Dim theutatesThunder As New Cavalry("Theutates Thunder", 90, 25, 350, gaulEmpire)
        Dim archerIce As New Archer("Archer Ice", 65, 35, 140, gaulEmpire)

        gaulEmpire.addSoldier(phalanx)
        gaulEmpire.addSoldier(theutatesThunder)
        gaulEmpire.addSoldier(archerIce)

        'add Empires with its soldiers
        Me.addEmpire(romanEmpire)
        Me.addEmpire(teutonsEmpire)
        Me.addEmpire(gaulEmpire)
    End Sub

    Public Function getUserByLogin(ByVal username As String, ByVal password As String) As User
        Dim _user As User
        For Each user In pUsers
            If user.authenticate(username, password) = True Then
                _user = user
            End If
        Next
        Return _user
    End Function

End Class
