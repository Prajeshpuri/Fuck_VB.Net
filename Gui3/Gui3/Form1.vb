Public Class Form1

    Public Function fact(ByVal number As Integer)
        fact = 1
        For i = 1 To number
            fact *= i
        Next
        Return fact
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        TextBox1.Text = "10 Even Numbers"
        For i = 1 To 20
            If i Mod 2 = 0 Then
                ListBox1.Items.Add(i)
            End If
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        TextBox1.Text = "10 Odd Numbers"
        For i = 1 To 20
            If i Mod 2 <> 0 Then
                ListBox1.Items.Add(i)
            End If
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        TextBox1.Text = "Factorial from 1-10"
        For i = 1 To 10
            ListBox1.Items.Add(fact(i))
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ListBox1.Items.Clear()
        TextBox1.Text = "Fibonacci Series"
        Dim a As Integer = 0
        Dim b As Integer = 1
        Dim n As Integer = 10
       
        ' Add up numbers.
        For i As Integer = 0 To n - 1
            Dim temp As Integer = a
            a = b
            b = temp + b
            ListBox1.Items.Add(temp)
        Next
    End Sub
End Class
