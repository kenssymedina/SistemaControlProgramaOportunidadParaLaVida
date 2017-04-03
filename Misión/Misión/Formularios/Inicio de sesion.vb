Public Class FrmIniciarSesion
    Private Sub Button1_Click(sender As Object, e As EventArgs)

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



    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

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



    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox4_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseMove
        PictureBox4.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox5_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseMove
        PictureBox5.Size = New Size(58, 59)
    End Sub

    Private Sub FrmIniciarSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
