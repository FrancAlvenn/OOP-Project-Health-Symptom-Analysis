﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IssueInformationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IssueInformationForm))
        Me.backButton = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.Label()
        Me.txtMedicalCondition = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPossibleSymtoms = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTreatmentDesc = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.Label()
        Me.txtProfname = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'backButton
        '
        Me.backButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.backButton.Image = CType(resources.GetObject("backButton.Image"), System.Drawing.Image)
        Me.backButton.Location = New System.Drawing.Point(15, 10)
        Me.backButton.Name = "backButton"
        Me.backButton.Size = New System.Drawing.Size(42, 36)
        Me.backButton.TabIndex = 169
        '
        'Label1
        '
        Me.Label1.Image = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.TestResultHeader
        Me.Label1.Location = New System.Drawing.Point(1, -2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1045, 218)
        Me.Label1.TabIndex = 168
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(72, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 26)
        Me.Label3.TabIndex = 170
        Me.Label3.Text = "Name: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(73, 341)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 19)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "Professional Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(72, 425)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 26)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "Description"
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(112, 468)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(851, 227)
        Me.txtDesc.TabIndex = 173
        '
        'txtMedicalCondition
        '
        Me.txtMedicalCondition.Location = New System.Drawing.Point(112, 779)
        Me.txtMedicalCondition.Name = "txtMedicalCondition"
        Me.txtMedicalCondition.Size = New System.Drawing.Size(851, 227)
        Me.txtMedicalCondition.TabIndex = 175
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(72, 736)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 26)
        Me.Label6.TabIndex = 174
        Me.Label6.Text = "Medical Condition"
        '
        'txtPossibleSymtoms
        '
        Me.txtPossibleSymtoms.Location = New System.Drawing.Point(112, 1100)
        Me.txtPossibleSymtoms.Name = "txtPossibleSymtoms"
        Me.txtPossibleSymtoms.Size = New System.Drawing.Size(851, 227)
        Me.txtPossibleSymtoms.TabIndex = 177
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(72, 1057)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(198, 26)
        Me.Label8.TabIndex = 176
        Me.Label8.Text = "Possible Symptoms"
        '
        'txtTreatmentDesc
        '
        Me.txtTreatmentDesc.Location = New System.Drawing.Point(112, 1411)
        Me.txtTreatmentDesc.Name = "txtTreatmentDesc"
        Me.txtTreatmentDesc.Size = New System.Drawing.Size(851, 227)
        Me.txtTreatmentDesc.TabIndex = 179
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(72, 1368)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(228, 26)
        Me.Label10.TabIndex = 178
        Me.Label10.Text = "Treatment Description"
        '
        'txtName
        '
        Me.txtName.AutoSize = True
        Me.txtName.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(175, 282)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(69, 26)
        Me.txtName.TabIndex = 180
        Me.txtName.Text = "Name"
        '
        'txtProfname
        '
        Me.txtProfname.AutoSize = True
        Me.txtProfname.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProfname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.txtProfname.Location = New System.Drawing.Point(251, 334)
        Me.txtProfname.Name = "txtProfname"
        Me.txtProfname.Size = New System.Drawing.Size(51, 26)
        Me.txtProfname.TabIndex = 181
        Me.txtProfname.Text = "N/A"
        '
        'IssueInformationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1074, 719)
        Me.Controls.Add(Me.txtProfname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtTreatmentDesc)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtPossibleSymtoms)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMedicalCondition)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.backButton)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "IssueInformationForm"
        Me.Text = "IssueInformationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents backButton As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDesc As Label
    Friend WithEvents txtMedicalCondition As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPossibleSymtoms As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTreatmentDesc As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtName As Label
    Friend WithEvents txtProfname As Label
End Class