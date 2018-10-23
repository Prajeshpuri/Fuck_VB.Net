Public Class ArrayMethods
    Dim arr(9) As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, i As Integer
        a = CInt(TextBox1.Text)
        arr(i) = a
        TextBox1.Clear()
        ListBox1.Items.Add(a)
        i = i + 1
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim sum, i As Integer
        Dim res As Double
        For i = 0 To 9
            sum = sum + arr(i)
        Next
        res = sum / 10
        MessageBox.Show("Average : " & res)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim arrs(9) As String
        Dim i As Integer
        For i = 0 To 9
            ' a = CInt(TextBox1.Text)
            arrs(i) = TextBox1.Text
            TextBox1.Clear()
            ListBox1.Items.Add(arrs(i))
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a, i As Integer
        a = CInt(TextBox1.Text)
        arr(i) = a
        TextBox1.Clear()
        ListBox1.Items.Add(a)
        i = i + 1
    End Sub
End Class
