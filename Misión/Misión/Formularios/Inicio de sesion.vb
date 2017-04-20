Imports System.Data.SqlClient

Public Class FrmIniciarSesion

    Public IdUsuarioActual As Integer
    Public NombreUsuario As String
    'declaramos una variable booleana para verificar el estado del inicio 
    Public Property EsInicio As Boolean = True

    Private Sub btnEntrar_Click(sender As Object, e As EventArgs) Handles btnEntrar.Click
        If Trim(Me.txtUsuario.Text) = Nothing Then
            Me.txtUsuario.Focus()
            MsgBox("Debe ingresar el nombre de usuario", MsgBoxStyle.Information, "Usuario requerido")
        ElseIf Trim(Me.txtContra.Text) = Nothing Then
            Me.txtContra.Focus()
            MsgBox("Debe ingresar la contraseña del usuario", MsgBoxStyle.Information, "Contraseña requerida")
        Else
            If ExisteRegistro() = False Then
                MsgBox("Usuario o contraseña incorrecta", MsgBoxStyle.Exclamation, "Intenta de nuevo")
                Me.txtContra.Text = Nothing
                Me.txtUsuario.Text = Nothing
                Me.txtUsuario.Focus()
            Else

                Me.DialogResult = DialogResult.OK
                ' si el estado es tru entonces se cerrara el formulario de control de ususario y mostrara la pantalla principal
                If EsInicio = True Then
                    Me.Hide()
                    FrmMenuPrincipal.Show()
                    'MDIprincipal.txtUserLog.Text = Me.txtUsuario.Text
                End If

                Me.Close()
            End If

        End If


    End Sub


    Private Function ExisteRegistro() As Boolean
        'declaramos una variable que servira de parametro para la funcion de encriptacion
        Dim contra As String
        'verificamos el stado de la conexion
        If cnn.Connection.State = ConnectionState.Open Then
            cnn.Connection.Close()

        End If
        Dim state As Boolean
        'le asignamos a la variable el valor que retorna la encriptacion de la contraseña que se ingreso en el usuario
        contra = Me.txtContra.Text

        Try
            'llamammos el procedimiento alamcenado y le asignamos los parametros correspondientes
            Dim ListaUsuario As New SqlCommand("Sp_ExisteUsuario", cnn.Connection)
            ListaUsuario.CommandType = CommandType.StoredProcedure
            ListaUsuario.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 100).Value = Trim(Me.txtUsuario.Text)
            ListaUsuario.Parameters.Add("Contraseña", SqlDbType.NVarChar, 100).Value = contra ' la encriptacion se compara con lo que esta encriptado
            'en la base de datos de no ser igual no podra ingresar
            ListaUsuario.Connection = cnn.Connection   'Nombra la conexion'
            cnn.Connection.Open()
            IdUsuarioSistemaActual = Convert.ToInt32(ListaUsuario.ExecuteScalar())
            'si encutra un registro de ese usuario el estado sera TRUE por lo cual dejara acceder a la Aplciacion
            If IdUsuarioSistemaActual > 0 Then
                state = True
            Else
                state = False

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            cnn.Connection.Close()

        End Try
        Return state
    End Function

    Public Function MostrarID() As String
        If cnn.Connection.State = ConnectionState.Open Then
            cnn.Connection.Close()
        End If

        Try
            cnn.Connection.Open()



            Dim ListaUsuario As New SqlCommand("Sp_MostraID", cnn.Connection)
            ListaUsuario.CommandType = CommandType.StoredProcedure
            ListaUsuario.Parameters.Add("@NombreUsuario", SqlDbType.VarChar, 25).Value = Me.txtUsuario.Text
            Dim ListaUsuarios As SqlDataReader
            ListaUsuarios = ListaUsuario.ExecuteReader()
            If ListaUsuarios.Read Then
                NombreUsuario = (ListaUsuarios("Datos correctos").ToString)

            End If
            cnn.Connection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return NombreUsuario
    End Function



    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles btnEntrar.MouseLeave
        btnEntrar.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox4_MouseMove(sender As Object, e As MouseEventArgs) Handles btnEntrar.MouseMove
        btnEntrar.Size = New Size(58, 59)
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
