Public Class AdminForm

    Sub childForm(ByVal panel As Form)
        SubPanel.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        SubPanel.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub TimerPanelDecrease_Tick(sender As Object, e As EventArgs) Handles TimerPanelDecrease.Tick
        If pnlMenu.Width > 65 Then
            pnlMenu.Width -= 50
            seperator1.Visible = False
            seperator2.Visible = False
            SubPanel.Enabled = True
        Else
            TimerPanelDecrease.Enabled = False
        End If
    End Sub

    Private Sub TimerPanelIncrease_Tick(sender As Object, e As EventArgs) Handles TimerPanelIncrease.Tick
        If pnlMenu.Width < 270 Then
            pnlMenu.Width += 50
            seperator1.Visible = True
            seperator2.Visible = True
            SubPanel.Enabled = False
        Else
            TimerPanelIncrease.Enabled = False
        End If
    End Sub


    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If pnlMenu.Width >= 270 Then
            TimerPanelDecrease.Enabled = True
        Else
            TimerPanelIncrease.Enabled = True
        End If
    End Sub


    Private Sub MainFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        childForm(AdminHome)
    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        childForm(UserManagementForm)
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        childForm(AdminHome)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        childForm(ViewFeedbackForm)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "CONFIRMATION",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            MainForm.hasAccount = False
            MainForm.Show()
            Me.Dispose()
        End If

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        childForm(UserReportFormAll)
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        childForm(AdminAbout)
    End Sub
End Class