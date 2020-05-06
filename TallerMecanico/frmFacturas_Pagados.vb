Public Class frmFacturas_Pagados

    Private Sub frmFacturas_Pagados_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub

    Private Sub frmFacturas_Pagados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estructura_ventana(Me)
        CargarFolios()

        txtproveedor.Focus()
    End Sub
    Public Sub CargarFolios()
        tablaFolios.Rows.Clear()
        Tabla_Detalle.Rows.Clear()
        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultados As New DataTable

        Try
            consulta = "SELECT * FROM facturas_pagos WHERE proveedor like '%" & txtproveedor.Text & "%' ORDER BY folio DESC Limit " & nmax.Value

            tablaFolios.Rows.Clear()
            tablaResultados = tool.ObtenerTabla(consulta)
            If tablaResultados.Rows.Count > 0 Then
                For Each xRow As DataRow In tablaResultados.Rows
                    tablaFolios.Rows.Add(xRow.Item("folio"), xRow.Item("fecha"), xRow.Item("proveedor"), xRow.Item("total"), xRow.Item("estado"), xRow.Item("observacion"), xRow.Item("metodo"))
                Next
            End If
           
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "FOlios")
        End Try
        cargardetalle()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub frmFacturas_Pagados_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        estructura_ventana(Me)
    End Sub

    Private Sub frmFacturas_Pagados_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub tablaFolios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaFolios.CellClick
        If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
            Return

        End If
        lblMensajeCancelado.Hide()
        btnCancelar.Hide()
        If tablaFolios.Rows(e.RowIndex).Cells(ColEstado.Name).Value.ToString = "CANCELADO" Then
            lblMensajeCancelado.Show()
        Else
            btnCancelar.Show()
        End If
    End Sub

    Private Sub tablaFolios_SelectionChanged(sender As Object, e As EventArgs) Handles tablaFolios.SelectionChanged
        If datos.IsClosed And tablaFolios.Rows.Count > 0 Then
            cargardetalle()
        End If

    End Sub
    Private Sub cargardetalle()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultados As New DataTable

        Tabla_Detalle.Rows.Clear()

        If tablaFolios.Rows.Count > 0 And tablaFolios.SelectedCells.Count > 0 Then
            Dim i As Integer = tablaFolios.CurrentRow.Index
            Try
                Tabla_Detalle.Rows.Clear()

                consulta = "SELECT iddetalle FROM facturas_pagodetalle WHERE idpago=" & tablaFolios.Rows(i).Cells("folio").Value
                tablaResultados = tool.ObtenerTabla(consulta)
                If tablaResultados.Rows.Count > 0 Then
                    'POR RELACION DE detalle
                    consulta = "SELECT * FROM facturas_pagodetalle LEFT JOIN factura ON factura.id = facturas_pagodetalle.idfactura WHERE facturas_pagodetalle.idpago=" & tablaFolios.Rows(i).Cells("folio").Value
                    tablaResultados = tool.ObtenerTabla(consulta)
                    For Each xRow As DataRow In tablaResultados.Rows
                        Tabla_Detalle.Rows.Add(xRow.Item("folio"), xRow.Item("observacion"), xRow.Item("total"), xRow.Item("fecha"), xRow.Item("abonado"), xRow.Item("saldopendiente"), xRow.Item("saldopagado"))
                    Next
                Else
                    consulta = "SELECT * FROM factura LEFT JOIN facturas_pagodetalle ON factura.idpago = facturas_pagodetalle.idpago WHERE factura.idpago=" & tablaFolios.Rows(i).Cells("folio").Value
                    tablaResultados = tool.ObtenerTabla(consulta)
                    If tablaResultados.Rows.Count > 0 Then
                        For Each xRow As DataRow In tablaResultados.Rows
                            Tabla_Detalle.Rows.Add(xRow.Item("folio"), xRow.Item("observacion"), xRow.Item("total"), xRow.Item("fecha"), xRow.Item("total"), xRow.Item("saldopendiente"), xRow.Item("saldopagado"))
                        Next
                    End If
                End If


               

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If

    End Sub

    Private Sub txtproveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles txtproveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            CargarFolios()

        End If
    End Sub

    Private Sub txtproveedor_TextChanged(sender As Object, e As EventArgs) Handles txtproveedor.TextChanged


    End Sub

    Private Sub btnFecha_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Dim frmCancelarPago As frmFacturas_Pagados_cancelar

        Dim xIdPago As Integer
        Dim xPagadoTotal As Decimal

        If tablaFolios.Rows.Count > 0 And tablaFolios.SelectedCells.Count > 0 Then
            Dim i As Integer = tablaFolios.CurrentRow.Index
            If MessageBox.Show("¿Desea cancelar este pago?", "Cancelar pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                Integer.TryParse(tablaFolios.Rows(i).Cells("folio").Value.ToString, xIdPago)
                Decimal.TryParse(tablaFolios.Rows(i).Cells("pagado").Value.ToString, xPagadoTotal)
                frmCancelarPago = New frmFacturas_Pagados_cancelar(xIdPago, xPagadoTotal)
                With frmCancelarPago
                    .lblfecha.Text = tablaFolios.Rows(i).Cells("fecha").Value
                    .lbltotal.Text = FormatCurrency(tablaFolios.Rows(i).Cells("pagado").Value)
                    .lblidpago.Text = tablaFolios.Rows(i).Cells("folio").Value
                    .lblrefa.Text = tablaFolios.Rows(i).Cells("Proveedor").Value

                    frmCancelarPago.ShowDialog()
                    CargarFolios()
                End With

            End If
        End If
    End Sub

    Private Sub tablaFolios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaFolios.CellContentClick

    End Sub

    Private Sub nmax_KeyDown(sender As Object, e As KeyEventArgs) Handles nmax.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            CargarFolios()

        End If
    End Sub

    Private Sub nmax_ValueChanged(sender As Object, e As EventArgs) Handles nmax.ValueChanged

    End Sub

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        CargarFolios()

    End Sub
End Class