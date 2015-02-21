<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBuscarEmpleado))
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTabControl2 = New MetroFramework.Controls.MetroTabControl()
        Me.gbListado = New MetroFramework.Controls.MetroTabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtEmpleado = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MetroTabControl2.SuspendLayout()
        Me.gbListado.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.AutoSize = True
        Me.Button6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Location = New System.Drawing.Point(0, -1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(85, 64)
        Me.Button6.TabIndex = 165
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
        Me.MetroTile2.Location = New System.Drawing.Point(0, -1)
        Me.MetroTile2.Name = "MetroTile2"
        Me.MetroTile2.Size = New System.Drawing.Size(786, 64)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTile2.TabIndex = 164
        Me.MetroTile2.Text = "BUSCAR EMPLEADO"
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
        'MetroTabControl2
        '
        Me.MetroTabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.MetroTabControl2.Controls.Add(Me.gbListado)
        Me.MetroTabControl2.Location = New System.Drawing.Point(0, 69)
        Me.MetroTabControl2.Multiline = True
        Me.MetroTabControl2.Name = "MetroTabControl2"
        Me.MetroTabControl2.SelectedIndex = 0
        Me.MetroTabControl2.Size = New System.Drawing.Size(786, 357)
        Me.MetroTabControl2.TabIndex = 171
        Me.MetroTabControl2.UseSelectable = True
        '
        'gbListado
        '
        Me.gbListado.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.gbListado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.gbListado.Controls.Add(Me.Panel1)
        Me.gbListado.Controls.Add(Me.dgvEmpleados)
        Me.gbListado.Controls.Add(Me.btnBuscar)
        Me.gbListado.Controls.Add(Me.txtEmpleado)
        Me.gbListado.Controls.Add(Me.MetroLabel1)
        Me.gbListado.ForeColor = System.Drawing.Color.DodgerBlue
        Me.gbListado.HorizontalScrollbarBarColor = True
        Me.gbListado.HorizontalScrollbarHighlightOnWheel = True
        Me.gbListado.HorizontalScrollbarSize = 10
        Me.gbListado.Location = New System.Drawing.Point(4, 41)
        Me.gbListado.Name = "gbListado"
        Me.gbListado.Size = New System.Drawing.Size(778, 312)
        Me.gbListado.TabIndex = 0
        Me.gbListado.Text = "LISTA EMPLEADOS"
        Me.gbListado.Theme = MetroFramework.MetroThemeStyle.Light
        Me.gbListado.VerticalScrollbarBarColor = True
        Me.gbListado.VerticalScrollbarHighlightOnWheel = False
        Me.gbListado.VerticalScrollbarSize = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnSeleccionar)
        Me.Panel1.Location = New System.Drawing.Point(8, 246)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(757, 68)
        Me.Panel1.TabIndex = 175
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
        Me.btnCancelar.Location = New System.Drawing.Point(677, -2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 72)
        Me.btnCancelar.TabIndex = 150
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.BackColor = System.Drawing.Color.Transparent
        Me.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSeleccionar.FlatAppearance.BorderSize = 0
        Me.btnSeleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.ForeColor = System.Drawing.Color.White
        Me.btnSeleccionar.Image = CType(resources.GetObject("btnSeleccionar.Image"), System.Drawing.Image)
        Me.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSeleccionar.Location = New System.Drawing.Point(583, -1)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(88, 72)
        Me.btnSeleccionar.TabIndex = 149
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSeleccionar.UseVisualStyleBackColor = False
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.BackgroundColor = System.Drawing.Color.Gray
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Cargo, Me.Dni, Me.Direccion, Me.Telefono, Me.Celular, Me.Correo})
        Me.dgvEmpleados.Location = New System.Drawing.Point(8, 53)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.Size = New System.Drawing.Size(757, 188)
        Me.dgvEmpleados.TabIndex = 162
        '
        'btnBuscar
        '
        Me.btnBuscar.BackColor = System.Drawing.Color.Transparent
        Me.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.Black
        Me.btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), System.Drawing.Image)
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(439, -1)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(59, 51)
        Me.btnBuscar.TabIndex = 161
        Me.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        'txtEmpleado
        '
        Me.txtEmpleado.BackColor = System.Drawing.Color.DodgerBlue
        Me.txtEmpleado.ForeColor = System.Drawing.Color.DodgerBlue
        Me.txtEmpleado.Lines = New String(-1) {}
        Me.txtEmpleado.Location = New System.Drawing.Point(143, 13)
        Me.txtEmpleado.MaxLength = 32767
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmpleado.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtEmpleado.SelectedText = ""
        Me.txtEmpleado.Size = New System.Drawing.Size(285, 23)
        Me.txtEmpleado.TabIndex = 160
        Me.txtEmpleado.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.ForeColor = System.Drawing.Color.Black
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 13)
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
        'Column3
        '
        Me.Column3.DataPropertyName = "NombreEmpleado"
        Me.Column3.HeaderText = "EMPLEADO"
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
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
        'frmBuscarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 440)
        Me.Controls.Add(Me.MetroTabControl2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.MetroTile2)
        Me.Name = "frmBuscarEmpleado"
        Me.MetroTabControl2.ResumeLayout(False)
        Me.gbListado.ResumeLayout(False)
        Me.gbListado.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTabControl2 As MetroFramework.Controls.MetroTabControl
    Private WithEvents gbListado As MetroFramework.Controls.MetroTabPage
    Friend WithEvents dgvEmpleados As System.Windows.Forms.DataGridView
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtEmpleado As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cargo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dni As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Celular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Correo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
