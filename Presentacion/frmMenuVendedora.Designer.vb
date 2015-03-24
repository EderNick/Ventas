<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCajero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCajero))
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.btnOrdenPedido = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnUsuario = New System.Windows.Forms.Button()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.MetroPanel1.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.MetroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MetroPanel1.Controls.Add(Me.btnOrdenPedido)
        Me.MetroPanel1.Controls.Add(Me.Label1)
        Me.MetroPanel1.Controls.Add(Me.btnSalir)
        Me.MetroPanel1.Controls.Add(Me.btnUsuario)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(1, 30)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(620, 677)
        Me.MetroPanel1.TabIndex = 192
        Me.MetroPanel1.UseCustomBackColor = True
        Me.MetroPanel1.UseCustomForeColor = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'btnOrdenPedido
        '
        Me.btnOrdenPedido.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.btnOrdenPedido.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(136, Byte), Integer))
        Me.btnOrdenPedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnOrdenPedido.FlatAppearance.BorderSize = 0
        Me.btnOrdenPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnOrdenPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnOrdenPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenPedido.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnOrdenPedido.ForeColor = System.Drawing.Color.White
        Me.btnOrdenPedido.Image = CType(resources.GetObject("btnOrdenPedido.Image"), System.Drawing.Image)
        Me.btnOrdenPedido.Location = New System.Drawing.Point(44, 172)
        Me.btnOrdenPedido.Name = "btnOrdenPedido"
        Me.btnOrdenPedido.Size = New System.Drawing.Size(126, 358)
        Me.btnOrdenPedido.TabIndex = 220
        Me.btnOrdenPedido.Text = "Orden Pedido"
        Me.btnOrdenPedido.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnOrdenPedido.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(161, 45)
        Me.Label1.TabIndex = 215
        Me.Label1.Text = "Vendedor"
        '
        'btnSalir
        '
        Me.btnSalir.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnSalir.ForeColor = System.Drawing.Color.White
        Me.btnSalir.Location = New System.Drawing.Point(524, 618)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(69, 34)
        Me.btnSalir.TabIndex = 208
        Me.btnSalir.Text = "off"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnUsuario
        '
        Me.btnUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.btnUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(116, Byte), Integer), CType(CType(95, Byte), Integer))
        Me.btnUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnUsuario.FlatAppearance.BorderSize = 0
        Me.btnUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnUsuario.ForeColor = System.Drawing.Color.White
        Me.btnUsuario.Image = CType(resources.GetObject("btnUsuario.Image"), System.Drawing.Image)
        Me.btnUsuario.Location = New System.Drawing.Point(185, 172)
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(266, 124)
        Me.btnUsuario.TabIndex = 198
        Me.btnUsuario.Text = "Usuario"
        Me.btnUsuario.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnUsuario.UseVisualStyleBackColor = False
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(150, 150)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(639, 45)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        '
        'ToolStripContainer1.RightToolStripPanel
        '
        Me.ToolStripContainer1.RightToolStripPanel.BackgroundImage = CType(resources.GetObject("ToolStripContainer1.RightToolStripPanel.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripContainer1.RightToolStripPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStripContainer1.Size = New System.Drawing.Size(150, 175)
        Me.ToolStripContainer1.TabIndex = 216
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'frmCajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(615, 707)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Name = "frmCajero"
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents btnUsuario As System.Windows.Forms.Button
    Friend WithEvents btnOrdenPedido As System.Windows.Forms.Button
End Class
