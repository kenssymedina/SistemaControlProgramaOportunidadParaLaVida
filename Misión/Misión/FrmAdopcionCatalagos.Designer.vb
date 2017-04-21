<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdopcionCatalagos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.DgvDetallesAdopcion = New System.Windows.Forms.DataGridView()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvDetallesAdopcion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calisto MT", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(85, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calisto MT", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(280, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 34)
        Me.Label3.TabIndex = 198
        Me.Label3.Text = "Buscar  Adopcion"
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global.Misión.My.Resources.Resources.busqueda11
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Location = New System.Drawing.Point(616, 82)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(49, 51)
        Me.PictureBox5.TabIndex = 197
        Me.PictureBox5.TabStop = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI Light", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(166, 82)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(435, 32)
        Me.txtBuscar.TabIndex = 196
        '
        'DgvDetallesAdopcion
        '
        Me.DgvDetallesAdopcion.BackgroundColor = System.Drawing.Color.White
        Me.DgvDetallesAdopcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetallesAdopcion.Location = New System.Drawing.Point(76, 144)
        Me.DgvDetallesAdopcion.Name = "DgvDetallesAdopcion"
        Me.DgvDetallesAdopcion.Size = New System.Drawing.Size(673, 228)
        Me.DgvDetallesAdopcion.TabIndex = 195
        '
        'FrmAdopcionCatalagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Misión.My.Resources.Resources.fonditooo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(825, 419)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.DgvDetallesAdopcion)
        Me.DoubleBuffered = True
        Me.Name = "FrmAdopcionCatalagos"
        Me.Text = "FrmAdopcionCatalagos"
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvDetallesAdopcion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents DgvDetallesAdopcion As DataGridView
End Class
