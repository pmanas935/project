Public Class Form1
    Dim attempt As Integer = 0
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim username As String
        Dim password As String

        username = TextBox1.Text

        password = TextBox2.Text

        If TextBox1.Text = "student" And TextBox2.Text = "12345" Then
            MessageBox.Show("succsfully")
            Form2.Show()
            Me.Hide()

        ElseIf TextBox1.Text IsNot "student" Or TextBox2.Text IsNot "12345" Then
            TextBox1.Clear()
            TextBox2.Clear()
            MessageBox.Show("your username and passwordis wrong. Please try again")
            attempt += 1


            If attempt = 3 Then
                TextBox1.ReadOnly = True
                TextBox2.ReadOnly = True

            End If
        End If
    End Sub
End Class
