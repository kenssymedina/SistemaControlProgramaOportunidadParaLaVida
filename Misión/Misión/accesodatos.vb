Public Class accesodatos
    Shared Sub CargarTutores(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then
            'si la funcion cargar no se le manda el parametro de busqueda osea que no tiene nada el txtBuscar muesta todos los datos en el grid
            grid.DataSource = (From a In cnn.Tutors
                               Join o In cnn.OficioProfesions On a.IdOficioProfesion Equals o.IdOficioProfesion
                               Join s In cnn.Sexos On a.IdSexo Equals s.IdSexo
                               Join i In cnn.Iglesias On a.IdIglesia Equals i.IdIglesia
                               Join l In cnn.Lugars On a.IdLugar Equals l.IdLugar
                               Join p In cnn.Parentescos On a.IdParentesco Equals p.IdParentesco
                               Join u In cnn.Usuarios On u.IdUsuario Equals a.IdUsuario
                               Order By a.IdTutor
                               Select a.IdTutor, a.NombreTutor, a.ApellidoTutor, a.Telefono,
                                   a.Direccion, a.Celular, a.FechaNac, a.SalarioDia, o.OficioProfesion,
                                   s.Sexo, i.Iglesia, l.Lugar, p.Parentesco, u.IdUsuario, u.NombreUsuario).ToList()
            ' si la variable busqueda o el txtBuscar tiene texto pues procede a realizar la busqueda
        Else
            grid.DataSource = (From a In cnn.Tutors
                               Join o In cnn.OficioProfesions On a.IdOficioProfesion Equals o.IdOficioProfesion
                               Join s In cnn.Sexos On a.IdSexo Equals s.IdSexo
                               Join i In cnn.Iglesias On a.IdIglesia Equals i.IdIglesia
                               Join l In cnn.Lugars On a.IdLugar Equals l.IdLugar
                               Join p In cnn.Parentescos On a.IdParentesco Equals p.IdParentesco
                               Join u In cnn.Usuarios On u.IdUsuario Equals a.IdUsuario
                               Where a.NombreTutor.Contains(busqueda)
                               Order By a.IdTutor
                               Select a.IdTutor, a.NombreTutor, a.ApellidoTutor, a.Telefono, a.Direccion,
                                   a.Celular, a.FechaNac, a.SalarioDia, o.OficioProfesion, s.Sexo, i.Iglesia,
                                   l.Lugar, p.Parentesco, u.IdUsuario, u.NombreUsuario).ToList()
        End If
        grid.Columns(0).Visible = False
        grid.Columns(13).Visible = False



    End Sub
    'esta es la funcion que envia los datos  de la fila seleccionada al  formulario 
    Shared Sub CargarDatosTutor(id As String, txt1 As TextBox, txt2 As TextBox,
                                txt3 As TextBox, txt4 As DateTimePicker,
                                txt5 As TextBox, txt6 As TextBox, txt7 As TextBox,
                                cbo As ComboBox, cbo1 As ComboBox, cbo2 As ComboBox,
                                cbo3 As ComboBox, cbo4 As ComboBox)
        Dim datos = (From a In cnn.Tutors
                     Join o In cnn.OficioProfesions On a.IdOficioProfesion Equals o.IdOficioProfesion
                     Join s In cnn.Sexos On a.IdSexo Equals s.IdSexo
                     Join i In cnn.Iglesias On a.IdIglesia Equals i.IdIglesia
                     Join l In cnn.Lugars On a.IdLugar Equals l.IdLugar
                     Join p In cnn.Parentescos On a.IdParentesco Equals p.IdParentesco
                     Join u In cnn.Usuarios On u.IdUsuario Equals a.IdUsuario
                     Order By a.IdTutor
                     Where a.IdTutor = id
                     Select a).SingleOrDefault()

        txt1.Text = datos.NombreTutor
        txt2.Text = datos.ApellidoTutor
        txt3.Text = datos.Telefono
        txt4.Text = datos.FechaNac
        txt5.Text = datos.SalarioDia
        txt6.Text = datos.Celular
        txt7.Text = datos.Direccion
        cbo.SelectedValue = CInt(datos.IdOficioProfesion)
        cbo1.SelectedValue = CInt(datos.IdSexo)
        cbo2.SelectedValue = CInt(datos.IdIglesia)
        cbo3.SelectedValue = CInt(datos.IdLugar)
        cbo4.SelectedValue = CInt(datos.IdParentesco)

    End Sub

    Shared Sub CargarBeneficiados(grid As DataGridView, Optional busqueda As String = "")

        If busqueda = "" Then


            grid.DataSource = (From t In cnn.Beneficiados
                               Join g In cnn.GradoCursados On g.IdGradoCursado Equals t.IdGradoCursado
                               Join s In cnn.Sexos On s.IdSexo Equals t.IdSexo
                               Join i In cnn.Iglesias On i.IdIglesia Equals t.IdIglesia
                               Join l In cnn.Lugars On l.IdLugar Equals t.IdLugar
                               Join e In cnn.EstadoBeneficiados On e.IdEstadoBeneficiado Equals t.IdEstadoBeneficiado
                               Join p In cnn.Institucions On p.IdInstitucion Equals t.IdInstitucion
                               Join k In cnn.Nacionalidads On k.IdNacionalidad Equals t.IdNacionalidad
                               Join n In cnn.EnfermedadPadecimientos On n.IdEnfermedadPadecimiento Equals t.IdEnfermedadPadecimiento
                               Join u In cnn.Usuarios On u.IdUsuario Equals t.IdUsuario
                               Order By t.IdBeneficiado
                               Select t.IdBeneficiado, t.NombreBeneficiado, t.ApellidoBeneficiado, t.Direccion, t.FechaNac,
                                   t.CantidadHermanos, t.CantidadHermanas, t.ColorOjos, t.ColorPelo,
                                   g.IdGradoCursado, g.GradoCursado, s.IdSexo, s.Sexo, i.IdIglesia, i.Iglesia, l.IdLugar, l.Lugar, e.IdEstadoBeneficiado, e.EstadoBeneficiado, e.Beneficiados, p.IdInstitucion, p.Institucion, t.FechaHistotiaEnviada,
                                    k.IdNacionalidad, k.Nacionalidad,
                                   n.IdEnfermedadPadecimiento, n.EnfermedadPadecimiento, t.Interno, t.AsistenciaClaseDominical, u.NombreUsuario
).ToList()
        Else
            grid.DataSource = (From t In cnn.Beneficiados
                               Join g In cnn.GradoCursados On g.IdGradoCursado Equals t.IdGradoCursado
                               Join s In cnn.Sexos On s.IdSexo Equals t.IdSexo
                               Join i In cnn.Iglesias On i.IdIglesia Equals t.IdIglesia
                               Join l In cnn.Lugars On l.IdLugar Equals t.IdLugar
                               Join e In cnn.EstadoBeneficiados On e.IdEstadoBeneficiado Equals t.IdEstadoBeneficiado
                               Join p In cnn.Institucions On p.IdInstitucion Equals t.IdInstitucion
                               Join k In cnn.Nacionalidads On k.IdNacionalidad Equals t.IdNacionalidad
                               Join n In cnn.EnfermedadPadecimientos On n.IdEnfermedadPadecimiento Equals t.IdEnfermedadPadecimiento
                               Join u In cnn.Usuarios On u.IdUsuario Equals t.IdUsuario
                               Order By t.IdBeneficiado
                               Where t.NombreBeneficiado.Contains(busqueda)
                               Select t.IdBeneficiado, t.NombreBeneficiado, t.ApellidoBeneficiado, t.Direccion, t.FechaNac,
                                   t.CantidadHermanos, t.CantidadHermanas, t.ColorOjos, t.ColorPelo,
                                   g.IdGradoCursado, g.GradoCursado, s.IdSexo, s.Sexo, i.IdIglesia, i.Iglesia, l.IdLugar, l.Lugar, e.IdEstadoBeneficiado, e.EstadoBeneficiado, e.Beneficiados, p.IdInstitucion, p.Institucion, t.FechaHistotiaEnviada,
                                    k.IdNacionalidad, k.Nacionalidad,
                                   n.IdEnfermedadPadecimiento, n.EnfermedadPadecimiento, t.Interno, t.AsistenciaClaseDominical, u.NombreUsuario).ToList()
        End If

        grid.Columns(9).Visible = False
        grid.Columns(11).Visible = False
        grid.Columns(13).Visible = False
        grid.Columns(15).Visible = False
        grid.Columns(17).Visible = False
        grid.Columns(19).Visible = False
        grid.Columns(22).Visible = False
        grid.Columns(24).Visible = False

    End Sub
    Shared Sub CargarDatosBeneficiado(id As String, txt1 As TextBox, txt2 As TextBox, txt3 As TextBox, txt4 As DateTimePicker,
                                      txt5 As TextBox, txt6 As TextBox, txt7 As TextBox,
                                      txt8 As TextBox, cbo1 As ComboBox, cbo2 As ComboBox, cbo3 As ComboBox,
                                      cbo4 As ComboBox, cbo5 As ComboBox, cbo6 As ComboBox, txt9 As DateTimePicker,
                                      cbo7 As CheckBox, cbo8 As CheckBox, cbo9 As ComboBox, cbo10 As ComboBox)
        Dim datos = (From t In cnn.Beneficiados
                     Join g In cnn.GradoCursados On g.IdGradoCursado Equals t.IdGradoCursado
                     Join s In cnn.Sexos On s.IdSexo Equals t.IdSexo
                     Join i In cnn.Iglesias On i.IdIglesia Equals t.IdIglesia
                     Join l In cnn.Lugars On l.IdLugar Equals t.IdLugar
                     Join e In cnn.EstadoBeneficiados On e.IdEstadoBeneficiado Equals t.IdEstadoBeneficiado
                     Join p In cnn.Institucions On p.IdInstitucion Equals t.IdInstitucion
                     Join u In cnn.Usuarios On u.IdUsuario Equals t.IdUsuario
                     Join x In cnn.EnfermedadPadecimientos On x.IdEnfermedadPadecimiento Equals t.IdEnfermedadPadecimiento
                     Order By t.IdBeneficiado
                     Where t.IdBeneficiado = id
                     Select t).SingleOrDefault()

        txt1.Text = datos.NombreBeneficiado
        txt2.Text = datos.ApellidoBeneficiado
        txt3.Text = datos.Direccion
        txt4.Text = datos.FechaNac
        txt5.Text = datos.CantidadHermanos
        txt6.Text = datos.CantidadHermanas
        txt7.Text = datos.ColorOjos
        txt8.Text = datos.ColorPelo
        cbo1.SelectedValue = CInt(datos.IdGradoCursado)
        cbo2.SelectedValue = CInt(datos.IdSexo)
        cbo3.SelectedValue = CInt(datos.IdIglesia)
        cbo4.SelectedValue = CInt(datos.IdLugar)
        cbo5.SelectedValue = CInt(datos.IdEstadoBeneficiado)
        cbo6.SelectedValue = CInt(datos.IdInstitucion)
        txt9.Text = datos.FechaHistotiaEnviada

        cbo7.Checked = CBool(datos.AsistenciaClaseDominical)
        cbo8.Checked = CBool(datos.Interno)

        cbo9.SelectedValue = CInt(datos.IdNacionalidad)
        cbo10.SelectedValue = CInt(datos.IdEnfermedadPadecimiento)
    End Sub
    Shared Sub CargarSponsor(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then

            grid.DataSource = (From sp In cnn.Sponsors
                               Join s In cnn.Sexos On s.IdSexo Equals sp.IdSexo
                               Join P In cnn.Pais On P.IdPais Equals sp.IdPais
                               Join ti In cnn.TipoSponsors On ti.IdTipoSponsor Equals sp.IdTipoSponsor
                               Join u In cnn.Usuarios On u.IdUsuario Equals sp.IdUsuario
                               Order By sp.IdSponsor
                               Select sp.IdSponsor, sp.NombreCompletoSponsor, sp.Direccion, sp.CorreoElectronico,
                                   s.IdSexo, s.Sexo, P.IdPais, P.Pais, ti.IdTipoSponsor, ti.TipoSponsor, u.NombreUsuario).ToList()

        Else
            grid.DataSource = (From sp In cnn.Sponsors
                               Join s In cnn.Sexos On s.IdSexo Equals sp.IdSexo
                               Join P In cnn.Pais On P.IdPais Equals sp.IdPais
                               Join ti In cnn.TipoSponsors On ti.IdTipoSponsor Equals sp.IdTipoSponsor
                               Join u In cnn.Usuarios On u.IdUsuario Equals sp.IdUsuario
                               Where sp.NombreCompletoSponsor.Contains(busqueda)
                               Order By sp.IdSponsor
                               Select sp.IdSponsor, sp.NombreCompletoSponsor, sp.Direccion, sp.CorreoElectronico,
                                   s.IdSexo, s.Sexo, P.IdPais, P.Pais, ti.IdTipoSponsor, ti.TipoSponsor, u.NombreUsuario).ToList()

        End If
        grid.Columns(4).Visible = False
        grid.Columns(6).Visible = False
        grid.Columns(8).Visible = False
    End Sub

    Shared Sub CargarDatoSponsor(id As String, txt1 As TextBox, txt2 As TextBox, txt3 As TextBox,
                                 cbo1 As ComboBox, cbo2 As ComboBox, cbo3 As ComboBox)

        Dim datos = (From sp In cnn.Sponsors
                     Join s In cnn.Sexos On s.IdSexo Equals sp.IdSexo
                     Join P In cnn.Pais On P.IdPais Equals sp.IdPais
                     Join ti In cnn.TipoSponsors On ti.IdTipoSponsor Equals sp.IdTipoSponsor
                     Join u In cnn.Usuarios On u.IdUsuario Equals sp.IdUsuario
                     Order By sp.IdSponsor
                     Where sp.IdSponsor = id
                     Select sp).SingleOrDefault()

        txt1.Text = datos.NombreCompletoSponsor
        txt2.Text = datos.Direccion
        txt3.Text = datos.CorreoElectronico
        cbo1.SelectedValue = datos.IdSexo
        cbo2.SelectedValue = datos.IdPais
        cbo3.SelectedValue = datos.IdTipoSponsor

    End Sub

    'NACIONALIDAD
    Shared Sub cargarNacionalidades(grid As DataGridView)
        grid.DataSource = (From p In cnn.Nacionalidads
                           Order By p.Nacionalidad Ascending
                           Select p.IdNacionalidad, p.Nacionalidad).ToList
        grid.Columns(0).Visible = False
    End Sub
    Shared Sub CargarDatosNacionalidad(id As String, nombre As TextBox)
        Dim datos = (From p In cnn.Nacionalidads
                     Where p.IdNacionalidad = id
                     Select p.IdNacionalidad, p.Nacionalidad).SingleOrDefault
        nombre.Text = datos.Nacionalidad
    End Sub

End Class