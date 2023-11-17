Public Class DepressionTest
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

    Private Sub rdb_A3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_A3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_A4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_A4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    '---------SET 2------------------------------------------------------------------------------------------------------'
    Private Sub rdb_B1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_B1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_B2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_B2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_B3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_B3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_B4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_B4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub


    '---------SET 3------------------------------------------------------------------------------------------------------'
    Private Sub rdb_C1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_C1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_C2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_C2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_C3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_C3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_C4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_C4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub



    '---------SET 4------------------------------------------------------------------------------------------------------'
    Private Sub rdb_D1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_D1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_D2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_D2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_D3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_D3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_D4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_D4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub



    '---------SET 5------------------------------------------------------------------------------------------------------'
    Private Sub rdb_E1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_E1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_E2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_E2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_E3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_E3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_E4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_E4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub



    '---------SET 6------------------------------------------------------------------------------------------------------'
    Private Sub rdb_F1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_F1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_F2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_F2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_F3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_F3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_F4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_F4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    '---------SET 7------------------------------------------------------------------------------------------------------'

    Private Sub rdb_G1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_G1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_G2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_G2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_G3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_G3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_G4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_G4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    '---------SET 8------------------------------------------------------------------------------------------------------'

    Private Sub rdb_H1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_H1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_H2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_H2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_H3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_H3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_H4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_H4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub


    '---------SET 9------------------------------------------------------------------------------------------------------'


    Private Sub rdb_I1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_I1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_I2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_I2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_I3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_I3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_I4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_I4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    '---------SET 10------------------------------------------------------------------------------------------------------'


    Private Sub rdb_J1_CheckedChanged(sender As Object, e As EventArgs)
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_J2_CheckedChanged(sender As Object, e As EventArgs)
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_J3_CheckedChanged(sender As Object, e As EventArgs)
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_J4_CheckedChanged(sender As Object, e As EventArgs)
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        MainForm.childForm(MentalAssessment)


    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        If looper < 9 Then
            IsAnyRadioButtonSelected(Panel1)
            IsAnyRadioButtonSelected(Panel2)
            IsAnyRadioButtonSelected(Panel3)
            IsAnyRadioButtonSelected(Panel4)
            IsAnyRadioButtonSelected(Panel5)
            IsAnyRadioButtonSelected(Panel6)
            IsAnyRadioButtonSelected(Panel7)
            IsAnyRadioButtonSelected(Panel8)
            IsAnyRadioButtonSelected(Panel9)
        Else
            MainForm.childForm(DepressionResultForm)
        End If


        If rdb_A1.Checked Then
            scorer += 0
        ElseIf rdb_A2.Checked Then
            scorer += 1
        ElseIf rdb_A3.Checked Then
            scorer += 2
        ElseIf rdb_A4.Checked Then
            scorer += 3
        End If

        If rdb_B1.Checked Then
            scorer += 0
        ElseIf rdb_B2.Checked Then
            scorer += 1
        ElseIf rdb_B3.Checked Then
            scorer += 2
        ElseIf rdb_B4.Checked Then
            scorer += 3
        End If

        If rdb_C1.Checked Then
            scorer += 0
        ElseIf rdb_C2.Checked Then
            scorer += 1
        ElseIf rdb_C3.Checked Then
            scorer += 2
        ElseIf rdb_C4.Checked Then
            scorer += 3
        End If

        If rdb_D1.Checked Then
            scorer += 0
        ElseIf rdb_D2.Checked Then
            scorer += 1
        ElseIf rdb_D3.Checked Then
            scorer += 2
        ElseIf rdb_D4.Checked Then
            scorer += 3
        End If

        If rdb_E1.Checked Then
            scorer += 0
        ElseIf rdb_E2.Checked Then
            scorer += 1
        ElseIf rdb_E3.Checked Then
            scorer += 2
        ElseIf rdb_E4.Checked Then
            scorer += 3
        End If

        If rdb_F1.Checked Then
            scorer += 0
        ElseIf rdb_F2.Checked Then
            scorer += 1
        ElseIf rdb_F3.Checked Then
            scorer += 2
        ElseIf rdb_F4.Checked Then
            scorer += 3
        End If

        If rdb_G1.Checked Then
            scorer += 0
        ElseIf rdb_G2.Checked Then
            scorer += 1
        ElseIf rdb_G3.Checked Then
            scorer += 2
        ElseIf rdb_G4.Checked Then
            scorer += 3
        End If

        If rdb_H1.Checked Then
            scorer += 0
        ElseIf rdb_H2.Checked Then
            scorer += 1
        ElseIf rdb_H3.Checked Then
            scorer += 2
        ElseIf rdb_H4.Checked Then
            scorer += 3
        End If

        If rdb_I1.Checked Then
            scorer += 0
        ElseIf rdb_I2.Checked Then
            scorer += 1
        ElseIf rdb_I3.Checked Then
            scorer += 2
        ElseIf rdb_I4.Checked Then
            scorer += 3
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