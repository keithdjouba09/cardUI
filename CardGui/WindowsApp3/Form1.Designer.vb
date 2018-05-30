<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.showColor = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.RadioButton9 = New System.Windows.Forms.RadioButton()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SaveDialog = New System.Windows.Forms.SaveFileDialog()
        Me.imageFileLoader = New System.Windows.Forms.OpenFileDialog()
        Me.imageButton = New System.Windows.Forms.RadioButton()
        Me.grayButton = New System.Windows.Forms.RadioButton()
        Me.oliveButton = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButton10 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'showColor
        '
        Me.showColor.Location = New System.Drawing.Point(365, 117)
        Me.showColor.Name = "showColor"
        Me.showColor.Size = New System.Drawing.Size(214, 203)
        Me.showColor.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(3, 372)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(358, 33)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select Numbers of Rows"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RadioButton4.Location = New System.Drawing.Point(380, 386)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton4.TabIndex = 6
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "4"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RadioButton5.Location = New System.Drawing.Point(417, 386)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton5.TabIndex = 7
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "5"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RadioButton6.Location = New System.Drawing.Point(454, 388)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton6.TabIndex = 8
        Me.RadioButton6.TabStop = True
        Me.RadioButton6.Text = "6"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RadioButton7.Location = New System.Drawing.Point(491, 388)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton7.TabIndex = 9
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "7"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RadioButton8.Location = New System.Drawing.Point(528, 388)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton8.TabIndex = 10
        Me.RadioButton8.TabStop = True
        Me.RadioButton8.Text = "8"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'RadioButton9
        '
        Me.RadioButton9.AutoSize = True
        Me.RadioButton9.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RadioButton9.Location = New System.Drawing.Point(565, 388)
        Me.RadioButton9.Name = "RadioButton9"
        Me.RadioButton9.Size = New System.Drawing.Size(31, 17)
        Me.RadioButton9.TabIndex = 11
        Me.RadioButton9.TabStop = True
        Me.RadioButton9.Text = "9"
        Me.RadioButton9.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.BackColor = System.Drawing.Color.Red
        Me.saveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.saveButton.Location = New System.Drawing.Point(474, 428)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(84, 40)
        Me.saveButton.TabIndex = 12
        Me.saveButton.Text = "save"
        Me.saveButton.UseVisualStyleBackColor = False
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(564, 438)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 26)
        Me.exitButton.TabIndex = 13
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(211, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 33)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Matching Game"
        '
        'imageFileLoader
        '
        Me.imageFileLoader.FileName = "OpenFileDialog1"
        '
        'imageButton
        '
        Me.imageButton.AutoSize = True
        Me.imageButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.imageButton.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.imageButton.Location = New System.Drawing.Point(24, 119)
        Me.imageButton.Name = "imageButton"
        Me.imageButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.imageButton.Size = New System.Drawing.Size(85, 28)
        Me.imageButton.TabIndex = 5
        Me.imageButton.TabStop = True
        Me.imageButton.Text = "Image"
        Me.imageButton.UseVisualStyleBackColor = True
        '
        'grayButton
        '
        Me.grayButton.AutoSize = True
        Me.grayButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grayButton.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.grayButton.Location = New System.Drawing.Point(24, 80)
        Me.grayButton.Name = "grayButton"
        Me.grayButton.Size = New System.Drawing.Size(71, 28)
        Me.grayButton.TabIndex = 4
        Me.grayButton.TabStop = True
        Me.grayButton.Text = "Gary"
        Me.grayButton.UseVisualStyleBackColor = True
        '
        'oliveButton
        '
        Me.oliveButton.AutoSize = True
        Me.oliveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.oliveButton.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.oliveButton.Location = New System.Drawing.Point(24, 46)
        Me.oliveButton.Name = "oliveButton"
        Me.oliveButton.Size = New System.Drawing.Size(76, 28)
        Me.oliveButton.TabIndex = 3
        Me.oliveButton.TabStop = True
        Me.oliveButton.Text = "Olive"
        Me.oliveButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.oliveButton)
        Me.Panel1.Controls.Add(Me.imageButton)
        Me.Panel1.Controls.Add(Me.grayButton)
        Me.Panel1.Location = New System.Drawing.Point(18, 117)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 161)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(32, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(268, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Select the back of the cards"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(371, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Preview"
        '
        'RadioButton10
        '
        Me.RadioButton10.AutoSize = True
        Me.RadioButton10.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.RadioButton10.Location = New System.Drawing.Point(602, 390)
        Me.RadioButton10.Name = "RadioButton10"
        Me.RadioButton10.Size = New System.Drawing.Size(37, 17)
        Me.RadioButton10.TabIndex = 16
        Me.RadioButton10.TabStop = True
        Me.RadioButton10.Text = "10"
        Me.RadioButton10.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(565, 471)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Help"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(668, 506)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioButton10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.RadioButton9)
        Me.Controls.Add(Me.RadioButton8)
        Me.Controls.Add(Me.RadioButton7)
        Me.Controls.Add(Me.RadioButton6)
        Me.Controls.Add(Me.RadioButton5)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.showColor)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents showColor As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton5 As RadioButton
    Friend WithEvents RadioButton6 As RadioButton
    Friend WithEvents RadioButton7 As RadioButton
    Friend WithEvents RadioButton8 As RadioButton
    Friend WithEvents RadioButton9 As RadioButton
    Friend WithEvents saveButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents SaveDialog As SaveFileDialog
    Friend WithEvents imageFileLoader As OpenFileDialog
    Friend WithEvents imageButton As RadioButton
    Friend WithEvents grayButton As RadioButton
    Friend WithEvents oliveButton As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents RadioButton10 As RadioButton
    Friend WithEvents Button1 As Button
End Class
