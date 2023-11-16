<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddictionResultForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddictionResultForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.backButton = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.testResult = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button40 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.q5 = New System.Windows.Forms.Label()
        Me.q4 = New System.Windows.Forms.Label()
        Me.q3 = New System.Windows.Forms.Label()
        Me.q2 = New System.Windows.Forms.Label()
        Me.q1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.TestResultHeader
        Me.Label1.Location = New System.Drawing.Point(-2, -3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1045, 218)
        Me.Label1.TabIndex = 2
        '
        'backButton
        '
        Me.backButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backButton.Image = CType(resources.GetObject("backButton.Image"), System.Drawing.Image)
        Me.backButton.Location = New System.Drawing.Point(12, 9)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(42, 36)
        Me.backButton.TabIndex = 155
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Panel1.Controls.Add(Me.testResult)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(117, 254)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(804, 165)
        Me.Panel1.TabIndex = 156
        '
        'testResult
        '
        Me.testResult.AutoSize = True
        Me.testResult.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.testResult.Location = New System.Drawing.Point(48, 74)
        Me.testResult.Name = "testResult"
        Me.testResult.Size = New System.Drawing.Size(72, 36)
        Me.testResult.TabIndex = 158
        Me.testResult.Text = "Null"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 19)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "Your Result -- Addiction Test"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(36, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 25)
        Me.Label4.TabIndex = 157
        Me.Label4.Text = "About your Score"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(645, 57)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "Your score indicates the number of times you answered ""yes."" A score of two or mo" &
    "re indicates a likely " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "drug or alcohol problem."
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(117, 1015)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(804, 625)
        Me.Panel2.TabIndex = 160
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(67, 451)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(665, 95)
        Me.Label9.TabIndex = 162
        Me.Label9.Text = resources.GetString("Label9.Text")
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(167, 388)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(288, 19)
        Me.LinkLabel1.TabIndex = 161
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "https://europepmc.org/article/med/7778330"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(63, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(578, 133)
        Me.Label8.TabIndex = 160
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(27, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 25)
        Me.Label7.TabIndex = 159
        Me.Label7.Text = "Source:"
        '
        'Button40
        '
        Me.Button40.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Button40.FlatAppearance.BorderSize = 0
        Me.Button40.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Button40.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.Button40.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button40.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button40.ForeColor = System.Drawing.Color.Black
        Me.Button40.Location = New System.Drawing.Point(673, 448)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(248, 37)
        Me.Button40.TabIndex = 161
        Me.Button40.Text = "Take another Mental Assessment"
        Me.Button40.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.q5)
        Me.Panel3.Controls.Add(Me.q4)
        Me.Panel3.Controls.Add(Me.q3)
        Me.Panel3.Controls.Add(Me.q2)
        Me.Panel3.Controls.Add(Me.q1)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Location = New System.Drawing.Point(117, 569)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(804, 376)
        Me.Panel3.TabIndex = 163
        '
        'q5
        '
        Me.q5.AutoSize = True
        Me.q5.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q5.Location = New System.Drawing.Point(410, 292)
        Me.q5.Name = "q5"
        Me.q5.Size = New System.Drawing.Size(164, 19)
        Me.q5.TabIndex = 149
        Me.q5.Text = "No substance added"
        '
        'q4
        '
        Me.q4.AutoSize = True
        Me.q4.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q4.Location = New System.Drawing.Point(189, 223)
        Me.q4.Name = "q4"
        Me.q4.Size = New System.Drawing.Size(40, 19)
        Me.q4.TabIndex = 148
        Me.q4.Text = "Null"
        '
        'q3
        '
        Me.q3.AutoSize = True
        Me.q3.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q3.Location = New System.Drawing.Point(469, 134)
        Me.q3.Name = "q3"
        Me.q3.Size = New System.Drawing.Size(40, 19)
        Me.q3.TabIndex = 147
        Me.q3.Text = "Null"
        '
        'q2
        '
        Me.q2.AutoSize = True
        Me.q2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q2.Location = New System.Drawing.Point(484, 77)
        Me.q2.Name = "q2"
        Me.q2.Size = New System.Drawing.Size(40, 19)
        Me.q2.TabIndex = 146
        Me.q2.Text = "Null"
        '
        'q1
        '
        Me.q1.AutoSize = True
        Me.q1.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q1.Location = New System.Drawing.Point(551, 24)
        Me.q1.Name = "q1"
        Me.q1.Size = New System.Drawing.Size(40, 19)
        Me.q1.TabIndex = 145
        Me.q1.Text = "Null"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(40, 292)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(351, 19)
        Me.Label13.TabIndex = 144
        Me.Label13.Text = "What substance or addiction are you concerned about?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(617, 57)
        Me.Label6.TabIndex = 142
        Me.Label6.Text = "Have you ever had a drink or used drugs first thing in the morning to steady your" &
    " nerves or to get " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rid of a hangover?"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 134)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(410, 19)
        Me.Label10.TabIndex = 140
        Me.Label10.Text = "Have you ever felt bad or guilty about your drinking or drug use?"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(40, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(417, 19)
        Me.Label11.TabIndex = 138
        Me.Label11.Text = "Have people annoyed you by criticizing your drinking or drug use?"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(40, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(484, 19)
        Me.Label12.TabIndex = 136
        Me.Label12.Text = "Have you ever felt that you ought to cut down on your drinking or drug use?"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(136, 540)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(133, 41)
        Me.Label14.TabIndex = 164
        Me.Label14.Text = "Your Answers"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(940, 1601)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 121)
        Me.Label15.TabIndex = 165
        '
        'AddictionResultForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1084, 658)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button40)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddictionResultForm"
        Me.Text = "ResultForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents backButton As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents testResult As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button40 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents q5 As Label
    Friend WithEvents q4 As Label
    Friend WithEvents q3 As Label
    Friend WithEvents q2 As Label
    Friend WithEvents q1 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
End Class
