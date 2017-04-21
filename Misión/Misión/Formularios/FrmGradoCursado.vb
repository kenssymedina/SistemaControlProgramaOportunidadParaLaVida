Imports System.Data.SqlClient
Imports System.Data
Public Class FrmGradoCursado
    Implements IForm

    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        txtIdGrado.Text = id
    End Sub
    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox4_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseMove
        PictureBox4.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        PictureBox1.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        PictureBox2.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Size = New Size(49, 51)
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

    Private Sub FrmGradoCursado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accesodatos.cargarGrado(DataGridView1)
    End Sub
    Private Function Validar() As Boolean
        Dim Estado As Boolean
        If txtIdGrado.Text = Nothing And txtGrado.Text = Nothing Then
            MessageBox.Show("Ingrese los datos solicitados")
            txtIdGrado.Focus()
            Estado = False
        ElseIf txtGrado.Text = Nothing Then
            MessageBox.Show("Ingrese el Grado")
            txtGrado.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado

    End Function
    Public Sub Guardar()
        If Validar() = True Then
            Dim sp As New GradoCursado With
            {
                .GradoCursado = txtGrado.Text
            }
            Try
                cnn.GradoCursados.InsertOnSubmit(sp)
                cnn.SubmitChanges()
                MsgBox("Datos ingresados correctamente", MsgBoxStyle.Information, "Aviso")
                accesodatos.cargarGrado(DataGridView1)
            Catch ex As Exception
                MsgBox("Error al guardar los datos", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Call Guardar()

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.CheckState = CheckState.Checked Then
            Me.Height = 497
        Else
            Me.Height = 279
        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        'aqui obtiene el id de sql osea la pk de la tabla que se esta mostrando en el grid
        Dim id As String = DataGridView1.CurrentRow.Cells(0).Value
        'como la funcion del grid esta dentro del mismo formulario a donde se envia no ocuap instaciar la clase 
        Call ObtenerId(id)
    End Sub

    Private Sub txtIdGrado_TextChanged(sender As Object, e As EventArgs) Handles txtIdGrado.TextChanged
        If txtIdGrado.Text <> "" Then
            accesodatos.CargarDatosGrado(txtIdGrado.Text, txtGrado)
        End If
    End Sub
    Public Sub ActualizarDatos(id As Integer)

        Dim datos As GradoCursado = (From I In cnn.GradoCursados
                                     Where I.IdGradoCursado = id
                                     Select I).ToList()(0)
        datos.GradoCursado = Me.txtGrado.Text
        Try
            cnn.SubmitChanges()
            MsgBox("Datos actualizado con éxito", MsgBoxStyle.Information, "Aviso")
            accesodatos.cargarGrado(DataGridView1)
        Catch ex As Exception
            MsgBox("error al actualizar los datos", MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Me.txtIdGrado.Text <> "" Then
            Call ActualizarDatos(CInt(txtIdGrado.Text))
        Else
            MsgBox("Debe ingresar el nombre de la Iglesia ", MsgBoxStyle.Critical, "Aviso")
            Me.txtGrado.Focus()
        End If
    End Sub
    Sub InvestigarCorrelativo()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            Dim ListarCiudad As New SqlCommand("Sp_IdentityGrado", cn)
            ListarCiudad.CommandType = CommandType.StoredProcedure
            Dim ListarCiudades As SqlDataReader
            cn.Open()
            ListarCiudades = ListarCiudad.ExecuteReader()
            If ListarCiudades.Read = True Then
                If ListarCiudades("Id") Is DBNull.Value Then
                    txtIdGrado.Text = 1
                Else
                    txtIdGrado.Text = ListarCiudades("Id").ToString
                End If
            End If
        Catch ex As Exception
        End Try
        txtGrado.Focus()

    End Sub
    Private Sub Limpiar()
        txtIdGrado.Clear()
        txtGrado.Clear()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Call Limpiar()
        Call InvestigarCorrelativo()
    End Sub
End Class