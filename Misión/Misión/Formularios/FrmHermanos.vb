
Imports System.Data.SqlClient
Imports System.Data



Public Class FrmHermanos

    Implements IForm, IForm2

    Dim acumulador As Integer
    Public esBuscar As Boolean = False
    Public Nuevo As Boolean = True

    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        TxtNumeroBeneficiado.Text = id
    End Sub

    Public Sub ObtenerHermano(id As String) Implements IForm2.ObtenerIdSegundo
        txtIdHermano.Text = id
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Close()
    End Sub

    Private Sub PictureBox6_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox6.MouseMove
        PictureBox6.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox5_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseMove
        PictureBox5.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        PictureBox2.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        PictureBox2.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        PictureBox1.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox4_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseMove
        PictureBox4.Size = New Size(58, 59)
    End Sub



    Private Sub FrmHermanos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarGradoCursado()
        Call LlenarSexo()

    End Sub

    Private Sub txtIdHermano_TextChanged(sender As Object, e As EventArgs) Handles txtIdHermano.TextChanged
        If esBuscar = True Then
            If txtIdHermano.Text <> "" Then
                accesodatos.CargarDatosHermano(txtIdHermano.Text, TxtNombreHermano, TxtApellidoHermano,
                                               DTpFechaNacimiento, ChkTieneSponsor, TxtNumeroBeneficiado, TxtNombreBeneficiado,
                                               CboGradoCursado, CboSexo)

            End If
        End If
    End Sub

    Private Sub TxtNumeroBeneficiado_TextChanged(sender As Object, e As EventArgs) Handles TxtNumeroBeneficiado.TextChanged
        If TxtNumeroBeneficiado.Text <> "" Then
            accesodatos.CargarDatosBeneficidoHermano(TxtNumeroBeneficiado.Text, TxtNombreBeneficiado)
        End If
    End Sub
    Public Sub LlenarGradoCursado()

        Dim datos = (From G In cnn.GradoCursados
                     Order By G.IdGradoCursado Ascending
                     Select G.IdGradoCursado, G.GradoCursado).ToList
        Me.CboGradoCursado.DataSource = datos
        Me.CboGradoCursado.ValueMember = "IdGradoCursado"
        Me.CboGradoCursado.DisplayMember = "GradoCursado"
        Me.CboGradoCursado.SelectedIndex = -1
        Me.CboGradoCursado.Text = "Seleccione"

    End Sub
    Public Sub LlenarSexo()
        Dim datos = (From a In cnn.Sexos
                     Order By a.IdSexo Ascending
                     Select a.IdSexo, a.Sexo).ToList
        Me.CboSexo.DataSource = datos
        Me.CboSexo.ValueMember = "IdSexo"
        Me.CboSexo.DisplayMember = "Sexo"
        Me.CboSexo.SelectedIndex = -1
        Me.CboSexo.Text = "Seleccione"
    End Sub

    Private Sub BtnBusqueHer_Click(sender As Object, e As EventArgs) Handles BtnBusqueHer.Click
        'aqui muestra el formulario de busqueda
        Dim frm As New FrmBusquedaHermanovb()
        frm.Show(Me)
    End Sub

    Private Sub BtnData_Click(sender As Object, e As EventArgs) Handles BtnData.Click
        'aqui muestra el formulario de busqueda
        Dim frm As New FrmBuscarBeneficiadoIntereses()
        frm.Show(Me)
    End Sub
    Public Sub Guardar()
        For I As Integer = 0 To ListView1.Items.Count - 1

            Dim sp As New Hermano With
            {
                .NombreHermano = ListView1.Items(I).SubItems(1).Text,
                .ApellidoHermano = ListView1.Items(I).SubItems(2).Text,
                .FechaNac = ListView1.Items(I).SubItems(3).Text,
                .SponsorHermano = ListView1.Items(I).SubItems(4).Text,
                .IdGradoCursado = ListView1.Items(I).SubItems(5).Text,
                .IdSexo = ListView1.Items(I).SubItems(7).Text
             }
            Try
                cnn.Hermanos.InsertOnSubmit(sp)
                cnn.SubmitChanges()

                Dim Bh As New BeneficiadoHermano With
                    {
                        .IdHermano = ListView1.Items(I).SubItems(0).Text,
                        .IdBeneficiado = TxtNumeroBeneficiado.Text
                    }
                Try
                    cnn.BeneficiadoHermanos.InsertOnSubmit(Bh)
                    cnn.SubmitChanges()
                    MsgBox("Datos ingresados correctamente", MsgBoxStyle.Information, "Aviso")
                Catch ex As Exception
                    MsgBox("Error al guardar los datos", MsgBoxStyle.Information, "Aviso")
                    Exit Sub
                End Try
            Catch ex As Exception

            End Try

        Next
    End Sub

    Private Function Validar() As Boolean
        Dim Estado As Boolean
        If TxtNumeroBeneficiado.Text = Nothing And TxtNombreHermano.Text = Nothing And TxtApellidoHermano.Text = Nothing And
            CboGradoCursado.SelectedIndex = -1 And CboSexo.SelectedIndex = -1 Then
            MessageBox.Show("Ingrese los datos solicitados")
            TxtNombreHermano.Focus()
            Estado = False
        ElseIf TxtNombreHermano.Text = Nothing Then
            MessageBox.Show("Ingrese el Nombre del Hermano(a)")
            TxtNombreHermano.Focus()
            Estado = False
        ElseIf TxtApellidoHermano.Text = Nothing Then
            MessageBox.Show("Ingrese el Apellido del Hermano(a)")
            TxtApellidoHermano.Focus()
            Estado = False
        ElseIf TxtNumeroBeneficiado.Text = Nothing Then
            MessageBox.Show("Ingrese el Numero del  Beneficiado")
            TxtNumeroBeneficiado.Focus()
            Estado = False
        ElseIf CboGradoCursado.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el Grado  Cursado")
            CboGradoCursado.Focus()
            Estado = False
        ElseIf CboSexo.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el Sexo")
            CboSexo.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado

    End Function
    Public Sub ActualizarDatos(id As Integer)

        Dim datos As Hermano = (From g In cnn.Hermanos
                                Where g.IdHermano = id
                                Select g).ToList()(0)
        datos.NombreHermano = TxtNombreHermano.Text
        datos.ApellidoHermano = TxtApellidoHermano.Text
        datos.FechaNac = CDate(DTpFechaNacimiento.Value)
        datos.SponsorHermano = ChkTieneSponsor.CheckState
        datos.IdGradoCursado = CInt(CboGradoCursado.SelectedValue)
        datos.IdSexo = CInt(CboSexo.SelectedValue)

        Try
            cnn.SubmitChanges()
            MsgBox("Datos Actualizados correctamente", MsgBoxStyle.Information, "Aviso")

        Catch ex As Exception
            MsgBox("Eror al Actualizar los Datos")
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Call Guardar()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Call ActualizarDatos(CInt(txtIdHermano.Text))
    End Sub
    Private Sub Limpiar()

        TxtNombreHermano.Clear()
        TxtApellidoHermano.Clear()
        CboGradoCursado.SelectedIndex = -1
        CboSexo.SelectedIndex = -1
        Me.DTpFechaNacimiento.Text = Now.ToLongDateString


    End Sub
    Sub InvestigarCorrelativo()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            Dim ListarHermano As New SqlCommand("Sp_IdentityHermano", cn)
            ListarHermano.CommandType = CommandType.StoredProcedure
            Dim ListarHermanos As SqlDataReader
            cn.Open()
            ListarHermanos = ListarHermano.ExecuteReader()
            If ListarHermanos.Read = True Then
                If ListarHermanos("Id") Is DBNull.Value Then
                    txtIdHermano.Text = 1
                Else
                    txtIdHermano.Text = ListarHermanos("Id").ToString
                End If
            End If
        Catch ex As Exception
        End Try
        TxtNombreHermano.Focus()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Call Limpiar()
        Call InvestigarCorrelativo()
        acumulador = (Me.txtIdHermano.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Validar() = True Then

            If Nuevo Then
                With ListView1.Items.Add(acumulador)
                    .SubItems.Add(TxtNombreHermano.Text)
                    .SubItems.Add(TxtApellidoHermano.Text)
                    .SubItems.Add(DTpFechaNacimiento.Text)
                    .SubItems.Add(ChkTieneSponsor.Checked)
                    .SubItems.Add(CboGradoCursado.SelectedValue)
                    .SubItems.Add(CboGradoCursado.Text)
                    .SubItems.Add(CboSexo.SelectedValue)
                    .SubItems.Add(CboSexo.Text)
                End With
                acumulador += 1

            Else
                With ListView1.Items.Add(Me.txtIdHermano.Text)
                    .SubItems.Add(TxtNombreHermano.Text)
                    .SubItems.Add(TxtApellidoHermano.Text)
                    .SubItems.Add(DTpFechaNacimiento.Text)
                    .SubItems.Add(ChkTieneSponsor.Checked)
                    .SubItems.Add(CboGradoCursado.SelectedValue)
                    .SubItems.Add(CboGradoCursado.Text)
                    .SubItems.Add(CboSexo.SelectedValue)
                    .SubItems.Add(CboSexo.Text)

                End With
                Nuevo = True
                Me.txtIdHermano.Text = acumulador
                Me.ListView1.Enabled = True
            End If
            Me.txtIdHermano.Text = acumulador
        End If

        Call Limpiar()
    End Sub
    Private Sub LimpiarHermano()
        TxtNumeroBeneficiado.Clear()
        TxtNombreBeneficiado.Clear()
        txtIdHermano.Clear()
        TxtNombreHermano.Clear()
        TxtApellidoHermano.Clear()
        CboGradoCursado.Text = "Seleccione"
        CboSexo.Text = "Seleccione"
        Me.DTpFechaNacimiento.Text = Now.ToLongDateString


    End Sub



    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Nuevo = False

        txtIdHermano.Text = ListView1.FocusedItem.SubItems(0).Text
        TxtNombreHermano.Text = ListView1.FocusedItem.SubItems(1).Text
        TxtApellidoHermano.Text = ListView1.FocusedItem.SubItems(2).Text
        DTpFechaNacimiento.Text = ListView1.FocusedItem.SubItems(3).Text
        ChkTieneSponsor.Checked = ListView1.FocusedItem.SubItems(4).Text
        CboGradoCursado.SelectedValue = ListView1.FocusedItem.SubItems(5).Text
        CboGradoCursado.Text = ListView1.FocusedItem.SubItems(6).Text
        CboSexo.SelectedValue = ListView1.FocusedItem.SubItems(7).Text
        CboSexo.Text = ListView1.FocusedItem.SubItems(8).Text
        Me.ListView1.FocusedItem.Remove()
        Me.ListView1.Enabled = False

    End Sub
End Class