Imports System.Data.SQLite
Imports System.Collections.Generic
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

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
                    Dim createTableString As String = "CREATE TABLE IF NOT EXISTS _" & UserLogin.userID & " (ID INTEGER PRIMARY KEY AUTOINCREMENT," &
                                                      "AssessmentCategory TEXT," &
                                                      "TestResult TEXT," &
                                                      "PatientResponse TEXT," &
                                                      "DateTaken TEXT);"
                    ' Execute the query
                    Dim createTableCommand As New SQLiteCommand(createTableString, connection)
                    createTableCommand.ExecuteNonQuery()

                    ' Get value from form
                    Dim insertQuery As String = "INSERT INTO _" & UserLogin.userID & " (AssessmentCategory, TestResult, PatientResponse, DateTaken) VALUES (@AssessmentCategory ,@TestResult, @PatientResponse, @DateTaken)"
                    Dim command As New SQLiteCommand(insertQuery, connection)



                    ' Add parameters
                    command.Parameters.AddWithValue("@AssessmentCategory", MentalAssessment.assessmentCategory)
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

    Public Sub generateReport(testType As String)
        ' Connection string for SQLite in-memory database
        Dim connectionString As String = "Data Source=C:\Users\Administrator\source\repos\OOP-Project-Health Symptom Analysis\database\userAuthentication.sqlite;"
        Dim report As ReportClass
        ' Create an SQLite connection
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()


            ' Load the data from the database into a DataTable
            Dim dataTable As New System.Data.DataTable()
            Using adapter As New SQLiteDataAdapter("SELECT * FROM _" & UserLogin.userID & " WHERE AssessmentCategory = """ & testType & """ ORDER BY DateTaken DESC LIMIT 1;", connection)
                adapter.Fill(dataTable)
            End Using

            Select Case testType
                Case "AddictionTest"
                    report = New AddictionTestReport()
                Case "ADHDTest"
                    report = New ADHDTestReport()
                Case "AnxietyTest"
                    report = New AnxietyTestReport()
                Case "DepressionTest"
                    report = New DepressionTestReport()
                Case "PTSDTest"
                    report = New PTSDTestReport()
            End Select

            ' Set parameters from DataTable values
            If dataTable.Rows.Count > 0 Then
                report.SetParameterValue("TestResult", dataTable.Rows(0)("TestResult").ToString())
                report.SetParameterValue("PatientResponses", dataTable.Rows(0)("PatientResponse").ToString())

                Select Case testType
                    Case "AddictionTest"
                        'get patient responses
                        Dim patientResponseString As String = dataTable.Rows(0)("PatientResponse").ToString()
                        Dim responsesArray As String() = patientResponseString.Split(","c)
                        report.SetParameterValue("q1", responsesArray(0))
                        report.SetParameterValue("q2", responsesArray(1))
                        report.SetParameterValue("q3", responsesArray(2))
                        report.SetParameterValue("q4", responsesArray(3))
                        report.SetParameterValue("q5", responsesArray(4))
                    Case "ADHDTest"
                        'get patient responses
                        Dim patientResponseString As String = dataTable.Rows(0)("PatientResponse").ToString()
                        Dim responsesArray As String() = patientResponseString.Split(","c)
                        report.SetParameterValue("q1", responsesArray(0))
                        report.SetParameterValue("q2", responsesArray(1))
                        report.SetParameterValue("q3", responsesArray(2))
                        report.SetParameterValue("q4", responsesArray(3))
                        report.SetParameterValue("q5", responsesArray(4))
                        report.SetParameterValue("q6", responsesArray(5))
                        report.SetParameterValue("q7", responsesArray(6))
                        report.SetParameterValue("q8", responsesArray(7))
                        report.SetParameterValue("q9", responsesArray(8))
                        report.SetParameterValue("q10", responsesArray(9))
                        report.SetParameterValue("q11", responsesArray(10))
                        report.SetParameterValue("q12", responsesArray(11))
                        report.SetParameterValue("q13", responsesArray(12))
                        report.SetParameterValue("q14", responsesArray(13))
                        report.SetParameterValue("q15", responsesArray(14))
                        report.SetParameterValue("q16", responsesArray(15))
                        report.SetParameterValue("q17", responsesArray(16))
                        report.SetParameterValue("q18", responsesArray(17))
                    Case "AnxietyTest"
                        'get patient responses
                        Dim patientResponseString As String = dataTable.Rows(0)("PatientResponse").ToString()
                        Dim responsesArray As String() = patientResponseString.Split(","c)
                        report.SetParameterValue("q1", responsesArray(0))
                        report.SetParameterValue("q2", responsesArray(1))
                        report.SetParameterValue("q3", responsesArray(2))
                        report.SetParameterValue("q4", responsesArray(3))
                        report.SetParameterValue("q5", responsesArray(4))
                        report.SetParameterValue("q6", responsesArray(5))
                        report.SetParameterValue("q7", responsesArray(6))
                    Case "DepressionTest"
                        'get patient responses
                        Dim patientResponseString As String = dataTable.Rows(0)("PatientResponse").ToString()
                        Dim responsesArray As String() = patientResponseString.Split(","c)
                        report.SetParameterValue("q1", responsesArray(0))
                        report.SetParameterValue("q2", responsesArray(1))
                        report.SetParameterValue("q3", responsesArray(2))
                        report.SetParameterValue("q4", responsesArray(3))
                        report.SetParameterValue("q5", responsesArray(4))
                        report.SetParameterValue("q6", responsesArray(5))
                        report.SetParameterValue("q7", responsesArray(6))
                        report.SetParameterValue("q8", responsesArray(7))
                        report.SetParameterValue("q9", responsesArray(8))
                    Case "PTSDTest"
                        'get patient responses
                        Dim patientResponseString As String = dataTable.Rows(0)("PatientResponse").ToString()
                        Dim responsesArray As String() = patientResponseString.Split(","c)
                        report.SetParameterValue("q1", responsesArray(0))
                        report.SetParameterValue("q2", responsesArray(1))
                        report.SetParameterValue("q3", responsesArray(2))
                        report.SetParameterValue("q4", responsesArray(3))
                        report.SetParameterValue("q5", responsesArray(4))
                End Select

            End If
            ' Set the report to the CrystalReportViewer
            TestReportForm.CrystalReportViewer1.ReportSource = report
            ShowReport(report)
            connection.Close()

        End Using
    End Sub

    '--------------------------------------------------------------------------------------------------------------------------------
    'Symptom Checker Code Block

    Public symptomCheckerResultString As String

    Public Function AddDiagnosisToQueue(tableLayout As TableLayoutPanel) As String
        For Each control As Control In tableLayout.Controls
            If TypeOf control Is Label Then
                ' Get the text from each label
                Dim labelText As String = DirectCast(control, Label).Text

                ' Add the label value to the queue
                symptomCheckerResultString &= labelText & ","
            End If
        Next

        ' Remove the trailing comma, if any
        If symptomCheckerResultString.EndsWith(",") Then
            symptomCheckerResultString = symptomCheckerResultString.Substring(0, symptomCheckerResultString.Length - 1)
        End If
        Return symptomCheckerResultString
    End Function

    Public symptomCheckerResponseString As String

    Public Function AddSymptomsToQueue(tableLayout As TableLayoutPanel) As String
        For Each control As Control In tableLayout.Controls
            If TypeOf control Is Label Then
                ' Get the text from each label
                Dim labelText As String = DirectCast(control, Label).Text

                ' Add the label value to the queue
                symptomCheckerResponseString &= labelText & ","
            End If
        Next

        ' Remove the trailing comma, if any
        If symptomCheckerResponseString.EndsWith(",") Then
            symptomCheckerResponseString = symptomCheckerResponseString.Substring(0, symptomCheckerResponseString.Length - 1)
        End If
        Return symptomCheckerResponseString
    End Function

    Public Sub addRecordSymptom()
        If MainForm.hasAccount Then
            Try
                connection.Open()
                If connection.State = ConnectionState.Open Then
                    'Create Table if not exists in the database
                    Dim createTableString As String = "CREATE TABLE IF NOT EXISTS _" & UserLogin.userID & " (ID INTEGER PRIMARY KEY AUTOINCREMENT," &
                                                      "AssessmentCategory TEXT," &
                                                      "TestResult TEXT," &
                                                      "PatientResponse TEXT," &
                                                      "DateTaken TEXT);"
                    ' Execute the query
                    Dim createTableCommand As New SQLiteCommand(createTableString, connection)
                    createTableCommand.ExecuteNonQuery()

                    ' Get value from form
                    Dim insertQuery As String = "INSERT INTO _" & UserLogin.userID & " (AssessmentCategory, TestResult, PatientResponse, DateTaken) VALUES (@AssessmentCategory ,@TestResult, @PatientResponse, @DateTaken)"
                    Dim command As New SQLiteCommand(insertQuery, connection)



                    ' Add parameters
                    command.Parameters.AddWithValue("@AssessmentCategory", "SymptomChecker")
                    command.Parameters.AddWithValue("@TestResult", symptomCheckerResultString)
                    command.Parameters.AddWithValue("@PatientResponse", symptomCheckerResponseString)
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


    Public Sub generateSymptomCheckerReport()
        ' Connection string for SQLite in-memory database
        Dim connectionString As String = "Data Source=C:\Users\Administrator\source\repos\OOP-Project-Health Symptom Analysis\database\userAuthentication.sqlite;"
        Dim report As ReportClass
        ' Create an SQLite connection
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()


            ' Load the data from the database into a DataTable
            Dim dataTable As New System.Data.DataTable()
            Using adapter As New SQLiteDataAdapter("SELECT * FROM _" & UserLogin.userID & " WHERE AssessmentCategory = """ & "SymptomChecker" & """ ORDER BY DateTaken DESC LIMIT 1;", connection)
                adapter.Fill(dataTable)
            End Using

            report = New SymptomCheckerResultReport()


            ' Set parameters from DataTable values
            If dataTable.Rows.Count > 0 Then
                report.SetParameterValue("TestResult", dataTable.Rows(0)("TestResult").ToString())
                report.SetParameterValue("PatientResponses", dataTable.Rows(0)("PatientResponse").ToString())


                'get patient responses
                Dim patientResponseString As String = dataTable.Rows(0)("PatientResponse").ToString()
                Dim responsesArray As String() = patientResponseString.Split(","c)

            End If
            ' Set the report to the CrystalReportViewer
            TestReportForm.CrystalReportViewer1.ReportSource = report
            ShowReport(report)
            connection.Close()

        End Using
    End Sub

    Public Sub generateIssueSpecificReport()
        If MainForm.hasAccount Then
            ' Connection string for SQLite in-memory database
            Dim connectionString As String = "Data Source=C:\Users\Administrator\source\repos\OOP-Project-Health Symptom Analysis\database\userAuthentication.sqlite;"
            Dim report As ReportClass
            ' Create an SQLite connection
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()


                ' Load the data from the database into a DataTable
                Dim dataTable As New System.Data.DataTable()
                Using adapter As New SQLiteDataAdapter("SELECT * FROM _" & UserLogin.userID & " WHERE AssessmentCategory = """ & "SymptomChecker" & """ ORDER BY DateTaken DESC LIMIT 1;", connection)
                    adapter.Fill(dataTable)
                End Using

                report = New IssueSpecificReport()


                ' Set parameters from DataTable values
                If dataTable.Rows.Count > 0 Then
                    report.SetParameterValue("Name", IssueInformationForm.txtName.Text)
                    report.SetParameterValue("PatientResponses", dataTable.Rows(0)("PatientResponse").ToString())
                    report.SetParameterValue("ProfessionalName", IssueInformationForm.txtProfname.Text)
                    report.SetParameterValue("Description", IssueInformationForm.txtDesc.Text)
                    report.SetParameterValue("MedicalCondition", IssueInformationForm.txtMedicalCondition.Text)
                    report.SetParameterValue("PossibleSymptoms", IssueInformationForm.txtPossibleSymtoms.Text)
                    report.SetParameterValue("Treatment Description", IssueInformationForm.txtTreatmentDesc.Text)

                End If
                ' Set the report to the CrystalReportViewer
                TestReportForm.CrystalReportViewer1.ReportSource = report
                ShowReport(report)
                connection.Close()

            End Using

        Else
            Dim result As DialogResult = MessageBox.Show("Test Result Not Saved, to save result please LogIn!", "CONFIRMATION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                Dim loginForm As DialogResult = UserLogin.ShowDialog()
            End If
        End If
    End Sub

    Private Sub ShowReport(report As ReportClass)
        ' Create an instance of the CrystalReportViewerForm
        Dim viewerForm As New TestReportForm()

        ' Set the report to the CrystalReportViewer in the form
        viewerForm.SetReport(report)

        ' Show the CrystalReportViewerForm
        viewerForm.ShowDialog()
    End Sub
End Module
