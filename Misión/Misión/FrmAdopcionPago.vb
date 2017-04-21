
Imports System.Data.SqlClient
Imports System.Data
Public Class FrmAdopcionPago
    Implements IForm, IForm2

    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        TxtIdAdopcion.Text = id
    End Sub

    Public Sub ObtenerIdSegundo(id As String) Implements IForm2.ObtenerIdSegundo
        TxtIdPago.Text = id
    End Sub


    Private Sub TxtIdAdopcion_TextChanged(sender As Object, e As EventArgs) Handles TxtIdAdopcion.TextChanged
        If TxtIdAdopcion.Text <> "" Then
            accesodatos.CargarDatosAdopcionParaPago(TxtIdAdopcion.Text, TxtNumeroBeneficiado, TxtNombreBeneficiado,
                                                   TxtNumeroSponsor, TxtNombreSponsor)
        End If
    End Sub
    Private Sub TxtIdPago_TextChanged(sender As Object, e As EventArgs) Handles TxtIdPago.TextChanged
        If TxtIdPago.Text <> "" Then
            accesodatos.CargarDatosAdopcionPago(TxtIdPago.Text, TxtIdAdopcion, TxtNumeroBeneficiado, TxtNombreBeneficiado,
                                                   TxtNumeroSponsor, TxtNombreSponsor, DtpFechaPago, TxtValor)
        End If
    End Sub

    Private Sub BtnBuscarAdopPago_Click(sender As Object, e As EventArgs) Handles BtnBuscarAdopPago.Click
        'aqui muestra el formulario de busqueda
        Dim frm As New FrmBusquedaAdopcionPago()
        frm.Show(Me)
    End Sub

    Private Sub BtnBuscarAdopcion_Click(sender As Object, e As EventArgs) Handles BtnBuscarAdopcion.Click
        'aqui muestra el formulario de busqueda
        Dim frm As New FrmBusquedaAdopcionCatalago()
        frm.Show(Me)
    End Sub
    Private Function Validar() As Boolean
        Dim Estado As Boolean
        If TxtIdAdopcion.Text = Nothing And TxtIdPago.Text = Nothing And TxtValor.Text = Nothing Then
            MessageBox.Show("Ingrese los datos solicitados")
            TxtIdPago.Focus()
            Estado = False
        ElseIf TxtIdPago.Text = Nothing Then
            MessageBox.Show("Seleccione el Id de la Adopcion Pago")
            TxtNumeroBeneficiado.Focus()
            Estado = False
        ElseIf TxtValor.Text = Nothing Then
            MessageBox.Show("Ingrese el Valor de la Adopcion")
            TxtValor.Focus()
            Estado = False
        ElseIf TxtIdAdopcion.Text = Nothing Then
            MessageBox.Show("Seleccione el Id  de la Adopcion")
            TxtIdAdopcion.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado

    End Function
    Public Sub Guardar()

        If Validar() = True Then
            Dim sp As New AdopcionPago With
        {
            .FechaPago = DtpFechaPago.Text,
            .Valor = TxtValor.Text,
            .Idadopcion = TxtIdAdopcion.Text
         }

            Try
                cnn.AdopcionPagos.InsertOnSubmit(sp)
                cnn.SubmitChanges()
                MsgBox("Datos ingresados correctamente", MsgBoxStyle.Information, "Aviso")
            Catch ex As Exception
                MsgBox("Error al guardar los datos", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Call Guardar()
        Call LimpiarAdopcion()
        Call InvestigarCorrelativo()
    End Sub
    Public Sub ActualizarDatos(id As Integer)

        Dim datos As AdopcionPago = (From g In cnn.AdopcionPagos
                                     Where g.IdAdopcionPago = id
                                     Select g).ToList()(0)
        datos.FechaPago = DtpFechaPago.Text
        datos.Valor = TxtValor.Text
        datos.Idadopcion = TxtIdAdopcion.Text

        Try
            cnn.SubmitChanges()
            MsgBox("Datos Actualizados correctamente", MsgBoxStyle.Information, "Aviso")

        Catch ex As Exception
            MsgBox("Eror al Actualizar los Datos")
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Call ActualizarDatos(CInt(TxtIdPago.Text))
    End Sub
    Private Sub Limpiar()
        TxtIdAdopcion.Clear()
        TxtNumeroBeneficiado.Clear()
        TxtNombreBeneficiado.Clear()
        TxtNumeroSponsor.Clear()
        TxtNombreSponsor.Clear()
        TxtValor.Text = "0"
        Me.DtpFechaPago.Text = Now.ToLongDateString
    End Sub
    Sub InvestigarCorrelativo()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            Dim ListarHermano As New SqlCommand("Sp_IdentityAdopcionPago", cn)
            ListarHermano.CommandType = CommandType.StoredProcedure
            Dim ListarHermanos As SqlDataReader
            cn.Open()
            ListarHermanos = ListarHermano.ExecuteReader()
            If ListarHermanos.Read = True Then
                If ListarHermanos("Id") Is DBNull.Value Then
                    TxtIdPago.Text = 1
                Else
                    TxtIdPago.Text = ListarHermanos("Id").ToString
                End If
            End If
        Catch ex As Exception
        End Try
        TxtIdAdopcion.Focus()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Call Limpiar()
        Call InvestigarCorrelativo()
    End Sub
    Private Sub LimpiarAdopcion()
        TxtIdPago.Clear()
        TxtIdAdopcion.Clear()
        TxtNumeroBeneficiado.Clear()
        TxtNombreBeneficiado.Clear()
        TxtNumeroSponsor.Clear()
        TxtNombreSponsor.Clear()
        TxtValor.Text = "0"
        Me.DtpFechaPago.Text = Now.ToLongDateString
    End Sub
End Class