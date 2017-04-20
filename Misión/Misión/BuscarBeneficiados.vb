Imports DevExpress.XtraReports.UI

Public Class BuscarBeneficiados
    Private Sub BusquedaBeneficiado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accesodatos.CargarBeneficiados(DgvDetallesBeneficiado)

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        accesodatos.CargarBeneficiados(DgvDetallesBeneficiado, txtBuscar.Text)

    End Sub



    Private Sub DgvDetallesBeneficiado_DoubleClick(sender As Object, e As EventArgs) Handles DgvDetallesBeneficiado.DoubleClick
        Dim id As String = DgvDetallesBeneficiado.CurrentRow.Cells(0).Value
        Dim InstanciaForm As IForm = CType(Me.Owner, IForm)

        'evalua que la columna (0) osea la del id tenga algo para poder hacer el envio de los datos
        If InstanciaForm IsNot Nothing Then
            InstanciaForm.ObtenerId(id)
        End If
        Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        PictureBox1.Size = New Size(58, 59)
    End Sub

    Private Sub VerReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerReporteToolStripMenuItem.Click
        Dim codigo As String = Me.DgvDetallesBeneficiado.CurrentRow.Cells(0).Value
        Dim rp As New ReporteBeneficiado
        If codigo <> "" Then
            rp.generareporte(codigo)
            rp.ShowPreviewDialog()

        End If

    End Sub

End Class