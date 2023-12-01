Public Class UserReportViewerForm
    Private Sub UserReportForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        crpvUserManagement.ReportSource = userManagementReport1 'document viewer
    End Sub
End Class