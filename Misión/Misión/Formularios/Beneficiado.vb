Public Class FrmBeneficiado

    Implements IForm
    Public b As Boolean



    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        TextBox1.Text = id

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New BuscarBeneficiados()
        frm.Show(Me)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        'esto de aqui es lo que permite obtener los datos desde el gridview solo llama a la clase AccederDatos.CargarDatosTutor(y manda los textbox y combobox)
        If b = False Then
            If TextBox1.Text <> "" Then
                accesodatos.CargarDatosBeneficiado(TextBox1.Text, TxtNombreBeneficiado, TxtApellidoBeneficiado,
                                                     TxtDireccionBeneficiado, TxtFechaNac, TxtCantidadHermanos,
                                                   TxtCantidadHermanas, TxtColorOjos, TxtColorPelo, CboGradoCursado,
                                                   CboSexo, CboIglesia, CboLugar, CboEstadoBeneficiado,
                                                   CboInstitucion, TxtFechaHistoEnviada, ckAsistencia, ckInterno,
                                                   CboNacionalidad, CboEnfermedad)

            End If
        End If

    End Sub


    Private Sub LlenarComboboxNacionalidad()
        Dim datos = (From a In cnn.Nacionalidads
                     Select a.IdNacionalidad, a.Nacionalidad
                         ).ToList
        Me.CboNacionalidad.DataSource = datos

        Me.CboNacionalidad.ValueMember = "IdNacionalidad"
        Me.CboNacionalidad.DisplayMember = "Nacionalidad"
        Me.CboNacionalidad.SelectedIndex = -1
        Me.CboNacionalidad.Text = "--Seleccione--"

    End Sub


    Private Sub LlenarComboboGradoC()
        Dim datos = (From g In cnn.GradoCursados
                     Select g.IdGradoCursado, g.GradoCursado
                     ).ToList
        Me.CboGradoCursado.DataSource = datos

        Me.CboGradoCursado.ValueMember = "IdGradoCursado"
        Me.CboGradoCursado.DisplayMember = "GradoCursado"
        Me.CboGradoCursado.SelectedIndex = -1
        Me.CboGradoCursado.Text = "--Seleccione--"
    End Sub

    Private Sub LlenarComboboxSexo()

        Dim datos = (From s In cnn.Sexos
                     Select s.IdSexo, s.Sexo
                         ).ToList

        Me.CboSexo.DataSource = datos

        Me.CboSexo.ValueMember = "IdSexo"
        Me.CboSexo.DisplayMember = "Sexo"
        Me.CboSexo.SelectedIndex = -1
        Me.CboSexo.Text = "--Seleccione--"
    End Sub

    Private Sub LlenarComboboxIglesia()

        Dim datos = (From i In cnn.Iglesias
                     Select i.IdIglesia, i.Iglesia
                      ).ToList

        Me.CboIglesia.DataSource = datos

        Me.CboIglesia.ValueMember = "IdIglesia"
        Me.CboIglesia.DisplayMember = "Iglesia"
        Me.CboIglesia.SelectedIndex = -1
        Me.CboIglesia.Text = "--Seleccione--"


    End Sub

    Private Sub LlenarComboboxLugar()
        Dim datos = (From l In cnn.Lugars
                     Select l.IdLugar, l.Lugar
                         ).ToList
        Me.CboLugar.DataSource = datos

        Me.CboLugar.ValueMember = "IdLugar"
        Me.CboLugar.DisplayMember = "Lugar"
        Me.CboLugar.SelectedIndex = -1
        Me.CboLugar.Text = "--Seleccione--"

    End Sub

    Private Sub LlenarComboboxEstadoBeneficiado()
        Dim datos = (From e In cnn.EstadoBeneficiados
                     Select e.IdEstadoBeneficiado, e.EstadoBeneficiado
                         ).ToList
        Me.CboEstadoBeneficiado.DataSource = datos

        Me.CboEstadoBeneficiado.ValueMember = "IdEstadoBeneficiado"
        Me.CboEstadoBeneficiado.DisplayMember = "EstadoBeneficiado"
        Me.CboEstadoBeneficiado.SelectedIndex = -1
        Me.CboEstadoBeneficiado.Text = "--Seleccione--"

    End Sub

    Private Sub LlenarComboboxInstitucion()
        Dim datos = (From q In cnn.Institucions
                     Select q.IdInstitucion, q.Institucion
                             ).ToList

        Me.CboInstitucion.DataSource = datos

        Me.CboInstitucion.ValueMember = "IdInstitucion"
        Me.CboInstitucion.DisplayMember = "Institucion"
        Me.CboInstitucion.SelectedIndex = -1
        Me.CboInstitucion.Text = "--Seleccione--"

    End Sub
    Private Sub LlenarComboboxEnfermedad()
        Dim datos = (From m In cnn.EnfermedadPadecimientos
                     Select m.IdEnfermedadPadecimiento, m.EnfermedadPadecimiento
                    ).ToList

        Me.CboEnfermedad.DataSource = datos
        Me.CboEnfermedad.ValueMember = "IdEnfermedadPadecimiento"
        Me.CboEnfermedad.DisplayMember = "EnfermedadPadecimiento"
        Me.CboEnfermedad.SelectedIndex = -1
        Me.CboEnfermedad.Text = "--Seleccione--"

    End Sub





    Private Sub FrmBeneficiado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarComboboxNacionalidad()
        Call LlenarComboboGradoC()
        Call LlenarComboboxEstadoBeneficiado()
        Call LlenarComboboxSexo()
        Call LlenarComboboxIglesia()
        Call LlenarComboboxLugar()
        Call LlenarComboboxInstitucion()
        Call LlenarComboboxEnfermedad()
    End Sub


    Public Sub GuardarN()
        If Validar() = True Then


            Dim t As New Beneficiado With
            {.IdBeneficiado = TextBox1.Text,
            .NombreBeneficiado = TxtNombreBeneficiado.Text,
            .ApellidoBeneficiado = TxtApellidoBeneficiado.Text,
            .Direccion = TxtDireccionBeneficiado.Text,
            .FechaNac = CDate(TxtFechaNac.Text),
            .CantidadHermanos = TxtCantidadHermanos.Text,
             .CantidadHermanas = TxtCantidadHermanas.Text,
             .ColorOjos = TxtColorOjos.Text,
             .ColorPelo = TxtColorPelo.Text,
             .IdGradoCursado = CInt(Me.CboGradoCursado.SelectedValue),
             .IdSexo = CInt(Me.CboSexo.SelectedValue),
             .IdIglesia = CInt(Me.CboIglesia.SelectedValue),
             .IdLugar = CInt(Me.CboLugar.SelectedValue),
             .IdEstadoBeneficiado = CInt(CboEstadoBeneficiado.SelectedValue),
             .IdInstitucion = CInt(CboInstitucion.SelectedValue),
             .FechaHistotiaEnviada = CDate(TxtFechaHistoEnviada.Text),
             .IdUsuario = IdUsuarioSistemaActual,
             .IdNacionalidad = CInt(CboNacionalidad.SelectedValue),
             .IdEnfermedadPadecimiento = CInt(CboEnfermedad.SelectedValue),
             .Interno = CBool(ckInterno.CheckState),
             .AsistenciaClaseDominical = CBool(ckAsistencia.CheckState)
           }

            Try
                cnn.Beneficiados.InsertOnSubmit(t)
                cnn.SubmitChanges()
                MsgBox("Datos ingresados correctamente", MsgBoxStyle.Information, "Aviso")

            Catch ex As Exception
                MsgBox("Error al ingersar los datos", MsgBoxStyle.Critical, "Aviso")
            End Try
        End If
    End Sub


    Public Sub ActualizarDatos(id As Integer)

        Dim datos As Beneficiado = (From t In cnn.Beneficiados
                                    Where t.IdBeneficiado = id
                                    Select t).ToList()(0)
        datos.NombreBeneficiado = TxtNombreBeneficiado.Text
        datos.ApellidoBeneficiado = TxtApellidoBeneficiado.Text
        datos.Direccion = TxtDireccionBeneficiado.Text
        datos.FechaNac = CDate(TxtFechaNac.Text)
        datos.CantidadHermanos = TxtCantidadHermanos.Text
        datos.ColorOjos = TxtColorOjos.Text
        datos.ColorPelo = TxtColorPelo.Text
        datos.IdGradoCursado = CInt(CboGradoCursado.SelectedValue)
        datos.IdSexo = CInt(CboSexo.SelectedValue)
        datos.IdIglesia = CInt(CboIglesia.SelectedValue)
        datos.IdLugar = CInt(CboIglesia.SelectedValue)
        datos.IdEstadoBeneficiado = CInt(CboEstadoBeneficiado.SelectedValue)
        datos.IdInstitucion = CInt(CboInstitucion.SelectedValue)
        datos.FechaHistotiaEnviada = CDate(TxtFechaHistoEnviada.Text)
        datos.IdUsuario = IdUsuarioSistemaActual
        datos.IdNacionalidad = CInt(CboNacionalidad.SelectedValue)
        datos.IdEnfermedadPadecimiento = CInt(CboEnfermedad.SelectedValue)
        datos.Interno = ckInterno.CheckState
        datos.AsistenciaClaseDominical = ckAsistencia.CheckState


        Try
            cnn.SubmitChanges()
            MsgBox("correcto")

        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub

    Public Sub nuevo()
        TextBox1.Text = ""
        TxtNombreBeneficiado.Text = ""
        TxtApellidoBeneficiado.Text = ""
        TxtDireccionBeneficiado.Text = ""
        TxtFechaNac.Text = ""
        TxtCantidadHermanos.Text = ""
        TxtCantidadHermanas.Text = ""
        TxtColorOjos.Text = "Seleccione"
        TxtColorPelo.Text = "Seleccione"
        CboGradoCursado.Text = "Seleccione"
        CboSexo.Text = "Seleccione"
        CboIglesia.Text = "Seleccione"
        CboLugar.Text = "Seleccione"
        CboLugar.Text = "Seleccione"
        CboEstadoBeneficiado.Text = "Seleccione"
        CboInstitucion.Text = "Seleccione"
        TxtFechaHistoEnviada.Text = ""
        CboNacionalidad.Text = "Seleccione"
        CboEnfermedad.Text = "Seleccione"
        ckAsistencia.Text = ""
        ckInterno.Text = ""


    End Sub





    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        Call GuardarN()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Call ActualizarDatos(CInt(TextBox1.Text))
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        FrmTransaccionales.Show()
        Me.Close()
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

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles BtnNuevo.MouseLeave
        BtnNuevo.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox4_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnNuevo.MouseMove
        BtnNuevo.Size = New Size(58, 59)
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

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call nuevo()
        b = True
    End Sub
    Private Function Validar() As Boolean
        Dim estado As Boolean
        If TextBox1.Text = Nothing And TxtNombreBeneficiado.Text = Nothing And TxtApellidoBeneficiado.Text = Nothing And TxtDireccionBeneficiado.Text = Nothing And TxtCantidadHermanos.Text = Nothing And TxtCantidadHermanas.Text = Nothing And TxtColorOjos.Text = Nothing And TxtColorPelo.Text = Nothing And CboNacionalidad.SelectedIndex = -1 And CboGradoCursado.SelectedIndex = -1 And CboSexo.SelectedIndex = -1 And CboIglesia.SelectedIndex = -1 And CboLugar.SelectedIndex = -1 And CboEstadoBeneficiado.SelectedIndex = -1 And CboInstitucion.SelectedIndex = -1 And CboEnfermedad.SelectedIndex = -1 Then
            MessageBox.Show("Ingrese los datos solicitados")
            TextBox1.Focus()
            estado = False
        ElseIf TxtNombreBeneficiado.Text = Nothing Then
            MessageBox.Show("ingrese el nombre del Beneficiado")
            TxtNombreBeneficiado.Focus()
            estado = False
        ElseIf TxtApellidoBeneficiado.Text = Nothing Then
            MessageBox.Show("ingrese el apellido del Beneficiado")
            TxtApellidoBeneficiado.Focus()
            estado = False

        ElseIf TxtDireccionBeneficiado.Text = Nothing Then
            MessageBox.Show("ingrese la direccion")
            TxtDireccionBeneficiado.Focus()
            estado = False
        ElseIf TxtCantidadHermanos.Text = Nothing Then
            MessageBox.Show("ingrese la cantidad de Hermanos")
            TxtCantidadHermanos.Focus()
            estado = False
        ElseIf TxtCantidadHermanas.Text = Nothing Then
            MessageBox.Show("ingrese la cantidad de Hermanas")
            TxtCantidadHermanas.Focus()
            estado = False

        ElseIf TxtColorOjos.Text = Nothing Then
            MessageBox.Show("ingrese el color de ojos")
            TxtColorOjos.Focus()
            estado = False
        ElseIf TxtColorPelo.Text = Nothing Then
            MessageBox.Show("Ingrese el color de pelo ")
            TxtColorPelo.Focus()
            estado = False
        ElseIf CboNacionalidad.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione la nacionalidad")
            CboNacionalidad.Focus()
            estado = False

        ElseIf CboGradoCursado.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el grado cursado")
            CboGradoCursado.Focus()
            estado = False

        ElseIf CboSexo.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el sexo")
            CboSexo.Focus()
            estado = False
        ElseIf CboIglesia.SelectedIndex = -1 Then
            MessageBox.Show("seleccione la iglesia")
            CboIglesia.Focus()
            estado = False

        ElseIf CboLugar.SelectedIndex = -1 Then
            MessageBox.Show("seleccione el lugar")
            CboLugar.Focus()
            estado = False

        ElseIf CboEstadoBeneficiado.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el estado del beneficiado")
            CboEstadoBeneficiado.Focus()
            estado = False

        ElseIf CboInstitucion.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione la institucion")
            CboInstitucion.Focus()
            estado = False

        ElseIf CboEnfermedad.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione la enfermedad de padecimiento")
            CboEnfermedad.Focus()
            estado = False
        Else
            estado = True

        End If
        Return estado
    End Function




    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        FrmInteresesBeneficiado.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        FrmCasaBeneficiado.Show()
    End Sub
End Class