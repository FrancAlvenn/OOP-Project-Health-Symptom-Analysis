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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.lblRecords = New System.Windows.Forms.Label()
        Me.lblDrugsMedicine = New System.Windows.Forms.Label()
        Me.lblSymptomChecker = New System.Windows.Forms.Label()
        Me.lblBMICalculator = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.pnlUserInfo = New System.Windows.Forms.Panel()
        Me.pnlChangeable = New System.Windows.Forms.Panel()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Label()
        Me.TimerPanelIncrease = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPanelDecrease = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
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
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnMenu)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblAbout)
        Me.Panel1.Controls.Add(Me.lblRecords)
        Me.Panel1.Controls.Add(Me.lblDrugsMedicine)
        Me.Panel1.Controls.Add(Me.lblSymptomChecker)
        Me.Panel1.Controls.Add(Me.lblBMICalculator)
        Me.Panel1.Controls.Add(Me.lblHome)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1484, 61)
        Me.Panel1.TabIndex = 1
        '
        'btnMenu
        '
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.menu
        Me.btnMenu.Location = New System.Drawing.Point(1414, 10)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(49, 42)
        Me.btnMenu.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Location = New System.Drawing.Point(1090, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1, 30)
        Me.Label11.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Black
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Location = New System.Drawing.Point(970, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1, 30)
        Me.Label10.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Black
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Location = New System.Drawing.Point(776, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1, 30)
        Me.Label9.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Location = New System.Drawing.Point(583, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1, 30)
        Me.Label8.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Location = New System.Drawing.Point(409, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1, 30)
        Me.Label7.TabIndex = 2
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.Location = New System.Drawing.Point(1110, 20)
        Me.lblAbout.Name = "lblAbout"
        Me.lblAbout.Size = New System.Drawing.Size(60, 29)
        Me.lblAbout.TabIndex = 9
        Me.lblAbout.Text = "About"
        Me.lblAbout.UseMnemonic = False
        '
        'lblRecords
        '
        Me.lblRecords.AutoSize = True
        Me.lblRecords.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecords.Location = New System.Drawing.Point(989, 20)
        Me.lblRecords.Name = "lblRecords"
        Me.lblRecords.Size = New System.Drawing.Size(80, 29)
        Me.lblRecords.TabIndex = 8
        Me.lblRecords.Text = "Records"
        Me.lblRecords.UseMnemonic = False
        '
        'lblDrugsMedicine
        '
        Me.lblDrugsMedicine.AutoSize = True
        Me.lblDrugsMedicine.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrugsMedicine.Location = New System.Drawing.Point(796, 20)
        Me.lblDrugsMedicine.Name = "lblDrugsMedicine"
        Me.lblDrugsMedicine.Size = New System.Drawing.Size(156, 29)
        Me.lblDrugsMedicine.TabIndex = 7
        Me.lblDrugsMedicine.Text = "Drugs  &  Medicine"
        Me.lblDrugsMedicine.UseMnemonic = False
        '
        'lblSymptomChecker
        '
        Me.lblSymptomChecker.AutoSize = True
        Me.lblSymptomChecker.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSymptomChecker.Location = New System.Drawing.Point(602, 20)
        Me.lblSymptomChecker.Name = "lblSymptomChecker"
        Me.lblSymptomChecker.Size = New System.Drawing.Size(157, 29)
        Me.lblSymptomChecker.TabIndex = 6
        Me.lblSymptomChecker.Text = "Symptom Checker"
        '
        'lblBMICalculator
        '
        Me.lblBMICalculator.AutoSize = True
        Me.lblBMICalculator.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBMICalculator.Location = New System.Drawing.Point(436, 20)
        Me.lblBMICalculator.Name = "lblBMICalculator"
        Me.lblBMICalculator.Size = New System.Drawing.Size(127, 29)
        Me.lblBMICalculator.TabIndex = 5
        Me.lblBMICalculator.Text = "BMI Calculator"
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.Location = New System.Drawing.Point(327, 20)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(60, 29)
        Me.lblHome.TabIndex = 4
        Me.lblHome.Text = "Home"
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
        Me.btnClose.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.close
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
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(34, 10)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(42, 42)
        Me.Panel3.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1484, 861)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlChangeable)
        Me.Controls.Add(Me.pnlUserInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
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
    Friend WithEvents lblBMICalculator As Label
    Friend WithEvents lblHome As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblAbout As Label
    Friend WithEvents lblRecords As Label
    Friend WithEvents lblDrugsMedicine As Label
    Friend WithEvents lblSymptomChecker As Label
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents btnMenu As Label
    Friend WithEvents btnClose As Label
    Friend WithEvents TimerPanelIncrease As Timer
    Friend WithEvents TimerPanelDecrease As Timer
    Friend WithEvents Panel3 As Panel
End Class
