<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrdenPedido))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.gbProducto = New System.Windows.Forms.GroupBox()
        Me.txtPrecioUnitario = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtCantidad = New MetroFramework.Controls.MetroTextBox()
        Me.txtProducto = New MetroFramework.Controls.MetroTextBox()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.txtMonto = New MetroFramework.Controls.MetroTextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.txtCliente = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MetroTextBox5 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.txtNumero = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFecha = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnGuardarCierre = New System.Windows.Forms.Button()
        Me.lblIGV = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.lblTotal = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.lblSubTotal = New MetroFramework.Controls.MetroLabel()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gbProducto.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(23, 137)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel8.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel8.TabIndex = 47
        Me.MetroLabel8.Text = "CLIENTE"
        Me.MetroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel8.UseCustomBackColor = True
        Me.MetroLabel8.UseCustomForeColor = True
        Me.MetroLabel8.UseStyleColors = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(17, 33)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel4.TabIndex = 44
        Me.MetroLabel4.Text = " PRODUCTO"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        Me.MetroLabel4.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MetroLabel1.Location = New System.Drawing.Point(619, 621)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel1.TabIndex = 33
        Me.MetroLabel1.Text = "TOTAL"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        Me.MetroLabel1.UseStyleColors = True
        '
        'gbProducto
        '
        Me.gbProducto.BackColor = System.Drawing.Color.White
        Me.gbProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbProducto.Controls.Add(Me.txtPrecioUnitario)
        Me.gbProducto.Controls.Add(Me.MetroLabel5)
        Me.gbProducto.Controls.Add(Me.txtCantidad)
        Me.gbProducto.Controls.Add(Me.txtProducto)
        Me.gbProducto.Controls.Add(Me.btnBuscarProducto)
        Me.gbProducto.Controls.Add(Me.txtMonto)
        Me.gbProducto.Controls.Add(Me.btnAgregar)
        Me.gbProducto.Controls.Add(Me.MetroLabel2)
        Me.gbProducto.Controls.Add(Me.MetroLabel4)
        Me.gbProducto.Controls.Add(Me.MetroLabel9)
        Me.gbProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProducto.ForeColor = System.Drawing.Color.Black
        Me.gbProducto.Location = New System.Drawing.Point(9, 210)
        Me.gbProducto.Name = "gbProducto"
        Me.gbProducto.Size = New System.Drawing.Size(884, 141)
        Me.gbProducto.TabIndex = 117
        Me.gbProducto.TabStop = False
        '
        'txtPrecioUnitario
        '
        Me.txtPrecioUnitario.Enabled = False
        Me.txtPrecioUnitario.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPrecioUnitario.Lines = New String(-1) {}
        Me.txtPrecioUnitario.Location = New System.Drawing.Point(140, 82)
        Me.txtPrecioUnitario.MaxLength = 32767
        Me.txtPrecioUnitario.Name = "txtPrecioUnitario"
        Me.txtPrecioUnitario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecioUnitario.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecioUnitario.SelectedText = ""
        Me.txtPrecioUnitario.Size = New System.Drawing.Size(67, 23)
        Me.txtPrecioUnitario.TabIndex = 198
        Me.txtPrecioUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecioUnitario.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(17, 83)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(117, 19)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel5.TabIndex = 197
        Me.MetroLabel5.Text = "PRECIO UNITARIO"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel5.UseCustomBackColor = True
        Me.MetroLabel5.UseCustomForeColor = True
        Me.MetroLabel5.UseStyleColors = True
        '
        'txtCantidad
        '
        Me.txtCantidad.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtCantidad.Lines = New String(-1) {}
        Me.txtCantidad.Location = New System.Drawing.Point(304, 83)
        Me.txtCantidad.MaxLength = 32767
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCantidad.SelectedText = ""
        Me.txtCantidad.Size = New System.Drawing.Size(73, 23)
        Me.txtCantidad.TabIndex = 196
        Me.txtCantidad.Tag = "0"
        Me.txtCantidad.UseCustomBackColor = True
        Me.txtCantidad.UseSelectable = True
        '
        'txtProducto
        '
        Me.txtProducto.Enabled = False
        Me.txtProducto.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtProducto.Lines = New String(-1) {}
        Me.txtProducto.Location = New System.Drawing.Point(140, 29)
        Me.txtProducto.MaxLength = 32767
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtProducto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtProducto.SelectedText = ""
        Me.txtProducto.Size = New System.Drawing.Size(427, 23)
        Me.txtProducto.TabIndex = 184
        Me.txtProducto.UseSelectable = True
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarProducto.BackgroundImage = CType(resources.GetObject("btnBuscarProducto.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscarProducto.FlatAppearance.BorderSize = 0
        Me.btnBuscarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarProducto.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscarProducto.ForeColor = System.Drawing.Color.White
        Me.btnBuscarProducto.Location = New System.Drawing.Point(573, 23)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(44, 39)
        Me.btnBuscarProducto.TabIndex = 183
        Me.btnBuscarProducto.UseVisualStyleBackColor = False
        '
        'txtMonto
        '
        Me.txtMonto.Enabled = False
        Me.txtMonto.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtMonto.Lines = New String(-1) {}
        Me.txtMonto.Location = New System.Drawing.Point(515, 80)
        Me.txtMonto.MaxLength = 32767
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMonto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMonto.SelectedText = ""
        Me.txtMonto.Size = New System.Drawing.Size(102, 30)
        Me.txtMonto.TabIndex = 177
        Me.txtMonto.Tag = ""
        Me.txtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMonto.UseSelectable = True
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.Transparent
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAgregar.FlatAppearance.BorderSize = 0
        Me.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.Black
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregar.Location = New System.Drawing.Point(687, 39)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(117, 73)
        Me.btnAgregar.TabIndex = 195
        Me.btnAgregar.Text = "Agregar Producto"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(224, 86)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel2.TabIndex = 47
        Me.MetroLabel2.Text = "CANTIDAD"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        Me.MetroLabel2.UseStyleColors = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(402, 87)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(107, 19)
        Me.MetroLabel9.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel9.TabIndex = 43
        Me.MetroLabel9.Text = "MONTO SIN IGV"
        Me.MetroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel9.UseCustomBackColor = True
        Me.MetroLabel9.UseCustomForeColor = True
        Me.MetroLabel9.UseStyleColors = True
        '
        'dgvProductos
        '
        Me.dgvProductos.AllowUserToAddRows = False
        Me.dgvProductos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.Column1, Me.DataGridViewTextBoxColumn5})
        Me.dgvProductos.Location = New System.Drawing.Point(9, 363)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(804, 161)
        Me.dgvProductos.TabIndex = 173
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.AutoSize = True
        Me.MetroTile2.BackColor = System.Drawing.Color.DodgerBlue
        Me.MetroTile2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MetroTile2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTile2.Location = New System.Drawing.Point(-2, 2)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(914, 94)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Pink
        Me.MetroTile2.TabIndex = 174
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MetroTile2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroTile2.UseCustomBackColor = True
        Me.MetroTile2.UseSelectable = True
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtCliente.Lines = New String(-1) {}
        Me.txtCliente.Location = New System.Drawing.Point(138, 137)
        Me.txtCliente.MaxLength = 32767
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCliente.SelectedText = ""
        Me.txtCliente.Size = New System.Drawing.Size(575, 23)
        Me.txtCliente.TabIndex = 181
        Me.txtCliente.UseSelectable = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.MetroTextBox5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel10)
        Me.GroupBox1.Controls.Add(Me.MetroLabel12)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.MetroLabel17)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(558, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 70)
        Me.GroupBox1.TabIndex = 170
        Me.GroupBox1.TabStop = False
        '
        'MetroTextBox5
        '
        Me.MetroTextBox5.Lines = New String(-1) {}
        Me.MetroTextBox5.Location = New System.Drawing.Point(418, 236)
        Me.MetroTextBox5.MaxLength = 32767
        Me.MetroTextBox5.Name = "MetroTextBox5"
        Me.MetroTextBox5.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox5.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox5.SelectedText = ""
        Me.MetroTextBox5.Size = New System.Drawing.Size(209, 23)
        Me.MetroTextBox5.TabIndex = 50
        Me.MetroTextBox5.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(5, 30)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(137, 19)
        Me.MetroLabel10.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel10.TabIndex = 48
        Me.MetroLabel10.Text = "NUMERO DE PEDIDO"
        Me.MetroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel10.UseCustomBackColor = True
        Me.MetroLabel10.UseCustomForeColor = True
        Me.MetroLabel10.UseStyleColors = True
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(418, 103)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(58, 19)
        Me.MetroLabel12.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel12.TabIndex = 46
        Me.MetroLabel12.Text = "CLIENTE"
        Me.MetroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel12.UseCustomBackColor = True
        Me.MetroLabel12.UseCustomForeColor = True
        Me.MetroLabel12.UseStyleColors = True
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtNumero.Enabled = False
        Me.txtNumero.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtNumero.Lines = New String() {"00000000001"}
        Me.txtNumero.Location = New System.Drawing.Point(158, 24)
        Me.txtNumero.MaxLength = 32767
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumero.SelectedText = ""
        Me.txtNumero.Size = New System.Drawing.Size(161, 30)
        Me.txtNumero.TabIndex = 40
        Me.txtNumero.Text = "00000000001"
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNumero.UseSelectable = True
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(360, 240)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel17.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel17.TabIndex = 33
        Me.MetroLabel17.Text = "TOTAL"
        Me.MetroLabel17.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel17.UseCustomBackColor = True
        Me.MetroLabel17.UseCustomForeColor = True
        Me.MetroLabel17.UseStyleColors = True
        '
        'dtpFecha
        '
        Me.dtpFecha.CalendarTitleBackColor = System.Drawing.Color.DarkGray
        Me.dtpFecha.CalendarTitleForeColor = System.Drawing.Color.White
        Me.dtpFecha.Checked = False
        Me.dtpFecha.Location = New System.Drawing.Point(138, 179)
        Me.dtpFecha.MaxDate = New Date(3015, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha.MinDate = New Date(2015, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(235, 29)
        Me.dtpFecha.TabIndex = 52
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(23, 183)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(107, 19)
        Me.MetroLabel16.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel16.TabIndex = 42
        Me.MetroLabel16.Text = "FECHA EMISION"
        Me.MetroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel16.UseCustomBackColor = True
        Me.MetroLabel16.UseCustomForeColor = True
        Me.MetroLabel16.UseStyleColors = True
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscarCliente.BackgroundImage = CType(resources.GetObject("btnBuscarCliente.BackgroundImage"), System.Drawing.Image)
        Me.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscarCliente.FlatAppearance.BorderSize = 0
        Me.btnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscarCliente.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnBuscarCliente.ForeColor = System.Drawing.Color.White
        Me.btnBuscarCliente.Location = New System.Drawing.Point(717, 131)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(41, 35)
        Me.btnBuscarCliente.TabIndex = 182
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(223, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(250, 38)
        Me.Label1.TabIndex = 216
        Me.Label1.Text = "Gestion Orden Pedido"
        Me.Label1.UseCompatibleTextRendering = True
        Me.Label1.UseMnemonic = False
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
        Me.Button6.Location = New System.Drawing.Point(14, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(145, 94)
        Me.Button6.TabIndex = 218
        Me.Button6.UseCompatibleTextRendering = True
        Me.Button6.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Transparent
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.Black
        Me.btnEliminar.Image = CType(resources.GetObject("btnEliminar.Image"), System.Drawing.Image)
        Me.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnEliminar.Location = New System.Drawing.Point(819, 363)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 72)
        Me.btnEliminar.TabIndex = 219
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.btnNuevo)
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Controls.Add(Me.btnGuardarCierre)
        Me.Panel2.Location = New System.Drawing.Point(1, 651)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(911, 79)
        Me.Panel2.TabIndex = 220
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(8, 3)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 72)
        Me.btnNuevo.TabIndex = 156
        Me.btnNuevo.Text = "&Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
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
        Me.btnSalir.Location = New System.Drawing.Point(819, 3)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(73, 72)
        Me.btnSalir.TabIndex = 155
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
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
        Me.btnGuardarCierre.Location = New System.Drawing.Point(421, 3)
        Me.btnGuardarCierre.Name = "btnGuardarCierre"
        Me.btnGuardarCierre.Size = New System.Drawing.Size(111, 72)
        Me.btnGuardarCierre.TabIndex = 154
        Me.btnGuardarCierre.Text = "&Registrar"
        Me.btnGuardarCierre.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardarCierre.UseVisualStyleBackColor = False
        '
        'lblIGV
        '
        Me.lblIGV.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblIGV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblIGV.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblIGV.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblIGV.Location = New System.Drawing.Point(670, 569)
        Me.lblIGV.Name = "lblIGV"
        Me.lblIGV.Size = New System.Drawing.Size(123, 30)
        Me.lblIGV.Style = MetroFramework.MetroColorStyle.Green
        Me.lblIGV.TabIndex = 233
        Me.lblIGV.Text = "0.00"
        Me.lblIGV.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblIGV.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblIGV.UseCustomBackColor = True
        Me.lblIGV.UseCustomForeColor = True
        Me.lblIGV.UseStyleColors = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MetroLabel3.Location = New System.Drawing.Point(595, 580)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel3.TabIndex = 234
        Me.MetroLabel3.Text = "IGV TOTAL"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        Me.MetroLabel3.UseStyleColors = True
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblTotal.Location = New System.Drawing.Point(670, 610)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(123, 30)
        Me.lblTotal.Style = MetroFramework.MetroColorStyle.Green
        Me.lblTotal.TabIndex = 235
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotal.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblTotal.UseCustomBackColor = True
        Me.lblTotal.UseCustomForeColor = True
        Me.lblTotal.UseStyleColors = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MetroLabel6.Location = New System.Drawing.Point(591, 539)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel6.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel6.TabIndex = 237
        Me.MetroLabel6.Text = "SUB TOTAL"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel6.UseCustomBackColor = True
        Me.MetroLabel6.UseCustomForeColor = True
        Me.MetroLabel6.UseStyleColors = True
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSubTotal.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblSubTotal.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblSubTotal.Location = New System.Drawing.Point(670, 530)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(123, 30)
        Me.lblSubTotal.Style = MetroFramework.MetroColorStyle.Green
        Me.lblSubTotal.TabIndex = 236
        Me.lblSubTotal.Text = "0.00"
        Me.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblSubTotal.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblSubTotal.UseCustomBackColor = True
        Me.lblSubTotal.UseCustomForeColor = True
        Me.lblSubTotal.UseStyleColors = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NombreModelo"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.HeaderText = "PRODUCTO"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 420
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cantidad"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn1.HeaderText = "CANT."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "PrecioUnitario"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column1.HeaderText = "PRECIO UNIT."
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 120
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Total"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn5.HeaderText = "SUBTOTAL"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 120
        '
        'frmOrdenPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 729)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.lblIGV)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MetroLabel16)
        Me.Controls.Add(Me.btnBuscarCliente)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.MetroLabel8)
        Me.Controls.Add(Me.gbProducto)
        Me.Controls.Add(Me.dgvProductos)
        Me.Controls.Add(Me.MetroLabel1)
        Me.KeyPreview = True
        Me.Name = "frmOrdenPedido"
        Me.gbProducto.ResumeLayout(False)
        Me.gbProducto.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents gbProducto As System.Windows.Forms.GroupBox
    Friend WithEvents txtMonto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents txtCliente As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtProducto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnBuscarProducto As System.Windows.Forms.Button
    Friend WithEvents btnBuscarCliente As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpFecha As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroTextBox5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNumero As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtCantidad As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnGuardarCierre As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtPrecioUnitario As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents lblIGV As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblSubTotal As MetroFramework.Controls.MetroLabel
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
