Imports System.Data
Imports System.Data.SqlClient
Public Class FrmTutor

    ' importa la interfax llamada IForm que contiene el constructor
    Implements IForm
    'crea una subproceso que no importa el nombre pero puede escribir uno que identifique que va obtener , si un id, una cuenta,  una serie o lo que sea
    'esto que sta IForm.ObtenerId es el constructor que esta en el archivo IForm este lo puede reutilizar y solo cambia el nombre del subproceso
    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        TextBox1.Text = id
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'aqui muestra el formulario de busqueda
        Dim frm As New BuscTutor()
        frm.Show(Me)
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        'esto de aqui es lo que permite obtener los datos desde el gridview solo llama a la clase AccederDatos.CargarDatosTutor(y manda los textbox y combobox)
        If TextBox1.Text <> "" Then
            accesodatos.CargarDatosTutor(TextBox1.Text, TxtNombre, TxtApellido, TxtNumeroT, TxtFechaNac,
                                         TxtSalario, TxtNumeroC, TxtDireccion, CboOficio, CboSexo,
                                         CboIglesia, CboLugar, CboParentesco)
        End If
    End Sub

    Public Sub Combobox()
        'cambiar combobox por llenarlos desde la tabla en sql'
        Dim dt = (From o In cnn.OficioProfesions
                  Select o.IdOficioProfesion, o.OficioProfesion).ToList
        Me.CboOficio.DataSource = dt
        Me.CboOficio.DisplayMember = "OficioProfesion"
        Me.CboOficio.ValueMember = "IdOficioProfesion"
        Me.CboOficio.SelectedIndex = -1
        Me.CboOficio.Text = "--Seleccione--"
    End Sub

    Public Sub LlenarComboboxLugar()

        Dim datos = (From p In cnn.Lugars
                     Select p.IdLugar, p.Lugar).ToList
        Me.CboLugar.DataSource = datos

        Me.CboLugar.ValueMember = "IdLugar"
        Me.CboLugar.DisplayMember = "Lugar"
        Me.CboLugar.SelectedIndex = -1
        Me.CboLugar.Text = "--seleccione--"

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
                     Select a.IdIglesia, a.Iglesia).ToList
        Me.CboIglesia.DataSource = datos

        Me.CboIglesia.ValueMember = "IdIglesia"
        Me.CboIglesia.DisplayMember = "Iglesia"
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
    Private Sub frmTutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Combobox()
        Call LlenarComboboxLugar()
        Call LlenarSexo()
        Call LlenarIglesia()
        Call LlenarParentesco()
    End Sub
    Public Sub GuardarN()
        Dim t As New Tutor With
            {.NombreTutor = TxtNombre.Text,
            .ApellidoTutor = TxtApellido.Text,
            .Telefono = TxtNumeroT.Text,
             .Direccion = TxtDireccion.Text,
              .FechaNac = CDate(TxtFechaNac.Text),
            .SalarioDia = CDbl(TxtSalario.Text),
             .Celular = TxtNumeroC.Text,
            .IdOficioProfesion = CInt(Me.CboOficio.SelectedValue),
            .IdSexo = CInt(Me.CboSexo.SelectedValue),
            .IdIglesia = CInt(Me.CboIglesia.SelectedValue),
            .IdLugar = CInt(Me.CboLugar.SelectedValue),
            .IdParentesco = CInt(Me.CboParentesco.SelectedValue),
            .IdUsuario = IdUsuarioSistemaActual
           }

        Try
            cnn.Tutors.InsertOnSubmit(t)
            cnn.SubmitChanges()
            MsgBox("correcto")
        Catch ex As Exception
            MsgBox(String.Format("Error: {0}", ex))
        End Try
    End Sub



    Public Sub Nuevo()
        ' TextBox1.Text = ""
        TxtNombre.Text = ""
        TxtApellido.Text = ""
        TxtNumeroT.Text = ""
        TxtNumeroC.Text = ""
        TxtFechaNac.Text = ""
        TxtDireccion.Text = ""
        TxtSalario.Text = ""
        CboOficio.SelectedIndex = -1
        CboSexo.SelectedIndex = -1
        CboLugar.SelectedIndex = -1
        CboIglesia.SelectedIndex = -1
        CboParentesco.SelectedIndex = -1
    End Sub

    Public Sub ActualizarDatos(id As Integer)

        Dim datos As Tutor = (From g In cnn.Tutors
                              Where g.IdTutor = id
                              Select g).ToList()(0)
        datos.NombreTutor = TxtNombre.Text
        datos.ApellidoTutor = TxtApellido.Text
        datos.Telefono = TxtNumeroT.Text
        datos.Celular = TxtNumeroC.Text
        datos.FechaNac = CDate(TxtFechaNac.Text)
        datos.Direccion = TxtDireccion.Text
        datos.SalarioDia = TxtSalario.Text
        datos.IdOficioProfesion = CInt(CboOficio.SelectedValue)
        datos.IdSexo = CInt(CboSexo.SelectedValue)
        datos.IdLugar = CInt(CboLugar.SelectedValue)
        datos.IdIglesia = CInt(CboIglesia.SelectedValue)
        datos.IdParentesco = CInt(CboParentesco.SelectedValue)

        Try
            cnn.SubmitChanges()
            MsgBox("correcto")

        Catch ex As Exception
            MsgBox("error")
        End Try
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        GuardarN()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Call ActualizarDatos(CInt(TextBox1.Text))
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove
        PictureBox3.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Size = New Size(49, 51)
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

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles BtnGuardar.MouseLeave
        BtnGuardar.Size = New Size(49, 51)
    End Sub



    Private Sub PictureBox4_MouseMove(sender As Object, e As MouseEventArgs) Handles Btnuevo.MouseMove
        Btnuevo.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox4_MouseLeave(sender As Object, e As EventArgs) Handles Btnuevo.MouseLeave
        Btnuevo.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles BtnGuardar.MouseMove
        BtnGuardar.Size = New Size(58, 59)
    End Sub

    Private Sub Btnuevo_Click(sender As Object, e As EventArgs) Handles Btnuevo.Click
        Call InvestigarCorrelativo()
        Call Nuevo()

    End Sub
    Sub InvestigarCorrelativo()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            Dim Listarnacionalidad As New SqlCommand("Sp_TutorIdentity", cn)
            Listarnacionalidad.CommandType = CommandType.StoredProcedure
            Dim Listarnacionalidades As SqlDataReader
            cn.Open()
            Listarnacionalidades = Listarnacionalidad.ExecuteReader()
            If Listarnacionalidades.Read = True Then
                If Listarnacionalidades("Id") Is DBNull.Value Then
                    TextBox1.Text = 1
                Else
                    TextBox1.Text = Listarnacionalidades("Id").ToString
                End If
            End If
        Catch ex As Exception
        End Try
        TextBox1.Focus()
    End Sub
End Class