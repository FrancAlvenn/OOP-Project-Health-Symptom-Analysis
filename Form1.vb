Public Class Form1
    Private selectedLabel As Label = Nothing

    'Funtions and Methods

    'Form Change in a Panel
    Sub childForm(ByVal panel As Form)
        pnlChangeable.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        pnlChangeable.Controls.Add(panel)
        panel.Show()
    End Sub

    'Round Button Function
    Private Sub RoundCornerButton(button As Button)
        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.BackColor = Color.FromArgb(5, 121, 203)
        button.ForeColor = Color.White
        button.Cursor = Cursors.Hand

        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        'top left
        rad.AddArc(New Rectangle(0, 0, 10, 10), 180, 90)
        rad.AddLine(10, 0, button.Width - 10, 0)
        'top right
        rad.AddArc(New Rectangle(button.Width - 10, 0, 10, 10), -90, 90)
        rad.AddLine(button.Width, 10, button.Width, button.Height - 10)
        'bottom right
        'to change the bottom right the x,y,width,height must be same
        rad.AddArc(New Rectangle(button.Width - 15, button.Height - 15, 15, 15), 0, 90)
        rad.AddLine(button.Width - 10, button.Height, 10, button.Height)
        'bottom left
        rad.AddArc(New Rectangle(0, button.Height - 10, 10, 10), 90, 90)
        button.Region = New Region(rad)
    End Sub

    'Funtion to Change ForeColor
    Private Sub changeForeColor(sender As Object)
        Dim clickedLabel As Label = DirectCast(sender, Label)

        ' Reset the properties of the previously selected label (if any)
        If selectedLabel IsNot Nothing AndAlso selectedLabel IsNot clickedLabel Then
            selectedLabel.ForeColor = Color.Black
        End If

        ' Set the properties of the clicked label
        clickedLabel.ForeColor = Color.FromArgb(5, 121, 203)

        ' Update the selected label
        selectedLabel = clickedLabel
    End Sub


    'Round Panel Function
    Private Sub RoundCornerPanel(panel As Panel)
        panel.BorderStyle = FlatStyle.Flat

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


    Private Sub CloseMenuBar()
        'Closes Menu Bar if open
        If pnlMenu.Width > 0 Then
            TimerPanelDecrease.Enabled = True
        End If
    End Sub



    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------'

    'Event Handlers

    'Form Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'databaseConnection.APISymptoms()
        'databaseConnection.APIIssues()
        'databaseConnection.APIIssueSpecific()
        'APIBodyLocations()
        'APIBodyLocationSpecific()
        APIBodySymptom()

        RoundCornerPanel(pnlChangeable)
        RoundCornerPanel(pnlUserInfo)
        'fucntion call to get childform
        childForm(Home)
        'function call to change Fore Color of MenuBar
        changeForeColor(lblHome)





    End Sub

    'lblBMICalculator_Click
    Private Sub lblBMICalculator_Click(sender As Object, e As EventArgs) Handles lblBMICalculator.Click
        'fucntion call to get childform
        childForm(BMIChecker)
        'function call to change Fore Color of MenuBar
        changeForeColor(sender)
        'Close Menubar if open
        CloseMenuBar()
    End Sub

    'lblHome_Click
    Private Sub lblHome_Click(sender As Object, e As EventArgs) Handles lblHome.Click

        'fucntion call to get childform
        childForm(Home)
        'function call to change Fore Color of MenuBar
        changeForeColor(sender)
        'Close Menubar if open
        CloseMenuBar()
    End Sub

    'lblSymptomChecker_Click
    Private Sub lblSymptomChecker_Click(sender As Object, e As EventArgs) Handles lblSymptomChecker.Click
        'fucntion call to get childform
        childForm(SymptomChecker)
        'function call to change Fore Color of MenuBar
        changeForeColor(sender)
        'Close Menubar if open
        CloseMenuBar()
    End Sub

    'DrugsMedicine_Click
    Private Sub lblDrugsMedicine_Click(sender As Object, e As EventArgs) Handles lblDrugsMedicine.Click
        'fucntion call to get childform
        childForm(DrugsMedicine)
        'function call to change Fore Color of MenuBar
        changeForeColor(sender)
        'Close Menubar if open
        CloseMenuBar()
    End Sub

    'Records_Click
    Private Sub lblRecords_Click(sender As Object, e As EventArgs) Handles lblRecords.Click
        'fucntion call to get childform
        childForm(Records)
        'function call to change Fore Color of MenuBar
        changeForeColor(sender)
        'Close Menubar if open
        CloseMenuBar()
    End Sub

    'About_Click
    Private Sub lblAbout_Click(sender As Object, e As EventArgs) Handles lblAbout.Click
        'fucntion call to get childform
        childForm(About)
        'function call to change Fore Color of MenuBar
        changeForeColor(sender)
        'Close Menubar if open
        CloseMenuBar()
    End Sub

    'btnMenu_Click
    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click

        If pnlMenu.Width > 230 Then
            TimerPanelDecrease.Enabled = True
        Else
            TimerPanelIncrease.Enabled = True
        End If
    End Sub

    'btnClose
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        CloseMenuBar()
    End Sub

    Private Sub TimerPanelDecrease_Tick(sender As Object, e As EventArgs) Handles TimerPanelDecrease.Tick
        If pnlMenu.Width > 0 Then
            pnlMenu.Width -= 10
        Else
            TimerPanelDecrease.Enabled = False
        End If
    End Sub

    Private Sub TimerPanelIncrease_Tick(sender As Object, e As EventArgs) Handles TimerPanelIncrease.Tick
        If pnlMenu.Width < 230 Then
            pnlMenu.Width += 10
        Else
            TimerPanelIncrease.Enabled = False
        End If
    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        CloseMenuBar()
    End Sub
End Class
