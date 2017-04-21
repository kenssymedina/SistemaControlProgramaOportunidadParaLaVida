Imports System.Data.SqlClient
Imports System.Data
Public Class FrmParentesco
    Implements IForm

    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        txtIdparentesco.Text = id
    End Sub
    Public Sub Guardar()
        If validar() = True Then
            Dim sp As New Parentesco With
            {
                .Parentesco = txtParentesco.Text
            }
            Try
                cnn.Parentescos.InsertOnSubmit(sp)
                cnn.SubmitChanges()
                MsgBox("Datos ingresados correctamente", MsgBoxStyle.Information, "Aviso")
                accesodatos.cargarParentescos(DataGridView1)
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
        btnActualizar.Size = New Size(49, 51) 'actualizar
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



    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()

    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove
        PictureBox3.Size = New Size(58, 59)
    End Sub

    Private Sub FrmParentesco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accesodatos.cargarParentescos(DataGridView1)
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call Guardar()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            Me.Height = 578
        Else
            Me.Height = 315
        End If
    End Sub
    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        'aqui obtiene el id de sql osea la pk de la tabla que se esta mostrando en el grid
        Dim id As String = DataGridView1.CurrentRow.Cells(0).Value
        'como la funcion del grid esta dentro del mismo formulario a donde se envia no ocuap instaciar la clase 
        Call ObtenerId(id)

    End Sub
    Private Sub txtIdparentesco_TextChanged(sender As Object, e As EventArgs) Handles txtIdparentesco.TextChanged
        If txtIdparentesco.Text <> "" Then
            accesodatos.CargarDatosParentesco(txtIdparentesco.Text, txtParentesco)
        End If
    End Sub
    Public Sub ActualizarDatos(id As Integer)

        Dim datos As Parentesco = (From sp In cnn.Parentescos
                                   Where sp.IdParentesco = id
                                   Select sp).ToList()(0)
        datos.Parentesco = Me.txtParentesco.Text

        Try
            cnn.SubmitChanges()
            MsgBox("Datos actualizado con éxito", MsgBoxStyle.Information, "Aviso")
            accesodatos.cargarParentescos(DataGridView1)
        Catch ex As Exception
            MsgBox("error al actualizar los datos", MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Me.txtParentesco.Text <> "" Then
            Call ActualizarDatos(CInt(txtIdparentesco.Text))
        Else
            MsgBox("Debe ingresar el nombre del tipo de parentesco", MsgBoxStyle.Critical, "Aviso")
            Me.txtParentesco.Focus()
        End If
    End Sub
    Private Sub limpiar()
        'txtIdparentesco.Text = ""
        txtParentesco.Text = ""
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Call limpiar()
        Call InvestigarCorrelativo()
    End Sub
    Private Function validar() As Boolean
        Dim estado As Boolean
        If txtIdparentesco.Text = Nothing And txtParentesco.Text = Nothing Then
            MessageBox.Show("ingrese los datos solicitados")
            txtParentesco.Focus()
            estado = False

        ElseIf txtParentesco.Text = Nothing Then
            MessageBox.Show("ingrese el parentesco")
            txtParentesco.Focus()
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
            Dim Listarparentesco As New SqlCommand("sp_identityhermano", cn)
            Listarparentesco.CommandType = CommandType.StoredProcedure
            Dim ListarParentescos As SqlDataReader
            cn.Open()
            ListarParentescos = Listarparentesco.ExecuteReader()
            If ListarParentescos.Read = True Then
                If ListarParentescos("Id") Is DBNull.Value Then
                    txtIdparentesco.Text = 1
                Else
                    txtIdparentesco.Text = ListarParentescos("Id").ToString
                End If
            End If
        Catch ex As Exception
        End Try
        txtParentesco.Focus()
    End Sub
End Class