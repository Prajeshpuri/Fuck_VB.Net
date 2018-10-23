Public Class Form1
    Dim ara As New Form1()
    Dim ara2 As New Form1()
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        'Dim x As Integer
        If TextBox1.Text <> "" Then
            ara.Add(CInt(TextBox1.Text))
            ListBox1.Items.Add(CInt(TextBox1.Text))
            i = i + 1
        End If
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox2.Items.Clear()
        For i = 0 To ara.Count - 1
            If ara.Item(i) Mod 2 <> 0 Then
                ara2.Add(ara.Item(i))
                ListBox2.Items.Add(ara.Item(i))
            End If
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox2.Items.Clear()
        ara.Sort()
        ara.Reverse()
        ListBox1.Items.Clear()
        For i = 0 To ara.Count - 1
            'ara2.Add(ara.Item(i))
            ListBox2.Items.Add(ara.Item(i))
            ListBox1.Items.Add(ara.Item(i))
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim a As Integer
        a = CInt(TextBox2.Text)
        TextBox3.Text = ara.IndexOf(a)
    End Sub
End Class
