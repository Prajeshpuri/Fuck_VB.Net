Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As String
        a = TextBox1.Text
        ListBox1.Items.Add(a)
        TextBox1.Clear()
        'ComboBox1.Items.Add(a)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'delete button
        Dim z As String
        z = ComboBox1.SelectedItem
        ComboBox1.Items.Remove(z)
        ListBox1.Items.Remove(z)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'delete all button
        ListBox1.Items.Clear()
        ComboBox1.Items.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'move button
        Dim temp As String
        temp = ListBox1.SelectedItem
        ComboBox1.Items.Add(temp)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'move all button
        Dim i As Integer
        Dim temp As String
        For i = 0 To ListBox1.Items.Count - 1
            temp = ListBox1.Items(i)
            ComboBox1.Items.Add(temp)
        Next
    End Sub
End Class
