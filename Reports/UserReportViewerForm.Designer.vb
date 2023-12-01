<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserReportViewerForm
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
        Me.crpvUserManagement = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.userManagementReport1 = New OOP_Project_Health_Symptom_Analysis.UserManagementReport()
        Me.SuspendLayout()
        '
        'crpvUserManagement
        '
        Me.crpvUserManagement.ActiveViewIndex = -1
        Me.crpvUserManagement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crpvUserManagement.Cursor = System.Windows.Forms.Cursors.Default
        Me.crpvUserManagement.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crpvUserManagement.Location = New System.Drawing.Point(0, 0)
        Me.crpvUserManagement.Name = "crpvUserManagement"
        Me.crpvUserManagement.Size = New System.Drawing.Size(1202, 822)
        Me.crpvUserManagement.TabIndex = 0
        '
        'UserReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 822)
        Me.Controls.Add(Me.crpvUserManagement)
        Me.Font = New System.Drawing.Font("Microsoft YaHei", 11.25!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "UserReportForm"
        Me.Text = "UserReportForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents crpvUserManagement As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents userManagementReport1 As UserManagementReport
End Class
