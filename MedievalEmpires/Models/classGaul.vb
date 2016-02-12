Public Class Gaul
    Inherits Empire

    Public Sub New(name As String)
        MyBase.New(name, 0, 0)
    End Sub

    Public Sub New(name As String, population As Integer, coins As Integer)
        MyBase.New(name, population, coins)
    End Sub

    Public Overrides Function buySoldier(soldier As Soldier) As Boolean
        Dim bought As Boolean = False
        If soldier.pEmpire.GetType Is Me.GetType Then
            pCoins = pCoins - soldier.pPrice
            If pCoins < 0 Then
                bought = False
            Else
                pSoldiers.Add(soldier)
                bought = True
            End If
        Else
            Throw New Exception("You can't buy a soldier that not belongs this empire.")
        End If
        Return bought
    End Function
End Class
