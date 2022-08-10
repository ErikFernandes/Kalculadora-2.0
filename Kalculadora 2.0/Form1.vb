Public Class Kalculadora

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        Try
            If BotaoSoma.Checked = False And BotaoSub.Checked = False And BotaoMulti.Checked = False And BotaoDivi.Checked = False Then
                MessageBox.Show("Selecione uma opção")
            End If

            If BotaoSoma.Checked = True Then
                Resultado.Text = Double.Parse(Valor1.Text) + Double.Parse(Valor2.Text)
            End If

            If BotaoSub.Checked = True Then
                Resultado.Text = Double.Parse(Valor1.Text) - Double.Parse(Valor2.Text)
            End If

            If BotaoMulti.Checked = True Then
                Resultado.Text = Double.Parse(Valor1.Text) * Double.Parse(Valor2.Text)
            End If

            If BotaoDivi.Checked = True Then
                Resultado.Text = Double.Parse(Valor1.Text) / Double.Parse(Valor2.Text)
            End If
        Catch
            MessageBox.Show("Digite apenas números")
        End Try

    End Sub
End Class
