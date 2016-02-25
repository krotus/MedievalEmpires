Public Class Battle
    Inherits System.Web.UI.Page

    Public account As User
    Public game As MedievalEmpires
    Public listSoldiers As List(Of Soldier)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            account = CType(Session("User"), User)
            game = CType(Session("BoME"), MedievalEmpires)
            lblArmyToFight.Text = paintTableBattle()
        End If
    End Sub
    Public Function paintTableBattle() As String
        Dim str As String = ""
        Dim i As Integer = 1
        str += "<ul class='list-group'>"
        For Each soldierType In game.getSoldiersByEmpire(account.pEmpire)
            Dim countSoldiers As Integer = 0
            str += "<li class='list-group-item'><span>" & soldierType.pName & "</span>"
            For Each soldier In account.pEmpire.pSoldiers
                If soldierType.pName = soldier.pName Then
                    countSoldiers += 1
                End If
            Next
            str += "<input name='ctl00$MainContent$tbQuantity" & i & "' type='number' id='MainContent_tbQuantity" & i & "' class='form-control' value='0' />"
            str += " / "
            str += "<span style='font-weight:bold'>" & countSoldiers & "</span>"
            str += "</li>"
            i += 1
        Next
        str += "</ul>"
        Return str
    End Function
End Class