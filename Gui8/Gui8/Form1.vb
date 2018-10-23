Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ice cream names
        ComboBox1.Items.Add("Mint Chocolate Chip")
        ComboBox1.Items.Add("Butter Pecan")
        ComboBox1.Items.Add("Rocky Road")
        ComboBox1.Items.Add("Butter Cokkie")
        ComboBox1.Items.Add("Tutti Frutti")
        ComboBox1.Items.Add("Black Current")
        ComboBox1.Items.Add("Blue Moon")

        'flavour names
        ComboBox2.Items.Add("Mango")
        ComboBox2.Items.Add("Chocolate")
        ComboBox2.Items.Add("Fruit")
        ComboBox2.Items.Add("Coffee")

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'calcprice()
        Dim arr(6) As String
        Dim total_price As Integer
        Dim ice_cream_price = New Integer() {230, 300, 85, 79, 150, 200, 100}
        Dim flavour_price = New Integer() {23, 30, 10, 15}

        'adding price for ice cream
        For i = 0 To 6
            If ComboBox1.SelectedIndex = i Then
                total_price += ice_cream_price(i)
            End If
        Next

        'add to total for Cup or Cone
        If RadioButton1.Checked Then
            'Add 20 more for Cup
            total_price += 20
        ElseIf RadioButton2.Checked Then
            'Add 25 more for cone
            total_price += 25
        End If

        'For flavours
        For j = 0 To 3
            If ComboBox2.SelectedIndex = j Then
                total_price += flavour_price(j)
            End If
        Next

        
        'for toppings
        If CheckBox1.Checked Then
            'Nuts
            total_price += 15
        End If
        If CheckBox2.Checked Then
            'Chocolate
            total_price += 10
        End If
        If CheckBox3.Checked Then
            'fruit
            total_price += 9
        End If
        If CheckBox4.Checked Then
            'coffee
            total_price += 9
        End If


        'For Quantity
        If Not String.IsNullOrEmpty(TextBox1.Text) Then
            total_price *= Integer.Parse(TextBox1.Text)
        End If
        Label8.Text = total_price
    End Sub
End Class
