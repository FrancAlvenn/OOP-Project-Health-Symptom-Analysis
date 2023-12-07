Imports CrystalDecisions.CrystalReports.Engine

Public Class UserReportFormAll

    Private Sub ShowReport(report As ReportClass)
        ' Create an instance of the CrystalReportViewerForm
        Dim viewerForm As New TestReportForm()

        ' Set the report to the CrystalReportViewer in the form
        viewerForm.SetReport(report)

        ' Show the CrystalReportViewerForm
        viewerForm.ShowDialog()
    End Sub
    Private Sub UserReportFormAll_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim report As ReportClass
        report = New AllUserReport()
        ' Set the report to the CrystalReportViewer
        CrystalReportViewer1.ReportSource = report
        ShowReport(report)

    End Sub
End Class