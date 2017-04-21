Imports System.Data.SqlClient
Imports System.Data

Public Class FrmInteresesBeneficiado

    Implements IForm, IForm2

    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        TxtNumeroBeneficiado.Text = id
    End Sub

    Public Sub ObtenerHermano(id As String) Implements IForm2.ObtenerIdSegundo
        txtIdInteres.Text = id
    End Sub

    Private Sub FrmInteresesBeneficiado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtIdInteres_TextChanged(sender As Object, e As EventArgs) Handles txtIdInteres.TextChanged

        If txtIdInteres.Text <> "" Then
            accesodatos.CargarDatosInteresesBeneficiado(txtIdInteres.Text, TxtGustaC, TxtGustaJ, TxtGustaT, TxtNumeroBeneficiado, TxtNombreBeneficiado)

        End If
    End Sub

    Private Sub TxtNumeroBeneficiado_TextChanged(sender As Object, e As EventArgs) Handles TxtNumeroBeneficiado.TextChanged
        If TxtNumeroBeneficiado.Text <> "" Then
            accesodatos.CargarDatosBeneficidoIntereses(TxtNumeroBeneficiado.Text, TxtNombreBeneficiado)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'aqui muestra el formulario de busqueda
        Dim frm As New FrmBuscarInteresesBeneficiado()
        frm.Show(Me)
    End Sub

    Private Sub BtnData_Click(sender As Object, e As EventArgs) Handles BtnData.Click

        Dim frm As New FrmBuscarBeneficiadoIntereses()
        frm.Show(Me)
    End Sub
    Private Function Validar() As Boolean
        Dim Estado As Boolean
        If txtIdInteres.Text = Nothing And TxtGustaC.Text = Nothing And TxtGustaJ.Text = Nothing And TxtGustaT.Text = Nothing And
          TxtNumeroBeneficiado.Text = Nothing Then
            MessageBox.Show("Ingrese los datos solicitados")
            txtIdInteres.Focus()
            Estado = False
        ElseIf TxtGustaC.Text = Nothing Then
            MessageBox.Show("Ingrese la Comida que le Gusta Comer")
            TxtGustaC.Focus()
            Estado = False
        ElseIf TxtGustaJ.Text = Nothing Then
            MessageBox.Show("Ingrese lo que le Gusta Jugar")
            TxtGustaJ.Focus()
            Estado = False
        ElseIf TxtGustaT.Text = Nothing Then
            MessageBox.Show("Ingreses lo que le Gustaria Tener")
            TxtGustaC.Focus()
            Estado = False
        ElseIf TxtNumeroBeneficiado.Text = Nothing Then
            MessageBox.Show("Ingrese el Numero del Beneficiado")
            TxtNumeroBeneficiado.Focus()
            Estado = False
        Else
            Estado = True
        End If
        Return Estado


    End Function
    Public Sub Guardar()

        If Validar() = True Then
            Dim sp As New InteresesBeneficiado With
        {
            .GustaComerBeneficiado = TxtGustaC.Text,
            .GustaJugarBeneficiado = TxtGustaJ.Text,
            .GustaTenerBeneficiado = TxtGustaT.Text,
            .IdBeneficiado = TxtNumeroBeneficiado.Text
         }

            Try
                cnn.InteresesBeneficiados.InsertOnSubmit(sp)
                cnn.SubmitChanges()
                MsgBox("Datos ingresados correctamente", MsgBoxStyle.Information, "Aviso")
            Catch ex As Exception
                MsgBox("Error al guardar los datos", MsgBoxStyle.Information, "Aviso")
                Exit Sub
            End Try
        End If
    End Sub

    Public Sub ActualizarDatos(id As Integer)

        Dim datos As InteresesBeneficiado = (From g In cnn.InteresesBeneficiados
                                             Where g.IdIntereseBeneficiado = id
                                             Select g).ToList()(0)
        datos.GustaComerBeneficiado = TxtGustaC.Text
        datos.GustaJugarBeneficiado = TxtGustaJ.Text
        datos.GustaTenerBeneficiado = TxtGustaT.Text
        datos.IdBeneficiado = TxtNumeroBeneficiado.Text

        Try
            cnn.SubmitChanges()
            MsgBox("Datos Actualizados correctamente", MsgBoxStyle.Information, "Aviso")

        Catch ex As Exception
            MsgBox("Eror al Actualizar los Datos")
        End Try
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Call ActualizarDatos(CInt(txtIdInteres.Text))
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Call Guardar()
    End Sub
    Private Sub Limpiar()

        TxtGustaC.Clear()
        TxtGustaJ.Clear()
        TxtGustaT.Clear()
        TxtNumeroBeneficiado.Clear()
        TxtNombreBeneficiado.Clear()

    End Sub
    Sub InvestigarCorrelativo()
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
        Try
            Dim ListarHermano As New SqlCommand("Sp_IdentityIntereses", cn)
            ListarHermano.CommandType = CommandType.StoredProcedure
            Dim ListarHermanos As SqlDataReader
            cn.Open()
            ListarHermanos = ListarHermano.ExecuteReader()
            If ListarHermanos.Read = True Then
                If ListarHermanos("Id") Is DBNull.Value Then
                    txtIdInteres.Text = 1
                Else
                    txtIdInteres.Text = ListarHermanos("Id").ToString
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

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        FrmBeneficiado.Show()
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Me.Close()
    End Sub
End Class