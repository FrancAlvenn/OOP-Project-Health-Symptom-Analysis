Public Class Home

    Private Sub RoundCornerButton(button As Button)
        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        'top left
        rad.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        rad.AddLine(10, 0, button.Width - 10, 0)
        'top right
        rad.AddArc(New Rectangle(button.Width - 10, 0, 10, 10), -90, 90)
        rad.AddLine(button.Width, 10, button.Width, button.Height - 10)
        'bottom right
        'to change the bottom right the x,y,width,height must be same
        rad.AddArc(New Rectangle(button.Width - 15, button.Height - 15, 15, 15), 0, 90)
        rad.AddLine(button.Width - 10, button.Width, 10, button.Height)
        'bottom left
        rad.AddArc(New Rectangle(0, button.Height - 10, 10, 10), 90, 90)
        button.Region = New Region(rad)
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load
        RoundCornerButton(btnGetStarted)
    End Sub

    Private Sub btnGetStarted_Click(sender As Object, e As EventArgs) Handles btnGetStarted.Click
        'check if user has account if not open login Form
        If MainForm.hasAccount = False Then
            Dim loginForm As DialogResult = UserLogin.ShowDialog()
        Else
            MainForm.childForm(BMICalc)
        End If


    End Sub
End Class