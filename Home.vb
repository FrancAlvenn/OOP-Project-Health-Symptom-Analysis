Public Class Home

    Private Sub RoundCornerButton(form As Form)
        form.FormBorderStyle = FormBorderStyle.None

        'form.BackColor = Color.FromArgb(5, 121, 203)
        'form.ForeColor = Color.White
        'form.Cursor = Cursors.Hand

        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        'top left
        rad.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        rad.AddLine(10, 0, form.Width - 10, 0)
        'top right
        rad.AddArc(New Rectangle(form.Width - 10, 0, 10, 10), -90, 90)
        rad.AddLine(form.Width, 10, form.Width, form.Height - 10)
        'bottom right
        'to change the bottom right the x,y,width,height must be same
        rad.AddArc(New Rectangle(form.Width - 15, form.Height - 15, 15, 15), 0, 90)
        rad.AddLine(form.Width - 10, form.Width, 10, form.Height)
        'bottom left
        rad.AddArc(New Rectangle(0, form.Height - 10, 10, 10), 90, 90)
        form.Region = New Region(rad)
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles Me.Load


    End Sub
End Class