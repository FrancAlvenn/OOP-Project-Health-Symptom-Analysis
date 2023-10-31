Public Class BMICalc
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




    '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------'
    'Event Handlers


    Private Sub PhysicalAssessmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SymptomCheckerToolStripMenuItem.Click
        'fucntion call to get childform
        Form1.childForm(PhysicalAssessment)
    End Sub

    Private Sub BMICalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BMICalculatorToolStripMenuItem.Click
        'fucntion call to get childform
        Form1.childForm(Me)
    End Sub

    Private Sub BMICalc_Load(sender As Object, e As EventArgs) Handles Me.Load
        RoundCornerButton(btnReset)
        RoundCornerButton(btnSubmit)
        rdbMetric.Select()
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


End Class