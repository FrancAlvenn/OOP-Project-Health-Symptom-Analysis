Imports System.Data.SQLite

Public Class AdminHome

    Public userAuthenticationString As String = DatabaseConfiguration.DataSourceUserAuthentication
    Public connection As New SQLiteConnection(userAuthenticationString)
    Private Sub RoundCornerLabel(label As Label)
        label.BorderStyle = FlatStyle.Flat

        Dim rad As New Drawing2D.GraphicsPath
        rad.StartFigure()
        'top left
        rad.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        rad.AddLine(10, 0, label.Width - 20, 0)
        'top right
        rad.AddArc(New Rectangle(label.Width - 20, 0, 20, 20), -90, 90)
        rad.AddLine(label.Width, 20, label.Width, label.Height - 20)
        'bottom right
        'to change the bottom right the x,y,width,height must be same
        rad.AddArc(New Rectangle(label.Width - 25, label.Height - 25, 25, 25), 0, 90)
        rad.AddLine(label.Width - 10, label.Height, 20, label.Height)
        'bottom left
        rad.AddArc(New Rectangle(0, label.Height - 20, 20, 20), 90, 90)
        label.Region = New Region(rad)
    End Sub

    Private Sub userCount()
        If connection.State <> ConnectionState.Open Then
            connection.Open()
        End If

        Using connection As New SQLiteConnection(userAuthenticationString)
            connection.Open()
            Dim query As String = "SELECT COUNT(ID) FROM user_accounts"
            Using command As New SQLiteCommand(query, connection)
                Dim count As Integer = CInt(command.ExecuteScalar())
                lblUserCount.Text = count
                connection.Close()
            End Using
        End Using

    End Sub


    Private Sub AdminHome_Load(sender As Object, e As EventArgs) Handles Me.Load
        RoundCornerLabel(lblHome)
        RoundCornerLabel(lblTime)
        RoundCornerLabel(lblUser)
        connection.Open()
        userCount()
        updateTimer.Enabled = True
        lblCurrentDate.Text = Date.Today
    End Sub

    Dim reset As Integer = 60
    Dim timer As Integer = 0
    Private Sub updateTimer_Tick(sender As Object, e As EventArgs) Handles updateTimer.Tick
        timer += 1
        lblCurrentTime.Text = DateTime.Now.ToString("h:mm:ss tt")
        If timer = reset Then
            userCount()
            timer = 0
        End If
    End Sub

End Class