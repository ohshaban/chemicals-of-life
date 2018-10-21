Public Class sugarsForm

    Private Sub sugarsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblTestName.Left = (Me.ClientSize.Width / 2) - (lblTestName.Width / 2)

        lblLesson.Text = "- Reagent : Benedict's solution (blue)" & vbCrLf & vbCrLf & "- Test : Heat food sample (crushed water extract if sample if solid) with the same volume of benedict's solution in a test tube, over a boiling water bath for three minutes." & vbCrLf & vbCrLf & vbCrLf & "- Positive result : Colour change from blue to brick red." & vbCrLf & vbCrLf & "- Conclusion :  Reducing sugars present." & vbCrLf & vbCrLf & "- Negative result : Solution stays blue." & vbCrLf & vbCrLf & "- Conclusion : Reducing sugars absent." & vbCrLf & vbCrLf & vbCrLf & "- Precautions : " & vbCrLf & vbCrLf & "1. Wear safety goggles, a lab coat, and gloves." & vbCrLf & vbCrLf & "2. The test tube mouth should face away from you." & vbCrLf & vbCrLf & "3. Use a water bath for heating the solution."

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        mainMenu.Show()
        Me.Close()
    End Sub
End Class