Public Class Calculator_App


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1_Validating()
        TextBox2_Validating()
        If RadioButton1.Checked Then
            MessageBox.Show(Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text))
        ElseIf RadioButton2.Checked Then
            MessageBox.Show(TextBox1.Text - TextBox2.Text)
        ElseIf RadioButton3.Checked Then
            MessageBox.Show(TextBox1.Text / TextBox2.Text)
        ElseIf RadioButton4.Checked Then
            MessageBox.Show(TextBox1.Text * TextBox2.Text)
        ElseIf RadioButton5.Checked Then
            MessageBox.Show(TextBox1.Text Mod TextBox2.Text)
        End If
    End Sub

    Private Sub TextBox1_Validating() Handles TextBox1.Validating
        Dim userInput As String = TextBox1.Text

        If Not IsNumeric(userInput) Then
            MessageBox.Show("Please enter a numeric value in first number.")
            TextBox1.Focus()
            TextBox1.Text = ""
        End If
    End Sub

    Private Sub TextBox2_Validating() Handles TextBox2.Validating
        Dim userInput As String = TextBox2.Text

        If Not IsNumeric(userInput) Then
            MessageBox.Show("Please enter a numeric value in second number.")
            TextBox2.Focus()
            TextBox2.Text = ""
        End If
    End Sub
End Class
