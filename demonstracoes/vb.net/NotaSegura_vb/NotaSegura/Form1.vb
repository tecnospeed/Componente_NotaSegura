Public Class Form1

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click



        Dim notasegura As New spdNotaSegura.spdNotaSeguraX



        notasegura.Login = txtLogin.Text

        notasegura.Senha = txtSenha.Text

        notasegura.Token = txtToken.Text



        txtXML.Text = notasegura.EnviarXml(txtXML.Text)







    End Sub

End Class