Imports System.Data
Imports System.Data.SqlClient

Public Class FrmSponsor
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarSexo()
        Call LlenarPais()
        Call LlenarTipoSponsor()
        Call CargarDatos()

    End Sub
    Public Sub LlenarSexo()
        Dim datos = (From a In cnn.Sexos
                     Select a.IdSexo, a.Sexo).ToList
        Me.CboSexo.DataSource = datos

        Me.CboSexo.ValueMember = "IdSexo"
        Me.CboSexo.DisplayMember = "Sexo"
        Me.CboSexo.SelectedIndex = -1
        Me.CboSexo.Text = "--seleccione--"
    End Sub
    Public Sub LlenarPais()
        Dim datos = (From a In cnn.Pais
                     Select a.IdPais, a.Pais).ToList
        Me.CboPais.DataSource = datos

        Me.CboPais.ValueMember = "IdPais"
        Me.CboPais.DisplayMember = "Pais"
        Me.CboPais.SelectedIndex = -1
        Me.CboPais.Text = "--seleccione--"
    End Sub
    Public Sub LlenarTipoSponsor()
        Dim datos = (From a In cnn.TipoSponsors
                     Select a.IdTipoSponsor, a.TipoSponsor).ToList
        Me.CboTipoSponsor.DataSource = datos

        Me.CboTipoSponsor.ValueMember = "IdTipoSponsor"
        Me.CboTipoSponsor.DisplayMember = "TipoSponsor"
        Me.CboTipoSponsor.SelectedIndex = -1
        Me.CboTipoSponsor.Text = "--seleccione--"
    End Sub

    Public Sub GuardarN()
        Dim sp As New Sponsor With
            {.NombreCompletoSponsor = TxtNombreSponsor.Text,
            .Direccion = TxtDireccion.Text,
            .CorreoElectronico = TxtCorreoE.Text,
            .IdSexo = CInt(Me.CboSexo.SelectedValue),
            .IdPais = CInt(Me.CboPais.SelectedValue),
            .IdTipoSponsor = CInt(Me.CboTipoSponsor.SelectedValue)
            }

        Try
            cnn.Sponsors.InsertOnSubmit(sp)
            cnn.SubmitChanges()

            MsgBox("correcto")
            CargarDatos()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Public Sub CargarDatos()


        Dim datos = (From sp In cnn.Sponsors
                     Join s In cnn.Sexos On s.IdSexo Equals sp.IdSexo
                     Join P In cnn.Pais On P.IdPais Equals sp.IdPais
                     Join ti In cnn.TipoSponsors On ti.IdTipoSponsor Equals sp.IdTipoSponsor
                     Select sp.IdSponsor, sp.NombreCompletoSponsor, sp.Direccion, sp.CorreoElectronico,
                        s.Sexo, P.Pais, ti.TipoSponsor).ToList()
        Me.DataGridView1.DataSource = datos

    End Sub

    Private Sub ActualizarDatos(id As Integer)
        Dim datos As Sponsor = (From sp In cnn.Sponsors
                                Where sp.IdSponsor = id
                                Select sp).ToList()(0)


        datos.NombreCompletoSponsor = TxtNombreSponsor.Text
        datos.Direccion = TxtDireccion.Text
        datos.CorreoElectronico = TxtCorreoE.Text
        datos.IdSexo = CInt(CboSexo.SelectedValue)
        datos.IdPais = CInt(CboPais.SelectedValue)
        datos.IdTipoSponsor = CInt(CboTipoSponsor.SelectedValue)
        Try
            cnn.SubmitChanges()
            MsgBox("correcto")
            Call CargarDatos()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub
    Public Sub PasarDatos()
        Dim fila As DataGridViewRow = DataGridView1.CurrentRow
        Me.TxtId.Text = fila.Cells(0).Value
        Me.TxtNombreSponsor.Text = fila.Cells(1).Value
        Me.TxtDireccion.Text = fila.Cells(2).Value
        Me.TxtCorreoE.Text = fila.Cells(3).Value
        Me.CboSexo.SelectedValue = (fila.Cells(4).Value)
        Me.CboPais.SelectedValue = (fila.Cells(5).Value)
        Me.CboTipoSponsor.SelectedValue = (fila.Cells(6).Value)

    End Sub
    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call PasarDatos()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Call ActualizarDatos(CInt(TxtId.Text))
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Call GuardarN()
    End Sub

    Private Sub CboTipoSponsor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTipoSponsor.SelectedIndexChanged

    End Sub
End Class