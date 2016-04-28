Public Class Login1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Recollim de la sessió BoME el videojoc
        game = CType(Session("BoME"), MedievalEmpires)
        'Obtenim un "usuari" a partir dels parametres
        account = game.getUserByLogin(tbUsername.Text, tbPassword.Text)
        If user IsNot Nothing Then
            If Session("User") IsNot Nothing Then
                Session.Remove("User") 'Eliminem la sessió user si estigues inicialitzada
            End If
            Session("User") = account
            Response.Redirect("Dashboard")
        Else
        End If
    End Sub
End Class