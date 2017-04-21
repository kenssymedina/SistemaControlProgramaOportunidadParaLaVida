Imports System.Data.SqlClient
Imports System.Data
Public Class FrmOfrendavb


    Implements IForm, IForm2

    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        TxtIdOfrenda.Text = id
    End Sub

    Public Sub ObtenerIdSegundo(id As String) Implements IForm2.ObtenerIdSegundo
        TxtIdAdopcion.Text = id
    End Sub

    Private Sub TxtIdAdopcion_TextChanged(sender As Object, e As EventArgs) Handles TxtIdAdopcion.TextChanged
        If TxtIdAdopcion.Text <> "" Then
            accesodatos.CargarDatosAdopcionCartas(TxtIdAdopcion.Text, TxtNumeroBeneficiado, TxtNombreBeneficiado,
                                                   TxtNumeroSponsor, TxtNombreSponsor)
        End If
    End Sub

    Private Sub TxtIdOfrenda_TextChanged(sender As Object, e As EventArgs) Handles TxtIdOfrenda.TextChanged
        If TxtIdOfrenda.Text <> "" Then
            accesodatos.CargarDatosOfrenda(TxtIdOfrenda.Text, TxtDescripcion, DTpFechaRecibida, DtpFechaEntregada, TxtIdAdopcion, TxtNumeroBeneficiado, TxtNombreBeneficiado,
                                                   TxtNumeroSponsor, TxtNombreSponsor, CboTipoOfrenda)
        End If
    End Sub
    Public Sub LlenarTipoOfrenda()

        Dim datos = (From G In cnn.TipoOfrendas
                     Order By G.IdTipoOfrenda Ascending
                     Select G.IdTipoOfrenda, G.TipoOfrenda).ToList
        Me.CboTipoOfrenda.DataSource = datos
        Me.CboTipoOfrenda.ValueMember = "IdTipoOfrenda"
        Me.CboTipoOfrenda.DisplayMember = "TipoOfrenda"
        Me.CboTipoOfrenda.SelectedIndex = -1
        Me.CboTipoOfrenda.Text = "Seleccione"

    End Sub

    Private Sub FrmOfrendavb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarTipoOfrenda()
    End Sub

    Private Sub BtnBuscarOfrenda_Click(sender As Object, e As EventArgs) Handles BtnBuscarOfrenda.Click
        'aqui muestra el formulario de busqueda
        Dim frm As New FrmBusquedaOfrenda()
        frm.Show(Me)
    End Sub

    Private Sub BtnBuscarAdopcion_Click(sender As Object, e As EventArgs) Handles BtnBuscarAdopcion.Click
        'aqui muestra el formulario de busqueda
        Dim frm As New FrmBusquedaAdopcionCatalago()
        frm.Show(Me)
    End Sub
    Private Function Validar() As Boolean
        Dim Estado As Boolean
        If TxtIdOfrenda.Text = Nothing And TxtIdAdopcion.Text = Nothing And TxtDescripcion.Text = Nothing And
            CboTipoOfrenda.SelectedIndex = -1 Then
            MessageBox.Show("Ingrese los datos solicitados")
            TxtIdOfrenda.Focus()
            Estado = False
        ElseIf TxtDescripcion.Text = Nothing Then
            MessageBox.Show("Descriva que Contiene la Ofrenda")
            TxtDescripcion.Focus()
            Estado = False
        ElseIf TxtIdAdopcion.Text = Nothing Then
            MessageBox.Show("Seleccione el Numero de Adopcion")
            TxtDescripcion.Focus()
            Estado = False
        ElseIf CboTipoOfrenda.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el Tipo de Pago de la Adopcion")
            CboTipoOfrenda.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado

    End Function

    Public Sub Guardar()

        If Validar() = True Then
            Dim sp As New Ofrenda With
        {
            .fechaEntregado = DtpFechaEntregada.Text,
            .FechaRecibida = DTpFechaRecibida.Text,
            .DescripcionOfrenda = TxtDescripcion.Text,
            .IdAdopcion = TxtIdAdopcion.Text,
            .IdTipoOfrenda = CInt(Me.CboTipoOfrenda.SelectedValue),
            .IdUsuario = 1
         }

            Try
                cnn.Ofrendas.InsertOnSubmit(sp)
                cnn.SubmitChanges()
                MsgBox("Datos ingresados correctamente", MsgBoxStyle.Information, "Aviso")
            Catch ex As Exception
                MsgBox("Error al guardar los datos", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End Try
        End If
    End Sub


    Public Sub ActualizarDatos(id As Integer)

        Dim datos As Ofrenda = (From g In cnn.Ofrendas
                                Where g.IdOfrenda = id
                                Select g).ToList()(0)
        datos.FechaRecibida = DTpFechaRecibida.Text
        datos.fechaEntregado = DtpFechaEntregada.Text
        datos.DescripcionOfrenda = TxtDescripcion.Text
        datos.IdAdopcion = TxtIdAdopcion.Text
        datos.IdTipoOfrenda = CInt(CboTipoOfrenda.SelectedValue)

        Try
            cnn.SubmitChanges()
            MsgBox("Datos Actualizados correctamente", MsgBoxStyle.Information, "Aviso")

        Catch ex As Exception
            MsgBox("Eror al Actualizar los Datos")
        End Try
    End Sub


    Private Sub Limpiar()
        TxtIdOfrenda.Clear()
        TxtNumeroBeneficiado.Clear()
        TxtNombreBeneficiado.Clear()
        TxtNumeroSponsor.Clear()
        TxtNombreSponsor.Clear()
        TxtIdAdopcion.Clear()
        TxtDescripcion.Clear()
        Me.DtpFechaEntregada.Text = Now.ToLongDateString
        Me.DTpFechaRecibida.Text = Now.ToLongDateString
        CboTipoOfrenda.Text = "Seleccione"
    End Sub
    Sub InvestigarCorrelativo()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            Dim ListarHermano As New SqlCommand("Sp_IdentityOfrenda", cn)
            ListarHermano.CommandType = CommandType.StoredProcedure
            Dim ListarHermanos As SqlDataReader
            cn.Open()
            ListarHermanos = ListarHermano.ExecuteReader()
            If ListarHermanos.Read = True Then
                If ListarHermanos("Id") Is DBNull.Value Then
                    TxtIdOfrenda.Text = 1
                Else
                    TxtIdOfrenda.Text = ListarHermanos("Id").ToString
                End If
            End If
        Catch ex As Exception
        End Try
        TxtIdAdopcion.Focus()

    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Call Guardar()
        Call Limpiar()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Call Limpiar()
        Call InvestigarCorrelativo()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        Call ActualizarDatos(CInt(TxtIdOfrenda.Text))
    End Sub
End Class