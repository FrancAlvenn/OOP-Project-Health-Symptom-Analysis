Public Class ADHDTest
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
    Private Sub rdb_A5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_A5.CheckedChanged
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
    Private Sub rdb_B5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_B5.CheckedChanged
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
    Private Sub rdb_C5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_C5.CheckedChanged
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
    Private Sub rdb_D5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_D5.CheckedChanged
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
    Private Sub rdb_E5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_E5.CheckedChanged
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
    Private Sub rdb_F5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_F5.CheckedChanged
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
    Private Sub rdb_G5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_G5.CheckedChanged
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
    Private Sub rdb_H5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_H5.CheckedChanged
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
    Private Sub rdb_I5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_I5.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    '---------SET 10------------------------------------------------------------------------------------------------------'


    Private Sub rdb_J1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_J1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_J2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_J2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_J3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_J3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_J4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_J4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_J5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_J5.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub



    '---------SET 11------------------------------------------------------------------------------------------------------'
    Private Sub rdb_K1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_K1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_K2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_K2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_K3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_K3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_K4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_K4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_K5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_K5.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    '---------SET 12------------------------------------------------------------------------------------------------------'

    Private Sub rdb_L1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_L1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_L2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_L2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_L3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_L3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_L4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_L4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_L5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_L5.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    '---------SET 13------------------------------------------------------------------------------------------------------'

    Private Sub rdb_M1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_M1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_M2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_M2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_M3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_M3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_M4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_M4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_M5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_M5.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    '---------SET 14------------------------------------------------------------------------------------------------------'

    Private Sub rdb_N1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_N1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_N2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_N2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_N3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_N3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_N4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_N4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_N5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_N5.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    '---------SET 15------------------------------------------------------------------------------------------------------'

    Private Sub rdb_O1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_O1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_O2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_O2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_O3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_O3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_O4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_O4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_O5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_O5.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    '---------SET 16------------------------------------------------------------------------------------------------------'

    Private Sub rdb_P1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_P1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_P2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_P2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_P3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_P3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_P4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_P4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_P5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_P5.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    '---------SET 17------------------------------------------------------------------------------------------------------'

    Private Sub rdb_Q1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_Q1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_Q2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_Q2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_Q3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_Q3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_Q4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_Q4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_Q5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_Q5.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    '---------SET 18------------------------------------------------------------------------------------------------------'

    Private Sub rdb_R1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_R1.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_R2_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_R2.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_R3_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_R3.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_R4_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_R4.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub rdb_R5_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_R5.CheckedChanged
        UpdateRadioButtonAppearance(DirectCast(sender, RadioButton))
    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        MainForm.childForm(MentalAssessment)
    End Sub
End Class

