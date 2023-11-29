Public Class PTSDResultForm
    Public PTSDPositive As String = "PTSD Positive"
    Public PTSDNegative As String = "PTSD Negative"
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        MainForm.childForm(MentalAssessment)
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        MainForm.childForm(MentalAssessment)
    End Sub

    Private Sub PTSDResultForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If PTSDTest.scorer <= 3 Then
            testResult.Text = PTSDNegative
        ElseIf PTSDTest.scorer <= 5 Then
            testResult.Text = PTSDPositive
        End If

        Dim radioButtonGroup As RadioButton() = PTSDTest.Panel1.Controls.OfType(Of RadioButton)().ToArray()
        ' Find the selected radio button
        Dim selectedRadioButton As RadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)

        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q1.Text = selectedText
        End If

        radioButtonGroup = PTSDTest.Panel3.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q2.Text = selectedText
        End If

        radioButtonGroup = PTSDTest.Panel4.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q3.Text = selectedText
        End If

        radioButtonGroup = PTSDTest.Panel5.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q4.Text = selectedText
        End If

        radioButtonGroup = PTSDTest.Panel6.Controls.OfType(Of RadioButton)().ToArray()
        selectedRadioButton = radioButtonGroup.FirstOrDefault(Function(radioButton) radioButton.Checked)
        If selectedRadioButton IsNot Nothing Then
            ' Get the text of the selected radio button
            Dim selectedText As String = selectedRadioButton.Text
            q5.Text = selectedText
        End If


        Dim labelArray() As Label = {q1, q2, q3, q4, q5}
        AddLabelsToQueue(labelArray)
        addRecord(testResult.Text)

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If MainForm.hasAccount Then
            generateReport("PTSDTest")
        Else
            Dim result As DialogResult = MessageBox.Show("You cannot print your report as you are not logged in, to print result please LogIn!", "CONFIRMATION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim loginForm As DialogResult = UserLogin.ShowDialog()
            End If
        End If
    End Sub
End Class