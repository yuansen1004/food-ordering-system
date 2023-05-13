Public Class SidesPage
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub PizzaButton_Click(sender As Object, e As EventArgs) Handles PizzaButton.Click
        PizzaSec.Show()
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        SideForm1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        SideForm2.Show()
    End Sub

    Private Sub LogoButton_Click(sender As Object, e As EventArgs) Handles LogoButton.Click
        SystemMain.Show()
        Me.Close()
    End Sub
End Class