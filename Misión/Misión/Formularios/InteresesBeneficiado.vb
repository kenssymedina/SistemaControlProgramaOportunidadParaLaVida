﻿Public Class InteresesBeneficiado

    Implements IForm, IForm2

    Public Sub ObtenerId(id As String) Implements IForm.ObtenerId
        TxtNumeroBeneficiado.Text = id
    End Sub
    Public Sub ObtenerHermano(id As String) Implements IForm2.ObtenerIdSegundo
        txtIdInteres.Text = id
    End Sub
    Private Sub InteresesBeneficiado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub BtnData_Click(sender As Object, e As EventArgs) Handles BtnData.Click
        'aqui muestra el formulario de busqueda
        Dim frm As New FrmBuscarBeneficiadoIntereses()
        frm.Show(Me)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'aqui muestra el formulario de busqueda
        Dim frm As New FrmBuscarInteresesBeneficiado()
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
End Class