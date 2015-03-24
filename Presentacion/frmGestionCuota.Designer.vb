<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGestionCuota
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGestionCuota))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvcuota = New System.Windows.Forms.DataGridView()
        Me.cuota = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.monto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iddocumentoventa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnpagar = New System.Windows.Forms.Button()
        Me.gbdatos = New System.Windows.Forms.GroupBox()
        Me.txtDNIRUC = New MetroFramework.Controls.MetroTextBox()
        Me.lbltipo = New MetroFramework.Controls.MetroLabel()
        Me.txtnombre = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtBuscar = New MetroFramework.Controls.MetroTextBox()
        Me.rbDNI = New System.Windows.Forms.RadioButton()
        Me.rbRUC = New System.Windows.Forms.RadioButton()
        Me.btnbusqueda = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvcuota, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.gbdatos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox3.Controls.Add(Me.dgvcuota)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(17, 234)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(679, 215)
        Me.GroupBox3.TabIndex = 230
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DETALLE CUOTAS"
        '
        'dgvcuota
        '
        Me.dgvcuota.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvcuota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcuota.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuota, Me.fecha, Me.monto, Me.estado, Me.iddocumentoventa})
        Me.dgvcuota.Location = New System.Drawing.Point(14, 33)
        Me.dgvcuota.Name = "dgvcuota"
        Me.dgvcuota.Size = New System.Drawing.Size(645, 161)
        Me.dgvcuota.TabIndex = 163
        '
        'cuota
        '
        Me.cuota.DataPropertyName = "numerocuota"
        Me.cuota.HeaderText = "NROCUOTA"
        Me.cuota.Name = "cuota"
        Me.cuota.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "fecha"
        Me.fecha.HeaderText = "FECHACOBRANZA"
        Me.fecha.Name = "fecha"
        Me.fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.fecha.Width = 150
        '
        'monto
        '
        Me.monto.DataPropertyName = "monto"
        Me.monto.HeaderText = "MONTO"
        Me.monto.Name = "monto"
        '
        'estado
        '
        Me.estado.DataPropertyName = "estadodeuda"
        Me.estado.HeaderText = "ESTADO"
        Me.estado.Name = "estado"
        Me.estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.estado.Width = 150
        '
        'iddocumentoventa
        '
        Me.iddocumentoventa.DataPropertyName = "codigodocumento"
        Me.iddocumentoventa.HeaderText = "DOCUMENTOVENTA"
        Me.iddocumentoventa.Name = "iddocumentoventa"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.btnlimpiar)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.btnSalir)
        Me.Panel3.Location = New System.Drawing.Point(2, 455)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(807, 86)
        Me.Panel3.TabIndex = 229
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.Color.Transparent
        Me.btnlimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnlimpiar.FlatAppearance.BorderSize = 0
        Me.btnlimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnlimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpiar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.ForeColor = System.Drawing.Color.White
        Me.btnlimpiar.Image = CType(resources.GetObject("btnlimpiar.Image"), System.Drawing.Image)
        Me.btnlimpiar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnlimpiar.Location = New System.Drawing.Point(104, 6)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(76, 72)
        Me.btnlimpiar.TabIndex = 1
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(3, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(74, 72)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "Exportar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(623, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 72)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Imprimir"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
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
        Me.btnSalir.Location = New System.Drawing.Point(724, 9)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(64, 69)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnpagar
        '
        Me.btnpagar.BackColor = System.Drawing.Color.Transparent
        Me.btnpagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnpagar.FlatAppearance.BorderSize = 0
        Me.btnpagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnpagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnpagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpagar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpagar.ForeColor = System.Drawing.Color.Black
        Me.btnpagar.Image = CType(resources.GetObject("btnpagar.Image"), System.Drawing.Image)
        Me.btnpagar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnpagar.Location = New System.Drawing.Point(726, 267)
        Me.btnpagar.Name = "btnpagar"
        Me.btnpagar.Size = New System.Drawing.Size(64, 72)
        Me.btnpagar.TabIndex = 0
        Me.btnpagar.Text = "PAGO"
        Me.btnpagar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnpagar.UseVisualStyleBackColor = False
        '
        'gbdatos
        '
        Me.gbdatos.BackColor = System.Drawing.Color.White
        Me.gbdatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.gbdatos.Controls.Add(Me.txtDNIRUC)
        Me.gbdatos.Controls.Add(Me.lbltipo)
        Me.gbdatos.Controls.Add(Me.txtnombre)
        Me.gbdatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbdatos.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbdatos.ForeColor = System.Drawing.Color.Black
        Me.gbdatos.Location = New System.Drawing.Point(17, 172)
        Me.gbdatos.Name = "gbdatos"
        Me.gbdatos.Size = New System.Drawing.Size(679, 56)
        Me.gbdatos.TabIndex = 227
        Me.gbdatos.TabStop = False
        Me.gbdatos.Text = "CLIENTE"
        '
        'txtDNIRUC
        '
        Me.txtDNIRUC.BackColor = System.Drawing.Color.White
        Me.txtDNIRUC.Enabled = False
        Me.txtDNIRUC.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtDNIRUC.Lines = New String(-1) {}
        Me.txtDNIRUC.Location = New System.Drawing.Point(461, 24)
        Me.txtDNIRUC.MaxLength = 32767
        Me.txtDNIRUC.Name = "txtDNIRUC"
        Me.txtDNIRUC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDNIRUC.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDNIRUC.SelectedText = ""
        Me.txtDNIRUC.Size = New System.Drawing.Size(212, 23)
        Me.txtDNIRUC.TabIndex = 206
        Me.txtDNIRUC.UseCustomBackColor = True
        Me.txtDNIRUC.UseSelectable = True
        '
        'lbltipo
        '
        Me.lbltipo.AutoSize = True
        Me.lbltipo.Location = New System.Drawing.Point(425, 24)
        Me.lbltipo.Name = "lbltipo"
        Me.lbltipo.Size = New System.Drawing.Size(31, 19)
        Me.lbltipo.TabIndex = 205
        Me.lbltipo.Text = "DNI"
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.White
        Me.txtnombre.Enabled = False
        Me.txtnombre.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtnombre.Lines = New String(-1) {}
        Me.txtnombre.Location = New System.Drawing.Point(10, 24)
        Me.txtnombre.MaxLength = 32767
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtnombre.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtnombre.SelectedText = ""
        Me.txtnombre.Size = New System.Drawing.Size(403, 23)
        Me.txtnombre.TabIndex = 198
        Me.txtnombre.UseCustomBackColor = True
        Me.txtnombre.UseSelectable = True
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
        Me.MetroTile2.Size = New System.Drawing.Size(809, 97)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTile2.TabIndex = 226
        Me.MetroTile2.Text = "CUOTAS"
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
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(71, 4)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(111, 94)
        Me.Button6.TabIndex = 232
        Me.Button6.UseCompatibleTextRendering = True
        Me.Button6.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.BackColor = System.Drawing.Color.White
        Me.txtBuscar.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtBuscar.Lines = New String(-1) {}
        Me.txtBuscar.Location = New System.Drawing.Point(173, 18)
        Me.txtBuscar.MaxLength = 32767
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscar.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBuscar.SelectedText = ""
        Me.txtBuscar.Size = New System.Drawing.Size(337, 23)
        Me.txtBuscar.TabIndex = 2
        Me.txtBuscar.UseCustomBackColor = True
        Me.txtBuscar.UseSelectable = True
        '
        'rbDNI
        '
        Me.rbDNI.AutoSize = True
        Me.rbDNI.Location = New System.Drawing.Point(14, 21)
        Me.rbDNI.Name = "rbDNI"
        Me.rbDNI.Size = New System.Drawing.Size(48, 21)
        Me.rbDNI.TabIndex = 0
        Me.rbDNI.TabStop = True
        Me.rbDNI.Text = "DNI"
        Me.rbDNI.UseVisualStyleBackColor = True
        '
        'rbRUC
        '
        Me.rbRUC.AutoSize = True
        Me.rbRUC.Location = New System.Drawing.Point(91, 20)
        Me.rbRUC.Name = "rbRUC"
        Me.rbRUC.Size = New System.Drawing.Size(51, 21)
        Me.rbRUC.TabIndex = 1
        Me.rbRUC.TabStop = True
        Me.rbRUC.Text = "RUC"
        Me.rbRUC.UseVisualStyleBackColor = True
        '
        'btnbusqueda
        '
        Me.btnbusqueda.BackColor = System.Drawing.Color.Transparent
        Me.btnbusqueda.BackgroundImage = CType(resources.GetObject("btnbusqueda.BackgroundImage"), System.Drawing.Image)
        Me.btnbusqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnbusqueda.FlatAppearance.BorderSize = 0
        Me.btnbusqueda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnbusqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnbusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbusqueda.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnbusqueda.ForeColor = System.Drawing.Color.White
        Me.btnbusqueda.Location = New System.Drawing.Point(531, 11)
        Me.btnbusqueda.Name = "btnbusqueda"
        Me.btnbusqueda.Size = New System.Drawing.Size(37, 32)
        Me.btnbusqueda.TabIndex = 3
        Me.btnbusqueda.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.rbDNI)
        Me.GroupBox2.Controls.Add(Me.btnbusqueda)
        Me.GroupBox2.Controls.Add(Me.rbRUC)
        Me.GroupBox2.Controls.Add(Me.txtBuscar)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(17, 111)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(585, 49)
        Me.GroupBox2.TabIndex = 235
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "BUSCAR"
        '
        'frmGestionCuota
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(801, 539)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnpagar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.gbdatos)
        Me.Controls.Add(Me.MetroTile2)
        Me.Name = "frmGestionCuota"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvcuota, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.gbdatos.ResumeLayout(False)
        Me.gbdatos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnpagar As System.Windows.Forms.Button
    Friend WithEvents gbdatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtnombre As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtDNIRUC As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lbltipo As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnlimpiar As System.Windows.Forms.Button
    Public WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As MetroFramework.Controls.MetroTextBox
    Friend WithEvents rbDNI As System.Windows.Forms.RadioButton
    Friend WithEvents rbRUC As System.Windows.Forms.RadioButton
    Friend WithEvents btnbusqueda As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvcuota As System.Windows.Forms.DataGridView
    Friend WithEvents cuota As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents monto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents iddocumentoventa As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
