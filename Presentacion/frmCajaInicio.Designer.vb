<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCajaInicio

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCajaInicio))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.MetroTile2 = New MetroFramework.Controls.MetroTile()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tabIniciar = New MetroFramework.Controls.MetroTabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCancelarInicio = New System.Windows.Forms.Button()
        Me.btnGuardarInicio = New System.Windows.Forms.Button()
        Me.gbCaja = New System.Windows.Forms.GroupBox()
        Me.txtMontoApertura = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtDescripcion = New MetroFramework.Controls.MetroTextBox()
        Me.txtNumero = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox3 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox4 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox2 = New MetroFramework.Controls.MetroTextBox()
        Me.dgbCaja = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.MetroTabControl1.SuspendLayout()
        Me.tabIniciar.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.gbCaja.SuspendLayout()
        CType(Me.dgbCaja, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Button6.Size = New System.Drawing.Size(87, 57)
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
        Me.MetroTile2.Size = New System.Drawing.Size(516, 64)
        Me.MetroTile2.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTile2.TabIndex = 158
        Me.MetroTile2.Text = "INICIO DE CAJA"
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
        Me.MetroTabControl1.Controls.Add(Me.tabIniciar)
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 71)
        Me.MetroTabControl1.Multiline = True
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(516, 283)
        Me.MetroTabControl1.TabIndex = 0
        Me.MetroTabControl1.UseSelectable = True
        '
        'tabIniciar
        '
        Me.tabIniciar.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.tabIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.tabIniciar.Controls.Add(Me.Panel2)
        Me.tabIniciar.Controls.Add(Me.gbCaja)
        Me.tabIniciar.ForeColor = System.Drawing.Color.DodgerBlue
        Me.tabIniciar.HorizontalScrollbarBarColor = True
        Me.tabIniciar.HorizontalScrollbarHighlightOnWheel = False
        Me.tabIniciar.HorizontalScrollbarSize = 10
        Me.tabIniciar.Location = New System.Drawing.Point(4, 41)
        Me.tabIniciar.Name = "tabIniciar"
        Me.tabIniciar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabIniciar.Size = New System.Drawing.Size(508, 238)
        Me.tabIniciar.TabIndex = 0
        Me.tabIniciar.Text = "Iniciar Caja"
        Me.tabIniciar.VerticalScrollbarBarColor = True
        Me.tabIniciar.VerticalScrollbarHighlightOnWheel = False
        Me.tabIniciar.VerticalScrollbarSize = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.btnCancelarInicio)
        Me.Panel2.Controls.Add(Me.btnGuardarInicio)
        Me.Panel2.Location = New System.Drawing.Point(3, 169)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 68)
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
        Me.btnCancelarInicio.Location = New System.Drawing.Point(425, -2)
        Me.btnCancelarInicio.Name = "btnCancelarInicio"
        Me.btnCancelarInicio.Size = New System.Drawing.Size(72, 72)
        Me.btnCancelarInicio.TabIndex = 1
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
        Me.btnGuardarInicio.TabIndex = 0
        Me.btnGuardarInicio.Text = "Guardar Inicio de Caja"
        Me.btnGuardarInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnGuardarInicio.UseVisualStyleBackColor = False
        '
        'gbCaja
        '
        Me.gbCaja.BackColor = System.Drawing.Color.White
        Me.gbCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.gbCaja.Size = New System.Drawing.Size(500, 160)
        Me.gbCaja.TabIndex = 85
        Me.gbCaja.TabStop = False
        '
        'txtMontoApertura
        '
        Me.txtMontoApertura.Lines = New String(-1) {}
        Me.txtMontoApertura.Location = New System.Drawing.Point(161, 70)
        Me.txtMontoApertura.MaxLength = 32767
        Me.txtMontoApertura.Name = "txtMontoApertura"
        Me.txtMontoApertura.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMontoApertura.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMontoApertura.SelectedText = ""
        Me.txtMontoApertura.Size = New System.Drawing.Size(137, 23)
        Me.txtMontoApertura.TabIndex = 1
        Me.txtMontoApertura.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(27, 70)
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
        Me.MetroLabel2.Location = New System.Drawing.Point(27, 113)
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
        Me.MetroLabel6.Location = New System.Drawing.Point(27, 25)
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
        Me.txtDescripcion.Location = New System.Drawing.Point(161, 113)
        Me.txtDescripcion.MaxLength = 25
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDescripcion.SelectedText = ""
        Me.txtDescripcion.Size = New System.Drawing.Size(320, 23)
        Me.txtDescripcion.TabIndex = 4
        Me.txtDescripcion.UseSelectable = True
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.Color.White
        Me.txtNumero.Lines = New String(-1) {}
        Me.txtNumero.Location = New System.Drawing.Point(161, 25)
        Me.txtNumero.MaxLength = 32767
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumero.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtNumero.SelectedText = ""
        Me.txtNumero.Size = New System.Drawing.Size(137, 23)
        Me.txtNumero.TabIndex = 0
        Me.txtNumero.UseSelectable = True
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgbCaja.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgbCaja.BackgroundColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgbCaja.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgbCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbCaja.Location = New System.Drawing.Point(3, 90)
        Me.dgbCaja.Name = "dgbCaja"
        Me.dgbCaja.Size = New System.Drawing.Size(442, 180)
        Me.dgbCaja.TabIndex = 162
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
        'frmCajaInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 358)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.MetroTile2)
        Me.Name = "frmCajaInicio"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tabIniciar.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.gbCaja.ResumeLayout(False)
        Me.gbCaja.PerformLayout()
        CType(Me.dgbCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents MetroTile2 As MetroFramework.Controls.MetroTile
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabIniciar As MetroFramework.Controls.MetroTabPage
    Friend WithEvents gbCaja As System.Windows.Forms.GroupBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDescripcion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMontoApertura As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTextBox3 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox4 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents dgbCaja As System.Windows.Forms.DataGridView
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtNumero As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnCancelarInicio As System.Windows.Forms.Button
    Friend WithEvents btnGuardarInicio As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
