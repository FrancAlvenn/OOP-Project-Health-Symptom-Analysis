Public Class SymptomCheckerResult
    Dim itemCount As Integer = 0
    Dim clickedLabel As Label

    'clicked label funtion
    Private previousClickedLabel As Label
    Private Sub Label_Click(sender As Object, e As EventArgs)
        ' Cast sender to Label
        clickedLabel = DirectCast(sender, Label)

        ' Reset styles for the previousClickedLabel if it exists
        If previousClickedLabel IsNot Nothing Then
            previousClickedLabel.BackColor = Color.Transparent
            previousClickedLabel.Font = New Font("Microsoft Tai Le", 10, FontStyle.Regular)
        End If


        For Each control As Control In tableDiagnosis.Controls
            If TypeOf control Is Label Then
                control.BackColor = Color.Transparent ' Set the default background color (Transparent)
                control.Font = New Font("Microsoft Tai Le", 10, FontStyle.Regular)
            End If
        Next

        clickedLabel.Font = New Font("Microsoft Tai Le", 10, FontStyle.Bold)
        clickedLabel.BackColor = Color.FromArgb(162, 220, 245)

        ' Update the reference to the previously clicked label
        previousClickedLabel = clickedLabel
    End Sub
    Private Sub SymptomCheckerResult_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 1 To 10
            If itemCount < 10 Then
                Dim newLabel As New Label()

                If BMICalc.IssueName.Count > 0 Then
                    newLabel.Text = BMICalc.IssueName.Dequeue
                    newLabel.AutoSize = True
                    newLabel.Font = New Font("Microsoft Tai Le", 10, FontStyle.Regular)
                    newLabel.Dock = DockStyle.Fill
                    newLabel.TextAlign = ContentAlignment.MiddleLeft

                    AddHandler newLabel.Click, AddressOf Label_Click

                    Dim row As Integer = 0
                    Dim column As Integer = 0

                    tableDiagnosis.Controls.Add(newLabel, column, row)
                    itemCount += 1

                End If




            Else
                MsgBox("Too many symptoms!")
            End If
        Next

    End Sub
End Class