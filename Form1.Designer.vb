<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnMenu = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.lblContactUs = New System.Windows.Forms.Label()
        Me.lblMentalAssessment = New System.Windows.Forms.Label()
        Me.lblPhysicalAssessment = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnlUserInfo = New System.Windows.Forms.Panel()
        Me.pnlChangeable = New System.Windows.Forms.Panel()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.TimerPanelIncrease = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPanelDecrease = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(66, 995)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnMenu)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblAbout)
        Me.Panel1.Controls.Add(Me.lblContactUs)
        Me.Panel1.Controls.Add(Me.lblMentalAssessment)
        Me.Panel1.Controls.Add(Me.lblPhysicalAssessment)
        Me.Panel1.Controls.Add(Me.lblHome)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1484, 61)
        Me.Panel1.TabIndex = 1
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.menu1
        Me.btnMenu.Location = New System.Drawing.Point(1414, 10)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(49, 42)
        Me.btnMenu.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(1033, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1, 30)
        Me.Label11.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(891, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1, 30)
        Me.Label9.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(696, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1, 30)
        Me.Label8.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(470, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1, 30)
        Me.Label7.TabIndex = 2
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.ForeColor = System.Drawing.Color.White
        Me.lblAbout.Location = New System.Drawing.Point(1053, 20)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(60, 29)
        Me.lblAbout.TabIndex = 9
        Me.lblAbout.Text = "About"
        Me.lblAbout.UseMnemonic = False
        '
        'lblContactUs
        '
        Me.lblContactUs.AutoSize = True
        Me.lblContactUs.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblContactUs.ForeColor = System.Drawing.Color.White
        Me.lblContactUs.Location = New System.Drawing.Point(913, 20)
        Me.lblContactUs.Name = "lblContactUs"
        Me.lblContactUs.Size = New System.Drawing.Size(100, 29)
        Me.lblContactUs.TabIndex = 8
        Me.lblContactUs.Text = "Contact Us"
        Me.lblContactUs.UseMnemonic = False
        '
        'lblMentalAssessment
        '
        Me.lblMentalAssessment.AutoSize = True
        Me.lblMentalAssessment.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMentalAssessment.ForeColor = System.Drawing.Color.White
        Me.lblMentalAssessment.Location = New System.Drawing.Point(712, 20)
        Me.lblMentalAssessment.Name = "lblMentalAssessment"
        Me.lblMentalAssessment.Size = New System.Drawing.Size(166, 29)
        Me.lblMentalAssessment.TabIndex = 6
        Me.lblMentalAssessment.Text = "Mental Assessment"
        '
        'lblPhysicalAssessment
        '
        Me.lblPhysicalAssessment.AutoSize = True
        Me.lblPhysicalAssessment.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhysicalAssessment.ForeColor = System.Drawing.Color.White
        Me.lblPhysicalAssessment.Location = New System.Drawing.Point(498, 20)
        Me.lblPhysicalAssessment.Name = "lblPhysicalAssessment"
        Me.lblPhysicalAssessment.Size = New System.Drawing.Size(180, 29)
        Me.lblPhysicalAssessment.TabIndex = 5
        Me.lblPhysicalAssessment.Text = "Physical Assessment"
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.ForeColor = System.Drawing.Color.White
        Me.lblHome.Location = New System.Drawing.Point(388, 20)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(60, 29)
        Me.lblHome.TabIndex = 4
        Me.lblHome.Text = "Home"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(34, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(42, 42)
        Me.Panel3.TabIndex = 2
        '
        'pnlUserInfo
        '
        Me.pnlUserInfo.BackColor = System.Drawing.Color.White
        Me.pnlUserInfo.Location = New System.Drawing.Point(34, 100)
        Me.pnlUserInfo.Name = "pnlUserInfo"
        Me.pnlUserInfo.Size = New System.Drawing.Size(271, 729)
        Me.pnlUserInfo.TabIndex = 2
        '
        'pnlChangeable
        '
        Me.pnlChangeable.BackColor = System.Drawing.Color.White
        Me.pnlChangeable.Location = New System.Drawing.Point(342, 100)
        Me.pnlChangeable.Name = "pnlChangeable"
        Me.pnlChangeable.Size = New System.Drawing.Size(1109, 729)
        Me.pnlChangeable.TabIndex = 3
        '
        'pnlMenu
        '
        Me.pnlMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlMenu.Controls.Add(Me.btnClose)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.pnlMenu.Location = New System.Drawing.Point(1484, 0)
        Me.pnlMenu.MaximumSize = New System.Drawing.Size(230, 0)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(0, 861)
        Me.pnlMenu.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.Location = New System.Drawing.Point(3, 9)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(40, 29)
        Me.btnClose.TabIndex = 14
        '
        'TimerPanelIncrease
        '
        Me.TimerPanelIncrease.Interval = 10
        '
        'TimerPanelDecrease
        '
        Me.TimerPanelDecrease.Interval = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1484, 861)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlChangeable)
        Me.Controls.Add(Me.pnlUserInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pnlUserInfo As Panel
    Friend WithEvents pnlChangeable As Panel
    Friend WithEvents lblPhysicalAssessment As Label
    Friend WithEvents lblHome As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAbout As Label
    Friend WithEvents lblContactUs As Label
    Friend WithEvents lblMentalAssessment As Label
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnMenu As Label
    Friend WithEvents btnClose As Label
    Friend WithEvents TimerPanelIncrease As Timer
    Friend WithEvents TimerPanelDecrease As Timer
    Friend WithEvents Panel3 As Panel
End Class
