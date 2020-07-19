Public Class Form1
    Dim point, Grade As String

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        point = TextBox1.Text
        If point >= 80 Then
            Grade = "A"
        ElseIf point >= 70 Then
            Grade = "B"
        ElseIf point >= 60 Then
            Grade = "C"
        ElseIf point >= 50 Then
            Grade = "D"
        Else
            Grade = "F"
        End If
        TextBox2.Text = Grade
    End Sub
End Class
