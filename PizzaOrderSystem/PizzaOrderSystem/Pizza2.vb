Imports System.Reflection.Emit

Public Class PizzaForm2
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

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Dim pizza As Double = 11
        Dim quantity As Double = 0
        Double.TryParse(TextBox1.Text, quantity)
        Dim size As Double
        If ComboBox1.SelectedIndex = 0 Then
            size = 0
        ElseIf ComboBox1.SelectedIndex = 1 Then
            size = 2
        Else ComboBox1.SelectedIndex = 2
            size = 4
        End If

        Dim crust As Double
        If ComboBox2.SelectedIndex = 0 Then
            crust = 2
        ElseIf ComboBox2.SelectedIndex = 1 Then
            crust = 4
        Else ComboBox2.SelectedIndex = 2
            crust = 0
        End If

        Dim price As Double
        price = (size + crust + pizza) * quantity

        Dim outFile As IO.StreamWriter
        If (Label1.Text = "") Then
            MessageBox.Show("Please enter an item.")
        Else
            outFile = IO.File.AppendText("C:\VB\item.txt") 'VB access nameList.Text
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
        If (TextBox1.Text = "") Then
            MessageBox.Show("Please enter a quantity.")
        Else
            outFile = IO.File.AppendText("C:\VB\quantity.txt") 'VB access nameList.Text
            outFile.WriteLine(TextBox1.Text)
            outFile.Close()
        End If
        If (ComboBox1.Text = "") Then
            MessageBox.Show("Please enter a size.")
        Else
            outFile = IO.File.AppendText("C:\VB\size.txt") 'VB access nameList.Text
            outFile.WriteLine(ComboBox1.Text)
            outFile.Close()
        End If
        If (ComboBox2.Text = "") Then
            MessageBox.Show("Please enter a crust.")
        Else
            outFile = IO.File.AppendText("C:\VB\crust.txt") 'VB access nameList.Text
            outFile.WriteLine(ComboBox2.Text)
            outFile.Close()
        End If

        Me.Hide()
        Me.Close()
    End Sub
End Class