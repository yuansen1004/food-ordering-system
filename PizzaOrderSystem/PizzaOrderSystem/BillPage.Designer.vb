<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BillPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BillPage))
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.LogoButton = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BillButton = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DrinksButton = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.SidesButton = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PizzaButton = New System.Windows.Forms.Button()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.Items = New System.Windows.Forms.ListBox()
        Me.Quantity = New System.Windows.Forms.ListBox()
        Me.Sizes = New System.Windows.Forms.ListBox()
        Me.Crust = New System.Windows.Forms.ListBox()
        Me.Price = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.MenuPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.BackColor = System.Drawing.Color.Firebrick
        Me.MenuPanel.Controls.Add(Me.LogoButton)
        Me.MenuPanel.Controls.Add(Me.Panel2)
        Me.MenuPanel.Controls.Add(Me.BillButton)
        Me.MenuPanel.Controls.Add(Me.Panel3)
        Me.MenuPanel.Controls.Add(Me.ExitButton)
        Me.MenuPanel.Controls.Add(Me.Panel4)
        Me.MenuPanel.Controls.Add(Me.DrinksButton)
        Me.MenuPanel.Controls.Add(Me.Panel5)
        Me.MenuPanel.Controls.Add(Me.SidesButton)
        Me.MenuPanel.Controls.Add(Me.Panel6)
        Me.MenuPanel.Controls.Add(Me.PizzaButton)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(245, 569)
        Me.MenuPanel.TabIndex = 38
        '
        'LogoButton
        '
        Me.LogoButton.BackColor = System.Drawing.Color.Coral
        Me.LogoButton.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.LogoButton.FlatAppearance.BorderSize = 0
        Me.LogoButton.Image = CType(resources.GetObject("LogoButton.Image"), System.Drawing.Image)
        Me.LogoButton.Location = New System.Drawing.Point(57, 5)
        Me.LogoButton.Name = "LogoButton"
        Me.LogoButton.Size = New System.Drawing.Size(118, 72)
        Me.LogoButton.TabIndex = 12
        Me.LogoButton.Text = "PIzzaGo!"
        Me.LogoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.LogoButton.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Coral
        Me.Panel2.Location = New System.Drawing.Point(0, 304)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(12, 67)
        Me.Panel2.TabIndex = 9
        '
        'BillButton
        '
        Me.BillButton.FlatAppearance.BorderSize = 0
        Me.BillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BillButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BillButton.ForeColor = System.Drawing.SystemColors.Control
        Me.BillButton.Image = CType(resources.GetObject("BillButton.Image"), System.Drawing.Image)
        Me.BillButton.Location = New System.Drawing.Point(0, 304)
        Me.BillButton.Name = "BillButton"
        Me.BillButton.Size = New System.Drawing.Size(242, 67)
        Me.BillButton.TabIndex = 10
        Me.BillButton.Text = "    Bill"
        Me.BillButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BillButton.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Coral
        Me.Panel3.Location = New System.Drawing.Point(0, 378)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(12, 67)
        Me.Panel3.TabIndex = 7
        '
        'ExitButton
        '
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Image = CType(resources.GetObject("ExitButton.Image"), System.Drawing.Image)
        Me.ExitButton.Location = New System.Drawing.Point(0, 378)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(242, 67)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "    Exit"
        Me.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Coral
        Me.Panel4.Location = New System.Drawing.Point(0, 231)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(12, 67)
        Me.Panel4.TabIndex = 5
        '
        'DrinksButton
        '
        Me.DrinksButton.FlatAppearance.BorderSize = 0
        Me.DrinksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DrinksButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DrinksButton.ForeColor = System.Drawing.SystemColors.Control
        Me.DrinksButton.Image = CType(resources.GetObject("DrinksButton.Image"), System.Drawing.Image)
        Me.DrinksButton.Location = New System.Drawing.Point(0, 231)
        Me.DrinksButton.Name = "DrinksButton"
        Me.DrinksButton.Size = New System.Drawing.Size(242, 67)
        Me.DrinksButton.TabIndex = 6
        Me.DrinksButton.Text = "     Drinks"
        Me.DrinksButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DrinksButton.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Coral
        Me.Panel5.Location = New System.Drawing.Point(0, 158)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(12, 67)
        Me.Panel5.TabIndex = 3
        '
        'SidesButton
        '
        Me.SidesButton.FlatAppearance.BorderSize = 0
        Me.SidesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SidesButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SidesButton.ForeColor = System.Drawing.SystemColors.Control
        Me.SidesButton.Image = CType(resources.GetObject("SidesButton.Image"), System.Drawing.Image)
        Me.SidesButton.Location = New System.Drawing.Point(0, 158)
        Me.SidesButton.Name = "SidesButton"
        Me.SidesButton.Size = New System.Drawing.Size(242, 67)
        Me.SidesButton.TabIndex = 4
        Me.SidesButton.Text = "     Sides"
        Me.SidesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SidesButton.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Coral
        Me.Panel6.Location = New System.Drawing.Point(0, 84)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(12, 67)
        Me.Panel6.TabIndex = 2
        '
        'PizzaButton
        '
        Me.PizzaButton.FlatAppearance.BorderSize = 0
        Me.PizzaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PizzaButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PizzaButton.ForeColor = System.Drawing.SystemColors.Control
        Me.PizzaButton.Image = CType(resources.GetObject("PizzaButton.Image"), System.Drawing.Image)
        Me.PizzaButton.Location = New System.Drawing.Point(0, 84)
        Me.PizzaButton.Name = "PizzaButton"
        Me.PizzaButton.Size = New System.Drawing.Size(242, 67)
        Me.PizzaButton.TabIndex = 2
        Me.PizzaButton.Text = "     Pizza"
        Me.PizzaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PizzaButton.UseVisualStyleBackColor = True
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.TopPanel.Location = New System.Drawing.Point(16, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1332, 43)
        Me.TopPanel.TabIndex = 37
        '
        'Items
        '
        Me.Items.Font = New System.Drawing.Font("Arial Narrow", 12.096!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Items.FormattingEnabled = True
        Me.Items.ItemHeight = 25
        Me.Items.Location = New System.Drawing.Point(251, 95)
        Me.Items.Name = "Items"
        Me.Items.Size = New System.Drawing.Size(208, 454)
        Me.Items.TabIndex = 46
        '
        'Quantity
        '
        Me.Quantity.Font = New System.Drawing.Font("Arial Narrow", 12.096!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Quantity.FormattingEnabled = True
        Me.Quantity.ItemHeight = 25
        Me.Quantity.Location = New System.Drawing.Point(465, 95)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(137, 454)
        Me.Quantity.TabIndex = 47
        '
        'Sizes
        '
        Me.Sizes.Font = New System.Drawing.Font("Arial Narrow", 12.096!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Sizes.FormattingEnabled = True
        Me.Sizes.ItemHeight = 25
        Me.Sizes.Location = New System.Drawing.Point(608, 95)
        Me.Sizes.Name = "Sizes"
        Me.Sizes.Size = New System.Drawing.Size(213, 454)
        Me.Sizes.TabIndex = 48
        '
        'Crust
        '
        Me.Crust.Font = New System.Drawing.Font("Arial Narrow", 12.096!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Crust.FormattingEnabled = True
        Me.Crust.ItemHeight = 25
        Me.Crust.Location = New System.Drawing.Point(827, 95)
        Me.Crust.Name = "Crust"
        Me.Crust.Size = New System.Drawing.Size(247, 454)
        Me.Crust.TabIndex = 49
        '
        'Price
        '
        Me.Price.Font = New System.Drawing.Font("Arial Narrow", 12.096!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Price.FormattingEnabled = True
        Me.Price.ItemHeight = 25
        Me.Price.Location = New System.Drawing.Point(1080, 95)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(220, 379)
        Me.Price.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Firebrick
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.096!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(251, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 27)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Items"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Firebrick
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.096!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(465, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 27)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Quantity"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Firebrick
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.096!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(608, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 27)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Size"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Firebrick
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.096!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(827, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 27)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Crust"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Firebrick
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.096!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1080, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 27)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Price"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 13.824!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1080, 480)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(220, 69)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Print Bill"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'BillPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1312, 569)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Crust)
        Me.Controls.Add(Me.Sizes)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.Items)
        Me.Controls.Add(Me.MenuPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BillPage"
        Me.Text = "BillPage"
        Me.MenuPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuPanel As Panel
    Friend WithEvents LogoButton As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BillButton As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ExitButton As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DrinksButton As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents SidesButton As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PizzaButton As Button
    Friend WithEvents TopPanel As Panel
    Friend WithEvents Items As ListBox
    Friend WithEvents Quantity As ListBox
    Friend WithEvents Sizes As ListBox
    Friend WithEvents Crust As ListBox
    Friend WithEvents Price As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
