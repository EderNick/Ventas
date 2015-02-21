<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSucursal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSucursal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.gbDatos = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboDistrito = New System.Windows.Forms.ComboBox()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.cboDepartamento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCorreo = New MetroFramework.Controls.MetroTextBox()
        Me.txtTelefono = New MetroFramework.Controls.MetroTextBox()
        Me.txtDireccion = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl2 = New MetroFramework.Controls.MetroTabControl()
        Me.gbListado = New MetroFramework.Controls.MetroTabPage()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtSucursal = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.dgvSucursal = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZonaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.gbDatos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MetroTabControl2.SuspendLayout()
        Me.gbListado.SuspendLayout()
        CType(Me.dgvSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Button6.Location = New System.Drawing.Point(0, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(141, 57)
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
        Me.MetroTile2.Location = New System.Drawing.Point(0, 4)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(1065, 64)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTile2.TabIndex = 162
        Me.MetroTile2.Text = "REGISTRO  SUCURSAL"
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
        Me.MetroTabControl1.Location = New System.Drawing.Point(13, 83)
        Me.MetroTabControl1.Multiline = True
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(489, 398)
        Me.MetroTabControl1.TabIndex = 0
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
        Me.MetroTabPage1.Size = New System.Drawing.Size(481, 353)
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
        Me.gbDatos.Controls.Add(Me.GroupBox1)
        Me.gbDatos.Controls.Add(Me.txtCorreo)
        Me.gbDatos.Controls.Add(Me.txtTelefono)
        Me.gbDatos.Controls.Add(Me.txtDireccion)
        Me.gbDatos.Controls.Add(Me.MetroLabel8)
        Me.gbDatos.Controls.Add(Me.MetroLabel4)
        Me.gbDatos.Controls.Add(Me.MetroLabel3)
        Me.gbDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatos.ForeColor = System.Drawing.Color.Black
        Me.gbDatos.Location = New System.Drawing.Point(0, 3)
        Me.gbDatos.Name = "gbDatos"
        Me.gbDatos.Size = New System.Drawing.Size(478, 280)
        Me.gbDatos.TabIndex = 86
        Me.gbDatos.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboDistrito)
        Me.GroupBox1.Controls.Add(Me.cboProvincia)
        Me.GroupBox1.Controls.Add(Me.cboDepartamento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(437, 102)
        Me.GroupBox1.TabIndex = 172
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ZONA"
        '
        'cboDistrito
        '
        Me.cboDistrito.FormattingEnabled = True
        Me.cboDistrito.Location = New System.Drawing.Point(301, 48)
        Me.cboDistrito.Name = "cboDistrito"
        Me.cboDistrito.Size = New System.Drawing.Size(121, 24)
        Me.cboDistrito.TabIndex = 5
        '
        'cboProvincia
        '
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(165, 48)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(121, 24)
        Me.cboProvincia.TabIndex = 4
        '
        'cboDepartamento
        '
        Me.cboDepartamento.FormattingEnabled = True
        Me.cboDepartamento.Location = New System.Drawing.Point(28, 48)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Size = New System.Drawing.Size(121, 24)
        Me.cboDepartamento.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Departamento"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Provincia"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(302, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Distrito"
        '
        'txtCorreo
        '
        Me.txtCorreo.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtCorreo.Lines = New String(-1) {}
        Me.txtCorreo.Location = New System.Drawing.Point(109, 73)
        Me.txtCorreo.MaxLength = 32767
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCorreo.SelectedText = ""
        Me.txtCorreo.Size = New System.Drawing.Size(303, 23)
        Me.txtCorreo.TabIndex = 2
        Me.txtCorreo.UseSelectable = True
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtTelefono.Lines = New String(-1) {}
        Me.txtTelefono.Location = New System.Drawing.Point(109, 237)
        Me.txtTelefono.MaxLength = 32767
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelefono.SelectedText = ""
        Me.txtTelefono.Size = New System.Drawing.Size(303, 23)
        Me.txtTelefono.TabIndex = 4
        Me.txtTelefono.UseSelectable = True
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtDireccion.Lines = New String(-1) {}
        Me.txtDireccion.Location = New System.Drawing.Point(109, 30)
        Me.txtDireccion.MaxLength = 32767
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDireccion.SelectedText = ""
        Me.txtDireccion.Size = New System.Drawing.Size(303, 23)
        Me.txtDireccion.TabIndex = 1
        Me.txtDireccion.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(16, 30)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(77, 19)
        Me.MetroLabel8.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel8.TabIndex = 171
        Me.MetroLabel8.Text = "DIRECCION"
        Me.MetroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel8.UseCustomBackColor = True
        Me.MetroLabel8.UseCustomForeColor = True
        Me.MetroLabel8.UseStyleColors = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(19, 73)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel4.TabIndex = 43
        Me.MetroLabel4.Text = "CORREO"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        Me.MetroLabel4.UseStyleColors = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(16, 237)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel3.TabIndex = 42
        Me.MetroLabel3.Text = "TELEFONO"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        Me.MetroLabel3.UseStyleColors = True
        '
        'MetroTabControl2
        '
        Me.MetroTabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MetroTabControl2.Controls.Add(Me.gbListado)
        Me.MetroTabControl2.Location = New System.Drawing.Point(520, 83)
        Me.MetroTabControl2.Multiline = True
        Me.MetroTabControl2.Name = "MetroTabControl2"
        Me.MetroTabControl2.SelectedIndex = 0
        Me.MetroTabControl2.Size = New System.Drawing.Size(543, 311)
        Me.MetroTabControl2.TabIndex = 168
        Me.MetroTabControl2.UseSelectable = True
        '
        'gbListado
        '
        Me.gbListado.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.gbListado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbListado.Controls.Add(Me.btnBuscar)
        Me.gbListado.Controls.Add(Me.txtSucursal)
        Me.gbListado.Controls.Add(Me.MetroLabel10)
        Me.gbListado.Controls.Add(Me.dgvSucursal)
        Me.gbListado.ForeColor = System.Drawing.Color.DodgerBlue
        Me.gbListado.HorizontalScrollbarBarColor = True
        Me.gbListado.HorizontalScrollbarHighlightOnWheel = True
        Me.gbListado.HorizontalScrollbarSize = 10
        Me.gbListado.Location = New System.Drawing.Point(4, 41)
        Me.gbListado.Name = "gbListado"
        Me.gbListado.Size = New System.Drawing.Size(535, 266)
        Me.gbListado.TabIndex = 0
        Me.gbListado.Text = "LISTA SUCURSAL"
        Me.gbListado.Theme = MetroFramework.MetroThemeStyle.Light
        Me.gbListado.VerticalScrollbarBarColor = True
        Me.gbListado.VerticalScrollbarHighlightOnWheel = False
        Me.gbListado.VerticalScrollbarSize = 10
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
        Me.btnBuscar.Location = New System.Drawing.Point(326, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(37, 32)
        Me.btnBuscar.TabIndex = 1
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtSucursal
        '
        Me.txtSucursal.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtSucursal.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtSucursal.Lines = New String(-1) {}
        Me.txtSucursal.Location = New System.Drawing.Point(111, 24)
        Me.txtSucursal.MaxLength = 32767
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSucursal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSucursal.SelectedText = ""
        Me.txtSucursal.Size = New System.Drawing.Size(194, 23)
        Me.txtSucursal.TabIndex = 0
        Me.txtSucursal.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel10.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel10.Location = New System.Drawing.Point(3, 13)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(81, 19)
        Me.MetroLabel10.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel10.TabIndex = 157
        Me.MetroLabel10.Text = "BUSQUEDA:"
        Me.MetroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel10.UseCustomBackColor = True
        Me.MetroLabel10.UseCustomForeColor = True
        Me.MetroLabel10.UseStyleColors = True
        '
        'dgvSucursal
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.dgvSucursal.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSucursal.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvSucursal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSucursal.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Direccion, Me.ZonaNombre, Me.Correo, Me.Telefono})
        Me.dgvSucursal.Location = New System.Drawing.Point(4, 76)
        Me.dgvSucursal.Name = "dgvSucursal"
        Me.dgvSucursal.Size = New System.Drawing.Size(532, 187)
        Me.dgvSucursal.TabIndex = 144
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(16, 413)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(479, 68)
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
        Me.btnCancelar.Location = New System.Drawing.Point(397, -2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 72)
        Me.btnCancelar.TabIndex = 5
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
        Me.btnGuardar.Location = New System.Drawing.Point(299, -2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 72)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
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
        Me.btnSalir.Location = New System.Drawing.Point(457, -2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(72, 72)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
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
        Me.btnNuevo.Location = New System.Drawing.Point(24, -2)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 72)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
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
        Me.btnModificar.Location = New System.Drawing.Point(129, -2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(72, 72)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Controls.Add(Me.btnNuevo)
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Location = New System.Drawing.Point(528, 412)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(532, 68)
        Me.Panel2.TabIndex = 175
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.Direccion.DefaultCellStyle = DataGridViewCellStyle3
        Me.Direccion.HeaderText = "DIRECCION"
        Me.Direccion.Name = "Direccion"
        '
        'ZonaNombre
        '
        Me.ZonaNombre.DataPropertyName = "ZonaNombre"
        Me.ZonaNombre.HeaderText = "ZONA"
        Me.ZonaNombre.Name = "ZonaNombre"
        '
        'Correo
        '
        Me.Correo.DataPropertyName = "Correo"
        Me.Correo.HeaderText = "CORREO"
        Me.Correo.Name = "Correo"
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.HeaderText = "TELEFONO"
        Me.Telefono.Name = "Telefono"
        '
        'frmSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 492)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroTabControl2)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.MetroTile2)
        Me.Name = "frmSucursal"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.gbDatos.ResumeLayout(False)
        Me.gbDatos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MetroTabControl2.ResumeLayout(False)
        Me.gbListado.ResumeLayout(False)
        Me.gbListado.PerformLayout()
        CType(Me.dgvSucursal, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDireccion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCorreo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTelefono As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTabControl2 As MetroFramework.Controls.MetroTabControl
    Private WithEvents gbListado As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtSucursal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgvSucursal As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboDistrito As System.Windows.Forms.ComboBox
    Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents cboDepartamento As System.Windows.Forms.ComboBox
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZonaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
