Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class UserSignUp

    Public connectionName As String = DatabaseConfiguration.DataSourceUserAuthentication
    Public connection As New SQLiteConnection(connectionName)

    Public random As New Random()
    Public generatedNumbers As New HashSet(Of Integer)()
    Public randomNum As Integer
    Public Function GenerateUniqueRandom() As Integer
        Do
            randomNum = random.Next(100000, 999999)
        Loop While generatedNumbers.Contains(randomNum)
        generatedNumbers.Add(randomNum)
        Return randomNum
    End Function

    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------'
    'FUNCTIONS AND METHODS


    Public Function insertUser()
        Try
            'connection.Open()

            If connection.State = ConnectionState.Open Then
                'Create Table if not exists in the database
                Dim createTableString As String = "CREATE TABLE IF NOT EXISTS user_accounts ( " &
                                                  "ID INTEGER PRIMARY KEY," &
                                                  "Name TEXT, " &
                                                  "Username TEXT NOT NULL, " &
                                                  "Password TEXT NOT NULL )"
                ' Execute the query
                Dim createTableCommand As New SQLiteCommand(createTableString, connection)
                createTableCommand.ExecuteNonQuery()

                ' Get value from form
                GenerateUniqueRandom()
                Dim accountNumber As Integer = "800" & randomNum.ToString
                Dim name As String = txtName.Text
                Dim username As String = txtUsername.Text
                Dim password As String = txtPassword.Text
                Dim insertQuery As String = "INSERT INTO user_accounts (ID, Name, Username, Password) VALUES (@ID, @Name, @Username, @Password)"
                Dim command As New SQLiteCommand(insertQuery, connection)

                ' Add parameters
                command.Parameters.AddWithValue("@ID", accountNumber)
                command.Parameters.AddWithValue("@Name", name)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                ' Execute the query
                command.ExecuteNonQuery()


                Dim createUserHistory As String = "CREATE TABLE IF NOT EXISTS _" & UserLogin.userID & " (ID INTEGER PRIMARY KEY AUTOINCREMENT," &
                                                   "AssessmentCategory TEXT," &
                                                   "TestResult TEXT," &
                                                   "PatientResponse TEXT," &
                                                   "DateTaken TEXT);"
                ' Execute the query
                Dim createUserHistoryCommand As New SQLiteCommand(createTableString, connection)
                createUserHistoryCommand.ExecuteNonQuery()



                MsgBox("Account Created Successfully! Proceed to LogIn!", vbOK, "Welcome to SymptoMedic!")


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

    Private Sub btnSignIn_Click(sender As Object, e As EventArgs) Handles btnSignIn.Click

        Dim userExists As Boolean = IsUsernameExists(txtUsername.Text)
        If userExists Then
            MsgBox("Username already used!", vbOK, "Username Exists")
        Else
            If Not String.IsNullOrEmpty(txtUsername.Text) And Not String.IsNullOrEmpty(txtPassword.Text) Then
                insertUser()
                Me.Dispose()
                MainForm.Enabled = True
                MainForm.Show()
            Else
                MsgBox("Textbox is empty. Please enter a value.", vbInformation, "Empty Value!")
            End If
        End If
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
End Class