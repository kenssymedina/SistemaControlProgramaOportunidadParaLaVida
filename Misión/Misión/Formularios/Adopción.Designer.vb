<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdopción
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CboEstado = New System.Windows.Forms.ComboBox()
        Me.CboIdSponsor = New System.Windows.Forms.ComboBox()
        Me.CboTipoPago = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.DtpFechaPerdidaAdopcion = New System.Windows.Forms.DateTimePicker()
        Me.TxtObservaciones = New System.Windows.Forms.TextBox()
        Me.DtpFechaAdopcion = New System.Windows.Forms.DateTimePicker()
        Me.TxtIdAdopcion = New System.Windows.Forms.TextBox()
        Me.CboIdBeneficiado = New System.Windows.Forms.ComboBox()
        Me.DgvInformacion = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvInformacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.CboEstado)
        Me.Panel1.Controls.Add(Me.CboIdSponsor)
        Me.Panel1.Controls.Add(Me.CboTipoPago)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.TxtValor)
        Me.Panel1.Controls.Add(Me.DtpFechaPerdidaAdopcion)
        Me.Panel1.Controls.Add(Me.TxtObservaciones)
        Me.Panel1.Controls.Add(Me.DtpFechaAdopcion)
        Me.Panel1.Controls.Add(Me.TxtIdAdopcion)
        Me.Panel1.Controls.Add(Me.CboIdBeneficiado)
        Me.Panel1.Location = New System.Drawing.Point(12, 122)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(510, 273)
        Me.Panel1.TabIndex = 147
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(97, 234)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(121, 18)
        Me.Label15.TabIndex = 132
        Me.Label15.Text = "Fecha de Perdida" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(160, 209)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 18)
        Me.Label17.TabIndex = 131
        Me.Label17.Text = "Estado "
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(172, 184)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 17)
        Me.Label16.TabIndex = 130
        Me.Label16.Text = "Valor"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(120, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 18)
        Me.Label14.TabIndex = 129
        Me.Label14.Text = "Tipo de Pagó"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(83, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(135, 18)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "Fecha de Adopción"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(126, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 18)
        Me.Label11.TabIndex = 127
        Me.Label11.Text = "Observación"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(75, 77)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(143, 18)
        Me.Label20.TabIndex = 126
        Me.Label20.Text = "Número del Sponsor"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(52, 50)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(166, 18)
        Me.Label21.TabIndex = 125
        Me.Label21.Text = "Número del Beneficiado"
        '
        'CboEstado
        '
        Me.CboEstado.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Location = New System.Drawing.Point(225, 204)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(254, 23)
        Me.CboEstado.TabIndex = 17
        '
        'CboIdSponsor
        '
        Me.CboIdSponsor.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboIdSponsor.FormattingEnabled = True
        Me.CboIdSponsor.Location = New System.Drawing.Point(225, 72)
        Me.CboIdSponsor.Name = "CboIdSponsor"
        Me.CboIdSponsor.Size = New System.Drawing.Size(254, 23)
        Me.CboIdSponsor.TabIndex = 0
        '
        'CboTipoPago
        '
        Me.CboTipoPago.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoPago.FormattingEnabled = True
        Me.CboTipoPago.Location = New System.Drawing.Point(225, 151)
        Me.CboTipoPago.Name = "CboTipoPago"
        Me.CboTipoPago.Size = New System.Drawing.Size(254, 23)
        Me.CboTipoPago.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(152, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 18)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Número "
        '
        'TxtValor
        '
        Me.TxtValor.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValor.Location = New System.Drawing.Point(225, 178)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(254, 23)
        Me.TxtValor.TabIndex = 16
        '
        'DtpFechaPerdidaAdopcion
        '
        Me.DtpFechaPerdidaAdopcion.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaPerdidaAdopcion.Location = New System.Drawing.Point(225, 231)
        Me.DtpFechaPerdidaAdopcion.Name = "DtpFechaPerdidaAdopcion"
        Me.DtpFechaPerdidaAdopcion.Size = New System.Drawing.Size(254, 23)
        Me.DtpFechaPerdidaAdopcion.TabIndex = 15
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservaciones.Location = New System.Drawing.Point(225, 125)
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(254, 23)
        Me.TxtObservaciones.TabIndex = 14
        '
        'DtpFechaAdopcion
        '
        Me.DtpFechaAdopcion.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaAdopcion.Location = New System.Drawing.Point(225, 99)
        Me.DtpFechaAdopcion.Name = "DtpFechaAdopcion"
        Me.DtpFechaAdopcion.Size = New System.Drawing.Size(254, 23)
        Me.DtpFechaAdopcion.TabIndex = 13
        '
        'TxtIdAdopcion
        '
        Me.TxtIdAdopcion.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdAdopcion.Location = New System.Drawing.Point(225, 19)
        Me.TxtIdAdopcion.Name = "TxtIdAdopcion"
        Me.TxtIdAdopcion.Size = New System.Drawing.Size(254, 23)
        Me.TxtIdAdopcion.TabIndex = 12
        '
        'CboIdBeneficiado
        '
        Me.CboIdBeneficiado.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboIdBeneficiado.FormattingEnabled = True
        Me.CboIdBeneficiado.Location = New System.Drawing.Point(225, 45)
        Me.CboIdBeneficiado.Name = "CboIdBeneficiado"
        Me.CboIdBeneficiado.Size = New System.Drawing.Size(254, 23)
        Me.CboIdBeneficiado.TabIndex = 11
        '
        'DgvInformacion
        '
        Me.DgvInformacion.BackgroundColor = System.Drawing.Color.White
        Me.DgvInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvInformacion.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DgvInformacion.Location = New System.Drawing.Point(557, 115)
        Me.DgvInformacion.Name = "DgvInformacion"
        Me.DgvInformacion.Size = New System.Drawing.Size(793, 337)
        Me.DgvInformacion.TabIndex = 146
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(105, 26)
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 34)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "Adopción"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.Misión.My.Resources.Resources.nuevo
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(91, 457)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox4.TabIndex = 161
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Misión.My.Resources.Resources.editar
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(247, 457)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox2.TabIndex = 160
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Misión.My.Resources.Resources.nuevito
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(168, 457)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox1.TabIndex = 159
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global.Misión.My.Resources.Resources.volververde
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(325, 457)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox5.TabIndex = 158
        Me.PictureBox5.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Misión.My.Resources.Resources.adoptado2
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(64, 52)
        Me.PictureBox3.TabIndex = 157
        Me.PictureBox3.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = Global.Misión.My.Resources.Resources.cerrarsesion
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(402, 457)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox6.TabIndex = 234
        Me.PictureBox6.TabStop = False
        '
        'FrmAdopción
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Misión.My.Resources.Resources.fondo4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1378, 570)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DgvInformacion)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FrmAdopción"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvInformacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents CboEstado As ComboBox
    Friend WithEvents CboIdSponsor As ComboBox
    Friend WithEvents CboTipoPago As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents DtpFechaPerdidaAdopcion As DateTimePicker
    Friend WithEvents TxtObservaciones As TextBox
    Friend WithEvents DtpFechaAdopcion As DateTimePicker
    Friend WithEvents TxtIdAdopcion As TextBox
    Friend WithEvents CboIdBeneficiado As ComboBox
    Friend WithEvents DgvInformacion As DataGridView
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
