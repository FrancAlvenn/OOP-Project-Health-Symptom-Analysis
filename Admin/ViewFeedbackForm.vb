Imports System.Data.SQLite

Public Class ViewFeedbackForm
    Public userAuthenticationString As String = DatabaseConfiguration.DataSourceAdminAuthentication
    Public connection As New SQLiteConnection(userAuthenticationString)

    Private Sub LoadData()
        Dim dataTable As New DataTable()
        If connection.State <> ConnectionState.Open Then
            connection.Open()
        End If

        Using Localconnection As New SQLiteConnection(userAuthenticationString)

            Dim query As String = "SELECT * FROM feedback"
            Using adapter As New SQLiteDataAdapter(query, Localconnection)
                adapter.Fill(dataTable)

            End Using
        End Using

        dgvFeedbackViewer.DataSource = dataTable
        dgvFeedbackViewer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

    End Sub

    Private Sub Clear()
        txtFullname.Text = ""
        txtEmail.Text = ""
        txtMessage.Text = ""
    End Sub

    Private Sub dgvFeedbackViewer_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFeedbackViewer.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgvFeedbackViewer.RowCount - 1 Then
            ' Access the value of the clicked cell in the first column (index 0)
            Dim ID As Object = dgvFeedbackViewer.Rows(e.RowIndex).Cells(0).Value
            Dim FullName As Object = dgvFeedbackViewer.Rows(e.RowIndex).Cells(1).Value
            Dim Email As Object = dgvFeedbackViewer.Rows(e.RowIndex).Cells(2).Value
            Dim Message As Object = dgvFeedbackViewer.Rows(e.RowIndex).Cells(3).Value

            txtID.Text = ID
            txtFullname.Text = FullName
            txtEmail.Text = Email
            txtMessage.Text = Message
        End If
    End Sub

    Private Sub ViewFeedbackForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        generateFeedbackReport()
    End Sub
End Class