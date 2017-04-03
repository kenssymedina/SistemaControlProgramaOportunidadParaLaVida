Public Class FrmBeneficiado
    Private Sub Beneficiado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarAsistenciaComboBox()
        Call LlenarInternoComboBox()
        Call LlenarGradoCursadoComboBox()
        Call LlenarSexoComboBox()
        Call LlenarIglesiaComboBox()
        Call LlenarLugarComboBox()
        Call LlenarEstadoBeneficiadoComboBox()
        Call LlenarInstitucionComboBox()
        Call CargarDatosBeneficiado()
    End Sub
    Public Sub LlenarAsistenciaComboBox()

        Dim datos = (From a In cnn.AsistenciaClaseDominicals
                     Select a.IdAsistencia, a.Asistencia).ToList

        Me.CboAsistenciaClaseDominical.DataSource = datos

        Me.CboAsistenciaClaseDominical.ValueMember = "IdAsistencia"
        Me.CboAsistenciaClaseDominical.DisplayMember = "Asistencia"
        Me.CboAsistenciaClaseDominical.SelectedIndex = -1
        Me.CboAsistenciaClaseDominical.Text = "Seleccione..."

    End Sub
    Public Sub LlenarInternoComboBox()

        Dim datos = (From a In cnn.Internos
                     Select a.IdInterno, a.Interno).ToList

        Me.CboInterno.DataSource = datos

        Me.CboInterno.ValueMember = "IdInterno"
        Me.CboInterno.DisplayMember = "Interno"
        Me.CboInterno.SelectedIndex = -1
        Me.CboInterno.Text = "Seleccione..."

    End Sub
    Public Sub LlenarGradoCursadoComboBox()

        Dim Datos = (From a In cnn.GradoCursados
                     Select a.IdGradoCursado, a.GradoCursado).ToList

        Me.CboGradoCursado.DataSource = Datos

        Me.CboGradoCursado.ValueMember = "IdGradoCursado"
        Me.CboGradoCursado.DisplayMember = "GradoCursado"
        Me.CboGradoCursado.SelectedIndex = -1
        Me.CboGradoCursado.Text = "Seleccione..."

    End Sub
    Public Sub LlenarSexoComboBox()

        Dim datos = (From a In cnn.Sexos
                     Select a.IdSexo, a.Sexo).ToList
        Me.CboSexo.DataSource = datos

        Me.CboSexo.ValueMember = "IdSexo"
        Me.CboSexo.DisplayMember = "Sexo"
        Me.CboSexo.SelectedIndex = -1
        Me.CboSexo.Text = "Seleccione..."

    End Sub
    Public Sub LlenarIglesiaComboBox()

        Dim datos = (From a In cnn.Iglesias
                     Select a.IdIglesia, a.NombreIglesia).ToList
        Me.CboIglesia.DataSource = datos

        Me.CboIglesia.ValueMember = "IdIglesia"
        Me.CboIglesia.DisplayMember = "NombreIglesia"
        Me.CboIglesia.SelectedIndex = -1
        Me.CboIglesia.Text = "Seleccione..."

    End Sub
    Public Sub LlenarLugarComboBox()

        Dim datos = (From a In cnn.Lugars
                     Select a.IdLugar, a.Lugar).ToList
        Me.CboLugar.DataSource = datos

        Me.CboLugar.ValueMember = "IdLugar"
        Me.CboLugar.DisplayMember = "Lugar"
        Me.CboLugar.SelectedIndex = -1
        Me.CboLugar.Text = "Seleccione..."

    End Sub
    Public Sub LlenarEstadoBeneficiadoComboBox()

        Dim datos = (From a In cnn.EstadoBeneficiados
                     Select a.IdEstadoBeneficiado, a.EstadoBeneficiado).ToList
        Me.CboEstadoBeneficiado.DataSource = datos

        Me.CboEstadoBeneficiado.ValueMember = "IdEstadoBeneficiado"
        Me.CboEstadoBeneficiado.DisplayMember = "EstadoBeneficiado"
        Me.CboEstadoBeneficiado.SelectedIndex = -1
        Me.CboEstadoBeneficiado.Text = "Seleccione..."

    End Sub

    Public Sub LlenarInstitucionComboBox()

        Dim datos = (From a In cnn.Institucions
                     Select a.IdInstitucion, a.Institucion).ToList
        Me.CboInstitucion.DataSource = datos

        Me.CboInstitucion.ValueMember = "IdInstitucion"
        Me.CboInstitucion.DisplayMember = "Institucion"
        Me.CboInstitucion.SelectedIndex = -1
        Me.CboInstitucion.Text = "Seleccione..."

    End Sub
    Public Sub GuardarNuevoRegistro()

        Dim b As New Beneficiado With
            {.IdBeneficiado = CInt(TxtIdBeneficiado.Text),
             .NombreBeneficiado = TxtNombreBeneficiado.Text,
            .ApellidoBeneficiado = TxtApellidoBeneficiado.Text,
            .Direccion = TxtDireccionBeneficiado.Text,
            .FechaNac = CDate(TxtFechaNacBeneficiado.Text),
            .CantidadHermanos = TxtCantidadHermanos.Text,
            .CantidadHermanas = TxtCantidadHermanas.Text,
            .ColorOjos = TxtColorOjos.Text,
            .ColorPelo = TxtColorPelo.Text,
            .Nacionalidad = TxtNacionalidad.Text,
            .IdGradoCursado = CInt(Me.CboGradoCursado.SelectedValue),
            .IdSexo = CInt(Me.CboSexo.SelectedValue),
            .IdIglesia = CInt(Me.CboIglesia.SelectedValue),
            .IdLugar = CInt(Me.CboLugar.SelectedValue),
            .IdEstadoBeneficiado = CInt(Me.CboEstadoBeneficiado.SelectedValue),
            .IdInstitucion = CInt(Me.CboInstitucion.SelectedValue),
            .FechaHistoriaEnviada = CDate(TxtFechaHistoEnviada.Text),
            .EncuestaRealizada = TxtEncuestaRealizada.Text,
            .IdAsistencia = CInt(CboAsistenciaClaseDominical.SelectedValue),
            .IdInterno = CInt(CboInterno.SelectedValue),
            .EnfermedadPadecimiento = TxtEnfermedadPadecimiento.Text
            }
        Try
            cnn.Beneficiados.InsertOnSubmit(b)
            cnn.SubmitChanges()

            MsgBox("Correcto")
            CargarDatosBeneficiado()
        Catch ex As Exception
            MsgBox("Error")
        End Try
    End Sub

    Private Sub ActualizarDatosBeneficiado(id As Integer)
        Dim datos As Beneficiado = (From b In cnn.Beneficiados
                                    Where b.IdBeneficiado = id
                                    Select b).ToList()(0)


        datos.NombreBeneficiado = TxtNombreBeneficiado.Text
        datos.ApellidoBeneficiado = TxtApellidoBeneficiado.Text
        datos.Direccion = TxtDireccionBeneficiado.Text
        datos.FechaNac = TxtFechaNacBeneficiado.Text
        datos.CantidadHermanos = TxtCantidadHermanos.Text
        datos.CantidadHermanas = TxtCantidadHermanas.Text
        datos.ColorOjos = TxtColorOjos.Text
        datos.ColorPelo = TxtColorPelo.Text
        datos.Nacionalidad = TxtNacionalidad.Text
        datos.IdGradoCursado = CInt(Me.CboGradoCursado.SelectedValue)
        datos.IdSexo = CInt(Me.CboSexo.SelectedValue)
        datos.IdIglesia = CInt(Me.CboIglesia.SelectedValue)
        datos.IdLugar = CInt(Me.CboLugar.SelectedValue)
        datos.IdEstadoBeneficiado = CInt(Me.CboEstadoBeneficiado.SelectedValue)
        datos.IdInstitucion = CInt(Me.CboInstitucion.SelectedValue)
        datos.FechaHistoriaEnviada = TxtFechaHistoEnviada.Text
        datos.EncuestaRealizada = TxtEncuestaRealizada.Text
        datos.IdAsistencia = CInt(Me.CboAsistenciaClaseDominical.SelectedValue)
        datos.IdInterno = CInt(Me.CboInterno.SelectedValue)
        datos.EnfermedadPadecimiento = TxtEnfermedadPadecimiento.Text

        Try
            cnn.SubmitChanges()
            MsgBox("correcto")
            CargarDatosBeneficiado()
        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Public Sub CargarDatosBeneficiado()

        Dim datos = (From t In cnn.Beneficiados
                     Join g In cnn.GradoCursados On g.IdGradoCursado Equals t.IdGradoCursado
                     Join s In cnn.Sexos On s.IdSexo Equals t.IdSexo
                     Join i In cnn.Iglesias On t.IdIglesia Equals i.IdIglesia
                     Join l In cnn.Lugars On t.IdLugar Equals l.IdLugar
                     Join es In cnn.EstadoBeneficiados On t.IdEstadoBeneficiado Equals es.IdEstadoBeneficiado
                     Join ins In cnn.Institucions On t.IdInstitucion Equals ins.IdInstitucion
                     Join asis In cnn.AsistenciaClaseDominicals On t.IdAsistencia Equals asis.IdAsistencia
                     Join Int In cnn.Internos On t.IdInterno Equals Int.IdInterno
                     Select t.IdBeneficiado, t.NombreBeneficiado, t.ApellidoBeneficiado,
                         t.Direccion, t.FechaNac, t.CantidadHermanos, t.CantidadHermanas,
                         t.ColorOjos, t.ColorPelo, t.Nacionalidad, g.GradoCursado,
                        s.Sexo, i.NombreIglesia, l.Lugar,
                         es.EstadoBeneficiado, ins.Institucion, t.FechaHistoriaEnviada, t.EncuestaRealizada,
                         asis.Asistencia, Int.Interno, t.EnfermedadPadecimiento).ToList()
        Me.DgvDetallesBeneficiado.DataSource = datos

    End Sub

    Public Sub PasarDatosDetalleBeneficiado()
        Dim fila As DataGridViewRow = DgvDetallesBeneficiado.CurrentRow
        Me.TxtIdBeneficiado.Text = fila.Cells(0).Value
        Me.TxtNombreBeneficiado.Text = fila.Cells(1).Value
        Me.TxtApellidoBeneficiado.Text = fila.Cells(2).Value
        Me.TxtDireccionBeneficiado.Text = fila.Cells(3).Value
        Me.TxtFechaNacBeneficiado.Text = CDate(fila.Cells(4).Value)
        Me.TxtCantidadHermanos.Text = fila.Cells(5).Value
        Me.TxtCantidadHermanas.Text = fila.Cells(6).Value
        Me.TxtColorOjos.Text = fila.Cells(7).Value
        Me.TxtColorPelo.Text = fila.Cells(8).Value
        Me.TxtNacionalidad.Text = fila.Cells(9).Value
        Me.CboGradoCursado.SelectedValue = (fila.Cells(10).Value)
        Me.CboSexo.SelectedValue = (fila.Cells(11).Value)
        Me.CboIglesia.SelectedValue = (fila.Cells(12).Value)
        Me.CboLugar.SelectedValue = (fila.Cells(13).Value)
        Me.CboEstadoBeneficiado.SelectedValue = (fila.Cells(14).Value)
        Me.CboInstitucion.SelectedValue = (fila.Cells(15).Value)
        Me.TxtFechaHistoEnviada.Text = CDate(fila.Cells(16).Value)
        Me.TxtEncuestaRealizada.Text = (fila.Cells(17).Value)
        Me.CboAsistenciaClaseDominical.SelectedValue = (fila.Cells(18).Value)
        Me.CboInterno.SelectedValue = (fila.Cells(19).Value)
        Me.TxtEnfermedadPadecimiento.Text = fila.Cells(20).Value

    End Sub
    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarToolStripMenuItem.Click
        Call PasarDatosDetalleBeneficiado()
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Call GuardarNuevoRegistro()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Call ActualizarDatosBeneficiado(CInt(TxtIdBeneficiado.Text))
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        FrmTransaccionales.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub PictureBox8_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox8.MouseMove
        PictureBox8.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox8_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox8.MouseLeave
        PictureBox8.Size = New Size(49, 51)
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

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Close()

    End Sub

    Private Sub PictureBox7_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseMove
        PictureBox7.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox7.MouseLeave
        PictureBox7.Size = New Size(49, 51)
    End Sub
End Class