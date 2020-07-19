Public Class Form1
    Dim price, num, tal, sudti As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        price = TextBox1.Text
        num = TextBox2.Text
        tal = price * num
        TextBox3.Text = tal

        sudti = tal / 50
        TextBox4.Text = sudti
    End Sub
End Class
