<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroPagos

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistroPagos))
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.gbCheque = New System.Windows.Forms.GroupBox()
        Me.numMontoCHE = New System.Windows.Forms.NumericUpDown()
        Me.MetroLabel16 = New MetroFramework.Controls.MetroLabel()
        Me.dtpFechaGiro = New MetroFramework.Controls.MetroDateTime()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.txtNumeroCH = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel35 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel33 = New MetroFramework.Controls.MetroLabel()
        Me.gbDeposito = New System.Windows.Forms.GroupBox()
        Me.numMontoDEP = New System.Windows.Forms.NumericUpDown()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.cboBancoDEP = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.cboCuentaDEP = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel31 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel34 = New MetroFramework.Controls.MetroLabel()
        Me.gbTarjeta = New System.Windows.Forms.GroupBox()
        Me.numMontoTAR = New System.Windows.Forms.NumericUpDown()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.cboBancoTAR = New MetroFramework.Controls.MetroComboBox()
        Me.txtNumTAR2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtNumTAR3 = New MetroFramework.Controls.MetroTextBox()
        Me.txtNumTAR4 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel17 = New MetroFramework.Controls.MetroLabel()
        Me.txtNumTAR1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.cboTarjeta = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel30 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel29 = New MetroFramework.Controls.MetroLabel()
        Me.gbEfectivo = New System.Windows.Forms.GroupBox()
        Me.numPagaCon = New System.Windows.Forms.NumericUpDown()
        Me.txtVuelto = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel27 = New MetroFramework.Controls.MetroLabel()
        Me.MtxtDescripcion = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.txtMontoFijo = New MetroFramework.Controls.MetroTextBox()
        Me.txtDescuento = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroDateTime1 = New MetroFramework.Controls.MetroDateTime()
        Me.MetroComboBox1 = New MetroFramework.Controls.MetroComboBox()
        Me.MetroTextBox1 = New MetroFramework.Controls.MetroTextBox()
        Me.lblMontoAPagar = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.dtFecha = New MetroFramework.Controls.MetroDateTime()
        Me.tglEfectivo = New MetroFramework.Controls.MetroToggle()
        Me.tglDeposito = New MetroFramework.Controls.MetroToggle()
        Me.tglTarjeta = New MetroFramework.Controls.MetroToggle()
        Me.tglCheque = New MetroFramework.Controls.MetroToggle()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.lblMontoPagando = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.lblMontoFaltante = New MetroFramework.Controls.MetroLabel()
        Me.lblMontoF = New MetroFramework.Controls.MetroLabel()
        Me.MetroTile2.SuspendLayout()
        Me.gbCheque.SuspendLayout()
        CType(Me.numMontoCHE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDeposito.SuspendLayout()
        CType(Me.numMontoDEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTarjeta.SuspendLayout()
        CType(Me.numMontoTAR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEfectivo.SuspendLayout()
        CType(Me.numPagaCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTile2
        '
        Me.MetroTile2.ActiveControl = Nothing
        Me.MetroTile2.AutoSize = True
        Me.MetroTile2.BackColor = System.Drawing.Color.DodgerBlue
        Me.MetroTile2.Controls.Add(Me.MetroLabel14)
        Me.MetroTile2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MetroTile2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTile2.Location = New System.Drawing.Point(0, 2)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(1037, 100)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTile2.TabIndex = 164
        Me.MetroTile2.Text = "REGISTRO DE PAGOS "
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
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MetroLabel14.Location = New System.Drawing.Point(732, 64)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel14.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel14.TabIndex = 214
        Me.MetroLabel14.Text = "HOY"
        Me.MetroLabel14.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel14.UseCustomBackColor = True
        Me.MetroLabel14.UseCustomForeColor = True
        Me.MetroLabel14.UseStyleColors = True
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
        Me.Button6.Location = New System.Drawing.Point(0, 10)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(181, 78)
        Me.Button6.TabIndex = 165
        Me.Button6.UseCompatibleTextRendering = True
        Me.Button6.UseVisualStyleBackColor = False
        '
        'gbCheque
        '
        Me.gbCheque.BackColor = System.Drawing.Color.White
        Me.gbCheque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbCheque.Controls.Add(Me.numMontoCHE)
        Me.gbCheque.Controls.Add(Me.MetroLabel16)
        Me.gbCheque.Controls.Add(Me.dtpFechaGiro)
        Me.gbCheque.Controls.Add(Me.MetroLabel10)
        Me.gbCheque.Controls.Add(Me.txtNumeroCH)
        Me.gbCheque.Controls.Add(Me.MetroLabel35)
        Me.gbCheque.Controls.Add(Me.MetroLabel33)
        Me.gbCheque.Enabled = False
        Me.gbCheque.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbCheque.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCheque.ForeColor = System.Drawing.Color.Black
        Me.gbCheque.Location = New System.Drawing.Point(618, 415)
        Me.gbCheque.Name = "gbCheque"
        Me.gbCheque.Size = New System.Drawing.Size(398, 169)
        Me.gbCheque.TabIndex = 207
        Me.gbCheque.TabStop = False
        Me.gbCheque.Text = "CHEQUE"
        '
        'numMontoCHE
        '
        Me.numMontoCHE.DecimalPlaces = 2
        Me.numMontoCHE.Location = New System.Drawing.Point(143, 124)
        Me.numMontoCHE.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.numMontoCHE.Name = "numMontoCHE"
        Me.numMontoCHE.Size = New System.Drawing.Size(153, 23)
        Me.numMontoCHE.TabIndex = 227
        Me.numMontoCHE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MetroLabel16
        '
        Me.MetroLabel16.AutoSize = True
        Me.MetroLabel16.Location = New System.Drawing.Point(25, 124)
        Me.MetroLabel16.Name = "MetroLabel16"
        Me.MetroLabel16.Size = New System.Drawing.Size(112, 19)
        Me.MetroLabel16.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel16.TabIndex = 226
        Me.MetroLabel16.Text = "MONTO GIRADO"
        Me.MetroLabel16.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel16.UseCustomBackColor = True
        Me.MetroLabel16.UseCustomForeColor = True
        Me.MetroLabel16.UseStyleColors = True
        '
        'dtpFechaGiro
        '
        Me.dtpFechaGiro.Location = New System.Drawing.Point(143, 72)
        Me.dtpFechaGiro.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpFechaGiro.Name = "dtpFechaGiro"
        Me.dtpFechaGiro.Size = New System.Drawing.Size(216, 29)
        Me.dtpFechaGiro.TabIndex = 1
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(22, 78)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel10.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel10.TabIndex = 220
        Me.MetroLabel10.Text = "FECHA DE GIRO"
        Me.MetroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel10.UseCustomBackColor = True
        Me.MetroLabel10.UseCustomForeColor = True
        Me.MetroLabel10.UseStyleColors = True
        '
        'txtNumeroCH
        '
        Me.txtNumeroCH.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNumeroCH.Lines = New String(-1) {}
        Me.txtNumeroCH.Location = New System.Drawing.Point(143, 29)
        Me.txtNumeroCH.MaxLength = 32767
        Me.txtNumeroCH.Name = "txtNumeroCH"
        Me.txtNumeroCH.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumeroCH.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumeroCH.SelectedText = ""
        Me.txtNumeroCH.Size = New System.Drawing.Size(134, 23)
        Me.txtNumeroCH.TabIndex = 0
        Me.txtNumeroCH.UseSelectable = True
        '
        'MetroLabel35
        '
        Me.MetroLabel35.AutoSize = True
        Me.MetroLabel35.Location = New System.Drawing.Point(22, 33)
        Me.MetroLabel35.Name = "MetroLabel35"
        Me.MetroLabel35.Size = New System.Drawing.Size(80, 19)
        Me.MetroLabel35.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel35.TabIndex = 212
        Me.MetroLabel35.Text = "N° CHEQUE"
        Me.MetroLabel35.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel35.UseCustomBackColor = True
        Me.MetroLabel35.UseCustomForeColor = True
        Me.MetroLabel35.UseStyleColors = True
        '
        'MetroLabel33
        '
        Me.MetroLabel33.AutoSize = True
        Me.MetroLabel33.Location = New System.Drawing.Point(520, 43)
        Me.MetroLabel33.Name = "MetroLabel33"
        Me.MetroLabel33.Size = New System.Drawing.Size(35, 19)
        Me.MetroLabel33.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel33.TabIndex = 211
        Me.MetroLabel33.Text = "RUC"
        Me.MetroLabel33.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel33.UseCustomBackColor = True
        Me.MetroLabel33.UseCustomForeColor = True
        Me.MetroLabel33.UseStyleColors = True
        '
        'gbDeposito
        '
        Me.gbDeposito.BackColor = System.Drawing.Color.White
        Me.gbDeposito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbDeposito.Controls.Add(Me.numMontoDEP)
        Me.gbDeposito.Controls.Add(Me.MetroLabel9)
        Me.gbDeposito.Controls.Add(Me.cboBancoDEP)
        Me.gbDeposito.Controls.Add(Me.MetroLabel15)
        Me.gbDeposito.Controls.Add(Me.cboCuentaDEP)
        Me.gbDeposito.Controls.Add(Me.MetroLabel31)
        Me.gbDeposito.Controls.Add(Me.MetroLabel34)
        Me.gbDeposito.Enabled = False
        Me.gbDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbDeposito.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDeposito.ForeColor = System.Drawing.Color.Black
        Me.gbDeposito.Location = New System.Drawing.Point(98, 415)
        Me.gbDeposito.Name = "gbDeposito"
        Me.gbDeposito.Size = New System.Drawing.Size(352, 169)
        Me.gbDeposito.TabIndex = 205
        Me.gbDeposito.TabStop = False
        Me.gbDeposito.Text = "DEPOSITO"
        '
        'numMontoDEP
        '
        Me.numMontoDEP.DecimalPlaces = 2
        Me.numMontoDEP.Location = New System.Drawing.Point(166, 126)
        Me.numMontoDEP.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.numMontoDEP.Name = "numMontoDEP"
        Me.numMontoDEP.Size = New System.Drawing.Size(140, 23)
        Me.numMontoDEP.TabIndex = 225
        Me.numMontoDEP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(18, 128)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(142, 19)
        Me.MetroLabel9.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel9.TabIndex = 224
        Me.MetroLabel9.Text = "MONTO DEPOSITADO"
        Me.MetroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel9.UseCustomBackColor = True
        Me.MetroLabel9.UseCustomForeColor = True
        Me.MetroLabel9.UseStyleColors = True
        '
        'cboBancoDEP
        '
        Me.cboBancoDEP.FormattingEnabled = True
        Me.cboBancoDEP.ItemHeight = 23
        Me.cboBancoDEP.Location = New System.Drawing.Point(108, 27)
        Me.cboBancoDEP.Name = "cboBancoDEP"
        Me.cboBancoDEP.Size = New System.Drawing.Size(198, 29)
        Me.cboBancoDEP.TabIndex = 0
        Me.cboBancoDEP.UseSelectable = True
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(18, 81)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel15.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel15.TabIndex = 222
        Me.MetroLabel15.Text = "N°CUENTA"
        Me.MetroLabel15.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel15.UseCustomBackColor = True
        Me.MetroLabel15.UseCustomForeColor = True
        Me.MetroLabel15.UseStyleColors = True
        '
        'cboCuentaDEP
        '
        Me.cboCuentaDEP.FormattingEnabled = True
        Me.cboCuentaDEP.ItemHeight = 23
        Me.cboCuentaDEP.Location = New System.Drawing.Point(108, 77)
        Me.cboCuentaDEP.Name = "cboCuentaDEP"
        Me.cboCuentaDEP.Size = New System.Drawing.Size(198, 29)
        Me.cboCuentaDEP.TabIndex = 1
        Me.cboCuentaDEP.UseSelectable = True
        '
        'MetroLabel31
        '
        Me.MetroLabel31.AutoSize = True
        Me.MetroLabel31.Location = New System.Drawing.Point(18, 33)
        Me.MetroLabel31.Name = "MetroLabel31"
        Me.MetroLabel31.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel31.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel31.TabIndex = 218
        Me.MetroLabel31.Text = "BANCO"
        Me.MetroLabel31.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel31.UseCustomBackColor = True
        Me.MetroLabel31.UseCustomForeColor = True
        Me.MetroLabel31.UseStyleColors = True
        '
        'MetroLabel34
        '
        Me.MetroLabel34.AutoSize = True
        Me.MetroLabel34.Location = New System.Drawing.Point(520, 43)
        Me.MetroLabel34.Name = "MetroLabel34"
        Me.MetroLabel34.Size = New System.Drawing.Size(35, 19)
        Me.MetroLabel34.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel34.TabIndex = 211
        Me.MetroLabel34.Text = "RUC"
        Me.MetroLabel34.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel34.UseCustomBackColor = True
        Me.MetroLabel34.UseCustomForeColor = True
        Me.MetroLabel34.UseStyleColors = True
        '
        'gbTarjeta
        '
        Me.gbTarjeta.BackColor = System.Drawing.Color.White
        Me.gbTarjeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbTarjeta.Controls.Add(Me.numMontoTAR)
        Me.gbTarjeta.Controls.Add(Me.MetroLabel19)
        Me.gbTarjeta.Controls.Add(Me.cboBancoTAR)
        Me.gbTarjeta.Controls.Add(Me.txtNumTAR2)
        Me.gbTarjeta.Controls.Add(Me.txtNumTAR3)
        Me.gbTarjeta.Controls.Add(Me.txtNumTAR4)
        Me.gbTarjeta.Controls.Add(Me.MetroLabel17)
        Me.gbTarjeta.Controls.Add(Me.txtNumTAR1)
        Me.gbTarjeta.Controls.Add(Me.MetroLabel8)
        Me.gbTarjeta.Controls.Add(Me.cboTarjeta)
        Me.gbTarjeta.Controls.Add(Me.MetroLabel30)
        Me.gbTarjeta.Controls.Add(Me.MetroLabel29)
        Me.gbTarjeta.Enabled = False
        Me.gbTarjeta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbTarjeta.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTarjeta.ForeColor = System.Drawing.Color.Black
        Me.gbTarjeta.Location = New System.Drawing.Point(618, 203)
        Me.gbTarjeta.Name = "gbTarjeta"
        Me.gbTarjeta.Size = New System.Drawing.Size(399, 194)
        Me.gbTarjeta.TabIndex = 204
        Me.gbTarjeta.TabStop = False
        Me.gbTarjeta.Text = "TARJETA"
        '
        'numMontoTAR
        '
        Me.numMontoTAR.DecimalPlaces = 2
        Me.numMontoTAR.Location = New System.Drawing.Point(143, 157)
        Me.numMontoTAR.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.numMontoTAR.Name = "numMontoTAR"
        Me.numMontoTAR.Size = New System.Drawing.Size(216, 23)
        Me.numMontoTAR.TabIndex = 229
        Me.numMontoTAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.Location = New System.Drawing.Point(21, 161)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(116, 19)
        Me.MetroLabel19.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel19.TabIndex = 228
        Me.MetroLabel19.Text = "MONTO PAGADO"
        Me.MetroLabel19.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel19.UseCustomBackColor = True
        Me.MetroLabel19.UseCustomForeColor = True
        Me.MetroLabel19.UseStyleColors = True
        '
        'cboBancoTAR
        '
        Me.cboBancoTAR.FormattingEnabled = True
        Me.cboBancoTAR.ItemHeight = 23
        Me.cboBancoTAR.Location = New System.Drawing.Point(133, 112)
        Me.cboBancoTAR.Name = "cboBancoTAR"
        Me.cboBancoTAR.Size = New System.Drawing.Size(226, 29)
        Me.cboBancoTAR.TabIndex = 6
        Me.cboBancoTAR.UseSelectable = True
        '
        'txtNumTAR2
        '
        Me.txtNumTAR2.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNumTAR2.Lines = New String(-1) {}
        Me.txtNumTAR2.Location = New System.Drawing.Point(195, 21)
        Me.txtNumTAR2.MaxLength = 4
        Me.txtNumTAR2.Name = "txtNumTAR2"
        Me.txtNumTAR2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumTAR2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumTAR2.SelectedText = ""
        Me.txtNumTAR2.Size = New System.Drawing.Size(56, 23)
        Me.txtNumTAR2.TabIndex = 1
        Me.txtNumTAR2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumTAR2.UseSelectable = True
        '
        'txtNumTAR3
        '
        Me.txtNumTAR3.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNumTAR3.Lines = New String(-1) {}
        Me.txtNumTAR3.Location = New System.Drawing.Point(257, 21)
        Me.txtNumTAR3.MaxLength = 4
        Me.txtNumTAR3.Name = "txtNumTAR3"
        Me.txtNumTAR3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumTAR3.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumTAR3.SelectedText = ""
        Me.txtNumTAR3.Size = New System.Drawing.Size(56, 23)
        Me.txtNumTAR3.TabIndex = 2
        Me.txtNumTAR3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumTAR3.UseSelectable = True
        '
        'txtNumTAR4
        '
        Me.txtNumTAR4.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNumTAR4.Lines = New String(-1) {}
        Me.txtNumTAR4.Location = New System.Drawing.Point(319, 21)
        Me.txtNumTAR4.MaxLength = 4
        Me.txtNumTAR4.Name = "txtNumTAR4"
        Me.txtNumTAR4.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumTAR4.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumTAR4.SelectedText = ""
        Me.txtNumTAR4.Size = New System.Drawing.Size(56, 23)
        Me.txtNumTAR4.TabIndex = 3
        Me.txtNumTAR4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumTAR4.UseSelectable = True
        '
        'MetroLabel17
        '
        Me.MetroLabel17.AutoSize = True
        Me.MetroLabel17.Location = New System.Drawing.Point(21, 116)
        Me.MetroLabel17.Name = "MetroLabel17"
        Me.MetroLabel17.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel17.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel17.TabIndex = 224
        Me.MetroLabel17.Text = "BANCO"
        Me.MetroLabel17.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel17.UseCustomBackColor = True
        Me.MetroLabel17.UseCustomForeColor = True
        Me.MetroLabel17.UseStyleColors = True
        '
        'txtNumTAR1
        '
        Me.txtNumTAR1.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtNumTAR1.Lines = New String(-1) {}
        Me.txtNumTAR1.Location = New System.Drawing.Point(133, 21)
        Me.txtNumTAR1.MaxLength = 4
        Me.txtNumTAR1.Name = "txtNumTAR1"
        Me.txtNumTAR1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumTAR1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumTAR1.SelectedText = ""
        Me.txtNumTAR1.Size = New System.Drawing.Size(56, 23)
        Me.txtNumTAR1.TabIndex = 0
        Me.txtNumTAR1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtNumTAR1.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(21, 25)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel8.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel8.TabIndex = 216
        Me.MetroLabel8.Text = "NÚMERO"
        Me.MetroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel8.UseCustomBackColor = True
        Me.MetroLabel8.UseCustomForeColor = True
        Me.MetroLabel8.UseStyleColors = True
        '
        'cboTarjeta
        '
        Me.cboTarjeta.FormattingEnabled = True
        Me.cboTarjeta.ItemHeight = 23
        Me.cboTarjeta.Location = New System.Drawing.Point(133, 64)
        Me.cboTarjeta.Name = "cboTarjeta"
        Me.cboTarjeta.Size = New System.Drawing.Size(226, 29)
        Me.cboTarjeta.TabIndex = 4
        Me.cboTarjeta.UseSelectable = True
        '
        'MetroLabel30
        '
        Me.MetroLabel30.AutoSize = True
        Me.MetroLabel30.Location = New System.Drawing.Point(17, 69)
        Me.MetroLabel30.Name = "MetroLabel30"
        Me.MetroLabel30.Size = New System.Drawing.Size(110, 19)
        Me.MetroLabel30.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel30.TabIndex = 214
        Me.MetroLabel30.Text = "TIPO DE TARJETA"
        Me.MetroLabel30.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel30.UseCustomBackColor = True
        Me.MetroLabel30.UseCustomForeColor = True
        Me.MetroLabel30.UseStyleColors = True
        '
        'MetroLabel29
        '
        Me.MetroLabel29.AutoSize = True
        Me.MetroLabel29.Location = New System.Drawing.Point(520, 43)
        Me.MetroLabel29.Name = "MetroLabel29"
        Me.MetroLabel29.Size = New System.Drawing.Size(35, 19)
        Me.MetroLabel29.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel29.TabIndex = 211
        Me.MetroLabel29.Text = "RUC"
        Me.MetroLabel29.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel29.UseCustomBackColor = True
        Me.MetroLabel29.UseCustomForeColor = True
        Me.MetroLabel29.UseStyleColors = True
        '
        'gbEfectivo
        '
        Me.gbEfectivo.BackColor = System.Drawing.Color.White
        Me.gbEfectivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbEfectivo.Controls.Add(Me.numPagaCon)
        Me.gbEfectivo.Controls.Add(Me.txtVuelto)
        Me.gbEfectivo.Controls.Add(Me.MetroLabel11)
        Me.gbEfectivo.Controls.Add(Me.MetroLabel7)
        Me.gbEfectivo.Controls.Add(Me.MetroLabel27)
        Me.gbEfectivo.Enabled = False
        Me.gbEfectivo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbEfectivo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEfectivo.ForeColor = System.Drawing.Color.Black
        Me.gbEfectivo.Location = New System.Drawing.Point(98, 214)
        Me.gbEfectivo.Name = "gbEfectivo"
        Me.gbEfectivo.Size = New System.Drawing.Size(352, 162)
        Me.gbEfectivo.TabIndex = 200
        Me.gbEfectivo.TabStop = False
        Me.gbEfectivo.Text = "EFECTIVO"
        '
        'numPagaCon
        '
        Me.numPagaCon.DecimalPlaces = 2
        Me.numPagaCon.Location = New System.Drawing.Point(120, 47)
        Me.numPagaCon.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.numPagaCon.Name = "numPagaCon"
        Me.numPagaCon.Size = New System.Drawing.Size(174, 25)
        Me.numPagaCon.TabIndex = 228
        Me.numPagaCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtVuelto
        '
        Me.txtVuelto.Enabled = False
        Me.txtVuelto.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtVuelto.Lines = New String() {"0.00"}
        Me.txtVuelto.Location = New System.Drawing.Point(120, 88)
        Me.txtVuelto.MaxLength = 32767
        Me.txtVuelto.Name = "txtVuelto"
        Me.txtVuelto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVuelto.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtVuelto.SelectedText = ""
        Me.txtVuelto.Size = New System.Drawing.Size(174, 23)
        Me.txtVuelto.TabIndex = 212
        Me.txtVuelto.Text = "0.00"
        Me.txtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtVuelto.UseSelectable = True
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(35, 92)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(55, 19)
        Me.MetroLabel11.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel11.TabIndex = 213
        Me.MetroLabel11.Text = "VUELTO"
        Me.MetroLabel11.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel11.UseCustomBackColor = True
        Me.MetroLabel11.UseCustomForeColor = True
        Me.MetroLabel11.UseStyleColors = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(520, 43)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(35, 19)
        Me.MetroLabel7.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel7.TabIndex = 211
        Me.MetroLabel7.Text = "RUC"
        Me.MetroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel7.UseCustomBackColor = True
        Me.MetroLabel7.UseCustomForeColor = True
        Me.MetroLabel7.UseStyleColors = True
        '
        'MetroLabel27
        '
        Me.MetroLabel27.AutoSize = True
        Me.MetroLabel27.Location = New System.Drawing.Point(35, 47)
        Me.MetroLabel27.Name = "MetroLabel27"
        Me.MetroLabel27.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel27.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel27.TabIndex = 198
        Me.MetroLabel27.Text = "PAGA CON"
        Me.MetroLabel27.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel27.UseCustomBackColor = True
        Me.MetroLabel27.UseCustomForeColor = True
        Me.MetroLabel27.UseStyleColors = True
        '
        'MtxtDescripcion
        '
        Me.MtxtDescripcion.Lines = New String(-1) {}
        Me.MtxtDescripcion.Location = New System.Drawing.Point(121, 19)
        Me.MtxtDescripcion.MaxLength = 32767
        Me.MtxtDescripcion.Name = "MtxtDescripcion"
        Me.MtxtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MtxtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MtxtDescripcion.SelectedText = ""
        Me.MtxtDescripcion.Size = New System.Drawing.Size(98, 23)
        Me.MtxtDescripcion.TabIndex = 3
        Me.MtxtDescripcion.UseSelectable = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(19, 64)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(66, 19)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel5.TabIndex = 32
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel5.UseCustomBackColor = True
        Me.MetroLabel5.UseCustomForeColor = True
        Me.MetroLabel5.UseStyleColors = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(474, 13)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel1.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel1.TabIndex = 37
        Me.MetroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel1.UseCustomBackColor = True
        Me.MetroLabel1.UseCustomForeColor = True
        Me.MetroLabel1.UseStyleColors = True
        '
        'txtMontoFijo
        '
        Me.txtMontoFijo.Lines = New String(-1) {}
        Me.txtMontoFijo.Location = New System.Drawing.Point(90, 160)
        Me.txtMontoFijo.MaxLength = 32767
        Me.txtMontoFijo.Name = "txtMontoFijo"
        Me.txtMontoFijo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontoFijo.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontoFijo.SelectedText = ""
        Me.txtMontoFijo.Size = New System.Drawing.Size(132, 23)
        Me.txtMontoFijo.TabIndex = 38
        Me.txtMontoFijo.UseSelectable = True
        '
        'txtDescuento
        '
        Me.txtDescuento.Lines = New String(-1) {}
        Me.txtDescuento.Location = New System.Drawing.Point(576, 13)
        Me.txtDescuento.MaxLength = 32767
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescuento.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescuento.SelectedText = ""
        Me.txtDescuento.Size = New System.Drawing.Size(132, 23)
        Me.txtDescuento.TabIndex = 40
        Me.txtDescuento.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(474, 53)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(85, 19)
        Me.MetroLabel4.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel4.TabIndex = 42
        Me.MetroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel4.UseCustomBackColor = True
        Me.MetroLabel4.UseCustomForeColor = True
        Me.MetroLabel4.UseStyleColors = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(19, 23)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(77, 19)
        Me.MetroLabel6.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel6.TabIndex = 43
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel6.UseCustomBackColor = True
        Me.MetroLabel6.UseCustomForeColor = True
        Me.MetroLabel6.UseStyleColors = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(483, 95)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(57, 19)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel2.TabIndex = 41
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        Me.MetroLabel2.UseStyleColors = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(239, 23)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(60, 19)
        Me.MetroLabel3.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel3.TabIndex = 44
        Me.MetroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel3.UseCustomBackColor = True
        Me.MetroLabel3.UseCustomForeColor = True
        Me.MetroLabel3.UseStyleColors = True
        '
        'MetroDateTime1
        '
        Me.MetroDateTime1.Location = New System.Drawing.Point(576, 43)
        Me.MetroDateTime1.MinimumSize = New System.Drawing.Size(0, 29)
        Me.MetroDateTime1.Name = "MetroDateTime1"
        Me.MetroDateTime1.Size = New System.Drawing.Size(200, 29)
        Me.MetroDateTime1.TabIndex = 45
        '
        'MetroComboBox1
        '
        Me.MetroComboBox1.FormattingEnabled = True
        Me.MetroComboBox1.ItemHeight = 23
        Me.MetroComboBox1.Location = New System.Drawing.Point(576, 85)
        Me.MetroComboBox1.Name = "MetroComboBox1"
        Me.MetroComboBox1.Size = New System.Drawing.Size(153, 29)
        Me.MetroComboBox1.TabIndex = 46
        Me.MetroComboBox1.UseSelectable = True
        '
        'MetroTextBox1
        '
        Me.MetroTextBox1.Lines = New String(-1) {}
        Me.MetroTextBox1.Location = New System.Drawing.Point(305, 19)
        Me.MetroTextBox1.MaxLength = 32767
        Me.MetroTextBox1.Name = "MetroTextBox1"
        Me.MetroTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox1.SelectedText = ""
        Me.MetroTextBox1.Size = New System.Drawing.Size(98, 23)
        Me.MetroTextBox1.TabIndex = 47
        Me.MetroTextBox1.UseSelectable = True
        '
        'lblMontoAPagar
        '
        Me.lblMontoAPagar.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblMontoAPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMontoAPagar.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblMontoAPagar.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblMontoAPagar.Location = New System.Drawing.Point(376, 119)
        Me.lblMontoAPagar.Name = "lblMontoAPagar"
        Me.lblMontoAPagar.Size = New System.Drawing.Size(159, 30)
        Me.lblMontoAPagar.Style = MetroFramework.MetroColorStyle.Green
        Me.lblMontoAPagar.TabIndex = 231
        Me.lblMontoAPagar.Text = "0.00"
        Me.lblMontoAPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblMontoAPagar.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblMontoAPagar.UseCustomBackColor = True
        Me.lblMontoAPagar.UseCustomForeColor = True
        Me.lblMontoAPagar.UseStyleColors = True
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel12.Location = New System.Drawing.Point(208, 119)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(149, 25)
        Me.MetroLabel12.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel12.TabIndex = 222
        Me.MetroLabel12.Text = "MONTO A PAGAR"
        Me.MetroLabel12.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel12.UseCustomBackColor = True
        Me.MetroLabel12.UseCustomForeColor = True
        Me.MetroLabel12.UseStyleColors = True
        '
        'dtFecha
        '
        Me.dtFecha.Enabled = False
        Me.dtFecha.Location = New System.Drawing.Point(780, 61)
        Me.dtFecha.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(236, 29)
        Me.dtFecha.TabIndex = 215
        '
        'tglEfectivo
        '
        Me.tglEfectivo.AutoSize = True
        Me.tglEfectivo.Location = New System.Drawing.Point(12, 234)
        Me.tglEfectivo.Name = "tglEfectivo"
        Me.tglEfectivo.Size = New System.Drawing.Size(80, 17)
        Me.tglEfectivo.TabIndex = 0
        Me.tglEfectivo.Text = "Off"
        Me.tglEfectivo.UseSelectable = True
        '
        'tglDeposito
        '
        Me.tglDeposito.AutoSize = True
        Me.tglDeposito.Location = New System.Drawing.Point(12, 444)
        Me.tglDeposito.Name = "tglDeposito"
        Me.tglDeposito.Size = New System.Drawing.Size(80, 17)
        Me.tglDeposito.TabIndex = 1
        Me.tglDeposito.Text = "Off"
        Me.tglDeposito.UseSelectable = True
        '
        'tglTarjeta
        '
        Me.tglTarjeta.AutoSize = True
        Me.tglTarjeta.Location = New System.Drawing.Point(532, 234)
        Me.tglTarjeta.Name = "tglTarjeta"
        Me.tglTarjeta.Size = New System.Drawing.Size(80, 17)
        Me.tglTarjeta.TabIndex = 2
        Me.tglTarjeta.Text = "Off"
        Me.tglTarjeta.UseSelectable = True
        '
        'tglCheque
        '
        Me.tglCheque.AutoSize = True
        Me.tglCheque.Location = New System.Drawing.Point(532, 444)
        Me.tglCheque.Name = "tglCheque"
        Me.tglCheque.Size = New System.Drawing.Size(80, 17)
        Me.tglCheque.TabIndex = 3
        Me.tglCheque.Text = "Off"
        Me.tglCheque.UseSelectable = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.btnNuevo)
        Me.Panel3.Controls.Add(Me.btnSalir)
        Me.Panel3.Controls.Add(Me.btnPagar)
        Me.Panel3.Location = New System.Drawing.Point(0, 596)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1037, 80)
        Me.Panel3.TabIndex = 230
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Transparent
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNuevo.Location = New System.Drawing.Point(16, 4)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(71, 72)
        Me.btnNuevo.TabIndex = 160
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNuevo.UseVisualStyleBackColor = False
        Me.btnNuevo.Visible = False
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
        Me.btnSalir.Location = New System.Drawing.Point(956, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(66, 72)
        Me.btnSalir.TabIndex = 159
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnPagar
        '
        Me.btnPagar.BackColor = System.Drawing.Color.Transparent
        Me.btnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnPagar.FlatAppearance.BorderSize = 0
        Me.btnPagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnPagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPagar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.ForeColor = System.Drawing.Color.Transparent
        Me.btnPagar.Image = CType(resources.GetObject("btnPagar.Image"), System.Drawing.Image)
        Me.btnPagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnPagar.Location = New System.Drawing.Point(443, 5)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(173, 72)
        Me.btnPagar.TabIndex = 0
        Me.btnPagar.Text = "Efectuar Pago"
        Me.btnPagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPagar.UseVisualStyleBackColor = False
        '
        'lblMontoPagando
        '
        Me.lblMontoPagando.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lblMontoPagando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMontoPagando.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblMontoPagando.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblMontoPagando.Location = New System.Drawing.Point(857, 119)
        Me.lblMontoPagando.Name = "lblMontoPagando"
        Me.lblMontoPagando.Size = New System.Drawing.Size(159, 30)
        Me.lblMontoPagando.Style = MetroFramework.MetroColorStyle.Green
        Me.lblMontoPagando.TabIndex = 233
        Me.lblMontoPagando.Text = "0.00"
        Me.lblMontoPagando.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblMontoPagando.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblMontoPagando.UseCustomBackColor = True
        Me.lblMontoPagando.UseCustomForeColor = True
        Me.lblMontoPagando.UseStyleColors = True
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.MetroLabel13.Location = New System.Drawing.Point(585, 119)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(266, 25)
        Me.MetroLabel13.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel13.TabIndex = 232
        Me.MetroLabel13.Text = "MONTO QUE SE ESTÁ PAGANDO"
        Me.MetroLabel13.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel13.UseCustomBackColor = True
        Me.MetroLabel13.UseCustomForeColor = True
        Me.MetroLabel13.UseStyleColors = True
        '
        'lblMontoFaltante
        '
        Me.lblMontoFaltante.BackColor = System.Drawing.Color.Gainsboro
        Me.lblMontoFaltante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMontoFaltante.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblMontoFaltante.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblMontoFaltante.Location = New System.Drawing.Point(857, 161)
        Me.lblMontoFaltante.Name = "lblMontoFaltante"
        Me.lblMontoFaltante.Size = New System.Drawing.Size(159, 30)
        Me.lblMontoFaltante.Style = MetroFramework.MetroColorStyle.Green
        Me.lblMontoFaltante.TabIndex = 235
        Me.lblMontoFaltante.Text = "0.00"
        Me.lblMontoFaltante.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblMontoFaltante.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblMontoFaltante.UseCustomBackColor = True
        Me.lblMontoFaltante.UseCustomForeColor = True
        Me.lblMontoFaltante.UseStyleColors = True
        '
        'lblMontoF
        '
        Me.lblMontoF.AutoSize = True
        Me.lblMontoF.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblMontoF.Location = New System.Drawing.Point(698, 161)
        Me.lblMontoF.Name = "lblMontoF"
        Me.lblMontoF.Size = New System.Drawing.Size(153, 25)
        Me.lblMontoF.Style = MetroFramework.MetroColorStyle.Green
        Me.lblMontoF.TabIndex = 234
        Me.lblMontoF.Text = "MONTO FALTANTE"
        Me.lblMontoF.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.lblMontoF.UseCustomBackColor = True
        Me.lblMontoF.UseCustomForeColor = True
        Me.lblMontoF.UseStyleColors = True
        '
        'frmRegistroPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 676)
        Me.Controls.Add(Me.lblMontoFaltante)
        Me.Controls.Add(Me.lblMontoF)
        Me.Controls.Add(Me.lblMontoPagando)
        Me.Controls.Add(Me.MetroLabel13)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.tglCheque)
        Me.Controls.Add(Me.lblMontoAPagar)
        Me.Controls.Add(Me.tglTarjeta)
        Me.Controls.Add(Me.MetroLabel12)
        Me.Controls.Add(Me.gbCheque)
        Me.Controls.Add(Me.tglDeposito)
        Me.Controls.Add(Me.tglEfectivo)
        Me.Controls.Add(Me.gbTarjeta)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.gbDeposito)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.MetroTile2)
        Me.Controls.Add(Me.gbEfectivo)
        Me.Name = "frmRegistroPagos"
        Me.MetroTile2.ResumeLayout(False)
        Me.MetroTile2.PerformLayout()
        Me.gbCheque.ResumeLayout(False)
        Me.gbCheque.PerformLayout()
        CType(Me.numMontoCHE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDeposito.ResumeLayout(False)
        Me.gbDeposito.PerformLayout()
        CType(Me.numMontoDEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTarjeta.ResumeLayout(False)
        Me.gbTarjeta.PerformLayout()
        CType(Me.numMontoTAR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEfectivo.ResumeLayout(False)
        Me.gbEfectivo.PerformLayout()
        CType(Me.numPagaCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents gbCheque As System.Windows.Forms.GroupBox
    Friend WithEvents txtNumeroCH As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel35 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel33 As MetroFramework.Controls.MetroLabel
    Friend WithEvents gbDeposito As System.Windows.Forms.GroupBox
    Friend WithEvents MetroLabel34 As MetroFramework.Controls.MetroLabel
    Friend WithEvents gbTarjeta As System.Windows.Forms.GroupBox
    Friend WithEvents cboTarjeta As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel30 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel29 As MetroFramework.Controls.MetroLabel
    Friend WithEvents gbEfectivo As System.Windows.Forms.GroupBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel27 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MtxtDescripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtMontoFijo As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtDescuento As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroDateTime1 As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroComboBox1 As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroTextBox1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dtFecha As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtpFechaGiro As MetroFramework.Controls.MetroDateTime
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNumTAR1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboCuentaDEP As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel31 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel17 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tglEfectivo As MetroFramework.Controls.MetroToggle
    Friend WithEvents tglDeposito As MetroFramework.Controls.MetroToggle
    Friend WithEvents tglTarjeta As MetroFramework.Controls.MetroToggle
    Friend WithEvents tglCheque As MetroFramework.Controls.MetroToggle
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnPagar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents lblMontoAPagar As MetroFramework.Controls.MetroLabel
    Friend WithEvents cboBancoDEP As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtNumTAR2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNumTAR3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtNumTAR4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents cboBancoTAR As MetroFramework.Controls.MetroComboBox
    Friend WithEvents txtVuelto As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblMontoPagando As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblMontoFaltante As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblMontoF As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel16 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents numMontoCHE As System.Windows.Forms.NumericUpDown
    Friend WithEvents numMontoDEP As System.Windows.Forms.NumericUpDown
    Friend WithEvents numMontoTAR As System.Windows.Forms.NumericUpDown
    Friend WithEvents numPagaCon As System.Windows.Forms.NumericUpDown
End Class
