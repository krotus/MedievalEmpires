Public Class Result
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            account = CType(Session("User"), User)
            game = CType(Session("BoME"), MedievalEmpires)
            lblTableAttacker.Text = paintTableResultAttacker()
            lblTableDefender.Text = paintTableResultDefender()
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("Dashboard.aspx")
    End Sub

    Public Function paintTableResultAttacker() As String
        Dim str As String = ""
        str += "<table class='table'>
                        <thead style='color:white; background-color: rgba(0, 0, 0, 0.8);'>
                            <tr><th>Name</th>"
        Dim i As Integer = 0
        For Each ob In listResultAttack
            Dim obs As Soldier = ob.Item(0)
            str += "<th>" & obs.pName & "</th>"
        Next
        str += "</tr>
            </thead>
            <tbody>"
        str += "<tr><td>Troops</td>"
        For Each ob In listResultAttack
            Dim obq As Integer = ob.Item(1)
            str += "<td>" & obq & "</td>"
        Next
        str += "</tr>"
        str += "<tr><td>Losts</td>"
        For Each ob In listResultAttack
            Dim obd As Integer = ob.Item(2)
            str += "<td>" & obd & "</td>"
        Next
        str += "<tr><td>Survivors</td>"
        For Each ob In listResultAttack
            Dim obd As Integer = ob.Item(3)
            str += "<td>" & obd & "</td>"
        Next
        str += "</tr>
            </tbody>
        </table>"
        Return str
    End Function

    Public Function paintTableResultDefender() As String
        Dim str As String = ""
        str += "<table class='table'>
                        <thead style='color:white; background-color: rgba(0, 0, 0, 0.8);'>
                            <tr><th>Name</th>"
        Dim i As Integer = 0
        For Each ob In listResultDefend
            Dim obs As Soldier = ob.Item(0)
            str += "<th>" & obs.pName & "</th>"
        Next
        str += "</tr>
            </thead>
            <tbody>"
        str += "<tr><td>Troops</td>"
        For Each ob In listResultDefend
            Dim obq As Integer = ob.Item(1)
            str += "<td>" & obq & "</td>"
        Next
        str += "</tr>"
        str += "<tr><td>Losts</td>"
        For Each ob In listResultDefend
            Dim obd As Integer = ob.Item(2)
            str += "<td>" & obd & "</td>"
        Next
        str += "<tr><td>Survivors</td>"
        For Each ob In listResultDefend
            Dim obd As Integer = ob.Item(3)
            str += "<td>" & obd & "</td>"
        Next
        str += "</tr>
            </tbody>
        </table>"
        Return str
    End Function
End Class