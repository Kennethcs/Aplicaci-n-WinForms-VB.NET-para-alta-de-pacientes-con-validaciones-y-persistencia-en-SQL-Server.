<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblTipoID = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblPrimerApellido = New System.Windows.Forms.Label()
        Me.lblSegundoApellido = New System.Windows.Forms.Label()
        Me.cmbTipoID = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.mskID = New System.Windows.Forms.MaskedTextBox()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.grbAcciones = New System.Windows.Forms.GroupBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.lblFechaAdmision = New System.Windows.Forms.Label()
        Me.dtpFechaAdmision = New System.Windows.Forms.DateTimePicker()
        Me.grbAcciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTipoID
        '
        Me.lblTipoID.AutoSize = True
        Me.lblTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoID.Location = New System.Drawing.Point(48, 33)
        Me.lblTipoID.Name = "lblTipoID"
        Me.lblTipoID.Size = New System.Drawing.Size(181, 18)
        Me.lblTipoID.TabIndex = 1
        Me.lblTipoID.Text = "TIPO IDENTIFICACION"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(272, 33)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(138, 18)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "IDENTIFICACION"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(489, 31)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(81, 18)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "NOMBRE"
        '
        'lblPrimerApellido
        '
        Me.lblPrimerApellido.AutoSize = True
        Me.lblPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrimerApellido.Location = New System.Drawing.Point(694, 31)
        Me.lblPrimerApellido.Name = "lblPrimerApellido"
        Me.lblPrimerApellido.Size = New System.Drawing.Size(156, 18)
        Me.lblPrimerApellido.TabIndex = 4
        Me.lblPrimerApellido.Text = "PRIMER APELLIDO"
        '
        'lblSegundoApellido
        '
        Me.lblSegundoApellido.AutoSize = True
        Me.lblSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSegundoApellido.Location = New System.Drawing.Point(933, 31)
        Me.lblSegundoApellido.Name = "lblSegundoApellido"
        Me.lblSegundoApellido.Size = New System.Drawing.Size(176, 18)
        Me.lblSegundoApellido.TabIndex = 5
        Me.lblSegundoApellido.Text = "SEGUNDO APELLIDO"
        '
        'cmbTipoID
        '
        Me.cmbTipoID.FormattingEnabled = True
        Me.cmbTipoID.Items.AddRange(New Object() {"NACIONAL", "DIMEX", "PASAPORTE"})
        Me.cmbTipoID.Location = New System.Drawing.Point(73, 54)
        Me.cmbTipoID.Name = "cmbTipoID"
        Me.cmbTipoID.Size = New System.Drawing.Size(121, 24)
        Me.cmbTipoID.TabIndex = 6
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(462, 52)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(138, 22)
        Me.txtNombre.TabIndex = 7
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.Location = New System.Drawing.Point(676, 54)
        Me.txtPrimerApellido.MaxLength = 30
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(201, 22)
        Me.txtPrimerApellido.TabIndex = 8
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.Location = New System.Drawing.Point(927, 52)
        Me.txtSegundoApellido.MaxLength = 30
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(191, 22)
        Me.txtSegundoApellido.TabIndex = 9
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(70, 158)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(170, 18)
        Me.lblFecha.TabIndex = 10
        Me.lblFecha.Text = "FECHA NACIMIENTO"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(35, 179)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(245, 22)
        Me.dtpFechaNacimiento.TabIndex = 11
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorreo.Location = New System.Drawing.Point(459, 156)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(81, 18)
        Me.lblCorreo.TabIndex = 12
        Me.lblCorreo.Text = "CORREO"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(346, 175)
        Me.txtCorreo.MaxLength = 50
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(324, 22)
        Me.txtCorreo.TabIndex = 14
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(107, 232)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(100, 18)
        Me.lblDireccion.TabIndex = 16
        Me.lblDireccion.Text = "DIRECCION"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(82, 251)
        Me.txtDireccion.MaxLength = 100
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(518, 48)
        Me.txtDireccion.TabIndex = 17
        '
        'mskID
        '
        Me.mskID.Location = New System.Drawing.Point(275, 54)
        Me.mskID.Mask = "9-9999-9999"
        Me.mskID.Name = "mskID"
        Me.mskID.Size = New System.Drawing.Size(132, 22)
        Me.mskID.TabIndex = 18
        '
        'btnInsertar
        '
        Me.btnInsertar.BackColor = System.Drawing.Color.YellowGreen
        Me.btnInsertar.Location = New System.Drawing.Point(54, 34)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(103, 39)
        Me.btnInsertar.TabIndex = 19
        Me.btnInsertar.Text = "&INSERTAR"
        Me.btnInsertar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Tomato
        Me.btnSalir.Location = New System.Drawing.Point(54, 159)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(103, 39)
        Me.btnSalir.TabIndex = 20
        Me.btnSalir.Text = "&SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'grbAcciones
        '
        Me.grbAcciones.Controls.Add(Me.btnLimpiar)
        Me.grbAcciones.Controls.Add(Me.btnInsertar)
        Me.grbAcciones.Controls.Add(Me.btnSalir)
        Me.grbAcciones.Location = New System.Drawing.Point(1043, 156)
        Me.grbAcciones.Name = "grbAcciones"
        Me.grbAcciones.Size = New System.Drawing.Size(200, 209)
        Me.grbAcciones.TabIndex = 21
        Me.grbAcciones.TabStop = False
        Me.grbAcciones.Text = "ACCIONES"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnLimpiar.Location = New System.Drawing.Point(54, 101)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(103, 39)
        Me.btnLimpiar.TabIndex = 21
        Me.btnLimpiar.Text = "&LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'lblFechaAdmision
        '
        Me.lblFechaAdmision.AutoSize = True
        Me.lblFechaAdmision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaAdmision.Location = New System.Drawing.Point(793, 156)
        Me.lblFechaAdmision.Name = "lblFechaAdmision"
        Me.lblFechaAdmision.Size = New System.Drawing.Size(148, 18)
        Me.lblFechaAdmision.TabIndex = 22
        Me.lblFechaAdmision.Text = "FECHA ADMISION"
        '
        'dtpFechaAdmision
        '
        Me.dtpFechaAdmision.Location = New System.Drawing.Point(738, 177)
        Me.dtpFechaAdmision.Name = "dtpFechaAdmision"
        Me.dtpFechaAdmision.Size = New System.Drawing.Size(245, 22)
        Me.dtpFechaAdmision.TabIndex = 23
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1310, 425)
        Me.Controls.Add(Me.dtpFechaAdmision)
        Me.Controls.Add(Me.lblFechaAdmision)
        Me.Controls.Add(Me.mskID)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.lblCorreo)
        Me.Controls.Add(Me.dtpFechaNacimiento)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.txtSegundoApellido)
        Me.Controls.Add(Me.txtPrimerApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.cmbTipoID)
        Me.Controls.Add(Me.lblSegundoApellido)
        Me.Controls.Add(Me.lblPrimerApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.lblTipoID)
        Me.Controls.Add(Me.grbAcciones)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grbAcciones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTipoID As Label
    Friend WithEvents lblID As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblPrimerApellido As Label
    Friend WithEvents lblSegundoApellido As Label
    Friend WithEvents cmbTipoID As ComboBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPrimerApellido As TextBox
    Friend WithEvents txtSegundoApellido As TextBox
    Friend WithEvents lblFecha As Label
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents mskID As MaskedTextBox
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents grbAcciones As GroupBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents lblFechaAdmision As Label
    Friend WithEvents dtpFechaAdmision As DateTimePicker
End Class
