<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblAbout = New System.Windows.Forms.Label()
        Me.lblContactUs = New System.Windows.Forms.Label()
        Me.lblMentalAssessment = New System.Windows.Forms.Label()
        Me.lblPhysicalAssessment = New System.Windows.Forms.Label()
        Me.lblHome = New System.Windows.Forms.Label()
        Me.pnlChangeable = New System.Windows.Forms.Panel()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerPanelIncrease = New System.Windows.Forms.Timer(Me.components)
        Me.TimerPanelDecrease = New System.Windows.Forms.Timer(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnMenu = New System.Windows.Forms.Label()
        Me.CircularPictureBox3 = New OOP_Project_Health_Symptom_Analysis.CircularPictureBox()
        Me.CircularPictureBox2 = New OOP_Project_Health_Symptom_Analysis.CircularPictureBox()
        Me.Panel1.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        CType(Me.CircularPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CircularPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.Controls.Add(Me.CircularPictureBox2)
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
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1290, 61)
        Me.Panel1.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(929, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1, 30)
        Me.Label11.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(787, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1, 30)
        Me.Label9.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(592, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1, 30)
        Me.Label8.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(366, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(1, 30)
        Me.Label7.TabIndex = 2
        '
        'lblAbout
        '
        Me.lblAbout.AutoSize = True
        Me.lblAbout.Font = New System.Drawing.Font("Sans Serif Collection", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAbout.ForeColor = System.Drawing.Color.White
        Me.lblAbout.Location = New System.Drawing.Point(949, 21)
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
        Me.lblContactUs.Location = New System.Drawing.Point(809, 21)
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
        Me.lblMentalAssessment.Location = New System.Drawing.Point(608, 21)
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
        Me.lblPhysicalAssessment.Location = New System.Drawing.Point(394, 21)
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
        Me.lblHome.Location = New System.Drawing.Point(284, 21)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(60, 29)
        Me.lblHome.TabIndex = 4
        Me.lblHome.Text = "Home"
        '
        'pnlChangeable
        '
        Me.pnlChangeable.BackColor = System.Drawing.Color.White
        Me.pnlChangeable.Location = New System.Drawing.Point(87, 99)
        Me.pnlChangeable.Name = "pnlChangeable"
        Me.pnlChangeable.Size = New System.Drawing.Size(1109, 729)
        Me.pnlChangeable.TabIndex = 3
        '
        'pnlMenu
        '
        Me.pnlMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.Label12)
        Me.pnlMenu.Controls.Add(Me.Label10)
        Me.pnlMenu.Controls.Add(Me.Label6)
        Me.pnlMenu.Controls.Add(Me.Label5)
        Me.pnlMenu.Controls.Add(Me.Label4)
        Me.pnlMenu.Controls.Add(Me.Label3)
        Me.pnlMenu.Controls.Add(Me.Label2)
        Me.pnlMenu.Controls.Add(Me.Label1)
        Me.pnlMenu.Controls.Add(Me.CircularPictureBox3)
        Me.pnlMenu.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlMenu.Location = New System.Drawing.Point(985, 60)
        Me.pnlMenu.MaximumSize = New System.Drawing.Size(300, 450)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(300, 0)
        Me.pnlMenu.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(29, 377)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(250, 1)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Label10"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(29, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(250, 1)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Sans Serif Collection", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(66, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Franc Alvenn Dela Cruz"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TimerPanelIncrease
        '
        Me.TimerPanelIncrease.Interval = 10
        '
        'TimerPanelDecrease
        '
        Me.TimerPanelDecrease.Interval = 10
        '
        'Label12
        '
        Me.Label12.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.profit_report
        Me.Label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Location = New System.Drawing.Point(31, 224)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(238, 45)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "            Reports"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.logout
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(31, 400)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(238, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "            Home"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.information_button
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(29, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(238, 45)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "            About"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.feedback
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(29, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(238, 45)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "            Feedback"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.home
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(29, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(238, 45)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "            Home"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.menu1
        Me.btnMenu.Location = New System.Drawing.Point(1223, 10)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(49, 42)
        Me.btnMenu.TabIndex = 0
        '
        'CircularPictureBox3
        '
        Me.CircularPictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CircularPictureBox3.Location = New System.Drawing.Point(16, 22)
        Me.CircularPictureBox3.Name = "CircularPictureBox3"
        Me.CircularPictureBox3.Size = New System.Drawing.Size(35, 35)
        Me.CircularPictureBox3.TabIndex = 0
        Me.CircularPictureBox3.TabStop = False
        '
        'CircularPictureBox2
        '
        Me.CircularPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CircularPictureBox2.Location = New System.Drawing.Point(22, 10)
        Me.CircularPictureBox2.Name = "CircularPictureBox2"
        Me.CircularPictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.CircularPictureBox2.TabIndex = 14
        Me.CircularPictureBox2.TabStop = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1284, 861)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlChangeable)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        CType(Me.CircularPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CircularPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
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
    Friend WithEvents TimerPanelIncrease As Timer
    Friend WithEvents TimerPanelDecrease As Timer
    Friend WithEvents CircularPictureBox2 As CircularPictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CircularPictureBox3 As CircularPictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
End Class
