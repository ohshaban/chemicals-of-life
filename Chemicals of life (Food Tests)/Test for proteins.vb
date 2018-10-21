Public Class proteinsForm

    Private Sub Test_for_proteins_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTestName.Left = (Me.ClientSize.Width / 2) - (lblTestName.Width / 2)

        lblLesson.Text = "- Reagent : Biuret reagent (blue)" & vbCrLf & vbCrLf & "- Test : To 2 cm3 of water extract of crushed food sample, add sodium hydroxide (aq), then dropwise add copper sulphate (aq). Shake gently." & vbCrLf & vbCrLf & vbCrLf & "- Positive result : Colour change from blue to purple (mauve/lilac/violet)" & vbCrLf & vbCrLf & "- Conclusion : Proteins present." & vbCrLf & vbCrLf & "- Negative result : Colour of mixture stays ble." & vbCrLf & vbCrLf & "- Conclusion : Proteins absent."

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        mainMenu.Show()
        Me.Close()
    End Sub
End Class