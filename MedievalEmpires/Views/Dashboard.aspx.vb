Public Class Dashboard
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Session("User") = New User("Andreu", "Sala", "Krotus", "1234", New Roman("Roman Town"))

    End Sub

End Class