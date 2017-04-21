<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdopcionPago
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DtpFechaPago = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.TxtIdPago = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnBuscarAdopPago = New System.Windows.Forms.Button()
        Me.TxtIdAdopcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumeroSponsor = New System.Windows.Forms.TextBox()
        Me.TxtNombreSponsor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNumeroBeneficiado = New System.Windows.Forms.TextBox()
        Me.TxtNombreBeneficiado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnBuscarAdopcion = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtpFechaPago
        '
        Me.DtpFechaPago.Location = New System.Drawing.Point(254, 256)
        Me.DtpFechaPago.Name = "DtpFechaPago"
        Me.DtpFechaPago.Size = New System.Drawing.Size(216, 20)
        Me.DtpFechaPago.TabIndex = 169
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(109, 258)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 18)
        Me.Label11.TabIndex = 168
        Me.Label11.Text = "Fecha Entregada"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(182, 285)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 18)
        Me.Label5.TabIndex = 167
        Me.Label5.Text = "Valor"
        '
        'TxtValor
        '
        Me.TxtValor.Location = New System.Drawing.Point(254, 283)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(216, 20)
        Me.TxtValor.TabIndex = 166
        Me.TxtValor.Text = "0"
        '
        'TxtIdPago
        '
        Me.TxtIdPago.Location = New System.Drawing.Point(253, 94)
        Me.TxtIdPago.Name = "TxtIdPago"
        Me.TxtIdPago.ReadOnly = True
        Me.TxtIdPago.Size = New System.Drawing.Size(216, 20)
        Me.TxtIdPago.TabIndex = 165
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(112, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 18)
        Me.Label6.TabIndex = 164
        Me.Label6.Text = "Adopcion  Pago"
        '
        'BtnBuscarAdopPago
        '
        Me.BtnBuscarAdopPago.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnBuscarAdopPago.Location = New System.Drawing.Point(485, 89)
        Me.BtnBuscarAdopPago.Name = "BtnBuscarAdopPago"
        Me.BtnBuscarAdopPago.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarAdopPago.TabIndex = 163
        Me.BtnBuscarAdopPago.Text = "..."
        Me.BtnBuscarAdopPago.UseVisualStyleBackColor = True
        '
        'TxtIdAdopcion
        '
        Me.TxtIdAdopcion.Location = New System.Drawing.Point(253, 123)
        Me.TxtIdAdopcion.Name = "TxtIdAdopcion"
        Me.TxtIdAdopcion.ReadOnly = True
        Me.TxtIdAdopcion.Size = New System.Drawing.Size(216, 20)
        Me.TxtIdAdopcion.TabIndex = 162
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(155, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "Adopcion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(39, 232)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 18)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Nombre Completo Sponsor"
        '
        'TxtNumeroSponsor
        '
        Me.TxtNumeroSponsor.Location = New System.Drawing.Point(253, 204)
        Me.TxtNumeroSponsor.Name = "TxtNumeroSponsor"
        Me.TxtNumeroSponsor.ReadOnly = True
        Me.TxtNumeroSponsor.Size = New System.Drawing.Size(216, 20)
        Me.TxtNumeroSponsor.TabIndex = 159
        '
        'TxtNombreSponsor
        '
        Me.TxtNombreSponsor.Location = New System.Drawing.Point(253, 230)
        Me.TxtNombreSponsor.Name = "TxtNombreSponsor"
        Me.TxtNombreSponsor.ReadOnly = True
        Me.TxtNombreSponsor.Size = New System.Drawing.Size(216, 20)
        Me.TxtNombreSponsor.TabIndex = 158
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(166, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 157
        Me.Label2.Text = "Sponsor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(16, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(212, 18)
        Me.Label9.TabIndex = 156
        Me.Label9.Text = "Nombre Completo Beneficiado"
        '
        'TxtNumeroBeneficiado
        '
        Me.TxtNumeroBeneficiado.Location = New System.Drawing.Point(253, 149)
        Me.TxtNumeroBeneficiado.Name = "TxtNumeroBeneficiado"
        Me.TxtNumeroBeneficiado.ReadOnly = True
        Me.TxtNumeroBeneficiado.Size = New System.Drawing.Size(216, 20)
        Me.TxtNumeroBeneficiado.TabIndex = 155
        '
        'TxtNombreBeneficiado
        '
        Me.TxtNombreBeneficiado.Location = New System.Drawing.Point(253, 178)
        Me.TxtNombreBeneficiado.Name = "TxtNombreBeneficiado"
        Me.TxtNombreBeneficiado.ReadOnly = True
        Me.TxtNombreBeneficiado.Size = New System.Drawing.Size(216, 20)
        Me.TxtNombreBeneficiado.TabIndex = 154
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(143, 149)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 18)
        Me.Label8.TabIndex = 153
        Me.Label8.Text = "Beneficiado"
        '
        'BtnBuscarAdopcion
        '
        Me.BtnBuscarAdopcion.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.BtnBuscarAdopcion.Location = New System.Drawing.Point(485, 118)
        Me.BtnBuscarAdopcion.Name = "BtnBuscarAdopcion"
        Me.BtnBuscarAdopcion.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarAdopcion.TabIndex = 152
        Me.BtnBuscarAdopcion.Text = "..."
        Me.BtnBuscarAdopcion.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = Global.Misión.My.Resources.Resources.cerrarsesion
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(419, 333)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox6.TabIndex = 239
        Me.PictureBox6.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.Misión.My.Resources.Resources.nuevo
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(108, 333)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox4.TabIndex = 238
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Misión.My.Resources.Resources.editar
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(264, 333)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox2.TabIndex = 237
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Misión.My.Resources.Resources.nuevito
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(185, 333)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox1.TabIndex = 236
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global.Misión.My.Resources.Resources.volververde
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(342, 333)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox5.TabIndex = 235
        Me.PictureBox5.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calisto MT", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(110, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(188, 34)
        Me.Label4.TabIndex = 240
        Me.Label4.Text = "Adopción Pago"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Misión.My.Resources.Resources.adoptado2
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(19, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 52)
        Me.PictureBox3.TabIndex = 241
        Me.PictureBox3.TabStop = False
        '
        'FrmAdopcionPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Misión.My.Resources.Resources.fonditooo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(583, 396)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.DtpFechaPago)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtValor)
        Me.Controls.Add(Me.TxtIdPago)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnBuscarAdopPago)
        Me.Controls.Add(Me.TxtIdAdopcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNumeroSponsor)
        Me.Controls.Add(Me.TxtNombreSponsor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtNumeroBeneficiado)
        Me.Controls.Add(Me.TxtNombreBeneficiado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnBuscarAdopcion)
        Me.DoubleBuffered = True
        Me.Name = "FrmAdopcionPago"
        Me.Text = "FrmAdopcionPago"
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtpFechaPago As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents TxtIdPago As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents BtnBuscarAdopPago As Button
    Friend WithEvents TxtIdAdopcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNumeroSponsor As TextBox
    Friend WithEvents TxtNombreSponsor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNumeroBeneficiado As TextBox
    Friend WithEvents TxtNombreBeneficiado As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnBuscarAdopcion As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
