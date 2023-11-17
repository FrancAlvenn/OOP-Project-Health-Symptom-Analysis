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
        MainForm.pnlChangeable.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        MainForm.pnlChangeable.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub MentalAssessment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundCornerButton(btnDepressionTest)
        RoundCornerButton(btnADHDTest)
        RoundCornerButton(btnAnxietyTest)
        RoundCornerButton(btnPTSDTest)
        RoundCornerButton(btnAddictionTest)
    End Sub


    Private Sub btnDepressionTest_Click_1(sender As Object, e As EventArgs) Handles btnDepressionTest.Click
        childForm(DepressionTest)
    End Sub

    Private Sub btnADHDTest_Click(sender As Object, e As EventArgs) Handles btnADHDTest.Click
        childForm(ADHDTest)
    End Sub

    Private Sub btnAnxietyTest_Click(sender As Object, e As EventArgs) Handles btnAnxietyTest.Click
        childForm(AnxietyTest)
    End Sub

    Private Sub btnPTSDTest_Click(sender As Object, e As EventArgs) Handles btnPTSDTest.Click
        childForm(PTSDTest)
    End Sub

    Private Sub btnAddictionTest_Click(sender As Object, e As EventArgs) Handles btnAddictionTest.Click
        childForm(AddictionTest)
    End Sub



    '---------------------------------------------------------------------------------------------------------------------------------------------------------------------------'

End Class