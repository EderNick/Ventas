<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuCajero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMenuCajero))
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnEmpleado = New System.Windows.Forms.Button()
        Me.MetroPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.MetroPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MetroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MetroPanel2.Controls.Add(Me.btnEmpleado)
        Me.MetroPanel2.Controls.Add(Me.Button2)
        Me.MetroPanel2.Controls.Add(Me.Button4)
        Me.MetroPanel2.Controls.Add(Me.Button6)
        Me.MetroPanel2.Controls.Add(Me.Label2)
        Me.MetroPanel2.Controls.Add(Me.Button8)
        Me.MetroPanel2.Controls.Add(Me.Button9)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 36)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(864, 861)
        Me.MetroPanel2.TabIndex = 224
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.UseCustomForeColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'Button9
        '
        Me.Button9.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(137, Byte), Integer))
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Image = CType(resources.GetObject("Button9.Image"), System.Drawing.Image)
        Me.Button9.Location = New System.Drawing.Point(109, 130)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(340, 116)
        Me.Button9.TabIndex = 198
        Me.Button9.Text = "Usuario"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(727, 644)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(69, 34)
        Me.Button8.TabIndex = 208
        Me.Button8.Text = "off"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 45)
        Me.Label2.TabIndex = 215
        Me.Label2.Text = "Vendedor"
        '
        'Button6
        '
        Me.Button6.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(93, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.Location = New System.Drawing.Point(266, 261)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(183, 146)
        Me.Button6.TabIndex = 216
        Me.Button6.Text = "Caja"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(266, 430)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(184, 210)
        Me.Button4.TabIndex = 221
        Me.Button4.Text = " Registrar Pagos"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(142, Byte), Integer), CType(CType(110, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(466, 130)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 510)
        Me.Button2.TabIndex = 223
        Me.Button2.Text = "Reporte Venta"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnEmpleado
        '
        Me.btnEmpleado.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip
        Me.btnEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(89, Byte), Integer))
        Me.btnEmpleado.BackgroundImage = CType(resources.GetObject("btnEmpleado.BackgroundImage"), System.Drawing.Image)
        Me.btnEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEmpleado.FlatAppearance.BorderSize = 0
        Me.btnEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
        Me.btnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEmpleado.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnEmpleado.ForeColor = System.Drawing.Color.White
        Me.btnEmpleado.Location = New System.Drawing.Point(109, 252)
        Me.btnEmpleado.Name = "btnEmpleado"
        Me.btnEmpleado.Size = New System.Drawing.Size(139, 388)
        Me.btnEmpleado.TabIndex = 224
        Me.btnEmpleado.Text = "Registrar Venta"
        Me.btnEmpleado.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnEmpleado.UseVisualStyleBackColor = False
        '
        'frmMenuCajero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 764)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Name = "frmMenuCajero"
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnEmpleado As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
End Class
