<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Location = New System.Drawing.Point(510, 143)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(856, 287)
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
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
        Me.GroupBox1.Size = New System.Drawing.Size(477, 368)
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
        Me.txtidparen.Location = New System.Drawing.Point(4, 313)
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
        Me.Label12.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(130, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 18)
        Me.Label12.TabIndex = 99
        Me.Label12.Text = "Salario"
        '
        'TxtSalario
        '
        Me.TxtSalario.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSalario.Location = New System.Drawing.Point(190, 147)
        Me.TxtSalario.Name = "TxtSalario"
        Me.TxtSalario.Size = New System.Drawing.Size(249, 23)
        Me.TxtSalario.TabIndex = 98
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(145, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 18)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "Sexo"
        '
        'CboSexo
        '
        Me.CboSexo.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSexo.FormattingEnabled = True
        Me.CboSexo.Location = New System.Drawing.Point(191, 68)
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Size = New System.Drawing.Size(248, 23)
        Me.CboSexo.TabIndex = 96
        Me.CboSexo.Text = "Sexo"
        '
        'TxtFechaNac
        '
        Me.TxtFechaNac.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TxtFechaNac.Location = New System.Drawing.Point(190, 279)
        Me.TxtFechaNac.Name = "TxtFechaNac"
        Me.TxtFechaNac.Size = New System.Drawing.Size(249, 23)
        Me.TxtFechaNac.TabIndex = 95
        '
        'TxtNumeroC
        '
        Me.TxtNumeroC.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroC.Location = New System.Drawing.Point(190, 201)
        Me.TxtNumeroC.Name = "TxtNumeroC"
        Me.TxtNumeroC.Size = New System.Drawing.Size(250, 23)
        Me.TxtNumeroC.TabIndex = 94
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(129, 206)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 18)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Celular"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(37, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 18)
        Me.Label10.TabIndex = 89
        Me.Label10.Text = "Fecha de Nacimiento"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(190, 253)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(249, 23)
        Me.TxtDireccion.TabIndex = 88
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(111, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 18)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Dirección"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(104, 311)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 18)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "Parentesco"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(134, 126)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 18)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Iglesia"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(135, 179)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 18)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Oficio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(137, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Lugar"
        '
        'CboParentesco
        '
        Me.CboParentesco.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboParentesco.FormattingEnabled = True
        Me.CboParentesco.Location = New System.Drawing.Point(190, 306)
        Me.CboParentesco.Name = "CboParentesco"
        Me.CboParentesco.Size = New System.Drawing.Size(249, 23)
        Me.CboParentesco.TabIndex = 81
        Me.CboParentesco.Text = "Parentesco"
        '
        'CboIglesia
        '
        Me.CboIglesia.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboIglesia.FormattingEnabled = True
        Me.CboIglesia.Location = New System.Drawing.Point(190, 121)
        Me.CboIglesia.Name = "CboIglesia"
        Me.CboIglesia.Size = New System.Drawing.Size(249, 23)
        Me.CboIglesia.TabIndex = 3
        Me.CboIglesia.Text = "Iglesia"
        '
        'CboOficio
        '
        Me.CboOficio.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboOficio.FormattingEnabled = True
        Me.CboOficio.Location = New System.Drawing.Point(190, 174)
        Me.CboOficio.Name = "CboOficio"
        Me.CboOficio.Size = New System.Drawing.Size(249, 23)
        Me.CboOficio.TabIndex = 79
        Me.CboOficio.Text = "Oficio"
        '
        'CboLugar
        '
        Me.CboLugar.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboLugar.FormattingEnabled = True
        Me.CboLugar.Location = New System.Drawing.Point(190, 94)
        Me.CboLugar.Name = "CboLugar"
        Me.CboLugar.Size = New System.Drawing.Size(249, 23)
        Me.CboLugar.TabIndex = 78
        Me.CboLugar.Text = "Lugar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(117, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 18)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Teléfono"
        '
        'TxtNumeroT
        '
        Me.TxtNumeroT.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNumeroT.Location = New System.Drawing.Point(190, 227)
        Me.TxtNumeroT.Name = "TxtNumeroT"
        Me.TxtNumeroT.Size = New System.Drawing.Size(249, 23)
        Me.TxtNumeroT.TabIndex = 50
        '
        'TxtApellido
        '
        Me.TxtApellido.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido.Location = New System.Drawing.Point(191, 42)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(249, 23)
        Me.TxtApellido.TabIndex = 44
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(191, 17)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(249, 23)
        Me.TxtNombre.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(121, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Apellido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(123, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 18)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Nombre"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(579, 75)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(100, 20)
        Me.TxtId.TabIndex = 144
        Me.TxtId.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calisto MT", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 34)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "Tutor"
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = Global.Misión.My.Resources.Resources.family_2561
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(35, 8)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(64, 52)
        Me.PictureBox6.TabIndex = 228
        Me.PictureBox6.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.BackgroundImage = Global.Misión.My.Resources.Resources.cerrarsesion
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(372, 481)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox3.TabIndex = 233
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.BackgroundImage = Global.Misión.My.Resources.Resources.nuevo
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(65, 481)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox4.TabIndex = 232
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Misión.My.Resources.Resources.editar
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(221, 481)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox2.TabIndex = 231
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Misión.My.Resources.Resources.nuevito
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(142, 481)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox1.TabIndex = 230
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global.Misión.My.Resources.Resources.volververde
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(299, 481)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox5.TabIndex = 229
        Me.PictureBox5.TabStop = False
        '
        'FrmTutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Misión.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1378, 570)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmTutor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tutor"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
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
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
End Class
