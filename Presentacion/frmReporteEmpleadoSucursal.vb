Imports System.Data.OleDb
Public Class frmReporteEmpleadoSucursal

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        ListarEmpleado()
    End Sub
    Private Sub ListarEmpleado()
        Dim rn As New RNUsuario
        Dim empleado As List(Of Usuario)

        Try
            empleado = rn.ListarEmpleado(Me.txtSucursal.Text)
            modFunciones.EnlazarDatagridView(Me.dgvEmpleados, empleado)
            Me.dgvEmpleados.Focus()
        Catch ex As Exception
            MetroMessageBox.Show(Me, ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnExportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportar.Click
        Dim save As New SaveFileDialog
        save.Filter = "Archivo Excel | *.xlsx"

        If save.ShowDialog = Windows.Forms.DialogResult.OK Then

            Exportar_Excel(Me.dgvEmpleados, save.FileName)

        End If
        End
    End Sub
    Public Sub Exportar_Excel(ByVal dgv As DataGridView, ByVal pth As String)

        Dim xlApp As Object = CreateObject("Excel.Application")
        'crear una nueva hoja de calculo

        Dim xlWB As Object = xlApp.WorkBooks.add
        Dim xlWS As Object = xlWB.WorkSheets(1)
        'exportamos los caracteres de las columnas 
        For c As Integer = 0 To dgvEmpleados.Columns.Count - 1

            xlWS.cells(1, c + 1).value = dgvEmpleados.Columns(c).HeaderText
        Next

        'exportamos las cabeceras de columnas 

        For r As Integer = 0 To dgvEmpleados.RowCount - 1

            For c As Integer = 0 To dgvEmpleados.Columns.Count - 1

                xlWS.cells(r + 2, c + 1).value = dgvEmpleados.Item(c, r).Value

            Next
        Next


        'guardamos la hoja de calculo en la ruta especificada

        xlWB.saveas(pth)
        xlWS = Nothing
        xlWB = Nothing
        xlApp.quit()
        xlApp = Nothing


    End Sub
End Class