Imports System.Data.SqlClient
Imports System.Data
Public Class FrmNacionalidad
    Implements IForm
    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        txtidNacionalidad.Text = id
    End Sub
    Public Sub Guardar()
        If validar() = True Then
            Dim sp As New Nacionalidad With
            {
                .Nacionalidad = txtNacionalidad.Text
            }
            Try
                cnn.Nacionalidads.InsertOnSubmit(sp)
                cnn.SubmitChanges()
                MsgBox("Datos ingresados correctamente", MsgBoxStyle.Information, "Aviso")
                accesodatos.cargarNacionalidades(DataGridView1)
            Catch ex As Exception
                MsgBox("Error al guardar los datos", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub PictureBox4_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseMove
        PictureBox4.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseMove
        btnGuardar.Size = New Size(58, 59) ' guardar
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles btnActualizar.MouseMove
        btnActualizar.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles btnActualizar.MouseLeave
        btnActualizar.Size = New Size(49, 51) ' actualizar
    End Sub

    Private Sub PictureBox5_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseMove
        PictureBox5.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove
        PictureBox3.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub FrmNacionalidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accesodatos.cargarNacionalidades(DataGridView1)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call Guardar()
    End Sub

    Private Sub chkVer_CheckedChanged(sender As Object, e As EventArgs) Handles chkVer.CheckedChanged
        If chkVer.CheckState = CheckState.Checked Then
            Me.Height = 705
        Else
            Me.Height = 313
        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        'aqui obtiene el id de sql osea la pk de la tabla que se esta mostrando en el grid
        Dim id As String = DataGridView1.CurrentRow.Cells(0).Value
        'como la funcion del grid esta dentro del mismo formulario a donde se envia no ocuap instaciar la clase 
        Call ObtenerId(id)



    End Sub

    Private Sub txtidNacionalidad_TextChanged(sender As Object, e As EventArgs) Handles txtidNacionalidad.TextChanged
        If txtidNacionalidad.Text <> "" Then
            accesodatos.CargarDatosNacionalidad(txtidNacionalidad.Text, txtNacionalidad)
        End If
    End Sub
    Public Sub ActualizarDatos(id As Integer)

        Dim datos As Nacionalidad = (From sp In cnn.Nacionalidads
                                     Where sp.IdNacionalidad = id
                                     Select sp).ToList()(0)
        datos.Nacionalidad = Me.txtNacionalidad.Text

        Try
            cnn.SubmitChanges()
            MsgBox("Datos actualizado con éxito", MsgBoxStyle.Information, "Aviso")
            accesodatos.cargarNacionalidades(DataGridView1)
        Catch ex As Exception
            MsgBox("error al actualizar los datos", MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Me.txtNacionalidad.Text <> "" Then
            Call ActualizarDatos(CInt(txtidNacionalidad.Text))
        Else
            MsgBox("Debe ingresar el nombre de la nacionalidad", MsgBoxStyle.Critical, "Aviso")
            Me.txtNacionalidad.Focus()
        End If
    End Sub
    Private Sub limpiar()
        ' txtidNacionalidad.Text = ""
        txtNacionalidad.Text = ""
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Call limpiar()
        Call InvestigarCorrelativo()
    End Sub
    Private Function validar() As Boolean
        Dim estado As Boolean
        If txtidNacionalidad.Text = Nothing And txtNacionalidad.Text = Nothing Then
            MessageBox.Show("ingrese todos los datos")
            txtidNacionalidad.Focus()
            estado = False
        ElseIf txtNacionalidad.Text = Nothing Then
            MessageBox.Show("escriba la nacionalidad")
            txtNacionalidad.Focus()
            estado = False
        Else
            estado = True
        End If
        Return estado
    End Function
    Sub InvestigarCorrelativo()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            Dim Listarnacionalidad As New SqlCommand("Sp_NacionalidadIdentity", cn)
            Listarnacionalidad.CommandType = CommandType.StoredProcedure
            Dim Listarnacionalidades As SqlDataReader
            cn.Open()
            Listarnacionalidades = Listarnacionalidad.ExecuteReader()
            If Listarnacionalidades.Read = True Then
                If Listarnacionalidades("Id") Is DBNull.Value Then
                    txtidNacionalidad.Text = 1
                Else
                    txtidNacionalidad.Text = Listarnacionalidades("Id").ToString
                End If
            End If
        Catch ex As Exception
        End Try
        txtidNacionalidad.Focus()
    End Sub
End Class