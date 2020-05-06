Public Class Facturas_INV
    Public index_fac As Integer = -1
    Public esNotaDeCredito As Boolean = False

    Private Sub Facturas_INV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_detalle()
    End Sub
    Public Sub cargar_detalle()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        tabla_detalle.Rows.Clear()
        Try

            consulta = "SELECT estado,idproveedor FROM factura WHERE id=" & lblidfac.Text
            tablaResultado = tool.ObtenerTabla(consulta)
            If tablaResultado.Rows.Count > 0 Then
                lblestado.Text = tablaResultado.Rows(0).Item("estado")
                lblid_proveedor.Text = tablaResultado.Rows(0).Item("idproveedor")
            Else
                Throw New Exception("esta factura no contiene detalle, no es posible continuar")
            End If

            consulta = "SELECT * FROM facturadetalle WHERE idfactura=" & lblidfac.Text & " AND idnp_inv=0"
            tablaResultado = tool.ObtenerTabla(consulta)
            If tablaResultado.Rows.Count > 0 Then
                For Each xRow As DataRow In tablaResultado.Rows
                    tabla_detalle.Rows.Add(xRow.Item("id"), xRow.Item("cant"), xRow.Item("np"), xRow.Item("descripcion"), xRow.Item("costo"), xRow.Item("idnp_inv"))
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            btnaplicar.Enabled = False

        End Try
    End Sub

    Private Sub btnaplicar_Click(sender As Object, e As EventArgs) Handles btnaplicar.Click
        Dim continuar As Boolean = False
        Dim cantidad_inv As Integer = 0 'invetanrio mysql
        Dim cant_unidad As Integer = 0 ' Invetario en tabla local

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable
        Dim comando As New MySql.Data.MySqlClient.MySqlCommand
        Dim transaccionActualizar As MySql.Data.MySqlClient.MySqlTransaction = Nothing
        Dim totalFactura As Decimal = 0
        Dim textoMovimiento As String = "ENTRADA"

        Try

            If lblidfac.Text = "" Or lblidfac.Text = "" Then
                Throw New Exception("no se establecio el id de la factura")
            End If

            consulta = "SELECT estado, total FROM factura WHERE id=" & lblidfac.Text
            tablaResultado = tool.ObtenerTabla(consulta)
            If tablaResultado.Rows.Count > 0 Then
                With tablaResultado.Rows(0)
                    If .Item("estado") = "PENDIENTE" Or .Item("estado") = "PAGADO" Then
                        continuar = True
                        totalFactura = .Item("total")
                        If totalFactura = 0 Then
                            Throw New Exception("no se pude continuar el total de la factura es $0.00")
                        End If

                        If totalFactura > 0 Then
                            esNotaDeCredito = False
                            textoMovimiento = "ENTRADA"
                        Else
                            esNotaDeCredito = True
                            textoMovimiento = "SALIDA"
                        End If
                    End If
                End With

            Else
                Throw New Exception("no se pudo obtener el estado de la factura")
            End If

            If continuar Then
                ' VERIFICAR INFORMACION DE LA FACTURA Y SI SE CANCELO

                consulta = "SELECT estado FROM factura WHERE id=" & lblidfac.Text & " AND estado='CANCELADO'"
                tablaResultado = tool.ObtenerTabla(consulta)
                If tablaResultado.Rows.Count > 0 Then
                    continuar = False
                    Throw New Exception("esta Factura ya se encuentra cancelada, no se procede a cambio de INV")
                Else
                    continuar = True
                End If

            End If
            'VERIFICAR 
            If continuar Then
                Dim sumaElementosSeleccionados As Integer = 0
                With tabla_detalle
                    For a = 0 To tabla_detalle.Rows.Count - 1
                        If .Rows(a).Cells("id_np").Value <> 0 Then
                            sumaElementosSeleccionados += 1

                        End If
                    Next
                End With
                If sumaElementosSeleccionados >= 1 Then
                    'se asume que minimo 1 de ellos tiene inventario
                    comando.Connection = New MySql.Data.MySqlClient.MySqlConnection
                    comando.Connection.ConnectionString = con.ConnectionString
                    comando.Connection.Open()

                    transaccionActualizar = comando.Connection.BeginTransaction
                    comando.Transaction = transaccionActualizar

                    For b = 0 To tabla_detalle.Rows.Count - 1
                        If tabla_detalle.Rows(b).Cells("id_np").Value.ToString <> 0 Then 'SI VA AFECTAR UN NP DEL INVETARIO
                            consulta = "SELECT cantidad,cant_unidad FROM articulos_inventario WHERE id=" & tabla_detalle.Rows(b).Cells("id_np").Value.ToString

                            tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                            If tablaResultado.Rows.Count > 0 Then

                                cantidad_inv = tablaResultado.Rows(0).Item("cantidad")

                                cant_unidad = tabla_detalle.Rows(b).Cells("cantidad").Value
                                With tabla_detalle.Rows(b)

                                    If tool.Insertar_Movimiento_ModuloTransaccion("factura_inv", lblfolio.Text, Val(.Cells("id_det").Value), Val(.Cells("id_np").Value), .Cells("np").Value.ToString, textoMovimiento, "ARTICULO", cant_unidad, DateTime.Now, .Cells("desc").Value.ToString, cantidad_inv, (cantidad_inv + cant_unidad), Val(lblid_proveedor.Text), lblproveedor.Text, 1, "ASGINAR INV FACTURA CREADA", transaccionActualizar) Then
                                    Else
                                        Throw New Exception("no se pudo ingresar el movimiento del inventario")
                                    End If
                                End With
                            Else
                                Throw New Exception("No existe numero de parte")
                            End If
                            If esNotaDeCredito Then
                                cantidad_inv -= cant_unidad
                            Else
                                cantidad_inv += cant_unidad
                            End If

                            consulta = "UPDATE articulos_inventario SET cantidad=" & cantidad_inv & " WHERE id=" & tabla_detalle.Rows(b).Cells("id_np").Value.ToString

                            If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                                'actualizar el detalle de la factura por el renglon

                                consulta = "UPDATE facturadetalle SET idnp_inv=" & tabla_detalle.Rows(b).Cells("id_np").Value.ToString & " WHERE id=" & tabla_detalle.Rows(b).Cells("id_det").Value

                                If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then

                                Else
                                    Throw New Exception("no se pudo actualizar información de detalle")
                                End If

                            Else
                                Throw New Exception("no se pudo actualizar la información del inventario")
                            End If

                        End If
                        If b = (tabla_detalle.Rows.Count - 1) Then
                            transaccionActualizar.Commit()
                            MsgBox("Factura e Inventarios Actualizados", MsgBoxStyle.Information)
                            Me.Close()
                        End If
                    Next
                Else
                    MsgBox("Debe asigar un articulo con invetario", MsgBoxStyle.Information)
                    Exit Sub

                End If
            End If

        Catch ex As Exception
            If transaccionActualizar IsNot Nothing Then
                If transaccionActualizar.Connection IsNot Nothing Then
                    transaccionActualizar.Rollback()
                End If
            End If
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Actualizar registros e inventario")
        End Try
    End Sub


    Private Sub tabla_detalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_detalle.CellContentClick
        If tabla_detalle.Rows.Count > 0 Then
            Dim i As Integer = tabla_detalle.CurrentRow.Index

        End If
    End Sub

    Private Sub btnINV_Click(sender As Object, e As EventArgs) Handles btnINV.Click
        If tabla_detalle.Rows.Count > 0 And tabla_detalle.SelectedCells.Count > 0 Then
            FrmFacturasAgregar_INV.Dispose()
            Dim i As Integer = tabla_detalle.CurrentRow.Index
            Dim numero_parte As String = tabla_detalle.Rows(i).Cells("np").Value
            FrmFacturasAgregar_INV.numero_parte = numero_parte
            FrmFacturasAgregar_INV.ventana = "factura_inv"
            FrmFacturasAgregar_INV.ShowDialog()
            If FrmFacturasAgregar_INV.id_numero_parte > 0 Then
                tabla_detalle.Rows(i).Cells("id_np").Value = FrmFacturasAgregar_INV.id_numero_parte
                tabla_detalle.Rows(i).Cells("np").Value = FrmFacturasAgregar_INV.numero_parte
            End If

        End If
    End Sub
End Class