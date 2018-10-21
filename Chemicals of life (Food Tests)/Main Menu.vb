Public Class mainMenu

    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        labelTitle.Left = (Me.ClientSize.Width / 2) - (labelTitle.Width / 2)
        btnSugars.Left = (Me.ClientSize.Width / 2) - (btnSugars.Width / 2)
        btnStarch.Left = (Me.ClientSize.Width / 2) - (btnStarch.Width / 2)
        btnProteins.Left = (Me.ClientSize.Width / 2) - (btnProteins.Width / 2)
        btnLipids.Left = (Me.ClientSize.Width / 2) - (btnLipids.Width / 2)
        btnQuestions.Left = (Me.ClientSize.Width / 2) - (btnQuestions.Width / 2)

    End Sub

    Private Sub btnQuestions_Click(sender As Object, e As EventArgs) Handles btnQuestions.Click
        Me.Hide()
        questionsForm.show()
    End Sub

    Private Sub btnStarch_Click(sender As Object, e As EventArgs) Handles btnStarch.Click
        Me.Hide()
        starchForm.Show()
    End Sub

    Private Sub btnProteins_Click(sender As Object, e As EventArgs) Handles btnProteins.Click
        Me.Hide()
        proteinsForm.Show()
    End Sub

    Private Sub btnLipids_Click(sender As Object, e As EventArgs) Handles btnLipids.Click
        Me.Hide()
        lipidsForm.show()
    End Sub

    Private Sub btnSugars_Click(sender As Object, e As EventArgs) Handles btnSugars.Click
        Me.Hide()
        sugarsForm.Show()
    End Sub

    Private Sub labelTitle_Click(sender As Object, e As EventArgs) Handles labelTitle.Click

    End Sub
End Class
