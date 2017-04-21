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

    ' PARENTESCO
    Shared Sub cargarParentescos(grid As DataGridView)
        grid.DataSource = (From p In cnn.Parentescos
                           Order By p.Parentesco Ascending
                           Select p.IdParentesco, p.Parentesco).ToList
        grid.Columns(0).Visible = False
    End Sub
    Shared Sub CargarDatosParentesco(id As String, nombre As TextBox)
        Dim datos = (From p In cnn.Parentescos
                     Where p.IdParentesco = id
                     Select p.IdParentesco, p.Parentesco).SingleOrDefault
        nombre.Text = datos.Parentesco
    End Sub

    'OFICIO PROFESION 
    Shared Sub cargaroficios(grid As DataGridView)
        grid.DataSource = (From p In cnn.OficioProfesions
                           Order By p.IdOficioProfesion Ascending
                           Select p.IdOficioProfesion, p.OficioProfesion).ToList
        grid.Columns(0).Visible = True
    End Sub
    Shared Sub CargarDatosTipoOficio(id As String, nombre As TextBox)
        Dim datos = (From sp In cnn.OficioProfesions
                     Where sp.IdOficioProfesion = id
                     Select sp).SingleOrDefault
        nombre.Text = datos.OficioProfesion
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

    'enfermedad
    Shared Sub cargarEnfermedades(grid As DataGridView)
        grid.DataSource = (From p In cnn.EnfermedadPadecimientos
                           Order By p.IdEnfermedadPadecimiento Ascending
                           Select p.IdEnfermedadPadecimiento, p.EnfermedadPadecimiento).ToList
        grid.Columns(0).Visible = False
    End Sub
    Shared Sub CargarDatosEnfermedad(id As String, nombre As TextBox)
        Dim datos = (From p In cnn.EnfermedadPadecimientos
                     Where p.IdEnfermedadPadecimiento = id
                     Select p.IdEnfermedadPadecimiento, p.EnfermedadPadecimiento).SingleOrDefault
        nombre.Text = datos.EnfermedadPadecimiento
    End Sub

    ' PAIS

    Shared Sub cargarPaises(grid As DataGridView)
        grid.DataSource = (From p In cnn.Pais
                           Order By p.Pais Ascending
                           Select p.IdPais, p.Pais).ToList
        grid.Columns(0).Visible = False
    End Sub
    Shared Sub CargarDatosPaises(id As String, nombre As TextBox)
        Dim datos = (From p In cnn.Pais
                     Where p.IdPais = id
                     Select p.IdPais, p.Pais).SingleOrDefault
        nombre.Text = datos.Pais
    End Sub








    '--------------- FORMULARIO IGLESIA -------------

    ' Cargar los datos de sql al dat grid de iglesia
    Shared Sub cargarIglesia(grid As DataGridView)
        grid.DataSource = (From I In cnn.Iglesias
                           Order By I.IdIglesia Ascending
                           Select I.IdIglesia, I.Iglesia, I.NombrePastor).ToList
        grid.Columns(0).Visible = False
    End Sub
    'pasar datos de la dat grid a los textbox de iglesia
    Shared Sub CargarDatosIglesia(id As String, txt1 As TextBox, txt2 As TextBox)
        Dim datos = (From i In cnn.Iglesias
                     Where i.IdIglesia = id
                     Select i).SingleOrDefault()
        txt1.Text = datos.Iglesia
        txt2.Text = datos.NombrePastor
    End Sub

    '--------------- FORMULARIO HERMANOS  -------------

    ' Cargar los datos de sql al dat grid de Beneficiado para mostrar en el formulario de hermanos
    Shared Sub CargarBeneficiadoHermano(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then
            'si la funcion cargar no se le manda el parametro de busqueda osea que no tiene nada el txtBuscar muesta todos los datos en el grid
            grid.DataSource = (From a In cnn.Beneficiados
                               Order By a.IdBeneficiado
                               Select a.IdBeneficiado, Nombre_Brnrficiado = a.NombreBeneficiado + " " + a.ApellidoBeneficiado).ToList()
        Else
            ' si la variable busqueda o el txtBuscar tiene texto pues procede a realizar la busqueda
            grid.DataSource = (From a In cnn.Beneficiados
                               Order By a.IdBeneficiado
                               Where a.NombreBeneficiado.Contains(busqueda)
                               Select a.IdBeneficiado, Nombre_Beneficiado = a.NombreBeneficiado + " " + a.ApellidoBeneficiado).ToList()
        End If

    End Sub
    'pasar datos de la dat grid de Beneficiado a los textbox de Hermano
    Shared Sub CargarDatosBeneficidoHermano(id As String, txt1 As TextBox)
        Dim datos = (From a In cnn.Beneficiados
                     Order By a.IdBeneficiado
                     Where a.IdBeneficiado = id
                     Select a).SingleOrDefault()
        txt1.Text = datos.NombreBeneficiado + " " + datos.ApellidoBeneficiado
    End Sub

    ' Cargar los datos de sql al dat grid de Hermanos para mostrar en el formulario de hermanos
    Shared Sub Cargarhermanos(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then
            'si la funcion cargar no se le manda el parametro de busqueda osea que no tiene nada el txtBuscar muesta
            'todos los datos en el grid
            grid.DataSource = (From c In cnn.Hermanos
                               Join s In cnn.GradoCursados On c.IdGradoCursado Equals s.IdGradoCursado
                               Join bh In cnn.BeneficiadoHermanos On bh.IdHermano Equals c.IdHermano
                               Join b In cnn.Beneficiados On b.IdBeneficiado Equals bh.IdBeneficiado
                               Join o In cnn.Sexos On c.IdSexo Equals o.IdSexo
                               Order By c.IdHermano
                               Select c.IdHermano, c.NombreHermano, c.ApellidoHermano, c.FechaNac, c.SponsorHermano,
                                   s.IdGradoCursado, s.GradoCursado, o.IdSexo, o.Sexo, b.IdBeneficiado, b.NombreBeneficiado, b.ApellidoBeneficiado).ToList()
        Else
            ' si la variable busqueda o el txtBuscar tiene texto pues procede a realizar la busqueda
            grid.DataSource = (From c In cnn.Hermanos
                               Join s In cnn.GradoCursados On c.IdGradoCursado Equals s.IdGradoCursado
                               Join bh In cnn.BeneficiadoHermanos On bh.IdHermano Equals c.IdHermano
                               Join b In cnn.Beneficiados On b.IdBeneficiado Equals bh.IdBeneficiado
                               Join o In cnn.Sexos On c.IdSexo Equals o.IdSexo
                               Order By c.IdHermano
                               Where c.NombreHermano.Contains(busqueda)
                               Select c.IdHermano, c.NombreHermano, c.ApellidoHermano, c.FechaNac, c.SponsorHermano,
                                   s.IdGradoCursado, s.GradoCursado, o.IdSexo, o.Sexo, b.IdBeneficiado, b.NombreBeneficiado, b.ApellidoBeneficiado).ToList()
        End If
        grid.Columns(5).Visible = False
        grid.Columns(7).Visible = False
    End Sub

    'pasar datos de la dat grid de Hermanos a los textbox de Hermanos
    Shared Sub CargarDatosHermano(id As String, txt1 As TextBox, txt2 As TextBox, txt3 As DateTimePicker,
                                  chk As CheckBox, txt4 As TextBox, txt5 As TextBox, cbo1 As ComboBox, cbo2 As ComboBox)
        Dim datos = (From c In cnn.Hermanos
                     Join s In cnn.GradoCursados On c.IdGradoCursado Equals s.IdGradoCursado
                     Join bh In cnn.BeneficiadoHermanos On bh.IdHermano Equals c.IdHermano
                     Join b In cnn.Beneficiados On b.IdBeneficiado Equals bh.IdBeneficiado
                     Join o In cnn.Sexos On c.IdSexo Equals o.IdSexo
                     Order By c.IdHermano
                     Where c.IdHermano = id
                     Select c.IdHermano, c.NombreHermano, c.ApellidoHermano, c.FechaNac, c.SponsorHermano,
                                   s.IdGradoCursado, o.IdSexo, b.IdBeneficiado, b.NombreBeneficiado, b.ApellidoBeneficiado).SingleOrDefault()
        txt1.Text = datos.NombreHermano
        txt2.Text = datos.ApellidoHermano
        txt3.Text = datos.FechaNac
        chk.Checked = datos.SponsorHermano
        cbo1.SelectedValue = CInt(datos.IdGradoCursado)
        cbo2.SelectedValue = CInt(datos.IdSexo)
        txt4.Text = datos.IdBeneficiado
        txt5.Text = datos.NombreBeneficiado + " " + datos.ApellidoBeneficiado

    End Sub
    '--------------- FORMULARIO LUGAR -------------

    ' Cargar los datos de sql al dat grid de Lugar
    Shared Sub cargarLugar(grid As DataGridView)
        grid.DataSource = (From i In cnn.Lugars
                           Join s In cnn.Pais On i.IdPais Equals s.IdPais
                           Order By i.Lugar
                           Select i.IdLugar, i.Lugar, s.IdPais, s.Pais).ToList
        grid.Columns(0).Visible = False
        grid.Columns(2).Visible = False
    End Sub
    ' pasar datos de la dat grid a los textbox de Lugar
    Shared Sub CargarDatosLugar(id As String, txt1 As TextBox, cbo As ComboBox)
        Dim datos = (From i In cnn.Lugars
                     Join s In cnn.Pais On i.IdPais Equals s.IdPais
                     Where i.IdLugar = id
                     Select i.IdLugar, i.Lugar, s.IdPais, s.Pais).SingleOrDefault()
        txt1.Text = datos.Lugar
        cbo.SelectedValue = CInt(datos.IdPais)
    End Sub
    '--------------- FORMULARIO  GRADO CURSADO -------------

    ' Cargar los datos de sql al dat grid de Grado Cursado
    Shared Sub cargarGrado(grid As DataGridView)
        grid.DataSource = (From i In cnn.GradoCursados
                           Order By i.IdGradoCursado
                           Select i.IdGradoCursado, i.GradoCursado).ToList
    End Sub
    ' pasar datos de la dat grid a los textbox de Grado Cursado
    Shared Sub CargarDatosGrado(id As String, txt1 As TextBox)
        Dim datos = (From i In cnn.GradoCursados
                     Where i.IdGradoCursado = id
                     Select i.IdGradoCursado, i.GradoCursado).SingleOrDefault()
        txt1.Text = datos.GradoCursado
    End Sub
    '--------------- FORMULARIO  CASA BENEFICIADO -------------

    ' Cargar los datos de sql al dat grid de Beneficiado para mostrar en el formulario de CasaBeneficiado

    Shared Sub CargarBeneficiadoCasa(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then
            'si la funcion cargar no se le manda el parametro de busqueda osea que no tiene nada el txtBuscar muesta todos los datos en el grid
            grid.DataSource = (From a In cnn.Beneficiados
                               Order By a.IdBeneficiado
                               Select a.IdBeneficiado, Nombre_Beneficiado = a.NombreBeneficiado + " " + a.ApellidoBeneficiado).ToList()
        Else
            ' si la variable busqueda o el txtBuscar tiene texto pues procede a realizar la busqueda
            grid.DataSource = (From a In cnn.Beneficiados
                               Order By a.IdBeneficiado
                               Where a.NombreBeneficiado.Contains(busqueda)
                               Select a.IdBeneficiado, Nombre_Beneficiado = a.NombreBeneficiado + " " + a.ApellidoBeneficiado).ToList()
        End If

    End Sub

    'pasar datos de la dat grid de Beneficiado a los textbox de CasaBeneficiado
    Shared Sub CargarDatosBeneficidoCasa(id As String, txt1 As TextBox)
        Dim datos = (From a In cnn.Beneficiados
                     Order By a.IdBeneficiado
                     Where a.IdBeneficiado = id
                     Select a).SingleOrDefault()
        txt1.Text = datos.NombreBeneficiado + " " + datos.ApellidoBeneficiado
    End Sub

    ' Cargar los datos de sql al dat grid de CasaBeneficiado para mostrar en el formulario de CasaBeneficiado
    Shared Sub CargarCasaBeneficiaado(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then
            'si la funcion cargar no se le manda el parametro de busqueda osea que no tiene nada el txtBuscar muesta
            'todos los datos en el grid
            grid.DataSource = (From c In cnn.CasaBeneficiados
                               Join b In cnn.Beneficiados On b.IdBeneficiado Equals c.IdBeneficiado
                               Join a In cnn.TipoCasas On a.IdTipoCasa Equals c.IdTipoCasa
                               Order By c.IdCasaBeneficiado
                               Select c.IdCasaBeneficiado, b.IdBeneficiado,
                                   Nombre_Beneficiado = b.NombreBeneficiado + " " + b.ApellidoBeneficiado, c.CantidadDormitorios, c.CantidadCamas, c.CantidadHamacas, c.CantidadRopaCama,
                                   c.CantidadMesas, c.CantidadSillas, a.IdTipoCasa, a.TipoCasa).ToList()
        Else
            ' si la variable busqueda o el txtBuscar tiene texto pues procede a realizar la busqueda
            grid.DataSource = (From c In cnn.CasaBeneficiados
                               Join b In cnn.Beneficiados On b.IdBeneficiado Equals c.IdBeneficiado
                               Join a In cnn.TipoCasas On a.IdTipoCasa Equals c.IdTipoCasa
                               Order By c.IdCasaBeneficiado
                               Where b.NombreBeneficiado.Contains(busqueda)
                               Select c.IdCasaBeneficiado, b.IdBeneficiado,
                                   Nombre_Beneficiado = b.NombreBeneficiado + " " + b.ApellidoBeneficiado, c.CantidadDormitorios, c.CantidadCamas, c.CantidadHamacas, c.CantidadRopaCama,
                                   c.CantidadMesas, c.CantidadSillas, a.IdTipoCasa, a.TipoCasa).ToList()
        End If
        grid.Columns(0).Visible = False
        grid.Columns(7).Visible = False
    End Sub

    'pasar datos de la dat grid de CasaBeneficado a los textbox de CasaBeneficado
    Shared Sub CargarDatosCasaBeneficiado(id As String, txt1 As TextBox, txt2 As TextBox, txt3 As TextBox,
                                   txt4 As TextBox, txt5 As TextBox, txt6 As TextBox, txt7 As TextBox, txt8 As TextBox,
                                          txt9 As TextBox, cbo As ComboBox)
        Dim datos = (From c In cnn.CasaBeneficiados
                     Join b In cnn.Beneficiados On b.IdBeneficiado Equals c.IdBeneficiado
                     Join a In cnn.TipoCasas On a.IdTipoCasa Equals c.IdTipoCasa
                     Order By c.IdCasaBeneficiado
                     Where c.IdCasaBeneficiado = id
                     Select c.IdCasaBeneficiado, c.CantidadDormitorios, c.CantidadCamas, c.CantidadHamacas, c.CantidadRopaCama,
                                   c.CantidadMesas, c.CantidadSillas, c.Piso, a.IdTipoCasa, a.TipoCasa, b.IdBeneficiado,
                         b.NombreBeneficiado, b.ApellidoBeneficiado).SingleOrDefault()

        txt1.Text = datos.CantidadDormitorios
        txt2.Text = datos.CantidadCamas
        txt3.Text = datos.CantidadHamacas
        txt4.Text = datos.CantidadRopaCama
        txt5.Text = datos.CantidadMesas
        txt6.Text = datos.CantidadSillas
        txt7.Text = datos.Piso
        txt8.Text = datos.IdBeneficiado
        txt9.Text = datos.NombreBeneficiado + " " + datos.ApellidoBeneficiado
        cbo.SelectedValue = CInt(datos.IdTipoCasa)


    End Sub


    '--------------- FORMULARIO INTERESES BENEFICIADO  -------------

    ' Cargar los datos de sql al dat grid de Beneficiado para mostrar en el formulario de Intereses Beneficado
    Shared Sub CargarBeneficiadoIntereses(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then
            'si la funcion cargar no se le manda el parametro de busqueda osea que no tiene nada el txtBuscar muesta todos los datos en el grid
            grid.DataSource = (From a In cnn.Beneficiados
                               Order By a.IdBeneficiado
                               Select a.IdBeneficiado, Nombre_Brnrficiado = a.NombreBeneficiado + " " + a.ApellidoBeneficiado).ToList()
        Else
            ' si la variable busqueda o el txtBuscar tiene texto pues procede a realizar la busqueda
            grid.DataSource = (From a In cnn.Beneficiados
                               Order By a.IdBeneficiado
                               Where a.NombreBeneficiado.Contains(busqueda)
                               Select a.IdBeneficiado, Nombre_Beneficiado = a.NombreBeneficiado + " " + a.ApellidoBeneficiado).ToList()
        End If

    End Sub
    'pasar datos de la dat grid de Beneficiado a los textbox de Intereses Benefciado
    Shared Sub CargarDatosBeneficidoIntereses(id As String, txt1 As TextBox)
        Dim datos = (From a In cnn.Beneficiados
                     Order By a.IdBeneficiado
                     Where a.IdBeneficiado = id
                     Select a).SingleOrDefault()
        txt1.Text = datos.NombreBeneficiado + " " + datos.ApellidoBeneficiado
    End Sub

    ' Cargar los datos de sql al dat grid de InteresesBeneficiado para mostrar en el formulario de InteresesBeneficado
    Shared Sub CargarIntereses(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then
            'si la funcion cargar no se le manda el parametro de busqueda osea que no tiene nada el txtBuscar muesta
            'todos los datos en el grid
            grid.DataSource = (From c In cnn.InteresesBeneficiados
                               Join b In cnn.Beneficiados On b.IdBeneficiado Equals c.IdBeneficiado
                               Order By c.IdIntereseBeneficiado
                               Select c.IdIntereseBeneficiado, b.IdBeneficiado, b.NombreBeneficiado, b.ApellidoBeneficiado,
                                   c.GustaComerBeneficiado, c.GustaJugarBeneficiado, c.GustaTenerBeneficiado).ToList()
        Else
            ' si la variable busqueda o el txtBuscar tiene texto pues procede a realizar la busqueda
            grid.DataSource = (From c In cnn.InteresesBeneficiados
                               Join b In cnn.Beneficiados On b.IdBeneficiado Equals c.IdBeneficiado
                               Order By c.IdIntereseBeneficiado
                               Where b.NombreBeneficiado.Contains(busqueda)
                               Select c.IdIntereseBeneficiado, b.IdBeneficiado, b.NombreBeneficiado, b.ApellidoBeneficiado,
                                   c.GustaComerBeneficiado, c.GustaJugarBeneficiado, c.GustaTenerBeneficiado).ToList()
        End If
        grid.Columns(0).Visible = False

    End Sub
    'pasar datos de la dat grid de InteresesBeneficiado a los textbox de InteresesBeneficado
    Shared Sub CargarDatosInteresesBeneficiado(id As String, txt1 As TextBox, txt2 As TextBox, txt3 As TextBox,
                                               txt4 As TextBox, txt5 As TextBox)
        Dim datos = (From c In cnn.InteresesBeneficiados
                     Join b In cnn.Beneficiados On b.IdBeneficiado Equals c.IdBeneficiado
                     Order By c.IdIntereseBeneficiado
                     Where c.IdIntereseBeneficiado = id
                     Select c.IdIntereseBeneficiado, c.GustaComerBeneficiado, c.GustaJugarBeneficiado, c.GustaTenerBeneficiado,
                         b.IdBeneficiado, b.NombreBeneficiado, b.ApellidoBeneficiado).SingleOrDefault()
        txt1.Text = datos.GustaComerBeneficiado
        txt2.Text = datos.GustaJugarBeneficiado
        txt3.Text = datos.GustaTenerBeneficiado
        txt4.Text = datos.IdBeneficiado
        txt5.Text = datos.NombreBeneficiado + " " + datos.ApellidoBeneficiado
    End Sub

    '--------------- FORMULARIO ADOPCION  -------------
    ' Cargar los datos de sql al dat grid de Beneficiado para mostrar en el formulario de Adopcion

    Shared Sub CargarBeneficiadoAdopcion(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then
            'si la funcion cargar no se le manda el parametro de busqueda osea que no tiene nada el txtBuscar muesta todos los datos en el grid
            grid.DataSource = (From a In cnn.Beneficiados
                               Order By a.IdBeneficiado
                               Select a.IdBeneficiado, Nombre_Beneficiado = a.NombreBeneficiado + " " + a.ApellidoBeneficiado).ToList()
        Else
            ' si la variable busqueda o el txtBuscar tiene texto pues procede a realizar la busqueda
            grid.DataSource = (From a In cnn.Beneficiados
                               Order By a.IdBeneficiado
                               Where a.NombreBeneficiado.Contains(busqueda)
                               Select a.IdBeneficiado, Nombre_Beneficiado = a.NombreBeneficiado + " " + a.ApellidoBeneficiado).ToList()
        End If

    End Sub

    'pasar datos de la dat grid de Beneficiado a los textbox de Adopcion
    Shared Sub CargarDatosBeneficidoAdopcion(id As String, txt1 As TextBox)
        Dim datos = (From a In cnn.Beneficiados
                     Order By a.IdBeneficiado
                     Where a.IdBeneficiado = id
                     Select a).SingleOrDefault()
        txt1.Text = datos.NombreBeneficiado + " " + datos.ApellidoBeneficiado
    End Sub

    ' Cargar los datos de sql al dat grid de Sponsor  para mostrar en el formulario de Adopcion

    Shared Sub CargarSponsorAdopcion(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then
            'si la funcion cargar no se le manda el parametro de busqueda osea que no tiene nada el txtBuscar muesta todos los datos en el grid
            grid.DataSource = (From a In cnn.Sponsors
                               Order By a.IdSponsor
                               Select a.IdSponsor, a.NombreCompletoSponsor).ToList()
        Else
            ' si la variable busqueda o el txtBuscar tiene texto pues procede a realizar la busqueda
            grid.DataSource = (From a In cnn.Sponsors
                               Order By a.IdSponsor
                               Where a.NombreCompletoSponsor.Contains(busqueda)
                               Select a.IdSponsor, a.NombreCompletoSponsor).ToList()
        End If

    End Sub

    'pasar datos de la dat grid de Sponsor a los textbox de Adopcion
    Shared Sub CargarDatosSponsorAdopncion(id As String, txt1 As TextBox)
        Dim datos = (From a In cnn.Sponsors
                     Order By a.IdSponsor
                     Where a.IdSponsor = id
                     Select a.IdSponsor, a.NombreCompletoSponsor).SingleOrDefault()
        txt1.Text = datos.NombreCompletoSponsor
    End Sub

    ' Cargar los datos de sql al dat grid de Adopcion para mostrar en el formulario de Adopcion
    Shared Sub CargarAdopcion(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then
            'si la funcion cargar no se le manda el parametro de busqueda osea que no tiene nada el txtBuscar muesta
            'todos los datos en el grid
            grid.DataSource = (From a In cnn.Adopcions
                               Join b In cnn.Beneficiados On a.IdBeneficiado Equals b.IdBeneficiado
                               Join c In cnn.Sponsors On a.IdSponsor Equals c.IdSponsor
                               Join d In cnn.TipoPagoAdopcions On d.IdTipoPagoAdopcion Equals a.IdTipoPagoAdopcion
                               Join e In cnn.EstadoAdopcions On a.IdEstadoAdopcion Equals e.IdEstadoAdopcion
                               Join f In cnn.Usuarios On a.IdUsuario Equals f.IdUsuario
                               Order By b.IdBeneficiado
                               Select a.IdAdopcion, a.IdBeneficiado, Nombre_Beneficiado = b.NombreBeneficiado + "" + b.ApellidoBeneficiado, a.IdSponsor,
                                   c.NombreCompletoSponsor, a.FechaAdopcion, a.Observacion, a.Valor, a.IdTipoPagoAdopcion, d.TipoPagoAdopcion,
                                   a.IdEstadoAdopcion, e.EstadoAdopcion, a.IdUsuario, f.NombreUsuario).ToList()
        Else
            ' si la variable busqueda o el txtBuscar tiene texto pues procede a realizar la busqueda
            grid.DataSource = (From a In cnn.Adopcions
                               Join b In cnn.Beneficiados On b.IdBeneficiado Equals a.IdBeneficiado
                               Join c In cnn.Sponsors On a.IdSponsor Equals c.IdSponsor
                               Join d In cnn.TipoPagoAdopcions On d.IdTipoPagoAdopcion Equals a.IdTipoPagoAdopcion
                               Join e In cnn.EstadoAdopcions On e.IdEstadoAdopcion Equals a.IdEstadoAdopcion
                               Join f In cnn.Usuarios On f.IdUsuario Equals a.IdUsuario
                               Order By b.IdBeneficiado
                               Where b.NombreBeneficiado.Contains(busqueda)
                               Select a.IdAdopcion, a.IdBeneficiado, Nombre_Beneficiado = b.NombreBeneficiado + "" + b.ApellidoBeneficiado, a.IdSponsor,
                                   c.NombreCompletoSponsor, a.FechaAdopcion, a.Observacion, a.Valor, a.IdTipoPagoAdopcion, d.TipoPagoAdopcion,
                                   a.IdEstadoAdopcion, e.EstadoAdopcion, a.IdUsuario, f.NombreUsuario).ToList()
        End If
        grid.Columns(0).Visible = False
        grid.Columns(8).Visible = False
        grid.Columns(10).Visible = False
        grid.Columns(12).Visible = False
    End Sub
    'pasar datos de la dat grid de Adopcion  a los textbox de Adopcion
    Shared Sub CargarDatosAdopcion(id As String, txt1 As TextBox, txt2 As DateTimePicker, txt3 As TextBox,
                                               txt4 As TextBox, txt5 As TextBox, txt6 As TextBox,
                                   txt7 As TextBox, cbo1 As ComboBox, cbo2 As ComboBox)

        Dim datos = (From a In cnn.Adopcions
                     Join b In cnn.Beneficiados On b.IdBeneficiado Equals a.IdBeneficiado
                     Join c In cnn.Sponsors On c.IdSponsor Equals a.IdSponsor
                     Join d In cnn.TipoPagoAdopcions On d.IdTipoPagoAdopcion Equals a.IdTipoPagoAdopcion
                     Join e In cnn.EstadoAdopcions On e.IdEstadoAdopcion Equals a.IdEstadoAdopcion
                     Order By a.IdAdopcion
                     Where a.IdAdopcion = id
                     Select a.IdAdopcion, b.IdBeneficiado, b.NombreBeneficiado, b.ApellidoBeneficiado, c.IdSponsor,
                                   c.NombreCompletoSponsor, a.FechaAdopcion, a.Observacion, a.Valor, d.IdTipoPagoAdopcion, d.TipoPagoAdopcion,
                                   e.IdEstadoAdopcion, e.EstadoAdopcion).SingleOrDefault()
        txt1.Text = datos.Observacion
        txt2.Text = datos.FechaAdopcion
        txt3.Text = FormatCurrency(datos.Valor, 2)
        txt4.Text = datos.IdBeneficiado
        txt5.Text = datos.NombreBeneficiado + " " + datos.ApellidoBeneficiado
        txt6.Text = datos.IdSponsor
        txt7.Text = datos.NombreCompletoSponsor
        cbo1.SelectedValue = CInt(datos.IdEstadoAdopcion)
        cbo2.SelectedValue = CInt(datos.IdTipoPagoAdopcion)

    End Sub
    '-------------------Formulario Ofrenda------------------------------------

    ' Cargar los datos de sql al dat grid de BuscarAdopcion para mostrar en el formulario de Ofrenda
    Shared Sub CargarAdopcionOfrenda(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then
            'si la funcion cargar no se le manda el parametro de busqueda osea que no tiene nada el txtBuscar muesta
            'todos los datos en el grid
            grid.DataSource = (From a In cnn.Adopcions
                               Join b In cnn.Beneficiados On a.IdBeneficiado Equals b.IdBeneficiado
                               Join c In cnn.Sponsors On a.IdSponsor Equals c.IdSponsor
                               Order By a.IdAdopcion
                               Select a.IdAdopcion, b.IdBeneficiado, Nombre_Beneficiado = b.NombreBeneficiado + "" + b.ApellidoBeneficiado, c.IdSponsor,
                                   c.NombreCompletoSponsor).ToList()
        Else
            ' si la variable busqueda o el txtBuscar tiene texto pues procede a realizar la busqueda
            grid.DataSource = (From a In cnn.Adopcions
                               Join b In cnn.Beneficiados On b.IdBeneficiado Equals a.IdBeneficiado
                               Join c In cnn.Sponsors On a.IdSponsor Equals c.IdSponsor
                               Order By a.IdAdopcion
                               Where b.NombreBeneficiado.Contains(busqueda)
                               Select a.IdAdopcion, b.IdBeneficiado, Nombre_Beneficiado = b.NombreBeneficiado + "" + b.ApellidoBeneficiado, c.IdSponsor,
                                   c.NombreCompletoSponsor).ToList()
        End If
        grid.Columns(0).Visible = False
    End Sub
    'pasar datos de la dat grid de Adopcion  a los textbox de Ofrenda
    Shared Sub CargarDatosAdopcionOfrenda(id As String, txt1 As TextBox, txt2 As TextBox, txt3 As TextBox,
                                               txt4 As TextBox)

        Dim datos = (From a In cnn.Adopcions
                     Join b In cnn.Beneficiados On b.IdBeneficiado Equals a.IdBeneficiado
                     Join c In cnn.Sponsors On c.IdSponsor Equals a.IdSponsor
                     Order By a.IdAdopcion
                     Where a.IdAdopcion = id
                     Select a.IdAdopcion, b.IdBeneficiado, b.NombreBeneficiado, b.ApellidoBeneficiado, c.IdSponsor,
                                   c.NombreCompletoSponsor).SingleOrDefault()
        txt1.Text = datos.IdBeneficiado
        txt2.Text = datos.NombreBeneficiado + " " + datos.ApellidoBeneficiado
        txt4.Text = datos.NombreCompletoSponsor
        txt3.Text = datos.IdSponsor

    End Sub

    ' Cargar los datos de sql al dat grid de Adopcion para mostrar en el formulario de Ofrenda

    Shared Sub CargarOfrenda(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then
            'si la funcion cargar no se le manda el parametro de busqueda osea que no tiene nada el txtBuscar muesta
            'todos los datos en el grid
            grid.DataSource = (From f In cnn.Ofrendas
                               Join a In cnn.Adopcions On f.IdAdopcion Equals a.IdAdopcion
                               Join b In cnn.Beneficiados On a.IdBeneficiado Equals b.IdBeneficiado
                               Join c In cnn.Sponsors On a.IdSponsor Equals c.IdSponsor
                               Join d In cnn.TipoOfrendas On d.IdTipoOfrenda Equals f.IdTipoOfrenda
                               Order By f.IdOfrenda
                               Select f.IdOfrenda, a.IdAdopcion, b.IdBeneficiado, Nombre_Beneficiado = b.NombreBeneficiado + "" + b.ApellidoBeneficiado, c.IdSponsor,
                                   c.NombreCompletoSponsor, f.FechaRecibida, f.fechaEntregado, f.DescripcionOfrenda, d.IdTipoOfrenda, d.TipoOfrenda).ToList()
        Else
            ' si la variable busqueda o el txtBuscar tiene texto pues procede a realizar la busqueda
            grid.DataSource = (From f In cnn.Ofrendas
                               Join a In cnn.Adopcions On f.IdAdopcion Equals a.IdAdopcion
                               Join b In cnn.Beneficiados On a.IdBeneficiado Equals b.IdBeneficiado
                               Join c In cnn.Sponsors On a.IdSponsor Equals c.IdSponsor
                               Join d In cnn.TipoOfrendas On d.IdTipoOfrenda Equals f.IdTipoOfrenda
                               Order By f.IdOfrenda
                               Where b.NombreBeneficiado.Contains(busqueda)
                               Select f.IdOfrenda, a.IdAdopcion, b.IdBeneficiado, Nombre_Beneficiado = b.NombreBeneficiado + "" + b.ApellidoBeneficiado, c.IdSponsor,
                                   c.NombreCompletoSponsor, f.FechaRecibida, f.fechaEntregado, f.DescripcionOfrenda, d.IdTipoOfrenda, d.TipoOfrenda).ToList()
        End If
        grid.Columns(0).Visible = False
        grid.Columns(1).Visible = False
        grid.Columns(9).Visible = False
    End Sub
    'pasar datos de la dat grid de Adopcion  a los textbox de Ofrenda
    Shared Sub CargarDatosOfrenda(id As String, txt1 As TextBox, txt2 As DateTimePicker, txt3 As DateTimePicker,
                                               txt4 As TextBox, txt5 As TextBox, txt6 As TextBox,
                                   txt7 As TextBox, txt8 As TextBox, cbo1 As ComboBox)

        Dim datos = (From f In cnn.Ofrendas
                     Join a In cnn.Adopcions On f.IdAdopcion Equals a.IdAdopcion
                     Join b In cnn.Beneficiados On a.IdBeneficiado Equals b.IdBeneficiado
                     Join c In cnn.Sponsors On a.IdSponsor Equals c.IdSponsor
                     Join d In cnn.TipoOfrendas On d.IdTipoOfrenda Equals f.IdTipoOfrenda
                     Order By f.IdOfrenda
                     Where f.IdOfrenda = id
                     Select f.IdOfrenda, a.IdAdopcion, b.IdBeneficiado, b.NombreBeneficiado, b.ApellidoBeneficiado, c.IdSponsor,
                          c.NombreCompletoSponsor, f.FechaRecibida, f.fechaEntregado, f.DescripcionOfrenda, f.IdTipoOfrenda, d.TipoOfrenda).SingleOrDefault()
        txt1.Text = datos.DescripcionOfrenda
        txt2.Text = datos.FechaRecibida
        txt3.Text = datos.fechaEntregado
        txt4.Text = datos.IdAdopcion
        txt5.Text = datos.IdBeneficiado
        txt6.Text = datos.NombreBeneficiado + " " + datos.ApellidoBeneficiado
        txt7.Text = datos.IdSponsor
        txt8.Text = datos.NombreCompletoSponsor
        cbo1.SelectedValue = CInt(datos.IdTipoOfrenda)

    End Sub
    '-------------------Formulario Usuario------------------------------------

    ' Cargar los datos de sql al dat grid de BuscarAdopcion para mostrar en el formulario de Ofrenda
    Shared Sub CargarUsuario(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then
            'si la funcion cargar no se le manda el parametro de busqueda osea que no tiene nada el txtBuscar muesta
            'todos los datos en el grid
            grid.DataSource = (From a In cnn.Usuarios
                               Join c In cnn.EstadoUsuarios On a.IdEstadoUsuario Equals c.IdEstadoUsuario
                               Order By a.IdUsuario
                               Select a.IdUsuario, a.NombreUsuario, a.Contraseña, c.IdEstadoUsuario, c.EstadoUsuario).ToList()
        Else
            ' si la variable busqueda o el txtBuscar tiene texto pues procede a realizar la busqueda
            grid.DataSource = (From a In cnn.Usuarios
                               Join c In cnn.EstadoUsuarios On a.IdEstadoUsuario Equals c.IdEstadoUsuario
                               Order By a.IdUsuario
                               Where a.NombreUsuario.Contains(busqueda)
                               Select a.IdUsuario, a.NombreUsuario, a.Contraseña, c.IdEstadoUsuario, c.EstadoUsuario).ToList()
        End If
        grid.Columns(0).Visible = False
        grid.Columns(3).Visible = False
    End Sub
    Shared Sub CargarDatosUsuario(id As String, txt1 As TextBox, txt2 As TextBox, cbo1 As ComboBox)

        Dim datos = (From a In cnn.Usuarios
                     Join c In cnn.EstadoUsuarios On a.IdEstadoUsuario Equals c.IdEstadoUsuario
                     Order By a.IdUsuario
                     Where a.IdUsuario = id
                     Select a.IdUsuario, a.NombreUsuario, a.Contraseña, c.IdEstadoUsuario, c.EstadoUsuario).SingleOrDefault()
        txt1.Text = datos.NombreUsuario
        txt2.Text = datos.Contraseña
        cbo1.SelectedValue = CInt(datos.IdEstadoUsuario)

    End Sub
    '-------------------Formulario AdopcionPago------------------------------------

    ' Cargar los datos de sql al dat grid de BuscarAdopcion para mostrar en el formulario de Ofrenda
    Shared Sub CargarAdopcionParaPago(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then
            'si la funcion cargar no se le manda el parametro de busqueda osea que no tiene nada el txtBuscar muesta
            'todos los datos en el grid
            grid.DataSource = (From a In cnn.Adopcions
                               Join b In cnn.Beneficiados On a.IdBeneficiado Equals b.IdBeneficiado
                               Join c In cnn.Sponsors On a.IdSponsor Equals c.IdSponsor
                               Order By a.IdAdopcion
                               Select a.IdAdopcion, b.IdBeneficiado, Nombre_Beneficiado = b.NombreBeneficiado + "" + b.ApellidoBeneficiado, c.IdSponsor,
                                   c.NombreCompletoSponsor).ToList()
        Else
            ' si la variable busqueda o el txtBuscar tiene texto pues procede a realizar la busqueda
            grid.DataSource = (From a In cnn.Adopcions
                               Join b In cnn.Beneficiados On b.IdBeneficiado Equals a.IdBeneficiado
                               Join c In cnn.Sponsors On a.IdSponsor Equals c.IdSponsor
                               Order By b.IdBeneficiado
                               Where b.NombreBeneficiado.Contains(busqueda)
                               Select a.IdAdopcion, b.IdBeneficiado, Nombre_Beneficiado = b.NombreBeneficiado + "" + b.ApellidoBeneficiado, c.IdSponsor,
                                   c.NombreCompletoSponsor).ToList()
        End If
        grid.Columns(0).Visible = False
    End Sub
    'pasar datos de la dat grid de Adopcion  a los textbox de Ofrenda
    Shared Sub CargarDatosAdopcionParaPago(id As String, txt1 As TextBox, txt2 As TextBox, txt3 As TextBox,
                                               txt4 As TextBox)

        Dim datos = (From a In cnn.Adopcions
                     Join b In cnn.Beneficiados On b.IdBeneficiado Equals a.IdBeneficiado
                     Join c In cnn.Sponsors On c.IdSponsor Equals a.IdSponsor
                     Order By b.IdBeneficiado
                     Where a.IdAdopcion = id
                     Select a.IdAdopcion, b.IdBeneficiado, b.NombreBeneficiado, b.ApellidoBeneficiado, c.IdSponsor,
                                   c.NombreCompletoSponsor).SingleOrDefault()
        txt1.Text = datos.IdBeneficiado
        txt2.Text = datos.NombreBeneficiado + " " + datos.ApellidoBeneficiado
        txt4.Text = datos.NombreCompletoSponsor
        txt3.Text = datos.IdSponsor

    End Sub
    Shared Sub CargarAdopcionPago(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then
            'si la funcion cargar no se le manda el parametro de busqueda osea que no tiene nada el txtBuscar muesta
            'todos los datos en el grid
            grid.DataSource = (From d In cnn.AdopcionPagos
                               Join a In cnn.Adopcions On a.IdAdopcion Equals d.Idadopcion
                               Join b In cnn.Beneficiados On a.IdBeneficiado Equals b.IdBeneficiado
                               Join c In cnn.Sponsors On a.IdSponsor Equals c.IdSponsor
                               Order By a.IdAdopcion
                               Select d.IdAdopcionPago, a.IdAdopcion, b.IdBeneficiado, Nombre_Beneficiado = b.NombreBeneficiado + "" + b.ApellidoBeneficiado, c.IdSponsor,
                                   c.NombreCompletoSponsor, d.FechaPago, d.Valor).ToList()
        Else
            ' si la variable busqueda o el txtBuscar tiene texto pues procede a realizar la busqueda
            grid.DataSource = (From d In cnn.AdopcionPagos
                               Join a In cnn.Adopcions On a.IdAdopcion Equals d.Idadopcion
                               Join b In cnn.Beneficiados On a.IdBeneficiado Equals b.IdBeneficiado
                               Join c In cnn.Sponsors On a.IdSponsor Equals c.IdSponsor
                               Order By a.IdAdopcion
                               Where b.NombreBeneficiado.Contains(busqueda)
                               Select a.IdAdopcion, b.IdBeneficiado, Nombre_Beneficiado = b.NombreBeneficiado + "" + b.ApellidoBeneficiado, c.IdSponsor,
                                   c.NombreCompletoSponsor, d.FechaPago, d.Valor).ToList()
        End If
        grid.Columns(0).Visible = False
    End Sub
    'pasar datos de la dat grid de Adopcion  a los textbox de Ofrenda
    Shared Sub CargarDatosAdopcionPago(id As String, txt1 As TextBox, txt2 As TextBox, txt3 As TextBox,
                                               txt4 As TextBox, txt5 As TextBox, txt6 As DateTimePicker, txt7 As TextBox)

        Dim datos = (From d In cnn.AdopcionPagos
                     Join a In cnn.Adopcions On a.IdAdopcion Equals d.Idadopcion
                     Join b In cnn.Beneficiados On a.IdBeneficiado Equals b.IdBeneficiado
                     Join c In cnn.Sponsors On a.IdSponsor Equals c.IdSponsor
                     Order By d.IdAdopcionPago
                     Where d.IdAdopcionPago = id
                     Select d.IdAdopcionPago, a.IdAdopcion, b.IdBeneficiado, b.NombreBeneficiado, b.ApellidoBeneficiado, c.IdSponsor,
                                   c.NombreCompletoSponsor, d.FechaPago, d.Valor).SingleOrDefault()
        txt1.Text = datos.IdAdopcionPago
        txt2.Text = datos.IdBeneficiado
        txt3.Text = datos.NombreBeneficiado + " " + datos.ApellidoBeneficiado
        txt4.Text = datos.NombreCompletoSponsor
        txt5.Text = datos.IdSponsor
        txt6.Text = datos.FechaPago
        txt7.Text = FormatCurrency(datos.Valor, 2)

    End Sub
    '-------------------Formulario  Cartas------------------------------------

    ' Cargar los datos de sql al dat grid de BuscarCartas para mostrar en el formulario de Caetas
    Shared Sub CargarCartas(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then
            'si la funcion cargar no se le manda el parametro de busqueda osea que no tiene nada el txtBuscar muesta
            'todos los datos en el grid
            grid.DataSource = (From a In cnn.Cartas
                               Join d In cnn.Adopcions On a.IdAdopcion Equals d.IdAdopcion
                               Join b In cnn.Beneficiados On d.IdBeneficiado Equals b.IdBeneficiado
                               Join c In cnn.Sponsors On d.IdSponsor Equals c.IdSponsor
                               Join e In cnn.RemitenteDestinatarios On a.Remitente Equals e.IdRemitenteDestinatario
                               Join f In cnn.RemitenteDestinatarios On a.Destinatario Equals f.IdRemitenteDestinatario
                               Join g In cnn.TipoCartas On a.IdTipoCarta Equals g.IdTipoCarta
                               Order By a.IdCarta
                               Select a.IdCarta, d.IdAdopcion, b.IdBeneficiado, Nombre_Beneficiado = b.NombreBeneficiado + "" + b.ApellidoBeneficiado,
                                   c.IdSponsor, c.NombreCompletoSponsor, a.Descripcion, a.FechaEntrega, a.Remitente, a.Destinatario, e.IdRemitenteDestinatario,
                                   e.RemitenteDestinatario, g.IdTipoCarta, g.TipoCarta).ToList()
        Else
            ' si la variable busqueda o el txtBuscar tiene texto pues procede a realizar la busqueda
            grid.DataSource = (From a In cnn.Cartas
                               Join d In cnn.Adopcions On a.IdAdopcion Equals d.IdAdopcion
                               Join b In cnn.Beneficiados On d.IdBeneficiado Equals b.IdBeneficiado
                               Join c In cnn.Sponsors On d.IdSponsor Equals c.IdSponsor
                               Join e In cnn.RemitenteDestinatarios On a.Remitente Equals e.IdRemitenteDestinatario
                               Join f In cnn.RemitenteDestinatarios On a.Destinatario Equals f.IdRemitenteDestinatario
                               Join g In cnn.TipoCartas On a.IdTipoCarta Equals g.IdTipoCarta
                               Order By a.IdCarta
                               Where b.NombreBeneficiado.Contains(busqueda)
                               Select a.IdCarta, d.IdAdopcion, b.IdBeneficiado, Nombre_Beneficiado = b.NombreBeneficiado + "" + b.ApellidoBeneficiado,
                                   c.IdSponsor, c.NombreCompletoSponsor, a.Descripcion, a.FechaEntrega, a.Remitente, a.Destinatario, e.IdRemitenteDestinatario,
                                    g.IdTipoCarta, g.TipoCarta).ToList()
        End If

        grid.Columns(0).Visible = False
        grid.Columns(8).Visible = False
        grid.Columns(9).Visible = False
        grid.Columns(10).Visible = False
        grid.Columns(11).Visible = False
        grid.Columns(12).Visible = False
    End Sub
    Shared Sub CargarDatosCartas(id As String, txt1 As TextBox, txt2 As TextBox, txt3 As TextBox,
                                               txt4 As TextBox, txt5 As TextBox, txt6 As DateTimePicker,
                                               txt7 As TextBox, cbo As ComboBox, cbo1 As ComboBox,
                                                cbo2 As ComboBox)

        Dim datos = (From a In cnn.Cartas
                     Join d In cnn.Adopcions On a.IdAdopcion Equals d.IdAdopcion
                     Join b In cnn.Beneficiados On d.IdBeneficiado Equals b.IdBeneficiado
                     Join c In cnn.Sponsors On d.IdSponsor Equals c.IdSponsor
                     Join e In cnn.RemitenteDestinatarios On a.Remitente Equals e.IdRemitenteDestinatario
                     Join f In cnn.RemitenteDestinatarios On a.Destinatario Equals f.IdRemitenteDestinatario
                     Join g In cnn.TipoCartas On a.IdTipoCarta Equals g.IdTipoCarta
                     Order By a.IdCarta
                     Where a.IdCarta = id
                     Select a.IdCarta, d.IdAdopcion, b.IdBeneficiado, b.NombreBeneficiado, b.ApellidoBeneficiado, c.IdSponsor,
                                   c.NombreCompletoSponsor, a.Descripcion, a.FechaEntrega, a.Remitente, a.Destinatario, e.IdRemitenteDestinatario,
                         e.RemitenteDestinatario, g.IdTipoCarta, g.TipoCarta).SingleOrDefault()
        txt1.Text = datos.IdAdopcion
        txt2.Text = datos.IdBeneficiado
        txt3.Text = datos.NombreBeneficiado + " " + datos.ApellidoBeneficiado
        txt4.Text = datos.NombreCompletoSponsor
        txt5.Text = datos.IdSponsor
        txt6.Text = datos.FechaEntrega
        txt7.Text = datos.Descripcion
        cbo.SelectedValue = CInt(datos.Remitente)
        cbo1.SelectedValue = CInt(datos.Destinatario)
        cbo2.SelectedValue = CInt(datos.IdTipoCarta)
    End Sub
    ' Cargar los datos de sql al dat grid de BuscarAdopcion para mostrar en el formulario de Ofrenda
    Shared Sub CargarAdopcionCartas(grid As DataGridView, Optional busqueda As String = "")
        If busqueda = "" Then
            'si la funcion cargar no se le manda el parametro de busqueda osea que no tiene nada el txtBuscar muesta
            'todos los datos en el grid
            grid.DataSource = (From a In cnn.Adopcions
                               Join b In cnn.Beneficiados On a.IdBeneficiado Equals b.IdBeneficiado
                               Join c In cnn.Sponsors On a.IdSponsor Equals c.IdSponsor
                               Order By a.IdAdopcion
                               Select a.IdAdopcion, b.IdBeneficiado, Nombre_Beneficiado = b.NombreBeneficiado + "" + b.ApellidoBeneficiado, c.IdSponsor,
                                   c.NombreCompletoSponsor).ToList()
        Else
            ' si la variable busqueda o el txtBuscar tiene texto pues procede a realizar la busqueda
            grid.DataSource = (From a In cnn.Adopcions
                               Join b In cnn.Beneficiados On b.IdBeneficiado Equals a.IdBeneficiado
                               Join c In cnn.Sponsors On a.IdSponsor Equals c.IdSponsor
                               Order By b.IdBeneficiado
                               Where b.NombreBeneficiado.Contains(busqueda)
                               Select a.IdAdopcion, b.IdBeneficiado, Nombre_Beneficiado = b.NombreBeneficiado + "" + b.ApellidoBeneficiado, c.IdSponsor,
                                   c.NombreCompletoSponsor).ToList()
        End If
        grid.Columns(0).Visible = False
    End Sub
    'pasar datos de la dat grid de Adopcion  a los textbox de Ofrenda
    Shared Sub CargarDatosAdopcionCartas(id As String, txt1 As TextBox, txt2 As TextBox, txt3 As TextBox,
                                               txt4 As TextBox)

        Dim datos = (From a In cnn.Adopcions
                     Join b In cnn.Beneficiados On b.IdBeneficiado Equals a.IdBeneficiado
                     Join c In cnn.Sponsors On c.IdSponsor Equals a.IdSponsor
                     Order By b.IdBeneficiado
                     Where a.IdAdopcion = id
                     Select a.IdAdopcion, b.IdBeneficiado, b.NombreBeneficiado, b.ApellidoBeneficiado, c.IdSponsor,
                                   c.NombreCompletoSponsor).SingleOrDefault()
        txt1.Text = datos.IdBeneficiado
        txt2.Text = datos.NombreBeneficiado + " " + datos.ApellidoBeneficiado
        txt4.Text = datos.NombreCompletoSponsor
        txt3.Text = datos.IdSponsor

    End Sub


End Class