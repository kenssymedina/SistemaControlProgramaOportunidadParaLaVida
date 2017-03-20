Public Class FrmIniciar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click

        If TxtNombreUsuario.Text = "" And TxtContraseña.Text = "" Then
            MsgBox("Debe ingresar los datos", MsgBoxStyle.Information, "Error")
        ElseIf TxtNombreUsuario.Text = "" Then
            MsgBox("Ingresar el nombre del usuario", MsgBoxStyle.Information, "Error")
        ElseIf TxtContraseña.Text = "" Then
            MsgBox("Ingresar la contraseña", MsgBoxStyle.Information, "Error")
        ElseIf TxtNombreUsuario.Text <> user And TxtContraseña.Text <> pasword Then
            TxtNombreUsuario.Text = ""
            TxtContraseña.Text = ""
            MsgBox("Usuario o Contraseña Incorrecta", MsgBoxStyle.Critical, "Error")
        Else
            Me.Hide()
            FrmMenuPrincipal.Show()

        End If
    End Sub
End Class
