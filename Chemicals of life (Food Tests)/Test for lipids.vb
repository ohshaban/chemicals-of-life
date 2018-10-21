Public Class lipidsForm

    Private Sub lipidsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim resultShown As Boolean = False

        lblTestName.Left = (Me.ClientSize.Width / 2) - (lblTestName.Width / 2)

        lblLesson.Text = "- Reagent : Ethanol (colourless)" & vbCrLf & vbCrLf & "- Test : To the crushed food sample (do not prepare a water extract), add ethanol. Shake gently, then filter. Let the filtrate drop into a test tube containing distilled water." & vbCrLf & vbCrLf & vbCrLf & "- Positive result : The distilled water becomes milky (from clear)." & vbCrLf & vbCrLf & "- Conclusion : Lipids are present." & vbCrLf & vbCrLf & "- Negative result : The distilled water stays clear." & vbCrLf & vbCrLf & "- Conclusion : Lipids are absent." & vbCrLf & vbCrLf & vbCrLf & "- The more the milkiness/turbidity, the greater the amount of lipids present."

        myTimer.Interval = 5000
        myTimer.Enabled = True
        myTimer.Start()
        AddHandler myTimer.Tick, AddressOf showResult

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub showResult(sender As Object, e As EventArgs)

        pbTest.Image = My.Resources.ttMilkyLiquid
        myTimer.Stop()
        myTimer.Enabled = False
        myTimer.Interval = 10000
        myTimer.Enabled = True
        myTimer.Start()
        AddHandler myTimer.Tick, AddressOf resetTest

    End Sub

    Private Sub resetTest(sender As Object, e As EventArgs)

        pbTest.Image = My.Resources.ttClearLiquid
        myTimer.Stop()
        myTimer.Enabled = False
        myTimer.Interval = 5000
        myTimer.Enabled = True
        myTimer.Start()
        AddHandler myTimer.Tick, AddressOf showResult

    End Sub

End Class