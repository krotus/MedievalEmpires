Public Class Map
    Inherits System.Web.UI.Page

    Public account As User
    Public game As MedievalEmpires
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            account = CType(Session("User"), User)
            game = CType(Session("BoME"), MedievalEmpires)
            Dim str As String = "<div id='map'>
                                      <h2>BATTLE MAP</h2>
                                      <div id = 'fila1' Class='fila fila-side'>"
            Dim cont = 2 ' a 2 perque la primera fila ja esta pintada
            For i = 1 To game.pUsers.Count
                Dim account As User = game.pUsers.Item(i - 1)

                str += "<div id = 'col" & i & "' Class='column col-side tooltip'>
                                              <span>
                                                  <h3>" & account.pEmpire.pName & "</h3>
                                                  <p>Player : " & account.pUsername & "</p>
                                                  <p>Population :  " & account.pEmpire.pPopulation & "</p>
                                                  <p>Empire : " & account.pEmpire.getTypeEmpire() & "</p>
                                              </span>
                                          </div>"
                If (i Mod 3) = 0 Then
                    str += "</div>" 'Salt a la següent fila
                    If i < game.pUsers.Count - 1 Then 'Fem més lineas sempre i quan tinguem usuaris a mostrar
                        str += "<div id = 'fila" & cont & "' Class='fila fila-side'>"
                        cont += 1
                    End If

                End If
            Next i
            str += "</div>" 'Div close map
            dynamicContent.Text = str
        End If

    End Sub

End Class