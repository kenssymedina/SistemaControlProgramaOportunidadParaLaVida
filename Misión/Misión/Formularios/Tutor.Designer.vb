﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTutor
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
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtidiglesia = New System.Windows.Forms.TextBox()
        Me.txtidparen = New System.Windows.Forms.TextBox()
        Me.txtidlu = New System.Windows.Forms.TextBox()
        Me.txtids = New System.Windows.Forms.TextBox()
        Me.txtidof = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtSalario = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CboSexo = New System.Windows.Forms.ComboBox()
        Me.TxtFechaNac = New System.Windows.Forms.DateTimePicker()
        Me.TxtNumeroC = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboParentesco = New System.Windows.Forms.ComboBox()
        Me.CboIglesia = New System.Windows.Forms.ComboBox()
        Me.CboOficio = New System.Windows.Forms.ComboBox()
        Me.CboLugar = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNumeroT = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cambria", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(450, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 41)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tutor"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.BackColor = System.Drawing.Color.Transparent
        Me.BtnActualizar.BackgroundImage = Global.Misión.My.Resources.Resources.actualizar
        Me.BtnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizar.ForeColor = System.Drawing.Color.Black
        Me.BtnActualizar.Location = New System.Drawing.Point(250, 466)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(53, 41)
        Me.BtnActualizar.TabIndex = 136
        Me.BtnActualizar.UseVisualStyleBackColor = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.BtnGuardar.BackgroundImage = Global.Misión.My.Resources.Resources.guardar1
        Me.BtnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardar.ForeColor = System.Drawing.Color.Black
        Me.BtnGuardar.Location = New System.Drawing.Point(155, 466)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(53, 41)
        Me.BtnGuardar.TabIndex = 135
        Me.BtnGuardar.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Location = New System.Drawing.Point(491, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(554, 287)
        Me.DataGridView1.TabIndex = 141
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(-4, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1226, 45)
        Me.Panel1.TabIndex = 142
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtidiglesia)
        Me.GroupBox1.Controls.Add(Me.txtidparen)
        Me.GroupBox1.Controls.Add(Me.txtidlu)
        Me.GroupBox1.Controls.Add(Me.txtids)
        Me.GroupBox1.Controls.Add(Me.txtidof)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.TxtSalario)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CboSexo)
        Me.GroupBox1.Controls.Add(Me.TxtFechaNac)
        Me.GroupBox1.Controls.Add(Me.TxtNumeroC)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtDireccion)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CboParentesco)
        Me.GroupBox1.Controls.Add(Me.CboIglesia)
        Me.GroupBox1.Controls.Add(Me.CboOficio)
        Me.GroupBox1.Controls.Add(Me.CboLugar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtNumeroT)
        Me.GroupBox1.Controls.Add(Me.TxtApellido)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(453, 394)
        Me.GroupBox1.TabIndex = 143
        Me.GroupBox1.TabStop = False
        '
        'txtidiglesia
        '
        Me.txtidiglesia.Location = New System.Drawing.Point(324, 329)
        Me.txtidiglesia.Name = "txtidiglesia"
        Me.txtidiglesia.Size = New System.Drawing.Size(100, 20)
        Me.txtidiglesia.TabIndex = 103
        Me.txtidiglesia.Visible = False
        '
        'txtidparen
        '
        Me.txtidparen.Location = New System.Drawing.Point(6, 355)
        Me.txtidparen.Name = "txtidparen"
        Me.txtidparen.Size = New System.Drawing.Size(100, 20)
        Me.txtidparen.TabIndex = 104
        Me.txtidparen.Visible = False
        '
        'txtidlu
        '
        Me.txtidlu.Location = New System.Drawing.Point(218, 329)
        Me.txtidlu.Name = "txtidlu"
        Me.txtidlu.Size = New System.Drawing.Size(100, 20)
        Me.txtidlu.TabIndex = 102
        Me.txtidlu.Visible = False
        '
        'txtids
        '
        Me.txtids.Location = New System.Drawing.Point(112, 329)
        Me.txtids.Name = "txtids"
        Me.txtids.Size = New System.Drawing.Size(100, 20)
        Me.txtids.TabIndex = 101
        Me.txtids.Visible = False
        '
        'txtidof
        '
        Me.txtidof.Location = New System.Drawing.Point(6, 329)
        Me.txtidof.Name = "txtidof"
        Me.txtidof.Size = New System.Drawing.Size(100, 20)
        Me.txtidof.TabIndex = 100
        Me.txtidof.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(127, 150)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 17)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "Salario"
        '
        'TxtSalario
        '
        Me.TxtSalario.Location = New System.Drawing.Point(191, 147)
        Me.TxtSalario.Name = "TxtSalario"
        Me.TxtSalario.Size = New System.Drawing.Size(249, 20)
        Me.TxtSalario.TabIndex = 98
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(144, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Sexo"
        '
        'CboSexo
        '
        Me.CboSexo.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSexo.FormattingEnabled = True
        Me.CboSexo.Location = New System.Drawing.Point(191, 225)
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Size = New System.Drawing.Size(248, 20)
        Me.CboSexo.TabIndex = 96
        Me.CboSexo.Text = "Sexo"
        '
        'TxtFechaNac
        '
        Me.TxtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtFechaNac.Location = New System.Drawing.Point(191, 121)
        Me.TxtFechaNac.Name = "TxtFechaNac"
        Me.TxtFechaNac.Size = New System.Drawing.Size(249, 20)
        Me.TxtFechaNac.TabIndex = 95
        '
        'TxtNumeroC
        '
        Me.TxtNumeroC.Location = New System.Drawing.Point(191, 173)
        Me.TxtNumeroC.Name = "TxtNumeroC"
        Me.TxtNumeroC.Size = New System.Drawing.Size(248, 20)
        Me.TxtNumeroC.TabIndex = 94
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(47, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 17)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Número de Celular"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(36, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 17)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Fecha de Nacimiento"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(191, 95)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(249, 20)
        Me.TxtDireccion.TabIndex = 88
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(109, 98)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 17)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Dirección"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(100, 306)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 17)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Parentesco"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(131, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 17)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Iglesia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(136, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Oficio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(137, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Lugar"
        '
        'CboParentesco
        '
        Me.CboParentesco.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboParentesco.FormattingEnabled = True
        Me.CboParentesco.Location = New System.Drawing.Point(191, 303)
        Me.CboParentesco.Name = "CboParentesco"
        Me.CboParentesco.Size = New System.Drawing.Size(249, 20)
        Me.CboParentesco.TabIndex = 81
        Me.CboParentesco.Text = "Parentesco"
        '
        'CboIglesia
        '
        Me.CboIglesia.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboIglesia.FormattingEnabled = True
        Me.CboIglesia.Location = New System.Drawing.Point(191, 277)
        Me.CboIglesia.Name = "CboIglesia"
        Me.CboIglesia.Size = New System.Drawing.Size(249, 20)
        Me.CboIglesia.TabIndex = 3
        Me.CboIglesia.Text = "Iglesia"
        '
        'CboOficio
        '
        Me.CboOficio.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboOficio.FormattingEnabled = True
        Me.CboOficio.Location = New System.Drawing.Point(191, 199)
        Me.CboOficio.Name = "CboOficio"
        Me.CboOficio.Size = New System.Drawing.Size(249, 20)
        Me.CboOficio.TabIndex = 79
        Me.CboOficio.Text = "Oficio"
        '
        'CboLugar
        '
        Me.CboLugar.Font = New System.Drawing.Font("Cambria", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLugar.FormattingEnabled = True
        Me.CboLugar.Location = New System.Drawing.Point(191, 251)
        Me.CboLugar.Name = "CboLugar"
        Me.CboLugar.Size = New System.Drawing.Size(249, 20)
        Me.CboLugar.TabIndex = 78
        Me.CboLugar.Text = "Lugar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(36, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 17)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Número de Teléfono"
        '
        'TxtNumeroT
        '
        Me.TxtNumeroT.Location = New System.Drawing.Point(191, 69)
        Me.TxtNumeroT.Name = "TxtNumeroT"
        Me.TxtNumeroT.Size = New System.Drawing.Size(249, 20)
        Me.TxtNumeroT.TabIndex = 50
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(191, 43)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(249, 20)
        Me.TxtApellido.TabIndex = 44
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(191, 17)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(249, 20)
        Me.TxtNombre.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(49, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 17)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Apellido del Tutor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(53, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 17)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Nombre del Tutor"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(579, 75)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 144
        Me.TxtId.Visible = False
        '
        'FrmTutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1063, 521)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnActualizar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Name = "FrmTutor"
        Me.Text = "Tutor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtidiglesia As TextBox
    Friend WithEvents txtidparen As TextBox
    Friend WithEvents txtidlu As TextBox
    Friend WithEvents txtids As TextBox
    Friend WithEvents txtidof As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtSalario As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CboSexo As ComboBox
    Friend WithEvents TxtFechaNac As DateTimePicker
    Friend WithEvents TxtNumeroC As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CboParentesco As ComboBox
    Friend WithEvents CboIglesia As ComboBox
    Friend WithEvents CboOficio As ComboBox
    Friend WithEvents CboLugar As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNumeroT As TextBox
    Friend WithEvents TxtApellido As TextBox
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
End Class
