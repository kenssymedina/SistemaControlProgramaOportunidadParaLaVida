<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuario
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
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.btnactualizar = New System.Windows.Forms.Button()
        Me.TxtContrasena = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboEstadoUsuario = New System.Windows.Forms.ComboBox()
        Me.BtnBuscarUsuario = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdUsuario = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(206, 192)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 127
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(54, 192)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.BtnNuevo.TabIndex = 126
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'btnactualizar
        '
        Me.btnactualizar.Location = New System.Drawing.Point(359, 192)
        Me.btnactualizar.Name = "btnactualizar"
        Me.btnactualizar.Size = New System.Drawing.Size(75, 23)
        Me.btnactualizar.TabIndex = 125
        Me.btnactualizar.Text = "Actualizar"
        Me.btnactualizar.UseVisualStyleBackColor = True
        '
        'TxtContrasena
        '
        Me.TxtContrasena.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContrasena.Location = New System.Drawing.Point(187, 107)
        Me.TxtContrasena.Name = "TxtContrasena"
        Me.TxtContrasena.Size = New System.Drawing.Size(216, 25)
        Me.TxtContrasena.TabIndex = 124
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(101, 110)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 18)
        Me.Label11.TabIndex = 123
        Me.Label11.Text = "Contraseña"
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(188, 81)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(216, 25)
        Me.TxtNombreUsuario.TabIndex = 122
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(66, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 18)
        Me.Label10.TabIndex = 121
        Me.Label10.Text = "Nombre Usuario"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(70, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 18)
        Me.Label5.TabIndex = 120
        Me.Label5.Text = "Estado Usuario"
        '
        'CboEstadoUsuario
        '
        Me.CboEstadoUsuario.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboEstadoUsuario.FormattingEnabled = True
        Me.CboEstadoUsuario.Location = New System.Drawing.Point(187, 133)
        Me.CboEstadoUsuario.Name = "CboEstadoUsuario"
        Me.CboEstadoUsuario.Size = New System.Drawing.Size(216, 26)
        Me.CboEstadoUsuario.TabIndex = 119
        '
        'BtnBuscarUsuario
        '
        Me.BtnBuscarUsuario.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscarUsuario.Location = New System.Drawing.Point(413, 42)
        Me.BtnBuscarUsuario.Name = "BtnBuscarUsuario"
        Me.BtnBuscarUsuario.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscarUsuario.TabIndex = 118
        Me.BtnBuscarUsuario.Text = "..."
        Me.BtnBuscarUsuario.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(119, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 18)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Numero"
        '
        'txtIdUsuario
        '
        Me.txtIdUsuario.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdUsuario.Location = New System.Drawing.Point(188, 45)
        Me.txtIdUsuario.Name = "txtIdUsuario"
        Me.txtIdUsuario.ReadOnly = True
        Me.txtIdUsuario.Size = New System.Drawing.Size(216, 25)
        Me.txtIdUsuario.TabIndex = 116
        '
        'FrmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Misión.My.Resources.Resources.fonditooo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(526, 257)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.btnactualizar)
        Me.Controls.Add(Me.TxtContrasena)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtNombreUsuario)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CboEstadoUsuario)
        Me.Controls.Add(Me.BtnBuscarUsuario)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtIdUsuario)
        Me.DoubleBuffered = True
        Me.Name = "FrmUsuario"
        Me.Text = "FrmUsuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnNuevo As Button
    Friend WithEvents btnactualizar As Button
    Friend WithEvents TxtContrasena As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtNombreUsuario As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CboEstadoUsuario As ComboBox
    Friend WithEvents BtnBuscarUsuario As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtIdUsuario As TextBox
End Class
