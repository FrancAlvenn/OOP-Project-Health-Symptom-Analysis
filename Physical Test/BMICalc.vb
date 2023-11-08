Public Class BMICalc
    Dim itemCount As Integer = 0
    Dim clickedLabel As Label
    'Functions and Methods

    'Round Corner Button
    Private Sub RoundCornerButton(panel As Button)
        'panel.BorderStyle = FlatStyle.Flat

        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        'top left
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad.AddLine(10, 0, panel.Width - 20, 0)
        'top right
        rad.AddArc(New Rectangle(panel.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(panel.Width, 20, panel.Width, panel.Height - 20)
        'bottom right
        'to change the bottom right the x,y,width,height must be same
        rad.AddArc(New Rectangle(panel.Width - 25, panel.Height - 25, 25, 25), 0, 90)
        rad.AddLine(panel.Width - 10, panel.Height, 20, panel.Height)
        'bottom left
        rad.AddArc(New Rectangle(0, panel.Height - 20, 20, 20), 90, 90)
        panel.Region = New Region(rad)
    End Sub

    'clicked label funtion
    Private Sub Label_Click(sender As Object, e As EventArgs)
        ' Cast sender to Label
        clickedLabel = DirectCast(sender, Label)

        For Each control As Control In TableLayoutPanel12.Controls
            If TypeOf control Is Label Then
                control.BackColor = Color.Transparent ' Set the default background color (Transparent)
                control.Font = New Font("Microsoft Tai Le", 10, FontStyle.Regular)
            End If
        Next

        clickedLabel.Font = New Font("Microsoft Tai Le", 10, FontStyle.Bold)
        clickedLabel.BackColor = Color.FromArgb(162, 220, 245)
    End Sub



    '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------'
    'Event Handlers


    Private Sub PhysicalAssessmentToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'fucntion call to get childform
        MainForm.childForm(PhysicalAssessment)
    End Sub


    Private Sub BMICalc_Load(sender As Object, e As EventArgs) Handles Me.Load
        RoundCornerButton(btnReset)
        RoundCornerButton(btnSubmit)
        'rdbMetric.Select()

    End Sub

    Private Sub rdbImperial_CheckedChanged(sender As Object, e As EventArgs) Handles rdbImperial.CheckedChanged
        lblHeight.Text = "ft"
        lblWeight.Text = "lbs"
        txtInch.Visible = True
        lblInch.Visible = True
    End Sub

    Private Sub rdbMetric_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMetric.CheckedChanged
        lblHeight.Text = "cm"
        lblWeight.Text = "kg"
        txtInch.Visible = False
        lblInch.Visible = False
    End Sub


    '==============================================================='
    'Scroll Behavior

    Public targetScrollValue As Integer
    Public currentScrollValue As Integer
    Private Sub scrollTimer_Tick(sender As Object, e As EventArgs) Handles scrollTimer.Tick
        If currentScrollValue < targetScrollValue Then
            currentScrollValue += 25
            Me.VerticalScroll.Value = currentScrollValue
        Else
            scrollTimer.Stop()
        End If
    End Sub

    Private Sub btnBMICalc_Click(sender As Object, e As EventArgs) Handles btnBMICalc.Click
        targetScrollValue = 800 ' Set the target scroll value
        currentScrollValue = Me.VerticalScroll.Value
        scrollTimer.Interval = 10 ' Set the interval for the timer (adjust as needed)
        scrollTimer.Start()
    End Sub
    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        targetScrollValue = 800 ' Set the target scroll value
        currentScrollValue = Me.VerticalScroll.Value
        scrollTimer.Interval = 10 ' Set the interval for the timer (adjust as needed)
        scrollTimer.Start()
    End Sub

    Private Sub btnSymptomChecker_Click(sender As Object, e As EventArgs) Handles btnSymptomChecker.Click
        targetScrollValue = 1700 ' Set the target scroll value
        currentScrollValue = Me.VerticalScroll.Value
        scrollTimer.Interval = 15 ' Set the interval for the timer (adjust as needed)
        scrollTimer.Start()
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        targetScrollValue = 1700 ' Set the target scroll value
        currentScrollValue = Me.VerticalScroll.Value
        scrollTimer.Interval = 15 ' Set the interval for the timer (adjust as needed)
        scrollTimer.Start()
    End Sub



    '==============================================================='

    'Symptom Checker handler

    Private Sub btnAddSymptom_Click(sender As Object, e As EventArgs) Handles btnAddSymptom.Click
        If itemCount < 15 Then
            Dim newLabel As New Label()
            newLabel.Text = "Dynamic Label"
            newLabel.AutoSize = True
            newLabel.Font = New Font("Microsoft Tai Le", 10, FontStyle.Regular)
            newLabel.Dock = DockStyle.Fill
            newLabel.TextAlign = ContentAlignment.MiddleLeft

            AddHandler newLabel.Click, AddressOf Label_Click

            Dim row As Integer = 0
            Dim column As Integer = 0

            tableLayoutSymptoms.Controls.Add(newLabel, column, row)
            itemCount += 1
        Else
            MsgBox("Too many symptoms!")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tableLayoutSymptoms.Controls.Clear()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        tableLayoutSymptoms.Controls.Remove(clickedLabel)
        clickedLabel.Dispose()
    End Sub
End Class