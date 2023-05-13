<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SystemMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SystemMain))
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.LogoButton = New System.Windows.Forms.Button()
        Me.PanelOnBill = New System.Windows.Forms.Panel()
        Me.BillButton = New System.Windows.Forms.Button()
        Me.PanelOnExit = New System.Windows.Forms.Panel()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PanelOnDrinks = New System.Windows.Forms.Panel()
        Me.DrinkButton = New System.Windows.Forms.Button()
        Me.PanelOnSide = New System.Windows.Forms.Panel()
        Me.SIdeButton = New System.Windows.Forms.Button()
        Me.PanelOnPizza = New System.Windows.Forms.Panel()
        Me.PizzaButton = New System.Windows.Forms.Button()
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.MainPagePic = New System.Windows.Forms.PictureBox()
        Me.MenuPanel.SuspendLayout()
        CType(Me.MainPagePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.BackColor = System.Drawing.Color.Firebrick
        Me.MenuPanel.Controls.Add(Me.LogoButton)
        Me.MenuPanel.Controls.Add(Me.PanelOnBill)
        Me.MenuPanel.Controls.Add(Me.BillButton)
        Me.MenuPanel.Controls.Add(Me.PanelOnExit)
        Me.MenuPanel.Controls.Add(Me.ExitButton)
        Me.MenuPanel.Controls.Add(Me.PanelOnDrinks)
        Me.MenuPanel.Controls.Add(Me.DrinkButton)
        Me.MenuPanel.Controls.Add(Me.PanelOnSide)
        Me.MenuPanel.Controls.Add(Me.SIdeButton)
        Me.MenuPanel.Controls.Add(Me.PanelOnPizza)
        Me.MenuPanel.Controls.Add(Me.PizzaButton)
        Me.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuPanel.Location = New System.Drawing.Point(0, 0)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(218, 589)
        Me.MenuPanel.TabIndex = 0
        '
        'LogoButton
        '
        Me.LogoButton.BackColor = System.Drawing.Color.Coral
        Me.LogoButton.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.LogoButton.FlatAppearance.BorderSize = 0
        Me.LogoButton.Image = CType(resources.GetObject("LogoButton.Image"), System.Drawing.Image)
        Me.LogoButton.Location = New System.Drawing.Point(53, 5)
        Me.LogoButton.Name = "LogoButton"
        Me.LogoButton.Size = New System.Drawing.Size(105, 69)
        Me.LogoButton.TabIndex = 11
        Me.LogoButton.Text = "PIzzaGo!"
        Me.LogoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.LogoButton.UseVisualStyleBackColor = False
        '
        'PanelOnBill
        '
        Me.PanelOnBill.BackColor = System.Drawing.Color.Coral
        Me.PanelOnBill.Location = New System.Drawing.Point(0, 290)
        Me.PanelOnBill.Name = "PanelOnBill"
        Me.PanelOnBill.Size = New System.Drawing.Size(11, 64)
        Me.PanelOnBill.TabIndex = 9
        '
        'BillButton
        '
        Me.BillButton.FlatAppearance.BorderSize = 0
        Me.BillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BillButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BillButton.ForeColor = System.Drawing.SystemColors.Control
        Me.BillButton.Image = CType(resources.GetObject("BillButton.Image"), System.Drawing.Image)
        Me.BillButton.Location = New System.Drawing.Point(0, 290)
        Me.BillButton.Name = "BillButton"
        Me.BillButton.Size = New System.Drawing.Size(215, 64)
        Me.BillButton.TabIndex = 10
        Me.BillButton.Text = "    Bill"
        Me.BillButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BillButton.UseVisualStyleBackColor = True
        '
        'PanelOnExit
        '
        Me.PanelOnExit.BackColor = System.Drawing.Color.Coral
        Me.PanelOnExit.Location = New System.Drawing.Point(0, 360)
        Me.PanelOnExit.Name = "PanelOnExit"
        Me.PanelOnExit.Size = New System.Drawing.Size(11, 64)
        Me.PanelOnExit.TabIndex = 7
        '
        'ExitButton
        '
        Me.ExitButton.FlatAppearance.BorderSize = 0
        Me.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.Control
        Me.ExitButton.Image = CType(resources.GetObject("ExitButton.Image"), System.Drawing.Image)
        Me.ExitButton.Location = New System.Drawing.Point(0, 360)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(215, 64)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "    Exit"
        Me.ExitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PanelOnDrinks
        '
        Me.PanelOnDrinks.BackColor = System.Drawing.Color.Coral
        Me.PanelOnDrinks.Location = New System.Drawing.Point(0, 220)
        Me.PanelOnDrinks.Name = "PanelOnDrinks"
        Me.PanelOnDrinks.Size = New System.Drawing.Size(11, 64)
        Me.PanelOnDrinks.TabIndex = 5
        '
        'DrinkButton
        '
        Me.DrinkButton.FlatAppearance.BorderSize = 0
        Me.DrinkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DrinkButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DrinkButton.ForeColor = System.Drawing.SystemColors.Control
        Me.DrinkButton.Image = CType(resources.GetObject("DrinkButton.Image"), System.Drawing.Image)
        Me.DrinkButton.Location = New System.Drawing.Point(0, 220)
        Me.DrinkButton.Name = "DrinkButton"
        Me.DrinkButton.Size = New System.Drawing.Size(215, 64)
        Me.DrinkButton.TabIndex = 6
        Me.DrinkButton.Text = "     Drinks"
        Me.DrinkButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.DrinkButton.UseVisualStyleBackColor = True
        '
        'PanelOnSide
        '
        Me.PanelOnSide.BackColor = System.Drawing.Color.Coral
        Me.PanelOnSide.Location = New System.Drawing.Point(0, 150)
        Me.PanelOnSide.Name = "PanelOnSide"
        Me.PanelOnSide.Size = New System.Drawing.Size(11, 64)
        Me.PanelOnSide.TabIndex = 3
        '
        'SIdeButton
        '
        Me.SIdeButton.FlatAppearance.BorderSize = 0
        Me.SIdeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SIdeButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.SIdeButton.ForeColor = System.Drawing.SystemColors.Control
        Me.SIdeButton.Image = CType(resources.GetObject("SIdeButton.Image"), System.Drawing.Image)
        Me.SIdeButton.Location = New System.Drawing.Point(0, 150)
        Me.SIdeButton.Name = "SIdeButton"
        Me.SIdeButton.Size = New System.Drawing.Size(215, 64)
        Me.SIdeButton.TabIndex = 4
        Me.SIdeButton.Text = "     Sides"
        Me.SIdeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SIdeButton.UseVisualStyleBackColor = True
        '
        'PanelOnPizza
        '
        Me.PanelOnPizza.BackColor = System.Drawing.Color.Coral
        Me.PanelOnPizza.Location = New System.Drawing.Point(0, 80)
        Me.PanelOnPizza.Name = "PanelOnPizza"
        Me.PanelOnPizza.Size = New System.Drawing.Size(11, 64)
        Me.PanelOnPizza.TabIndex = 2
        '
        'PizzaButton
        '
        Me.PizzaButton.FlatAppearance.BorderSize = 0
        Me.PizzaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PizzaButton.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.PizzaButton.ForeColor = System.Drawing.SystemColors.Control
        Me.PizzaButton.Image = CType(resources.GetObject("PizzaButton.Image"), System.Drawing.Image)
        Me.PizzaButton.Location = New System.Drawing.Point(0, 80)
        Me.PizzaButton.Name = "PizzaButton"
        Me.PizzaButton.Size = New System.Drawing.Size(215, 64)
        Me.PizzaButton.TabIndex = 2
        Me.PizzaButton.Text = "     Pizza"
        Me.PizzaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.PizzaButton.UseVisualStyleBackColor = True
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(218, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(966, 31)
        Me.TopPanel.TabIndex = 1
        '
        'MainPagePic
        '
        Me.MainPagePic.Image = CType(resources.GetObject("MainPagePic.Image"), System.Drawing.Image)
        Me.MainPagePic.Location = New System.Drawing.Point(218, 28)
        Me.MainPagePic.Name = "MainPagePic"
        Me.MainPagePic.Size = New System.Drawing.Size(966, 561)
        Me.MainPagePic.TabIndex = 2
        Me.MainPagePic.TabStop = False
        '
        'SystemMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 589)
        Me.Controls.Add(Me.MainPagePic)
        Me.Controls.Add(Me.TopPanel)
        Me.Controls.Add(Me.MenuPanel)
        Me.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SystemMain"
        Me.Text = "Form1"
        Me.MenuPanel.ResumeLayout(False)
        CType(Me.MainPagePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuPanel As Panel
    Friend WithEvents PizzaButton As Button
    Friend WithEvents TopPanel As Panel
    Friend WithEvents PanelOnPizza As Panel
    Friend WithEvents PanelOnExit As Panel
    Friend WithEvents ExitButton As Button
    Friend WithEvents PanelOnDrinks As Panel
    Friend WithEvents DrinkButton As Button
    Friend WithEvents PanelOnSide As Panel
    Friend WithEvents SIdeButton As Button
    Friend WithEvents PanelOnBill As Panel
    Friend WithEvents BillButton As Button
    Friend WithEvents MainPagePic As PictureBox
    Friend WithEvents LogoButton As Button
End Class
