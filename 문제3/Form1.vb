Public Class Form1
    Dim point As Point
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        stopButton.Hide()
        point.X = 20
        point.Y = 25
    End Sub

    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click
        stopButton.Show()
        startButton.Hide()
        Timer1.Start()

    End Sub

    Private Sub stopButton_Click(sender As Object, e As EventArgs) Handles stopButton.Click
        startButton.Show()
        stopButton.Hide()
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        point.X += HScrollBar1.Value
        Image.Location = point
        If Image.Location.X >= 800 Then
            Init()
        End If
    End Sub
    Private Sub Init()
        point.X = 0
        point.Y = 25
    End Sub
End Class
