Public Class Dashboard
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim game As MedievalEmpires
        game = CType(Session("BoME"), MedievalEmpires)

    End Sub

End Class