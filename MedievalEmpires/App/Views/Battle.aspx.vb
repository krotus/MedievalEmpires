Public Class Battle
    Inherits System.Web.UI.Page

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

    Public Function battle()
        game = CType(Session("BoME"), MedievalEmpires)
        account = CType(Session("User"), User)
        Dim enemyName As String = Request.QueryString("player")
        enemy = game.getUserByUsername(enemyName)


        'Calcul del attack i la defensa per la batalla
        Dim ptsDamage As Integer = 0 'total attack you have
        Dim i As Integer = 1
        For Each soldierType In game.getSoldiersByEmpire(account.pEmpire)

            Dim q As Integer = CInt(Request.Form("ctl00$MainContent$tbQuantity" & i))
            For Each soldier In account.pEmpire.pSoldiers
                If soldierType.pName = soldier.pName Then
                    q = q * soldier.pAttack
                    Exit For
                End If
            Next
            ptsDamage += q
            i += 1
        Next
        Dim ptsDefense As Integer = enemy.pEmpire.getTotalDefense() 'total defense enemy has

        'Algorisme resultant de la llista de soldats enemics vius despres de la batalla
        listResultDefend.Clear()
        i = 0
        For Each soldierType In game.getSoldiersByEmpire(enemy.pEmpire)
            Dim s As Soldier 'soldat
            Dim q As Integer = 0
            For Each soldier In enemy.pEmpire.pSoldiers
                If soldierType.pName = soldier.pName Then
                    q += 1
                End If
            Next
            listResultDefend.Add(New List(Of Object))
            listResultDefend.Item(i).Add(soldierType) 'soldat
            listResultDefend.Item(i).Add(q) 'quantitat
            listResultDefend.Item(i).Add(0) 'morts (per més endevant)
            listResultDefend.Item(i).Add(q) 'supervivents (de moment la quantitat que s'envien)
            i += 1
        Next
        Dim hurtDefense As Integer = ptsDefense - ptsDamage
        If hurtDefense <= 0 Then
            enemy.pEmpire.pSoldiers.Clear() 'Han mort tots els soldats que defensaven (enemic)
            For Each ob In listResultDefend
                Dim sold As Soldier = ob.Item(0) 'soldat
                ob.Item(3) = 0 'quantitat de supervivents es igual a 0
                ob.Item(2) = ob.Item(1) 'quantitat de morts es igual a la quantitat de soldats
                Dim morts = ob.Item(2) 'morts
                Dim soldiersReal As Integer = 0
                For Each soldier In account.pEmpire.pSoldiers
                    If soldier.pName = sold.pName Then
                        soldiersReal += 1
                    End If
                Next
            Next
        Else 'hi han supervivents
            Dim diff As Integer = ptsDefense - hurtDefense
            For Each ob In listResultDefend
                Dim sold As Soldier = ob.Item(0) 'soldat
                Dim quantity = ob.Item(1) 'quantiat
                Dim morts = ob.Item(2) 'morts
                Dim survivors = ob.Item(3) 'supervivents
                Dim cont As Integer = 0
                If quantity <> 0 Then
                    For k As Integer = 0 To quantity - 1
                        If sold.pDefense <= diff Then
                            diff -= sold.pDefense
                        Else
                            cont += 1
                        End If
                    Next
                End If
                morts = quantity - cont
                survivors = cont
                ob.Item(1) = quantity
                ob.Item(2) = morts
                ob.Item(3) = survivors
            Next

            Dim copyEnemySoldiers As New List(Of Soldier) From {}
            For Each ob In listResultDefend
                Dim sold As Soldier = ob.Item(0) 'soldat
                Dim quantity = ob.Item(1) 'quantiat
                Dim morts = ob.Item(2) 'morts
                Dim soldiersReal As Integer = 0
                For Each soldier In enemy.pEmpire.pSoldiers
                    If soldier.pName = sold.pName Then
                        soldiersReal += 1
                    End If
                Next
                soldiersReal -= morts 'número de soldats vius d'un tipus especific 
                For l As Integer = 0 To soldiersReal - 1
                    copyEnemySoldiers.Add(sold) 'afegim al a la llista de copia
                Next
            Next
            enemy.pEmpire.pSoldiers = copyEnemySoldiers 'actualitzem els soldats
        End If





        'Algorisme resultant de la llista dels soldats atacants vius despres de la batalla
        listResultAttack.Clear()
        i = 0
        For Each soldierType In game.getSoldiersByEmpire(account.pEmpire)
            Dim s As Soldier 'soldat
            Dim q As Integer = CInt(Request.Form("ctl00$MainContent$tbQuantity" & i + 1)) 'quantitat
            For Each soldier In account.pEmpire.pSoldiers
                If soldierType.pName = soldier.pName Then
                    s = soldier
                    Exit For
                End If
            Next
            listResultAttack.Add(New List(Of Object))
            listResultAttack.Item(i).Add(soldierType) 'soldat
            listResultAttack.Item(i).Add(q) 'quantitat
            listResultAttack.Item(i).Add(0) 'morts (per més endevant)
            listResultAttack.Item(i).Add(q) 'supervivents (de moment la quantitat que s'envien)
            i += 1
        Next
        Dim hurtAttack As Integer = ptsDamage - ptsDefense
        If hurtAttack <= 0 Then
            'moren tots els soldats que has enviat
            Dim copyAttackSoldiers As New List(Of Soldier) From {}
            For Each ob In listResultAttack
                Dim sold As Soldier = ob.Item(0) 'soldat
                ob.Item(3) = 0 'quantitat de supervivents es igual a 0
                ob.Item(2) = ob.Item(1) 'quantitat de morts es igual a la quantitat de soldats
                Dim morts = ob.Item(2) 'morts
                Dim soldiersReal As Integer = 0
                For Each soldier In account.pEmpire.pSoldiers
                    If soldier.pName = sold.pName Then
                        soldiersReal += 1
                    End If
                Next
                soldiersReal -= morts 'número de soldats vius d'un tipus especific 
                For l As Integer = 0 To soldiersReal - 1
                    copyAttackSoldiers.Add(sold) 'afegim al a la llista de copia
                Next
            Next
            account.pEmpire.pSoldiers = copyAttackSoldiers 'actualitzem els soldats
        Else 'hi han supervivents
            i = 0
            Dim diff2 = ptsDamage - Math.Abs(hurtAttack)
            For Each ob In listResultAttack
                Dim sold As Soldier = ob.Item(0) 'soldat
                Dim quantity = ob.Item(1) 'quantiat
                Dim morts = ob.Item(2) 'morts
                Dim survivors = ob.Item(3) 'supervivents
                Dim cont As Integer = 0
                If quantity <> 0 Then
                    For k As Integer = 0 To quantity - 1
                        If sold.pAttack <= diff2 Then
                            diff2 -= sold.pAttack
                        Else
                            cont += 1
                        End If
                    Next
                End If
                morts = quantity - cont
                survivors = cont
                ob.Item(1) = quantity
                ob.Item(2) = morts
                ob.Item(3) = survivors
            Next

            Dim copyAttackSoldiers As New List(Of Soldier) From {}
            For Each ob In listResultAttack
                Dim sold As Soldier = ob.Item(0) 'soldat
                Dim quantity = ob.Item(1) 'quantiat
                Dim morts = ob.Item(2) 'morts
                Dim soldiersReal As Integer = 0
                For Each soldier In account.pEmpire.pSoldiers
                    If soldier.pName = sold.pName Then
                        soldiersReal += 1
                    End If
                Next
                soldiersReal -= morts 'número de soldats vius d'un tipus especific 
                For l As Integer = 0 To soldiersReal - 1
                    copyAttackSoldiers.Add(sold) 'afegim al a la llista de copia
                Next
            Next

            account.pEmpire.pSoldiers = copyAttackSoldiers 'actualitzem els soldats
        End If

        Response.Redirect("Result.aspx")
        MsgBox("You:  " & account.pEmpire.pSoldiers.Count & vbNewLine &
               "Enemy: " & enemy.pEmpire.pSoldiers.Count)
    End Function

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        battle()
    End Sub
End Class