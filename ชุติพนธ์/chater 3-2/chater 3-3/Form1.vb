Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim price, num, tel, Jai, Sudti As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        price = TextBox1.Text
        num = TextBox2.Text
        tel = price * num
        TextBox3.Text = tel

        Jai = TextBox4.Text
        Sudti = Jai - tel
        TextBox5.Text = Sudti






    End Sub
End Class
