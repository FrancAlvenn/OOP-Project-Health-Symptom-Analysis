Public Class MainForm
    Inherits Windows.Forms.Form
    Private selectedLabel As Label = Nothing
    Public hasAccount As Boolean

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
    Public Sub changeForeColor(sender As Object)
        Dim clickedLabel As Label = DirectCast(sender, Label)

        ' Reset the properties of the previously selected label (if any)
        If selectedLabel IsNot Nothing AndAlso selectedLabel IsNot clickedLabel Then
            selectedLabel.ForeColor = Color.White
        End If

        ' Set the properties of the clicked label
        clickedLabel.ForeColor = Color.FromArgb(137, 207, 240)

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


    Private Sub DrawFormGradient(ByVal TopColor As Color, ByVal BottomColor As Color)
        Dim objBrush As New Drawing2D.LinearGradientBrush(Me.DisplayRectangle, TopColor, BottomColor, Drawing2D.LinearGradientMode.BackwardDiagonal)
        Dim objGraphics As Graphics = Me.CreateGraphics
        objGraphics.FillRectangle(objBrush, Me.DisplayRectangle)
        objBrush.Dispose()
        objGraphics.Dispose()

    End Sub



    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------'

    'Event Handlers

    'Form Load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'API CALLS (Don't Touch)
        '-----------------------------------------------------------------------------'
        'databaseConnection.APISymptoms()
        'databaseConnection.APIIssues()
        'databaseConnection.APIIssueSpecific()
        'APIBodyLocations()
        'APIBodyLocationSpecific()
        'APIBodySymptom()
        '-----------------------------------------------------------------------------'



        RoundCornerPanel(pnlChangeable)
        'RoundCornerPanel(pnlUserInfo)

        'fucntion call to get childform
        childForm(Home)
        'function call to change Fore Color of MenuBar
        changeForeColor(lblHome)



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

    'PhysicalAssessment_Click
    Private Sub lblPhysicalAssessment_Click(sender As Object, e As EventArgs) Handles lblPhysicalAssessment.Click

        'check if user has account if not open login Form
        If hasAccount = False Then
            Dim loginForm As DialogResult = UserLogin.ShowDialog()
        End If



        'fucntion call to get childform
        childForm(BMICalc)
        'function call to change Fore Color of MenuBar
        changeForeColor(sender)
        'Close Menubar if open
        CloseMenuBar()
    End Sub

    'lblMentalAssessment_Click
    Private Sub lblMentalAssessment_Click(sender As Object, e As EventArgs) Handles lblMentalAssessment.Click

        'check if user has account if not open login Form
        If hasAccount = False Then
            Dim loginForm As DialogResult = UserLogin.ShowDialog()
        End If

        'fucntion call to get childform
        childForm(MentalAssessment)
        'function call to change Fore Color of MenuBar
        changeForeColor(sender)
        'Close Menubar if open
        CloseMenuBar()


    End Sub


    'Records_Click
    Private Sub lblContactUs_Click(sender As Object, e As EventArgs) Handles lblContactUs.Click
        'fucntion call to get childform
        childForm(ContactUs)
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

        If pnlMenu.Height > 230 Then
            TimerPanelDecrease.Enabled = True
        Else
            TimerPanelIncrease.Enabled = True
        End If
    End Sub

    'btnClose
    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        CloseMenuBar()
    End Sub

    Private Sub TimerPanelDecrease_Tick(sender As Object, e As EventArgs) Handles TimerPanelDecrease.Tick
        If pnlMenu.Height > 0 Then
            pnlMenu.Height -= 320
        Else
            TimerPanelDecrease.Enabled = False
        End If
    End Sub

    Private Sub TimerPanelIncrease_Tick(sender As Object, e As EventArgs) Handles TimerPanelIncrease.Tick
        If pnlMenu.Height < 450 Then
            pnlMenu.Height += 100
        Else
            TimerPanelIncrease.Enabled = False
        End If
    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        CloseMenuBar()
    End Sub


    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        DrawFormGradient(Color.FromArgb(1, 27, 80), Color.FromArgb(63, 86, 187))
    End Sub


End Class
