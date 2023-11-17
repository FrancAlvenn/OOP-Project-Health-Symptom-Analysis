Public Class DepressionResultForm

    Public zeroToFour As String = "Minimal Depression"
    Public fiveToNine As String = "Mild Depression"
    Public tenToFourteen As String = "Moderate Depression"
    Public fifteenToTwenty As String = "Moderately Severe Depression"
    Public twentyToTwentySeven As String = "Severe Depression"

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        MainForm.childForm(MentalAssessment)
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        MainForm.childForm(MentalAssessment)
    End Sub

    Private Sub DepressionResultForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If DepressionTest.scorer <= 4 Then
            testResult.Text = zeroToFour
        ElseIf DepressionTest.scorer <= 9 Then
            testResult.Text = fiveToNine
        ElseIf DepressionTest.scorer <= 14 Then
            testResult.Text = tenToFourteen
        ElseIf DepressionTest.scorer <= 21 Then
            testResult.Text = fifteenToTwenty
        ElseIf DepressionTest.scorer <= 27 Then
            testResult.Text = twentyToTwentySeven
        End If

        Dim radioButtonGroup As RadioButton() = DepressionTest.Panel1.Controls.OfType(Of RadioButton)().ToArray()
        ' Find the selected radio button
        Dim selectedRadioButton As RadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)

        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q1.Text = selectedText
        End If

        radioButtonGroup = DepressionTest.Panel2.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q2.Text = selectedText
        End If

        radioButtonGroup = DepressionTest.Panel3.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q3.Text = selectedText
        End If

        radioButtonGroup = DepressionTest.Panel4.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q4.Text = selectedText
        End If

        radioButtonGroup = DepressionTest.Panel5.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q5.Text = selectedText
        End If

        radioButtonGroup = DepressionTest.Panel6.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q6.Text = selectedText
        End If

        radioButtonGroup = DepressionTest.Panel7.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q7.Text = selectedText
        End If

        radioButtonGroup = DepressionTest.Panel8.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q8.Text = selectedText
        End If

        radioButtonGroup = DepressionTest.Panel9.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q9.Text = selectedText
        End If
    End Sub
End Class