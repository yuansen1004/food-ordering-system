<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PizzaSec
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PizzaSec))
        Me.TopPanel = New System.Windows.Forms.Panel()
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
        Me.Pizza1 = New System.Windows.Forms.Button()
        Me.Pizza2 = New System.Windows.Forms.Button()
        Me.Pizza3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.DarkOrange
        Me.TopPanel.Location = New System.Drawing.Point(245, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1332, 43)
        Me.TopPanel.TabIndex = 2
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
        Me.MenuPanel.Size = New System.Drawing.Size(245, 618)
        Me.MenuPanel.TabIndex = 21
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
        'Pizza1
        '
        Me.Pizza1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pizza1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pizza1.Image = CType(resources.GetObject("Pizza1.Image"), System.Drawing.Image)
        Me.Pizza1.Location = New System.Drawing.Point(336, 158)
        Me.Pizza1.Name = "Pizza1"
        Me.Pizza1.Size = New System.Drawing.Size(261, 230)
        Me.Pizza1.TabIndex = 22
        Me.Pizza1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.Pizza1.UseVisualStyleBackColor = True
        '
        'Pizza2
        '
        Me.Pizza2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pizza2.Image = CType(resources.GetObject("Pizza2.Image"), System.Drawing.Image)
        Me.Pizza2.Location = New System.Drawing.Point(684, 158)
        Me.Pizza2.Name = "Pizza2"
        Me.Pizza2.Size = New System.Drawing.Size(261, 230)
        Me.Pizza2.TabIndex = 23
        Me.Pizza2.UseVisualStyleBackColor = True
        '
        'Pizza3
        '
        Me.Pizza3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Pizza3.Image = CType(resources.GetObject("Pizza3.Image"), System.Drawing.Image)
        Me.Pizza3.Location = New System.Drawing.Point(1026, 158)
        Me.Pizza3.Name = "Pizza3"
        Me.Pizza3.Size = New System.Drawing.Size(261, 230)
        Me.Pizza3.TabIndex = 24
        Me.Pizza3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(415, 458)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 30)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Choose"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(366, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 32)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Beef Pepperoni"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(727, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 32)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Island Tuna"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(1056, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 32)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Chicken Delight"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(766, 458)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 30)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Choose"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1111, 458)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(106, 30)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Choose"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(435, 414)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 27)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "RM10"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(784, 418)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 27)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "RM11"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(1129, 414)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 27)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "RM9"
        '
        'PizzaSec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1332, 618)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Pizza3)
        Me.Controls.Add(Me.Pizza2)
        Me.Controls.Add(Me.Pizza1)
        Me.Controls.Add(Me.MenuPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PizzaSec"
        Me.Text = "Form2"
        Me.MenuPanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TopPanel As Panel
    Friend WithEvents MenuPanel As Panel
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
    Friend WithEvents Pizza1 As Button
    Friend WithEvents Pizza2 As Button
    Friend WithEvents Pizza3 As Button
    Friend WithEvents LogoButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
