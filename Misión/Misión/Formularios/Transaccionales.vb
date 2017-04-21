Public Class FrmTransaccionales


    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Size = New Size(80, 72)
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove

        PictureBox1.Size = New Size(90, 82)
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        FrmAdopción.Show()
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave

        PictureBox5.Size = New Size(49, 51)
    End Sub

    Private Sub PictureBox5_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox5.MouseMove
        PictureBox5.Size = New Size(58, 59)
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave


        PictureBox2.Size = New Size(80, 72)
    End Sub


    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        PictureBox2.Size = New Size(90, 82)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        FrmBeneficiado.Show()

    End Sub

    Private Sub PictureBox7_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox7.MouseLeave

        PictureBox7.Size = New Size(80, 72)
    End Sub

    Private Sub PictureBox7_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox7.MouseMove
        PictureBox7.Size = New Size(90, 82)
    End Sub



    Private Sub PictureBox10_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox10.MouseLeave

        PictureBox10.Size = New Size(80, 72)
    End Sub

    Private Sub PictureBox10_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox10.MouseMove
        PictureBox10.Size = New Size(90, 82)
    End Sub

    Private Sub PictureBox6_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox6.MouseLeave

        PictureBox6.Size = New Size(80, 72)
    End Sub

    Private Sub PictureBox6_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox6.MouseMove
        PictureBox6.Size = New Size(90, 82)
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave

        PictureBox3.Size = New Size(80, 72)
    End Sub

    Private Sub PictureBox3_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox3.MouseMove
        PictureBox3.Size = New Size(90, 82)
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        FrmSponsor.Show()

    End Sub

    Private Sub FrmTransaccionales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        FrmTutor.Show()

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        FrmCartas.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmHermanos.Show()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        FrmOfrendavb.Show()
    End Sub
End Class