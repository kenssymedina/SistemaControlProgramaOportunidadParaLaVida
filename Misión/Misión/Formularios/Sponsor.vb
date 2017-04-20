Imports System.Data
Imports System.Data.SqlClient
Public Class FrmSponsor
    Implements IForm
    Public b As Boolean

    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        TextBox4.Text = id
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If b = False Then
            If TextBox4.Text <> "" Then
                accesodatos.CargarDatoSponsor(TextBox4.Text, TxtNombre, TxtDireccion, TxtCorreoElectronico, CboSexo, CboPais,
                                              CboTipoSponsor)
            End If
        End If
    End Sub

    Private Sub llenarComboboxSexo()
        Dim m = (From s In cnn.Sexos
                 Select s.IdSexo, s.Sexo
                      ).ToList

        Me.CboSexo.DataSource = m

        Me.CboSexo.ValueMember = "IdSexo"
        Me.CboSexo.DisplayMember = "Sexo"
        Me.CboSexo.SelectedIndex = -1
        Me.CboSexo.Text = "--Seleccione--"
    End Sub
    Public Sub LlenarComboboxPais()
        Dim datos = (From p In cnn.Pais
                     Select p.IdPais, p.Pais).ToList

        Me.CboPais.DataSource = datos

        Me.CboPais.ValueMember = "IdPais"
        Me.CboPais.DisplayMember = "Pais"
        Me.CboPais.SelectedIndex = -1
        Me.CboPais.Text = "--Seleccione--"

    End Sub

    Public Sub LlenarTipoSponsor()
        Dim datos = (From y In cnn.TipoSponsors
                     Select y.IdTipoSponsor, y.TipoSponsor).ToList
        Me.CboTipoSponsor.DataSource = datos

        Me.CboTipoSponsor.ValueMember = "IdTipoSponsor"
        Me.CboTipoSponsor.DisplayMember = "TipoSponsor"
        Me.CboTipoSponsor.SelectedIndex = -1
        Me.CboTipoSponsor.Text = "--Seleccione--"



    End Sub


    Private Sub Sponsor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call llenarComboboxSexo()
        Call LlenarComboboxPais()
        Call LlenarTipoSponsor()


    End Sub
    Public Sub GuardarN()
        If validar() = True Then
            Dim sp As New Sponsor With
            {.IdSponsor = TextBox4.Text,
            .NombreCompletoSponsor = TxtNombre.Text,
            .Direccion = TxtDireccion.Text,
            .CorreoElectronico = TxtCorreoElectronico.Text,
            .IdSexo = CInt(Me.CboSexo.SelectedValue),
            .IdPais = CInt(Me.CboPais.SelectedValue),
            .IdTipoSponsor = CInt(Me.CboTipoSponsor.SelectedValue),
             .IdUsuario = IdUsuarioSistemaActual
             }
            Try
                cnn.Sponsors.InsertOnSubmit(sp)
                cnn.SubmitChanges()
                MsgBox("Datos ingresados correctamente", MsgBoxStyle.Information, "Aviso")

            Catch ex As Exception
                MsgBox(String.Format("Error: {0}", ex))
            End Try
        End If
    End Sub
    Private Sub Limpiar()
        TextBox4.Text = ""
        TxtNombre.Text = ""
        TxtDireccion.Text = ""
        TxtCorreoElectronico.Text = ""
        CboSexo.Text = ""
        CboPais.Text = ""
        CboTipoSponsor.Text = ""


    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New BusqueSponsor()
        frm.Show(Me)
    End Sub
    Public Sub ActualizarDatos(id As Integer)
        Dim datos As Sponsor = (From s In cnn.Sponsors
                                Where s.IdSponsor = id
                                Select s).ToList()(0)
        datos.NombreCompletoSponsor = TxtNombre.Text
        datos.Direccion = TxtDireccion.Text
        datos.CorreoElectronico = TxtCorreoElectronico.Text
        datos.IdSexo = CInt(Me.CboSexo.SelectedValue)
        datos.IdPais = CInt(Me.CboPais.SelectedValue)
        datos.IdTipoSponsor = CInt(Me.CboTipoSponsor.SelectedValue)
        datos.IdUsuario = 1


        Try
            cnn.SubmitChanges()
            MsgBox("correcto")

        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub





    Private Sub CboTipoSponsor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTipoSponsor.SelectedIndexChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Call GuardarN()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Call ActualizarDatos(CInt(TextBox4.Text))
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        FrmTransaccionales.Show()
        Me.Close()
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

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnActualizar.MouseMove
        BtnActualizar.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles BtnActualizar.MouseLeave
        BtnActualizar.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnGuardar.MouseMove
        BtnGuardar.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles BtnGuardar.MouseLeave
        BtnGuardar.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox9_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnNuevo.MouseMove
        BtnNuevo.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox9_MouseLeave(sender As Object, e As EventArgs) Handles BtnNuevo.MouseLeave
        BtnNuevo.Size = New Size(49, 51)
    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Limpiar()
        b = True
    End Sub

    Private Function validar() As Boolean
        Dim estado As Boolean

        If TextBox4.Text = Nothing And TxtNombre.Text = Nothing And TxtDireccion.Text = Nothing And TxtCorreoElectronico.Text = Nothing And CboSexo.SelectedIndex = -1 And CboPais.SelectedIndex = -1 And CboTipoSponsor.SelectedIndex = -1 Then
            MessageBox.Show("ingrese los datos solicitados")
            TextBox4.Focus()
            estado = False
        ElseIf TxtNombre.Text = Nothing Then
            MessageBox.Show("ingrese el nombre")
            TxtNombre.Focus()
            estado = False
        ElseIf txtDireccion.Text = Nothing Then
            MessageBox.Show("ingrese el apellido")
            TxtDireccion.Focus()
            estado = False
        ElseIf TxtCorreoElectronico.Text = Nothing Then
            MessageBox.Show("ingrese la direccion")
            TxtCorreoElectronico.Focus()
            estado = False
        ElseIf CboSexo.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el sexo")
            CboSexo.Focus()
            estado = False
        ElseIf CboPais.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el pais")
            CboPais.Focus()
            estado = False
        ElseIf CboTipoSponsor.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el tipo sponsor")
            CboTipoSponsor.Focus()
            estado = False
        Else
            estado = True
        End If
        Return estado
    End Function
End Class