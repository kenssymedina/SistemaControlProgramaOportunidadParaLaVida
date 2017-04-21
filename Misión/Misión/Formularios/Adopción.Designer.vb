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
        Me.BtnBeneficiado = New System.Windows.Forms.Button()
        Me.BtnBuscarSponsor = New System.Windows.Forms.Button()
        Me.BtnBuscarAdopcion = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CboEstadoAdopcion = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CboTipoPago = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtValor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtObservacion = New System.Windows.Forms.TextBox()
        Me.DTpFechaAdopcion = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtIdAdopcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNumeroSponsor = New System.Windows.Forms.TextBox()
        Me.TxtNombreSponsor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNumeroBeneficiado = New System.Windows.Forms.TextBox()
        Me.TxtNombreBeneficiado = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
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
        Me.Panel1.Controls.Add(Me.BtnBeneficiado)
        Me.Panel1.Controls.Add(Me.BtnBuscarSponsor)
        Me.Panel1.Controls.Add(Me.BtnBuscarAdopcion)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CboEstadoAdopcion)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.CboTipoPago)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtValor)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtObservacion)
        Me.Panel1.Controls.Add(Me.DTpFechaAdopcion)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtIdAdopcion)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtNumeroSponsor)
        Me.Panel1.Controls.Add(Me.TxtNombreSponsor)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TxtNumeroBeneficiado)
        Me.Panel1.Controls.Add(Me.TxtNombreBeneficiado)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(12, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(549, 381)
        Me.Panel1.TabIndex = 147
        '
        'BtnBeneficiado
        '
        Me.BtnBeneficiado.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBeneficiado.Location = New System.Drawing.Point(466, 63)
        Me.BtnBeneficiado.Name = "BtnBeneficiado"
        Me.BtnBeneficiado.Size = New System.Drawing.Size(75, 23)
        Me.BtnBeneficiado.TabIndex = 119
        Me.BtnBeneficiado.Text = "..."
        Me.BtnBeneficiado.UseVisualStyleBackColor = True
        '
        'BtnBuscarSponsor
        '
        Me.BtnBuscarSponsor.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarSponsor.Location = New System.Drawing.Point(468, 124)
        Me.BtnBuscarSponsor.Name = "BtnBuscarSponsor"
        Me.BtnBuscarSponsor.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarSponsor.TabIndex = 118
        Me.BtnBuscarSponsor.Text = "..."
        Me.BtnBuscarSponsor.UseVisualStyleBackColor = True
        '
        'BtnBuscarAdopcion
        '
        Me.BtnBuscarAdopcion.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarAdopcion.Location = New System.Drawing.Point(467, 32)
        Me.BtnBuscarAdopcion.Name = "BtnBuscarAdopcion"
        Me.BtnBuscarAdopcion.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarAdopcion.TabIndex = 117
        Me.BtnBuscarAdopcion.Text = "..."
        Me.BtnBuscarAdopcion.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(103, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 18)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Estado Adopcion"
        '
        'CboEstadoAdopcion
        '
        Me.CboEstadoAdopcion.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEstadoAdopcion.FormattingEnabled = True
        Me.CboEstadoAdopcion.Location = New System.Drawing.Point(233, 327)
        Me.CboEstadoAdopcion.Name = "CboEstadoAdopcion"
        Me.CboEstadoAdopcion.Size = New System.Drawing.Size(216, 26)
        Me.CboEstadoAdopcion.TabIndex = 115
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(128, 298)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 18)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "Tipo de Pago"
        '
        'CboTipoPago
        '
        Me.CboTipoPago.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoPago.FormattingEnabled = True
        Me.CboTipoPago.Location = New System.Drawing.Point(233, 295)
        Me.CboTipoPago.Name = "CboTipoPago"
        Me.CboTipoPago.Size = New System.Drawing.Size(216, 26)
        Me.CboTipoPago.TabIndex = 113
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(176, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 18)
        Me.Label6.TabIndex = 112
        Me.Label6.Text = "Valor"
        '
        'TxtValor
        '
        Me.TxtValor.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValor.Location = New System.Drawing.Point(233, 266)
        Me.TxtValor.Name = "TxtValor"
        Me.TxtValor.Size = New System.Drawing.Size(119, 25)
        Me.TxtValor.TabIndex = 111
        Me.TxtValor.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(138, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 18)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Observacion"
        '
        'TxtObservacion
        '
        Me.TxtObservacion.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservacion.Location = New System.Drawing.Point(233, 229)
        Me.TxtObservacion.Name = "TxtObservacion"
        Me.TxtObservacion.Size = New System.Drawing.Size(216, 25)
        Me.TxtObservacion.TabIndex = 109
        '
        'DTpFechaAdopcion
        '
        Me.DTpFechaAdopcion.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTpFechaAdopcion.Location = New System.Drawing.Point(233, 188)
        Me.DTpFechaAdopcion.Name = "DTpFechaAdopcion"
        Me.DTpFechaAdopcion.Size = New System.Drawing.Size(216, 25)
        Me.DTpFechaAdopcion.TabIndex = 108
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(111, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 18)
        Me.Label4.TabIndex = 107
        Me.Label4.Text = "Fecha Adopcion"
        '
        'TxtIdAdopcion
        '
        Me.TxtIdAdopcion.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdAdopcion.Location = New System.Drawing.Point(233, 34)
        Me.TxtIdAdopcion.Name = "TxtIdAdopcion"
        Me.TxtIdAdopcion.ReadOnly = True
        Me.TxtIdAdopcion.Size = New System.Drawing.Size(216, 25)
        Me.TxtIdAdopcion.TabIndex = 106
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 18)
        Me.Label3.TabIndex = 105
        Me.Label3.Text = "Adopcion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(103, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 18)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "Nombre  Sponsor"
        '
        'TxtNumeroSponsor
        '
        Me.TxtNumeroSponsor.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroSponsor.Location = New System.Drawing.Point(233, 126)
        Me.TxtNumeroSponsor.Name = "TxtNumeroSponsor"
        Me.TxtNumeroSponsor.ReadOnly = True
        Me.TxtNumeroSponsor.Size = New System.Drawing.Size(216, 25)
        Me.TxtNumeroSponsor.TabIndex = 103
        '
        'TxtNombreSponsor
        '
        Me.TxtNombreSponsor.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreSponsor.Location = New System.Drawing.Point(233, 155)
        Me.TxtNombreSponsor.Name = "TxtNombreSponsor"
        Me.TxtNombreSponsor.ReadOnly = True
        Me.TxtNombreSponsor.Size = New System.Drawing.Size(216, 25)
        Me.TxtNombreSponsor.TabIndex = 102
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(158, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 18)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Sponsor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(83, 92)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(143, 18)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Nombre Beneficiado"
        '
        'TxtNumeroBeneficiado
        '
        Me.TxtNumeroBeneficiado.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroBeneficiado.Location = New System.Drawing.Point(233, 60)
        Me.TxtNumeroBeneficiado.Name = "TxtNumeroBeneficiado"
        Me.TxtNumeroBeneficiado.ReadOnly = True
        Me.TxtNumeroBeneficiado.Size = New System.Drawing.Size(216, 25)
        Me.TxtNumeroBeneficiado.TabIndex = 99
        '
        'TxtNombreBeneficiado
        '
        Me.TxtNombreBeneficiado.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreBeneficiado.Location = New System.Drawing.Point(233, 89)
        Me.TxtNombreBeneficiado.Name = "TxtNombreBeneficiado"
        Me.TxtNombreBeneficiado.ReadOnly = True
        Me.TxtNombreBeneficiado.Size = New System.Drawing.Size(216, 25)
        Me.TxtNombreBeneficiado.TabIndex = 98
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(142, 60)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 18)
        Me.Label11.TabIndex = 97
        Me.Label11.Text = "Beneficiado"
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
        Me.ClientSize = New System.Drawing.Size(592, 570)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FrmAdopción"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents BtnBeneficiado As Button
    Friend WithEvents BtnBuscarSponsor As Button
    Friend WithEvents BtnBuscarAdopcion As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents CboEstadoAdopcion As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CboTipoPago As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtValor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtObservacion As TextBox
    Friend WithEvents DTpFechaAdopcion As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtIdAdopcion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNumeroSponsor As TextBox
    Friend WithEvents TxtNombreSponsor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtNumeroBeneficiado As TextBox
    Friend WithEvents TxtNombreBeneficiado As TextBox
    Friend WithEvents Label11 As Label
End Class
