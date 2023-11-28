Imports System.Data.SQLite
Imports System.Collections.Generic

Module MentalHealthRecorder
    Public connectionName As String = "Data Source=C:\Users\Administrator\source\repos\OOP-Project-Health Symptom Analysis\database\userAuthentication.sqlite;"
    Public connection As New SQLiteConnection(connectionName)
    Public patientResponseString As String
    Public Function AddLabelsToQueue(labels As Label()) As String
        For Each label As Label In labels
            ' Get the text from each label
            Dim labelText As String = label.Text

            ' Add the label value to the queue
            patientResponseString &= labelText & ","
        Next

        ' Remove the trailing comma, if any
        If patientResponseString.EndsWith(",") Then
            patientResponseString = patientResponseString.Substring(0, patientResponseString.Length - 1)
        End If

    End Function


    Public Sub addRecord(testResult As String)
        If MainForm.hasAccount Then
            Try
                connection.Open()
                If connection.State = ConnectionState.Open Then
                    'Create Table if not exists in the database
                    MsgBox(UserLogin.userID)
                    Dim createTableString As String = "CREATE TABLE IF NOT EXISTS _" & UserLogin.userID & " (ID INTEGER PRIMARY KEY AUTOINCREMENT," &
                                                      "TestResult TEXT," &
                                                      "PatientResponse TEXT," &
                                                      "DateTaken TEXT);"
                    ' Execute the query
                    Dim createTableCommand As New SQLiteCommand(createTableString, connection)
                    createTableCommand.ExecuteNonQuery()

                    ' Get value from form
                    Dim insertQuery As String = "INSERT INTO _" & UserLogin.userID & " (TestResult, PatientResponse, DateTaken) VALUES (@TestResult, @PatientResponse, @DateTaken)"
                    Dim command As New SQLiteCommand(insertQuery, connection)



                    ' Add parameters
                    command.Parameters.AddWithValue("@TestResult", testResult)
                    command.Parameters.AddWithValue("@PatientResponse", patientResponseString)
                    command.Parameters.AddWithValue("@DateTaken", Date.Today)


                    ' Execute the query
                    command.ExecuteNonQuery()



                    MsgBox("Record Inserted Successfully!", vbOK, "Record Added")

                Else
                    Console.WriteLine("Bad Connection")
                End If
                ' Connection is successful
            Catch ex As Exception

                MsgBox(ex.Message, vbOK)
            Finally
                connection.Close()
            End Try
        Else
            Dim result As DialogResult = MessageBox.Show("Test Result Not Saved, to save result please LogIn!", "CONFIRMATION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim loginForm As DialogResult = UserLogin.ShowDialog()
            End If
        End If



    End Sub
End Module
