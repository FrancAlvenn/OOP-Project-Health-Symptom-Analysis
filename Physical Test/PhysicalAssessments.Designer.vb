<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BMICalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BMICalc))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblInch = New System.Windows.Forms.Label()
        Me.txtInch = New System.Windows.Forms.TextBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBMIResult = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbImperial = New System.Windows.Forms.RadioButton()
        Me.rdbMetric = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel12 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.scrollTimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tableLayoutSymptoms = New System.Windows.Forms.TableLayoutPanel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnSymptomSubmit = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdSearch = New System.Windows.Forms.ComboBox()
        Me.cmb_BodyLocation = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cmb_Symptoms = New System.Windows.Forms.ComboBox()
        Me.cmb_SpecificBodyLocation = New System.Windows.Forms.ComboBox()
        Me.rdb_Female = New System.Windows.Forms.RadioButton()
        Me.rdb_Male = New System.Windows.Forms.RadioButton()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.btnAddSymptom = New System.Windows.Forms.Button()
        Me.pnlHeight = New System.Windows.Forms.Panel()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.btnSymptomChecker = New System.Windows.Forms.Label()
        Me.btnBMICalc = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel12.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.pnlHeight.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox1.Controls.Add(Me.lblInch)
        Me.GroupBox1.Controls.Add(Me.txtInch)
        Me.GroupBox1.Controls.Add(Me.lblWeight)
        Me.GroupBox1.Controls.Add(Me.lblHeight)
        Me.GroupBox1.Controls.Add(Me.txtWeight)
        Me.GroupBox1.Controls.Add(Me.txtHeight)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtBMIResult)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnSubmit)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rdbImperial)
        Me.GroupBox1.Controls.Add(Me.rdbMetric)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(37, 1057)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(456, 774)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Calculate your BMI"
        '
        'lblInch
        '
        Me.lblInch.AutoSize = True
        Me.lblInch.BackColor = System.Drawing.Color.White
        Me.lblInch.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInch.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblInch.Location = New System.Drawing.Point(401, 226)
        Me.lblInch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInch.Name = "lblInch"
        Me.lblInch.Size = New System.Drawing.Size(22, 20)
        Me.lblInch.TabIndex = 16
        Me.lblInch.Text = "in"
        Me.lblInch.Visible = False
        '
        'txtInch
        '
        Me.txtInch.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtInch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInch.Location = New System.Drawing.Point(253, 222)
        Me.txtInch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInch.Name = "txtInch"
        Me.txtInch.Size = New System.Drawing.Size(139, 24)
        Me.txtInch.TabIndex = 17
        Me.txtInch.Visible = False
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.BackColor = System.Drawing.Color.White
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblWeight.Location = New System.Drawing.Point(213, 338)
        Me.lblWeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(27, 20)
        Me.lblWeight.TabIndex = 5
        Me.lblWeight.Text = "kg"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.BackColor = System.Drawing.Color.White
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeight.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblHeight.Location = New System.Drawing.Point(212, 226)
        Me.lblHeight.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(31, 20)
        Me.lblHeight.TabIndex = 5
        Me.lblHeight.Text = "cm"
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.Location = New System.Drawing.Point(64, 334)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(139, 24)
        Me.txtWeight.TabIndex = 6
        '
        'txtHeight
        '
        Me.txtHeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHeight.Location = New System.Drawing.Point(64, 222)
        Me.txtHeight.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(139, 24)
        Me.txtHeight.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(223, 580)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.MaxLength = 190
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 124)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = resources.GetString("TextBox1.Text")
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(200, 540)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 36)
        Me.Label7.TabIndex = 14
        '
        'txtBMIResult
        '
        Me.txtBMIResult.BackColor = System.Drawing.Color.White
        Me.txtBMIResult.Font = New System.Drawing.Font("Sans Serif Collection", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBMIResult.Location = New System.Drawing.Point(36, 604)
        Me.txtBMIResult.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.txtBMIResult.Name = "txtBMIResult"
        Me.txtBMIResult.Size = New System.Drawing.Size(191, 74)
        Me.txtBMIResult.TabIndex = 13
        Me.txtBMIResult.Text = "21.0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 586)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Your BMI is"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(36, 506)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(387, 1)
        Me.Label4.TabIndex = 11
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Location = New System.Drawing.Point(253, 414)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(164, 38)
        Me.btnSubmit.TabIndex = 10
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Location = New System.Drawing.Point(40, 414)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(164, 38)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 286)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Weight"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 182)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Height"
        '
        'rdbImperial
        '
        Me.rdbImperial.AutoSize = True
        Me.rdbImperial.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbImperial.Location = New System.Drawing.Point(52, 113)
        Me.rdbImperial.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbImperial.Name = "rdbImperial"
        Me.rdbImperial.Size = New System.Drawing.Size(98, 27)
        Me.rdbImperial.TabIndex = 1
        Me.rdbImperial.TabStop = True
        Me.rdbImperial.Text = "Imperial"
        Me.rdbImperial.UseVisualStyleBackColor = True
        '
        'rdbMetric
        '
        Me.rdbMetric.AutoSize = True
        Me.rdbMetric.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbMetric.Location = New System.Drawing.Point(52, 63)
        Me.rdbMetric.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbMetric.Name = "rdbMetric"
        Me.rdbMetric.Size = New System.Drawing.Size(84, 27)
        Me.rdbMetric.TabIndex = 0
        Me.rdbMetric.TabStop = True
        Me.rdbMetric.Text = "Metric"
        Me.rdbMetric.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel12)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(543, 1057)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(868, 774)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Health Tips"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(72, 457)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(678, 216)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = resources.GetString("Label18.Text")
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label17.Location = New System.Drawing.Point(49, 395)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(275, 30)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Path to Improved Health"
        '
        'TableLayoutPanel12
        '
        Me.TableLayoutPanel12.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TableLayoutPanel12.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel12.ColumnCount = 2
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel12.Controls.Add(Me.Label14, 1, 1)
        Me.TableLayoutPanel12.Controls.Add(Me.Label12, 0, 4)
        Me.TableLayoutPanel12.Controls.Add(Me.Label11, 0, 4)
        Me.TableLayoutPanel12.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel12.Controls.Add(Me.Label9, 0, 1)
        Me.TableLayoutPanel12.Controls.Add(Me.Label10, 0, 2)
        Me.TableLayoutPanel12.Controls.Add(Me.Label13, 0, 3)
        Me.TableLayoutPanel12.Controls.Add(Me.Label15, 1, 2)
        Me.TableLayoutPanel12.Controls.Add(Me.Label16, 1, 3)
        Me.TableLayoutPanel12.Cursor = System.Windows.Forms.Cursors.SizeAll
        Me.TableLayoutPanel12.Location = New System.Drawing.Point(49, 63)
        Me.TableLayoutPanel12.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel12.Name = "TableLayoutPanel12"
        Me.TableLayoutPanel12.RowCount = 5
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel12.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel12.Size = New System.Drawing.Size(765, 288)
        Me.TableLayoutPanel12.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(387, 58)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(115, 56)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Underweight"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(387, 229)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(115, 58)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "Obese"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(5, 229)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(171, 58)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "30.0 and above"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 48)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, -2)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(328, 48)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "BMI"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(387, 5)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(373, 48)
        Me.Panel2.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, -2)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(325, 48)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Weight Status"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(5, 58)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 56)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Below 18.5"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(5, 115)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 56)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "18.5 - 24.9"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(5, 172)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 56)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "25.0 - 29.9"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(387, 115)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(178, 56)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Normal or Healthy Weight"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(387, 172)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(82, 56)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Overweight"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(345, 447)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(784, 92)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "The BMI calculator offers a quick and reliable way to assess your relative body m" &
    "ass, providing " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "valuable insights into your overall health and fitness level." &
    "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(345, 694)
        Me.Label23.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(808, 69)
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "Our Symptom Checker is a powerful tool designed to help you identify potential he" &
    "alth  concerns " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "based on reported symptoms, offering initial guidance on poss" &
    "ible conditions."
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(0, 0)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(133, 28)
        Me.Label19.TabIndex = 27
        '
        'Label20
        '
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label20.Font = New System.Drawing.Font("Microsoft Tai Le", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(317, 364)
        Me.Label20.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(337, 71)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "BMI Calculator"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label21.Font = New System.Drawing.Font("Microsoft Tai Le", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(317, 608)
        Me.Label21.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(413, 71)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "Symptom Checker"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'scrollTimer
        '
        Me.scrollTimer.Interval = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox3.Controls.Add(Me.tableLayoutSymptoms)
        Me.GroupBox3.Controls.Add(Me.btnClear)
        Me.GroupBox3.Controls.Add(Me.btnRemove)
        Me.GroupBox3.Controls.Add(Me.btnSymptomSubmit)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox3.Location = New System.Drawing.Point(535, 2150)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(883, 774)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Symptoms"
        '
        'tableLayoutSymptoms
        '
        Me.tableLayoutSymptoms.ColumnCount = 1
        Me.tableLayoutSymptoms.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tableLayoutSymptoms.Location = New System.Drawing.Point(59, 84)
        Me.tableLayoutSymptoms.Margin = New System.Windows.Forms.Padding(4)
        Me.tableLayoutSymptoms.Name = "tableLayoutSymptoms"
        Me.tableLayoutSymptoms.RowCount = 15
        Me.tableLayoutSymptoms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.tableLayoutSymptoms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.tableLayoutSymptoms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.tableLayoutSymptoms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.tableLayoutSymptoms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.tableLayoutSymptoms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.tableLayoutSymptoms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.tableLayoutSymptoms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.tableLayoutSymptoms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.tableLayoutSymptoms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.tableLayoutSymptoms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.tableLayoutSymptoms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.tableLayoutSymptoms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.tableLayoutSymptoms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.tableLayoutSymptoms.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667!))
        Me.tableLayoutSymptoms.Size = New System.Drawing.Size(776, 554)
        Me.tableLayoutSymptoms.TabIndex = 27
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(336, 694)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(132, 43)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRemove.FlatAppearance.BorderSize = 0
        Me.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(493, 694)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(132, 43)
        Me.btnRemove.TabIndex = 25
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnSymptomSubmit
        '
        Me.btnSymptomSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnSymptomSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSymptomSubmit.FlatAppearance.BorderSize = 0
        Me.btnSymptomSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnSymptomSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnSymptomSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSymptomSubmit.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSymptomSubmit.Location = New System.Drawing.Point(648, 694)
        Me.btnSymptomSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSymptomSubmit.Name = "btnSymptomSubmit"
        Me.btnSymptomSubmit.Size = New System.Drawing.Size(207, 43)
        Me.btnSymptomSubmit.TabIndex = 24
        Me.btnSymptomSubmit.Text = "Submit"
        Me.btnSymptomSubmit.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox4.Controls.Add(Me.cmdSearch)
        Me.GroupBox4.Controls.Add(Me.cmb_BodyLocation)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.cmb_Symptoms)
        Me.GroupBox4.Controls.Add(Me.cmb_SpecificBodyLocation)
        Me.GroupBox4.Controls.Add(Me.rdb_Female)
        Me.GroupBox4.Controls.Add(Me.rdb_Male)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.btnAddSymptom)
        Me.GroupBox4.Controls.Add(Me.pnlHeight)
        Me.GroupBox4.Controls.Add(Me.Label29)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox4.Location = New System.Drawing.Point(37, 2150)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(456, 774)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Symptom Checker"
        '
        'cmdSearch
        '
        Me.cmdSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmdSearch.FormattingEnabled = True
        Me.cmdSearch.Location = New System.Drawing.Point(45, 208)
        Me.cmdSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(352, 26)
        Me.cmdSearch.TabIndex = 26
        '
        'cmb_BodyLocation
        '
        Me.cmb_BodyLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_BodyLocation.FormattingEnabled = True
        Me.cmb_BodyLocation.Location = New System.Drawing.Point(47, 417)
        Me.cmb_BodyLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_BodyLocation.Name = "cmb_BodyLocation"
        Me.cmb_BodyLocation.Size = New System.Drawing.Size(352, 26)
        Me.cmb_BodyLocation.TabIndex = 25
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(45, 302)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(230, 46)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "Unclear of your symptom? " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Try our body list locator" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(40, 555)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(89, 23)
        Me.Label25.TabIndex = 23
        Me.Label25.Text = "Symptom"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(40, 466)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(158, 23)
        Me.Label26.TabIndex = 22
        Me.Label26.Text = "Specific Body Part"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(40, 378)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(85, 23)
        Me.Label27.TabIndex = 21
        Me.Label27.Text = "Body List"
        '
        'cmb_Symptoms
        '
        Me.cmb_Symptoms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Symptoms.FormattingEnabled = True
        Me.cmb_Symptoms.Location = New System.Drawing.Point(51, 582)
        Me.cmb_Symptoms.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_Symptoms.Name = "cmb_Symptoms"
        Me.cmb_Symptoms.Size = New System.Drawing.Size(352, 26)
        Me.cmb_Symptoms.TabIndex = 20
        '
        'cmb_SpecificBodyLocation
        '
        Me.cmb_SpecificBodyLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SpecificBodyLocation.FormattingEnabled = True
        Me.cmb_SpecificBodyLocation.Location = New System.Drawing.Point(51, 494)
        Me.cmb_SpecificBodyLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_SpecificBodyLocation.Name = "cmb_SpecificBodyLocation"
        Me.cmb_SpecificBodyLocation.Size = New System.Drawing.Size(352, 26)
        Me.cmb_SpecificBodyLocation.TabIndex = 19
        '
        'rdb_Female
        '
        Me.rdb_Female.AutoSize = True
        Me.rdb_Female.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_Female.Location = New System.Drawing.Point(240, 95)
        Me.rdb_Female.Margin = New System.Windows.Forms.Padding(4)
        Me.rdb_Female.Name = "rdb_Female"
        Me.rdb_Female.Size = New System.Drawing.Size(85, 26)
        Me.rdb_Female.TabIndex = 17
        Me.rdb_Female.TabStop = True
        Me.rdb_Female.Text = "Female"
        Me.rdb_Female.UseVisualStyleBackColor = True
        '
        'rdb_Male
        '
        Me.rdb_Male.AutoSize = True
        Me.rdb_Male.Font = New System.Drawing.Font("Microsoft Tai Le", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_Male.Location = New System.Drawing.Point(240, 58)
        Me.rdb_Male.Margin = New System.Windows.Forms.Padding(4)
        Me.rdb_Male.Name = "rdb_Male"
        Me.rdb_Male.Size = New System.Drawing.Size(68, 26)
        Me.rdb_Male.TabIndex = 16
        Me.rdb_Male.TabStop = True
        Me.rdb_Male.Text = "Male"
        Me.rdb_Male.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label28.Location = New System.Drawing.Point(29, 272)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(387, 1)
        Me.Label28.TabIndex = 11
        '
        'btnAddSymptom
        '
        Me.btnAddSymptom.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnAddSymptom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAddSymptom.FlatAppearance.BorderSize = 0
        Me.btnAddSymptom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnAddSymptom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.btnAddSymptom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSymptom.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSymptom.Location = New System.Drawing.Point(45, 673)
        Me.btnAddSymptom.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddSymptom.Name = "btnAddSymptom"
        Me.btnAddSymptom.Size = New System.Drawing.Size(355, 50)
        Me.btnAddSymptom.TabIndex = 10
        Me.btnAddSymptom.Text = "Add Symptom"
        Me.btnAddSymptom.UseVisualStyleBackColor = False
        '
        'pnlHeight
        '
        Me.pnlHeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.pnlHeight.Controls.Add(Me.txtAge)
        Me.pnlHeight.Location = New System.Drawing.Point(51, 84)
        Me.pnlHeight.Margin = New System.Windows.Forms.Padding(4)
        Me.pnlHeight.Name = "pnlHeight"
        Me.pnlHeight.Padding = New System.Windows.Forms.Padding(1)
        Me.pnlHeight.Size = New System.Drawing.Size(113, 33)
        Me.pnlHeight.TabIndex = 7
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.FromArgb(CType(CType(162, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAge.Location = New System.Drawing.Point(5, 7)
        Me.txtAge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(100, 17)
        Me.txtAge.TabIndex = 6
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(40, 156)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(201, 23)
        Me.Label29.TabIndex = 3
        Me.Label29.Text = "What is your symptom?"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(40, 57)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(43, 23)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "Age"
        '
        'Label31
        '
        Me.Label31.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.physicalAssessmentHeader
        Me.Label31.Location = New System.Drawing.Point(-15, -54)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(1447, 379)
        Me.Label31.TabIndex = 28
        '
        'btnSymptomChecker
        '
        Me.btnSymptomChecker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSymptomChecker.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.symptomchecker
        Me.btnSymptomChecker.Location = New System.Drawing.Point(112, 596)
        Me.btnSymptomChecker.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnSymptomChecker.Name = "btnSymptomChecker"
        Me.btnSymptomChecker.Size = New System.Drawing.Size(225, 190)
        Me.btnSymptomChecker.TabIndex = 5
        '
        'btnBMICalc
        '
        Me.btnBMICalc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBMICalc.Image = CType(resources.GetObject("btnBMICalc.Image"), System.Drawing.Image)
        Me.btnBMICalc.Location = New System.Drawing.Point(127, 340)
        Me.btnBMICalc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.btnBMICalc.Name = "btnBMICalc"
        Me.btnBMICalc.Size = New System.Drawing.Size(211, 226)
        Me.btnBMICalc.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(1292, 3013)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(37, 148)
        Me.Panel4.TabIndex = 197
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Black
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(241, 3013)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(933, 1)
        Me.Label6.TabIndex = 196
        Me.Label6.Text = "Label2"
        Me.Label6.Visible = False
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft YaHei", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(144, 3034)
        Me.Label32.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(1147, 34)
        Me.Label32.TabIndex = 195
        Me.Label32.Text = resources.GetString("Label32.Text")
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BMICalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1636, 885)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label32)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.btnSymptomChecker)
        Me.Controls.Add(Me.btnBMICalc)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BMICalc"
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel12.ResumeLayout(False)
        Me.TableLayoutPanel12.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.pnlHeight.ResumeLayout(False)
        Me.pnlHeight.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rdbImperial As RadioButton
    Friend WithEvents rdbMetric As RadioButton
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtBMIResult As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableLayoutPanel12 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblInch As Label
    Friend WithEvents txtInch As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents btnBMICalc As Label
    Friend WithEvents btnSymptomChecker As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents scrollTimer As Timer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents tableLayoutSymptoms As TableLayoutPanel
    Friend WithEvents btnClear As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnSymptomSubmit As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents cmb_Symptoms As ComboBox
    Friend WithEvents cmb_SpecificBodyLocation As ComboBox
    Friend WithEvents rdb_Female As RadioButton
    Friend WithEvents rdb_Male As RadioButton
    Friend WithEvents Label28 As Label
    Friend WithEvents btnAddSymptom As Button
    Friend WithEvents pnlHeight As Panel
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Public WithEvents cmb_BodyLocation As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label32 As Label
    Public WithEvents cmdSearch As ComboBox
End Class
