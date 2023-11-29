Imports CrystalDecisions.CrystalReports.Engine


Public Class mentalTestReportForm


    Public Sub SetReport(report As ReportClass)
        CrystalReportViewer1.ReportSource = report
    End Sub

End Class