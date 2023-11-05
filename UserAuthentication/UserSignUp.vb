Imports System.Data.SQLite

Public Class UserSignUp

    Public connectionName As String = "Data Source=C:\Users\Administrator\source\repos\OOP-Project-Health Symptom Analysis\database\userAuthentication.sqlite;Version=3;"
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


    Public Function connectDB()
        Try
            connection.Open()

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



                MsgBox("Account Created Successfully!", vbOK, "Welcome to SymptoMedic!")
            Else
                Console.WriteLine("Bad Connection")
            End If
            ' Connection is successful
        Catch ex As Exception

            MsgBox("Connection Exception!", vbOK)
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
        If Not String.IsNullOrEmpty(txtUsername.Text) And Not String.IsNullOrEmpty(txtPassword.Text) Then
            connectDB()
            Me.Dispose()
            MainForm.Enabled = True
            MainForm.Show()
        Else
            MsgBox("Textbox is empty. Please enter a value.", vbInformation, "Empty Value!")
        End If



    End Sub
End Class