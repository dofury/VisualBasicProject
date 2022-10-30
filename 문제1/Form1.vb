Public Class Form1
    Structure UserStr
        Dim name As String
        Dim age As Integer
        Dim gender As String
        Dim color As String
    End Structure
    Dim userList As New ArrayList()
    Dim textsCheck As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Init() '초기값 설정'
    End Sub

    Private Sub Init()
        RadioButton1.Checked = True
        ComboBox1.SelectedItem() = "남"
        textsCheck = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextCheck() '텍스트 길이 체크'
        If textsCheck = True And (TextBox1.Text <> "" And TextBox2.Text <> "") Then
            Dim user As New UserStr()
            user.name = TextBox1.Text
            user.age = TextBox2.Text
            user.gender = ComboBox1.SelectedItem.ToString
            If (RadioButton1.Checked) Then
                user.color = RadioButton1.Text
            ElseIf RadioButton2.Checked Then
                user.color = RadioButton2.Text
            ElseIf RadioButton3.Checked Then
                user.color = RadioButton3.Text
            End If
            userList.Add(user)
            ListBox1.Items.Add(user.name)
            Timer1.Start()
            TextBox3.Text = user.name + "님이 등록되었습니다" + vbCrLf + "성별: " + user.gender + vbCrLf + "가장 좋아하는 색: " + user.color

        End If

    End Sub
    Private Sub TextCheck()
        If TextBox1.TextLength <> 3 Then
            MessageBox.Show("이름을 잘못 입력하였습니다.", "경고")
            textsCheck = False
            Exit Sub
        End If
        If TextBox2.TextLength < 1 Or TextBox2.TextLength > 2 Or Not IsNumeric(TextBox2.Text) Then
            MessageBox.Show("나이를 잘못 입력하였습니다.", "경고")
            textsCheck = False
            Exit Sub
        End If
        textsCheck = True '조건 충족'
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox3.Text = ""
        Timer1.Stop()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim user As New UserStr()
        user = userList.Item(ListBox1.SelectedIndex)
        Label8.Text = user.name
        Label9.Text = user.age
        Label10.Text = user.gender
        Label11.Text = user.color


    End Sub
End Class
