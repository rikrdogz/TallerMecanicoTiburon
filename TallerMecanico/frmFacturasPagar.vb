Public Class frmFacturasPagar
    Dim listProveedor As New List(Of Integer)
    Private Sub frmFacturasPagar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estructura_ventana(Me)
        cargarProveedor()
    End Sub
    Private Sub cargarProveedor()
        Dim agregar As Boolean = True
        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Try

            consulta = "SELECT DISTINCT idproveedor, proveedor FROM factura WHERE estado='PENDIENTE' order by idproveedor"
            cbProveedor.Items.Clear()
            listProveedor.Clear()
            tablaResultado = tool.ObtenerTabla(consulta)
            If tablaResultado.Rows.Count > 0 Then

                For Each xRow As DataRow In tablaResultado.Rows
                    cbProveedor.Items.Add(xRow.Item("proveedor"))
                    listProveedor.Add(xRow.Item("idproveedor"))
                Next


            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub
    
    Private Sub cbProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles cbProveedor.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnContinuar.PerformClick()

        End If
    End Sub

    Private Sub cbProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbProveedor.KeyPress

    End Sub

    Private Sub cbProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProveedor.SelectedIndexChanged
        If cbProveedor.SelectedIndex >= 0 Then
            btnContinuar.Enabled = True
        Else
            btnContinuar.Enabled = False
        End If
        lblid.Text = listProveedor.Item(cbProveedor.SelectedIndex)
        txtproveedor.Text = cbProveedor.Text
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        CargarFolios()
    End Sub
    Private Sub CargarFolios()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Try
            consulta = "SELECT * FROM factura WHERE idproveedor=" & lblid.Text & " AND estado='PENDIENTE' order by fecha"

            tablaFacturas.Rows.Clear()
            tablaResultado = tool.ObtenerTabla(consulta)
            If tablaResultado.Rows.Count > 0 Then
                cbProveedor.Enabled = False
                For Each xRow As DataRow In tablaResultado.Rows
                    Dim SaldoPorAbonar As Decimal
                    Dim SaldoPendiente As Decimal
                    Dim SaldoPagado As Decimal
                    Dim valorTotal As Decimal

                    Decimal.TryParse(xRow.Item("saldopagado").ToString, SaldoPagado)
                    Decimal.TryParse(xRow.Item("saldopendiente").ToString, SaldoPendiente)
                    Decimal.TryParse(xRow.Item("total").ToString, valorTotal)

                    SaldoPorAbonar = valorTotal - SaldoPagado

                    tablaFacturas.Rows.Add(xRow.Item("id"), xRow.Item("folio"), xRow.Item("total"), xRow.Item("fecha"), xRow.Item("observacion"), SaldoPendiente, SaldoPagado)
                Next
            End If
            btnContinuar.Enabled = False
            btncancelar.Enabled = True

            sumartotales()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub sumartotales()
        If tablaFacturas.Rows.Count > 0 Then
            Ntotales.Value = 0
            For i = 0 To tablaFacturas.Rows.Count - 1
                Ntotales.Value += tablaFacturas.Rows(i).Cells("total").Value

            Next
        Else
            Ntotales.Value = 0
        End If
        If TablaPagados.Rows.Count > 0 Then
            Npagadas.Value = 0
            For i = 0 To TablaPagados.Rows.Count - 1
                Npagadas.Value += TablaPagados.Rows(i).Cells(abonar.Name).Value

            Next
        Else
            Npagadas.Value = 0
        End If

    End Sub

    Private Sub btnagregar_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        If tablaFacturas.Rows.Count > 0 Then
            Dim i As Integer = tablaFacturas.CurrentRow.Index
            TablaPagados.MultiSelect = False
            For a = 0 To TablaPagados.Rows.Count - 1
                If tablaFacturas.Rows(i).Cells("id").Value = TablaPagados.Rows(a).Cells("idp").Value Then
                    MsgBox("Ya existe  esta Factura en la lista de Facturas a pagar", MsgBoxStyle.Information)
                    Exit Sub

                End If
            Next
            With tablaFacturas.Rows(i)
                Dim saldoPendiente As Decimal
                Dim saldoPagado As Decimal
                Dim ValorTotal As Decimal
                Try
                    Decimal.TryParse(.Cells(ColPagado.Name).Value.ToString, saldoPagado)
                    Decimal.TryParse(.Cells("total").Value.ToString, ValorTotal)
                Catch ex As Exception

                End Try
                
                saldoPendiente = ValorTotal - saldoPagado

                TablaPagados.Rows.Add(.Cells("id").Value, .Cells("folio").Value, .Cells("total").Value, .Cells("fech").Value, .Cells("obse").Value, .Cells(ColPendiente.Name).Value, saldoPendiente)
                tablaFacturas.Rows.RemoveAt(i)
                If TablaPagados.Rows.Count > 0 Then


                    TablaPagados.Rows(TablaPagados.Rows.Count - 1).Selected = True
                    TablaPagados.CurrentCell = TablaPagados(1, TablaPagados.Rows.Count - 1)
                    TablaPagados.FirstDisplayedScrollingRowIndex = TablaPagados.RowCount - 1

                End If

            End With
            sumartotales()
        End If
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        If TablaPagados.Rows.Count > 0 Then
            Dim i As Integer = TablaPagados.CurrentRow.Index
            Dim consulta As String = ""
            Dim tool As New Herramienta
            Dim tablaResultado As New DataTable

            With TablaPagados.Rows(i)
                If MessageBox.Show("¿Deseas regresar a la lista la Factura: " & .Cells("foliop").Value & " Total: " & .Cells("totalp").Value & " ?", "Preguntar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                    Try
                        consulta = "SELECT * from factura where id=" & TablaPagados.Rows(i).Cells(idp.Name).Value.ToString
                        tablaResultado = tool.ObtenerTabla(consulta)
                        If tablaResultado.Rows.Count > 0 Then
                            Dim SaldoPorAbonar As Decimal
                            Dim SaldoPendiente As Decimal
                            Dim SaldoPagado As Decimal
                            Dim valorTotal As Decimal
                            With tablaResultado.Rows(0)
                                Decimal.TryParse(.Item("saldopagado").ToString, SaldoPagado)
                                Decimal.TryParse(.Item("saldopendiente").ToString, SaldoPendiente)
                                Decimal.TryParse(.Item("total").ToString, valorTotal)

                                SaldoPorAbonar = valorTotal - SaldoPagado
                                tablaFacturas.Rows.Add(.Item("id"), .Item("folio"), .Item("total"), .Item("fecha"), .Item("observacion"), SaldoPendiente, SaldoPagado)
                                TablaPagados.Rows.RemoveAt(i)
                            End With

                        Else
                            Throw New Exception("no se pudo obtener información de la factura a regresar")
                        End If

                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                    

                End If
               
            End With

        End If
        sumartotales()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim valores As String = ""
        Dim val_folio As Integer = 0
        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable
        Dim comando As New MySql.Data.MySqlClient.MySqlCommand
        Dim transaccionActualizar As MySql.Data.MySqlClient.MySqlTransaction = Nothing

        Dim hoy As Date = Date.Now.ToLongDateString
        If fecha.Value.ToShortDateString > hoy Then
            MsgBox("La fecha que ingreso no es correcta, debe ingresar una que este dentro de el tiempo estimado", MsgBoxStyle.Information)
            Exit Sub
            fecha.Focus()

        End If

        If TablaPagados.Rows.Count > 0 Then
            If cbMetodo.SelectedIndex >= 0 Then

                Try
                    comando.Connection = New MySql.Data.MySqlClient.MySqlConnection
                    comando.Connection.ConnectionString = con.ConnectionString
                    comando.Connection.Open()

                    transaccionActualizar = comando.Connection.BeginTransaction
                    comando.Transaction = transaccionActualizar

                    valores &= "'" & Format(fecha.Value, "yyyy/MM/dd") & "',"
                    valores &= "'" & txtObserv.Text & "',"
                    valores &= lblid.Text & ","
                    valores &= "'" & cbProveedor.Text & "',"
                    valores &= Npagadas.Value & ","
                    valores &= "'" & cbMetodo.Text & "',"
                    valores &= MDIPrincipal.lblidUser.Text & ","
                    valores &= "'" & MDIPrincipal.lblUser.Text & "'"
                    consulta = "INSERT INTO facturas_pagos (fecha,observacion,idproveedor,proveedor,total,metodo,iduser,user) VALUES (" & valores & ")"
                    If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                        consulta = "SELECT MAX(folio) FROM facturas_pagos"
                        tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)
                        If tablaResultado.Rows.Count > 0 Then
                            val_folio = tablaResultado.Rows(0).Item(0)
                        Else
                            Throw New Exception("no se pudo obtener la información del ID del pago")
                        End If

                        For i = 0 To TablaPagados.Rows.Count - 1
                            Dim nuevoEstado As String = "PENDIENTE"
                            Dim SaldoPendienteNuevo As Decimal = 0
                            Dim pagadoNuevo As Decimal = 0
                            Dim pendienteAnterior As Decimal = 0
                            Dim idFacturaFolio As Integer = 0

                            Integer.TryParse(TablaPagados.Rows(i).Cells("idp").Value.ToString, idFacturaFolio)

                            With TablaPagados.Rows(i)
                                Decimal.TryParse(.Cells(porPagarPendiente.Name).Value.ToString, pendienteAnterior)
                                Decimal.TryParse(.Cells(abonar.Name).Value.ToString, pagadoNuevo)
                                SaldoPendienteNuevo = pendienteAnterior - pagadoNuevo
                                If .Cells(abonar.Name).Value = .Cells(porPagarPendiente.Name).Value Then
                                    nuevoEstado = "PAGADO"
                                End If
                            End With
                            If tool.AplicarABonoFactura(val_folio, idFacturaFolio, pagadoNuevo, pendienteAnterior, transaccionActualizar) Then
                            Else
                                Throw New Exception("No se pudo actualizar el abono detalle")
                            End If
                            consulta = "UPDATE factura SET estado='" & nuevoEstado & "', idpago=" & val_folio & ", fechapago='" & Format(fecha.Value, "yyyy/MM/dd") & "', saldopendiente=" & SaldoPendienteNuevo & ", saldopagado = saldopagado + " & pagadoNuevo & " WHERE id=" & idFacturaFolio
                            If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                                If i = TablaPagados.Rows.Count - 1 Then
                                    transaccionActualizar.Commit()
                                    MsgBox("Facturas pagadas", MsgBoxStyle.Information)
                                    Me.Close()

                                End If
                            Else
                                Throw New Exception("no se pudo actualizar a PAGADO las facturas")
                            End If
                        Next
                    End If
                Catch ex As Exception
                    If transaccionActualizar IsNot Nothing Then
                        If transaccionActualizar.Connection IsNot Nothing Then
                            transaccionActualizar.Rollback()
                        End If
                    End If
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try

            Else
                MsgBox("Seleccione el metodo de pago", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Debe agregar Facturas a la lista de 'Facturas a pagar'", MsgBoxStyle.Information)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub txtFolio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFolio.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            btnagregar.PerformClick()
        End If
    End Sub

    Private Sub txtFolio_TextChanged(sender As Object, e As EventArgs) Handles txtFolio.TextChanged
        Dim agregar As Boolean = False
        tablaFacturas.Rows.Clear()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Try
            consulta = "SELECT * FROM factura WHERE idproveedor=" & lblid.Text & " AND estado='PENDIENTE' AND folio like '%" & txtFolio.Text & "%'"
            tablaResultado = tool.ObtenerTabla(consulta)
            If tablaResultado.Rows.Count > 0 Then

                For Each xRow As DataRow In tablaResultado.Rows
                    Dim SaldoPorAbonar As Decimal
                    Dim SaldoPendiente As Decimal
                    Dim SaldoPagado As Decimal
                    Dim valorTotal As Decimal

                    Decimal.TryParse(xRow.Item("saldopagado").ToString, SaldoPagado)
                    Decimal.TryParse(xRow.Item("saldopendiente").ToString, SaldoPendiente)
                    Decimal.TryParse(xRow.Item("total").ToString, valorTotal)

                    SaldoPorAbonar = valorTotal - SaldoPagado


                    If TablaPagados.Rows.Count = 0 Then
                        tablaFacturas.Rows.Add(xRow.Item("id"), xRow.Item("folio"), xRow.Item("total"), xRow.Item("fecha"), xRow.Item("observacion"), SaldoPendiente, SaldoPagado)
                    Else
                        For i = 0 To TablaPagados.Rows.Count - 1
                            If Not xRow.Item("id") = TablaPagados.Rows(i).Cells("idp").Value.ToString Then
                                agregar = True
                                ' Exit For
                            Else

                                agregar = False
                                Exit For
                            End If
                        Next
                        If agregar Then
                            tablaFacturas.Rows.Add(xRow.Item("id"), xRow.Item("folio"), xRow.Item("total"), xRow.Item("fecha"), xRow.Item("observacion"), SaldoPendiente, SaldoPagado)
                        End If
                        agregar = False
                    End If
                Next
            End If
            btnContinuar.Enabled = False
            sumartotales()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tablaFacturas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaFacturas.CellContentClick

    End Sub

    Private Sub tablaFacturas_KeyDown(sender As Object, e As KeyEventArgs) Handles tablaFacturas.KeyDown
        If e.KeyCode = Keys.Enter Then
            If tablaFacturas.Rows.Count > 0 Then
                e.Handled = True

                Dim i As Integer = tablaFacturas.CurrentRow.Index
                btnagregar.PerformClick()

            End If

        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtFolio.Clear()

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        btncancelar.Enabled = False
        btnContinuar.Enabled = True
        tablaFacturas.Rows.Clear()
        TablaPagados.Rows.Clear()
        Npagadas.Value = 0
        Ntotales.Value = 0

        cbProveedor.Enabled = True
    End Sub

    Private Sub btnAct_Click(sender As Object, e As EventArgs) Handles btnAct.Click
        Dim agregar As Boolean = False
        tablaFacturas.Rows.Clear()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If con.State = ConnectionState.Open Then
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM factura WHERE idproveedor=" & lblid.Text & " AND estado='PENDIENTE'"
                datos = cmd.ExecuteReader
                If datos.HasRows Then
                    While datos.Read
                        If TablaPagados.Rows.Count = 0 Then
                            tablaFacturas.Rows.Add(datos("id"), datos("folio"), datos("total"))
                        Else
                            For i = 0 To TablaPagados.Rows.Count - 1

                                If Not datos("id") = TablaPagados.Rows(i).Cells("idp").Value.ToString Then
                                    agregar = True
                                Else
                                    agregar = False
                                    Exit For
                                End If
                            Next
                            If agregar Then
                                tablaFacturas.Rows.Add(datos("id"), datos("folio"), datos("total"), datos("fecha"), datos("observacion"))
                            End If
                            agregar = False
                        End If
                    End While
                End If
                btnContinuar.Enabled = False
                datos.Close()
            End If
            sumartotales()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub TablaPagados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaPagados.CellContentClick

    End Sub

    Private Sub TablaPagados_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaPagados.CellDoubleClick

        If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
            Return
        End If

        Try
            With TablaPagados.Rows(e.RowIndex)
                Dim AbonoMaximo As Decimal
                Dim valorAbonar As Decimal
                Dim esNotaCredito As Boolean
                Decimal.TryParse(.Cells(porPagarPendiente.Name).Value, AbonoMaximo)
                Decimal.TryParse(.Cells(abonar.Name).Value, valorAbonar)

                esNotaCredito = valorAbonar < 0

                Dim ventanaAbonar As New frmFacturaAbonar(e.RowIndex, AbonoMaximo, esNotaCredito, .Cells(foliop.Name).Value)
                If ventanaAbonar.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    .Cells(abonar.Name).Value = ventanaAbonar.valorNuevoAbonar
                    sumartotales()

                End If


            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
      



    End Sub

    Private Sub TablaPagados_Click(sender As Object, e As EventArgs) Handles TablaPagados.Click
        TablaPagados.MultiSelect = True
    End Sub

    Private Sub Npagadas_ValueChanged(sender As Object, e As EventArgs) Handles Npagadas.ValueChanged
        lbltotal.Text = FormatCurrency(Npagadas.Value)
    End Sub
End Class