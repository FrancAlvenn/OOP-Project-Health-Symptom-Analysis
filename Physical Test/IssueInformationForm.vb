Public Class IssueInformationForm
    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        MainForm.childForm(SymptomCheckerResult)
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        generateIssueSpecificReport()
    End Sub
End Class