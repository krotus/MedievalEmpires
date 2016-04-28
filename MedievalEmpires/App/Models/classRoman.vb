Public Class Roman
    Inherits Empire

    Public Event spendCoins(ByVal coins As Integer)
    Public Sub New(name As String)
        MyBase.New(name, 0, 999)
    End Sub

    Public Sub New(name As String, population As Integer, coins As Integer)
        MyBase.New(name, population, coins)
    End Sub

    Public Overrides Sub buySoldier(soldier As Soldier)

        If soldier.pEmpire.GetType Is Me.GetType Then
            pCoins = pCoins - soldier.pPrice
            If pCoins < 0 Then
                RaiseEvent spendCoins(pCoins)
            Else
                pSoldiers.Add(soldier)
            End If
        End If
    End Sub

    Private Sub Empire_spendCoins(ByVal coins As Integer) Handles Me.spendCoins
        Throw New System.Exception("You don't have enough golds to buy soldiers.")
    End Sub
End Class
