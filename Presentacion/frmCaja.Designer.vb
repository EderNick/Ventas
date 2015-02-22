<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaja

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCaja))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancelarInicio = New System.Windows.Forms.Button()
        Me.btnGuardarInicio = New System.Windows.Forms.Button()
        Me.gbCaja = New System.Windows.Forms.GroupBox()
        Me.btnAhoraI = New System.Windows.Forms.Button()
        Me.dtpApertura = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtMontoApertura = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtDescripcion = New MetroFramework.Controls.MetroTextBox()
        Me.txtNumero = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCancelarCierre = New System.Windows.Forms.Button()
        Me.btnGuardarCierre = New System.Windows.Forms.Button()
        Me.gbCierreCaja = New System.Windows.Forms.GroupBox()
        Me.btnAhoraC = New System.Windows.Forms.Button()
        Me.dtpCierre = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtCajaSinCerrar = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtObservacion = New MetroFramework.Controls.MetroTextBox()
        Me.txtMontoCierre = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl2 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
        Me.dgvCaja = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtCaja = New MetroFramework.Controls.MetroTextBox()
        Me.MetroRadioButton4 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox4 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.dgbCaja = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gbCaja.SuspendLayout()
        Me.MetroTabPage3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.gbCierreCaja.SuspendLayout()
        Me.MetroTabControl2.SuspendLayout()
        Me.MetroTabPage2.SuspendLayout()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgbCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
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
        Me.Button6.Location = New System.Drawing.Point(0, 8)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(258, 57)
        Me.Button6.TabIndex = 159
        Me.Button6.UseCompatibleTextRendering = True
        Me.Button6.UseVisualStyleBackColor = False
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.AutoSize = True
        Me.MetroTile2.BackColor = System.Drawing.Color.DodgerBlue
        Me.MetroTile2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTile2.Location = New System.Drawing.Point(0, 1)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(1191, 64)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTile2.TabIndex = 158
        Me.MetroTile2.Text = "REGISTRO DE CAJA"
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
        Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 71)
        Me.MetroTabControl1.Multiline = True
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(519, 404)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MetroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroTabPage1.Controls.Add(Me.Panel2)
        Me.MetroTabPage1.Controls.Add(Me.gbCaja)
        Me.MetroTabPage1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 41)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MetroTabPage1.Size = New System.Drawing.Size(511, 359)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "Iniciar Caja"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.btnCancelarInicio)
        Me.Panel2.Controls.Add(Me.btnGuardarInicio)
        Me.Panel2.Location = New System.Drawing.Point(3, 291)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(503, 68)
        Me.Panel2.TabIndex = 175
        '
        'btnCancelarInicio
        '
        Me.btnCancelarInicio.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelarInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelarInicio.FlatAppearance.BorderSize = 0
        Me.btnCancelarInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCancelarInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCancelarInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarInicio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarInicio.ForeColor = System.Drawing.Color.White
        Me.btnCancelarInicio.Image = CType(resources.GetObject("btnCancelarInicio.Image"), System.Drawing.Image)
        Me.btnCancelarInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelarInicio.Location = New System.Drawing.Point(428, -2)
        Me.btnCancelarInicio.Name = "btnCancelarInicio"
        Me.btnCancelarInicio.Size = New System.Drawing.Size(72, 72)
        Me.btnCancelarInicio.TabIndex = 5
        Me.btnCancelarInicio.Text = "Cancelar"
        Me.btnCancelarInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelarInicio.UseVisualStyleBackColor = False
        '
        'btnGuardarInicio
        '
        Me.btnGuardarInicio.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardarInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardarInicio.FlatAppearance.BorderSize = 0
        Me.btnGuardarInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnGuardarInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnGuardarInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarInicio.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarInicio.ForeColor = System.Drawing.Color.White
        Me.btnGuardarInicio.Image = CType(resources.GetObject("btnGuardarInicio.Image"), System.Drawing.Image)
        Me.btnGuardarInicio.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardarInicio.Location = New System.Drawing.Point(280, -2)
        Me.btnGuardarInicio.Name = "btnGuardarInicio"
        Me.btnGuardarInicio.Size = New System.Drawing.Size(142, 72)
        Me.btnGuardarInicio.TabIndex = 2
        Me.btnGuardarInicio.Text = "Guardar Inicio de Caja"
        Me.btnGuardarInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardarInicio.UseVisualStyleBackColor = False
        '
        'gbCaja
        '
        Me.gbCaja.BackColor = System.Drawing.Color.White
        Me.gbCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbCaja.Controls.Add(Me.btnAhoraI)
        Me.gbCaja.Controls.Add(Me.dtpApertura)
        Me.gbCaja.Controls.Add(Me.MetroLabel3)
        Me.gbCaja.Controls.Add(Me.txtMontoApertura)
        Me.gbCaja.Controls.Add(Me.MetroLabel7)
        Me.gbCaja.Controls.Add(Me.MetroLabel2)
        Me.gbCaja.Controls.Add(Me.MetroLabel6)
        Me.gbCaja.Controls.Add(Me.txtDescripcion)
        Me.gbCaja.Controls.Add(Me.txtNumero)
        Me.gbCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCaja.ForeColor = System.Drawing.Color.Black
        Me.gbCaja.Location = New System.Drawing.Point(3, 3)
        Me.gbCaja.Name = "gbCaja"
        Me.gbCaja.Size = New System.Drawing.Size(503, 280)
        Me.gbCaja.TabIndex = 85
        Me.gbCaja.TabStop = False
        '
        'btnAhoraI
        '
        Me.btnAhoraI.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAhoraI.Location = New System.Drawing.Point(397, 136)
        Me.btnAhoraI.Name = "btnAhoraI"
        Me.btnAhoraI.Size = New System.Drawing.Size(84, 29)
        Me.btnAhoraI.TabIndex = 186
        Me.btnAhoraI.Text = "Ahora"
        Me.btnAhoraI.UseVisualStyleBackColor = True
        '
        'dtpApertura
        '
        Me.dtpApertura.Checked = False
        Me.dtpApertura.Location = New System.Drawing.Point(161, 136)
        Me.dtpApertura.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtpApertura.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtpApertura.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpApertura.Name = "dtpApertura"
        Me.dtpApertura.Size = New System.Drawing.Size(230, 29)
        Me.dtpApertura.TabIndex = 185
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(27, 136)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(119, 19)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel3.TabIndex = 182
        Me.MetroLabel3.Text = "FECHA APERTURA"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        Me.MetroLabel3.UseStyleColors = True
        '
        'txtMontoApertura
        '
        Me.txtMontoApertura.Lines = New String(-1) {}
        Me.txtMontoApertura.Location = New System.Drawing.Point(161, 93)
        Me.txtMontoApertura.MaxLength = 32767
        Me.txtMontoApertura.Name = "txtMontoApertura"
        Me.txtMontoApertura.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontoApertura.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontoApertura.SelectedText = ""
        Me.txtMontoApertura.Size = New System.Drawing.Size(137, 23)
        Me.txtMontoApertura.TabIndex = 178
        Me.txtMontoApertura.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(27, 93)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(128, 19)
        Me.MetroLabel7.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel7.TabIndex = 174
        Me.MetroLabel7.Text = "MONTO APERTURA"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel7.UseCustomBackColor = True
        Me.MetroLabel7.UseCustomForeColor = True
        Me.MetroLabel7.UseStyleColors = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(27, 184)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(93, 19)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel2.TabIndex = 34
        Me.MetroLabel2.Text = "DESCRIPCIÓN"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        Me.MetroLabel2.UseStyleColors = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(27, 48)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(123, 19)
        Me.MetroLabel6.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel6.TabIndex = 19
        Me.MetroLabel6.Text = "NÚMERO DE CAJA"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel6.UseCustomBackColor = True
        Me.MetroLabel6.UseCustomForeColor = True
        Me.MetroLabel6.UseStyleColors = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Lines = New String(-1) {}
        Me.txtDescripcion.Location = New System.Drawing.Point(161, 184)
        Me.txtDescripcion.MaxLength = 25
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescripcion.SelectedText = ""
        Me.txtDescripcion.Size = New System.Drawing.Size(320, 23)
        Me.txtDescripcion.TabIndex = 3
        Me.txtDescripcion.UseSelectable = True
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtNumero.Lines = New String(-1) {}
        Me.txtNumero.Location = New System.Drawing.Point(161, 48)
        Me.txtNumero.MaxLength = 32767
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumero.SelectedText = ""
        Me.txtNumero.Size = New System.Drawing.Size(137, 23)
        Me.txtNumero.TabIndex = 2
        Me.txtNumero.UseSelectable = True
        '
        'MetroTabPage3
        '
        Me.MetroTabPage3.Controls.Add(Me.Panel3)
        Me.MetroTabPage3.Controls.Add(Me.gbCierreCaja)
        Me.MetroTabPage3.HorizontalScrollbarBarColor = True
        Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.HorizontalScrollbarSize = 10
        Me.MetroTabPage3.Location = New System.Drawing.Point(4, 41)
        Me.MetroTabPage3.Name = "MetroTabPage3"
        Me.MetroTabPage3.Size = New System.Drawing.Size(511, 359)
        Me.MetroTabPage3.TabIndex = 1
        Me.MetroTabPage3.Text = "Cerrar Caja"
        Me.MetroTabPage3.VerticalScrollbarBarColor = True
        Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage3.VerticalScrollbarSize = 10
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.btnCancelarCierre)
        Me.Panel3.Controls.Add(Me.btnGuardarCierre)
        Me.Panel3.Location = New System.Drawing.Point(3, 291)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(503, 68)
        Me.Panel3.TabIndex = 176
        '
        'btnCancelarCierre
        '
        Me.btnCancelarCierre.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelarCierre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCancelarCierre.FlatAppearance.BorderSize = 0
        Me.btnCancelarCierre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnCancelarCierre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnCancelarCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelarCierre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarCierre.ForeColor = System.Drawing.Color.White
        Me.btnCancelarCierre.Image = CType(resources.GetObject("btnCancelarCierre.Image"), System.Drawing.Image)
        Me.btnCancelarCierre.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnCancelarCierre.Location = New System.Drawing.Point(428, -2)
        Me.btnCancelarCierre.Name = "btnCancelarCierre"
        Me.btnCancelarCierre.Size = New System.Drawing.Size(72, 72)
        Me.btnCancelarCierre.TabIndex = 5
        Me.btnCancelarCierre.Text = "Cancelar"
        Me.btnCancelarCierre.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelarCierre.UseVisualStyleBackColor = False
        '
        'btnGuardarCierre
        '
        Me.btnGuardarCierre.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardarCierre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardarCierre.FlatAppearance.BorderSize = 0
        Me.btnGuardarCierre.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnGuardarCierre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnGuardarCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardarCierre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarCierre.ForeColor = System.Drawing.Color.White
        Me.btnGuardarCierre.Image = CType(resources.GetObject("btnGuardarCierre.Image"), System.Drawing.Image)
        Me.btnGuardarCierre.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardarCierre.Location = New System.Drawing.Point(279, -2)
        Me.btnGuardarCierre.Name = "btnGuardarCierre"
        Me.btnGuardarCierre.Size = New System.Drawing.Size(143, 72)
        Me.btnGuardarCierre.TabIndex = 2
        Me.btnGuardarCierre.Text = "Guardar Cierre de Caja"
        Me.btnGuardarCierre.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardarCierre.UseVisualStyleBackColor = False
        '
        'gbCierreCaja
        '
        Me.gbCierreCaja.BackColor = System.Drawing.Color.White
        Me.gbCierreCaja.Controls.Add(Me.btnAhoraC)
        Me.gbCierreCaja.Controls.Add(Me.dtpCierre)
        Me.gbCierreCaja.Controls.Add(Me.MetroLabel5)
        Me.gbCierreCaja.Controls.Add(Me.txtCajaSinCerrar)
        Me.gbCierreCaja.Controls.Add(Me.MetroLabel4)
        Me.gbCierreCaja.Controls.Add(Me.MetroLabel1)
        Me.gbCierreCaja.Controls.Add(Me.txtObservacion)
        Me.gbCierreCaja.Controls.Add(Me.txtMontoCierre)
        Me.gbCierreCaja.Controls.Add(Me.MetroLabel8)
        Me.gbCierreCaja.Location = New System.Drawing.Point(3, 3)
        Me.gbCierreCaja.Name = "gbCierreCaja"
        Me.gbCierreCaja.Size = New System.Drawing.Size(503, 280)
        Me.gbCierreCaja.TabIndex = 2
        Me.gbCierreCaja.TabStop = False
        '
        'btnAhoraC
        '
        Me.btnAhoraC.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAhoraC.Location = New System.Drawing.Point(397, 136)
        Me.btnAhoraC.Name = "btnAhoraC"
        Me.btnAhoraC.Size = New System.Drawing.Size(84, 29)
        Me.btnAhoraC.TabIndex = 191
        Me.btnAhoraC.Text = "Ahora"
        Me.btnAhoraC.UseVisualStyleBackColor = True
        '
        'dtpCierre
        '
        Me.dtpCierre.Location = New System.Drawing.Point(161, 136)
        Me.dtpCierre.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.dtpCierre.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtpCierre.MinimumSize = New System.Drawing.Size(4, 29)
        Me.dtpCierre.Name = "dtpCierre"
        Me.dtpCierre.Size = New System.Drawing.Size(230, 29)
        Me.dtpCierre.TabIndex = 190
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(27, 48)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(123, 19)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel5.TabIndex = 189
        Me.MetroLabel5.Text = "NÚMERO DE CAJA"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel5.UseCustomBackColor = True
        Me.MetroLabel5.UseCustomForeColor = True
        Me.MetroLabel5.UseStyleColors = True
        '
        'txtCajaSinCerrar
        '
        Me.txtCajaSinCerrar.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtCajaSinCerrar.Enabled = False
        Me.txtCajaSinCerrar.Lines = New String(-1) {}
        Me.txtCajaSinCerrar.Location = New System.Drawing.Point(161, 48)
        Me.txtCajaSinCerrar.MaxLength = 32767
        Me.txtCajaSinCerrar.Name = "txtCajaSinCerrar"
        Me.txtCajaSinCerrar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCajaSinCerrar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCajaSinCerrar.SelectedText = ""
        Me.txtCajaSinCerrar.Size = New System.Drawing.Size(137, 23)
        Me.txtCajaSinCerrar.TabIndex = 188
        Me.txtCajaSinCerrar.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(27, 136)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(96, 19)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel4.TabIndex = 187
        Me.MetroLabel4.Text = "FECHA CIERRE"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        Me.MetroLabel4.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(27, 184)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(113, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel1.TabIndex = 186
        Me.MetroLabel1.Text = "OBSERVACIONES"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        Me.MetroLabel1.UseStyleColors = True
        '
        'txtObservacion
        '
        Me.txtObservacion.Lines = New String(-1) {}
        Me.txtObservacion.Location = New System.Drawing.Point(161, 184)
        Me.txtObservacion.MaxLength = 25
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtObservacion.SelectedText = ""
        Me.txtObservacion.Size = New System.Drawing.Size(320, 23)
        Me.txtObservacion.TabIndex = 185
        Me.txtObservacion.UseSelectable = True
        '
        'txtMontoCierre
        '
        Me.txtMontoCierre.Lines = New String(-1) {}
        Me.txtMontoCierre.Location = New System.Drawing.Point(161, 93)
        Me.txtMontoCierre.MaxLength = 32767
        Me.txtMontoCierre.Name = "txtMontoCierre"
        Me.txtMontoCierre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontoCierre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontoCierre.SelectedText = ""
        Me.txtMontoCierre.Size = New System.Drawing.Size(137, 23)
        Me.txtMontoCierre.TabIndex = 183
        Me.txtMontoCierre.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(27, 93)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel8.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel8.TabIndex = 182
        Me.MetroLabel8.Text = "MONTO CIERRE"
        Me.MetroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel8.UseCustomBackColor = True
        Me.MetroLabel8.UseCustomForeColor = True
        Me.MetroLabel8.UseStyleColors = True
        '
        'MetroTabControl2
        '
        Me.MetroTabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MetroTabControl2.Controls.Add(Me.MetroTabPage2)
        Me.MetroTabControl2.Location = New System.Drawing.Point(544, 71)
        Me.MetroTabControl2.Multiline = True
        Me.MetroTabControl2.Name = "MetroTabControl2"
        Me.MetroTabControl2.SelectedIndex = 0
        Me.MetroTabControl2.Size = New System.Drawing.Size(627, 311)
        Me.MetroTabControl2.TabIndex = 170
        Me.MetroTabControl2.UseSelectable = True
        '
        'MetroTabPage2
        '
        Me.MetroTabPage2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MetroTabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroTabPage2.Controls.Add(Me.dgvCaja)
        Me.MetroTabPage2.Controls.Add(Me.Button3)
        Me.MetroTabPage2.Controls.Add(Me.txtCaja)
        Me.MetroTabPage2.Controls.Add(Me.MetroRadioButton4)
        Me.MetroTabPage2.Controls.Add(Me.MetroLabel10)
        Me.MetroTabPage2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTabPage2.HorizontalScrollbarBarColor = True
        Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = True
        Me.MetroTabPage2.HorizontalScrollbarSize = 10
        Me.MetroTabPage2.Location = New System.Drawing.Point(4, 41)
        Me.MetroTabPage2.Name = "MetroTabPage2"
        Me.MetroTabPage2.Size = New System.Drawing.Size(619, 266)
        Me.MetroTabPage2.TabIndex = 0
        Me.MetroTabPage2.Text = "LISTA CLIENTES"
        Me.MetroTabPage2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTabPage2.VerticalScrollbarBarColor = True
        Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage2.VerticalScrollbarSize = 10
        '
        'dgvCaja
        '
        Me.dgvCaja.AllowUserToAddRows = False
        Me.dgvCaja.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvCaja.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCaja.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvCaja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCaja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9})
        Me.dgvCaja.Location = New System.Drawing.Point(3, 90)
        Me.dgvCaja.Name = "dgvCaja"
        Me.dgvCaja.ReadOnly = True
        Me.dgvCaja.Size = New System.Drawing.Size(616, 173)
        Me.dgvCaja.TabIndex = 162
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Numero"
        Me.Column3.HeaderText = "NUMERO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 50
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Descripcion"
        Me.Column4.HeaderText = "DESCRIPCION"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "FechaApertura"
        Me.Column5.HeaderText = "FECHA APERTURA"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "FechaCierre"
        Me.Column6.HeaderText = "FECHA DE CIERRE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "MontoApertura"
        Me.Column7.HeaderText = "MONTO APERTURA"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "MontoCierre"
        Me.Column8.HeaderText = "MONTO CIERRE"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "Estado"
        Me.Column9.HeaderText = "ESTADO"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(434, 38)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 32)
        Me.Button3.TabIndex = 161
        Me.Button3.UseVisualStyleBackColor = False
        '
        'txtCaja
        '
        Me.txtCaja.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtCaja.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtCaja.Lines = New String(-1) {}
        Me.txtCaja.Location = New System.Drawing.Point(143, 47)
        Me.txtCaja.MaxLength = 32767
        Me.txtCaja.Name = "txtCaja"
        Me.txtCaja.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCaja.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCaja.SelectedText = ""
        Me.txtCaja.Size = New System.Drawing.Size(285, 23)
        Me.txtCaja.TabIndex = 160
        Me.txtCaja.UseSelectable = True
        '
        'MetroRadioButton4
        '
        Me.MetroRadioButton4.AutoSize = True
        Me.MetroRadioButton4.Location = New System.Drawing.Point(143, 17)
        Me.MetroRadioButton4.Name = "MetroRadioButton4"
        Me.MetroRadioButton4.Size = New System.Drawing.Size(73, 15)
        Me.MetroRadioButton4.TabIndex = 158
        Me.MetroRadioButton4.Text = "NUMERO"
        Me.MetroRadioButton4.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel10.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel10.Location = New System.Drawing.Point(3, 13)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(116, 19)
        Me.MetroLabel10.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel10.TabIndex = 157
        Me.MetroLabel10.Text = "BUSQUEDA POR :"
        Me.MetroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel10.UseCustomBackColor = True
        Me.MetroLabel10.UseCustomForeColor = True
        Me.MetroLabel10.UseStyleColors = True
        '
        'MetroTextBox3
        '
        Me.MetroTextBox3.Lines = New String(-1) {}
        Me.MetroTextBox3.Location = New System.Drawing.Point(161, 89)
        Me.MetroTextBox3.MaxLength = 32767
        Me.MetroTextBox3.Name = "MetroTextBox3"
        Me.MetroTextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox3.SelectedText = ""
        Me.MetroTextBox3.Size = New System.Drawing.Size(98, 23)
        Me.MetroTextBox3.TabIndex = 178
        Me.MetroTextBox3.UseSelectable = True
        '
        'MetroTextBox4
        '
        Me.MetroTextBox4.Lines = New String(-1) {}
        Me.MetroTextBox4.Location = New System.Drawing.Point(161, 132)
        Me.MetroTextBox4.MaxLength = 32767
        Me.MetroTextBox4.Name = "MetroTextBox4"
        Me.MetroTextBox4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox4.SelectedText = ""
        Me.MetroTextBox4.Size = New System.Drawing.Size(98, 23)
        Me.MetroTextBox4.TabIndex = 179
        Me.MetroTextBox4.UseSelectable = True
        '
        'MetroTextBox2
        '
        Me.MetroTextBox2.BackColor = System.Drawing.Color.DodgerBlue
        Me.MetroTextBox2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTextBox2.Lines = New String(-1) {}
        Me.MetroTextBox2.Location = New System.Drawing.Point(143, 47)
        Me.MetroTextBox2.MaxLength = 32767
        Me.MetroTextBox2.Name = "MetroTextBox2"
        Me.MetroTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox2.SelectedText = ""
        Me.MetroTextBox2.Size = New System.Drawing.Size(285, 23)
        Me.MetroTextBox2.TabIndex = 160
        Me.MetroTextBox2.UseSelectable = True
        '
        'dgbCaja
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgbCaja.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgbCaja.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgbCaja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgbCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbCaja.Location = New System.Drawing.Point(3, 90)
        Me.dgbCaja.Name = "dgbCaja"
        Me.dgbCaja.Size = New System.Drawing.Size(442, 180)
        Me.dgbCaja.TabIndex = 162
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Controls.Add(Me.btnSalir)
        Me.Panel4.Controls.Add(Me.btnNuevo)
        Me.Panel4.Controls.Add(Me.btnModificar)
        Me.Panel4.Location = New System.Drawing.Point(551, 403)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(616, 68)
        Me.Panel4.TabIndex = 176
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
        Me.btnSalir.Location = New System.Drawing.Point(541, -2)
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
        Me.btnNuevo.Location = New System.Drawing.Point(3, -2)
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
        Me.btnModificar.Location = New System.Drawing.Point(98, -2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(72, 72)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnModificar.UseVisualStyleBackColor = False
        Me.btnModificar.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.Location = New System.Drawing.Point(338, -2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(72, 72)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "Guardar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'frmCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 498)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.MetroTabControl2)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.MetroTile2)
        Me.Name = "frmCaja"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.gbCaja.ResumeLayout(False)
        Me.gbCaja.PerformLayout()
        Me.MetroTabPage3.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.gbCierreCaja.ResumeLayout(False)
        Me.gbCierreCaja.PerformLayout()
        Me.MetroTabControl2.ResumeLayout(False)
        Me.MetroTabPage2.ResumeLayout(False)
        Me.MetroTabPage2.PerformLayout()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgbCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents gbCaja As System.Windows.Forms.GroupBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDescripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMontoApertura As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTabControl2 As MetroFramework.Controls.MetroTabControl
    Private WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents dgvCaja As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtCaja As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroRadioButton4 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dgbCaja As System.Windows.Forms.DataGridView
    Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents gbCierreCaja As System.Windows.Forms.GroupBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtObservacion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMontoCierre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNumero As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCajaSinCerrar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelarInicio As System.Windows.Forms.Button
    Friend WithEvents btnGuardarInicio As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelarCierre As System.Windows.Forms.Button
    Friend WithEvents btnGuardarCierre As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents dtpApertura As MetroFramework.Controls.MetroDateTime
    Friend WithEvents dtpCierre As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btnAhoraI As System.Windows.Forms.Button
    Friend WithEvents btnAhoraC As System.Windows.Forms.Button
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
