<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        Me.btnGetStarted = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGetStarted
        '
        Me.btnGetStarted.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnGetStarted.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.btnGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGetStarted.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetStarted.ForeColor = System.Drawing.Color.Black
        Me.btnGetStarted.Location = New System.Drawing.Point(743, 366)
        Me.btnGetStarted.Name = "btnGetStarted"
        Me.btnGetStarted.Size = New System.Drawing.Size(262, 43)
        Me.btnGetStarted.TabIndex = 0
        Me.btnGetStarted.Text = "Get Started"
        Me.btnGetStarted.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.OOP_Project_Health_Symptom_Analysis.My.Resources.Resources.Welcome_to_SymptoMedicHeader
        Me.ClientSize = New System.Drawing.Size(1110, 724)
        Me.Controls.Add(Me.btnGetStarted)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGetStarted As Button
End Class
