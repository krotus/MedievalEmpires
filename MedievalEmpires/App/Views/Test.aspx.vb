Public Class Test
    Inherits System.Web.UI.Page
    Public game As MedievalEmpires
    Public account As User
    Public account2 As User
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        account = New User("Andreu", "Sala", "Krotus", "1234", New Roman("Roman Town"))
        account2 = New User("Marc", "Perez", "Mperez", "4321", New Teuton("Teuton Town"))
        game.populate()
    End Sub

    Protected Sub btnRomanTroops_Click(sender As Object, e As EventArgs) Handles btnRomanTroops.Click
        Dim romanTroops As String = ""
        For Each empire In game.pEmpires
            'If TypeOf empire Is Roman Then
            'End If

            For Each soldier In empire.pSoldiers
                Dim type = account.pEmpire.GetType
                If soldier.pEmpire.GetType Is account.pEmpire.GetType Then
                    romanTroops += soldier.pName
                End If
            Next
        Next
        'MsgBox(romanTroops)
    End Sub
End Class