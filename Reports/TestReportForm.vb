Imports CrystalDecisions.CrystalReports.Engine


Public Class TestReportForm


    Public Sub SetReport(report As ReportClass)
        CrystalReportViewer1.ReportSource = report
    End Sub

End Class