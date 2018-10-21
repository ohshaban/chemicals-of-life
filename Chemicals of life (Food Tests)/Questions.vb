Public Class questionsForm

    Dim myScore As Integer = 0
    Dim experimentNum As Integer = 0
    Dim myTest As String = ""
    Dim ttExtract As String = ""
    Dim resultShown As Boolean = False
    Dim myWaterBath As Boolean = False
    Dim sugarPresent As Integer = Nothing
    Dim starchPresent As Integer = Nothing
    Dim proteinsPresent As Integer = Nothing
    Dim lipidsPresent As Integer = Nothing
    Dim myInstructions As String = "Test the given crushed food sample for reducing sugars, starch, proteins, and lipids using the techniques provided."
    Dim myAreYouSure As String = "Are you sure? Try doing something else. If you're stuck and aren't sure what to do, go back to the lessons and figure it out."

    Private Sub questionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblInstructions.Left = (Me.ClientSize.Width / 2) - (lblInstructions.Width / 2)

        Dim randomBoolean As New Random

        sugarPresent = randomBoolean.Next(0, 2)
        If sugarPresent > 0 Then sugarPresent = 1 Else sugarPresent = 0

        starchPresent = randomBoolean.Next(0, 2)
        If starchPresent > 0 Then
            starchPresent = 1
        Else
            starchPresent = 0
        End If

        proteinsPresent = randomBoolean.Next(0, 2)
        If proteinsPresent > 0 Then
            proteinsPresent = 1
        Else
            proteinsPresent = 0
        End If

        lipidsPresent = randomBoolean.Next(0, 2)
        If lipidsPresent > 0 Then
            lipidsPresent = 1
        Else
            lipidsPresent = 0
        End If

        Me.Show()

        'MessageBox.Show(sugarPresent & "," & starchPresent & "," & proteinsPresent & "," & lipidsPresent)
        lblInstructions.ForeColor = Color.Black
        lblInstructions.Text = myInstructions
        'MessageBox.Show("Test the given food sample for reducing sugars, starch, proteins, and lipids using the techniques provided.")
    End Sub

    Private Sub btnBack_Click_1(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        mainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnBiuretReagent_Click(sender As Object, e As EventArgs) Handles btnBiuretReagent.Click

        If ttExtract = "waterExtract" Then
            myTest = "proteinsTest"
            lblInstructions.ForeColor = Color.Black
            lblInstructions.Text = "Testing for " & Replace(myTest, "Test", "") & "..."
            experimentNum += 1
            If proteinsPresent = 1 Then
                proteinsIsPresent()
            Else
                noReaction()
            End If
        Else
            lblInstructions.ForeColor = Color.Red
            lblInstructions.Text = myAreYouSure
            lblInstructions.Left = (Me.ClientSize.Width / 2) - (lblInstructions.Width / 2)
            myTimer.Interval = 5500
            myTimer.Enabled = True
            myTimer.Start()
            AddHandler myTimer.Tick, AddressOf instructionsDisplay
        End If

    End Sub

    Private Sub btnWExtract_Click(sender As Object, e As EventArgs) Handles btnWExtract.Click

        If ttExtract = "" Then
            mainTestTube.Image = My.Resources.ttClearLiquid
            ttExtract = "waterExtract"
        Else
            lblInstructions.ForeColor = Color.Red
            lblInstructions.Text = myAreYouSure
            lblInstructions.Left = (Me.ClientSize.Width / 2) - (lblInstructions.Width / 2)
            myTimer.Interval = 5500
            myTimer.Enabled = True
            myTimer.Start()
            AddHandler myTimer.Tick, AddressOf instructionsDisplay
        End If

    End Sub

    Private Sub btnBenedictsSolution_Click(sender As Object, e As EventArgs) Handles btnBenedictsSolution.Click

        If ttExtract = "waterExtract" Then
            mainTestTube.Image = My.Resources.ttBlueLiquid
            myTest = "sugarsTest"
        Else
            lblInstructions.ForeColor = Color.Red
            lblInstructions.Text = myAreYouSure
            lblInstructions.Left = (Me.ClientSize.Width / 2) - (lblInstructions.Width / 2)
            myTimer.Interval = 5500
            myTimer.Enabled = True
            myTimer.Start()
            AddHandler myTimer.Tick, AddressOf instructionsDisplay
        End If

    End Sub

    Private Sub btnWaterBath_Click(sender As Object, e As EventArgs) Handles btnWaterBath.Click

        If myWaterBath = True Then
            lblInstructions.ForeColor = Color.Red
            lblInstructions.Text = myAreYouSure
            lblInstructions.Left = (Me.ClientSize.Width / 2) - (lblInstructions.Width / 2)
            myTimer.Interval = 5500
            myTimer.Enabled = True
            myTimer.Start()
            AddHandler myTimer.Tick, AddressOf instructionsDisplay
        End If

        If myTest = "sugarsTest" Then
            lblInstructions.ForeColor = Color.Black
            lblInstructions.Text = "Testing for " & Replace(myTest, "Test", "") & "..."
            experimentNum += 1
            pbBunsenBurner.Show()
            myWaterBath = True
            If sugarPresent = 1 Then
                sugarIsPresent()
            Else
                noReaction()
            End If
        Else
            lblInstructions.ForeColor = Color.Red
            lblInstructions.Text = myAreYouSure
            lblInstructions.Left = (Me.ClientSize.Width / 2) - (lblInstructions.Width / 2)
            myTimer.Interval = 5500
            myTimer.Enabled = True
            myTimer.Start()
            AddHandler myTimer.Tick, AddressOf instructionsDisplay
        End If

    End Sub

    Private Sub btnAddToWater_Click(sender As Object, e As EventArgs) Handles btnAddToWater.Click

        If ttExtract = "ethanolExtract" Then
            myTest = "lipidsTest"
            lblInstructions.ForeColor = Color.Black
            lblInstructions.Text = "Testing for " & Replace(myTest, "Test", "") & "..."
            experimentNum += 1
            If lipidsPresent = 1 Then
                lipidsIsPresent()
            Else
                noReaction()
            End If
        Else
            lblInstructions.ForeColor = Color.Red
            lblInstructions.Text = myAreYouSure
            lblInstructions.Left = (Me.ClientSize.Width / 2) - (lblInstructions.Width / 2)
            myTimer.Interval = 5500
            myTimer.Enabled = True
            myTimer.Start()
            AddHandler myTimer.Tick, AddressOf instructionsDisplay
        End If

    End Sub

    Private Sub btnEExtract_Click(sender As Object, e As EventArgs) Handles btnEExtract.Click

        If ttExtract = "" Then
            mainTestTube.Image = My.Resources.ttClearLiquid
            ttExtract = "ethanolExtract"
        Else
            lblInstructions.ForeColor = Color.Red
            lblInstructions.Text = myAreYouSure
            lblInstructions.Left = (Me.ClientSize.Width / 2) - (lblInstructions.Width / 2)
            myTimer.Interval = 5500
            myTimer.Enabled = True
            myTimer.Start()
            AddHandler myTimer.Tick, AddressOf instructionsDisplay
        End If

    End Sub

    Private Sub btnIodineSolution_Click(sender As Object, e As EventArgs) Handles btnIodineSolution.Click

        If ttExtract = "waterExtract" Then
            myTest = "starchTest"
            lblInstructions.ForeColor = Color.Black
            lblInstructions.Text = "Testing for " & Replace(myTest, "Test", "") & "..."
            experimentNum += 1
            If starchPresent = 1 Then
                starchIsPresent()
            Else
                noReaction()
            End If
        Else
            lblInstructions.ForeColor = Color.Red
            lblInstructions.Text = myAreYouSure
            lblInstructions.Left = (Me.ClientSize.Width / 2) - (lblInstructions.Width / 2)
            myTimer.Interval = 5500
            myTimer.Enabled = True
            myTimer.Start()
            AddHandler myTimer.Tick, AddressOf instructionsDisplay
        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        myScore = 0

        If cbSugar.CheckState = sugarPresent Then
            pbCheck1.Show()
            pbCross1.Hide()
            myScore += 1
        Else
            pbCross1.Show()
            pbCheck1.Hide()
        End If

        If cbStarch.CheckState = starchPresent Then
            pbCheck2.Show()
            pbCross2.Hide()
            myScore += 1
        Else
            pbCross2.Show()
            pbCheck2.Hide()
        End If

        If cbProteins.CheckState = proteinsPresent Then
            pbCheck3.Show()
            pbCross3.Hide()
            myScore += 1
        Else
            pbCross3.Show()
            pbCheck3.Hide()
        End If

        If cbLipids.CheckState = lipidsPresent Then
            pbCheck4.Show()
            pbCross4.Hide()
            myScore += 1
        Else
            pbCross4.Show()
            pbCheck4.Hide()
        End If

        If myScore > 2 Then
            lblInstructions.ForeColor = Color.Green
        Else
            lblInstructions.ForeColor = Color.Red
        End If

        lblInstructions.Text = "Your score is: " & myScore & "/4"
        lblInstructions.Left = (Me.ClientSize.Width / 2) - (lblInstructions.Width / 2)

    End Sub

    Private Sub showResult(ByVal sender As Object, ByVal e As EventArgs)

        If myTest = "sugarsTest" Then
            If sugarPresent = 1 Then
                mainTestTube.Image = My.Resources.ReducingSugarsTestResult
                lblInstructions.Text = "The test is complete. The colour changed from blue to brick red. Record your conclusion below, then press Next Experiment to start a another test."
            End If
        ElseIf myTest = "starchTest" Then
            If starchPresent = 1 Then
                mainTestTube.Image = My.Resources.ttBlueBlackLiquid
                lblInstructions.Text = "The test is complete. The colour changed from yellow to blue/black. Record your conclusion below, then press Next Experiment to start a another test."
            End If
        ElseIf myTest = "proteinsTest" Then
            If proteinsPresent = 1 Then
                mainTestTube.Image = My.Resources.ttPurpleLiquid
                lblInstructions.Text = "The test is complete. The colour changed from blue to purple. Record your conclusion below, then press Next Experiment to start a another test."
            End If
        ElseIf myTest = "lipidsTest" Then
            If lipidsPresent = 1 Then
                mainTestTube.Image = My.Resources.ttMilkyLiquid
                lblInstructions.Text = "The test is complete. The colour changed from clear to milky. Record your conclusion below, then press Next Experiment to start a another test."
            End If
        End If

        btnNextExperiment.Enabled = True
        resultShown = True
        myTimer.Stop()
        myTimer.Enabled = False

    End Sub

    Private Sub sugarIsPresent()

        btnNextExperiment.Enabled = False
        btnWExtract.Enabled = False
        btnEExtract.Enabled = False
        btnAddToWater.Enabled = False
        btnWaterBath.Enabled = False
        btnBenedictsSolution.Enabled = False
        btnIodineSolution.Enabled = False
        btnBiuretReagent.Enabled = False

        mainTestTube.Image = My.Resources.reducingSugarsTest
        myTimer.Interval = 28000
        myTimer.Enabled = True
        myTimer.Start()
        AddHandler myTimer.Tick, AddressOf showResult

    End Sub

    Private Sub btnNextExperiment_Click(sender As Object, e As EventArgs) Handles btnNextExperiment.Click

        If resultShown = True Then

            If experimentNum = 1 Then
                If myTest = "sugarsTest" Then
                    If sugarPresent = 1 Then
                        ttExperiment1.Image = My.Resources.ttRedLiquid
                    Else
                        ttExperiment1.Image = My.Resources.ttBlueLiquid
                    End If
                ElseIf myTest = "starchTest" Then
                    If starchPresent = 1 Then
                        ttExperiment1.Image = My.Resources.ttBlueBlackLiquid
                    Else
                        ttExperiment1.Image = My.Resources.ttYellowLiquid
                    End If
                ElseIf myTest = "proteinsTest" Then
                    If proteinsPresent = 1 Then
                        ttExperiment1.Image = My.Resources.ttPurpleLiquid
                    Else
                        ttExperiment1.Image = My.Resources.ttBlueLiquid
                    End If
                ElseIf myTest = "lipidsTest" Then
                    If lipidsPresent = 1 Then
                        ttExperiment1.Image = My.Resources.ttMilkyLiquid
                    Else
                        ttExperiment1.Image = My.Resources.ttClearLiquid
                    End If
                End If
            ElseIf experimentNum = 2 Then
                If myTest = "sugarsTest" Then
                    If sugarPresent = 1 Then
                        ttExperiment2.Image = My.Resources.ttRedLiquid
                    Else
                        ttExperiment2.Image = My.Resources.ttBlueLiquid
                    End If
                ElseIf myTest = "starchTest" Then
                    If starchPresent = 1 Then
                        ttExperiment2.Image = My.Resources.ttBlueBlackLiquid
                    Else
                        ttExperiment2.Image = My.Resources.ttYellowLiquid
                    End If
                ElseIf myTest = "proteinsTest" Then
                    If proteinsPresent = 1 Then
                        ttExperiment2.Image = My.Resources.ttPurpleLiquid
                    Else
                        ttExperiment2.Image = My.Resources.ttBlueLiquid
                    End If
                ElseIf myTest = "lipidsTest" Then
                    If lipidsPresent = 1 Then
                        ttExperiment2.Image = My.Resources.ttMilkyLiquid
                    Else
                        ttExperiment2.Image = My.Resources.ttClearLiquid
                    End If
                End If
            ElseIf experimentNum = 3 Then
                If myTest = "sugarsTest" Then
                    If sugarPresent = 1 Then
                        ttExperiment3.Image = My.Resources.ttRedLiquid
                    Else
                        ttExperiment3.Image = My.Resources.ttBlueLiquid
                    End If
                ElseIf myTest = "starchTest" Then
                    If starchPresent = 1 Then
                        ttExperiment3.Image = My.Resources.ttBlueBlackLiquid
                    Else
                        ttExperiment3.Image = My.Resources.ttYellowLiquid
                    End If
                ElseIf myTest = "proteinsTest" Then
                    If proteinsPresent = 1 Then
                        ttExperiment3.Image = My.Resources.ttPurpleLiquid
                    Else
                        ttExperiment3.Image = My.Resources.ttBlueLiquid
                    End If
                ElseIf myTest = "lipidsTest" Then
                    If lipidsPresent = 1 Then
                        ttExperiment3.Image = My.Resources.ttMilkyLiquid
                    Else
                        ttExperiment3.Image = My.Resources.ttClearLiquid
                    End If
                End If
            ElseIf experimentNum = 4 Then
                If myTest = "sugarsTest" Then
                    If sugarPresent = 1 Then
                        ttExperiment4.Image = My.Resources.ttRedLiquid
                    Else
                        ttExperiment4.Image = My.Resources.ttBlueLiquid
                    End If
                ElseIf myTest = "starchTest" Then
                    If starchPresent = 1 Then
                        ttExperiment4.Image = My.Resources.ttBlueBlackLiquid
                    Else
                        ttExperiment4.Image = My.Resources.ttYellowLiquid
                    End If
                ElseIf myTest = "proteinsTest" Then
                    If proteinsPresent = 1 Then
                        ttExperiment4.Image = My.Resources.ttPurpleLiquid
                    Else
                        ttExperiment4.Image = My.Resources.ttBlueLiquid
                    End If
                ElseIf myTest = "lipidsTest" Then
                    If lipidsPresent = 1 Then
                        ttExperiment4.Image = My.Resources.ttMilkyLiquid
                    Else
                        ttExperiment4.Image = My.Resources.ttClearLiquid
                    End If
                End If
            End If

            myTest = ""
            ttExtract = ""
            resultShown = False
            myWaterBath = False

            btnWExtract.Enabled = True
            btnEExtract.Enabled = True
            btnAddToWater.Enabled = True
            btnWaterBath.Enabled = True
            btnBenedictsSolution.Enabled = True
            btnIodineSolution.Enabled = True
            btnBiuretReagent.Enabled = True

            mainTestTube.Image = My.Resources.crushedFoodSample
            pbBunsenBurner.Hide()
            lblInstructions.ForeColor = Color.Black
            lblInstructions.Text = myInstructions

        Else

            lblInstructions.ForeColor = Color.Red
            lblInstructions.Text = myAreYouSure
            lblInstructions.Left = (Me.ClientSize.Width / 2) - (lblInstructions.Width / 2)
            myTimer.Interval = 5500
            myTimer.Enabled = True
            myTimer.Start()
            AddHandler myTimer.Tick, AddressOf instructionsDisplay

        End If

    End Sub

    Private Sub starchIsPresent()

        btnNextExperiment.Enabled = False
        btnWExtract.Enabled = False
        btnEExtract.Enabled = False
        btnAddToWater.Enabled = False
        btnWaterBath.Enabled = False
        btnBenedictsSolution.Enabled = False
        btnIodineSolution.Enabled = False
        btnBiuretReagent.Enabled = False

        mainTestTube.Image = My.Resources.starchTest
        myTimer.Interval = 7800
        myTimer.Enabled = True
        myTimer.Start()
        AddHandler myTimer.Tick, AddressOf showResult

    End Sub

    Private Sub noReaction()

        btnNextExperiment.Enabled = False
        btnWExtract.Enabled = False
        btnEExtract.Enabled = False
        btnAddToWater.Enabled = False
        btnWaterBath.Enabled = False
        btnBenedictsSolution.Enabled = False
        btnIodineSolution.Enabled = False
        btnBiuretReagent.Enabled = False

        If myTest = "sugarsTest" Then
            mainTestTube.Image = My.Resources.hotWaterBathBlue
        ElseIf myTest = "starchTest" Then
            mainTestTube.Image = My.Resources.ttYellowLiquid
        ElseIf myTest = "proteinsTest" Then
            mainTestTube.Image = My.Resources.ttBlueLiquid
        ElseIf myTest = "lipidsTest" Then
            mainTestTube.Image = My.Resources.ttClearLiquid
        End If

        myTimer.Interval = 5000
        myTimer.Enabled = True
        myTimer.Start()
        AddHandler myTimer.Tick, AddressOf nextExperiment

    End Sub

    Private Sub nextExperiment(sender As Object, e As EventArgs)

        lblInstructions.Text = "The test is complete. There was no change in colour. Record your conclusion below, then press Next Experiment to start a another test."
        btnNextExperiment.Enabled = True
        resultShown = True
        myTimer.Stop()
        myTimer.Enabled = False

    End Sub

    Private Sub proteinsIsPresent()

        btnNextExperiment.Enabled = False
        btnWExtract.Enabled = False
        btnEExtract.Enabled = False
        btnAddToWater.Enabled = False
        btnWaterBath.Enabled = False
        btnBenedictsSolution.Enabled = False
        btnIodineSolution.Enabled = False
        btnBiuretReagent.Enabled = False

        mainTestTube.Image = My.Resources.proteinsTest
        myTimer.Interval = 8000
        myTimer.Enabled = True
        myTimer.Start()
        AddHandler myTimer.Tick, AddressOf showResult

    End Sub

    Private Sub lipidsIsPresent()

        btnNextExperiment.Enabled = False
        btnWExtract.Enabled = False
        btnEExtract.Enabled = False
        btnAddToWater.Enabled = False
        btnWaterBath.Enabled = False
        btnBenedictsSolution.Enabled = False
        btnIodineSolution.Enabled = False
        btnBiuretReagent.Enabled = False

        myTimer.Interval = 5000
        myTimer.Enabled = True
        myTimer.Start()
        AddHandler myTimer.Tick, AddressOf showResult

    End Sub

    Private Sub instructionsDisplay(sender As Object, e As EventArgs)

        lblInstructions.ForeColor = Color.Black
        lblInstructions.Text = myInstructions
        lblInstructions.Left = (Me.ClientSize.Width / 2) - (lblInstructions.Width / 2)
        myTimer.Stop()
        myTimer.Enabled = False
        resultShown = False

    End Sub

End Class