Public Class BusqueSponsor
    Private Sub BusquedaSponsor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        accesodatos.CargarSponsor(DataGridView1)

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        accesodatos.CargarSponsor(DataGridView1, txtBuscar.Text)
    End Sub


    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

        Dim id As String = DataGridView1.CurrentRow.Cells(0).Value
        Dim InstanciaForm As IForm = CType(Me.Owner, IForm)
        If InstanciaForm IsNot Nothing Then

            InstanciaForm.ObtenerId(id)
        End If
        Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        FrmSponsor.b = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        PictureBox1.Size = New Size(58, 59)
    End Sub
End Class