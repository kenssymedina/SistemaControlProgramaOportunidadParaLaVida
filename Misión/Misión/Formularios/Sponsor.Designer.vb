<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSponsor
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CboTipoSponsor = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CboPais = New System.Windows.Forms.ComboBox()
        Me.CboSexo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtCorreoE = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNombreSponsor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtIdPais = New System.Windows.Forms.TextBox()
        Me.TxtIdTipoSponsor = New System.Windows.Forms.TextBox()
        Me.TxtIdSexo = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CboTipoSponsor)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.CboPais)
        Me.Panel2.Controls.Add(Me.CboSexo)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.TxtCorreoE)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TxtNombreSponsor)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TxtDireccion)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(29, 149)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(427, 186)
        Me.Panel2.TabIndex = 1
        '
        'CboTipoSponsor
        '
        Me.CboTipoSponsor.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboTipoSponsor.FormattingEnabled = True
        Me.CboTipoSponsor.Location = New System.Drawing.Point(159, 143)
        Me.CboTipoSponsor.Name = "CboTipoSponsor"
        Me.CboTipoSponsor.Size = New System.Drawing.Size(254, 23)
        Me.CboTipoSponsor.TabIndex = 161
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(36, 148)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 18)
        Me.Label13.TabIndex = 160
        Me.Label13.Text = "Tipo de Sponsor"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(117, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(36, 18)
        Me.Label12.TabIndex = 159
        Me.Label12.Text = "País"
        '
        'CboPais
        '
        Me.CboPais.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboPais.FormattingEnabled = True
        Me.CboPais.Location = New System.Drawing.Point(159, 117)
        Me.CboPais.Name = "CboPais"
        Me.CboPais.Size = New System.Drawing.Size(254, 23)
        Me.CboPais.TabIndex = 158
        '
        'CboSexo
        '
        Me.CboSexo.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSexo.FormattingEnabled = True
        Me.CboSexo.Location = New System.Drawing.Point(159, 91)
        Me.CboSexo.Name = "CboSexo"
        Me.CboSexo.Size = New System.Drawing.Size(254, 23)
        Me.CboSexo.TabIndex = 157
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(113, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 18)
        Me.Label11.TabIndex = 156
        Me.Label11.Text = "Sexo"
        '
        'TxtCorreoE
        '
        Me.TxtCorreoE.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCorreoE.Location = New System.Drawing.Point(159, 65)
        Me.TxtCorreoE.Name = "TxtCorreoE"
        Me.TxtCorreoE.Size = New System.Drawing.Size(254, 23)
        Me.TxtCorreoE.TabIndex = 140
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(136, 18)
        Me.Label4.TabIndex = 141
        Me.Label4.Text = "Correo Eléctronico"
        '
        'TxtNombreSponsor
        '
        Me.TxtNombreSponsor.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreSponsor.Location = New System.Drawing.Point(159, 13)
        Me.TxtNombreSponsor.Name = "TxtNombreSponsor"
        Me.TxtNombreSponsor.Size = New System.Drawing.Size(254, 23)
        Me.TxtNombreSponsor.TabIndex = 138
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(87, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 134
        Me.Label5.Text = "Nombre "
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Calisto MT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(159, 39)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(254, 23)
        Me.TxtDireccion.TabIndex = 136
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 18)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Dirección"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calisto MT", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(99, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 34)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sponsor"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.Location = New System.Drawing.Point(476, 130)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(870, 287)
        Me.DataGridView1.TabIndex = 139
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
        'TxtIdPais
        '
        Me.TxtIdPais.Location = New System.Drawing.Point(59, 341)
        Me.TxtIdPais.Name = "TxtIdPais"
        Me.TxtIdPais.Size = New System.Drawing.Size(34, 20)
        Me.TxtIdPais.TabIndex = 146
        Me.TxtIdPais.Visible = False
        '
        'TxtIdTipoSponsor
        '
        Me.TxtIdTipoSponsor.Location = New System.Drawing.Point(29, 341)
        Me.TxtIdTipoSponsor.Name = "TxtIdTipoSponsor"
        Me.TxtIdTipoSponsor.Size = New System.Drawing.Size(27, 20)
        Me.TxtIdTipoSponsor.TabIndex = 145
        Me.TxtIdTipoSponsor.Visible = False
        '
        'TxtIdSexo
        '
        Me.TxtIdSexo.Location = New System.Drawing.Point(99, 341)
        Me.TxtIdSexo.Name = "TxtIdSexo"
        Me.TxtIdSexo.Size = New System.Drawing.Size(34, 20)
        Me.TxtIdSexo.TabIndex = 144
        Me.TxtIdSexo.Visible = False
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(139, 341)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(27, 20)
        Me.TxtId.TabIndex = 143
        Me.TxtId.Visible = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImage = Global.Misión.My.Resources.Resources.sponsor
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Location = New System.Drawing.Point(29, 12)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(64, 52)
        Me.PictureBox7.TabIndex = 162
        Me.PictureBox7.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BackgroundImage = Global.Misión.My.Resources.Resources.editar2
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(221, 413)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox2.TabIndex = 165
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Misión.My.Resources.Resources.nuevito2
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(146, 413)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox1.TabIndex = 164
        Me.PictureBox1.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global.Misión.My.Resources.Resources.volververde2
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(299, 413)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox5.TabIndex = 163
        Me.PictureBox5.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.BackgroundImage = Global.Misión.My.Resources.Resources.nuevo2
        Me.PictureBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox9.Location = New System.Drawing.Point(69, 413)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox9.TabIndex = 170
        Me.PictureBox9.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.BackgroundImage = Global.Misión.My.Resources.Resources.cerrarsesion
        Me.PictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox6.Location = New System.Drawing.Point(374, 413)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox6.TabIndex = 235
        Me.PictureBox6.TabStop = False
        '
        'FrmSponsor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.BackgroundImage = Global.Misión.My.Resources.Resources.fondo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1378, 570)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtIdPais)
        Me.Controls.Add(Me.TxtIdTipoSponsor)
        Me.Controls.Add(Me.TxtIdSexo)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "FrmSponsor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sponsor"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtCorreoE As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtNombreSponsor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CboTipoSponsor As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents CboPais As ComboBox
    Friend WithEvents CboSexo As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TxtIdPais As TextBox
    Friend WithEvents TxtIdTipoSponsor As TextBox
    Friend WithEvents TxtIdSexo As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
