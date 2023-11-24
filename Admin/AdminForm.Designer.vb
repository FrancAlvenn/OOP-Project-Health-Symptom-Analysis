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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SubPanel = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Timerupdater = New System.Windows.Forms.Timer(Me.components)
        Me.pnlMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SubPanel.SuspendLayout()
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(63, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 135)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(125, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(179, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SymptoMedic"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(442, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(319, 135)
        Me.Panel2.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(126, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(179, 29)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "7"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Sans Serif Collection", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(186, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 29)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Number of Users"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(824, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(319, 135)
        Me.Panel3.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!)
        Me.Label13.Location = New System.Drawing.Point(127, 90)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(179, 29)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "7:56:03 pm "
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Sans Serif Collection", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(187, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 29)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Time"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Sans Serif Collection", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(13, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(293, 29)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "11/03/2023  1:41:53 pm"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Sans Serif Collection", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(187, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 29)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Last Login"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SubPanel
        '
        Me.SubPanel.BackColor = System.Drawing.Color.White
        Me.SubPanel.Controls.Add(Me.GroupBox1)
        Me.SubPanel.Controls.Add(Me.lblHome)
        Me.SubPanel.Controls.Add(Me.lblUser)
        Me.SubPanel.Controls.Add(Me.Panel1)
        Me.SubPanel.Controls.Add(Me.lblTime)
        Me.SubPanel.Controls.Add(Me.Panel2)
        Me.SubPanel.Controls.Add(Me.Panel3)
        Me.SubPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SubPanel.Location = New System.Drawing.Point(65, 0)
        Me.SubPanel.Name = "SubPanel"
        Me.SubPanel.Size = New System.Drawing.Size(1218, 861)
        Me.SubPanel.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(63, 291)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1080, 523)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Assessments"
        '
        'lblHome
        '
        Me.lblHome.BackColor = System.Drawing.Color.LimeGreen
        Me.lblHome.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.home_big_
        Me.lblHome.Location = New System.Drawing.Point(85, 53)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(60, 60)
        Me.lblHome.TabIndex = 8
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.Tomato
        Me.lblUser.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.user
        Me.lblUser.Location = New System.Drawing.Point(462, 53)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(60, 60)
        Me.lblUser.TabIndex = 7
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblTime.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.clock
        Me.lblTime.Location = New System.Drawing.Point(847, 53)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(60, 60)
        Me.lblTime.TabIndex = 6
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.SubPanel.ResumeLayout(False)
        Me.SubPanel.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents lblHome As Label
    Friend WithEvents SubPanel As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Timerupdater As Timer
End Class
