<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserReportForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserReportForm))
        Me.dgvReports = New System.Windows.Forms.DataGridView()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.iconChangeName = New System.Windows.Forms.Button()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.iconChangeUsername = New System.Windows.Forms.Button()
        Me.iconChangePassword = New System.Windows.Forms.Button()
        Me.btnChangeName = New System.Windows.Forms.Button()
        Me.btnChangeUsername = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.txtConfirmPassword = New System.Windows.Forms.TextBox()
        Me.lblConfirmPassword = New System.Windows.Forms.Label()
        Me.seperator1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbSortBy = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.scrollTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReports
        '
        Me.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReports.Location = New System.Drawing.Point(84, 751)
        Me.dgvReports.Name = "dgvReports"
        Me.dgvReports.Size = New System.Drawing.Size(936, 455)
        Me.dgvReports.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Enabled = False
        Me.txtPassword.Location = New System.Drawing.Point(260, 453)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(269, 20)
        Me.txtPassword.TabIndex = 178
        '
        'txtUsername
        '
        Me.txtUsername.Enabled = False
        Me.txtUsername.Location = New System.Drawing.Point(260, 399)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(269, 20)
        Me.txtUsername.TabIndex = 177
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(260, 343)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(269, 20)
        Me.txtName.TabIndex = 176
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(260, 291)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(269, 20)
        Me.txtID.TabIndex = 175
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 456)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 174
        Me.Label5.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(120, 402)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 19)
        Me.Label4.TabIndex = 173
        Me.Label4.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 346)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 290)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 19)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "ID"
        '
        'iconChangeName
        '
        Me.iconChangeName.BackColor = System.Drawing.Color.White
        Me.iconChangeName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.iconChangeName.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.iconChangeName.FlatAppearance.BorderSize = 0
        Me.iconChangeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconChangeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconChangeName.ForeColor = System.Drawing.Color.White
        Me.iconChangeName.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.exchange
        Me.iconChangeName.Location = New System.Drawing.Point(547, 343)
        Me.iconChangeName.Name = "iconChangeName"
        Me.iconChangeName.Size = New System.Drawing.Size(25, 20)
        Me.iconChangeName.TabIndex = 59
        Me.iconChangeName.UseVisualStyleBackColor = False
        '
        'Label31
        '
        Me.Label31.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.ProfileHeader
        Me.Label31.Location = New System.Drawing.Point(-6, -51)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(1026, 308)
        Me.Label31.TabIndex = 29
        '
        'iconChangeUsername
        '
        Me.iconChangeUsername.BackColor = System.Drawing.Color.White
        Me.iconChangeUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.iconChangeUsername.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.iconChangeUsername.FlatAppearance.BorderSize = 0
        Me.iconChangeUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconChangeUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconChangeUsername.ForeColor = System.Drawing.Color.White
        Me.iconChangeUsername.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.exchange
        Me.iconChangeUsername.Location = New System.Drawing.Point(547, 397)
        Me.iconChangeUsername.Name = "iconChangeUsername"
        Me.iconChangeUsername.Size = New System.Drawing.Size(25, 20)
        Me.iconChangeUsername.TabIndex = 179
        Me.iconChangeUsername.UseVisualStyleBackColor = False
        '
        'iconChangePassword
        '
        Me.iconChangePassword.BackColor = System.Drawing.Color.White
        Me.iconChangePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.iconChangePassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.iconChangePassword.FlatAppearance.BorderSize = 0
        Me.iconChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.iconChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.iconChangePassword.ForeColor = System.Drawing.Color.White
        Me.iconChangePassword.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.exchange
        Me.iconChangePassword.Location = New System.Drawing.Point(547, 451)
        Me.iconChangePassword.Name = "iconChangePassword"
        Me.iconChangePassword.Size = New System.Drawing.Size(25, 20)
        Me.iconChangePassword.TabIndex = 180
        Me.iconChangePassword.UseVisualStyleBackColor = False
        '
        'btnChangeName
        '
        Me.btnChangeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnChangeName.FlatAppearance.BorderSize = 0
        Me.btnChangeName.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnChangeName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnChangeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeName.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeName.ForeColor = System.Drawing.Color.Black
        Me.btnChangeName.Location = New System.Drawing.Point(591, 341)
        Me.btnChangeName.Name = "btnChangeName"
        Me.btnChangeName.Size = New System.Drawing.Size(82, 22)
        Me.btnChangeName.TabIndex = 181
        Me.btnChangeName.Text = "Confirm"
        Me.btnChangeName.UseVisualStyleBackColor = False
        Me.btnChangeName.Visible = False
        '
        'btnChangeUsername
        '
        Me.btnChangeUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnChangeUsername.FlatAppearance.BorderSize = 0
        Me.btnChangeUsername.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnChangeUsername.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnChangeUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangeUsername.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangeUsername.ForeColor = System.Drawing.Color.Black
        Me.btnChangeUsername.Location = New System.Drawing.Point(591, 395)
        Me.btnChangeUsername.Name = "btnChangeUsername"
        Me.btnChangeUsername.Size = New System.Drawing.Size(82, 22)
        Me.btnChangeUsername.TabIndex = 182
        Me.btnChangeUsername.Text = "Confirm"
        Me.btnChangeUsername.UseVisualStyleBackColor = False
        Me.btnChangeUsername.Visible = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnChangePassword.FlatAppearance.BorderSize = 0
        Me.btnChangePassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnChangePassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangePassword.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangePassword.ForeColor = System.Drawing.Color.Black
        Me.btnChangePassword.Location = New System.Drawing.Point(591, 453)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(82, 22)
        Me.btnChangePassword.TabIndex = 183
        Me.btnChangePassword.Text = "Confirm"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        Me.btnChangePassword.Visible = False
        '
        'txtConfirmPassword
        '
        Me.txtConfirmPassword.Enabled = False
        Me.txtConfirmPassword.Location = New System.Drawing.Point(260, 507)
        Me.txtConfirmPassword.Name = "txtConfirmPassword"
        Me.txtConfirmPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConfirmPassword.Size = New System.Drawing.Size(269, 20)
        Me.txtConfirmPassword.TabIndex = 185
        Me.txtConfirmPassword.Visible = False
        '
        'lblConfirmPassword
        '
        Me.lblConfirmPassword.AutoSize = True
        Me.lblConfirmPassword.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmPassword.Location = New System.Drawing.Point(120, 507)
        Me.lblConfirmPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfirmPassword.Name = "lblConfirmPassword"
        Me.lblConfirmPassword.Size = New System.Drawing.Size(121, 19)
        Me.lblConfirmPassword.TabIndex = 184
        Me.lblConfirmPassword.Text = "Confirm Password"
        Me.lblConfirmPassword.Visible = False
        '
        'seperator1
        '
        Me.seperator1.BackColor = System.Drawing.Color.Black
        Me.seperator1.ForeColor = System.Drawing.Color.White
        Me.seperator1.Location = New System.Drawing.Point(81, 579)
        Me.seperator1.Name = "seperator1"
        Me.seperator1.Size = New System.Drawing.Size(700, 1)
        Me.seperator1.TabIndex = 186
        Me.seperator1.Text = "Label2"
        Me.seperator1.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(78, 623)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 36)
        Me.Label6.TabIndex = 187
        Me.Label6.Text = "Reports"
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(954, 1441)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(66, 42)
        Me.Panel1.TabIndex = 188
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 0
        Me.btnPrint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.Location = New System.Drawing.Point(796, 1253)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(224, 37)
        Me.btnPrint.TabIndex = 189
        Me.btnPrint.Text = "Print Selection"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 1398)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(919, 26)
        Me.Label3.TabIndex = 190
        Me.Label3.Text = resources.GetString("Label3.Text")
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(201, 1378)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(700, 1)
        Me.Label7.TabIndex = 191
        Me.Label7.Text = "Label2"
        Me.Label7.Visible = False
        '
        'cmbSortBy
        '
        Me.cmbSortBy.FormattingEnabled = True
        Me.cmbSortBy.Items.AddRange(New Object() {"SymptomChecker", "AddictionTest", "ADHDTest", "AnxietyTest", "DepressionTest", "PTSDTest"})
        Me.cmbSortBy.Location = New System.Drawing.Point(757, 696)
        Me.cmbSortBy.Name = "cmbSortBy"
        Me.cmbSortBy.Size = New System.Drawing.Size(263, 21)
        Me.cmbSortBy.TabIndex = 192
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(621, 698)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 19)
        Me.Label8.TabIndex = 193
        Me.Label8.Text = "Sort by Category:"
        '
        'scrollTimer
        '
        Me.scrollTimer.Interval = 10
        '
        'UserReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1149, 719)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbSortBy)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.seperator1)
        Me.Controls.Add(Me.txtConfirmPassword)
        Me.Controls.Add(Me.lblConfirmPassword)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.btnChangeUsername)
        Me.Controls.Add(Me.btnChangeName)
        Me.Controls.Add(Me.iconChangePassword)
        Me.Controls.Add(Me.iconChangeUsername)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.iconChangeName)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.dgvReports)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "UserReportForm"
        Me.Text = "  "
        CType(Me.dgvReports, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvReports As DataGridView
    Friend WithEvents Label31 As Label
    Friend WithEvents iconChangeName As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents iconChangeUsername As Button
    Friend WithEvents iconChangePassword As Button
    Friend WithEvents btnChangeName As Button
    Friend WithEvents btnChangeUsername As Button
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents lblConfirmPassword As Label
    Friend WithEvents seperator1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPrint As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbSortBy As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents scrollTimer As Timer
End Class
