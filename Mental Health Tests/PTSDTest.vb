Public Class PTSDTest
    Public looper As Integer = 0
    Public scorer As Integer = 0
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



    '---------SET 5------------------------------------------------------------------------------------------------------'
    Private Sub rdb_E1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_E1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_E2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_E2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        MainForm.childForm(MentalAssessment)
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        If looper < 5 Then
            IsAnyRadioButtonSelected(Panel1)
            IsAnyRadioButtonSelected(Panel3)
            IsAnyRadioButtonSelected(Panel4)
            IsAnyRadioButtonSelected(Panel5)
            IsAnyRadioButtonSelected(Panel6)

        Else
            MainForm.childForm(PTSDResultForm)
        End If


        If rdb_A1.Checked Then
            scorer += 0
        ElseIf rdb_A2.Checked Then
            scorer += 1
        End If


        If rdb_B1.Checked Then
            scorer += 0
        ElseIf rdb_B2.Checked Then
            scorer += 1

            End If

        If rdb_C1.Checked Then
            scorer += 0
        ElseIf rdb_C2.Checked Then
            scorer += 1
        End If

        If rdb_D1.Checked Then
            scorer += 0
        ElseIf rdb_D2.Checked Then
            scorer += 1
        End If

        If rdb_E1.Checked Then
            scorer += 0
        ElseIf rdb_E2.Checked Then
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