Public Class Form1
    Dim FirstNum, Secondnum, Result As Double

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FirstNum = TextBox1.Text
        Secondnum = TextBox2.Text
        If RadioButton1.Checked = True Then
            Result = FirstNum + Secondnum
        ElseIf RadioButton2.Checked = True Then
            Result = FirstNum - Secondnum
        ElseIf RadioButton3.Checked = True Then
            Result = FirstNum * Secondnum
        ElseIf RadioButton4.Checked = True Then
            Result = FirstNum / Secondnum
        ElseIf RadioButton5.Checked = True Then
            Result = (FirstNum ^ Secondnum)
        End If
        TextBox3.Text = Result
    End Sub
End Class
