<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class starchForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(starchForm))
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.lblTestName = New System.Windows.Forms.Label()
        Me.lblPositiveResult = New System.Windows.Forms.Label()
        Me.pbTest = New System.Windows.Forms.PictureBox()
        Me.lblLesson = New System.Windows.Forms.Label()
        CType(Me.pbTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMainMenu
        '
        Me.btnMainMenu.AutoSize = True
        Me.btnMainMenu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMainMenu.Location = New System.Drawing.Point(699, 12)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(89, 29)
        Me.btnMainMenu.TabIndex = 3
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'lblTestName
        '
        Me.lblTestName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTestName.AutoSize = True
        Me.lblTestName.Font = New System.Drawing.Font("Georgia", 20.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTestName.Location = New System.Drawing.Point(278, 12)
        Me.lblTestName.Name = "lblTestName"
        Me.lblTestName.Size = New System.Drawing.Size(191, 31)
        Me.lblTestName.TabIndex = 4
        Me.lblTestName.Text = "Test for starch"
        Me.lblTestName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPositiveResult
        '
        Me.lblPositiveResult.AutoSize = True
        Me.lblPositiveResult.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblPositiveResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositiveResult.Location = New System.Drawing.Point(561, 475)
        Me.lblPositiveResult.Name = "lblPositiveResult"
        Me.lblPositiveResult.Size = New System.Drawing.Size(162, 15)
        Me.lblPositiveResult.TabIndex = 11
        Me.lblPositiveResult.Text = "Observation of positive result"
        '
        'pbTest
        '
        Me.pbTest.BackColor = System.Drawing.SystemColors.ControlLight
        Me.pbTest.Image = Global.Chemicals_of_life__Food_Tests_.My.Resources.Resources.starchTest
        Me.pbTest.Location = New System.Drawing.Point(547, 118)
        Me.pbTest.Name = "pbTest"
        Me.pbTest.Size = New System.Drawing.Size(187, 352)
        Me.pbTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbTest.TabIndex = 10
        Me.pbTest.TabStop = False
        '
        'lblLesson
        '
        Me.lblLesson.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblLesson.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLesson.Location = New System.Drawing.Point(73, 68)
        Me.lblLesson.Name = "lblLesson"
        Me.lblLesson.Size = New System.Drawing.Size(461, 469)
        Me.lblLesson.TabIndex = 9
        Me.lblLesson.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'starchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(800, 589)
        Me.Controls.Add(Me.lblPositiveResult)
        Me.Controls.Add(Me.pbTest)
        Me.Controls.Add(Me.lblLesson)
        Me.Controls.Add(Me.lblTestName)
        Me.Controls.Add(Me.btnMainMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "starchForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test for starch"
        CType(Me.pbTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
    Friend WithEvents lblTestName As System.Windows.Forms.Label
    Friend WithEvents lblPositiveResult As System.Windows.Forms.Label
    Friend WithEvents pbTest As System.Windows.Forms.PictureBox
    Friend WithEvents lblLesson As System.Windows.Forms.Label
End Class
