Public Class Form1
    Private selectedLabel As Label = Nothing
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundCornerButton(btnSubmit)
        RoundCornerButton(btnClear)
        RoundCornerButton(btnRemove)

    End Sub


    Private Sub lblBMICalculator_Click(sender As Object, e As EventArgs) Handles lblBMICalculator.Click
        'fucntion call to get childform
        childForm(BMIChecker)
        'function call to change Fore Color of MenuBar
        changeForeColor(sender)
    End Sub

    Private Sub lblHome_Click(sender As Object, e As EventArgs) Handles lblHome.Click
        'fucntion call to get childform
        childForm(Home)
        'function call to change Fore Color of MenuBar
        changeForeColor(sender)
    End Sub



    '-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------'
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
        rad.AddLine(button.Width - 10, button.Width, 10, button.Height)
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


End Class
