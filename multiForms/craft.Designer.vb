<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class craft
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
        Me.smeltingButton = New System.Windows.Forms.Button()
        Me.blacksmithingButton = New System.Windows.Forms.Button()
        Me.jewelcraftingButton = New System.Windows.Forms.Button()
        Me.cookingButton = New System.Windows.Forms.Button()
        Me.alchemyButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'smeltingButton
        '
        Me.smeltingButton.Location = New System.Drawing.Point(50, 29)
        Me.smeltingButton.Name = "smeltingButton"
        Me.smeltingButton.Size = New System.Drawing.Size(97, 51)
        Me.smeltingButton.TabIndex = 0
        Me.smeltingButton.Text = "Smelting"
        Me.smeltingButton.UseVisualStyleBackColor = True
        '
        'blacksmithingButton
        '
        Me.blacksmithingButton.Location = New System.Drawing.Point(153, 29)
        Me.blacksmithingButton.Name = "blacksmithingButton"
        Me.blacksmithingButton.Size = New System.Drawing.Size(97, 51)
        Me.blacksmithingButton.TabIndex = 0
        Me.blacksmithingButton.Text = "Blacksmithing"
        Me.blacksmithingButton.UseVisualStyleBackColor = True
        '
        'jewelcraftingButton
        '
        Me.jewelcraftingButton.Location = New System.Drawing.Point(256, 29)
        Me.jewelcraftingButton.Name = "jewelcraftingButton"
        Me.jewelcraftingButton.Size = New System.Drawing.Size(97, 51)
        Me.jewelcraftingButton.TabIndex = 0
        Me.jewelcraftingButton.Text = "Jewelcrafting"
        Me.jewelcraftingButton.UseVisualStyleBackColor = True
        '
        'cookingButton
        '
        Me.cookingButton.Location = New System.Drawing.Point(359, 29)
        Me.cookingButton.Name = "cookingButton"
        Me.cookingButton.Size = New System.Drawing.Size(97, 51)
        Me.cookingButton.TabIndex = 0
        Me.cookingButton.Text = "Cooking"
        Me.cookingButton.UseVisualStyleBackColor = True
        '
        'alchemyButton
        '
        Me.alchemyButton.Location = New System.Drawing.Point(462, 29)
        Me.alchemyButton.Name = "alchemyButton"
        Me.alchemyButton.Size = New System.Drawing.Size(97, 51)
        Me.alchemyButton.TabIndex = 0
        Me.alchemyButton.Text = "Alchemy"
        Me.alchemyButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(50, 131)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(509, 458)
        Me.Panel1.TabIndex = 1
        '
        'craft
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(621, 631)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.alchemyButton)
        Me.Controls.Add(Me.cookingButton)
        Me.Controls.Add(Me.jewelcraftingButton)
        Me.Controls.Add(Me.blacksmithingButton)
        Me.Controls.Add(Me.smeltingButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "craft"
        Me.Text = "craft"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents smeltingButton As Button
    Friend WithEvents blacksmithingButton As Button
    Friend WithEvents jewelcraftingButton As Button
    Friend WithEvents cookingButton As Button
    Friend WithEvents alchemyButton As Button
    Friend WithEvents Panel1 As Panel
End Class
