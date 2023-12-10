<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminHome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblUserCount = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblCurrentTime = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.updateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(72, 574)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 166)
        Me.Panel1.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(167, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 36)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SymptoMedic"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblUserCount)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Location = New System.Drawing.Point(577, 574)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(425, 166)
        Me.Panel2.TabIndex = 11
        '
        'lblUserCount
        '
        Me.lblUserCount.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!)
        Me.lblUserCount.Location = New System.Drawing.Point(168, 75)
        Me.lblUserCount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUserCount.Name = "lblUserCount"
        Me.lblUserCount.Size = New System.Drawing.Size(239, 36)
        Me.lblUserCount.TabIndex = 1
        Me.lblUserCount.Text = "7"
        Me.lblUserCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Sans Serif Collection", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(248, 39)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 36)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Number of Users"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblCurrentTime)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.lblCurrentDate)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Location = New System.Drawing.Point(1086, 574)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(425, 166)
        Me.Panel3.TabIndex = 12
        '
        'lblCurrentTime
        '
        Me.lblCurrentTime.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!)
        Me.lblCurrentTime.Location = New System.Drawing.Point(169, 111)
        Me.lblCurrentTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentTime.Name = "lblCurrentTime"
        Me.lblCurrentTime.Size = New System.Drawing.Size(239, 36)
        Me.lblCurrentTime.TabIndex = 2
        Me.lblCurrentTime.Text = "00:00:00 pm "
        Me.lblCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Sans Serif Collection", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DimGray
        Me.Label11.Location = New System.Drawing.Point(249, 75)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(159, 36)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Time"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.Font = New System.Drawing.Font("Sans Serif Collection", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrentDate.ForeColor = System.Drawing.Color.DimGray
        Me.lblCurrentDate.Location = New System.Drawing.Point(17, 39)
        Me.lblCurrentDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(391, 36)
        Me.lblCurrentDate.TabIndex = 2
        Me.lblCurrentDate.Text = "00/00/0000"
        Me.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Sans Serif Collection", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(249, 14)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(159, 36)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'updateTimer
        '
        Me.updateTimer.Interval = 1000
        '
        'Label1
        '
        Me.Label1.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.AdministratorHeader
        Me.Label1.Location = New System.Drawing.Point(69, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1442, 210)
        Me.Label1.TabIndex = 16
        '
        'lblHome
        '
        Me.lblHome.BackColor = System.Drawing.Color.LimeGreen
        Me.lblHome.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.home_big_
        Me.lblHome.Location = New System.Drawing.Point(101, 540)
        Me.lblHome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(80, 74)
        Me.lblHome.TabIndex = 15
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.Color.Tomato
        Me.lblUser.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.user
        Me.lblUser.Location = New System.Drawing.Point(604, 540)
        Me.lblUser.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(80, 74)
        Me.lblUser.TabIndex = 14
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblTime.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.clock
        Me.lblTime.Location = New System.Drawing.Point(1117, 540)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(80, 74)
        Me.lblTime.TabIndex = 13
        '
        'AdminHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1603, 1012)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblHome)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "AdminHome"
        Me.Text = "AdminHome"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblHome As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblUserCount As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblCurrentTime As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents updateTimer As Timer
    Friend WithEvents Label1 As Label
End Class
