﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocumentoVenta

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocumentoVenta))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.lblCliente = New MetroFramework.Controls.MetroLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRuc = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.txtSucursal = New MetroFramework.Controls.MetroTextBox()
        Me.txtSerie = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtNumero = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox5 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblDoc = New MetroFramework.Controls.MetroLabel()
        Me.txtDoc = New MetroFramework.Controls.MetroTextBox()
        Me.txtCliente = New MetroFramework.Controls.MetroTextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtTotal = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel21 = New MetroFramework.Controls.MetroLabel()
        Me.txtIGV = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        'Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        'Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.txtNumOrdenPedido = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.gbCuotas = New System.Windows.Forms.GroupBox()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.txtMontoRestante = New MetroFramework.Controls.MetroTextBox()
        Me.dgvCuotas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NroCuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Interes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.numCuotas = New System.Windows.Forms.NumericUpDown()
        Me.MetroLabel18 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.txtMontoInicial = New MetroFramework.Controls.MetroTextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtDescuento = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtSubTotal = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtCajero = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.txtNumCaja = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.txtVendedor = New MetroFramework.Controls.MetroTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboFormaPago = New System.Windows.Forms.ComboBox()
        Me.btnEfectuarPago = New System.Windows.Forms.Button()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.cboTipoDoc = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox10.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gbCuotas.SuspendLayout()
        CType(Me.dgvCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCuotas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.BackColor = System.Drawing.Color.DodgerBlue
        Me.MetroTile2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MetroTile2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTile2.Location = New System.Drawing.Point(0, 2)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(1121, 86)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Pink
        Me.MetroTile2.TabIndex = 181
        Me.MetroTile2.Text = "                 DOCUMENTO DE VENTA"
        Me.MetroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroTile2.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTile2.TileImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall
        Me.MetroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold
        Me.MetroTile2.UseCustomBackColor = True
        Me.MetroTile2.UseSelectable = True
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(7, 32)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(89, 19)
        Me.lblCliente.Style = MetroFramework.MetroColorStyle.Green
        Me.lblCliente.TabIndex = 187
        Me.lblCliente.Text = "      NOMBRE"
        Me.lblCliente.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblCliente.UseCustomBackColor = True
        Me.lblCliente.UseCustomForeColor = True
        Me.lblCliente.UseStyleColors = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.txtRuc)
        Me.GroupBox1.Controls.Add(Me.MetroLabel11)
        Me.GroupBox1.Controls.Add(Me.txtSucursal)
        Me.GroupBox1.Controls.Add(Me.txtSerie)
        Me.GroupBox1.Controls.Add(Me.MetroLabel10)
        Me.GroupBox1.Controls.Add(Me.MetroLabel1)
        Me.GroupBox1.Controls.Add(Me.MetroLabel7)
        Me.GroupBox1.Controls.Add(Me.txtNumero)
        Me.GroupBox1.Controls.Add(Me.MetroTextBox5)
        Me.GroupBox1.Controls.Add(Me.MetroLabel12)
        Me.GroupBox1.Controls.Add(Me.MetroLabel17)
        Me.GroupBox1.Controls.Add(Me.MetroLabel14)
        Me.GroupBox1.Controls.Add(Me.MetroDateTime1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(386, -1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(735, 82)
        Me.GroupBox1.TabIndex = 170
        Me.GroupBox1.TabStop = False
        '
        'txtRuc
        '
        Me.txtRuc.Enabled = False
        Me.txtRuc.Lines = New String(-1) {}
        Me.txtRuc.Location = New System.Drawing.Point(320, 51)
        Me.txtRuc.MaxLength = 32767
        Me.txtRuc.Name = "txtRuc"
        Me.txtRuc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtRuc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtRuc.SelectedText = ""
        Me.txtRuc.Size = New System.Drawing.Size(139, 23)
        Me.txtRuc.TabIndex = 226
        Me.txtRuc.UseSelectable = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(274, 50)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(35, 19)
        Me.MetroLabel11.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel11.TabIndex = 225
        Me.MetroLabel11.Text = "RUC"
        Me.MetroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel11.UseCustomBackColor = True
        Me.MetroLabel11.UseCustomForeColor = True
        Me.MetroLabel11.UseStyleColors = True
        '
        'txtSucursal
        '
        Me.txtSucursal.Enabled = False
        Me.txtSucursal.Lines = New String(-1) {}
        Me.txtSucursal.Location = New System.Drawing.Point(320, 18)
        Me.txtSucursal.MaxLength = 32767
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSucursal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSucursal.SelectedText = ""
        Me.txtSucursal.Size = New System.Drawing.Size(390, 23)
        Me.txtSucursal.TabIndex = 224
        Me.txtSucursal.UseSelectable = True
        '
        'txtSerie
        '
        Me.txtSerie.Enabled = False
        Me.txtSerie.Lines = New String(-1) {}
        Me.txtSerie.Location = New System.Drawing.Point(81, 50)
        Me.txtSerie.MaxLength = 32767
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSerie.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSerie.SelectedText = ""
        Me.txtSerie.Size = New System.Drawing.Size(139, 23)
        Me.txtSerie.TabIndex = 54
        Me.txtSerie.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(21, 51)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel10.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel10.TabIndex = 53
        Me.MetroLabel10.Text = "SERIE"
        Me.MetroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel10.UseCustomBackColor = True
        Me.MetroLabel10.UseCustomForeColor = True
        Me.MetroLabel10.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(236, 22)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel1.TabIndex = 223
        Me.MetroLabel1.Text = "SUCURSAL"
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        Me.MetroLabel1.UseStyleColors = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(6, 20)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel7.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel7.TabIndex = 52
        Me.MetroLabel7.Text = "NUMERO"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel7.UseCustomBackColor = True
        Me.MetroLabel7.UseCustomForeColor = True
        Me.MetroLabel7.UseStyleColors = True
        '
        'txtNumero
        '
        Me.txtNumero.Enabled = False
        Me.txtNumero.Lines = New String(-1) {}
        Me.txtNumero.Location = New System.Drawing.Point(81, 18)
        Me.txtNumero.MaxLength = 32767
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumero.SelectedText = ""
        Me.txtNumero.Size = New System.Drawing.Size(139, 23)
        Me.txtNumero.TabIndex = 51
        Me.txtNumero.UseSelectable = True
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
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(476, 51)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel14.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel14.TabIndex = 195
        Me.MetroLabel14.Text = "FECHA E."
        Me.MetroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel14.UseCustomBackColor = True
        Me.MetroLabel14.UseCustomForeColor = True
        Me.MetroLabel14.UseStyleColors = True
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.Enabled = False
        Me.MetroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MetroDateTime1.Location = New System.Drawing.Point(552, 46)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(158, 29)
        Me.MetroDateTime1.TabIndex = 196
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.White
        Me.GroupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox4.Controls.Add(Me.lblDoc)
        Me.GroupBox4.Controls.Add(Me.txtDoc)
        Me.GroupBox4.Controls.Add(Me.txtCliente)
        Me.GroupBox4.Controls.Add(Me.lblCliente)
        Me.GroupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Black
        Me.GroupBox4.Location = New System.Drawing.Point(10, 191)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(748, 75)
        Me.GroupBox4.TabIndex = 199
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "CLIENTE"
        '
        'lblDoc
        '
        Me.lblDoc.AutoSize = True
        Me.lblDoc.Location = New System.Drawing.Point(519, 34)
        Me.lblDoc.Name = "lblDoc"
        Me.lblDoc.Size = New System.Drawing.Size(38, 19)
        Me.lblDoc.Style = MetroFramework.MetroColorStyle.Green
        Me.lblDoc.TabIndex = 211
        Me.lblDoc.Text = "DOC"
        Me.lblDoc.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblDoc.UseCustomBackColor = True
        Me.lblDoc.UseCustomForeColor = True
        Me.lblDoc.UseStyleColors = True
        '
        'txtDoc
        '
        Me.txtDoc.Enabled = False
        Me.txtDoc.Lines = New String(-1) {}
        Me.txtDoc.Location = New System.Drawing.Point(571, 32)
        Me.txtDoc.MaxLength = 32767
        Me.txtDoc.Name = "txtDoc"
        Me.txtDoc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDoc.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDoc.SelectedText = ""
        Me.txtDoc.Size = New System.Drawing.Size(154, 23)
        Me.txtDoc.TabIndex = 212
        Me.txtDoc.UseSelectable = True
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Lines = New String(-1) {}
        Me.txtCliente.Location = New System.Drawing.Point(119, 30)
        Me.txtCliente.MaxLength = 32767
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCliente.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCliente.SelectedText = ""
        Me.txtCliente.Size = New System.Drawing.Size(344, 23)
        Me.txtCliente.TabIndex = 199
        Me.txtCliente.UseSelectable = True
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
        Me.btnBuscar.Location = New System.Drawing.Point(258, 144)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(42, 28)
        Me.btnBuscar.TabIndex = 192
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtTotal
        '
        Me.txtTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtTotal.Lines = New String(-1) {}
        Me.txtTotal.Location = New System.Drawing.Point(125, 135)
        Me.txtTotal.MaxLength = 32767
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotal.SelectedText = ""
        Me.txtTotal.Size = New System.Drawing.Size(144, 30)
        Me.txtTotal.TabIndex = 177
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotal.UseSelectable = True
        '
        'MetroLabel21
        '
        Me.MetroLabel21.AutoSize = True
        Me.MetroLabel21.Location = New System.Drawing.Point(69, 139)
        Me.MetroLabel21.Name = "MetroLabel21"
        Me.MetroLabel21.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel21.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel21.TabIndex = 43
        Me.MetroLabel21.Text = "TOTAL"
        Me.MetroLabel21.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel21.UseCustomBackColor = True
        Me.MetroLabel21.UseCustomForeColor = True
        Me.MetroLabel21.UseStyleColors = True
        '
        'txtIGV
        '
        Me.txtIGV.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtIGV.Lines = New String(-1) {}
        Me.txtIGV.Location = New System.Drawing.Point(125, 55)
        Me.txtIGV.MaxLength = 32767
        Me.txtIGV.Name = "txtIGV"
        Me.txtIGV.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtIGV.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtIGV.SelectedText = ""
        Me.txtIGV.Size = New System.Drawing.Size(144, 30)
        Me.txtIGV.TabIndex = 176
        Me.txtIGV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIGV.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(85, 59)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(29, 19)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel3.TabIndex = 47
        Me.MetroLabel3.Text = "IGV"
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        Me.MetroLabel3.UseStyleColors = True
        '
        'dgvProductos
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProductos.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        'Me.dgvProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Column4, Me.Column1, Me.Column2, Me.Column3})
        Me.dgvProductos.Location = New System.Drawing.Point(12, 25)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.Size = New System.Drawing.Size(1075, 127)
        Me.dgvProductos.TabIndex = 208
        '
        'Codigo
        '
        'Me.Codigo.DataPropertyName = "CodigoModelo"
        'Me.Codigo.HeaderText = "CODIGO"
        'Me.Codigo.Name = "Codigo"
        '
        'Column4
        '
        'Me.Column4.DataPropertyName = "NombreModelo"
        'Me.Column4.HeaderText = "PRODUCTO"
        'Me.Column4.Name = "Column4"
        'Me.Column4.Width = 440
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "PrecioUnitario"
        Me.Column1.HeaderText = "PRECIO UNIT."
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Cantidad"
        Me.Column2.HeaderText = "CANTIDAD"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Total"
        Me.Column3.HeaderText = "SUB TOTAL"
        Me.Column3.Name = "Column3"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(27, 150)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(125, 19)
        Me.MetroLabel9.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel9.TabIndex = 213
        Me.MetroLabel9.Text = "Nº ORDEN PEDIDO"
        Me.MetroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel9.UseCustomBackColor = True
        Me.MetroLabel9.UseCustomForeColor = True
        Me.MetroLabel9.UseStyleColors = True
        '
        'txtNumOrdenPedido
        '
        Me.txtNumOrdenPedido.Lines = New String(-1) {}
        Me.txtNumOrdenPedido.Location = New System.Drawing.Point(158, 148)
        Me.txtNumOrdenPedido.MaxLength = 32767
        Me.txtNumOrdenPedido.Name = "txtNumOrdenPedido"
        Me.txtNumOrdenPedido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumOrdenPedido.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumOrdenPedido.SelectedText = ""
        Me.txtNumOrdenPedido.Size = New System.Drawing.Size(94, 23)
        Me.txtNumOrdenPedido.TabIndex = 214
        Me.txtNumOrdenPedido.UseCustomBackColor = True
        Me.txtNumOrdenPedido.UseSelectable = True
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.White
        Me.GroupBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox10.Controls.Add(Me.dgvProductos)
        Me.GroupBox10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.ForeColor = System.Drawing.Color.Black
        Me.GroupBox10.Location = New System.Drawing.Point(10, 273)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(1101, 165)
        Me.GroupBox10.TabIndex = 215
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "PRODUCTOS"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.btnCancelar)
        Me.Panel2.Controls.Add(Me.btnGuardar)
        Me.Panel2.Controls.Add(Me.btnNuevo)
        Me.Panel2.Controls.Add(Me.btnSalir)
        Me.Panel2.Location = New System.Drawing.Point(1, 641)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1120, 68)
        Me.Panel2.TabIndex = 216
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
        Me.btnCancelar.Location = New System.Drawing.Point(110, -2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 72)
        Me.btnCancelar.TabIndex = 7
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
        Me.btnGuardar.Location = New System.Drawing.Point(535, -2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(72, 72)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardar.UseVisualStyleBackColor = False
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
        Me.btnNuevo.Location = New System.Drawing.Point(16, -1)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(72, 72)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo"
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
        Me.btnSalir.Location = New System.Drawing.Point(1017, -2)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(84, 72)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'gbCuotas
        '
        Me.gbCuotas.BackColor = System.Drawing.Color.White
        Me.gbCuotas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbCuotas.Controls.Add(Me.MetroLabel19)
        Me.gbCuotas.Controls.Add(Me.txtMontoRestante)
        Me.gbCuotas.Controls.Add(Me.dgvCuotas)
        Me.gbCuotas.Controls.Add(Me.numCuotas)
        Me.gbCuotas.Controls.Add(Me.MetroLabel18)
        Me.gbCuotas.Controls.Add(Me.MetroLabel16)
        Me.gbCuotas.Controls.Add(Me.txtMontoInicial)
        Me.gbCuotas.Enabled = False
        Me.gbCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbCuotas.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCuotas.ForeColor = System.Drawing.Color.Black
        Me.gbCuotas.Location = New System.Drawing.Point(10, 481)
        Me.gbCuotas.Name = "gbCuotas"
        Me.gbCuotas.Size = New System.Drawing.Size(1101, 154)
        Me.gbCuotas.TabIndex = 217
        Me.gbCuotas.TabStop = False
        Me.gbCuotas.Text = "CUOTAS"
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.Location = New System.Drawing.Point(26, 74)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(123, 19)
        Me.MetroLabel19.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel19.TabIndex = 220
        Me.MetroLabel19.Text = "MONTO RESTANTE"
        Me.MetroLabel19.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel19.UseCustomBackColor = True
        Me.MetroLabel19.UseCustomForeColor = True
        Me.MetroLabel19.UseStyleColors = True
        '
        'txtMontoRestante
        '
        Me.txtMontoRestante.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMontoRestante.Enabled = False
        Me.txtMontoRestante.Lines = New String(-1) {}
        Me.txtMontoRestante.Location = New System.Drawing.Point(155, 74)
        Me.txtMontoRestante.MaxLength = 32767
        Me.txtMontoRestante.Name = "txtMontoRestante"
        Me.txtMontoRestante.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontoRestante.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontoRestante.SelectedText = ""
        Me.txtMontoRestante.Size = New System.Drawing.Size(120, 23)
        Me.txtMontoRestante.TabIndex = 221
        Me.txtMontoRestante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMontoRestante.UseCustomBackColor = True
        Me.txtMontoRestante.UseSelectable = True
        '
        'dgvCuotas
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue
        Me.dgvCuotas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCuotas.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvCuotas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvCuotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuotas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.NroCuota, Me.Interes, Me.Monto})
        Me.dgvCuotas.Enabled = False
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCuotas.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvCuotas.Location = New System.Drawing.Point(408, 25)
        Me.dgvCuotas.Name = "dgvCuotas"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCuotas.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvCuotas.RowHeadersVisible = False
        Me.dgvCuotas.Size = New System.Drawing.Size(678, 113)
        Me.dgvCuotas.TabIndex = 209
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "FECHA"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'NroCuota
        '
        Me.NroCuota.HeaderText = "Nº CUOTA"
        Me.NroCuota.Name = "NroCuota"
        Me.NroCuota.Width = 120
        '
        'Interes
        '
        Me.Interes.HeaderText = "COMISION"
        Me.Interes.Name = "Interes"
        Me.Interes.Width = 150
        '
        'Monto
        '
        Me.Monto.HeaderText = "MONTO"
        Me.Monto.Name = "Monto"
        Me.Monto.Width = 200
        '
        'numCuotas
        '
        Me.numCuotas.Location = New System.Drawing.Point(155, 108)
        Me.numCuotas.Name = "numCuotas"
        Me.numCuotas.Size = New System.Drawing.Size(120, 23)
        Me.numCuotas.TabIndex = 219
        '
        'MetroLabel18
        '
        Me.MetroLabel18.AutoSize = True
        Me.MetroLabel18.Location = New System.Drawing.Point(71, 112)
        Me.MetroLabel18.Name = "MetroLabel18"
        Me.MetroLabel18.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel18.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel18.TabIndex = 218
        Me.MetroLabel18.Text = "Nº CUOTAS"
        Me.MetroLabel18.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel18.UseCustomBackColor = True
        Me.MetroLabel18.UseCustomForeColor = True
        Me.MetroLabel18.UseStyleColors = True
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(43, 36)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(106, 19)
        Me.MetroLabel16.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel16.TabIndex = 215
        Me.MetroLabel16.Text = "MONTO INICIAL"
        Me.MetroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel16.UseCustomBackColor = True
        Me.MetroLabel16.UseCustomForeColor = True
        Me.MetroLabel16.UseStyleColors = True
        '
        'txtMontoInicial
        '
        Me.txtMontoInicial.Lines = New String(-1) {}
        Me.txtMontoInicial.Location = New System.Drawing.Point(155, 36)
        Me.txtMontoInicial.MaxLength = 32767
        Me.txtMontoInicial.Name = "txtMontoInicial"
        Me.txtMontoInicial.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontoInicial.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontoInicial.SelectedText = ""
        Me.txtMontoInicial.Size = New System.Drawing.Size(120, 23)
        Me.txtMontoInicial.TabIndex = 217
        Me.txtMontoInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMontoInicial.UseCustomBackColor = True
        Me.txtMontoInicial.UseSelectable = True
        '
        'Button6
        '
        Me.Button6.AutoSize = True
        Me.Button6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), System.Drawing.Image)
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(1, 1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(79, 83)
        Me.Button6.TabIndex = 218
        Me.Button6.UseCompatibleTextRendering = True
        Me.Button6.UseVisualStyleBackColor = False
        '
        'txtDescuento
        '
        Me.txtDescuento.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtDescuento.Lines = New String(-1) {}
        Me.txtDescuento.Location = New System.Drawing.Point(125, 93)
        Me.txtDescuento.MaxLength = 32767
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescuento.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescuento.SelectedText = ""
        Me.txtDescuento.Size = New System.Drawing.Size(144, 30)
        Me.txtDescuento.TabIndex = 220
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDescuento.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(30, 97)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel4.TabIndex = 219
        Me.MetroLabel4.Text = "DESCUENTO"
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        Me.MetroLabel4.UseStyleColors = True
        '
        'txtSubTotal
        '
        Me.txtSubTotal.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.txtSubTotal.Lines = New String(-1) {}
        Me.txtSubTotal.Location = New System.Drawing.Point(125, 14)
        Me.txtSubTotal.MaxLength = 32767
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSubTotal.SelectedText = ""
        Me.txtSubTotal.Size = New System.Drawing.Size(144, 30)
        Me.txtSubTotal.TabIndex = 222
        Me.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSubTotal.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(41, 18)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel2.TabIndex = 221
        Me.MetroLabel2.Text = "SUB TOTAL"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        Me.MetroLabel2.UseStyleColors = True
        '
        'txtCajero
        '
        Me.txtCajero.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtCajero.Enabled = False
        Me.txtCajero.Lines = New String(-1) {}
        Me.txtCajero.Location = New System.Drawing.Point(230, 108)
        Me.txtCajero.MaxLength = 32767
        Me.txtCajero.Name = "txtCajero"
        Me.txtCajero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCajero.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCajero.SelectedText = ""
        Me.txtCajero.Size = New System.Drawing.Size(248, 23)
        Me.txtCajero.TabIndex = 224
        Me.txtCajero.UseCustomBackColor = True
        Me.txtCajero.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(163, 112)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel6.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel6.TabIndex = 225
        Me.MetroLabel6.Text = "CAJERO"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel6.UseCustomBackColor = True
        Me.MetroLabel6.UseCustomForeColor = True
        Me.MetroLabel6.UseStyleColors = True
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(23, 112)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(62, 19)
        Me.MetroLabel13.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel13.TabIndex = 227
        Me.MetroLabel13.Text = "Nº CAJA"
        Me.MetroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel13.UseCustomBackColor = True
        Me.MetroLabel13.UseCustomForeColor = True
        Me.MetroLabel13.UseStyleColors = True
        '
        'txtNumCaja
        '
        Me.txtNumCaja.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNumCaja.Enabled = False
        Me.txtNumCaja.Lines = New String(-1) {}
        Me.txtNumCaja.Location = New System.Drawing.Point(91, 108)
        Me.txtNumCaja.MaxLength = 32767
        Me.txtNumCaja.Name = "txtNumCaja"
        Me.txtNumCaja.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumCaja.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumCaja.SelectedText = ""
        Me.txtNumCaja.Size = New System.Drawing.Size(51, 23)
        Me.txtNumCaja.TabIndex = 226
        Me.txtNumCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNumCaja.UseCustomBackColor = True
        Me.txtNumCaja.UseSelectable = True
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(370, 152)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(78, 19)
        Me.MetroLabel15.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel15.TabIndex = 229
        Me.MetroLabel15.Text = "VENDEDOR"
        Me.MetroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel15.UseCustomBackColor = True
        Me.MetroLabel15.UseCustomForeColor = True
        Me.MetroLabel15.UseStyleColors = True
        '
        'txtVendedor
        '
        Me.txtVendedor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtVendedor.Enabled = False
        Me.txtVendedor.Lines = New String(-1) {}
        Me.txtVendedor.Location = New System.Drawing.Point(467, 149)
        Me.txtVendedor.MaxLength = 32767
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVendedor.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtVendedor.SelectedText = ""
        Me.txtVendedor.Size = New System.Drawing.Size(291, 23)
        Me.txtVendedor.TabIndex = 228
        Me.txtVendedor.UseCustomBackColor = True
        Me.txtVendedor.UseSelectable = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTotal)
        Me.GroupBox2.Controls.Add(Me.txtSubTotal)
        Me.GroupBox2.Controls.Add(Me.MetroLabel21)
        Me.GroupBox2.Controls.Add(Me.MetroLabel2)
        Me.GroupBox2.Controls.Add(Me.MetroLabel3)
        Me.GroupBox2.Controls.Add(Me.txtDescuento)
        Me.GroupBox2.Controls.Add(Me.MetroLabel4)
        Me.GroupBox2.Controls.Add(Me.txtIGV)
        Me.GroupBox2.Location = New System.Drawing.Point(828, 90)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(283, 176)
        Me.GroupBox2.TabIndex = 230
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 454)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 16)
        Me.Label1.TabIndex = 231
        Me.Label1.Text = "FORMA DE PAGO"
        '
        'cboFormaPago
        '
        Me.cboFormaPago.FormattingEnabled = True
        Me.cboFormaPago.Items.AddRange(New Object() {"CONTADO", "CREDITO"})
        Me.cboFormaPago.Location = New System.Drawing.Point(148, 454)
        Me.cboFormaPago.Name = "cboFormaPago"
        Me.cboFormaPago.Size = New System.Drawing.Size(172, 21)
        Me.cboFormaPago.TabIndex = 232
        '
        'btnEfectuarPago
        '
        Me.btnEfectuarPago.Location = New System.Drawing.Point(341, 447)
        Me.btnEfectuarPago.Name = "btnEfectuarPago"
        Me.btnEfectuarPago.Size = New System.Drawing.Size(139, 32)
        Me.btnEfectuarPago.TabIndex = 233
        Me.btnEfectuarPago.Text = "EFECTUAR PAGO"
        Me.btnEfectuarPago.UseVisualStyleBackColor = True
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.Location = New System.Drawing.Point(496, 108)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(126, 19)
        Me.MetroLabel20.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel20.TabIndex = 234
        Me.MetroLabel20.Text = "TIPO DOCUMENTO"
        Me.MetroLabel20.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel20.UseCustomBackColor = True
        Me.MetroLabel20.UseCustomForeColor = True
        Me.MetroLabel20.UseStyleColors = True
        '
        'cboTipoDoc
        '
        Me.cboTipoDoc.FormattingEnabled = True
        Me.cboTipoDoc.Items.AddRange(New Object() {"BOLETA", "FACTURA"})
        Me.cboTipoDoc.Location = New System.Drawing.Point(629, 108)
        Me.cboTipoDoc.Name = "cboTipoDoc"
        Me.cboTipoDoc.Size = New System.Drawing.Size(125, 21)
        Me.cboTipoDoc.TabIndex = 235
        '
        'frmDocumentoVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
        Me.ClientSize = New System.Drawing.Size(1121, 709)
        Me.Controls.Add(Me.cboTipoDoc)
        Me.Controls.Add(Me.MetroLabel20)
        Me.Controls.Add(Me.btnEfectuarPago)
        Me.Controls.Add(Me.cboFormaPago)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MetroLabel15)
        Me.Controls.Add(Me.txtVendedor)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.txtNumCaja)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.txtCajero)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.gbCuotas)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.MetroLabel9)
        Me.Controls.Add(Me.txtNumOrdenPedido)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MetroTile2)
        Me.MaximizeBox = False
        Me.Movable = False
        Me.Name = "frmDocumentoVenta"
        Me.Resizable = False
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox10.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.gbCuotas.ResumeLayout(False)
        Me.gbCuotas.PerformLayout()
        CType(Me.dgvCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCuotas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblCliente As MetroFramework.Controls.MetroLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSerie As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNumero As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox5 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCliente As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel21 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtIGV As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dgvProductos As System.Windows.Forms.DataGridView
    Friend WithEvents lblDoc As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDoc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNumOrdenPedido As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents gbCuotas As System.Windows.Forms.GroupBox
    Public WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents txtDescuento As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSubTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtRuc As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtSucursal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents numCuotas As System.Windows.Forms.NumericUpDown
    Friend WithEvents MetroLabel18 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMontoInicial As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCajero As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNumCaja As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtVendedor As MetroFramework.Controls.MetroTextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents btnEfectuarPago As System.Windows.Forms.Button
    Friend WithEvents dgvCuotas As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NroCuota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Interes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMontoRestante As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboTipoDoc As System.Windows.Forms.ComboBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
