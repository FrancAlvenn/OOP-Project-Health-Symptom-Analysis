Public Class PhysicalAssessment
    Dim itemCount As Integer = 0
    Dim clickedLabel As Label


    'Functions and Methods
    Private Sub Label_Click(sender As Object, e As EventArgs)
        ' Cast sender to Label
        clickedLabel = DirectCast(sender, Label)

        For Each control As Control In TableLayoutPanel1.Controls
            If TypeOf control Is Label Then
                control.BackColor = Color.Transparent ' Set the default background color (Transparent)
                control.Font = New Font("Microsoft Tai Le", 10, FontStyle.Regular)
            End If
        Next

        clickedLabel.Font = New Font("Microsoft Tai Le", 10, FontStyle.Bold)
        clickedLabel.BackColor = Color.FromArgb(162, 220, 245)
    End Sub


    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------'
    'Event Handlers


    Private Sub RoundCornerButton(button As Button)
        'panel.BorderStyle = FlatStyle.Flat

        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        'top left
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad.AddLine(10, 0, button.Width - 20, 0)
        'top right
        rad.AddArc(New Rectangle(button.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(button.Width, 20, button.Width, button.Height - 20)
        'bottom right
        'to change the bottom right the x,y,width,height must be same
        rad.AddArc(New Rectangle(button.Width - 25, button.Height - 25, 25, 25), 0, 90)
        rad.AddLine(button.Width - 10, button.Height, 20, button.Height)
        'bottom left
        rad.AddArc(New Rectangle(0, button.Height - 20, 20, 20), 90, 90)
        button.Region = New Region(rad)
    End Sub

    Private Sub PhysicalAssessmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhysicalAssessmentToolStripMenuItem.Click
        'fucntion call to get childform
        Form1.childForm(Me)
    End Sub

    Private Sub BMICalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BMICalculatorToolStripMenuItem.Click
        'fucntion call to get childform
        Form1.childForm(BMICalc)
    End Sub

    Private Sub PhysicalAssessment_Load(sender As Object, e As EventArgs) Handles Me.Load
        RoundCornerButton(btnAddSymptom)
        RoundCornerButton(btnClear)
        RoundCornerButton(btnRemove)
        RoundCornerButton(btnSubmit)



    End Sub

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

            TableLayoutPanel1.Controls.Add(newLabel, column, row)
            itemCount += 1
        Else
            MsgBox("Too many symptoms!")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TableLayoutPanel1.Controls.Clear()
    End Sub



    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        TableLayoutPanel1.Controls.Remove(clickedLabel)
        clickedLabel.Dispose()
    End Sub
End Class