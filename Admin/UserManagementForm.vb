Imports System.Data.SQLite

Public Class UserManagementForm

    Public userAuthenticationString As String = "Data Source=C:/Users/Administrator/source/repos/OOP-Project-Health Symptom Analysis/database/userAuthentication.sqlite;"
    Public connection As New SQLiteConnection(userAuthenticationString)

    Private Sub LoadData()
        Dim dataTable As New DataTable()
        If connection.State <> ConnectionState.Open Then
            connection.Open()
        End If

        Using Localconnection As New SQLiteConnection(userAuthenticationString)

            Dim query As String = "SELECT * FROM user_accounts"
            Using adapter As New SQLiteDataAdapter(query, Localconnection)
                adapter.Fill(dataTable)

            End Using
        End Using

        dvgUsers.DataSource = dataTable
        dvgUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

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

    Public Function insertUser()
        Try
            If connection.State <> ConnectionState.Open Then
                connection.Open()
            End If
            If connection.State = ConnectionState.Open Then
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
                LoadData()
                Clear()

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

    Private Sub UserManagementForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub

    Private Sub dvgUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dvgUsers.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dvgUsers.RowCount - 1 Then
            ' Access the value of the clicked cell in the first column (index 0)
            Dim ID As Object = dvgUsers.Rows(e.RowIndex).Cells(0).Value
            Dim Name As Object = dvgUsers.Rows(e.RowIndex).Cells(1).Value
            Dim Username As Object = dvgUsers.Rows(e.RowIndex).Cells(2).Value
            Dim Password As Object = dvgUsers.Rows(e.RowIndex).Cells(3).Value

            txtID.Text = ID
            txtName.Text = Name
            txtUsername.Text = Username
            txtPassword.Text = Password
        End If
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        If connection.State <> ConnectionState.Open Then
            connection.Open()
        End If
        Dim userExists As Boolean = IsUsernameExists(txtUsername.Text)
        If userExists Then
            MsgBox("Username already used!", vbOK, "Username Exists")
        Else
            If Not String.IsNullOrEmpty(txtUsername.Text) And Not String.IsNullOrEmpty(txtPassword.Text) Then
                insertUser()
            Else
                MsgBox("Textbox is empty. Please enter a value.", vbInformation, "Empty Value!")
            End If
        End If
        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtID.Text = ""
        txtName.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim userAuthenticationString As String = "Data Source=C:/Users/Administrator/source/repos/OOP-Project-Health Symptom Analysis/database/userAuthentication.sqlite;"
        'Dim connection As New SQLiteConnection(userAuthenticationString)
        If txtID.Text <> "" AndAlso txtName.Text <> "" AndAlso txtUsername.Text <> "" AndAlso txtPassword.Text <> "" Then
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
                            Dim updateQuery As String = "UPDATE user_accounts SET Name = @Name, Username = @Username, Password = @Password WHERE ID = @ID;"

                            Dim command As New SQLiteCommand(updateQuery, LocalConnection)
                            command.Parameters.AddWithValue("@Name", txtName.Text)
                            command.Parameters.AddWithValue("@Username", txtUsername.Text)
                            command.Parameters.AddWithValue("@Password", txtPassword.Text)
                            command.Parameters.AddWithValue("@ID", txtID.Text)

                            ' Execute the update query
                            command.ExecuteNonQuery()

                            MsgBox("Account updated successfully.", vbOK, "Update Complete!")
                            LoadData()
                            Clear()
                        Else
                            MsgBox("Please select a record to update and complete all the inputs!", vbInformation, "Error!")
                        End If

                    Catch ex As Exception
                        MsgBox("ERROR:" & ex.Message)
                        Console.WriteLine(ex.Message)
                    Finally
                        LocalConnection.Close()

                    End Try
                End Using
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If connection.State <> ConnectionState.Open Then
            connection.Open()
        End If

        If txtID.Text <> "" Then
            Try
                If connection.State = ConnectionState.Open Then
                    Dim deleteQuery As String = "DELETE FROM user_accounts WHERE ID = @ID;"
                    Dim command As New SQLiteCommand(deleteQuery, connection)
                    command.Parameters.AddWithValue("@ID", txtID.Text)
                    ' Execute the delete query
                    command.ExecuteNonQuery()
                    MsgBox("User deleted successfully.", vbOK, "Account Deleted")
                    LoadData()
                    Clear()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox("Please select a record to delete!", vbInformation, "Error!")
        End If

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        UserReportForm.Show()
    End Sub
End Class