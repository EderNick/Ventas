<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmpleado))
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.gbLicencia = New System.Windows.Forms.GroupBox()
        Me.MetroRadioButton1 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.txtNLicencia = New MetroFramework.Controls.MetroTextBox()
        Me.gbEmpleado = New System.Windows.Forms.GroupBox()
        Me.cmbTipo = New MetroFramework.Controls.MetroComboBox()
        Me.cboVigencia = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtCorreo = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.Vigencia = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.txtDireccion = New MetroFramework.Controls.MetroTextBox()
        Me.txtDNI = New MetroFramework.Controls.MetroTextBox()
        Me.txtCelular = New MetroFramework.Controls.MetroTextBox()
        Me.txtTelefono = New MetroFramework.Controls.MetroTextBox()
        Me.txtAMaterno = New MetroFramework.Controls.MetroTextBox()
        Me.txtAPaterno = New MetroFramework.Controls.MetroTextBox()
        Me.txtNombres = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl3 = New MetroFramework.Controls.MetroTabControl()
        Me.gbListar = New MetroFramework.Controls.MetroTabPage()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.NombreEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rbDNI = New MetroFramework.Controls.MetroRadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtEmpleado = New MetroFramework.Controls.MetroTextBox()
        Me.rbNombre = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.gbLicencia.SuspendLayout()
        Me.gbEmpleado.SuspendLayout()
        Me.MetroTabControl3.SuspendLayout()
        Me.gbListar.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Button6.Location = New System.Drawing.Point(0, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(152, 57)
        Me.Button6.TabIndex = 159
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
        Me.MetroTile2.Location = New System.Drawing.Point(0, 2)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(1159, 64)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTile2.TabIndex = 158
        Me.MetroTile2.Text = "MANTENIMIENTO DE EMPLEADO"
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
        Me.MetroTabControl1.Location = New System.Drawing.Point(9, 72)
        Me.MetroTabControl1.Multiline = True
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(616, 407)
        Me.MetroTabControl1.TabIndex = 169
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MetroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroTabPage1.Controls.Add(Me.gbLicencia)
        Me.MetroTabPage1.Controls.Add(Me.gbEmpleado)
        Me.MetroTabPage1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 41)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MetroTabPage1.Size = New System.Drawing.Size(608, 362)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "DATOS"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'gbLicencia
        '
        Me.gbLicencia.BackColor = System.Drawing.Color.White
        Me.gbLicencia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbLicencia.Controls.Add(Me.MetroRadioButton1)
        Me.gbLicencia.Controls.Add(Me.MetroLabel20)
        Me.gbLicencia.Controls.Add(Me.txtNLicencia)
        Me.gbLicencia.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbLicencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLicencia.ForeColor = System.Drawing.Color.Black
        Me.gbLicencia.Location = New System.Drawing.Point(151, 303)
        Me.gbLicencia.Name = "gbLicencia"
        Me.gbLicencia.Size = New System.Drawing.Size(454, 56)
        Me.gbLicencia.TabIndex = 171
        Me.gbLicencia.TabStop = False
        '
        'MetroRadioButton1
        '
        Me.MetroRadioButton1.AutoSize = True
        Me.MetroRadioButton1.Location = New System.Drawing.Point(17, 26)
        Me.MetroRadioButton1.Name = "MetroRadioButton1"
        Me.MetroRadioButton1.Size = New System.Drawing.Size(74, 15)
        Me.MetroRadioButton1.TabIndex = 0
        Me.MetroRadioButton1.Text = "LICENCIA"
        Me.MetroRadioButton1.UseSelectable = True
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.Location = New System.Drawing.Point(250, 26)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(70, 19)
        Me.MetroLabel20.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel20.TabIndex = 16
        Me.MetroLabel20.Text = "NUMERO "
        Me.MetroLabel20.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel20.UseCustomBackColor = True
        Me.MetroLabel20.UseCustomForeColor = True
        Me.MetroLabel20.UseStyleColors = True
        '
        'txtNLicencia
        '
        Me.txtNLicencia.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtNLicencia.Enabled = False
        Me.txtNLicencia.Lines = New String(-1) {}
        Me.txtNLicencia.Location = New System.Drawing.Point(332, 19)
        Me.txtNLicencia.MaxLength = 32767
        Me.txtNLicencia.Name = "txtNLicencia"
        Me.txtNLicencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNLicencia.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNLicencia.SelectedText = ""
        Me.txtNLicencia.Size = New System.Drawing.Size(116, 23)
        Me.txtNLicencia.TabIndex = 1
        Me.txtNLicencia.UseSelectable = True
        '
        'gbEmpleado
        '
        Me.gbEmpleado.BackColor = System.Drawing.Color.White
        Me.gbEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbEmpleado.Controls.Add(Me.cmbTipo)
        Me.gbEmpleado.Controls.Add(Me.cboVigencia)
        Me.gbEmpleado.Controls.Add(Me.MetroLabel10)
        Me.gbEmpleado.Controls.Add(Me.MetroLabel2)
        Me.gbEmpleado.Controls.Add(Me.txtCorreo)
        Me.gbEmpleado.Controls.Add(Me.MetroLabel5)
        Me.gbEmpleado.Controls.Add(Me.Vigencia)
        Me.gbEmpleado.Controls.Add(Me.MetroLabel6)
        Me.gbEmpleado.Controls.Add(Me.MetroLabel13)
        Me.gbEmpleado.Controls.Add(Me.MetroLabel14)
        Me.gbEmpleado.Controls.Add(Me.MetroLabel15)
        Me.gbEmpleado.Controls.Add(Me.MetroLabel16)
        Me.gbEmpleado.Controls.Add(Me.txtDireccion)
        Me.gbEmpleado.Controls.Add(Me.txtDNI)
        Me.gbEmpleado.Controls.Add(Me.txtCelular)
        Me.gbEmpleado.Controls.Add(Me.txtTelefono)
        Me.gbEmpleado.Controls.Add(Me.txtAMaterno)
        Me.gbEmpleado.Controls.Add(Me.txtAPaterno)
        Me.gbEmpleado.Controls.Add(Me.txtNombres)
        Me.gbEmpleado.Controls.Add(Me.MetroLabel18)
        Me.gbEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEmpleado.ForeColor = System.Drawing.Color.Black
        Me.gbEmpleado.Location = New System.Drawing.Point(-1, 8)
        Me.gbEmpleado.Name = "gbEmpleado"
        Me.gbEmpleado.Size = New System.Drawing.Size(605, 289)
        Me.gbEmpleado.TabIndex = 53
        Me.gbEmpleado.TabStop = False
        Me.gbEmpleado.Text = "DATOS"
        '
        'cmbTipo
        '
        Me.cmbTipo.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.ItemHeight = 19
        Me.cmbTipo.Items.AddRange(New Object() {"SuperAdmin", "Administrador", "Cajero"})
        Me.cmbTipo.Location = New System.Drawing.Point(418, 73)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(164, 25)
        Me.cmbTipo.TabIndex = 6
        Me.cmbTipo.UseSelectable = True
        '
        'cboVigencia
        '
        Me.cboVigencia.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cboVigencia.FormattingEnabled = True
        Me.cboVigencia.ItemHeight = 19
        Me.cboVigencia.Items.AddRange(New Object() {"TRUE", "FALSE"})
        Me.cboVigencia.Location = New System.Drawing.Point(405, 217)
        Me.cboVigencia.Name = "cboVigencia"
        Me.cboVigencia.Size = New System.Drawing.Size(178, 25)
        Me.cboVigencia.TabIndex = 9
        Me.cboVigencia.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(324, 169)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel10.TabIndex = 31
        Me.MetroLabel10.Text = "CELULAR"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(292, 77)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(111, 19)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel2.TabIndex = 32
        Me.MetroLabel2.Text = "TIPO EMPLEADO"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        Me.MetroLabel2.UseStyleColors = True
        '
        'txtCorreo
        '
        Me.txtCorreo.Lines = New String(-1) {}
        Me.txtCorreo.Location = New System.Drawing.Point(401, 30)
        Me.txtCorreo.MaxLength = 32767
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCorreo.SelectedText = ""
        Me.txtCorreo.Size = New System.Drawing.Size(181, 23)
        Me.txtCorreo.TabIndex = 5
        Me.txtCorreo.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(326, 30)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(63, 19)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel5.TabIndex = 32
        Me.MetroLabel5.Text = "CORREO"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel5.UseCustomBackColor = True
        Me.MetroLabel5.UseCustomForeColor = True
        Me.MetroLabel5.UseStyleColors = True
        '
        'Vigencia
        '
        Me.Vigencia.AutoSize = True
        Me.Vigencia.Location = New System.Drawing.Point(324, 220)
        Me.Vigencia.Name = "Vigencia"
        Me.Vigencia.Size = New System.Drawing.Size(67, 19)
        Me.Vigencia.Style = MetroFramework.MetroColorStyle.Green
        Me.Vigencia.TabIndex = 19
        Me.Vigencia.Text = "VIGENCIA"
        Me.Vigencia.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.Vigencia.UseCustomBackColor = True
        Me.Vigencia.UseCustomForeColor = True
        Me.Vigencia.UseStyleColors = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(28, 213)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel6.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel6.TabIndex = 19
        Me.MetroLabel6.Text = "TELEFONO"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel6.UseCustomBackColor = True
        Me.MetroLabel6.UseCustomForeColor = True
        Me.MetroLabel6.UseStyleColors = True
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(38, 30)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(72, 19)
        Me.MetroLabel13.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel13.TabIndex = 16
        Me.MetroLabel13.Text = "NOMBRES"
        Me.MetroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel13.UseCustomBackColor = True
        Me.MetroLabel13.UseCustomForeColor = True
        Me.MetroLabel13.UseStyleColors = True
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(81, 169)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(31, 19)
        Me.MetroLabel14.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel14.TabIndex = 15
        Me.MetroLabel14.Text = "DNI"
        Me.MetroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel14.UseCustomBackColor = True
        Me.MetroLabel14.UseCustomForeColor = True
        Me.MetroLabel14.UseStyleColors = True
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(12, 122)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(92, 19)
        Me.MetroLabel15.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel15.TabIndex = 14
        Me.MetroLabel15.Text = "AP. MATERNO"
        Me.MetroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel15.UseCustomBackColor = True
        Me.MetroLabel15.UseCustomForeColor = True
        Me.MetroLabel15.UseStyleColors = True
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(11, 77)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel16.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel16.TabIndex = 13
        Me.MetroLabel16.Text = "AP. PATERNO"
        Me.MetroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel16.UseCustomBackColor = True
        Me.MetroLabel16.UseCustomForeColor = True
        Me.MetroLabel16.UseStyleColors = True
        '
        'txtDireccion
        '
        Me.txtDireccion.Lines = New String(-1) {}
        Me.txtDireccion.Location = New System.Drawing.Point(402, 122)
        Me.txtDireccion.MaxLength = 35
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDireccion.SelectedText = ""
        Me.txtDireccion.Size = New System.Drawing.Size(181, 23)
        Me.txtDireccion.TabIndex = 7
        Me.txtDireccion.UseSelectable = True
        '
        'txtDNI
        '
        Me.txtDNI.Lines = New String(-1) {}
        Me.txtDNI.Location = New System.Drawing.Point(121, 169)
        Me.txtDNI.MaxLength = 8
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDNI.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDNI.SelectedText = ""
        Me.txtDNI.Size = New System.Drawing.Size(165, 23)
        Me.txtDNI.TabIndex = 3
        Me.txtDNI.UseSelectable = True
        '
        'txtCelular
        '
        Me.txtCelular.Lines = New String(-1) {}
        Me.txtCelular.Location = New System.Drawing.Point(401, 169)
        Me.txtCelular.MaxLength = 9
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCelular.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCelular.SelectedText = ""
        Me.txtCelular.Size = New System.Drawing.Size(181, 23)
        Me.txtCelular.TabIndex = 8
        Me.txtCelular.UseSelectable = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Lines = New String(-1) {}
        Me.txtTelefono.Location = New System.Drawing.Point(121, 213)
        Me.txtTelefono.MaxLength = 6
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTelefono.SelectedText = ""
        Me.txtTelefono.Size = New System.Drawing.Size(165, 23)
        Me.txtTelefono.TabIndex = 4
        Me.txtTelefono.UseSelectable = True
        '
        'txtAMaterno
        '
        Me.txtAMaterno.Lines = New String(-1) {}
        Me.txtAMaterno.Location = New System.Drawing.Point(121, 122)
        Me.txtAMaterno.MaxLength = 35
        Me.txtAMaterno.Name = "txtAMaterno"
        Me.txtAMaterno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAMaterno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAMaterno.SelectedText = ""
        Me.txtAMaterno.Size = New System.Drawing.Size(165, 23)
        Me.txtAMaterno.TabIndex = 2
        Me.txtAMaterno.UseSelectable = True
        '
        'txtAPaterno
        '
        Me.txtAPaterno.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtAPaterno.Lines = New String(-1) {}
        Me.txtAPaterno.Location = New System.Drawing.Point(121, 73)
        Me.txtAPaterno.MaxLength = 35
        Me.txtAPaterno.Name = "txtAPaterno"
        Me.txtAPaterno.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAPaterno.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAPaterno.SelectedText = ""
        Me.txtAPaterno.Size = New System.Drawing.Size(165, 23)
        Me.txtAPaterno.TabIndex = 1
        Me.txtAPaterno.UseSelectable = True
        '
        'txtNombres
        '
        Me.txtNombres.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtNombres.Lines = New String(-1) {}
        Me.txtNombres.Location = New System.Drawing.Point(121, 26)
        Me.txtNombres.MaxLength = 35
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombres.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNombres.SelectedText = ""
        Me.txtNombres.Size = New System.Drawing.Size(165, 23)
        Me.txtNombres.TabIndex = 0
        Me.txtNombres.UseSelectable = True
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.Location = New System.Drawing.Point(312, 122)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(77, 19)
        Me.MetroLabel18.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel18.TabIndex = 0
        Me.MetroLabel18.Text = "DIRECCION"
        Me.MetroLabel18.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel18.UseCustomBackColor = True
        Me.MetroLabel18.UseCustomForeColor = True
        Me.MetroLabel18.UseStyleColors = True
        '
        'MetroTabControl3
        '
        Me.MetroTabControl3.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MetroTabControl3.Controls.Add(Me.gbListar)
        Me.MetroTabControl3.Location = New System.Drawing.Point(627, 72)
        Me.MetroTabControl3.Multiline = True
        Me.MetroTabControl3.Name = "MetroTabControl3"
        Me.MetroTabControl3.SelectedIndex = 0
        Me.MetroTabControl3.Size = New System.Drawing.Size(532, 407)
        Me.MetroTabControl3.TabIndex = 170
        Me.MetroTabControl3.UseSelectable = True
        '
        'gbListar
        '
        Me.gbListar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.gbListar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbListar.Controls.Add(Me.dgvEmpleados)
        Me.gbListar.Controls.Add(Me.rbDNI)
        Me.gbListar.Controls.Add(Me.btnBuscar)
        Me.gbListar.Controls.Add(Me.txtEmpleado)
        Me.gbListar.Controls.Add(Me.rbNombre)
        Me.gbListar.Controls.Add(Me.MetroLabel7)
        Me.gbListar.ForeColor = System.Drawing.Color.DodgerBlue
        Me.gbListar.HorizontalScrollbarBarColor = True
        Me.gbListar.HorizontalScrollbarHighlightOnWheel = True
        Me.gbListar.HorizontalScrollbarSize = 10
        Me.gbListar.Location = New System.Drawing.Point(4, 41)
        Me.gbListar.Name = "gbListar"
        Me.gbListar.Size = New System.Drawing.Size(524, 362)
        Me.gbListar.TabIndex = 0
        Me.gbListar.Text = "LISTAR EMPLEADO"
        Me.gbListar.Theme = MetroFramework.MetroThemeStyle.Light
        Me.gbListar.VerticalScrollbarBarColor = True
        Me.gbListar.VerticalScrollbarHighlightOnWheel = False
        Me.gbListar.VerticalScrollbarSize = 10
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreEmpleado, Me.Cargo, Me.Dni, Me.Direccion, Me.Telefono, Me.Celular, Me.Correo})
        Me.dgvEmpleados.Location = New System.Drawing.Point(3, 87)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.Size = New System.Drawing.Size(518, 270)
        Me.dgvEmpleados.TabIndex = 177
        '
        'NombreEmpleado
        '
        Me.NombreEmpleado.DataPropertyName = "NombreEmpleado"
        Me.NombreEmpleado.HeaderText = "EMPLEADO"
        Me.NombreEmpleado.Name = "NombreEmpleado"
        Me.NombreEmpleado.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.NombreEmpleado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Cargo
        '
        Me.Cargo.DataPropertyName = "Cargo"
        Me.Cargo.HeaderText = "CARGO"
        Me.Cargo.Name = "Cargo"
        Me.Cargo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Cargo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Dni
        '
        Me.Dni.DataPropertyName = "Dni"
        Me.Dni.HeaderText = "DNI"
        Me.Dni.Name = "Dni"
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "DIRECCION"
        Me.Direccion.Name = "Direccion"
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.HeaderText = "TELEFONO"
        Me.Telefono.Name = "Telefono"
        '
        'Celular
        '
        Me.Celular.DataPropertyName = "Celular"
        Me.Celular.HeaderText = "CELULAR"
        Me.Celular.Name = "Celular"
        '
        'Correo
        '
        Me.Correo.DataPropertyName = "Correo"
        Me.Correo.HeaderText = "CORREO"
        Me.Correo.Name = "Correo"
        '
        'rbDNI
        '
        Me.rbDNI.AutoSize = True
        Me.rbDNI.Location = New System.Drawing.Point(256, 18)
        Me.rbDNI.Name = "rbDNI"
        Me.rbDNI.Size = New System.Drawing.Size(43, 15)
        Me.rbDNI.TabIndex = 158
        Me.rbDNI.Text = "DNI"
        Me.rbDNI.UseSelectable = True
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
        Me.btnBuscar.Location = New System.Drawing.Point(396, 38)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(37, 32)
        Me.btnBuscar.TabIndex = 156
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtEmpleado
        '
        Me.txtEmpleado.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtEmpleado.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtEmpleado.Lines = New String(-1) {}
        Me.txtEmpleado.Location = New System.Drawing.Point(121, 43)
        Me.txtEmpleado.MaxLength = 32767
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmpleado.SelectedText = ""
        Me.txtEmpleado.Size = New System.Drawing.Size(256, 23)
        Me.txtEmpleado.TabIndex = 155
        Me.txtEmpleado.UseSelectable = True
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.Location = New System.Drawing.Point(143, 18)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(72, 15)
        Me.rbNombre.TabIndex = 153
        Me.rbNombre.Text = "NOMBRE"
        Me.rbNombre.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel7.Location = New System.Drawing.Point(3, 14)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(116, 19)
        Me.MetroLabel7.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel7.TabIndex = 152
        Me.MetroLabel7.Text = "BUSQUEDA POR :"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel7.UseCustomBackColor = True
        Me.MetroLabel7.UseCustomForeColor = True
        Me.MetroLabel7.UseStyleColors = True
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
        Me.btnModificar.Location = New System.Drawing.Point(81, 3)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(72, 72)
        Me.btnModificar.TabIndex = 173
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = False
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
        Me.btnNuevo.Location = New System.Drawing.Point(3, 3)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 72)
        Me.btnNuevo.TabIndex = 172
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Location = New System.Drawing.Point(16, 486)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(605, 58)
        Me.Panel1.TabIndex = 176
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
        Me.btnGuardar.Location = New System.Drawing.Point(159, 3)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 72)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Location = New System.Drawing.Point(631, 486)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(518, 58)
        Me.Panel2.TabIndex = 177
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
        Me.btnSalir.Location = New System.Drawing.Point(444, 2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(72, 72)
        Me.btnSalir.TabIndex = 174
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'frmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 556)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroTabControl3)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.MetroTile2)
        Me.Name = "frmEmpleado"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.gbLicencia.ResumeLayout(False)
        Me.gbLicencia.PerformLayout()
        Me.gbEmpleado.ResumeLayout(False)
        Me.gbEmpleado.PerformLayout()
        Me.MetroTabControl3.ResumeLayout(False)
        Me.gbListar.ResumeLayout(False)
        Me.gbListar.PerformLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents gbEmpleado As System.Windows.Forms.GroupBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCorreo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDireccion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDNI As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCelular As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTelefono As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAMaterno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAPaterno As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNombres As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents gbLicencia As System.Windows.Forms.GroupBox
    Friend WithEvents MetroRadioButton1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNLicencia As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTabControl3 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtEmpleado As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents dgvEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents NombreEmpleado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Celular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Vigencia As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboVigencia As MetroFramework.Controls.MetroComboBox
    Private WithEvents gbListar As MetroFramework.Controls.MetroTabPage
    Private WithEvents rbDNI As MetroFramework.Controls.MetroRadioButton
    Private WithEvents rbNombre As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents cmbTipo As MetroFramework.Controls.MetroComboBox
End Class
