Public Class Cavalry
    Inherits Soldier

    Public Sub New(name As String, attack As Integer, defense As Integer, price As Integer, empire As Empire)
        MyBase.New(name, attack, defense, price, empire)
    End Sub

End Class
