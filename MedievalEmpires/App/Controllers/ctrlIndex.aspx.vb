Public Class ctrlIndex
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            If Session("BoME") Is Nothing Then
                game.populate()
                Session("BoME") = game
                Response.Redirect("../Views/Login.aspx")
            End If
        End If
    End Sub

End Class