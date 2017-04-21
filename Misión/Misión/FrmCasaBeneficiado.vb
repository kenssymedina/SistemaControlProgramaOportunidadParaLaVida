Imports System.Data.SqlClient
Imports System.Data

Public Class FrmCasaBeneficiado
    Implements IForm, IForm2

    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        TxtNumeroBeneficiado.Text = id
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtNumeroBeneficiado.TextChanged
        If TxtNumeroBeneficiado.Text <> "" Then
            accesodatos.CargarDatosBeneficidoIntereses(TxtNumeroBeneficiado.Text, TxtNombreBeneficiado)
        End If
    End Sub

    Public Sub ObtenerIdSegundo(id As String) Implements IForm2.ObtenerIdSegundo
        txtIdCasa.Text = id
    End Sub
    Private Sub txtIdCasa_TextChanged(sender As Object, e As EventArgs) Handles txtIdCasa.TextChanged
        If txtIdCasa.Text <> "" Then
            accesodatos.CargarDatosCasaBeneficiado(txtIdCasa.Text, TxtCantidadDormi, TxtCantidadCamas, TxtCantidadHamacas, TxtCantidadRopa, TxtCantidadMesas, TxtCantidadSillas, TxtPiso, TxtNumeroBeneficiado, TxtNombreBeneficiado, CboTipoCasa)
        End If
    End Sub
    Public Sub LlenarTipoCasa()

        Dim datos = (From G In cnn.TipoCasas
                     Order By G.IdTipoCasa Ascending
                     Select G.IdTipoCasa, G.TipoCasa).ToList
        Me.CboTipoCasa.DataSource = datos
        Me.CboTipoCasa.ValueMember = "IdTipoCasa"
        Me.CboTipoCasa.DisplayMember = "TipoCasa"
        Me.CboTipoCasa.SelectedIndex = -1
        Me.CboTipoCasa.Text = "Seleccione"

    End Sub
    Private Sub FrmCasaBeneficiado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarTipoCasa()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'aqui muestra el formulario de busqueda
        Dim frm As New FrmBusquedaCasaBeneficiado()
        frm.Show(Me)
    End Sub

    Private Sub BtnData_Click(sender As Object, e As EventArgs) Handles BtnData.Click
        'aqui muestra el formulario de busqueda
        Dim frm As New FrmBuscarBeneficiadoIntereses()
        frm.Show(Me)
    End Sub

    Private Function Validar() As Boolean
        Dim Estado As Boolean
        If txtIdCasa.Text = Nothing And TxtCantidadDormi.Text = Nothing And TxtCantidadCamas.Text = Nothing And
            TxtCantidadHamacas.Text = Nothing And TxtCantidadRopa.Text = Nothing And TxtCantidadMesas.Text = Nothing And
            TxtCantidadSillas.Text = Nothing And TxtCantidadSillas.Text = Nothing And TxtPiso.Text = Nothing And TxtNumeroBeneficiado.Text = Nothing And
            CboTipoCasa.SelectedIndex = -1 Then
            MessageBox.Show("Ingrese los datos solicitados")
            TxtCantidadDormi.Focus()
            Estado = False
        ElseIf TxtCantidadDormi.Text = Nothing Then
            MessageBox.Show("Ingrese la Cantidad de Dormitorios")
            TxtCantidadDormi.Focus()
            Estado = False
        ElseIf TxtCantidadCamas.Text = Nothing Then
            MessageBox.Show("Ingrese la Cantidad de Camas")
            TxtCantidadCamas.Focus()
            Estado = False
        ElseIf TxtCantidadHamacas.Text = Nothing Then
            MessageBox.Show("Ingrese la Cantidad de Hamacas")
            TxtCantidadHamacas.Focus()
            Estado = False
        ElseIf TxtCantidadRopa.Text = Nothing Then
            MessageBox.Show("Ingrese la Cantidad de Ropa de Cama")
            TxtCantidadRopa.Focus()
            Estado = False
        ElseIf TxtCantidadMesas.Text = Nothing Then
            MessageBox.Show("Ingrese la Cantidad de Mesas")
            TxtCantidadMesas.Focus()
            Estado = False
        ElseIf TxtCantidadSillas.Text = Nothing Then
            MessageBox.Show("Ingrese la Cantidad de Sillas")
            TxtCantidadSillas.Focus()
            Estado = False
        ElseIf TxtPiso.Text = Nothing Then
            MessageBox.Show("Ingrese el Tipo de Piso que Posee la casa ")
            TxtPiso.Focus()
            Estado = False
        ElseIf TxtNumeroBeneficiado.Text = Nothing Then
            MessageBox.Show("Ingrese el Numero del Beneficiado")
            TxtNumeroBeneficiado.Focus()
            Estado = False
        ElseIf CboTipoCasa.SelectedIndex = -1 Then
            MessageBox.Show("Seleccione el Tipo de Casa")
            CboTipoCasa.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado

    End Function

    Public Sub Guardar()

        If Validar() = True Then
            Dim sp As New CasaBeneficiado With
        {
            .CantidadDormitorios = TxtCantidadDormi.Text,
            .CantidadCamas = TxtCantidadCamas.Text,
            .CantidadHamacas = TxtCantidadHamacas.Text,
            .CantidadRopaCama = TxtCantidadRopa.Text,
            .CantidadMesas = TxtCantidadMesas.Text,
            .CantidadSillas = TxtCantidadSillas.Text,
            .Piso = TxtPiso.Text,
            .IdCasaBeneficiado = CInt(Me.CboTipoCasa.SelectedValue),
            .IdBeneficiado = TxtNumeroBeneficiado.Text
         }

            Try
                cnn.CasaBeneficiados.InsertOnSubmit(sp)
                cnn.SubmitChanges()
                MsgBox("Datos ingresados correctamente", MsgBoxStyle.Information, "Aviso")
            Catch ex As Exception
                MsgBox("Error al guardar los datos", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Call Guardar()
    End Sub
    Public Sub ActualizarDatos(id As Integer)

        Dim datos As CasaBeneficiado = (From g In cnn.CasaBeneficiados
                                        Where g.IdCasaBeneficiado = id
                                        Select g).ToList()(0)
        datos.CantidadDormitorios = TxtCantidadDormi.Text
        datos.CantidadCamas = TxtCantidadCamas.Text
        datos.CantidadHamacas = TxtCantidadHamacas.Text
        datos.CantidadMesas = TxtCantidadMesas.Text
        datos.CantidadSillas = TxtCantidadSillas.Text
        datos.Piso = TxtPiso.Text
        datos.IdTipoCasa = CInt(CboTipoCasa.SelectedValue)
        datos.IdBeneficiado = TxtNumeroBeneficiado.Text

        Try
            cnn.SubmitChanges()
            MsgBox("Datos Actualizados correctamente", MsgBoxStyle.Information, "Aviso")

        Catch ex As Exception
            MsgBox("Eror al Actualizar los Datos")
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Call ActualizarDatos(CInt(txtIdCasa.Text))
    End Sub
    Private Sub Limpiar()

        TxtCantidadDormi.Clear()
        TxtCantidadCamas.Clear()
        TxtCantidadHamacas.Clear()
        TxtCantidadRopa.Clear()
        TxtCantidadMesas.Clear()
        TxtCantidadSillas.Clear()
        TxtPiso.Clear()
        TxtNumeroBeneficiado.Clear()
        TxtNombreBeneficiado.Clear()
        CboTipoCasa.SelectedIndex = -1

    End Sub
    Sub InvestigarCorrelativo()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            Dim ListarHermano As New SqlCommand("Sp_IdentityCasa", cn)
            ListarHermano.CommandType = CommandType.StoredProcedure
            Dim ListarHermanos As SqlDataReader
            cn.Open()
            ListarHermanos = ListarHermano.ExecuteReader()
            If ListarHermanos.Read = True Then
                If ListarHermanos("Id") Is DBNull.Value Then
                    txtIdCasa.Text = 1
                Else
                    txtIdCasa.Text = ListarHermanos("Id").ToString
                End If
            End If
        Catch ex As Exception
        End Try
        TxtNumeroBeneficiado.Focus()

    End Sub

    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        Call Limpiar()
        Call InvestigarCorrelativo()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Close()
    End Sub
End Class