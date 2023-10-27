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
End Class