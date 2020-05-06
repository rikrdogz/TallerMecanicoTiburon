Public Class frmFacturas_Pagados_cancelar

    Dim vIdPago As Integer
    Dim ValorPagado As Decimal
    Dim vEsConAbonos As Boolean

    Public Sub New(xIdPago As Integer, xValorPagadoTotal As Decimal)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        vIdPago = xIdPago
        ValorPagado = xValorPagadoTotal
        ObtenerFacturasDelPago()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub ObtenerFacturasDelPago()

        Dim consulta As String = ""
        Dim tool As New Herramienta
        Dim tablaResultado As New DataTable

        Try
            'Verificar si es CancenlacionConABonos
            consulta = "SELECT facturas_pagodetalle.iddetalle, idfactura, abonado, factura.folio, factura.total from facturas_pagodetalle LEFT JOIN factura ON factura.id =  facturas_pagodetalle.idfactura WHERE facturas_pagodetalle.idpago=" & vIdPago
            tablaResultado = tool.ObtenerTabla(consulta)
            If tablaResultado.Rows.Count > 0 Then
                vEsConAbonos = True
                For Each xRow As DataRow In tablaResultado.Rows
                    GridAbonos.Rows.Add(xRow.Item("iddetalle"), xRow.Item("idfactura"), xRow.Item("folio"), xRow.Item("abonado"), xRow.Item("total"))
                Next
                GridAbonos.Show()
            Else
                vEsConAbonos = False
                GridAbonos.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            btnSi.Enabled = False
        End Try
        


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub btnSi_Click(sender As Object, e As EventArgs) Handles btnSi.Click
        Dim cancelar As Boolean = False
        Dim observ As String = ""
        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable
        Dim comando As New MySql.Data.MySqlClient.MySqlCommand
        Dim transaccionActualizar As MySql.Data.MySqlClient.MySqlTransaction = Nothing

        Try

            comando.Connection = New MySql.Data.MySqlClient.MySqlConnection
            comando.Connection.ConnectionString = con.ConnectionString
            comando.Connection.Open()

            transaccionActualizar = comando.Connection.BeginTransaction
            comando.Transaction = transaccionActualizar

            consulta = " SELECT estado FROM facturas_pagos WHERE folio =" & lblidpago.Text
            tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

            If tablaResultado.Rows.Count > 0 Then
                If tablaResultado.Rows(0).Item("estado") = "CANCELADO" Then
                    Throw New Exception("Esta pago ya se encontraba CANCELADO")
                End If
            Else
                Throw New Exception("No se encontro folio del pago")
            End If

            consulta = "SELECT pass FROM usuarios WHERE id=" & MDIPrincipal.lblidUser.Text
            tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

            If tablaResultado.Rows.Count > 0 Then

                If txtpass.Text = tablaResultado.Rows(0).Item("pass") Then
                    cancelar = True
                Else
                    Throw New Exception("no se obtuvo la contraseña")
                End If
            Else
                Throw New Exception("no se obtuvo la contraseña")
            End If

            If cancelar = False Then Return

            If vEsConAbonos = False Then

                consulta = "UPDATE factura SET estado='PENDIENTE', saldopendiente=total, saldopagado=0, fechapago=NULL, idpago=0 WHERE idpago=" & lblidpago.Text
                If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                    consulta = "SELECT observacion FROM facturas_pagos WHERE folio=" & lblidpago.Text
                    tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)
                    If tablaResultado.Rows.Count > 0 Then
                        observ = tablaResultado.Rows(0).Item("observacion")
                    Else

                    End If

                    consulta = "UPDATE facturas_pagos SET observacion='" & observ & " *CANCELADO*', estado='CANCELADO' WHERE folio=" & lblidpago.Text
                    If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                        transaccionActualizar.Commit()
                        MsgBox("Facturas cancelados", MsgBoxStyle.Information)
                        Me.Dispose()
                    Else
                        Throw New Exception("no se pudo actualizar las facturas a estado cancelado")
                    End If

                End If
            Else
                'Es con abonos
                If GridAbonos.Rows.Count = 0 Then
                    Throw New Exception("No hay abonos en este pago")
                End If
                consulta = "UPDATE facturas_pagos SET observacion='" & observ & " *CANCELADO*', estado='CANCELADO' WHERE folio=" & lblidpago.Text
                If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                Else
                    Throw New Exception("No se pudo actualizar info de pago")
                End If

                Dim xSeAplicoLaCancelacion As Boolean

                For Each xRowFactura As DataGridViewRow In GridAbonos.Rows
                    Dim xIdFactura As Integer
                    Dim xSaldoPendiente As Decimal
                    Dim xSaldoPagado As Decimal
                    Dim xTotalFactura As Decimal
                    Dim xValorABonado As Decimal
                    Dim xSaldoPendienteNuevo As Decimal
                    Dim xSaldoPagadoNuevo As Decimal
                    Dim xEsNotaCredito As Boolean
                    consulta = " SELECT id, saldopendiente, saldopagado, total FROM factura WHERE id =" & xRowFactura.Cells(ColIdFactura.Name).Value.ToString

                    tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                    If tablaResultado.Rows.Count > 0 Then
                        Integer.TryParse(tablaResultado.Rows(0).Item("id"), xIdFactura)
                        Decimal.TryParse(tablaResultado.Rows(0).Item("saldopendiente"), xSaldoPendiente)
                        Decimal.TryParse(tablaResultado.Rows(0).Item("saldopagado"), xSaldoPagado)
                        Decimal.TryParse(tablaResultado.Rows(0).Item("total"), xTotalFactura)
                        Decimal.TryParse(xRowFactura.Cells(ColAbonado.Name).Value.ToString, xValorABonado)

                        If xValorABonado = 0 Then
                            Throw New Exception("el valor abonado es cero, deber ser diferente a cero")
                        End If

                        If xValorABonado < 0 Then
                            xEsNotaCredito = True
                        Else
                            xEsNotaCredito = False
                        End If

                        If xEsNotaCredito = False Then
                            If (xSaldoPendiente + xSaldoPagado) - xValorABonado < 0 Then
                                Throw New Exception("En facturas, no debe quedar saldo pendiente menor a cero")
                            End If

                            xSaldoPendienteNuevo = xSaldoPendiente + xValorABonado
                        Else
                            If (xSaldoPendiente + xSaldoPagado) - xValorABonado > 0 Then
                                Throw New Exception("En NotaDecredito, no debe quedar saldo pendiente mayor a cero")
                            End If

                            xSaldoPendienteNuevo = xSaldoPendiente + xValorABonado
                        End If

                        If xSaldoPendienteNuevo = 0 Then
                            Throw New Exception("En Nota Y Facturas, el saldo pendiente debe ser menor diferente a cero ")
                        End If

                        If xEsNotaCredito Then
                            If xSaldoPendienteNuevo < xTotalFactura Then
                                Throw New Exception("El saldo pendiente es mayor a total de la nota de credito")
                            End If
                        Else
                            If xSaldoPendienteNuevo > xTotalFactura Then
                                Throw New Exception("El saldo pendiente es mayor a total de la factura")
                            End If

                        End If
                        xSaldoPagadoNuevo = xSaldoPagado - xValorABonado
                        consulta = "UPDATE factura SET estado = 'PENDIENTE', saldopendiente= " & xSaldoPendienteNuevo & ", saldopagado =" & xSaldoPagadoNuevo & ", fechapago=NULL, idpago=0 WHERE id=" & xIdFactura
                        If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                            xSeAplicoLaCancelacion = True
                        Else
                            Throw New Exception("No se pudo actualizar la info de las facturas")
                        End If

                    Else
                        Throw New Exception("No se encontro detalle de pago " & xRowFactura.Cells(ColIdDetalle.Name).Value.ToString)
                    End If
                Next
                If xSeAplicoLaCancelacion Then
                    transaccionActualizar.Commit()
                    MsgBox("Cancelación Exitosa", MsgBoxStyle.Information)
                    Me.Close()
                End If
            End If

        Catch ex As Exception
            If transaccionActualizar IsNot Nothing Then
                If transaccionActualizar.Connection IsNot Nothing Then
                    transaccionActualizar.Rollback()
                End If
            End If
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub
End Class