Imports System.Data.SQLite

Public Class UserReportForm
    Public userAuthenticationString As String = DatabaseConfiguration.DataSourceUserAuthentication
    Public connection As New SQLiteConnection(userAuthenticationString)
    Public AssessmentCategory As Object

    Private Sub LoadData()
        Dim dataTable As New DataTable()
        If connection.State <> ConnectionState.Open Then
            connection.Open()
        End If

        Using Localconnection As New SQLiteConnection(userAuthenticationString)

            Dim query As String = "SELECT * FROM _" & UserLogin.userID & ";"
            Using adapter As New SQLiteDataAdapter(query, Localconnection)
                adapter.Fill(dataTable)

            End Using

            Dim query2 As String = "SELECT * FROM user_accounts WHERE ID = @ID"
            Dim command As New SQLiteCommand(query2, connection)
            command.Parameters.AddWithValue("@ID", UserLogin.userID)

            Using reader As SQLiteDataReader = command.ExecuteReader()
                While reader.Read()
                    ' Access values using column names or indices
                    txtID.Text = reader("ID").ToString()
                    txtName.Text = reader("Name").ToString()
                    txtUsername.Text = reader("Username").ToString()
                    txtPassword.Text = reader("Password").ToString()
                End While
            End Using

        End Using

        dgvReports.DataSource = dataTable
        dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        reset()
        Me.AutoScrollPosition = New Point(0, 0)
    End Sub

    Private Sub reset()
        txtName.Enabled = False
        txtPassword.Enabled = False
        txtUsername.Enabled = False

        btnChangeName.Visible = False
        btnChangePassword.Visible = False
        btnChangeUsername.Visible = False
        lblConfirmPassword.Visible = False
        txtConfirmPassword.Visible = False
    End Sub

    Private Sub Clear()
        txtID.Text = ""
        txtName.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub

    Public Function IsUsernameExists(username As String) As Boolean
        Try
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            If connection.State = ConnectionState.Open Then
                Dim usernames As String = txtUsername.Text
                Dim insertQuery As String = "SELECT * FROM user_accounts WHERE Username = @Username"

                Dim command As New SQLiteCommand(insertQuery, connection)
                command.Parameters.AddWithValue("@Username", usernames)

                Using reader As SQLiteDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        ' Username exists
                        Return True
                    Else
                        ' Username does not exist
                        Return False
                    End If
                End Using

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            connection.Close()
        End Try

    End Function

    Private Sub dgvReports_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReports.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgvReports.RowCount - 1 Then
            ' Access the value of the clicked cell in the first column (index 0)
            AssessmentCategory = dgvReports.Rows(e.RowIndex).Cells(1).Value


        End If


    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If AssessmentCategory <> "" Then
            Select Case AssessmentCategory
                Case "AddictionTest"
                    generateReport("AddictionTest")
                Case "ADHDTest"
                    generateReport("ADHDTest")
                Case "AnxietyTest"
                    generateReport("AnxietyTest")
                Case "DepressionTest"
                    generateReport("DepressionTest")
                Case "PTSDTest"
                    generateReport("PTSDTest")
                Case "SymptomChecker"
                    generateSymptomCheckerReport()
            End Select
        Else
            MsgBox("Please select a report to print", vbOK, "Nothing Selected!")
        End If

    End Sub

    Private Sub UserReportForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub iconChangeName_Click(sender As Object, e As EventArgs) Handles iconChangeName.Click
        txtName.Enabled = True
        btnChangeName.Visible = True
    End Sub
    Private Sub iconChangeUsername_Click(sender As Object, e As EventArgs) Handles iconChangeUsername.Click
        txtUsername.Enabled = True
        btnChangeUsername.Visible = True
    End Sub

    Private Sub iconChangePassword_Click(sender As Object, e As EventArgs) Handles iconChangePassword.Click
        txtPassword.Enabled = True
        btnChangePassword.Visible = True
        lblConfirmPassword.Visible = True
        txtConfirmPassword.Visible = True
        txtConfirmPassword.Enabled = True
    End Sub

    Private Sub btnChangeName_Click(sender As Object, e As EventArgs) Handles btnChangeName.Click

        Dim result As DialogResult = MessageBox.Show("Do you want to change Name?", "CONFIRMATION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If txtName.Text <> "" Then
                'Dim connection As New SQLiteConnection(userAuthenticationString)
                Using LocalConnection As New SQLiteConnection(userAuthenticationString)
                    Try
                        If LocalConnection.State <> ConnectionState.Open Then
                            LocalConnection.Open()
                        End If
                        If LocalConnection.State = ConnectionState.Open Then
                            Dim updateQuery As String = "UPDATE user_accounts SET Name = @Name WHERE ID = @ID;"

                            Dim command As New SQLiteCommand(updateQuery, LocalConnection)
                            command.Parameters.AddWithValue("@Name", txtName.Text)
                            command.Parameters.AddWithValue("@ID", txtID.Text)

                            ' Execute the update query
                            command.ExecuteNonQuery()

                            MsgBox("Account updated successfully.", vbOK, "Update Complete!")
                            LoadData()

                        Else
                            MsgBox("Please complete all the inputs!", vbInformation, "Error!")
                        End If

                    Catch ex As Exception
                        MsgBox("ERROR:" & ex.Message)
                    Finally
                        LocalConnection.Close()

                    End Try
                End Using
            End If
        Else
            LoadData()
            reset()
        End If

    End Sub

    Private Sub btnChangeUsername_Click(sender As Object, e As EventArgs) Handles btnChangeUsername.Click

        Dim result As DialogResult = MessageBox.Show("Do you want to change Username?", "CONFIRMATION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            If txtUsername.Text <> "" Then
                Dim userExists As Boolean = IsUsernameExists(txtUsername.Text)
                If userExists Then
                    MsgBox("Username already used!", vbOK, "Username Exists")
                Else
                    Using LocalConnection As New SQLiteConnection(userAuthenticationString)
                        Try
                            If LocalConnection.State <> ConnectionState.Open Then
                                LocalConnection.Open()
                            End If
                            If LocalConnection.State = ConnectionState.Open Then
                                Dim updateQuery As String = "UPDATE user_accounts SET Username = @Username WHERE ID = @ID;"

                                Dim command As New SQLiteCommand(updateQuery, LocalConnection)
                                command.Parameters.AddWithValue("@Username", txtUsername.Text)
                                command.Parameters.AddWithValue("@ID", txtID.Text)

                                ' Execute the update query
                                command.ExecuteNonQuery()

                                MsgBox("Account updated successfully.", vbOK, "Update Complete!")
                                LoadData()

                            Else
                                MsgBox("Please complete all the inputs!", vbInformation, "Error!")
                            End If

                        Catch ex As Exception
                            MsgBox("ERROR:" & ex.Message)
                        Finally
                            LocalConnection.Close()

                        End Try
                    End Using
                End If
            End If
        Else
            LoadData()
            reset()
        End If


    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click

        Dim result As DialogResult = MessageBox.Show("Do you want to change Password?", "CONFIRMATION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            If txtPassword.Text <> "" AndAlso txtPassword.Text = txtConfirmPassword.Text Then
                Dim userExists As Boolean = IsUsernameExists(txtUsername.Text)
                Using LocalConnection As New SQLiteConnection(userAuthenticationString)
                    Try
                        If LocalConnection.State <> ConnectionState.Open Then
                            LocalConnection.Open()
                        End If
                        If LocalConnection.State = ConnectionState.Open Then
                            Dim updateQuery As String = "UPDATE user_accounts SET Password = @Password WHERE ID = @ID;"

                            Dim command As New SQLiteCommand(updateQuery, LocalConnection)
                            command.Parameters.AddWithValue("@Password", txtPassword.Text)
                            command.Parameters.AddWithValue("@ID", txtID.Text)

                            ' Execute the update query
                            command.ExecuteNonQuery()

                            MsgBox("Account updated successfully.", vbOK, "Update Complete!")
                            LoadData()

                        Else
                            MsgBox("Please complete all the inputs!", vbInformation, "Error!")
                        End If

                    Catch ex As Exception
                        MsgBox("ERROR:" & ex.Message)
                    Finally
                        LocalConnection.Close()

                    End Try
                End Using
            Else
                MsgBox("Textbox is empty or password not the same, please try again!", vbOK, "Empty or Mismatch Values")
            End If
        Else
            LoadData()
            reset()
        End If
    End Sub
    Public targetScrollValue As Integer
    Public currentScrollValue As Integer
    Private Sub LoadDatabyCategory()
        Dim dataTable As New DataTable()
        If connection.State <> ConnectionState.Open Then
            connection.Open()
        End If

        Using Localconnection As New SQLiteConnection(userAuthenticationString)

            Dim query As String = "SELECT * FROM _" & UserLogin.userID & " WHERE AssessmentCategory = """ & cmbSortBy.SelectedItem.ToString & """"
            Using adapter As New SQLiteDataAdapter(query, Localconnection)
                adapter.Fill(dataTable)

            End Using
        End Using



        dgvReports.DataSource = dataTable
        dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        reset()
        Me.AutoScrollPosition = New Point(0, 0)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSortBy.SelectedIndexChanged
        LoadDatabyCategory()
        targetScrollValue = 610 ' Set the target scroll value
        currentScrollValue = Me.VerticalScroll.Value
        scrollTimer.Interval = 10 ' Set the interval for the timer (adjust as needed)
        scrollTimer.Start()
    End Sub

    Private Sub scrollTimer_Tick(sender As Object, e As EventArgs) Handles scrollTimer.Tick
        If currentScrollValue < targetScrollValue Then
            currentScrollValue += 610
            Me.VerticalScroll.Value = currentScrollValue
        Else
            scrollTimer.Stop()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadData()
        targetScrollValue = 610 ' Set the target scroll value
        currentScrollValue = Me.VerticalScroll.Value
        scrollTimer.Interval = 10 ' Set the interval for the timer (adjust as needed)
        scrollTimer.Start()
    End Sub
End Class