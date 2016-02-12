Public Class Battle
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim patata As User = CType(Session("User"), User)
        MsgBox(patata.pName)
    End Sub

End Class