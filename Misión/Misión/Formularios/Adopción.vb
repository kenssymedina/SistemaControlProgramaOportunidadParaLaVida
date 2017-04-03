Imports System.Data
Imports System.Data.SqlClient
Public Class FrmAdopción

    Private Sub FrmAdopcion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarComboboxIdBeneficiado()
        Call LlenarIdSponsor()
        Call LlenarCboEstadoAdopcion()
        Call LlenarCboTipoDePago()
        Call CargarDatos()

    End Sub

    Public Sub LlenarComboboxIdBeneficiado()

        Dim datos = (From p In cnn.Beneficiados
                     Select p.IdBeneficiado, p.NombreBeneficiado).ToList
        Me.CboIdBeneficiado.DataSource = datos

        Me.CboIdBeneficiado.ValueMember = "IdBeneficiado"
        'Me.CboIdBeneficiado.DisplayMember = "IdBeneficiado"
        Me.CboIdBeneficiado.SelectedIndex = -1
        Me.CboIdBeneficiado.Text = "--seleccione--"

    End Sub
    Public Sub LlenarIdSponsor()
        Dim datos = (From a In cnn.Sponsors
                     Select a.IdSponsor, a.NombreCompletoSponsor).ToList
        Me.CboIdSponsor.DataSource = datos


        Me.CboIdSponsor.ValueMember = "IdSponsor"
        'Me.CboIdSponsor.DisplayMember = "IdSponsor"
        Me.CboIdSponsor.SelectedIndex = -1
        Me.CboIdSponsor.Text = "--seleccione--"
    End Sub





    Public Sub LlenarCboTipoDePago()
        Dim datos = (From a In cnn.TipoPagoAdopcions
                     Select a.IdTipoPagoAdopcion, a.TipoPagoAdopcion).ToList
        Me.CboTipoPago.DataSource = datos

        Me.CboTipoPago.ValueMember = "IdTipoPagoAdopcion"
        Me.CboTipoPago.DisplayMember = "TipoPagoAdopcion"
        Me.CboTipoPago.SelectedIndex = -1
        Me.CboTipoPago.Text = "--seleccione--"
    End Sub

    Public Sub LlenarCboEstadoAdopcion()
        Dim datos = (From a In cnn.EstadoAdopcions
                     Select a.IdEstadoAdopcion, a.EstadoAdopcion).ToList
        Me.CboEstado.DataSource = datos

        Me.CboEstado.ValueMember = "IdEstadoAdopcion"
        Me.CboEstado.DisplayMember = "EstadoAdopcion"
        Me.CboEstado.SelectedIndex = -1
        Me.CboEstado.Text = "--seleccione--"
    End Sub

    Public Sub Guardar()
        Dim t As New Adopcion With
            {.IdAdopcion = CInt(TxtIdAdopcion.Text),
            .FechaAdopcion = CDate(DtpFechaAdopcion.Text),
            .Observaciones = TxtObservaciones.Text,
            .FechaAdopcionPerdida = CDate(DtpFechaPerdidaAdopcion.Text),
            .Valor = CDbl(TxtValor.Text),
            .IdBeneficiado = CInt(CboIdBeneficiado.SelectedValue),
            .IdSponsor = CInt(CboIdSponsor.SelectedValue),
            .IdTipoPagoAdopcion = CInt(CboTipoPago.SelectedValue),
            .IdEstadoAdopcion = CInt(CboEstado.SelectedValue)}

        Try
            cnn.Adopcions.InsertOnSubmit(t)
            cnn.SubmitChanges()

            MsgBox("correcto")
            CargarDatos()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Public Sub CargarDatos()


        Dim datos = (From a In cnn.Adopcions
                     Join bene In cnn.Beneficiados On a.IdBeneficiado Equals bene.IdBeneficiado
                     Join spon In cnn.Sponsors On spon.IdSponsor Equals a.IdSponsor
                     Join tp In cnn.TipoPagoAdopcions On tp.IdTipoPagoAdopcion Equals a.IdTipoPagoAdopcion
                     Join ea In cnn.EstadoAdopcions On ea.IdEstadoAdopcion Equals a.IdEstadoAdopcion
                     Select a.IdAdopcion, a.FechaAdopcion, spon.IdSponsor, spon.NombreCompletoSponsor, a.IdBeneficiado, bene.NombreBeneficiado,
                         bene.ApellidoBeneficiado, tp.TipoPagoAdopcion, a.Valor, ea.EstadoAdopcion, a.Observaciones, DtpFechaPerdidaAdopcion
                   ).ToList()
        Me.DgvInformacion.DataSource = datos

    End Sub



    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs)
        Call Guardar()

    End Sub

    Public Sub PasarDatos()
        Dim fila As DataGridViewRow = DgvInformacion.CurrentRow
        Me.TxtIdAdopcion.Text = fila.Cells(0).Value
        Me.DtpFechaAdopcion.Text = fila.Cells(1).Value
        Me.CboIdSponsor.SelectedValue = fila.Cells(2).Value
        Me.CboIdBeneficiado.SelectedValue = (fila.Cells(4).Value)
        Me.CboTipoPago.SelectedValue = fila.Cells(7).Value
        Me.TxtValor.Text = fila.Cells(8).Value
        Me.CboEstado.SelectedValue = fila.Cells(9).Value
        Me.TxtObservaciones.Text = fila.Cells(10).Value
        'Me.DtpFechaPerdidaAdopcion.Text = fila.Cells(11).Value





    End Sub

    Private Sub ActualizarDatos(id As Integer)
        Dim datos As Adopcion = (From a In cnn.Adopcions
                                 Where a.IdAdopcion = id
                                 Select a).ToList()(0)


        datos.FechaAdopcion = CDate(DtpFechaAdopcion.Text)
        datos.Observaciones = TxtObservaciones.Text
        datos.FechaAdopcionPerdida = CDate(DtpFechaAdopcion.Text)
        datos.Valor = TxtValor.Text
        datos.IdBeneficiado = CInt(CboIdBeneficiado.SelectedValue)
        datos.IdSponsor = CInt(CboIdSponsor.SelectedValue)
        datos.IdTipoPagoAdopcion = CInt(CboTipoPago.SelectedValue)
        datos.IdEstadoAdopcion = CInt(CboEstado.SelectedValue)

        Try
            cnn.SubmitChanges()
            MsgBox("correcto")
            Call CargarDatos()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub



    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call PasarDatos()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Call Guardar()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        FrmTransaccionales.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Call ActualizarDatos(CInt(TxtIdAdopcion.Text))
    End Sub

    Private Sub DgvInformacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvInformacion.CellContentClick

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
End Class