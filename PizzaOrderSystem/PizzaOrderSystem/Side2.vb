﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class SideForm2
    Private Sub textclear()
        TextBox1.Text = String.Empty
    End Sub
    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        textclear()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        Dim price As Double = 5
        Dim quantity As Double = 0
        Dim tprice As Double = 0

        quantity = TextBox1.Text
        tprice = quantity * price

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
            outFile.WriteLine(tprice)
            outFile.Close()
        End If
        If (TextBox1.Text = "") Then
            MessageBox.Show("Please enter a quantity.")
        Else
            outFile = IO.File.AppendText("C:\VB\quantity.txt")
            outFile.WriteLine(TextBox1.Text)
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