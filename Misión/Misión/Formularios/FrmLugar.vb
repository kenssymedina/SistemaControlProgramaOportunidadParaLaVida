Imports System.Data.SqlClient
Imports System.Data
Public Class FrmLugar
    Implements IForm

    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        TxtIdLugar.Text = id
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()

    End Sub
    Public Sub LlenarPais()

        Dim datos = (From G In cnn.Pais
                     Order By G.IdPais Ascending
                     Select G.IdPais, G.Pais).ToList
        Me.CboPais.DataSource = datos
        Me.CboPais.ValueMember = "IdPais"
        Me.CboPais.DisplayMember = "Pais"
        Me.CboPais.SelectedIndex = -1
        Me.CboPais.Text = "Seleccione"

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

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles btnActualizar.MouseMove
        btnActualizar.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles btnActualizar.MouseLeave
        btnActualizar.Size = New Size(49, 51)
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

    Private Sub FrmLugar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarPais()
        accesodatos.cargarLugar(DataGridView1)
    End Sub
    Private Function Validar() As Boolean
        Dim Estado As Boolean
        If TxtIdLugar.Text = Nothing And TxtLugar.Text = Nothing And CboPais.SelectedIndex = -1 Then
            MessageBox.Show("Ingrese los datos solicitados")
            TxtIdLugar.Focus()
            Estado = False
        ElseIf TxtLugar.Text = Nothing Then
            MessageBox.Show("Ingrese el Lugar")
            TxtLugar.Focus()
            Estado = False
        ElseIf CboPais.SelectedIndex = -1 Then
            MessageBox.Show("Seleccion el Pais")
            CboPais.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado

    End Function
    Public Sub Guardar()
        If Validar() = True Then
            Dim sp As New Lugar With
            {
                .Lugar = TxtLugar.Text,
                .IdPais = CInt(Me.CboPais.SelectedValue)
            }
            Try
                cnn.Lugars.InsertOnSubmit(sp)
                cnn.SubmitChanges()
                MsgBox("Datos ingresados correctamente", MsgBoxStyle.Information, "Aviso")
                accesodatos.cargarLugar(DataGridView1)
            Catch ex As Exception
                MsgBox("Error al guardar los datos", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            Me.Height = 551
        Else
            Me.Height = 323
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Call Guardar()
    End Sub


    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        'aqui obtiene el id de sql osea la pk de la tabla que se esta mostrando en el grid
        Dim id As String = DataGridView1.CurrentRow.Cells(0).Value
        'como la funcion del grid esta dentro del mismo formulario a donde se envia no ocuap instaciar la clase 
        Call ObtenerId(id)
    End Sub

    Private Sub TxtIdLugar_TextChanged(sender As Object, e As EventArgs) Handles TxtIdLugar.TextChanged
        If TxtIdLugar.Text <> "" Then
            accesodatos.CargarDatosLugar(TxtIdLugar.Text, TxtLugar, CboPais)
        End If
    End Sub
    Public Sub ActualizarDatos(id As Integer)

        Dim datos As Lugar = (From I In cnn.Lugars
                              Where I.IdLugar = id
                              Select I).ToList()(0)
        datos.Lugar = Me.TxtLugar.Text
        datos.IdPais = CInt(CboPais.SelectedValue)

        Try
            cnn.SubmitChanges()
            MsgBox("Datos actualizado con éxito", MsgBoxStyle.Information, "Aviso")
            accesodatos.cargarLugar(DataGridView1)
        Catch ex As Exception
            MsgBox("error al actualizar los datos", MsgBoxStyle.Critical, "Aviso")
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If Me.TxtIdLugar.Text <> "" Then
            Call ActualizarDatos(CInt(TxtIdLugar.Text))
        Else
            MsgBox("Debe ingresar el nombre de la Iglesia ", MsgBoxStyle.Critical, "Aviso")
            Me.TxtLugar.Focus()
        End If

    End Sub
    Sub InvestigarCorrelativo()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            Dim ListarCiudad As New SqlCommand("Sp_IdentityLugar", cn)
            ListarCiudad.CommandType = CommandType.StoredProcedure
            Dim ListarCiudades As SqlDataReader
            cn.Open()
            ListarCiudades = ListarCiudad.ExecuteReader()
            If ListarCiudades.Read = True Then
                If ListarCiudades("Id") Is DBNull.Value Then
                    TxtIdLugar.Text = 1
                Else
                    TxtIdLugar.Text = ListarCiudades("Id").ToString
                End If
            End If
        Catch ex As Exception
        End Try
        TxtLugar.Focus()

    End Sub
    Private Sub Limpiar()
        TxtIdLugar.Clear()
        TxtIdLugar.Clear()
        CboPais.Text = "Seleccione"
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        Call Limpiar()
        Call InvestigarCorrelativo()

    End Sub
End Class