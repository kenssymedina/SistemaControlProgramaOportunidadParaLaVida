Public Class BuscarBeneficiados
    Private Sub BusquedaBeneficiado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accesodatos.CargarBeneficiados(DgvDetallesBeneficiado)


    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        accesodatos.CargarBeneficiados(DgvDetallesBeneficiado, txtBuscar.Text)

    End Sub


    Private Sub DgvDetallesBeneficiado_DoubleClick(sender As Object, e As EventArgs) Handles DgvDetallesBeneficiado.DoubleClick
        'aqui obtiene el id de sql osea la pk de la tabla que se esta mostrando en el grid

        Dim id As String = DgvDetallesBeneficiado.CurrentRow.Cells(0).Value
        'aqui hace una instancia de la clase IForm
        Dim InstanciaForm As IForm = CType(Me.Owner, IForm)

        'evalua que la columna (0) osea la del id tenga algo para poder hacer el envio de los datos
        If InstanciaForm IsNot Nothing Then

            InstanciaForm.ObtenerId(id)
        End If
        Close()
    End Sub

    Private Sub DgvDetallesBeneficiado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvDetallesBeneficiado.CellContentClick
        FrmBeneficiado.b = False




    End Sub
End Class