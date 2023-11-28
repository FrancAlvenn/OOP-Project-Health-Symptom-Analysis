Public Class AddictionResultForm
    Public underTwo As String = "Unlikely Alcohol or Substance Use Problem"
    Public aboveTwo As String = "Likely Alcohol or Substance Use Problem"
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

        If AddictionTest.scorer <= 2 Then
            testResult.Text = underTwo
        Else
            testResult.Text = aboveTwo
        End If


        Dim labelArray() As Label = {q1, q2, q3, q4, q5}
        AddLabelsToQueue(labelArray)
        addRecord(testResult.Text)

    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        MainForm.childForm(MentalAssessment)
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        MainForm.childForm(MentalAssessment)
    End Sub
End Class