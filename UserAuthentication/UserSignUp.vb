Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class UserSignUp

    Public connectionName As String = DatabaseConfiguration.DataSourceUserAuthentication
    Public connection As New SQLiteConnection(connectionName)


    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------'
    'FUNCTIONS AND METHODS


    Public Function insertUser()
        Try
            'connection.Open()

            If connection.State = ConnectionState.Open Then
                'Create Table if not exists in the database
                Dim createTableString As String = "CREATE TABLE IF NOT EXISTS user_accounts ( " &
                                                  "ID TEXT PRIMARY KEY," &
                                                  "Name TEXT, " &
                                                  "Username TEXT NOT NULL, " &
                                                  "Password TEXT NOT NULL, " &
                                                  "IsActive TEXT NOT NULL)"
                ' Execute the query
                Dim createTableCommand As New SQLiteCommand(createTableString, connection)
                createTableCommand.ExecuteNonQuery()

                ' Get value from form
                Dim schoolID As String = txtSchoolID.Text.Replace("-", "")
                Dim name As String = txtName.Text
                Dim username As String = txtUsername.Text
                Dim password As String = txtPassword.Text
                Dim insertQuery As String = "INSERT INTO user_accounts (ID, Name, Username, Password, IsActive) VALUES (@ID, @Name, @Username, @Password,@IsActive)"
                Dim command As New SQLiteCommand(insertQuery, connection)

                ' Add parameters
                command.Parameters.AddWithValue("@ID", schoolID)
                command.Parameters.AddWithValue("@Name", name)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)
                command.Parameters.AddWithValue("@IsActive", "PENDING")

                ' Execute the query
                command.ExecuteNonQuery()


                Dim createUserHistory As String = "CREATE TABLE IF NOT EXISTS _" & schoolID & "(ID INTEGER PRIMARY KEY AUTOINCREMENT," &
                                                   "AssessmentCategory TEXT," &
                                                   "TestResult TEXT," &
                                                   "PatientResponse TEXT," &
                                                   "DateTaken TEXT);"
                ' Execute the query
                Dim createUserHistoryCommand As New SQLiteCommand(createUserHistory, connection)

                createUserHistoryCommand.ExecuteNonQuery()



                MsgBox("Account has been sent to admin for confirmation, please contact the admin!", vbOK, "Welcome to SymptoMedic!")


            Else
                Console.WriteLine("Bad Connection")
            End If
            ' Connection is successful
        Catch ex As Exception

            MsgBox(ex.Message, vbOK)
        Finally
            connection.Close()
        End Try
        Return 0
    End Function

    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------'
    'EVENT HANDLERS

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()

        MainForm.Enabled = True
        MainForm.Show()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        ' Open the signup form or perform signup logic here
        Dim loginForm As New UserLogin()
        loginForm.ShowDialog()
        Me.Dispose()
    End Sub



    Public Function IsUsernameExists(username As String) As Boolean
        Try
            connection.Open()

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

        End Try

    End Function

    Private Sub btnSignIn_Click_1(sender As Object, e As EventArgs) Handles btnSignIn.Click
        If txtPassword.Text = txtConfirmPassword.Text Then
            Dim userExists As Boolean = IsUsernameExists(txtUsername.Text)
            If userExists Then
                MsgBox("Username already used!", vbOK, "Username Exists")
            Else
                If Not String.IsNullOrEmpty(txtUsername.Text) And Not String.IsNullOrEmpty(txtPassword.Text) Then
                    insertUser()
                    Me.Dispose()
                    MainForm.Enabled = True
                    MainForm.Show()
                    MainForm.CloseMenuBar()
                Else
                    MsgBox("Textbox is empty. Please enter a value.", vbInformation, "Empty Value!")
                End If
            End If
        Else
            MsgBox("Password doesn't match! Please try again!", vbOK, "Mismatch Password")
        End If
    End Sub
End Class