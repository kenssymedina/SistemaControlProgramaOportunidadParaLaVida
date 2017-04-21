Imports System.Data.SqlClient
Imports System.Data

Public Class FrmOficioProfesion
    Implements IForm

    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        txtidOficio.Text = id
    End Sub
    Public Sub Guardar()
        If validar() = True Then
            Dim sp As New OficioProfesion With
            {
                .OficioProfesion = txtOficio.Text
            }
            Try
                cnn.OficioProfesions.InsertOnSubmit(sp)
                cnn.SubmitChanges()
                MsgBox("Datos ingresados correctamente", MsgBoxStyle.Information, "Aviso")
                accesodatos.cargaroficios(DataGridView1)
            Catch ex As Exception
                MsgBox("Error al guardar los datos", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End Try
        End If
    End Sub
    Private Sub FrmOficioProfesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accesodatos.cargaroficios(DataGridView1)
    End Sub

    Private Sub PictureBox4_MouseMove(sender As Object, e As MouseEventArgs) Handles btnnuevo.MouseMove
        btnnuevo.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles btnnuevo.MouseLeave
        btnnuevo.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles btnGuardar.MouseLeave
        btnGuardar.Size = New Size(49, 51) ' guarddar
    End Sub



    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles btnActualizar.MouseLeave
        btnActualizar.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles btnActualizar.MouseMove
        btnActualizar.Size = New Size(58, 59) ' actualizar
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

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles btnGuardar.MouseMove
        btnGuardar.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call Guardar()
    End Sub

    Private Sub chkVer_CheckedChanged(sender As Object, e As EventArgs) Handles chkVer.CheckedChanged
        If chkVer.CheckState = CheckState.Checked Then
            Me.Height = 705
        Else
            Me.Height = 329

        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        'aqui obtiene el id de sql osea la pk de la tabla que se esta mostrando en el grid
        Dim id As String = DataGridView1.CurrentRow.Cells(0).Value
        'como la funcion del grid esta dentro del mismo formulario a donde se envia no ocuap instaciar la clase 
        Call ObtenerId(id)



    End Sub
    Private Sub txtidOficio_TextChanged(sender As Object, e As EventArgs) Handles txtidOficio.TextChanged
        If txtidOficio.Text <> "" Then
            accesodatos.CargarDatosTipoOficio(txtidOficio.Text, txtOficio)
        End If
    End Sub
    Public Sub ActualizarDatos(id As Integer)

        Dim datos As OficioProfesion = (From sp In cnn.OficioProfesions
                                        Where sp.IdOficioProfesion = id
                                        Select sp).ToList()(0)
        datos.OficioProfesion = Me.txtOficio.Text

        Try
            cnn.SubmitChanges()
            MsgBox("Datos actualizado con éxito", MsgBoxStyle.Information, "Aviso")
            accesodatos.cargaroficios(DataGridView1)
        Catch ex As Exception
            MsgBox("error al actualizar los datos", MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Me.txtOficio.Text <> "" Then
            Call ActualizarDatos(CInt(txtidOficio.Text))
        Else
            MsgBox("Debe ingresar el nombre del tipo de oficio", MsgBoxStyle.Critical, "Aviso")
            Me.txtOficio.Focus()
        End If
    End Sub
    Private Sub limpiar()
        'txtidOficio.Text = ""
        txtOficio.Text = ""
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        Call limpiar()
        Call InvestigarCorrelativo()
    End Sub
    Private Function validar() As Boolean
        Dim estado As Boolean
        If txtidOficio.Text = Nothing And txtOficio.Text = Nothing Then
            MessageBox.Show("Ingrese los datos solicitados")
            txtidOficio.Focus()
            estado = False

        ElseIf txtidOficio.Text = Nothing Then
            MessageBox.Show("Ingrese el oficio")
            txtOficio.Focus()
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
            Dim ListarOficio As New SqlCommand("sp_identityhermano", cn)
            ListarOficio.CommandType = CommandType.StoredProcedure
            Dim ListarOficios As SqlDataReader
            cn.Open()
            ListarOficios = ListarOficio.ExecuteReader()
            If ListarOficios.Read = True Then
                If ListarOficios("Id") Is DBNull.Value Then
                    txtidOficio.Text = 1
                Else
                    txtidOficio.Text = ListarOficios("Id").ToString
                End If
            End If
        Catch ex As Exception
        End Try
        txtOficio.Focus()
    End Sub

End Class