Imports CrystalDecisions.CrystalReports.Engine

Public Class UserReportFormAll
    Public Sub SetReport(report As ReportClass)
        CrystalReportViewer1.ReportSource = report
    End Sub
    Private Sub ShowReport(report As ReportClass)
        ' Set the report to the CrystalReportViewer in the form
        Me.SetReport(report)

        ' Show the CrystalReportViewerForm
        Me.Show()
    End Sub

    Private Sub UserReportFormAll_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim report As ReportClass
        report = New AllUserReport()

        ShowReport(report)
    End Sub
End Class