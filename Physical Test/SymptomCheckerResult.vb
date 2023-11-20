Imports System.Data.SQLite

Public Class SymptomCheckerResult
    Dim itemCount As Integer = 0
    Dim itemCount2 As Integer = 0
    Public clickedLabel As Label
    Public description, medicalCondition, possibleSymptoms, profName, treatmentDescription As String

    'clicked label funtion
    Private previousClickedLabel As Label
    Private Sub Label_Click(sender As Object, e As EventArgs)
        ' Cast sender to Label
        clickedLabel = DirectCast(sender, Label)

        ' Reset styles for the previousClickedLabel if it exists
        If previousClickedLabel IsNot Nothing Then
            previousClickedLabel.BackColor = Color.Transparent
            previousClickedLabel.Font = New Font("Microsoft Tai Le", 10, FontStyle.Regular)
        End If


        For Each control As Control In tableDiagnosis.Controls
            If TypeOf control Is Label Then
                control.BackColor = Color.Transparent ' Set the default background color (Transparent)
                control.Font = New Font("Microsoft Tai Le", 10, FontStyle.Regular)
            End If
        Next

        clickedLabel.Font = New Font("Microsoft Tai Le", 10, FontStyle.Bold)
        clickedLabel.BackColor = Color.FromArgb(162, 220, 245)

        ' Update the reference to the previously clicked label
        previousClickedLabel = clickedLabel
    End Sub
    Private Sub SymptomCheckerResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 20
            If itemCount < 20 Then
                Dim newLabel As New Label()

                If BMICalc.IssueName.Count > 0 Then
                    newLabel.Text = BMICalc.IssueName.Dequeue
                    newLabel.AutoSize = True
                    newLabel.Font = New Font("Microsoft Tai Le", 10, FontStyle.Regular)
                    newLabel.Dock = DockStyle.Fill
                    newLabel.TextAlign = ContentAlignment.MiddleLeft

                    AddHandler newLabel.Click, AddressOf Label_Click

                    Dim row As Integer = 0
                    Dim column As Integer = 0

                    tableDiagnosis.Controls.Add(newLabel, column, row)
                    itemCount += 1

                End If




            Else
                MsgBox("Too many diagnosis!")
            End If
        Next


        For i As Integer = 1 To 15
            If itemCount2 < 15 Then
                Dim newLabel As New Label()

                If BMICalc.queueSymptomName.Count > 0 Then
                    newLabel.Text = BMICalc.queueSymptomName.Dequeue
                    newLabel.AutoSize = True
                    newLabel.Font = New Font("Microsoft Tai Le", 10, FontStyle.Regular)
                    newLabel.Dock = DockStyle.Fill
                    newLabel.TextAlign = ContentAlignment.MiddleLeft

                    AddHandler newLabel.Click, AddressOf Label_Click

                    Dim row As Integer = 0
                    Dim column As Integer = 0

                    tblSymptoms.Controls.Add(newLabel, column, row)
                    itemCount2 += 1

                End If




            Else
                MsgBox("Too many symptoms!")
            End If
        Next


    End Sub

    Private Sub backButton_Click(sender As Object, e As EventArgs) Handles backButton.Click
        MainForm.childForm(PhysicalAssessment)
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        MainForm.childForm(PhysicalAssessment)
    End Sub

    Private Sub btnConfirmSelection_Click(sender As Object, e As EventArgs) Handles btnConfirmSelection.Click
        Dim connectionString As String = "Data Source=C:/Users/Administrator/source/repos/OOP-Project-Health Symptom Analysis/database/systemDatabase.sqlite;"

        Try
            'bodylocations
            ' Create a new connection
            If clickedLabel.Text <> "" Then
                Using connection As New SQLiteConnection(connectionString)
                    connection.Open()

                    ' Your SQL query to retrieve data
                    Dim query As String = "SELECT * FROM tblIssueSpecific WHERE Name = '" & clickedLabel.Text & "';"

                    ' Create a command and execute the query
                    Using command As New SQLiteCommand(query, connection)
                        Using reader As SQLiteDataReader = command.ExecuteReader()
                            ' Read data and add it to ComboBox
                            While reader.Read()
                                description = reader("Description").ToString()
                                medicalCondition = reader("MedicalCondition").ToString()
                                possibleSymptoms = reader("PossibleSymptoms").ToString()
                                profName = reader("ProfName").ToString()
                                treatmentDescription = reader("TreatmentDescription").ToString()
                            End While
                        End Using
                    End Using
                End Using
                IssueInformationForm.txtName.Text = clickedLabel.Text
                IssueInformationForm.txtProfname.Text = profName
                IssueInformationForm.txtDesc.Text = description
                IssueInformationForm.txtMedicalCondition.Text = medicalCondition
                IssueInformationForm.txtPossibleSymtoms.Text = possibleSymptoms
                IssueInformationForm.txtTreatmentDesc.Text = treatmentDescription
                MainForm.childForm(IssueInformationForm)

            Else
                MsgBox("Please select an Issue to check!", vbInformation, "No Issue Selected")
            End If
        Catch ex As Exception
            MsgBox("Bad Connection, try again later!", vbInformation, "Error! ")
        End Try


    End Sub
End Class