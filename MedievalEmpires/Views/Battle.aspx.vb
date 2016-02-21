Public Class Battle
    Inherits System.Web.UI.Page

    Public account As User
    Public game As MedievalEmpires
    Public listSoldiers As List(Of Soldier)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then

        End If
    End Sub
    Public Function paintTableBattle(ByVal listSoldiers As List(Of Soldier)) As String
        Dim str As String = ""
        str += "<table class='table'>
                        <thead style='color:white; background-color: rgba(0, 0, 0, 0.8);'>
                            <tr>
                                <th>Roman</th>
                            </tr>
                        </thead>
                        <tbody>"
        Dim i As Integer = 1
        For Each soldier In listSoldiers
            str += "<tr>
                           <td>" & soldier.pName & "</td>
                           <td>" & soldier.pEmpire.pPopulation & "</td>
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
End Class