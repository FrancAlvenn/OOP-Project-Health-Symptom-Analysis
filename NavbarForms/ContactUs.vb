Imports System.Data.SQLite
Imports System.Net.Mail

Public Class ContactUs
    Public random As New Random()
    Public generatedNumbers As New HashSet(Of Integer)()
    Public randomNum As Integer
    Public connectionString As String = "Data Source=C:/Users/Administrator/source/repos/OOP-Project-Health Symptom Analysis/database/adminAuthentication.sqlite;"
    Public connection As New SQLiteConnection(connectionString)


    Public Function GenerateUniqueRandom() As Integer
        Do
            randomNum = Random.Next(100000, 999999)
        Loop While generatedNumbers.Contains(randomNum)
        generatedNumbers.Add(randomNum)
        Return randomNum
    End Function

    Public Function insertMessage()
        Try
            connection.Open()
            If connection.State = ConnectionState.Open Then

                ' Get value from form
                GenerateUniqueRandom()
                Dim accountNumber As Integer = "800" & randomNum.ToString
                Dim insertQuery As String = "INSERT INTO feedback (ID, Fullname, Email, Message) VALUES (@ID, @Fullname, @Email, @Message);"
                Dim command As New SQLiteCommand(insertQuery, connection)

                ' Add parameters
                command.Parameters.AddWithValue("@ID", accountNumber)
                command.Parameters.AddWithValue("@Fullname", txtFullname.Text)
                command.Parameters.AddWithValue("@Email", txtEmail.Text)
                command.Parameters.AddWithValue("@Message", txtMessage.Text)
                ' Execute the query
                command.ExecuteNonQuery()

                MsgBox("Thank you for your feedback!", vbInformation, "Message Sent Succesfully!")
            Else
                MsgBox("Please Complete the Feedback Form! Thank You!", vbInformation, "Warning!")
            End If
            ' Connection is successful
        Catch ex As Exception

            MsgBox(ex.Message, vbOK)
        Finally
            connection.Close()
        End Try
        Return 0
    End Function
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        insertMessage()
    End Sub
End Class