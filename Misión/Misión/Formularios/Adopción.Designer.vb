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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.BtnEntrar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
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
        Me.BtnVolver = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvInformacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(550, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 41)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Adopción"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Transparent
        Me.BtnActualizar.BackgroundImage = Global.Misión.My.Resources.Resources.actualizar
        Me.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Black
        Me.BtnActualizar.Location = New System.Drawing.Point(350, 413)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(53, 41)
        Me.BtnActualizar.TabIndex = 13
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnEntrar
        '
        Me.BtnEntrar.BackColor = System.Drawing.Color.Transparent
        Me.BtnEntrar.BackgroundImage = Global.Misión.My.Resources.Resources.guardar1
        Me.BtnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEntrar.ForeColor = System.Drawing.Color.Black
        Me.BtnEntrar.Location = New System.Drawing.Point(262, 413)
        Me.BtnEntrar.Name = "BtnEntrar"
        Me.BtnEntrar.Size = New System.Drawing.Size(53, 41)
        Me.BtnEntrar.TabIndex = 12
        Me.BtnEntrar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(-5, -1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1226, 45)
        Me.Panel2.TabIndex = 141
        '
        'Panel1
        '
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
        Me.Panel1.Location = New System.Drawing.Point(12, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(563, 273)
        Me.Panel1.TabIndex = 147
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(4, 234)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(215, 17)
        Me.Label15.TabIndex = 132
        Me.Label15.Text = "Fecha de Perdida de Adopción" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(94, 207)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(125, 17)
        Me.Label17.TabIndex = 131
        Me.Label17.Text = "Estado Adopción"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(173, 181)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 17)
        Me.Label16.TabIndex = 130
        Me.Label16.Text = "Valor"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(121, 154)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 17)
        Me.Label14.TabIndex = 129
        Me.Label14.Text = "Tipo de Pagó"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(82, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 17)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "Fecha de Adopción"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(124, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 17)
        Me.Label11.TabIndex = 127
        Me.Label11.Text = "Observación"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(69, 75)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(150, 17)
        Me.Label20.TabIndex = 126
        Me.Label20.Text = "Número del Sponsor"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(44, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(175, 17)
        Me.Label21.TabIndex = 125
        Me.Label21.Text = "Número del Beneficiado"
        '
        'CboEstado
        '
        Me.CboEstado.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEstado.FormattingEnabled = True
        Me.CboEstado.Location = New System.Drawing.Point(225, 204)
        Me.CboEstado.Name = "CboEstado"
        Me.CboEstado.Size = New System.Drawing.Size(317, 20)
        Me.CboEstado.TabIndex = 17
        '
        'CboIdSponsor
        '
        Me.CboIdSponsor.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboIdSponsor.FormattingEnabled = True
        Me.CboIdSponsor.Location = New System.Drawing.Point(225, 72)
        Me.CboIdSponsor.Name = "CboIdSponsor"
        Me.CboIdSponsor.Size = New System.Drawing.Size(317, 20)
        Me.CboIdSponsor.TabIndex = 0
        '
        'CboTipoPago
        '
        Me.CboTipoPago.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoPago.FormattingEnabled = True
        Me.CboTipoPago.Location = New System.Drawing.Point(225, 151)
        Me.CboTipoPago.Name = "CboTipoPago"
        Me.CboTipoPago.Size = New System.Drawing.Size(317, 20)
        Me.CboTipoPago.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(105, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(114, 17)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "ID de Adopcion"
        '
        'TxtValor
        '
        Me.TxtValor.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValor.Location = New System.Drawing.Point(225, 178)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(317, 20)
        Me.TxtValor.TabIndex = 16
        '
        'DtpFechaPerdidaAdopcion
        '
        Me.DtpFechaPerdidaAdopcion.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaPerdidaAdopcion.Location = New System.Drawing.Point(225, 231)
        Me.DtpFechaPerdidaAdopcion.Name = "DtpFechaPerdidaAdopcion"
        Me.DtpFechaPerdidaAdopcion.Size = New System.Drawing.Size(317, 20)
        Me.DtpFechaPerdidaAdopcion.TabIndex = 15
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservaciones.Location = New System.Drawing.Point(225, 125)
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.Size = New System.Drawing.Size(317, 20)
        Me.TxtObservaciones.TabIndex = 14
        '
        'DtpFechaAdopcion
        '
        Me.DtpFechaAdopcion.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFechaAdopcion.Location = New System.Drawing.Point(225, 99)
        Me.DtpFechaAdopcion.Name = "DtpFechaAdopcion"
        Me.DtpFechaAdopcion.Size = New System.Drawing.Size(317, 20)
        Me.DtpFechaAdopcion.TabIndex = 13
        '
        'TxtIdAdopcion
        '
        Me.TxtIdAdopcion.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdAdopcion.Location = New System.Drawing.Point(225, 19)
        Me.TxtIdAdopcion.Name = "TxtIdAdopcion"
        Me.TxtIdAdopcion.Size = New System.Drawing.Size(317, 20)
        Me.TxtIdAdopcion.TabIndex = 12
        '
        'CboIdBeneficiado
        '
        Me.CboIdBeneficiado.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboIdBeneficiado.FormattingEnabled = True
        Me.CboIdBeneficiado.Location = New System.Drawing.Point(225, 45)
        Me.CboIdBeneficiado.Name = "CboIdBeneficiado"
        Me.CboIdBeneficiado.Size = New System.Drawing.Size(317, 20)
        Me.CboIdBeneficiado.TabIndex = 11
        '
        'DgvInformacion
        '
        Me.DgvInformacion.BackgroundColor = System.Drawing.Color.White
        Me.DgvInformacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvInformacion.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DgvInformacion.Location = New System.Drawing.Point(581, 77)
        Me.DgvInformacion.Name = "DgvInformacion"
        Me.DgvInformacion.Size = New System.Drawing.Size(691, 337)
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
        'BtnVolver
        '
        Me.BtnVolver.BackColor = System.Drawing.Color.Transparent
        Me.BtnVolver.BackgroundImage = Global.Misión.My.Resources.Resources.abort_146072_640
        Me.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVolver.ForeColor = System.Drawing.Color.Black
        Me.BtnVolver.Location = New System.Drawing.Point(167, 413)
        Me.BtnVolver.Name = "BtnVolver"
        Me.BtnVolver.Size = New System.Drawing.Size(53, 41)
        Me.BtnVolver.TabIndex = 155
        Me.BtnVolver.UseVisualStyleBackColor = False
        '
        'FrmAdopción
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1294, 465)
        Me.Controls.Add(Me.BtnVolver)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DgvInformacion)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnEntrar)
        Me.MaximizeBox = False
        Me.Name = "FrmAdopción"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adopción"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvInformacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnEntrar As Button
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents Panel2 As Panel
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
    Friend WithEvents BtnVolver As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
End Class
