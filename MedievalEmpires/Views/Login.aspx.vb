Public Class Login1
    Inherits System.Web.UI.Page

    Dim game As MedievalEmpires
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            If Session("BoME") Is Nothing Then
                game = New MedievalEmpires()
                game.populate()
                Session("BoME") = game
            End If
        End If
    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Recollim de la sessió BoME el videojoc
        game = CType(Session("BoME"), MedievalEmpires)
        'Obtenim un "usuari" a partir dels parametres
        Dim user As User = game.getUserByLogin(tbUsername.Text, tbPassword.Text)
        If user IsNot Nothing Then
            If Session("User") IsNot Nothing Then
                Session.Remove("User") 'Eliminem la sessió user si estigues inicialitzada
            End If
            Session("User") = user
            Response.Redirect("Dashboard")
        Else
        End If
    End Sub
End Class