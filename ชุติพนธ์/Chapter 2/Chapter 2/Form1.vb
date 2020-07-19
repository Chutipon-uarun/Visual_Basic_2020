Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Label1.Text

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Firstname As String
        Firstname = "Chutipon"
        Label1.Text = Firstname
        Firstname = "Nine"
        Label3.Text = Firstname
        Firstname = "Uarun"
        Label2.Text = Firstname
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Prompt, FirstName As String
        Prompt = "กรุณากรอกชื่อจริง"
        FirstName = InputBox(Prompt)
        Label1.Text = FirstName

        Dim Prom, lastname As String
        Prom = "กรุณากรอกนามสกุล"
        lastname = InputBox(Prom)
        Label2.Text = lastname

        Dim Pro, nickname As String
        Pro = "กรุณากรอกชื่อเล่น"
        nickname = InputBox(Pro)
        Label3.Text = nickname
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Prompt, FullName As String
        Prompt = "กรุณาป้อนชื่อและนามสกุล"
        FullName = InputBox(Prompt)
        MsgBox(FullName, , "ชื่อและนามสกุลของคุณ")
    End Sub
End Class

