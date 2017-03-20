Imports System.Data
Imports System.Data.SqlClient
Public Class FrmTutor


    Private Sub FrmEncargado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarCombobox()
        Call LlenarOficio()
        Call LlenarSexo()
        Call LlenarIglesia()
        Call LlenarParentesco()
        Call CargarDatos()

    End Sub
    Public Sub LlenarCombobox()

        Dim datos = (From p In cnn.Lugars
                     Select p.IdLugar, p.Lugar).ToList
        Me.CboLugar.DataSource = datos

        Me.CboLugar.ValueMember = "IdLugar"
        Me.CboLugar.DisplayMember = "Lugar"
        Me.CboLugar.SelectedIndex = -1
        Me.CboLugar.Text = "--seleccione--"

    End Sub
    Public Sub LlenarOficio()
        Dim datos = (From a In cnn.OficioProfesions
                     Select a.IdOficioProfesion, a.OficioProfesion).ToList
        Me.CboOficio.DataSource = datos
        Me.CboOficio.ValueMember = "IdOficioProfesion"
        Me.CboOficio.DisplayMember = "OficioProfesion"
        Me.CboOficio.SelectedIndex = -1
        Me.CboOficio.Text = "--seleccione--"
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
    Public Sub LlenarIglesia()
        Dim datos = (From a In cnn.Iglesias
                     Select a.IdIglesia, a.NombreIglesia).ToList
        Me.CboIglesia.DataSource = datos

        Me.CboIglesia.ValueMember = "IdIglesia"
        Me.CboIglesia.DisplayMember = "NombreIglesia"
        Me.CboIglesia.SelectedIndex = -1
        Me.CboIglesia.Text = "--seleccione--"
    End Sub
    Public Sub LlenarParentesco()
        Dim datos = (From a In cnn.Parentescos
                     Select a.IdParentesco, a.Parentesco).ToList
        Me.CboParentesco.DataSource = datos

        Me.CboParentesco.ValueMember = "IdParentesco"
        Me.CboParentesco.DisplayMember = "Parentesco"
        Me.CboParentesco.SelectedIndex = -1
        Me.CboParentesco.Text = "--seleccione--"
    End Sub
    Public Sub GuardarN()
        Dim t As New Tutor With
            {.NombreTutor = TxtNombre.Text,
            .ApellidoTutor = TxtApellido.Text,
            .Telefono = TxtNumeroT.Text,
            .Celular = TxtNumeroC.Text,
            .Direccion = TxtDireccion.Text,
            .FechaNac = CDate(TxtFechaNac.Text),
            .SalarioDia = CDbl(TxtSalario.Text),
            .IdLugar = CInt(Me.CboLugar.SelectedValue),
            .IdOficioProfesion = CInt(Me.CboOficio.SelectedValue),
            .IdSexo = CInt(Me.CboSexo.SelectedValue),
            .IdIglesia = CInt(Me.CboIglesia.SelectedValue),
            .IdParentesco = CInt(Me.CboParentesco.SelectedValue)
           }

        Try
            cnn.Tutors.InsertOnSubmit(t)
            cnn.SubmitChanges()

            MsgBox("correcto")
            CargarDatos()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Private Sub ActualizarDatos(id As Integer)
        Dim datos As Tutor = (From t In cnn.Tutors
                              Where t.IdTutor = id
                              Select t).ToList()(0)


        datos.NombreTutor = TxtNombre.Text
        datos.ApellidoTutor = TxtApellido.Text
        datos.Telefono = TxtNumeroT.Text
        datos.Celular = TxtNumeroC.Text
        datos.Direccion = TxtDireccion.Text
        datos.FechaNac = TxtFechaNac.Text
        datos.SalarioDia = TxtSalario.Text
        datos.IdSexo = CInt(CboSexo.SelectedValue)
        datos.IdLugar = CInt(CboLugar.SelectedValue)
        datos.IdOficioProfesion = CInt(CboOficio.SelectedValue)
        datos.IdIglesia = CInt(CboIglesia.SelectedValue)
        datos.IdParentesco = CInt(CboParentesco.SelectedValue)
        Try
            cnn.SubmitChanges()
            MsgBox("correcto")
            Call CargarDatos()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub
    Public Sub CargarDatos()


        Dim datos = (From t In cnn.Tutors
                     Join ofi In cnn.OficioProfesions On t.IdOficioProfesion Equals ofi.IdOficioProfesion
                     Join s In cnn.Sexos On s.IdSexo Equals t.IdSexo
                     Join i In cnn.Iglesias On t.IdIglesia Equals i.IdIglesia
                     Join l In cnn.Lugars On t.IdLugar Equals l.IdLugar
                     Join p In cnn.Parentescos On p.IdParentesco Equals t.IdParentesco
                     Select t.IdTutor, t.NombreTutor, t.ApellidoTutor, t.Telefono, t.Direccion, t.FechaNac, t.SalarioDia, t.Celular,
                        ofi.IdOficioProfesion, ofi.OficioProfesion, s.IdSexo, s.Sexo, i.IdIglesia, i.NombreIglesia, l.IdLugar, l.Lugar, p.IdParentesco, p.Parentesco
                   ).ToList()
        Me.DataGridView1.DataSource = datos

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        GuardarN()
    End Sub
    Public Sub PasarDatos()
        Dim fila As DataGridViewRow = DataGridView1.CurrentRow
        Me.TxtId.Text = fila.Cells(0).Value
        Me.TxtNombre.Text = fila.Cells(1).Value
        Me.TxtApellido.Text = fila.Cells(2).Value
        Me.TxtNumeroT.Text = fila.Cells(3).Value
        Me.TxtDireccion.Text = fila.Cells(4).Value
        Me.TxtFechaNac.Text = CDate(fila.Cells(5).Value)
        Me.TxtSalario.Text = fila.Cells(6).Value
        Me.TxtNumeroC.Text = fila.Cells(7).Value
        Me.txtidof.Text = fila.Cells(8).Value
        Me.CboOficio.SelectedValue = (fila.Cells(9).Value)
        Me.txtids.Text = fila.Cells(10).Value
        Me.CboSexo.SelectedValue = (fila.Cells(11).Value)
        Me.txtidiglesia.Text = fila.Cells(12).Value
        Me.CboIglesia.SelectedValue = (fila.Cells(13).Value)
        Me.txtidlu.Text = fila.Cells(14).Value
        Me.CboLugar.SelectedValue = (fila.Cells(15).Value)
        Me.txtidparen.Text = fila.Cells(16).Value
        Me.CboParentesco.SelectedValue = (fila.Cells(17).Value)




    End Sub
    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call PasarDatos()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Call ActualizarDatos(CInt(TxtId.Text))
    End Sub


End Class