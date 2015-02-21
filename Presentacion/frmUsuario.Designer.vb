<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuario

    Inherits MetroFramework.Forms.MetroForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuario))
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.btnVerificarUserDisponible = New System.Windows.Forms.Button()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.btnAgregarEmpleado = New System.Windows.Forms.Button()
        Me.txtEmpleado = New System.Windows.Forms.Button()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.cboTipoUsuario = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtUser = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.MetroTabControl2 = New MetroFramework.Controls.MetroTabControl()
        Me.gbListado = New MetroFramework.Controls.MetroTabPage()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtUsuario = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.MetroTabControl2.SuspendLayout()
        Me.gbListado.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.AutoSize = True
        Me.Button6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(0, 1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(204, 57)
        Me.Button6.TabIndex = 163
        Me.Button6.UseCompatibleTextRendering = True
        Me.Button6.UseVisualStyleBackColor = False
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.AutoSize = True
        Me.MetroTile2.BackColor = System.Drawing.Color.DodgerBlue
        Me.MetroTile2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MetroTile2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTile2.Location = New System.Drawing.Point(0, 1)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(1064, 64)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTile2.TabIndex = 162
        Me.MetroTile2.Text = "REGISTRAR USUARIO"
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroTile2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroTile2.UseCustomBackColor = True
        Me.MetroTile2.UseSelectable = True
        Me.MetroTile2.UseStyleColors = True
        Me.MetroTile2.UseTileImage = True
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.AllowDrop = True
        Me.MetroTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
        Me.MetroTabControl1.Location = New System.Drawing.Point(9, 71)
        Me.MetroTabControl1.Multiline = True
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(511, 333)
        Me.MetroTabControl1.TabIndex = 169
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MetroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroTabPage1.Controls.Add(Me.gbDatos)
        Me.MetroTabPage1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 41)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MetroTabPage1.Size = New System.Drawing.Size(503, 288)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "DATOS"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'gbDatos
        '
        Me.gbDatos.BackColor = System.Drawing.Color.White
        Me.gbDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbDatos.Controls.Add(Me.btnVerificarUserDisponible)
        Me.gbDatos.Controls.Add(Me.txtclave)
        Me.gbDatos.Controls.Add(Me.btnAgregarEmpleado)
        Me.gbDatos.Controls.Add(Me.txtEmpleado)
        Me.gbDatos.Controls.Add(Me.MetroLabel9)
        Me.gbDatos.Controls.Add(Me.cboTipoUsuario)
        Me.gbDatos.Controls.Add(Me.MetroLabel7)
        Me.gbDatos.Controls.Add(Me.MetroLabel3)
        Me.gbDatos.Controls.Add(Me.txtUser)
        Me.gbDatos.Controls.Add(Me.MetroLabel4)
        Me.gbDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos.ForeColor = System.Drawing.Color.Black
        Me.gbDatos.Location = New System.Drawing.Point(3, 16)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(504, 266)
        Me.gbDatos.TabIndex = 43
        Me.gbDatos.TabStop = False
        Me.gbDatos.Text = "DATOS"
        '
        'btnVerificarUserDisponible
        '
        Me.btnVerificarUserDisponible.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificarUserDisponible.Location = New System.Drawing.Point(419, 128)
        Me.btnVerificarUserDisponible.Name = "btnVerificarUserDisponible"
        Me.btnVerificarUserDisponible.Size = New System.Drawing.Size(78, 29)
        Me.btnVerificarUserDisponible.TabIndex = 173
        Me.btnVerificarUserDisponible.Text = "Verificar"
        Me.btnVerificarUserDisponible.UseVisualStyleBackColor = True
        '
        'txtclave
        '
        Me.txtclave.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtclave.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer), CType(CType(159, Byte), Integer))
        Me.txtclave.Location = New System.Drawing.Point(114, 177)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtclave.Size = New System.Drawing.Size(299, 25)
        Me.txtclave.TabIndex = 172
        Me.txtclave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAgregarEmpleado
        '
        Me.btnAgregarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarEmpleado.Location = New System.Drawing.Point(419, 25)
        Me.btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        Me.btnAgregarEmpleado.Size = New System.Drawing.Size(78, 29)
        Me.btnAgregarEmpleado.TabIndex = 171
        Me.btnAgregarEmpleado.Text = "Agregar"
        Me.btnAgregarEmpleado.UseVisualStyleBackColor = True
        '
        'txtEmpleado
        '
        Me.txtEmpleado.AutoSize = True
        Me.txtEmpleado.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.txtEmpleado.Enabled = False
        Me.txtEmpleado.FlatAppearance.BorderSize = 0
        Me.txtEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.txtEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.txtEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtEmpleado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtEmpleado.ForeColor = System.Drawing.Color.White
        Me.txtEmpleado.Location = New System.Drawing.Point(114, 25)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(299, 29)
        Me.txtEmpleado.TabIndex = 170
        Me.txtEmpleado.UseCompatibleTextRendering = True
        Me.txtEmpleado.UseVisualStyleBackColor = False
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(16, 31)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel9.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel9.TabIndex = 19
        Me.MetroLabel9.Text = "EMPLEADO"
        Me.MetroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel9.UseCustomBackColor = True
        Me.MetroLabel9.UseCustomForeColor = True
        Me.MetroLabel9.UseStyleColors = True
        '
        'cboTipoUsuario
        '
        Me.cboTipoUsuario.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cboTipoUsuario.FormattingEnabled = True
        Me.cboTipoUsuario.ItemHeight = 19
        Me.cboTipoUsuario.Location = New System.Drawing.Point(114, 78)
        Me.cboTipoUsuario.Name = "cboTipoUsuario"
        Me.cboTipoUsuario.Size = New System.Drawing.Size(299, 25)
        Me.cboTipoUsuario.TabIndex = 18
        Me.cboTipoUsuario.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(10, 78)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel7.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel7.TabIndex = 16
        Me.MetroLabel7.Text = "TIPO USUARIO"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel7.UseCustomBackColor = True
        Me.MetroLabel7.UseCustomForeColor = True
        Me.MetroLabel7.UseStyleColors = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(16, 131)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(71, 19)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel3.TabIndex = 13
        Me.MetroLabel3.Text = "UserName"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        Me.MetroLabel3.UseStyleColors = True
        '
        'txtUser
        '
        Me.txtUser.Lines = New String(-1) {}
        Me.txtUser.Location = New System.Drawing.Point(114, 131)
        Me.txtUser.MaxLength = 32767
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUser.SelectedText = ""
        Me.txtUser.Size = New System.Drawing.Size(299, 23)
        Me.txtUser.TabIndex = 3
        Me.txtUser.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(16, 184)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel4.TabIndex = 0
        Me.MetroLabel4.Text = "CLAVE"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        Me.MetroLabel4.UseStyleColors = True
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Black
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(18, -1)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 72)
        Me.btnNuevo.TabIndex = 172
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'MetroTabControl2
        '
        Me.MetroTabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MetroTabControl2.Controls.Add(Me.gbListado)
        Me.MetroTabControl2.Location = New System.Drawing.Point(542, 71)
        Me.MetroTabControl2.Multiline = True
        Me.MetroTabControl2.Name = "MetroTabControl2"
        Me.MetroTabControl2.SelectedIndex = 0
        Me.MetroTabControl2.Size = New System.Drawing.Size(522, 329)
        Me.MetroTabControl2.TabIndex = 170
        Me.MetroTabControl2.UseSelectable = True
        '
        'gbListado
        '
        Me.gbListado.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.gbListado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbListado.Controls.Add(Me.dgvUsuarios)
        Me.gbListado.Controls.Add(Me.btnBuscar)
        Me.gbListado.Controls.Add(Me.txtUsuario)
        Me.gbListado.Controls.Add(Me.MetroLabel1)
        Me.gbListado.ForeColor = System.Drawing.Color.DodgerBlue
        Me.gbListado.HorizontalScrollbarBarColor = True
        Me.gbListado.HorizontalScrollbarHighlightOnWheel = True
        Me.gbListado.HorizontalScrollbarSize = 10
        Me.gbListado.Location = New System.Drawing.Point(4, 41)
        Me.gbListado.Name = "gbListado"
        Me.gbListado.Size = New System.Drawing.Size(514, 284)
        Me.gbListado.TabIndex = 0
        Me.gbListado.Text = "LISTA USUARIO"
        Me.gbListado.Theme = MetroFramework.MetroThemeStyle.Light
        Me.gbListado.VerticalScrollbarBarColor = True
        Me.gbListado.VerticalScrollbarHighlightOnWheel = False
        Me.gbListado.VerticalScrollbarSize = 10
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column2, Me.Column4})
        Me.dgvUsuarios.Location = New System.Drawing.Point(12, 94)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.Size = New System.Drawing.Size(499, 188)
        Me.dgvUsuarios.TabIndex = 162
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "NombreEmpleado"
        Me.Column3.HeaderText = "EMPLEADO"
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "NombTipoUsuario"
        Me.Column2.HeaderText = "TIPO"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Nombre"
        Me.Column4.HeaderText = "USERNAME"
        Me.Column4.Name = "Column4"
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.BackgroundImage = CType(resources.GetObject("btnBuscar.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscar.ForeColor = System.Drawing.Color.White
        Me.btnBuscar.Location = New System.Drawing.Point(420, 34)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(37, 32)
        Me.btnBuscar.TabIndex = 161
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtUsuario.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtUsuario.Lines = New String(-1) {}
        Me.txtUsuario.Location = New System.Drawing.Point(118, 38)
        Me.txtUsuario.MaxLength = 32767
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtUsuario.SelectedText = ""
        Me.txtUsuario.Size = New System.Drawing.Size(285, 23)
        Me.txtUsuario.TabIndex = 160
        Me.txtUsuario.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 16)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(116, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel1.TabIndex = 157
        Me.MetroLabel1.Text = "BUSQUEDA POR :"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        Me.MetroLabel1.UseStyleColors = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(16, 406)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 68)
        Me.Panel1.TabIndex = 174
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.White
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelar.Location = New System.Drawing.Point(444, -1)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 72)
        Me.btnCancelar.TabIndex = 150
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(351, -1)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 72)
        Me.btnGuardar.TabIndex = 149
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Me.btnNuevo)
        Me.Panel2.Location = New System.Drawing.Point(558, 406)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(499, 68)
        Me.Panel2.TabIndex = 175
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(423, -1)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(72, 72)
        Me.btnSalir.TabIndex = 174
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Transparent
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Image = CType(resources.GetObject("btnModificar.Image"), System.Drawing.Image)
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnModificar.Location = New System.Drawing.Point(106, -2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(72, 72)
        Me.btnModificar.TabIndex = 173
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'frmUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 480)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroTabControl2)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.MetroTile2)
        Me.Name = "frmUsuario"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.MetroTabControl2.ResumeLayout(False)
        Me.gbListado.ResumeLayout(False)
        Me.gbListado.PerformLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents gbDatos As System.Windows.Forms.GroupBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboTipoUsuario As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtUser As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Public WithEvents txtEmpleado As System.Windows.Forms.Button
    Friend WithEvents MetroTabControl2 As MetroFramework.Controls.MetroTabControl
    Private WithEvents gbListado As MetroFramework.Controls.MetroTabPage
    Friend WithEvents dgvUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtUsuario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnAgregarEmpleado As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtclave As System.Windows.Forms.TextBox
    Friend WithEvents btnVerificarUserDisponible As System.Windows.Forms.Button
End Class
