Public Class Battle
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Request.QueryString IsNot Nothing Then
            'MsgBox(Request.Form("ctl00$MainContent$tbQuantity3"))
            'MsgBox(Request.QueryString("player"))
        End If

    End Sub

End Class