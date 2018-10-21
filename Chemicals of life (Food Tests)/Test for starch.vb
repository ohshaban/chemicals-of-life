Public Class starchForm

    Private Sub starchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTestName.Left = (Me.ClientSize.Width / 2) - (lblTestName.Width / 2)

        lblLesson.Text = "- Reagent : Iodine solution (yellow/brown)" & vbCrLf & vbCrLf & "- Test : To 2 cm3 of the water extract of the crushed food sample, add a few drops of iodine solution. Then shake." & vbCrLf & vbCrLf & vbCrLf & "- Positive result : Colour change from yellow/brown to blue/black" & vbCrLf & vbCrLf & "- Conclusion :  Starch is present." & vbCrLf & vbCrLf & "- Negative result : Colour stays yellow/brown." & vbCrLf & vbCrLf & "- Conclusion : Starch is absent."

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        mainMenu.Show()
        Me.Close()
    End Sub
End Class