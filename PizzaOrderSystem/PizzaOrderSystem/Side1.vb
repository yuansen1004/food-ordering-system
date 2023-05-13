Public Class SideForm1
    Private Sub textclear()
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            ElseIf TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""
            End If
        Next
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        textclear()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim price As Double
        Dim quantity As Double
        If ComboBox1.SelectedIndex = 0 Then
            quantity = 5
        ElseIf ComboBox1.SelectedIndex = 1 Then
            quantity = 7
        Else ComboBox1.SelectedIndex = 2
            quantity = 9
        End If

        price = quantity

        Dim outFile As IO.StreamWriter
        If (Label1.Text = "") Then
            MessageBox.Show("Please enter an item.")
        Else
            outFile = IO.File.AppendText("C:\VB\item.txt")
            outFile.WriteLine(Label1.Text)
            outFile.Close()
        End If
        If (Label2.Text = "") Then
            MessageBox.Show("Please enter a price.")
        Else
            outFile = IO.File.AppendText("C:\VB\price.txt")
            outFile.WriteLine(price)
            outFile.Close()
        End If
        If (ComboBox1.Text = "") Then
            MessageBox.Show("Please enter a quantity.")
        Else
            outFile = IO.File.AppendText("C:\VB\quantity.txt")
            outFile.WriteLine(ComboBox1.Text)
            outFile.Close()
        End If

        outFile = IO.File.AppendText("C:\VB\size.txt")
        outFile.WriteLine(" ")
        outFile.Close()

        outFile = IO.File.AppendText("C:\VB\crust.txt")
        outFile.WriteLine(" ")
        outFile.Close()

        Me.Hide()
        Me.Close()
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        Me.Close()
    End Sub

End Class