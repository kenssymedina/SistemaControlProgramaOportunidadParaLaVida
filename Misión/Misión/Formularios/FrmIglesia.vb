Imports System.Data.SqlClient
Imports System.Data

Public Class FrmIglesia

    Implements IForm

    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        txtIdIglesia.Text = id
    End Sub

    Public Sub Guardar()
        If Validar() = True Then
            Dim sp As New Iglesia With
            {
                .Iglesia = txtIglesia.Text,
                .NombrePastor = TxtNombrePastor.Text
            }
            Try
                cnn.Iglesias.InsertOnSubmit(sp)
                cnn.SubmitChanges()
                MsgBox("Datos ingresados correctamente", MsgBoxStyle.Information, "Aviso")
                accesodatos.cargarIglesia(DataGridView1)
            Catch ex As Exception
                MsgBox("Error al guardar los datos", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End Try
        End If
    End Sub


    Private Sub PictureBox4_MouseMove(sender As Object, e As MouseEventArgs) Handles btnNuevo.MouseMove
        btnNuevo.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles btnNuevo.MouseLeave
        btnNuevo.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseMove
        btnGuardar.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.Size = New Size(49, 51)
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

    Private Sub FrmIglesia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accesodatos.cargarIglesia(DataGridView1)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.CheckState = CheckState.Checked Then
            Me.Height = 567
        Else
            Me.Height = 274
        End If
    End Sub
    Private Function Validar() As Boolean
        Dim Estado As Boolean
        If txtIglesia.Text = Nothing And TxtNombrePastor.Text = Nothing Then
            MessageBox.Show("Ingrese los datos solicitados")
            txtIglesia.Focus()
            Estado = False
        ElseIf txtIglesia.Text = Nothing Then
            MessageBox.Show("Ingrese el Nombre de la Iglesia")
            txtIglesia.Focus()
            Estado = False
        ElseIf TxtNombrePastor.Text = Nothing Then
            MessageBox.Show("Ingrese el Nombre del ´Pastor")
            TxtNombrePastor.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado

    End Function

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call Guardar()
    End Sub


    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        'aqui obtiene el id de sql osea la pk de la tabla que se esta mostrando en el grid
        Dim id As String = DataGridView1.CurrentRow.Cells(0).Value
        'como la funcion del grid esta dentro del mismo formulario a donde se envia no ocuap instaciar la clase 
        Call ObtenerId(id)
    End Sub

    Private Sub txtIdIglesia_TextChanged(sender As Object, e As EventArgs) Handles txtIdIglesia.TextChanged
        If txtIdIglesia.Text <> "" Then
            accesodatos.CargarDatosIglesia(txtIdIglesia.Text, txtIglesia, TxtNombrePastor)
        End If
    End Sub
    Public Sub ActualizarDatos(id As Integer)

        Dim datos As Iglesia = (From I In cnn.Iglesias
                                Where I.IdIglesia = id
                                Select I).ToList()(0)
        datos.Iglesia = Me.txtIglesia.Text
        datos.NombrePastor = Me.TxtNombrePastor.Text

        Try
            cnn.SubmitChanges()
            MsgBox("Datos actualizado con éxito", MsgBoxStyle.Information, "Aviso")
            accesodatos.cargarIglesia(DataGridView1)
        Catch ex As Exception
            MsgBox("error al actualizar los datos", MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If Me.txtIdIglesia.Text <> "" Then
            Call ActualizarDatos(CInt(txtIdIglesia.Text))
        Else
            MsgBox("Debe ingresar el nombre de la Iglesia ", MsgBoxStyle.Critical, "Aviso")
            Me.txtIglesia.Focus()
        End If
    End Sub
    Sub InvestigarCorrelativo()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            Dim ListarCiudad As New SqlCommand("Sp_MostrarIglesiaIdentity", cn)
            ListarCiudad.CommandType = CommandType.StoredProcedure
            Dim ListarCiudades As SqlDataReader
            cn.Open()
            ListarCiudades = ListarCiudad.ExecuteReader()
            If ListarCiudades.Read = True Then
                If ListarCiudades("Id") Is DBNull.Value Then
                    txtIdIglesia.Text = 1
                Else
                    txtIdIglesia.Text = ListarCiudades("Id").ToString
                End If
            End If
        Catch ex As Exception
        End Try
        txtIglesia.Focus()

    End Sub


    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        txtIdIglesia.Clear()
        txtIglesia.Clear()
        TxtNombrePastor.Clear()
        Call InvestigarCorrelativo()
    End Sub
End Class