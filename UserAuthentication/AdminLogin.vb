Imports System.Data.SQLite

Public Class AdminLogin
    Public tries As Integer = 0
    Public setTries As Integer = 0
    Public connectionName As String = DatabaseConfiguration.DataSourceAdminAuthentication
    Public connection As New SQLiteConnection(connectionName)

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click
        attemptCheck()
    End Sub

    Private Sub timeOutTimer_Tick(sender As Object, e As EventArgs) Handles timeOutTimer.Tick
        ' Set the initial countdown time (in seconds)
        Static countdown As Integer = 30
        countdown -= 1

        If countdown <= -1 Then
            ' Timer finished, re-enable the login button
            btnSignIn.Enabled = True
            timeOutTimer.Stop()
            MessageBox.Show("Login is now enabled.", "Countdown Finished", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblTimer.Visible = False

            btnClose.Enabled = True
            ' Reset countdown for next use
            tries = 0
            countdown = 30
        Else
            ' Show the countdown in a message box
            lblTimer.Visible = True

            btnClose.Enabled = False
            lblTimer.Text = "Time remaining: " & countdown & " seconds"

        End If
    End Sub

    Private Sub setTriesTimer_Tick(sender As Object, e As EventArgs) Handles setTriesTimer.Tick
        ' Set the initial countdown time (in seconds)
        Static countdown As Integer = 300
        countdown -= 1

        If countdown <= -1 Then
            ' Timer finished, re-enable the login button
            btnSignIn.Enabled = True
            setTriesTimer.Stop()
            MessageBox.Show("Login is now enabled.", "Countdown Finished", MessageBoxButtons.OK, MessageBoxIcon.Information)
            lblTimer.Visible = False

            btnClose.Enabled = True
            ' Reset countdown for next use
            tries = 0
            countdown = 300
        Else
            ' Show the countdown in a message box
            lblTimer.Visible = True

            btnClose.Enabled = False
            lblTimer.Text = "Time remaining: " & countdown & " seconds"

        End If
    End Sub

    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------'
    'FUNCTIONS AND METHODS

    Public Function attemptCheck()

        Try
            connection.Open()

            If connection.State = ConnectionState.Open Then
                ' Connection is successful
                If setTries <= 2 Then
                    If tries < 2 Then
                        logincheck()
                    Else
                        MsgBox("Too many attempts! Try again later")
                        btnSignIn.Enabled = False
                        timeOutTimer.Start()
                        setTries += 1
                    End If
                ElseIf setTries >= 3 Then
                    MsgBox("Too many attempts! Try again later")
                    btnSignIn.Enabled = False
                    setTriesTimer.Start()
                    setTries = +1
                ElseIf setTries = 4 Then
                    MsgBox("Too many attempts! Terminating ...")
                    Me.Dispose()
                End If

            Else
                Console.WriteLine("Bad Connection")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, vbOK)
        Finally
            connection.Close()
        End Try
        Return 0
    End Function

    Public Function logincheck()
        'Selects user from database
        Dim selectUserString As String = "SELECT * FROM admin_accounts WHERE
                                                   Username = @Username AND Password = @Password;"

        ' Execute the query
        Dim command As New SQLiteCommand(selectUserString, connection)


        ' Add parameters
        Dim username As String = txtLoginUsername.Text
        Dim password As String = txtLoginPassword.Text
        command.Parameters.AddWithValue("@Username", username)
        command.Parameters.AddWithValue("@Password", password)

        ' Execute the query
        Dim reader As SQLiteDataReader = command.ExecuteReader()

        'check if the username and password are in the database


        If reader.Read() Then
            ' Successful login
            MessageBox.Show("Login successful!")

            AdminForm.Show()
            Me.Dispose()
            MainForm.Hide()

        Else
            ' Invalid credentials
            MessageBox.Show("Invalid username or password.")
            tries = tries + 1
        End If

        reader.Close()
        txtLoginPassword.Clear()
        txtLoginUsername.Clear()


        Return 0
    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()

        MainForm.Enabled = True
        MainForm.Show()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        ' Open the signup form or perform signup logic here
        Dim loginForm As New UserLogin()
        loginForm.ShowDialog()
        Me.Dispose()
    End Sub
End Class