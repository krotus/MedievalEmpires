Public Class Map
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            account = CType(Session("User"), User)
            game = CType(Session("BoME"), MedievalEmpires)
            dynamicContent.Text = paintTableDynamic(game)
        End If
    End Sub

    Public Function paintTableDynamic(ByVal game As MedievalEmpires) As String
        'Taula 3x3
        Dim str As String = "<div id='map'>
                                      <h2>BATTLE MAP</h2>
                                      <div id = 'fila1' Class='fila fila-side'>"
        Dim cont = 2 ' a 2 perque la primera fila ja esta pintada
        Dim classColumn As String = "column col-side tooltip"
        For i = 1 To game.pUsers.Count
            Dim account As User = game.pUsers.Item(i - 1)

            str += "<div id = 'col" & i & "' class='" & classColumn & "'>
                                              <span>
                                                  <h3>" & account.pEmpire.pName & "</h3>
                                                  <p>Player : <span>" & account.pUsername & "</span></p>
                                                  <p>Population :  <span>" & account.pEmpire.pPopulation & "</span></p>
                                                  <p>Empire : <span>" & account.pEmpire.getTypeEmpire() & "</span></p>
                                              </span>
                                          </div>"
            If (i Mod 3) = 0 Then
                str += "</div>" 'Salt a la següent fila
                If i < game.pUsers.Count - 1 Then 'Fem més lineas sempre i quan tinguem usuaris a mostrar
                    If (cont Mod 2) = 0 Then 'Si es la fila parella 
                        str += "<div id = 'fila" & cont & "' class='fila'>"
                    Else
                        str += "<div id = 'fila" & cont & "' class='fila fila-side'>"
                        classColumn = "column col-side tooltip"
                    End If

                    cont += 1
                End If

            End If
        Next i
        str += "</div>" 'Div close map
        Return str
    End Function

End Class