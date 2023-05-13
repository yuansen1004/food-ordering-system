Imports System.Drawing.Printing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class BillPage
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

    Private Sub DrinkButton_Click(sender As Object, e As EventArgs) Handles DrinksButton.Click
        DrinksPage.Show()
        Me.Close()
    End Sub

    Private Sub BillPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inFile As IO.StreamReader
        If (IO.File.Exists("C:\VB\item.txt") = True) Then
            inFile = IO.File.OpenText("C:\VB\item.txt")
            Do Until inFile.Peek = -1
                Items.Items.Add(inFile.ReadLine)
            Loop
            inFile.Close()
        Else
            MessageBox.Show("item file not exist.")
        End If
        If (IO.File.Exists("C:\VB\quantity.txt") = True) Then
            inFile = IO.File.OpenText("C:\VB\quantity.txt")
            Do Until inFile.Peek = -1
                Quantity.Items.Add(inFile.ReadLine)
            Loop
            inFile.Close()
        Else
            MessageBox.Show("quantity file not exist.")
        End If
        If (IO.File.Exists("C:\VB\size.txt") = True) Then
            inFile = IO.File.OpenText("C:\VB\size.txt" + " ")
            Do Until inFile.Peek = -1
                Sizes.Items.Add(inFile.ReadLine)
            Loop
            inFile.Close()
        Else
            MessageBox.Show("size file not exist.")
        End If
        If (IO.File.Exists("C:\VB\crust.txt") = True) Then
            inFile = IO.File.OpenText("C:\VB\crust.txt")
            Do Until inFile.Peek = -1
                Crust.Items.Add(inFile.ReadLine)
            Loop
            inFile.Close()
        Else
            MessageBox.Show("crust file not exist.")
        End If
        If (IO.File.Exists("C:\VB\price.txt") = True) Then
            inFile = IO.File.OpenText("C:\VB\price.txt")
            Do Until inFile.Peek = -1
                Price.Items.Add("RM" + inFile.ReadLine)
            Loop
            inFile.Close()
        Else
            MessageBox.Show("price file not exist.")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim f12 As New Font("Arial", 12, FontStyle.Bold)
        Dim f30 As New Font("Arial", 30, FontStyle.Bold)

        Dim centermargin As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width / 3
        Dim leftmargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Left

        Dim center As New StringFormat
        Dim height As Integer 'DGV Position
        e.Graphics.DrawString("Pizza Ordering System", f12, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString(" ", f30, Brushes.Black, leftmargin, 35, center)
        e.Graphics.DrawString("Items", f12, Brushes.Black, leftmargin, 50, center)
        e.Graphics.DrawString("Quantity", f12, Brushes.Black, centermargin, 50, center)
        e.Graphics.DrawString("Price", f12, Brushes.Black, 600, 50, center)

        For row As Integer = 0 To Items.Items.Count - 1
            height += 15
            e.Graphics.DrawString(Items.Items(row), f12, Brushes.Black, leftmargin, 100 + height)
            e.Graphics.DrawString(Quantity.Items(row), f12, Brushes.Black, centermargin, 100 + height)
            e.Graphics.DrawString(Price.Items(row), f12, Brushes.Black, 600, 100 + height)
        Next
    End Sub

    Private Sub LogoButton_Click(sender As Object, e As EventArgs) Handles LogoButton.Click
        SystemMain.Show()
        Me.Close()
    End Sub
End Class