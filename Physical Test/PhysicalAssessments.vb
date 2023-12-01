Imports System.Data.SQLite
Imports System.Net.Http
Imports System.Text.Json

Public Class BMICalc
    Public itemCount As Integer = 0
    Public symptomCount As Integer = 0
    Public itemCount2 As Integer = 0
    Dim clickedLabelPhysicalAssessment As Label
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
        clickedLabelPhysicalAssessment = DirectCast(sender, Label)

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

        clickedLabelPhysicalAssessment.Font = New Font("Microsoft Tai Le", 10, FontStyle.Bold)
        clickedLabelPhysicalAssessment.BackColor = Color.FromArgb(162, 220, 245)

        ' Update the reference to the previously clicked label
        previousClickedLabel = clickedLabelPhysicalAssessment
    End Sub

    Private Sub Add_Label()
        For i As Integer = 1 To 20
            If itemCount < 20 Then
                Dim newLabel As New Label()

                If IssueName.Count > 0 And itemCount < 20 Then
                    newLabel.Text = IssueName.Dequeue
                    newLabel.AutoSize = True
                    newLabel.Font = New Font("Microsoft Tai Le", 10, FontStyle.Regular)
                    newLabel.Dock = DockStyle.Fill
                    newLabel.TextAlign = ContentAlignment.MiddleLeft

                    AddHandler newLabel.Click, AddressOf SymptomCheckerResult.Label_Click

                    Dim row As Integer = 0
                    Dim column As Integer = 0

                    SymptomCheckerResult.tableDiagnosis.Controls.Add(newLabel, column, row)
                    itemCount += 1

                End If
            Else
                Return
            End If
        Next


        For i As Integer = 1 To 15
            If itemCount2 < 15 Then
                Dim newLabel As New Label()

                If queueSymptomName.Count > 0 And itemCount2 < 15 Then
                    newLabel.Text = queueSymptomName.Dequeue
                    newLabel.AutoSize = True
                    newLabel.Font = New Font("Microsoft Tai Le", 10, FontStyle.Regular)
                    newLabel.Dock = DockStyle.Fill
                    newLabel.TextAlign = ContentAlignment.MiddleLeft

                    AddHandler newLabel.Click, AddressOf Label_Click

                    Dim row As Integer = 0
                    Dim column As Integer = 0

                    SymptomCheckerResult.tableSymptoms.Controls.Add(newLabel, column, row)
                    itemCount2 += 1

                End If
            Else
                MsgBox("Too many symptoms!")
            End If
        Next

    End Sub



    '------------------------------------------------------------------------------------------------------------------------------------------------------------------------------'
    'Event Handlers


    Private Sub PhysicalAssessmentToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'fucntion call to get childform
        MainForm.childForm(Me)
    End Sub




    Private Sub rdbImperial_CheckedChanged(sender As Object, e As EventArgs) Handles rdbImperial.CheckedChanged
        lblHeight.Text = "ft"
        lblWeight.Text = "lbs"
        txtBMIResult.Text = ""
        txtHeight.Text = ""
        txtWeight.Text = ""
        txtInch.Text = ""
        txtInch.Visible = True
        lblInch.Visible = True
    End Sub

    Private Sub rdbMetric_CheckedChanged(sender As Object, e As EventArgs) Handles rdbMetric.CheckedChanged
        lblHeight.Text = "cm"
        lblWeight.Text = "kg"
        txtBMIResult.Text = ""
        txtHeight.Text = ""
        txtWeight.Text = ""
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
            If symptomCount < 15 Then
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
                symptomCount += 1



                queueSymptomName.Enqueue(cmb_Symptoms.Text)

                cmb_BodyLocation.Items.Clear()
                cmb_Symptoms.Items.Clear()
                cmb_SpecificBodyLocation.Items.Clear()
                BodyLocations()

            Else
                MsgBox("Too many symptoms!")
            End If
        Else
            MsgBox("Please select a symptom!", vbInformation, "No Symptom Selected")
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        tableLayoutSymptoms.Controls.Clear()


        symptomCount = 0

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        tableLayoutSymptoms.Controls.Remove(clickedLabelPhysicalAssessment)
        clickedLabelPhysicalAssessment.Dispose()
    End Sub

    Public Function BodyLocations()
        Dim connectionString As String = DatabaseConfiguration.DataSourceSystemDatabase
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
        Dim connectionString As String = DatabaseConfiguration.DataSourceSystemDatabase

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
        Dim connectionString As String = DatabaseConfiguration.DataSourceSystemDatabase
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
            Dim query As String = "SELECT Name FROM tblBodySymptoms WHERE HealthSymptomLocationID LIKE  '%" & bodylocationID & "%'  AND HealthSymptomLocationID LIKE '%" & specificBodyLocation & "%';"

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
        rdbMetric.Checked = True
        txtHeight.Text = 180
        txtWeight.Text = 65
        txtBMIResult.Text = 20.1

        symptomCount = 0
        itemCount = 0
        itemCount2 = 0

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

        Add_Label()

    End Sub

    Public Function diagnosis()
        Dim connectionString As String = DatabaseConfiguration.DataSourceSystemDatabase
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
                            If IssueName.Count < 20 Then
                                IssueName.Enqueue(reader("Name").ToString())
                            End If

                        End While
                    End Using
                End Using
            End Using
        Next

        MainForm.childForm(SymptomCheckerResult)

    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If rdbMetric.Checked Then
            Dim height As Integer
            Dim weight As Integer
            Dim bmi As Double


            If Integer.TryParse(txtHeight.Text, height) AndAlso Integer.TryParse(txtWeight.Text, weight) Then
                height = Integer.Parse(txtHeight.Text)
                weight = Integer.Parse(txtWeight.Text)
                bmi = weight / (height / 100) ^ 2
                txtBMIResult.Text = Math.Ceiling(bmi * 10D) / 10D
            Else
                MsgBox("Please input a number!", vbOK, "Invalid Input!")
            End If


        ElseIf rdbImperial.Checked Then
            Dim height As Integer
            Dim inch As Integer
            Dim weight As Integer
            Dim bmi As Double
            If Integer.TryParse(txtHeight.Text, height) AndAlso Integer.TryParse(txtInch.Text, inch) AndAlso Integer.TryParse(txtWeight.Text, weight) Then
                height = Integer.Parse(txtHeight.Text)
                inch = Integer.Parse(txtInch.Text)
                weight = Integer.Parse(txtWeight.Text)

                bmi = 703 * (weight / (((height * 12) + inch) ^ 2))

                txtBMIResult.Text = Math.Ceiling(bmi * 10D) / 10D
            Else
                MsgBox("Please input a number!", vbOK, "Invalid Input!")
            End If
        End If
    End Sub

End Class