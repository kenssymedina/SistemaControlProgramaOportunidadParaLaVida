Imports System.Data
Imports System.Data.SqlClient

Public Class FrmAdopción
    Implements IForm, IForm2, IForm3

    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        TxtNumeroBeneficiado.Text = id
    End Sub

    Public Sub ObtenerIdSegundo(id As String) Implements IForm2.ObtenerIdSegundo
        TxtNumeroSponsor.Text = id
    End Sub

    Public Sub ObtenerIdTercero(id As String) Implements IForm3.ObtenerIdTercero
        TxtIdAdopcion.Text = id
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Call Guardar()
        Call Limpiar()
    End Sub

    Public Sub ActualizarDatos(id As Integer)

        Dim datos As Adopcion = (From g In cnn.Adopcions
                                 Where g.IdAdopcion = id
                                 Select g).ToList()(0)
        datos.FechaAdopcion = DTpFechaAdopcion.Text
        datos.Valor = TxtValor.Text
        datos.FechaAdopcion = CDate(DTpFechaAdopcion.Value)
        datos.Observacion = TxtObservacion.Text
        datos.IdEstadoAdopcion = CInt(CboEstadoAdopcion.SelectedValue)
        datos.IdTipoPagoAdopcion = CInt(CboTipoPago.SelectedValue)

        Try
            cnn.SubmitChanges()
            MsgBox("Datos Actualizados correctamente", MsgBoxStyle.Information, "Aviso")

        Catch ex As Exception
            MsgBox("Eror al Actualizar los Datos")
        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        FrmTransaccionales.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Call ActualizarDatos(CInt(TxtIdAdopcion.Text))
    End Sub

    Private Sub Limpiar()
        TxtIdAdopcion.Clear()
        TxtNumeroBeneficiado.Clear()
        TxtNombreBeneficiado.Clear()
        TxtNumeroSponsor.Clear()
        TxtNombreSponsor.Clear()
        TxtObservacion.Clear()
        TxtValor.Text = "0"
        Me.DTpFechaAdopcion.Text = Now.ToLongDateString
        CboEstadoAdopcion.Text = "Seleccione"
        CboTipoPago.Text = "Seleccione"
    End Sub

    Sub InvestigarCorrelativo()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            Dim ListarHermano As New SqlCommand("Sp_IdentityAdopcion", cn)
            ListarHermano.CommandType = CommandType.StoredProcedure
            Dim ListarHermanos As SqlDataReader
            cn.Open()
            ListarHermanos = ListarHermano.ExecuteReader()
            If ListarHermanos.Read = True Then
                If ListarHermanos("Id") Is DBNull.Value Then
                    TxtIdAdopcion.Text = 1
                Else
                    TxtIdAdopcion.Text = ListarHermanos("Id").ToString
                End If
            End If
        Catch ex As Exception
        End Try
        TxtNumeroBeneficiado.Focus()

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

    Private Sub PictureBox4_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox4.MouseMove
        PictureBox4.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Size = New Size(49, 51)
    End Sub


    Private Sub TxtNumeroBeneficiado_TextChanged(sender As Object, e As EventArgs) Handles TxtNumeroBeneficiado.TextChanged
        If TxtNumeroBeneficiado.Text <> "" Then
            accesodatos.CargarDatosBeneficidoAdopcion(TxtNumeroBeneficiado.Text, TxtNombreBeneficiado)
        End If
    End Sub

    Private Sub TxtNumeroSponsor_TextChanged(sender As Object, e As EventArgs) Handles TxtNumeroSponsor.TextChanged
        If TxtNumeroSponsor.Text <> "" Then
            accesodatos.CargarDatosSponsorAdopncion(TxtNumeroSponsor.Text, TxtNombreSponsor)
        End If
    End Sub

    Private Sub TxtIdAdopcion_TextChanged(sender As Object, e As EventArgs) Handles TxtIdAdopcion.TextChanged
        If TxtIdAdopcion.Text <> "" Then
            accesodatos.CargarDatosAdopcion(TxtIdAdopcion.Text, TxtObservacion, DTpFechaAdopcion, TxtValor, TxtNumeroBeneficiado,
                                            TxtNombreBeneficiado, TxtNumeroSponsor, TxtNombreSponsor, CboEstadoAdopcion, CboTipoPago)
        End If

    End Sub

    Public Sub LlenarTipoPago()

        Dim datos = (From G In cnn.TipoPagoAdopcions
                     Order By G.IdTipoPagoAdopcion Ascending
                     Select G.IdTipoPagoAdopcion, G.TipoPagoAdopcion).ToList
        Me.CboTipoPago.DataSource = datos
        Me.CboTipoPago.ValueMember = "IdTipoPagoAdopcion"
        Me.CboTipoPago.DisplayMember = "TipoPagoAdopcion"
        Me.CboTipoPago.SelectedIndex = -1
        Me.CboTipoPago.Text = "Seleccione"

    End Sub

    Public Sub LlenarEstadoAdopcion()

        Dim datos = (From G In cnn.EstadoAdopcions
                     Order By G.IdEstadoAdopcion Ascending
                     Select G.IdEstadoAdopcion, G.EstadoAdopcion).ToList
        Me.CboEstadoAdopcion.DataSource = datos
        Me.CboEstadoAdopcion.ValueMember = "IdEstadoAdopcion"
        Me.CboEstadoAdopcion.DisplayMember = "EstadoAdopcion"
        Me.CboEstadoAdopcion.SelectedIndex = -1
        Me.CboEstadoAdopcion.Text = "Seleccione"

    End Sub

    Private Sub FrmAdopción_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call LlenarTipoPago()
        Call LlenarEstadoAdopcion()
    End Sub

    Private Sub BtnBuscarAdopcion_Click(sender As Object, e As EventArgs) Handles BtnBuscarAdopcion.Click
        'aqui muestra el formulario de busqueda
        Dim frm As New FrmBusquedaAdopcio()
        frm.Show(Me)
    End Sub

    Private Sub BtnBuscarSponsor_Click(sender As Object, e As EventArgs) Handles BtnBuscarSponsor.Click
        'aqui muestra el formulario de busqueda
        Dim frm As New FrmBusquedaSponsorAdopcionvb()
        frm.Show(Me)
    End Sub

    Private Sub BtnBeneficiado_Click(sender As Object, e As EventArgs) Handles BtnBeneficiado.Click
        'aqui muestra el formulario de busqueda
        Dim frm As New FrmBusquedaBeneficiadoAdopcion()
        frm.Show(Me)

    End Sub
    Private Function Validar() As Boolean
        Dim Estado As Boolean
        If TxtIdAdopcion.Text = Nothing And TxtObservacion.Text = Nothing And TxtValor.Text = Nothing And TxtNumeroBeneficiado.Text = Nothing And
              TxtNumeroSponsor.Text = Nothing And CboEstadoAdopcion.SelectedIndex = -1 And CboTipoPago.SelectedIndex = -1 Then
            MessageBox.Show("Ingrese los datos solicitados")
            TxtIdAdopcion.Focus()
            Estado = False
        ElseIf TxtNumeroBeneficiado.Text = Nothing Then
            MessageBox.Show("Seleccione el Beneficiado")
            TxtNumeroBeneficiado.Focus()
            Estado = False
        ElseIf TxtNumeroSponsor.Text = Nothing Then
            MessageBox.Show("Seleccione el Sponsor")
            TxtNumeroSponsor.Focus()
            Estado = False
        ElseIf TxtValor.Text = Nothing Then
            MessageBox.Show("Ingrese el Valor de la Adopcion")
            TxtValor.Focus()
            Estado = False
        ElseIf TxtObservacion.Text = Nothing Then
            MessageBox.Show("Ingrese la Observacion  de la Adopcion")
            TxtObservacion.Focus()
            Estado = False
        ElseIf CboEstadoAdopcion.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el Estado de la Adopcion")
            CboEstadoAdopcion.Focus()
            Estado = False
        ElseIf CboTipoPago.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el Tipo de Pago de la Adopcion")
            CboTipoPago.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado

    End Function
    Public Sub Guardar()

        If Validar() = True Then
            Dim sp As New Adopcion With
        {
            .FechaAdopcion = DTpFechaAdopcion.Text,
            .Observacion = TxtObservacion.Text,
            .Valor = TxtValor.Text,
            .IdBeneficiado = TxtNumeroBeneficiado.Text,
            .IdSponsor = TxtNumeroSponsor.Text,
            .IdTipoPagoAdopcion = CInt(Me.CboTipoPago.SelectedValue),
            .IdEstadoAdopcion = CInt(Me.CboEstadoAdopcion.SelectedValue),
            .IdUsuario = IdUsuarioSistemaActual
         }

            Try
                cnn.Adopcions.InsertOnSubmit(sp)
                cnn.SubmitChanges()
                MsgBox("Datos ingresados correctamente", MsgBoxStyle.Information, "Aviso")
            Catch ex As Exception
                MsgBox("Error al guardar los datos", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End Try
        End If

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Call Limpiar()
        Call InvestigarCorrelativo()

    End Sub

    Private Sub TxtValor_TextChanged(sender As Object, e As EventArgs) Handles TxtValor.TextChanged
        Me.TxtValor.Text = FormatCurrency(Me.TxtValor.Text, 2)
    End Sub
End Class
