Imports System.Data.SQLite
Imports System.Net.Http
Imports System.Text.Json

Public Class BMICalc
    Dim itemCount As Integer = 0
    Dim clickedLabel As Label
    Public bodyLocationID As Integer
    Public queueSymptomName As New Queue()
    Public IssueName As New Queue()

    'Functions and Methods

    'Round Corner Button
    Private Sub RoundCornerButton(panel As Button)
        'panel.BorderStyle = FlatStyle.Flat

        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        'top left
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad.AddLine(10, 0, panel.Width - 20, 0)
        'top right
        rad.AddArc(New Rectangle(panel.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(panel.Width, 20, panel.Width, panel.Height - 20)
        'bottom right
        'to change the bottom right the x,y,width,height must be same
        rad.AddArc(New Rectangle(panel.Width - 25, panel.Height - 25, 25, 25), 0, 90)
        rad.AddLine(panel.Width - 10, panel.Height, 20, panel.Height)
        'bottom left
        rad.AddArc(New Rectangle(0, panel.Height - 20, 20, 20), 90, 90)
        panel.Region = New Region(rad)
    End Sub

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


        For Each control As Control In TableLayoutPanel12.Controls
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



    '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------'
    'Event Handlers


    Private Sub PhysicalAssessmentToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'fucntion call to get childform
        MainForm.childForm(PhysicalAssessment)
    End Sub




    Private Sub rdbImperial_CheckedChanged(sender As Object, e As EventArgs) Handles rdbImperial.CheckedChanged
        lblHeight.Text = "ft"
        lblWeight.Text = "lbs"
        txtInch.Visible = True
        lblInch.Visible = True
    End Sub

    Private Sub rdbMetric_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMetric.CheckedChanged
        lblHeight.Text = "cm"
        lblWeight.Text = "kg"
        txtInch.Visible = False
        lblInch.Visible = False
    End Sub


    '==============================================================='
    'Scroll Behavior

    Public targetScrollValue As Integer
    Public currentScrollValue As Integer
    Private Sub scrollTimer_Tick(sender As Object, e As EventArgs) Handles scrollTimer.Tick
        If currentScrollValue < targetScrollValue Then
            currentScrollValue += 25
            Me.VerticalScroll.Value = currentScrollValue
        Else
            scrollTimer.Stop()
        End If
    End Sub

    Private Sub btnBMICalc_Click(sender As Object, e As EventArgs) Handles btnBMICalc.Click
        targetScrollValue = 800 ' Set the target scroll value
        currentScrollValue = Me.VerticalScroll.Value
        scrollTimer.Interval = 10 ' Set the interval for the timer (adjust as needed)
        scrollTimer.Start()
    End Sub
    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        targetScrollValue = 800 ' Set the target scroll value
        currentScrollValue = Me.VerticalScroll.Value
        scrollTimer.Interval = 10 ' Set the interval for the timer (adjust as needed)
        scrollTimer.Start()
    End Sub

    Private Sub btnSymptomChecker_Click(sender As Object, e As EventArgs) Handles btnSymptomChecker.Click
        targetScrollValue = 1700 ' Set the target scroll value
        currentScrollValue = Me.VerticalScroll.Value
        scrollTimer.Interval = 15 ' Set the interval for the timer (adjust as needed)
        scrollTimer.Start()
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
        targetScrollValue = 1700 ' Set the target scroll value
        currentScrollValue = Me.VerticalScroll.Value
        scrollTimer.Interval = 15 ' Set the interval for the timer (adjust as needed)
        scrollTimer.Start()
    End Sub



    '==============================================================='

    'Symptom Checker handler

    Private Sub btnAddSymptom_Click(sender As Object, e As EventArgs) Handles btnAddSymptom.Click
        If cmb_Symptoms.SelectedIndex <> -1 Then
            If itemCount < 15 Then
                Dim newLabel As New Label()
                newLabel.Text = cmb_Symptoms.Text
                newLabel.AutoSize = True
                newLabel.Font = New Font("Microsoft Tai Le", 10, FontStyle.Regular)
                newLabel.Dock = DockStyle.Fill
                newLabel.TextAlign = ContentAlignment.MiddleLeft

                AddHandler newLabel.Click, AddressOf Label_Click

                Dim row As Integer = 0
                Dim column As Integer = 0

                tableLayoutSymptoms.Controls.Add(newLabel, column, row)
                itemCount += 1



                queueSymptomName.Enqueue(cmb_Symptoms.Text)

                cmb_BodyLocation.Items.Clear()
                cmb_Symptoms.Items.Clear()
                cmb_SpecificBodyLocation.Items.Clear()
                BodyLocations()

            Else
                MsgBox("Too many symptoms!")
            End If
        Else
            MsgBox("Please select a symptom to check!", vbInformation, "No Symptom Selected")
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tableLayoutSymptoms.Controls.Clear()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        tableLayoutSymptoms.Controls.Remove(clickedLabel)
        clickedLabel.Dispose()
    End Sub


    Public Function BodyLocations()
        Dim connectionString As String = "Data Source=C:/Users/Administrator/source/repos/OOP-Project-Health Symptom Analysis/database/systemDatabase.sqlite;"
        'Dim connection As New SQLiteConnection(connectionString)

        ' Create a new connection
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            ' Your SQL query to retrieve data
            Dim query As String = "SELECT Name FROM tblBodyLocations"

            ' Create a command and execute the query
            Using command As New SQLiteCommand(query, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    ' Clear existing items in ComboBox
                    cmb_BodyLocation.Items.Clear()

                    ' Read data and add it to ComboBox
                    While reader.Read()
                        cmb_BodyLocation.Items.Add(reader("Name").ToString())
                    End While
                End Using
            End Using
        End Using

        Return 0
    End Function

    Public Function BodyLocationSpecific()
        Dim connectionString As String = "Data Source=C:/Users/Administrator/source/repos/OOP-Project-Health Symptom Analysis/database/systemDatabase.sqlite;"

        ' Create a new connection
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            ' Your SQL query to retrieve data
            Dim query As String = "SELECT Name FROM tblBodyLocationSpecific WHERE BodyLocationID LIKE '" & bodyLocationID & "';"

            ' Create a command and execute the query
            Using command As New SQLiteCommand(query, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    ' Clear existing items in ComboBox
                    cmb_SpecificBodyLocation.Items.Clear()

                    ' Read data and add it to ComboBox
                    While reader.Read()
                        cmb_SpecificBodyLocation.Items.Add(reader("Name").ToString())
                    End While
                End Using
            End Using
        End Using



        Return 0
    End Function

    Public Function APIBodySymptom()
        Dim connectionString As String = "Data Source=C:/Users/Administrator/source/repos/OOP-Project-Health Symptom Analysis/database/systemDatabase.sqlite;"
        Dim bodylocationID As String = "0"
        Dim specificBodyLocation As String = "0"
        'bodylocations
        ' Create a new connection
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            ' Your SQL query to retrieve data
            Dim query As String = "SELECT ID FROM tblBodyLocations WHERE Name = '" & cmb_BodyLocation.SelectedItem & "';"

            ' Create a command and execute the query
            Using command As New SQLiteCommand(query, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    ' Read data and add it to ComboBox
                    While reader.Read()
                        bodylocationID = reader("ID").ToString()
                    End While
                End Using
            End Using
        End Using


        'specific bodylocation
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            ' Your SQL query to retrieve data
            Dim query As String = "SELECT ID FROM tblBodyLocationSpecific WHERE Name = """ & cmb_SpecificBodyLocation.SelectedItem & """;"

            ' Create a command and execute the query
            Using command As New SQLiteCommand(query, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()


                    ' Read data and add it to ComboBox
                    While reader.Read()
                        specificBodyLocation = reader("ID").ToString()
                    End While
                End Using
            End Using
        End Using


        'get symptoms
        Using connection As New SQLiteConnection(connectionString)
            connection.Open()

            ' Your SQL query to retrieve data
            Dim query As String = "SELECT Name FROM tblBodySymptoms WHERE HealthSymptomLocationID LIKE  '" & bodylocationID & "%'  OR HealthSymptomLocationID LIKE '" & specificBodyLocation & "%';"

            ' Create a command and execute the query
            Using command As New SQLiteCommand(query, connection)
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    cmb_Symptoms.Items.Clear()

                    ' Read data and add it to ComboBox
                    While reader.Read()
                        cmb_Symptoms.Items.Add(reader("Name").ToString())
                    End While
                End Using
            End Using
        End Using



    End Function


    Private Sub BMICalc_Load(sender As Object, e As EventArgs) Handles Me.Load
        RoundCornerButton(btnReset)
        RoundCornerButton(btnSubmit)
        'rdbMetric.Select()
        BodyLocations()
    End Sub

    Private Sub cmb_BodyLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_BodyLocation.SelectedIndexChanged
        Select Case cmb_BodyLocation.SelectedItem.ToString()
            Case "Head, throat & neck"
                bodyLocationID = 6
            Case "Arms & shoulder"
                bodyLocationID = 7
            Case "Legs"
                bodyLocationID = 10
            Case "Chest & back"
                bodyLocationID = 15
            Case "Abdomen, pelvis & buttocks"
                bodyLocationID = 16
            Case "Skin, joints & general"
                bodyLocationID = 17
        End Select

        BodyLocationSpecific()
    End Sub

    Private Sub cmb_SpecificBodyLocation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_SpecificBodyLocation.SelectedIndexChanged
        APIBodySymptom()
    End Sub

    Private Sub btnSymptomSubmit_Click(sender As Object, e As EventArgs) Handles btnSymptomSubmit.Click
        If rdb_Male.Checked OrElse rdb_Female.Checked Then
            diagnosis()
        Else
            MsgBox("Please select a gender", vbInformation, "Invalid Gender")
        End If


    End Sub

    Public Function diagnosis()
        Dim connectionString As String = "Data Source=C:/Users/Administrator/source/repos/OOP-Project-Health Symptom Analysis/database/systemDatabase.sqlite;"
        Dim gender As String = "male"
        Dim age As Integer = 2000
        Dim tempAge As Integer

        If rdb_Male.Checked Then
            gender = "male"
        ElseIf rdb_Female.Checked Then
            gender = "female"
        End If

        If Integer.TryParse(txtAge.Text, tempAge) Then
            age = 2023 - tempAge
        Else
            MsgBox("Please enter you age", vbInformation, "Invalid Input")
        End If


        For Each item As Object In queueSymptomName
            'specific bodylocation
            Using connection As New SQLiteConnection(connectionString)
                connection.Open()



                ' Your SQL query to retrieve data
                Dim query As String = "SELECT Name FROM tblIssueSpecific WHERE PossibleSymptoms LIKE '%" & item & "%';"

                ' Create a command and execute the query
                Using command As New SQLiteCommand(query, connection)
                    Using reader As SQLiteDataReader = command.ExecuteReader()
                        ' Read data and add it to ComboBox
                        While reader.Read()
                            IssueName.Enqueue(reader("Name").ToString())
                        End While
                    End Using
                End Using


            End Using
        Next

        MainForm.childForm(SymptomCheckerResult)

    End Function

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_Male.CheckedChanged
    End Sub
End Class