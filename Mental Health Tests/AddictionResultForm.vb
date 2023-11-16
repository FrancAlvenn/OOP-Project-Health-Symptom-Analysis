Public Class AddictionResultForm
    Private Sub AddictionResultForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If AddictionTest.rdb_A1.Checked Then
            q1.Text = AddictionTest.rdb_A1.Text
        ElseIf AddictionTest.rdb_A2.Checked Then
            q1.Text = AddictionTest.rdb_A2.Text
        End If

        If AddictionTest.rdb_B1.Checked Then
            q2.Text = AddictionTest.rdb_B1.Text
        ElseIf AddictionTest.rdb_B2.Checked Then
            q2.Text = AddictionTest.rdb_B2.Text
        End If

        If AddictionTest.rdb_C1.Checked Then
            q3.Text = AddictionTest.rdb_C1.Text
        ElseIf AddictionTest.rdb_C2.Checked Then
            q3.Text = AddictionTest.rdb_C2.Text
        End If

        If AddictionTest.rdb_D1.Checked Then
            q4.Text = AddictionTest.rdb_D1.Text
        ElseIf AddictionTest.rdb_D2.Checked Then
            q4.Text = AddictionTest.rdb_D2.Text
        End If

        q5.Text = AddictionTest.txtConcern.Text
    End Sub
End Class