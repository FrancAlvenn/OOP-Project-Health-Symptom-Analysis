Public Class AnxietyResultForm
    Public zeroToFour As String = "Minimal Anxiety"
    Public fiveToNine As String = "Mild Anxiety"
    Public tenToFourteen As String = "Moderate Anxiety"
    Public fifteenToTwenty As String = "Severe Anxiety"

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        MainForm.childForm(MentalAssessment)
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        MainForm.childForm(MentalAssessment)
    End Sub

    Private Sub AnxietyResultForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        If AnxietyTest.scorer <= 4 Then
            testResult.Text = zeroToFour
        ElseIf AnxietyTest.scorer <= 9 Then
            testResult.Text = fiveToNine
        ElseIf AnxietyTest.scorer <= 14 Then
            testResult.Text = tenToFourteen
        ElseIf AnxietyTest.scorer <= 21 Then
            testResult.Text = fifteenToTwenty
        End If

        Dim radioButtonGroup As RadioButton() = AnxietyTest.Panel1.Controls.OfType(Of RadioButton)().ToArray()
        ' Find the selected radio button
        Dim selectedRadioButton As RadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)

        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q1.Text = selectedText
        End If

        radioButtonGroup = AnxietyTest.Panel2.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q2.Text = selectedText
        End If

        radioButtonGroup = AnxietyTest.Panel3.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q3.Text = selectedText
        End If

        radioButtonGroup = AnxietyTest.Panel4.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q4.Text = selectedText
        End If

        radioButtonGroup = AnxietyTest.Panel5.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q5.Text = selectedText
        End If

        radioButtonGroup = AnxietyTest.Panel6.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q6.Text = selectedText
        End If

        radioButtonGroup = AnxietyTest.Panel7.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q7.Text = selectedText
        End If


        Dim labelArray() As Label = {q1, q2, q3, q4, q5, q6, q7}
        AddLabelsToQueue(labelArray)
        addRecord(testResult.Text)


    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If MainForm.hasAccount Then
            generateReport("AnxietyTest")
        Else
            Dim result As DialogResult = MessageBox.Show("You cannot print your report as you are not logged in, to print result please LogIn!", "CONFIRMATION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim loginForm As DialogResult = UserLogin.ShowDialog()
            End If
        End If
    End Sub
End Class