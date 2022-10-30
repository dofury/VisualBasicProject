

Imports System.Configuration
Imports System.Threading

Public Class Form1
    Dim clickButton As New Button
    Dim score As Integer
    Dim second As Integer
    Private thread As Thread
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Visible = False
        Label3.Show()
        Label5.Show()
        Label1.Show()
        Label2.Show()
        Dim point As Point
        Dim rd As New Random
        point.X = rd.Next(0, 550) '폼 크기 - 50' 
        point.Y = rd.Next(0, 450) '버튼이 보이지 않게 나타나는 것을 방지하기 위함'
        clickButton.Location = point
        Me.Controls.Add(clickButton)
        Timer1.Start()
        thread = New Thread(AddressOf threadOn)
        thread.IsBackground = True
        thread.Start()
        Timer3.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.Controls.Remove(clickButton)
        Dim point As Point
        Dim rd As New Random
        point.X = rd.Next(0, 550) '폼 크기 - 50' 
        point.Y = rd.Next(0, 450) '버튼이 보이지 않게 나타나는 것을 방지하기 위함'
        clickButton.Location = point
        Me.Controls.Add(clickButton)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim size As Size
        size.Width = 100
        size.Height = 50
        clickButton.Text = "Click Me"
        clickButton.Size = size
        AddHandler Me.clickButton.Click, AddressOf clickButton_Click
        CheckForIllegalCrossThreadCalls = False '디버그시 크로스 쓰레드 오류 임시방편 조치'
        Init()
        Timer3.Start()
    End Sub
    Private Sub Init()
        score = 0
        second = 10
        Label3.Hide()
        Label5.Hide()
        Label1.Hide()
        Label2.Hide()
    End Sub

    Private Sub clickButton_Click()
        score += 1
    End Sub
    Private Sub threadOn()
        Do
            Label5.Text = score.ToString
            Label3.Text = second.ToString + "초"
            If second = 0 Then
                Exit Do
            End If
        Loop
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        second -= 1
        If second = -1 Then
            Button1.Visible = True
            Init()
            Timer1.Stop()
            Me.Controls.Remove(clickButton)
            Timer3.Stop()
        End If
    End Sub
End Class
