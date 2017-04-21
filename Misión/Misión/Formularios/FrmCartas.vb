Imports System.Data.SqlClient
Imports System.Data

Public Class FrmCartas
    Implements IForm, IForm2

    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        TxtIdCarta.Text = id
    End Sub

    Public Sub ObtenerIdSegundo(id As String) Implements IForm2.ObtenerIdSegundo
        TxtIdCarta.Text = id
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

    Private Sub FrmCartas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarRemitente()
        Call LlenarTipoCarta()
        Call LlenarDestinatario()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub TxtIdAdopcion_TextChanged(sender As Object, e As EventArgs) Handles TxtIdAdopcion.TextChanged
        If TxtIdAdopcion.Text <> "" Then
            accesodatos.CargarDatosAdopcionOfrenda(TxtIdAdopcion.Text, TxtNumeroBeneficiado, TxtNombreBeneficiado,
                                                   TxtNumeroSponsor, TxtNombreSponsor)
        End If
    End Sub

    Private Sub TxtIdCarta_TextChanged(sender As Object, e As EventArgs) Handles TxtIdCarta.TextChanged
        If TxtIdCarta.Text <> "" Then
            accesodatos.CargarDatosCartas(TxtIdCarta.Text, TxtIdAdopcion, TxtNumeroBeneficiado, TxtNombreBeneficiado,
                                                   TxtNumeroSponsor, TxtNombreSponsor, DtpFechaEntregada, TxtDescripcion, CboRemitente,
                                          CboDestinatario, CboTipoCarta)
        End If
    End Sub
    Public Sub LlenarTipoCarta()

        Dim datos = (From G In cnn.TipoCartas
                     Order By G.IdTipoCarta Ascending
                     Select G.IdTipoCarta, G.TipoCarta).ToList
        Me.CboTipoCarta.DataSource = datos
        Me.CboTipoCarta.ValueMember = "IdTipoCarta"
        Me.CboTipoCarta.DisplayMember = "TipoCarta"
        Me.CboTipoCarta.SelectedIndex = -1
        Me.CboTipoCarta.Text = "Seleccione"

    End Sub
    Public Sub LlenarRemitente()

        Dim datos = (From G In cnn.RemitenteDestinatarios
                     Order By G.IdRemitenteDestinatario
                     Select G.IdRemitenteDestinatario, G.RemitenteDestinatario).ToList
        Me.CboRemitente.DataSource = datos
        Me.CboRemitente.ValueMember = "IdRemitenteDestinatario"
        Me.CboRemitente.DisplayMember = "RemitenteDestinatario"
        Me.CboRemitente.SelectedIndex = -1
        Me.CboRemitente.Text = "Seleccione"

    End Sub
    Public Sub LlenarDestinatario()

        Dim datos = (From G In cnn.RemitenteDestinatarios
                     Order By G.IdRemitenteDestinatario
                     Select G.IdRemitenteDestinatario, G.RemitenteDestinatario).ToList
        Me.CboDestinatario.DataSource = datos
        Me.CboDestinatario.ValueMember = "IdRemitenteDestinatario"
        Me.CboDestinatario.DisplayMember = "RemitenteDestinatario"
        Me.CboDestinatario.SelectedIndex = -1
        Me.CboDestinatario.Text = "Seleccione"

    End Sub
    Private Function Validar() As Boolean
        Dim Estado As Boolean
        If TxtIdCarta.Text = Nothing And TxtIdAdopcion.Text = Nothing And TxtDescripcion.Text = Nothing And
            CboTipoCarta.SelectedIndex = -1 And CboDestinatario.SelectedIndex = -1 And CboRemitente.SelectedIndex = -1 Then
            MessageBox.Show("Ingrese los datos solicitados")
            TxtIdCarta.Focus()
            Estado = False
        ElseIf TxtDescripcion.Text = Nothing Then
            MessageBox.Show("Descriva que Contiene la Carta")
            TxtDescripcion.Focus()
            Estado = False
        ElseIf TxtIdAdopcion.Text = Nothing Then
            MessageBox.Show("Seleccione el Numero de Adopcion")
            TxtDescripcion.Focus()
            Estado = False
        ElseIf CboTipoCarta.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el Tipo de Carta")
            CboTipoCarta.Focus()
            Estado = False
        ElseIf CboRemitente.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el Remitente")
            CboRemitente.Focus()
            Estado = False
        ElseIf CboDestinatario.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el Destinatario")
            CboDestinatario.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado

    End Function
    Public Sub Guardar()

        If Validar() = True Then
            Dim sp As New Carta With
        {
            .FechaEntrega = DtpFechaEntregada.Text,
            .Descripcion = TxtDescripcion.Text,
            .IdAdopcion = TxtIdAdopcion.Text,
            .IdTipoCarta = CInt(Me.CboTipoCarta.SelectedValue),
            .Remitente = CInt(Me.CboRemitente.SelectedValue),
            .Destinatario = CInt(Me.CboDestinatario.SelectedValue),
            .IdUsuario = 1
         }

            Try
                cnn.Cartas.InsertOnSubmit(sp)
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
        Call Limpiar()
    End Sub
    Public Sub ActualizarDatos(id As Integer)

        Dim datos As Carta = (From g In cnn.Cartas
                              Where g.IdCarta = id
                              Select g).ToList()(0)
        datos.FechaEntrega = DtpFechaEntregada.Text
        datos.Descripcion = TxtDescripcion.Text
        datos.IdAdopcion = TxtIdAdopcion.Text
        datos.IdTipoCarta = CInt(CboTipoCarta.SelectedValue)
        datos.Remitente = CInt(CboRemitente.SelectedValue)
        datos.Destinatario = CInt(CboDestinatario.SelectedValue)

        Try
            cnn.SubmitChanges()
            MsgBox("Datos Actualizados correctamente", MsgBoxStyle.Information, "Aviso")

        Catch ex As Exception
            MsgBox("Eror al Actualizar los Datos")
        End Try
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Call ActualizarDatos(CInt(TxtIdCarta.Text))
    End Sub
    Private Sub Limpiar()
        TxtIdAdopcion.Clear()
        TxtIdCarta.Clear()
        TxtNumeroBeneficiado.Clear()
        TxtNombreBeneficiado.Clear()
        TxtNumeroSponsor.Clear()
        TxtNombreSponsor.Clear()
        TxtDescripcion.Clear()
        Me.DtpFechaEntregada.Text = Now.ToLongDateString
        CboTipoCarta.SelectedIndex = -1
        CboDestinatario.SelectedIndex = -1
        CboRemitente.SelectedIndex = -1
    End Sub


    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Call Limpiar()

    End Sub
End Class