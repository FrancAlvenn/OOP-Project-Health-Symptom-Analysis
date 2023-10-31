Public Class MentalAssessment


    'Funtions and Methods

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

    Private Sub RoundCornerPanel(panel As Panel)
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

    Private Sub RoundCornerLabel(button As Label)
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

    Sub childForm(ByVal panel As Form)
        Form1.pnlChangeable.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        Form1.pnlChangeable.Controls.Add(panel)
        panel.Show()
    End Sub

    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------'
    Private Sub MentalAssessment_Load(sender As Object, e As EventArgs) Handles Me.Load
        RoundCornerPanel(pnlHeader)
        RoundCornerLabel(btnAddictionTest)
        RoundCornerLabel(btnAnxietyTest)
        RoundCornerLabel(btnADHDTest)
        RoundCornerLabel(btnDepressionTest)
        RoundCornerLabel(btnPTSDTest)
        RoundCornerLabel(btnEatingDisorderTest)

    End Sub

    Private Sub DepressionTestPanel_Scroll(sender As Object, e As ScrollEventArgs) Handles DepressionTestPanel.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            DepressionTestPanel.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    Private Sub btnDepressionTest_Click(sender As Object, e As EventArgs) Handles btnDepressionTest.Click
        lblHeader.Text = "What is Depression?"
        lblHeader.Dock = DockStyle.Left
        lblHeader.Padding = New Padding(30, 0, 0, 0)
        lblSubHeader.Text = ""

        tabControl.SelectedTab() = DepressionTestPanel
    End Sub

    Private Sub btnADHDTest_Click(sender As Object, e As EventArgs) Handles btnADHDTest.Click
        lblHeader.Text = "What is ADHD?"
        lblHeader.Dock = DockStyle.Left
        lblHeader.Padding = New Padding(30, 0, 0, 0)
        lblSubHeader.Text = ""

        tabControl.SelectedTab() = ADHDTestPanel
    End Sub

    Private Sub btnAnxietyTest_Click(sender As Object, e As EventArgs) Handles btnAnxietyTest.Click
        lblHeader.Text = "What is Anxiety?"
        lblHeader.Dock = DockStyle.Left
        lblHeader.Padding = New Padding(30, 0, 0, 0)
        lblSubHeader.Text = ""

        tabControl.SelectedTab() = AnxietyTestPanel
    End Sub

    Private Sub btnPTSDTest_Click(sender As Object, e As EventArgs) Handles btnPTSDTest.Click
        lblHeader.Text = "What is PTSD?"
        lblHeader.Dock = DockStyle.Left
        lblHeader.Padding = New Padding(30, 0, 0, 0)
        lblSubHeader.Text = ""

        tabControl.SelectedTab() = PTSDTestPanel
    End Sub

    Private Sub btnEatingDisorderTest_Click(sender As Object, e As EventArgs) Handles btnEatingDisorderTest.Click
        lblHeader.Text = "What is Eating Disorder?"
        lblHeader.Dock = DockStyle.Left
        lblHeader.Padding = New Padding(30, 0, 0, 0)
        lblSubHeader.Text = ""

        tabControl.SelectedTab() = EatingDisorderTestPanel
    End Sub

    Private Sub btnAddictionTest_Click(sender As Object, e As EventArgs) Handles btnAddictionTest.Click
        lblHeader.Text = "What is Addiction?"
        lblHeader.Dock = DockStyle.Left
        lblHeader.Padding = New Padding(30, 0, 0, 0)
        lblSubHeader.Text = ""

        tabControl.SelectedTab() = AddictionTestPanel
    End Sub

    Private Sub MentalAssessment_Click(sender As Object, e As EventArgs) Handles Me.Click
        lblHeader.Text = "Take a Mental Health Test?"
        lblHeader.Dock = DockStyle.None
        lblHeader.Padding = New Padding(0, 0, 0, 0)
        lblSubHeader.Text = "Conditions like depression or anxiety are not only real and widespread, but they're also highly treatable. 
The good news? Recovery is absolutely within reach!
"
        tabControl.SelectedTab() = LandingPanel
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If tabControl.SelectedTab Is DepressionTestPanel Then
            childForm(DepressionTest)
        ElseIf tabControl.SelectedTab Is ADHDTestPanel Then

        ElseIf tabControl.SelectedTab Is AnxietyTestPanel Then

        ElseIf tabControl.SelectedTab Is PTSDTestPanel Then

        ElseIf tabControl.SelectedTab Is EatingDisorderTestPanel Then

        ElseIf tabControl.SelectedTab Is AddictionTestPanel Then

        Else
            MsgBox("Please Select a Mental Disorder to test!", vbOK, "No Test Selected! ")

        End If

    End Sub
End Class