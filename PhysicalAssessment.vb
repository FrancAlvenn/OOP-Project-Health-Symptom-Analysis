Public Class PhysicalAssessment
    Private Sub PhysicalAssessmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PhysicalAssessmentToolStripMenuItem.Click
        'fucntion call to get childform
        Form1.childForm(Me)
    End Sub

    Private Sub BMICalculatorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BMICalculatorToolStripMenuItem.Click
        'fucntion call to get childform
        Form1.childForm(BMICalc)
    End Sub
End Class