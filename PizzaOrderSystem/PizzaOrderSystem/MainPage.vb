Public Class SystemMain
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub PizzaButton_Click(sender As Object, e As EventArgs) Handles PizzaButton.Click
        PizzaSec.Show()
        Me.Close()
    End Sub

    Private Sub SIdeButton_Click(sender As Object, e As EventArgs) Handles SIdeButton.Click
        SidesPage.Show()
        Me.Close()
    End Sub

    Private Sub DrinkButton_Click(sender As Object, e As EventArgs) Handles DrinkButton.Click
        DrinksPage.Show()
        Me.Close()
    End Sub

    Private Sub BillButton_Click(sender As Object, e As EventArgs) Handles BillButton.Click
        BillPage.Show()
        Me.Close()
    End Sub
End Class
