Imports System.Data.SQLite
Imports CrystalDecisions.CrystalReports.Engine

Public Class UserReportFormAll
    Public userAuthenticationString As String = DatabaseConfiguration.DataSourceUserAuthentication
    Dim dataTable As New DataTable()
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
        LoadData()
        report.SetDataSource(dataTable)
        'ShowReport(report)
        CrystalReportViewer1.ReportSource = report
    End Sub

    Private Sub LoadData()

        If connection.State <> ConnectionState.Open Then
            connection.Open()
        End If

        Using Localconnection As New SQLiteConnection(userAuthenticationString)

            Dim query As String = "SELECT ID, Name, Username FROM user_accounts"
            Using adapter As New SQLiteDataAdapter(query, Localconnection)
                adapter.Fill(dataTable)

            End Using
        End Using

    End Sub
End Class