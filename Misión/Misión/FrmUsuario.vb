Imports System.Data.SqlClient
Imports System.Data
Public Class FrmUsuario

    Implements IForm

    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        txtIdUsuario.Text = id
    End Sub

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarEstadoUsuario()
    End Sub

    Private Sub txtIdUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtIdUsuario.TextChanged
        If txtIdUsuario.Text <> "" Then
            accesodatos.CargarDatosUsuario(txtIdUsuario.Text, TxtNombreUsuario, TxtContrasena, CboEstadoUsuario)
        End If
    End Sub
    Public Sub LlenarEstadoUsuario()

        Dim datos = (From G In cnn.EstadoUsuarios
                     Order By G.IdEstadoUsuario Ascending
                     Select G.IdEstadoUsuario, G.EstadoUsuario).ToList
        Me.CboEstadoUsuario.DataSource = datos
        Me.CboEstadoUsuario.ValueMember = "IdEstadoUsuario"
        Me.CboEstadoUsuario.DisplayMember = "EstadoUsuario"
        Me.CboEstadoUsuario.SelectedIndex = -1
        Me.CboEstadoUsuario.Text = "Seleccione"

    End Sub

    Private Sub BtnBuscarUsuario_Click(sender As Object, e As EventArgs) Handles BtnBuscarUsuario.Click
        'aqui muestra el formulario de busqueda
        Dim frm As New FrmBusquedaUsuario()
        frm.Show(Me)
    End Sub

    Private Function Validar() As Boolean
        Dim Estado As Boolean
        If txtIdUsuario.Text = Nothing And TxtNombreUsuario.Text = Nothing And TxtContrasena.Text = Nothing And
          CboEstadoUsuario.SelectedIndex = -1 Then
            MessageBox.Show("Ingrese los datos solicitados")
            txtIdUsuario.Focus()
            Estado = False
        ElseIf TxtNombreUsuario.Text = Nothing Then
            MessageBox.Show("Ingrese el Nombre del Usuario")
            TxtNombreUsuario.Focus()
            Estado = False
        ElseIf TxtContrasena.Text = Nothing Then
            MessageBox.Show("Ingrese la Contraseña del Usuario")
            TxtContrasena.Focus()
            Estado = False
        ElseIf CboEstadoUsuario.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el estado del Usuario")
            CboEstadoUsuario.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado
    End Function
    Public Sub Guardar()

        If Validar() = True Then
            Dim sp As New Usuario With
        {
            .NombreUsuario = TxtNombreUsuario.Text,
            .Contraseña = TxtContrasena.Text,
            .IdEstadoUsuario = CInt(Me.CboEstadoUsuario.SelectedValue),
            .IdUsuario = IdUsuarioSistemaActual
         }

            Try
                cnn.Usuarios.InsertOnSubmit(sp)
                cnn.SubmitChanges()
                MsgBox("Datos ingresados correctamente", MsgBoxStyle.Information, "Aviso")
            Catch ex As Exception
                MsgBox("Error al guardar los datos", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Call Guardar()
    End Sub
    Public Sub ActualizarDatos(id As Integer)

        Dim datos As Usuario = (From g In cnn.Usuarios
                                Where g.IdUsuario = id
                                Select g).ToList()(0)
        datos.NombreUsuario = TxtNombreUsuario.Text
        datos.Contraseña = TxtContrasena.Text
        datos.IdEstadoUsuario = CInt(CboEstadoUsuario.SelectedValue)
        Try
            cnn.SubmitChanges()
            MsgBox("Datos Actualizados correctamente", MsgBoxStyle.Information, "Aviso")

        Catch ex As Exception
            MsgBox("Eror al Actualizar los Datos")
        End Try
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Call ActualizarDatos(CInt(txtIdUsuario.Text))
    End Sub
    Private Sub Limpiar()
        txtIdUsuario.Clear()
        TxtNombreUsuario.Clear()
        TxtContrasena.Clear()
        CboEstadoUsuario.Text = "Seleccione"
    End Sub
    Sub InvestigarCorrelativo()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            Dim ListarHermano As New SqlCommand("Sp_IdentityUsuario", cn)
            ListarHermano.CommandType = CommandType.StoredProcedure
            Dim ListarHermanos As SqlDataReader
            cn.Open()
            ListarHermanos = ListarHermano.ExecuteReader()
            If ListarHermanos.Read = True Then
                If ListarHermanos("Id") Is DBNull.Value Then
                    txtIdUsuario.Text = 1
                Else
                    txtIdUsuario.Text = ListarHermanos("Id").ToString
                End If
            End If
        Catch ex As Exception
        End Try
        TxtNombreUsuario.Focus()

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call Limpiar()
        Call InvestigarCorrelativo()
    End Sub
End Class