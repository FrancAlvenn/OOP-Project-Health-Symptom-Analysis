<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MentalAssessment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MentalAssessment))
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDepressionTest = New System.Windows.Forms.Label()
        Me.btnADHDTest = New System.Windows.Forms.Label()
        Me.btnAnxietyTest = New System.Windows.Forms.Label()
        Me.btnPTSDTest = New System.Windows.Forms.Label()
        Me.btnEatingDisorderTest = New System.Windows.Forms.Label()
        Me.btnAddictionTest = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.tabControl = New System.Windows.Forms.TabControl()
        Me.ADHDTestPanel = New System.Windows.Forms.TabPage()
        Me.AnxietyTestPanel = New System.Windows.Forms.TabPage()
        Me.PTSDTestPanel = New System.Windows.Forms.TabPage()
        Me.EatingDisorderTestPanel = New System.Windows.Forms.TabPage()
        Me.AddictionTestPanel = New System.Windows.Forms.TabPage()
        Me.LandingPanel = New System.Windows.Forms.TabPage()
        Me.DepressionTestPanel = New System.Windows.Forms.TabPage()
        Me.pnlHeader.SuspendLayout()
        Me.tabControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlHeader.Controls.Add(Me.Label3)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Location = New System.Drawing.Point(46, 22)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1011, 147)
        Me.pnlHeader.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(69, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(729, 42)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Conditions like depression or anxiety are not only real and widespread, but they'" &
    "re also highly treatable. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The good news? Recovery is absolutely within reach!"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(28, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(692, 56)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Take a Mental Health Test"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDepressionTest
        '
        Me.btnDepressionTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnDepressionTest.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepressionTest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnDepressionTest.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.plus3
        Me.btnDepressionTest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDepressionTest.Location = New System.Drawing.Point(59, 200)
        Me.btnDepressionTest.Name = "btnDepressionTest"
        Me.btnDepressionTest.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnDepressionTest.Size = New System.Drawing.Size(220, 43)
        Me.btnDepressionTest.TabIndex = 4
        Me.btnDepressionTest.Text = "    DEPRESSION TEST"
        Me.btnDepressionTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnADHDTest
        '
        Me.btnADHDTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnADHDTest.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnADHDTest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnADHDTest.Image = CType(resources.GetObject("btnADHDTest.Image"), System.Drawing.Image)
        Me.btnADHDTest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnADHDTest.Location = New System.Drawing.Point(59, 280)
        Me.btnADHDTest.Name = "btnADHDTest"
        Me.btnADHDTest.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnADHDTest.Size = New System.Drawing.Size(220, 43)
        Me.btnADHDTest.TabIndex = 5
        Me.btnADHDTest.Text = "    ADHD TEST"
        Me.btnADHDTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAnxietyTest
        '
        Me.btnAnxietyTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnAnxietyTest.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnxietyTest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnAnxietyTest.Image = CType(resources.GetObject("btnAnxietyTest.Image"), System.Drawing.Image)
        Me.btnAnxietyTest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAnxietyTest.Location = New System.Drawing.Point(59, 359)
        Me.btnAnxietyTest.Name = "btnAnxietyTest"
        Me.btnAnxietyTest.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnAnxietyTest.Size = New System.Drawing.Size(220, 43)
        Me.btnAnxietyTest.TabIndex = 6
        Me.btnAnxietyTest.Text = "    ANXIETY TEST"
        Me.btnAnxietyTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPTSDTest
        '
        Me.btnPTSDTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnPTSDTest.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPTSDTest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnPTSDTest.Image = CType(resources.GetObject("btnPTSDTest.Image"), System.Drawing.Image)
        Me.btnPTSDTest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPTSDTest.Location = New System.Drawing.Point(59, 436)
        Me.btnPTSDTest.Name = "btnPTSDTest"
        Me.btnPTSDTest.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnPTSDTest.Size = New System.Drawing.Size(220, 43)
        Me.btnPTSDTest.TabIndex = 7
        Me.btnPTSDTest.Text = "    PTSD TEST"
        Me.btnPTSDTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnEatingDisorderTest
        '
        Me.btnEatingDisorderTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnEatingDisorderTest.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEatingDisorderTest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnEatingDisorderTest.Image = CType(resources.GetObject("btnEatingDisorderTest.Image"), System.Drawing.Image)
        Me.btnEatingDisorderTest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnEatingDisorderTest.Location = New System.Drawing.Point(59, 512)
        Me.btnEatingDisorderTest.Name = "btnEatingDisorderTest"
        Me.btnEatingDisorderTest.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnEatingDisorderTest.Size = New System.Drawing.Size(220, 43)
        Me.btnEatingDisorderTest.TabIndex = 9
        Me.btnEatingDisorderTest.Text = "    EATING DISORDER TEST"
        Me.btnEatingDisorderTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddictionTest
        '
        Me.btnAddictionTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnAddictionTest.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddictionTest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnAddictionTest.Image = CType(resources.GetObject("btnAddictionTest.Image"), System.Drawing.Image)
        Me.btnAddictionTest.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddictionTest.Location = New System.Drawing.Point(59, 586)
        Me.btnAddictionTest.Name = "btnAddictionTest"
        Me.btnAddictionTest.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.btnAddictionTest.Size = New System.Drawing.Size(220, 43)
        Me.btnAddictionTest.TabIndex = 8
        Me.btnAddictionTest.Text = "    ADDICTION TEST"
        Me.btnAddictionTest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(890, 650)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(155, 35)
        Me.btnSubmit.TabIndex = 25
        Me.btnSubmit.Text = "Take the Test"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'tabControl
        '
        Me.tabControl.Controls.Add(Me.LandingPanel)
        Me.tabControl.Controls.Add(Me.DepressionTestPanel)
        Me.tabControl.Controls.Add(Me.ADHDTestPanel)
        Me.tabControl.Controls.Add(Me.AnxietyTestPanel)
        Me.tabControl.Controls.Add(Me.PTSDTestPanel)
        Me.tabControl.Controls.Add(Me.EatingDisorderTestPanel)
        Me.tabControl.Controls.Add(Me.AddictionTestPanel)
        Me.tabControl.HotTrack = True
        Me.tabControl.ItemSize = New System.Drawing.Size(1, 20)
        Me.tabControl.Location = New System.Drawing.Point(311, 196)
        Me.tabControl.Multiline = True
        Me.tabControl.Name = "tabControl"
        Me.tabControl.SelectedIndex = 0
        Me.tabControl.ShowToolTips = True
        Me.tabControl.Size = New System.Drawing.Size(734, 437)
        Me.tabControl.TabIndex = 26
        '
        'ADHDTestPanel
        '
        Me.ADHDTestPanel.Location = New System.Drawing.Point(4, 24)
        Me.ADHDTestPanel.Name = "ADHDTestPanel"
        Me.ADHDTestPanel.Padding = New System.Windows.Forms.Padding(3)
        Me.ADHDTestPanel.Size = New System.Drawing.Size(726, 409)
        Me.ADHDTestPanel.TabIndex = 1
        Me.ADHDTestPanel.Text = "ADHD Test"
        Me.ADHDTestPanel.UseVisualStyleBackColor = True
        '
        'AnxietyTestPanel
        '
        Me.AnxietyTestPanel.Location = New System.Drawing.Point(4, 24)
        Me.AnxietyTestPanel.Name = "AnxietyTestPanel"
        Me.AnxietyTestPanel.Size = New System.Drawing.Size(726, 409)
        Me.AnxietyTestPanel.TabIndex = 2
        Me.AnxietyTestPanel.Text = "AnxietyTest"
        Me.AnxietyTestPanel.UseVisualStyleBackColor = True
        '
        'PTSDTestPanel
        '
        Me.PTSDTestPanel.Location = New System.Drawing.Point(4, 24)
        Me.PTSDTestPanel.Name = "PTSDTestPanel"
        Me.PTSDTestPanel.Size = New System.Drawing.Size(726, 409)
        Me.PTSDTestPanel.TabIndex = 3
        Me.PTSDTestPanel.Text = "PTSD Test"
        Me.PTSDTestPanel.UseVisualStyleBackColor = True
        '
        'EatingDisorderTestPanel
        '
        Me.EatingDisorderTestPanel.Location = New System.Drawing.Point(4, 24)
        Me.EatingDisorderTestPanel.Name = "EatingDisorderTestPanel"
        Me.EatingDisorderTestPanel.Size = New System.Drawing.Size(726, 409)
        Me.EatingDisorderTestPanel.TabIndex = 4
        Me.EatingDisorderTestPanel.Text = "EatingDisorder Test"
        Me.EatingDisorderTestPanel.UseVisualStyleBackColor = True
        '
        'AddictionTestPanel
        '
        Me.AddictionTestPanel.Location = New System.Drawing.Point(4, 24)
        Me.AddictionTestPanel.Name = "AddictionTestPanel"
        Me.AddictionTestPanel.Size = New System.Drawing.Size(726, 409)
        Me.AddictionTestPanel.TabIndex = 5
        Me.AddictionTestPanel.Text = "Addiction Test"
        Me.AddictionTestPanel.UseVisualStyleBackColor = True
        '
        'LandingPanel
        '
        Me.LandingPanel.Location = New System.Drawing.Point(4, 24)
        Me.LandingPanel.Name = "LandingPanel"
        Me.LandingPanel.Size = New System.Drawing.Size(726, 409)
        Me.LandingPanel.TabIndex = 6
        Me.LandingPanel.Text = "Landing Page"
        Me.LandingPanel.UseVisualStyleBackColor = True
        '
        'DepressionTestPanel
        '
        Me.DepressionTestPanel.AutoScroll = True
        Me.DepressionTestPanel.BackColor = System.Drawing.Color.White
        Me.DepressionTestPanel.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepressionTestPanel.ForeColor = System.Drawing.Color.Black
        Me.DepressionTestPanel.Location = New System.Drawing.Point(4, 24)
        Me.DepressionTestPanel.Name = "DepressionTestPanel"
        Me.DepressionTestPanel.Padding = New System.Windows.Forms.Padding(3)
        Me.DepressionTestPanel.Size = New System.Drawing.Size(726, 409)
        Me.DepressionTestPanel.TabIndex = 0
        Me.DepressionTestPanel.Text = "Depression Test"
        '
        'MentalAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1093, 719)
        Me.Controls.Add(Me.btnAddictionTest)
        Me.Controls.Add(Me.btnEatingDisorderTest)
        Me.Controls.Add(Me.btnPTSDTest)
        Me.Controls.Add(Me.btnAnxietyTest)
        Me.Controls.Add(Me.btnADHDTest)
        Me.Controls.Add(Me.btnDepressionTest)
        Me.Controls.Add(Me.tabControl)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "MentalAssessment"
        Me.Text = " "
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.tabControl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDepressionTest As Label
    Friend WithEvents btnADHDTest As Label
    Friend WithEvents btnAnxietyTest As Label
    Friend WithEvents btnEatingDisorderTest As Label
    Friend WithEvents btnAddictionTest As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents tabControl As TabControl
    Friend WithEvents ADHDTestPanel As TabPage
    Friend WithEvents AnxietyTestPanel As TabPage
    Friend WithEvents PTSDTestPanel As TabPage
    Friend WithEvents EatingDisorderTestPanel As TabPage
    Friend WithEvents AddictionTestPanel As TabPage
    Friend WithEvents LandingPanel As TabPage
    Friend WithEvents btnPTSDTest As Label
    Friend WithEvents DepressionTestPanel As TabPage
End Class
