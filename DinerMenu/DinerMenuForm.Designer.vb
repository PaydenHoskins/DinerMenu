<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerMenuForm
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
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DinerNameLabel = New System.Windows.Forms.Label()
        Me.DisplaySpecialLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SoupButton
        '
        Me.SoupButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.SoupButton.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoupButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SoupButton.Location = New System.Drawing.Point(12, 328)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(169, 100)
        Me.SoupButton.TabIndex = 0
        Me.SoupButton.Text = "Soup"
        Me.SoupButton.UseVisualStyleBackColor = False
        '
        'SaladButton
        '
        Me.SaladButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.SaladButton.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaladButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SaladButton.Location = New System.Drawing.Point(211, 328)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(169, 100)
        Me.SaladButton.TabIndex = 1
        Me.SaladButton.Text = "Salad"
        Me.SaladButton.UseVisualStyleBackColor = False
        '
        'FishButton
        '
        Me.FishButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.FishButton.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FishButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FishButton.Location = New System.Drawing.Point(406, 327)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(169, 100)
        Me.FishButton.TabIndex = 2
        Me.FishButton.Text = "Fish"
        Me.FishButton.UseVisualStyleBackColor = False
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.SystemColors.Highlight
        Me.ExitButton.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExitButton.Location = New System.Drawing.Point(605, 329)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(169, 100)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'DinerNameLabel
        '
        Me.DinerNameLabel.AutoSize = True
        Me.DinerNameLabel.Font = New System.Drawing.Font("Edwardian Script ITC", 40.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinerNameLabel.Location = New System.Drawing.Point(176, 9)
        Me.DinerNameLabel.Name = "DinerNameLabel"
        Me.DinerNameLabel.Size = New System.Drawing.Size(455, 64)
        Me.DinerNameLabel.TabIndex = 4
        Me.DinerNameLabel.Text = "Payden's Dinner Menu"
        '
        'DisplaySpecialLabel
        '
        Me.DisplaySpecialLabel.AutoSize = True
        Me.DisplaySpecialLabel.Font = New System.Drawing.Font("MV Boli", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplaySpecialLabel.Location = New System.Drawing.Point(235, 100)
        Me.DisplaySpecialLabel.Name = "DisplaySpecialLabel"
        Me.DisplaySpecialLabel.Size = New System.Drawing.Size(0, 28)
        Me.DisplaySpecialLabel.TabIndex = 5
        Me.DisplaySpecialLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DinerMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DisplaySpecialLabel)
        Me.Controls.Add(Me.DinerNameLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Name = "DinerMenuForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SoupButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DinerNameLabel As Label
    Friend WithEvents DisplaySpecialLabel As Label
End Class
