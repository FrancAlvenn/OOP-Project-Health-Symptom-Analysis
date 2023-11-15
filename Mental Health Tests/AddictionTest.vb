Public Class AddictionTest
    Private Sub CustomPaintCheckBox(checkbox As CheckBox, g As Graphics)
        Dim checkBoxRect As Rectangle = New Rectangle(0, 0, checkbox.Width, checkbox.Height)

        ' Draw a circle with border
        Dim circleSize As Integer = Math.Min(checkbox.Height, checkbox.Height)
        Dim circleRect As New Rectangle(-1.5, (checkbox.Height - circleSize) \ 2, 35, 35)


        If checkbox.Checked Then
            ' If the checkbox is checked, fill the circle with blue
            g.FillEllipse(New SolidBrush(Color.FromArgb(162, 220, 245)), circleRect)
        Else
            ' If the checkbox is not checked, fill the circle with gray
            g.FillEllipse(Brushes.LightGray, circleRect)
        End If
    End Sub
    Private Sub CheckBox1_Paint(sender As Object, e As PaintEventArgs) Handles CheckBox1.Paint
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox2_Paint(sender As Object, e As PaintEventArgs) Handles CheckBox2.Paint
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox3_Paint(sender As Object, e As PaintEventArgs) Handles CheckBox3.Paint
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox4_Paint(sender As Object, e As PaintEventArgs) Handles CheckBox4.Paint
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox5_Paint(sender As Object, e As PaintEventArgs) Handles CheckBox5.Paint
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox6_Paint(sender As Object, e As PaintEventArgs) Handles CheckBox6.Paint
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox7_Paint(sender As Object, e As PaintEventArgs) Handles CheckBox7.Paint
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox8_Paint(sender As Object, e As PaintEventArgs) Handles CheckBox8.Paint
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox9_Paint(sender As Object, e As PaintEventArgs) Handles CheckBox9.Paint
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox10_Paint(sender As Object, e As PaintEventArgs) Handles CheckBox10.Paint
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub
End Class