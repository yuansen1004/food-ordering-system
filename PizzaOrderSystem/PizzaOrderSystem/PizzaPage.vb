Public Class PizzaSec
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub LogoButton_Click(sender As Object, e As EventArgs) Handles LogoButton.Click
        SystemMain.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PizzaForm1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PizzaForm2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PizzaForm3.Show()
    End Sub

    Private Sub SIdeButton_Click(sender As Object, e As EventArgs) Handles SidesButton.Click
        SidesPage.Show()
        Me.Close()
    End Sub

    Private Sub DrinkButton_Click(sender As Object, e As EventArgs) Handles DrinksButton.Click
        DrinksPage.Show()
        Me.Close()
    End Sub

    Private Sub BillButton_Click(sender As Object, e As EventArgs) Handles BillButton.Click
        BillPage.Show()
        Me.Close()
    End Sub
End Class