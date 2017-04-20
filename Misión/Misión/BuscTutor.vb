Public Class BuscTutor
    Private Sub frmBusquedaTutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'la funcion cargar datos tiene dos sentidos, la demostrar todo que es lo que hace cuando se abre el formulario de busquedas 
        accesodatos.CargarTutores(DataGridView1)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        'y la otra es cuando se realiza una busqueda osea que se escribe algo en el textbox del formulario buscartutor
        accesodatos.CargarTutores(DataGridView1, txtBuscar.Text)
    End Sub



    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        'aqui obtiene el id de sql osea la pk de la tabla que se esta mostrando en el grid
        Dim id As String = DataGridView1.CurrentRow.Cells(0).Value
        'aqui hace una instancia de la clase IForm
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
End Class