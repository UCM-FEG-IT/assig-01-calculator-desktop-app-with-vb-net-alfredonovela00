Public Class Form1



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "Button1" Then
            Resultado.Text = Resultado.Text + "1"

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "Button2" Then
            Resultado.Text = Resultado.Text + "2"

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "Button3" Then
            Resultado.Text = Resultado.Text + "3"

        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "Button4" Then
            Resultado.Text = Resultado.Text + "4"

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "Button5" Then
            Resultado.Text = Resultado.Text + "5"

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "Button6" Then
            Resultado.Text = Resultado.Text + "6"

        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "Button7" Then
            Resultado.Text = Resultado.Text + "7"

        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "Button8" Then
            Resultado.Text = Resultado.Text + "8"

        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "Button9" Then
            Resultado.Text = Resultado.Text + "9"

        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "Button0" Then
            Resultado.Text = Resultado.Text + "0"

        End If
    End Sub

    Private Sub ButtonPonto_Click(sender As Object, e As EventArgs) Handles ButtonPonto.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "ButtonPonto" Then
            Resultado.Text = Resultado.Text + "."

        End If
    End Sub

    Private Sub ButtonCLR_Click(sender As Object, e As EventArgs) Handles ButtonCLR.Click
        Resultado.Clear()
    End Sub

    Private Sub ButtonIgual_Click(sender As Object, e As EventArgs) Handles ButtonIgual.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "ButtonIgual" Then
            Dim equation As String = Resultado.Text
            Dim result = New DataTable().Compute(equation, Nothing)
            Resultado.Text = result
        End If

        If button.Name = "ButtonDiv" Then

            Resultado.Text = Resultado.Text + "/"
        End If

        If button.Name = "ButtonAdi" Then

            Resultado.Text = Resultado.Text + "+"
        End If

        If button.Name = "ButtonSub" Then

            Resultado.Text = Resultado.Text + "-"
        End If

        If button.Name = "ButtonCLR" Then

            Resultado.Text = ""
        End If
    End Sub

    Private Sub ButtonAdi_Click(sender As Object, e As EventArgs) Handles ButtonAdi.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "ButtonAdi" Then
            Resultado.Text = Resultado.Text + "+"
        End If
    End Sub

    Private Sub ButtonMult_Click(sender As Object, e As EventArgs) Handles ButtonMult.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "ButtonMult" Then
            Resultado.Text = Resultado.Text + "*"
        End If
    End Sub

    Private Sub ButtonSub_Click(sender As Object, e As EventArgs) Handles ButtonSub.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "ButtonSub" Then
            Resultado.Text = Resultado.Text + "-"
        End If
    End Sub

    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        Dim button As Button = CType(sender, Button)
        If button.Name = "ButtonDiv" Then
            Resultado.Text = Resultado.Text + "/"
        End If
    End Sub
End Class
