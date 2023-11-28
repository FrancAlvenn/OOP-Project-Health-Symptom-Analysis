<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.seperator2 = New System.Windows.Forms.Label()
        Me.seperator1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnReport = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Label()
        Me.btnAbout = New System.Windows.Forms.Label()
        Me.btnUserManagement = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Label()
        Me.TimerPanelIncrease = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPanelDecrease = New System.Windows.Forms.Timer(Me.components)
        Me.SubPanel = New System.Windows.Forms.Panel()
        Me.Timerupdater = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'seperator2
        '
        Me.seperator2.BackColor = System.Drawing.Color.White
        Me.seperator2.ForeColor = System.Drawing.Color.White
        Me.seperator2.Location = New System.Drawing.Point(11, 775)
        Me.seperator2.Name = "seperator2"
        Me.seperator2.Size = New System.Drawing.Size(250, 1)
        Me.seperator2.TabIndex = 7
        Me.seperator2.Text = "Label10"
        Me.seperator2.Visible = False
        '
        'seperator1
        '
        Me.seperator1.BackColor = System.Drawing.Color.White
        Me.seperator1.ForeColor = System.Drawing.Color.White
        Me.seperator1.Location = New System.Drawing.Point(11, 151)
        Me.seperator1.Name = "seperator1"
        Me.seperator1.Size = New System.Drawing.Size(250, 1)
        Me.seperator1.TabIndex = 2
        Me.seperator1.Text = "Label2"
        Me.seperator1.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(77, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 40)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Administrator"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.seperator2)
        Me.pnlMenu.Controls.Add(Me.btnReport)
        Me.pnlMenu.Controls.Add(Me.btnLogout)
        Me.pnlMenu.Controls.Add(Me.btnMenu)
        Me.pnlMenu.Controls.Add(Me.btnAbout)
        Me.pnlMenu.Controls.Add(Me.Label1)
        Me.pnlMenu.Controls.Add(Me.seperator1)
        Me.pnlMenu.Controls.Add(Me.btnUserManagement)
        Me.pnlMenu.Controls.Add(Me.btnHome)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!)
        Me.pnlMenu.ForeColor = System.Drawing.Color.White
        Me.pnlMenu.Location = New System.Drawing.Point(0, 0)
        Me.pnlMenu.MaximumSize = New System.Drawing.Size(270, 860)
        Me.pnlMenu.MinimumSize = New System.Drawing.Size(65, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(65, 860)
        Me.pnlMenu.TabIndex = 1
        '
        'btnReport
        '
        Me.btnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.profit_report
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.Location = New System.Drawing.Point(16, 405)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(238, 45)
        Me.btnReport.TabIndex = 8
        Me.btnReport.Text = "                 Reports"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.ForeColor = System.Drawing.Color.White
        Me.btnLogout.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.logout
        Me.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogout.Location = New System.Drawing.Point(16, 801)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(238, 40)
        Me.btnLogout.TabIndex = 6
        Me.btnLogout.Text = "                 Logout"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.menu1
        Me.btnMenu.Location = New System.Drawing.Point(0, 9)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(66, 42)
        Me.btnMenu.TabIndex = 0
        '
        'btnAbout
        '
        Me.btnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAbout.ForeColor = System.Drawing.Color.White
        Me.btnAbout.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.information_button
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Location = New System.Drawing.Point(16, 492)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(238, 45)
        Me.btnAbout.TabIndex = 5
        Me.btnAbout.Text = "                 About"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnUserManagement
        '
        Me.btnUserManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserManagement.ForeColor = System.Drawing.Color.White
        Me.btnUserManagement.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.user_small_
        Me.btnUserManagement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserManagement.Location = New System.Drawing.Point(16, 322)
        Me.btnUserManagement.Name = "btnUserManagement"
        Me.btnUserManagement.Size = New System.Drawing.Size(238, 45)
        Me.btnUserManagement.TabIndex = 4
        Me.btnUserManagement.Text = "                 User Management"
        Me.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnHome
        '
        Me.btnHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHome.ForeColor = System.Drawing.Color.White
        Me.btnHome.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.home
        Me.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHome.Location = New System.Drawing.Point(16, 242)
        Me.btnHome.MinimumSize = New System.Drawing.Size(65, 0)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(238, 45)
        Me.btnHome.TabIndex = 3
        Me.btnHome.Text = "                 Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TimerPanelIncrease
        '
        Me.TimerPanelIncrease.Interval = 10
        '
        'TimerPanelDecrease
        '
        Me.TimerPanelDecrease.Interval = 10
        '
        'SubPanel
        '
        Me.SubPanel.BackColor = System.Drawing.Color.White
        Me.SubPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SubPanel.Location = New System.Drawing.Point(65, 0)
        Me.SubPanel.Name = "SubPanel"
        Me.SubPanel.Size = New System.Drawing.Size(1218, 861)
        Me.SubPanel.TabIndex = 9
        '
        'AdminForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1284, 861)
        Me.Controls.Add(Me.SubPanel)
        Me.Controls.Add(Me.pnlMenu)
        Me.Name = "AdminForm"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReport As Label
    Friend WithEvents seperator2 As Label
    Friend WithEvents btnLogout As Label
    Friend WithEvents btnAbout As Label
    Friend WithEvents btnUserManagement As Label
    Friend WithEvents btnHome As Label
    Friend WithEvents seperator1 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnMenu As Label
    Friend WithEvents TimerPanelIncrease As Timer
    Friend WithEvents TimerPanelDecrease As Timer
    Friend WithEvents SubPanel As Panel
    Friend WithEvents Timerupdater As Timer
End Class
