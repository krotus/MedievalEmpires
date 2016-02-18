Imports System.IO
Imports System.Net

Public Class Shop
    Inherits System.Web.UI.Page

    Public account As User
    Public game As MedievalEmpires
    Public listSoldiers As List(Of Soldier)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            account = CType(Session("User"), User)
            game = CType(Session("BoME"), MedievalEmpires)

            'Recollim nomes aquells soldats que pertanyen al imperi de l'usuari
            listSoldiers = game.getSoldiersByEmpire(account.pEmpire)
            'Pintem la taula shop
            lblTableShop.Text = paintTableShop(listSoldiers)

            'Pintem els soldats que tenim actualment al imperi
            Dim listCounts As List(Of Integer) = account.getForEachSoldiersHave(listSoldiers)
            lblListArmy.Text = paintListArmy(listSoldiers, listCounts)

            'Pintem els diners actuals del imperi
            lblCurrency.Text = paintCurrency(account)
        End If
    End Sub

    Public Function paintCurrency(ByVal account As User) As String
        Dim str As String = ""
        str += "<ul class='list-group'>
                    <li class='list-group-item'><span>" & account.pEmpire.pCoins & "</span> Golds</li>
                </ul>"
        Return str
    End Function

    Public Function paintListArmy(ByVal listSoldiers As List(Of Soldier), ByVal listCount As List(Of Integer)) As String
        Dim str As String = ""
        str += "<ul class='list-group'>"
        For i = 0 To listSoldiers.Count - 1
            str += "<li class='list-group-item'><span>" & listCount.Item(i) & "</span> " & listSoldiers.Item(i).pName & "</li>"
        Next
        str += "</ul'>"
        Return str
    End Function

    Public Function paintTableShop(ByVal listSoldiers As List(Of Soldier)) As String
        Dim str As String = ""
        str += "<table class='table'>
                        <thead style='color:white; background-color: rgba(0, 0, 0, 0.8);'>
                            <tr>
                                <th>Soldier</th>
                                <th>Cost</th>
                                <th>Quantity</th>
                            </tr>
                        </thead>
                        <tbody>"
        Dim i As Integer = 1
        For Each soldier In listSoldiers
            str += "<tr>
                           <td>" & soldier.pName & "</td>
                           <td>" & soldier.pPrice & "</td>
                           <td>
                               <input name='ctl00$MainContent$tbQuantity" & i & "' type='number' id='MainContent_tbQuantity" & i & "' class='form-control' />
                           </td>
                        </tr>"
            i += 1
        Next
        str += "</tbody>
                </table>"
        Return str
    End Function

    Protected Sub btnBuy_Click(sender As Object, e As EventArgs) Handles btnBuy.Click

        'For i = 0 To listSoldiers.Count - 1
        'MsgBox(Request.Form("ctl00$MainContent$tbQuantity" & i + 1))
        MsgBox(Request.Form)
        'Next i
        Server.Transfer("Battle.aspx", True)
    End Sub
End Class