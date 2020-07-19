Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Username As String
        Dim Password As Integer
        Username = InputBox("กรุณาป้อนชื่อของคุณ")
        Password = InputBox("กรุณาป้อนรหัสผ่าน")
        If Username = "นุ๊กเน็ต" And Password = "123456" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-27\Downloads\Compressed\All_Images\All_Images\photo04.jpg")
        ElseIf Username = "นาย" And Password = "123456" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-27\Pictures\101958642_2846558468786952_6676338496669201874_o.jpg")
        ElseIf Username = "แอม" And Password = "123456" Then
            PictureBox1.Image = System.Drawing.Image.FromFile("C:\Users\Lenovo-27\Downloads\Compressed\All_Images\All_Images\photo07.jpg")
        Else
            MsgBox("ไม่มีชื่อคุณอยู่ในระบบ")
        End If
    End Sub
End Class
