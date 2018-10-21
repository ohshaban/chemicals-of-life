<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainMenu))
        Me.labelTitle = New System.Windows.Forms.Label()
        Me.btnSugars = New System.Windows.Forms.Button()
        Me.labelCopyright = New System.Windows.Forms.Label()
        Me.labelVersion = New System.Windows.Forms.Label()
        Me.btnProteins = New System.Windows.Forms.Button()
        Me.btnStarch = New System.Windows.Forms.Button()
        Me.btnLipids = New System.Windows.Forms.Button()
        Me.btnQuestions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'labelTitle
        '
        Me.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelTitle.AutoSize = True
        Me.labelTitle.BackColor = System.Drawing.Color.Transparent
        Me.labelTitle.Font = New System.Drawing.Font("Georgia", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTitle.ForeColor = System.Drawing.Color.White
        Me.labelTitle.Location = New System.Drawing.Point(249, 44)
        Me.labelTitle.Name = "labelTitle"
        Me.labelTitle.Size = New System.Drawing.Size(292, 56)
        Me.labelTitle.TabIndex = 0
        Me.labelTitle.Text = "Food Tests"
        Me.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSugars
        '
        Me.btnSugars.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSugars.AutoSize = True
        Me.btnSugars.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSugars.Location = New System.Drawing.Point(179, 145)
        Me.btnSugars.Name = "btnSugars"
        Me.btnSugars.Size = New System.Drawing.Size(448, 45)
        Me.btnSugars.TabIndex = 1
        Me.btnSugars.Text = "Test for reducing sugars"
        Me.btnSugars.UseVisualStyleBackColor = True
        '
        'labelCopyright
        '
        Me.labelCopyright.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelCopyright.AutoSize = True
        Me.labelCopyright.BackColor = System.Drawing.Color.Transparent
        Me.labelCopyright.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelCopyright.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelCopyright.Location = New System.Drawing.Point(665, 561)
        Me.labelCopyright.Name = "labelCopyright"
        Me.labelCopyright.Size = New System.Drawing.Size(123, 19)
        Me.labelCopyright.TabIndex = 2
        Me.labelCopyright.Text = "Copyright © OHS"
        Me.labelCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelVersion
        '
        Me.labelVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelVersion.AutoSize = True
        Me.labelVersion.BackColor = System.Drawing.Color.Transparent
        Me.labelVersion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVersion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.labelVersion.Location = New System.Drawing.Point(12, 561)
        Me.labelVersion.Name = "labelVersion"
        Me.labelVersion.Size = New System.Drawing.Size(238, 19)
        Me.labelVersion.TabIndex = 3
        Me.labelVersion.Text = "Chemicals of Life (Food Tests) v1.0"
        Me.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnProteins
        '
        Me.btnProteins.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProteins.AutoSize = True
        Me.btnProteins.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProteins.Location = New System.Drawing.Point(179, 306)
        Me.btnProteins.Name = "btnProteins"
        Me.btnProteins.Size = New System.Drawing.Size(448, 45)
        Me.btnProteins.TabIndex = 4
        Me.btnProteins.Text = "Test for proteins"
        Me.btnProteins.UseVisualStyleBackColor = True
        '
        'btnStarch
        '
        Me.btnStarch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStarch.AutoSize = True
        Me.btnStarch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStarch.Location = New System.Drawing.Point(179, 227)
        Me.btnStarch.Name = "btnStarch"
        Me.btnStarch.Size = New System.Drawing.Size(448, 45)
        Me.btnStarch.TabIndex = 5
        Me.btnStarch.Text = "Test for starch"
        Me.btnStarch.UseVisualStyleBackColor = True
        '
        'btnLipids
        '
        Me.btnLipids.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLipids.AutoSize = True
        Me.btnLipids.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLipids.Location = New System.Drawing.Point(179, 385)
        Me.btnLipids.Name = "btnLipids"
        Me.btnLipids.Size = New System.Drawing.Size(448, 45)
        Me.btnLipids.TabIndex = 6
        Me.btnLipids.Text = "Test for lipids (fats)"
        Me.btnLipids.UseVisualStyleBackColor = True
        '
        'btnQuestions
        '
        Me.btnQuestions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuestions.AutoSize = True
        Me.btnQuestions.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuestions.Location = New System.Drawing.Point(179, 464)
        Me.btnQuestions.Name = "btnQuestions"
        Me.btnQuestions.Size = New System.Drawing.Size(448, 45)
        Me.btnQuestions.TabIndex = 7
        Me.btnQuestions.Text = "Questions"
        Me.btnQuestions.UseVisualStyleBackColor = True
        '
        'mainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Chemicals_of_life__Food_Tests_.My.Resources.Resources.backgroundDNA
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 589)
        Me.Controls.Add(Me.btnQuestions)
        Me.Controls.Add(Me.btnLipids)
        Me.Controls.Add(Me.btnStarch)
        Me.Controls.Add(Me.btnProteins)
        Me.Controls.Add(Me.labelVersion)
        Me.Controls.Add(Me.labelCopyright)
        Me.Controls.Add(Me.btnSugars)
        Me.Controls.Add(Me.labelTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "mainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chemicals of Life (Food Tests)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labelTitle As System.Windows.Forms.Label
    Friend WithEvents btnSugars As System.Windows.Forms.Button
    Friend WithEvents labelCopyright As System.Windows.Forms.Label
    Friend WithEvents labelVersion As System.Windows.Forms.Label
    Friend WithEvents btnProteins As System.Windows.Forms.Button
    Friend WithEvents btnStarch As System.Windows.Forms.Button
    Friend WithEvents btnLipids As System.Windows.Forms.Button
    Friend WithEvents btnQuestions As System.Windows.Forms.Button

End Class
