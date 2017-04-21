Imports System.Data.SqlClient
Imports System.Data
Public Class FrmPais
    Implements IForm
    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        txtIdPais.Text = id
    End Sub
    Public Sub Guardar()
        If validar() = True Then
            Dim sp As New Pai With
            {
                .Pais = txtPais.Text
            }
            Try
                cnn.Pais.InsertOnSubmit(sp)
                cnn.SubmitChanges()
                MsgBox("Datos ingresados correctamente", MsgBoxStyle.Information, "Aviso")
                accesodatos.cargarPaises(DataGridView1)
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
        btnGuardar.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles btnActualizar.MouseLeave
        btnActualizar.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles btnActualizar.MouseMove
        btnActualizar.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox5_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseMove
        PictureBox5.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove
        PictureBox3.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub FrmPais_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accesodatos.cargarPaises(DataGridView1)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call Guardar()
    End Sub

    Private Sub chkVer_CheckedChanged(sender As Object, e As EventArgs) Handles chkVer.CheckedChanged
        '705, 314
        If chkVer.CheckState = CheckState.Checked Then
            Me.Height = 705
        Else
            Me.Height = 314
        End If
    End Sub
    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        'aqui obtiene el id de sql osea la pk de la tabla que se esta mostrando en el grid
        Dim id As String = DataGridView1.CurrentRow.Cells(0).Value
        'como la funcion del grid esta dentro del mismo formulario a donde se envia no ocuap instaciar la clase 
        Call ObtenerId(id)
    End Sub
    Private Sub txtIdPais_TextChanged(sender As Object, e As EventArgs) Handles txtIdPais.TextChanged
        If txtIdPais.Text <> "" Then
            accesodatos.CargarDatosPaises(txtIdPais.Text, txtPais)
        End If
    End Sub
    Public Sub ActualizarDatos(id As Integer)

        Dim datos As Pai = (From sp In cnn.Pais
                            Where sp.IdPais = id
                            Select sp).ToList()(0)
        datos.Pais = Me.txtPais.Text

        Try
            cnn.SubmitChanges()
            MsgBox("Datos actualizado con éxito", MsgBoxStyle.Information, "Aviso")
            accesodatos.cargarPaises(DataGridView1)
        Catch ex As Exception
            MsgBox("error al actualizar los datos", MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Me.txtPais.Text <> "" Then
            Call ActualizarDatos(CInt(txtIdPais.Text))
        Else
            MsgBox("Debe ingresar el nombre del pais", MsgBoxStyle.Critical, "Aviso")
            Me.txtPais.Focus()
        End If
    End Sub
    Private Sub limpiar()
        'txtIdPais.Text = ""
        txtPais.Text = ""
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Call limpiar()
        Call InvestigarCorrelativo()

    End Sub
    Private Function validar() As Boolean
        Dim estado As Boolean
        If txtIdPais.Text = Nothing And txtPais.Text = Nothing Then
            MessageBox.Show("Ingrese los datos solicitados")
            txtIdPais.Focus()
            estado = False

        ElseIf txtPais.Text = Nothing Then
            MessageBox.Show("Ingrese el pais")
            txtPais.Focus()
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
            Dim Listarpais As New SqlCommand("sp_identityhermano", cn)
            Listarpais.CommandType = CommandType.StoredProcedure
            Dim ListarPaises As SqlDataReader
            cn.Open()
            ListarPaises = Listarpais.ExecuteReader()
            If ListarPaises.Read = True Then
                If ListarPaises("Id") Is DBNull.Value Then
                    txtIdPais.Text = 1
                Else
                    txtIdPais.Text = ListarPaises("Id").ToString
                End If
            End If
        Catch ex As Exception
        End Try
        txtPais.Focus()
    End Sub
End Class