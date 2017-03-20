Public Class FrmMenuPrincipal
    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub AdopciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdopciónToolStripMenuItem.Click
        FrmAdopción.Show()
    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click

    End Sub

    Private Sub TutorTolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutorToolStripMenuItem.Click
        FrmTutor.Show()
    End Sub

    Private Sub SponsorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SponsorToolStripMenuItem.Click
        FrmSponsor.Show()
    End Sub

    Private Sub CatasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatasToolStripMenuItem.Click

    End Sub

    Private Sub FrmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BeneficiarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeneficiarioToolStripMenuItem.Click
        FrmBeneficiado.Show()
    End Sub

    Private Sub InformesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformesToolStripMenuItem.Click

    End Sub

    Private Sub SalirDelSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirDelSistemaToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class