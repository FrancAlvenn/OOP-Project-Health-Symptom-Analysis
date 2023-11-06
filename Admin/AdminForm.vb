Public Class AdminForm

    Private Sub TimerPanelDecrease_Tick(sender As Object, e As EventArgs) Handles TimerPanelDecrease.Tick
        If pnlMenu.Width > 65 Then
            pnlMenu.Width -= 50
            seperator1.Visible = False
            seperator2.Visible = False
            logo.Visible = False
            SubPanel.Enabled = True
        Else
            TimerPanelDecrease.Enabled = False
        End If
    End Sub

    Private Sub TimerPanelIncrease_Tick(sender As Object, e As EventArgs) Handles TimerPanelIncrease.Tick
        If pnlMenu.Width < 270 Then
            pnlMenu.Width += 50
            seperator1.Visible = True
            seperator2.Visible = True
            logo.Visible = True
            SubPanel.Enabled = False
        Else
            TimerPanelIncrease.Enabled = False
        End If
    End Sub


    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If pnlMenu.Width >= 270 Then
            TimerPanelDecrease.Enabled = True
        Else
            TimerPanelIncrease.Enabled = True
        End If
    End Sub

    Private Sub RoundCornerLabel(label As Label)
        label.BorderStyle = FlatStyle.Flat

        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        'top left
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad.AddLine(10, 0, label.Width - 20, 0)
        'top right
        rad.AddArc(New Rectangle(label.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(label.Width, 20, label.Width, label.Height - 20)
        'bottom right
        'to change the bottom right the x,y,width,height must be same
        rad.AddArc(New Rectangle(label.Width - 25, label.Height - 25, 25, 25), 0, 90)
        rad.AddLine(label.Width - 10, label.Height, 20, label.Height)
        'bottom left
        rad.AddArc(New Rectangle(0, label.Height - 20, 20, 20), 90, 90)
        label.Region = New Region(rad)
    End Sub

    Private Sub MainFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundCornerLabel(lblHome)
        RoundCornerLabel(lblTime)
        RoundCornerLabel(lblUser)
    End Sub


End Class