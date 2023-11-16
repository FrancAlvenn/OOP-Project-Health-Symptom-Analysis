Public Class AddictionTest
    Public looper As Integer = 0
    Public scorer As Integer = 0
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

    Private Sub UpdateLabel()
        ' Clear the label text
        Dim items As String = "Checked items: "

        ' Iterate through all controls in the form
        For Each ctrl As Control In Me.Controls
            ' Check if the control is a CheckBox
            If TypeOf ctrl Is CheckBox Then
                Dim checkbox As CheckBox = DirectCast(ctrl, CheckBox)

                ' If the checkbox is checked, append its text to the label
                If checkbox.Checked Then
                    items &= checkbox.Text & ", "
                End If
            End If
        Next

        ' Remove the trailing comma and space
        items = items.TrimEnd(", ".ToCharArray())
    End Sub
    Private Sub CheckBox1_Paint(sender As Object, e As PaintEventArgs)
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox2_Paint(sender As Object, e As PaintEventArgs)
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox3_Paint(sender As Object, e As PaintEventArgs)
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox4_Paint(sender As Object, e As PaintEventArgs)
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox5_Paint(sender As Object, e As PaintEventArgs)
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox6_Paint(sender As Object, e As PaintEventArgs)
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox7_Paint(sender As Object, e As PaintEventArgs)
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox8_Paint(sender As Object, e As PaintEventArgs)
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox9_Paint(sender As Object, e As PaintEventArgs)
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub

    Private Sub CheckBox10_Paint(sender As Object, e As PaintEventArgs)
        CustomPaintCheckBox(DirectCast(sender, CheckBox), e.Graphics)
    End Sub


    Private Sub UpdateRadioButtonAppearance(selectedRadioButton As RadioButton)
        If selectedRadioButton.Checked Then
            ' Change the color for the selected radio button
            selectedRadioButton.BackColor = Color.FromArgb(162, 220, 245)

            ' Unselect other radio buttons and revert their color
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is RadioButton AndAlso ctrl IsNot selectedRadioButton Then
                    DirectCast(ctrl, RadioButton).Checked = False
                    DirectCast(ctrl, RadioButton).BackColor = Color.Gainsboro
                End If
            Next
        Else
            ' Revert the color for the deselected radio button
            selectedRadioButton.BackColor = DefaultBackColor
        End If
    End Sub

    '---------SET 1------------------------------------------------------------------------------------------------------'
    Private Sub rdb_A1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_A1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_A2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_A2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub


    '---------SET 2------------------------------------------------------------------------------------------------------'
    Private Sub rdb_B1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_B1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_B2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_B2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub


    '---------SET 3------------------------------------------------------------------------------------------------------'
    Private Sub rdb_C1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_C1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_C2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_C2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub



    '---------SET 4------------------------------------------------------------------------------------------------------'
    Private Sub rdb_D1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_D1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_D2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_D2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        MainForm.childForm(MentalAssessment)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If looper < 4 Then
            IsAnyRadioButtonSelected(Panel1)
            IsAnyRadioButtonSelected(Panel3)
            IsAnyRadioButtonSelected(Panel4)
            IsAnyRadioButtonSelected(Panel5)
        Else
            MainForm.childForm(AddictionResultForm)
        End If

        If rdb_A2.Checked Then
            scorer += 1
        End If

        If rdb_B2.Checked Then
            scorer += 1
        End If

        If rdb_C2.Checked Then
            scorer += 1
        End If

        If rdb_D2.Checked Then
            scorer += 1
        End If





    End Sub

    Private Function IsAnyRadioButtonSelected(panel As Panel) As Boolean
        For Each radioButton As RadioButton In panel.Controls.OfType(Of RadioButton)()
            If radioButton.Checked Then
                looper += 1
                Return True
            End If
        Next

        MsgBox("Please answer all the questions!", vbInformation, "Message!")
        Return False
    End Function
End Class