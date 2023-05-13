Public Class DrinksPage
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub PizzaButton_Click(sender As Object, e As EventArgs) Handles PizzaButton.Click
        PizzaSec.Show()
        Me.Close()
    End Sub

    Private Sub SIdeButton_Click(sender As Object, e As EventArgs) Handles SidesButton.Click
        SidesPage.Show()
        Me.Close()
    End Sub

    Private Sub BillButton_Click(sender As Object, e As EventArgs) Handles BillButton.Click
        BillPage.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DrinkForm1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DrinkForm2.Show()
    End Sub

    Private Sub LogoButton_Click(sender As Object, e As EventArgs) Handles LogoButton.Click
        SystemMain.Show()
        Me.Close()
    End Sub
End Class