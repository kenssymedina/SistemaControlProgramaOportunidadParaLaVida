﻿Public Class FrmCargando
    Public contador As Integer

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click
        ProgressBar1.Value = 0.0
        ProgressBar1.Maximum = 100
        Timer1.Interval = 40
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If contador < 100 Then
            ProgressBar1.Value = contador
            contador = contador + 1
            Label1.Text = "Cargando el sistema al " & ProgressBar1.Value & "%"
        Else
            Timer1.Enabled = False
            Me.Hide()
            FrmIniciarSesion.Show()

        End If
    End Sub

    Private Sub FrmCargando_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class