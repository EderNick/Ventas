<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDetalleSucursal

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDetalleSucursal))
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbModelo = New MetroFramework.Controls.MetroComboBox()
        Me.cmbSucursal = New MetroFramework.Controls.MetroComboBox()
        Me.txtPrecio = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl2 = New MetroFramework.Controls.MetroTabControl()
        Me.tblistado = New MetroFramework.Controls.MetroTabPage()
        Me.txtBdetalle = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroRadioButton4 = New MetroFramework.Controls.MetroRadioButton()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.MetroTabControl1.SuspendLayout()
        Me.MetroTabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MetroTabControl2.SuspendLayout()
        Me.tblistado.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.Button6.Size = New System.Drawing.Size(210, 57)
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
        Me.MetroTile2.Size = New System.Drawing.Size(1028, 64)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTile2.TabIndex = 162
        Me.MetroTile2.Text = "DETALLE SUCURSAL"
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
        Me.MetroTabControl1.Location = New System.Drawing.Point(11, 71)
        Me.MetroTabControl1.Multiline = True
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(469, 245)
        Me.MetroTabControl1.TabIndex = 168
        Me.MetroTabControl1.UseSelectable = True
        '
        'MetroTabPage1
        '
        Me.MetroTabPage1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.MetroTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroTabPage1.Controls.Add(Me.GroupBox2)
        Me.MetroTabPage1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.MetroTabPage1.HorizontalScrollbarBarColor = True
        Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.HorizontalScrollbarSize = 10
        Me.MetroTabPage1.Location = New System.Drawing.Point(4, 41)
        Me.MetroTabPage1.Name = "MetroTabPage1"
        Me.MetroTabPage1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MetroTabPage1.Size = New System.Drawing.Size(461, 200)
        Me.MetroTabPage1.TabIndex = 0
        Me.MetroTabPage1.Text = "DATOS"
        Me.MetroTabPage1.VerticalScrollbarBarColor = True
        Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroTabPage1.VerticalScrollbarSize = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.cmbModelo)
        Me.GroupBox2.Controls.Add(Me.cmbSucursal)
        Me.GroupBox2.Controls.Add(Me.txtPrecio)
        Me.GroupBox2.Controls.Add(Me.MetroLabel2)
        Me.GroupBox2.Controls.Add(Me.MetroLabel5)
        Me.GroupBox2.Controls.Add(Me.MetroLabel6)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Century Schoolbook", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(49, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(345, 148)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        '
        'cmbModelo
        '
        Me.cmbModelo.FormattingEnabled = True
        Me.cmbModelo.ItemHeight = 23
        Me.cmbModelo.Location = New System.Drawing.Point(126, 65)
        Me.cmbModelo.Name = "cmbModelo"
        Me.cmbModelo.Size = New System.Drawing.Size(141, 29)
        Me.cmbModelo.TabIndex = 208
        Me.cmbModelo.UseSelectable = True
        '
        'cmbSucursal
        '
        Me.cmbSucursal.FormattingEnabled = True
        Me.cmbSucursal.ItemHeight = 23
        Me.cmbSucursal.Location = New System.Drawing.Point(125, 28)
        Me.cmbSucursal.Name = "cmbSucursal"
        Me.cmbSucursal.Size = New System.Drawing.Size(141, 29)
        Me.cmbSucursal.TabIndex = 207
        Me.cmbSucursal.UseSelectable = True
        '
        'txtPrecio
        '
        Me.txtPrecio.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtPrecio.Lines = New String(-1) {}
        Me.txtPrecio.Location = New System.Drawing.Point(165, 102)
        Me.txtPrecio.MaxLength = 32767
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrecio.SelectedText = ""
        Me.txtPrecio.Size = New System.Drawing.Size(99, 23)
        Me.txtPrecio.TabIndex = 37
        Me.txtPrecio.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(19, 71)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel2.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel2.TabIndex = 34
        Me.MetroLabel2.Text = "MODELO"
        Me.MetroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel2.UseCustomBackColor = True
        Me.MetroLabel2.UseCustomForeColor = True
        Me.MetroLabel2.UseStyleColors = True
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(19, 30)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel5.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel5.TabIndex = 32
        Me.MetroLabel5.Text = "SUCURSAL"
        Me.MetroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel5.UseCustomBackColor = True
        Me.MetroLabel5.UseCustomForeColor = True
        Me.MetroLabel5.UseStyleColors = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(19, 109)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(98, 19)
        Me.MetroLabel6.Style = MetroFramework.MetroColorStyle.Green
        Me.MetroLabel6.TabIndex = 19
        Me.MetroLabel6.Text = "PRECIO VENTA"
        Me.MetroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.MetroLabel6.UseCustomBackColor = True
        Me.MetroLabel6.UseCustomForeColor = True
        Me.MetroLabel6.UseStyleColors = True
        '
        'MetroTabControl2
        '
        Me.MetroTabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MetroTabControl2.Controls.Add(Me.tblistado)
        Me.MetroTabControl2.Location = New System.Drawing.Point(513, 71)
        Me.MetroTabControl2.Multiline = True
        Me.MetroTabControl2.Name = "MetroTabControl2"
        Me.MetroTabControl2.SelectedIndex = 0
        Me.MetroTabControl2.Size = New System.Drawing.Size(479, 269)
        Me.MetroTabControl2.TabIndex = 169
        Me.MetroTabControl2.UseSelectable = True
        '
        'tblistado
        '
        Me.tblistado.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.tblistado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tblistado.Controls.Add(Me.txtBdetalle)
        Me.tblistado.Controls.Add(Me.MetroLabel10)
        Me.tblistado.Controls.Add(Me.MetroRadioButton4)
        Me.tblistado.Controls.Add(Me.btnBuscar)
        Me.tblistado.Controls.Add(Me.dgvDetalle)
        Me.tblistado.ForeColor = System.Drawing.Color.DodgerBlue
        Me.tblistado.HorizontalScrollbarBarColor = True
        Me.tblistado.HorizontalScrollbarHighlightOnWheel = True
        Me.tblistado.HorizontalScrollbarSize = 10
        Me.tblistado.Location = New System.Drawing.Point(4, 41)
        Me.tblistado.Name = "tblistado"
        Me.tblistado.Size = New System.Drawing.Size(471, 224)
        Me.tblistado.TabIndex = 0
        Me.tblistado.Text = "LISTA DETALLE SUCURSAL MODELO"
        Me.tblistado.Theme = MetroFramework.MetroThemeStyle.Light
        Me.tblistado.VerticalScrollbarBarColor = True
        Me.tblistado.VerticalScrollbarHighlightOnWheel = False
        Me.tblistado.VerticalScrollbarSize = 10
        '
        'txtBdetalle
        '
        Me.txtBdetalle.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtBdetalle.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtBdetalle.Lines = New String(-1) {}
        Me.txtBdetalle.Location = New System.Drawing.Point(141, 37)
        Me.txtBdetalle.MaxLength = 32767
        Me.txtBdetalle.Name = "txtBdetalle"
        Me.txtBdetalle.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBdetalle.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBdetalle.SelectedText = ""
        Me.txtBdetalle.Size = New System.Drawing.Size(194, 23)
        Me.txtBdetalle.TabIndex = 160
        Me.txtBdetalle.UseSelectable = True
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
        'MetroRadioButton4
        '
        Me.MetroRadioButton4.AutoSize = True
        Me.MetroRadioButton4.Location = New System.Drawing.Point(134, 13)
        Me.MetroRadioButton4.Name = "MetroRadioButton4"
        Me.MetroRadioButton4.Size = New System.Drawing.Size(80, 15)
        Me.MetroRadioButton4.TabIndex = 158
        Me.MetroRadioButton4.Text = "SUCURSAL"
        Me.MetroRadioButton4.UseSelectable = True
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
        Me.btnBuscar.Location = New System.Drawing.Point(372, 28)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(37, 32)
        Me.btnBuscar.TabIndex = 161
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'dgvDetalle
        '
        Me.dgvDetalle.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column1, Me.precio})
        Me.dgvDetalle.Location = New System.Drawing.Point(9, 65)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.Size = New System.Drawing.Size(466, 137)
        Me.dgvDetalle.TabIndex = 162
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "NomSucursal"
        Me.Column2.HeaderText = "SUCURSAL"
        Me.Column2.Name = "Column2"
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "NomModelo"
        Me.Column1.HeaderText = "MODELO"
        Me.Column1.Name = "Column1"
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'precio
        '
        Me.precio.DataPropertyName = "precio"
        Me.precio.HeaderText = "PRECIO VENTA"
        Me.precio.Name = "precio"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnSalir)
        Me.Panel1.Controls.Add(Me.btnNuevo)
        Me.Panel1.Controls.Add(Me.btnModificar)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Location = New System.Drawing.Point(0, 365)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1015, 52)
        Me.Panel1.TabIndex = 175
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.BackgroundImage = CType(resources.GetObject("btnSalir.BackgroundImage"), System.Drawing.Image)
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(934, 0)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(51, 52)
        Me.btnSalir.TabIndex = 90
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.BackColor = System.Drawing.Color.Black
        Me.btnNuevo.BackgroundImage = CType(resources.GetObject("btnNuevo.BackgroundImage"), System.Drawing.Image)
        Me.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnNuevo.FlatAppearance.BorderSize = 0
        Me.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnNuevo.ForeColor = System.Drawing.Color.White
        Me.btnNuevo.Location = New System.Drawing.Point(17, 0)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(57, 52)
        Me.btnNuevo.TabIndex = 92
        Me.btnNuevo.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.Transparent
        Me.btnModificar.BackgroundImage = CType(resources.GetObject("btnModificar.BackgroundImage"), System.Drawing.Image)
        Me.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnModificar.ForeColor = System.Drawing.Color.White
        Me.btnModificar.Location = New System.Drawing.Point(98, 0)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(71, 52)
        Me.btnModificar.TabIndex = 77
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BackgroundImage = CType(resources.GetObject("btnGuardar.BackgroundImage"), System.Drawing.Image)
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Location = New System.Drawing.Point(188, 0)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(59, 52)
        Me.btnGuardar.TabIndex = 148
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'frmDetalleSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 423)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroTabControl2)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.MetroTile2)
        Me.Name = "frmDetalleSucursal"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.MetroTabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MetroTabControl2.ResumeLayout(False)
        Me.tblistado.ResumeLayout(False)
        Me.tblistado.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPrecio As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTabControl2 As MetroFramework.Controls.MetroTabControl
    Private WithEvents tblistado As MetroFramework.Controls.MetroTabPage
    Friend WithEvents dgvDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtBdetalle As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroRadioButton4 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents cmbModelo As MetroFramework.Controls.MetroComboBox
    Friend WithEvents cmbSucursal As MetroFramework.Controls.MetroComboBox
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents precio As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
