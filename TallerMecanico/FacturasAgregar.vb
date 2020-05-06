Public Class FacturasAgregar
    Dim t As Integer = 0
    Public cantPorUnidad As Integer = 1
    Public index_tabla As Integer
    Dim tipo_movimiento As String = "ENTRADA"
    Dim tipo_doc As String = "FACTURAS"
    Dim motivo As String = ""
    Public vIva As Decimal = 0

    Private Sub txtFolio_GotFocus(sender As Object, e As EventArgs) Handles txtFolio.GotFocus


    End Sub

    Private Sub txtFolio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFolio.KeyPress
        If txtFolio.TextLength > 0 Then
            If Asc(e.KeyChar) = 13 Then
                e.Handled = True
                txtObservacion.Focus()
            End If
        End If

    End Sub

    Private Sub txtFolio_LostFocus(sender As Object, e As EventArgs) Handles txtFolio.LostFocus
        If txtFolio.TextLength > 0 Then
            If IsNumeric(txtFolio.Text) Then
                buscar_por_folio()
                txtFolio.Enabled = True
            Else
                MsgBox("Ingrese numero en el folio")
                txtFolio.Focus()

            End If

        End If

    End Sub

    Private Sub txtFolio_TextChanged(sender As Object, e As EventArgs) Handles txtFolio.TextChanged

    End Sub

    Private Sub txtObservacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObservacion.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            CBPago.Focus()



        End If
    End Sub

    Private Sub txtObservacion_TextChanged(sender As Object, e As EventArgs) Handles txtObservacion.TextChanged

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        buscarFOLIO()


    End Sub
    Private Sub buscarFOLIO()
        If IsNumeric(txtFolio.Text) Then
            If txtFolio.TextLength > 0 Then
                If CBPago.SelectedIndex >= 0 Then
                    buscar_por_folio()
                Else
                    MsgBox("Seleccionar primero el pago", MsgBoxStyle.Information)
                    CBPago.Focus()

                End If
            Else
                MsgBox("Ingrese primero Folio de Factura", MsgBoxStyle.Information)
                txtFolio.Focus()

            End If
        Else
            MsgBox("Ingrese folio numerio")
            txtFolio.Focus()
            txtFolio.Select(0, txtFolio.TextLength)
        End If



    End Sub
    Private Sub buscar_por_folio()

        Dim tool As New Herramienta
        Dim tablaResultado As New DataTable
        Dim consulta As String = ""

        Try

            consulta = "SELECT estado FROM factura WHERE idproveedor=" & lblid.Text & " AND folio='" & txtFolio.Text & "'"
            tablaResultado = tool.ObtenerTabla(consulta)

            If tablaResultado.Rows.Count > 0 Then

                MsgBox("Existe una factura con este folio registrado estado: " & tablaResultado.Rows(0).Item("estado"), MsgBoxStyle.Information)

                If tablaResultado.Rows(0).Item("estado") = "PENDIENTE" Then
                    Return
                Else
                    If MsgBox("Deseas continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                        txtFolio.Enabled = False
                        Botones.Enabled = True

                    End If
                End If

            Else

                txtFolio.Enabled = False
                Botones.Enabled = True

            End If
            If txtObservacion.TextLength <> 0 Then
                btnProducto.Focus()
            Else
                txtObservacion.Focus()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Buscar FOlio")
        End Try
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        lbltipo.Text = "PRO"
        txtNp.Clear()

        Info.Enabled = True
        Ncantidad.Value = 1
        Ncantidad.Focus()

    End Sub

    Private Sub btnServicio_Click(sender As Object, e As EventArgs) Handles btnServicio.Click
        lbltipo.Text = "SER"
        txtNp.Text = "SER"
        Info.Enabled = True
        Ncantidad.Value = 1
        Ncantidad.Focus()

    End Sub

    Private Sub btnDescuento_Click(sender As Object, e As EventArgs) Handles btnDescuento.Click
        lbltipo.Text = "DES"
        txtNp.Text = "DES"
        Info.Enabled = True
        Ncantidad.Value = 1
        Ncantidad.Focus()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim continuar As Boolean = False
        Dim tool As New Herramienta
        Dim tablaResultado As New DataTable
        Dim consulta As String = ""

        If Ncantidad.Value > 0 Then
            If txtNp.TextLength > 0 Then
                If txtDesc.TextLength > 0 Then
                    If NCosto.Value <> 0 Then
                        continuar = True


                    Else
                        If MsgBox("la Cantidad es Cero 0.00, ¿Deseas continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            continuar = True
                        End If

                    End If
                    If continuar Then
                        TablaDetalle.Rows.Add(Ncantidad.Value, txtNp.Text, txtDesc.Text, NCosto.Value, lbltipo.Text, (NCosto.Value * Ncantidad.Value), "Editar", "Eliminar", lblidNp.Text, tipo_a.Text, 1)
                        Info.Enabled = False
                        Ncantidad.Value = 0

                        txtDesc.Clear()
                        NCosto.Value = 0
                        If txtNp.Text <> "SER" Or txtNp.Text <> "ser" Then
                            btnProducto.Focus()
                        End If
                        If txtNp.Text = "SER" Then
                            btnServicio.Focus()
                        End If
                        txtNp.Clear()
                        lblidNp.Text = 0
                        tipo_a.Text = 0

                        Dim val_index As Integer = 0
                        If TablaDetalle.Rows.Count > 0 Then
                            val_index = TablaDetalle.Rows.Count - 1

                            If TablaDetalle.Rows(val_index).Cells("idnp").Value > 0 Then
                                Try

                                    consulta = "SELECT preguntar, cant_unidad FROM articulos_inventario WHERE id=" & TablaDetalle.Rows(val_index).Cells("idnp").Value

                                    tablaResultado = tool.ObtenerTabla(consulta)

                                    If tablaResultado.Rows.Count > 0 Then
                                        With tablaResultado.Rows(0)
                                            If .Item("cant_unidad") > 1 Or .Item("preguntar") = "si" Then
                                                FacturasAgregar_Cant.Dispose()
                                                FacturasAgregar_Cant.Ncant.Value = .Item("cant_unidad")
                                                index_tabla = val_index
                                                FacturasAgregar_Cant.ShowDialog()
                                            Else
                                                TablaDetalle.Rows(val_index).Cells("c_unidad").Value = .Item("cant_unidad")
                                            End If
                                        End With

                                    End If

                                Catch ex As Exception
                                    MsgBox(ex.Message, MsgBoxStyle.Information, "Agregar")
                                End Try

                            End If
                        End If

                        ultimo()
                    End If
                Else
                    MsgBox("Ingrese Descripcion", MsgBoxStyle.Information)
                    txtDesc.Focus()
                End If
            Else
                MsgBox("Ingrese NP", MsgBoxStyle.Information)
                txtNp.Focus()
            End If
        Else
            MsgBox("Ingrese Cantidad mayor a cero", MsgBoxStyle.Information)
            Ncantidad.Focus()

        End If

        SumarTotales()
        Cargar_INV()

    End Sub
    Private Sub ultimo()
        If TablaDetalle.Rows.Count > 0 Then
            TablaDetalle.CurrentCell = TablaDetalle.Item(1, (TablaDetalle.Rows.Count - 1))

            TablaDetalle.Rows(TablaDetalle.Rows.Count - 1).Selected = True
            TablaDetalle.FirstDisplayedScrollingRowIndex = TablaDetalle.RowCount - 1
            Dim celdaSelecionada As Integer = TablaDetalle.Rows.Count
        End If
    End Sub
    Public Sub SumarTotales()
        Dim cantidadSuma As Decimal = 0
        If TablaDetalle.Rows.Count > 0 Then
            For i = 0 To TablaDetalle.Rows.Count - 1
                With TablaDetalle.Rows(i)
                    .Cells("importe").Value = .Cells("cant").Value * .Cells("costo").Value
                    If lblClave.Text = "CON-IVA" Then

                        If .Cells("tipo").Value.ToString = "PRO" Then
                            cantidadSuma += .Cells("importe").Value.ToString
                        End If
                        If .Cells("tipo").Value.ToString = "SER" Then
                            cantidadSuma += .Cells("importe").Value.ToString
                        End If
                        If .Cells("tipo").Value.ToString = "DES" Then
                            cantidadSuma -= .Cells("importe").Value.ToString
                        End If

                        NSub.Value = cantidadSuma
                        NIva.Value = NSub.Value * vIva
                        NTotal.Maximum = (NSub.Value + NIva.Value) + 0.01
                        NTotal.Minimum = (NSub.Value + NIva.Value) - 0.01
                        NTotal.Value = NSub.Value + NIva.Value
                    Else
                        'SI ES NO
                        If .Cells("tipo").Value.ToString = "PRO" Then
                            cantidadSuma += .Cells("importe").Value.ToString
                        End If
                        If .Cells("tipo").Value.ToString = "SER" Then
                            cantidadSuma += .Cells("importe").Value.ToString
                        End If
                        If .Cells("tipo").Value.ToString = "DES" Then
                            cantidadSuma -= .Cells("importe").Value.ToString
                        End If
                        NSub.Value = cantidadSuma
                        'NIva.Value = NSub.Value * 0.16
                        NTotal.Value = NSub.Value + NIva.Value
                    End If


                End With
            Next

        Else
            NSub.Minimum = -1000000
            NIva.Minimum = -1000000
            NTotal.Minimum = 0
            NSub.Value = 0
            NIva.Value = 0
            NTotal.Value = 0
        End If
        lblcant.Text = TablaDetalle.Rows.Count
    End Sub

    Private Sub txtNp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNp.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            If txtNp.TextLength = 0 Then

            Else

                txtDesc.Focus()
            End If

        End If

    End Sub

    Private Sub txtNp_LostFocus(sender As Object, e As EventArgs) Handles txtNp.LostFocus

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable


        txtNp.Text = Replace(txtNp.Text, "'", "")
        txtNp.Text = Replace(txtNp.Text, Chr(34), "")
        ' en caso que no sea un invetario afectado}
        If txtNp.Text = "SER" Then
        Else

            Try

                If lblTitulo.Text = "Agregando Nota Cred." Then
                    consulta = "SELECT descripcion,costo FROM facturadetalle WHERE np='" & txtNp.Text & "' AND costo<0 ORDER BY id DESC LIMIT 1"
                Else
                    'factura
                    consulta = "SELECT descripcion,costo FROM facturadetalle WHERE np='" & txtNp.Text & "' AND costo>0 ORDER BY id DESC LIMIT 1"
                End If

                tablaResultado = tool.ObtenerTabla(consulta)

                If tablaResultado.Rows.Count > 0 Then

                    txtDesc.Text = tablaResultado.Rows(0).Item("descripcion")
                    NCosto.Value = tablaResultado.Rows(0).Item("costo")
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If
        txtDesc.Text = Replace(txtDesc.Text, "Y M/O", "")
        txtDesc.Text = Replace(txtDesc.Text, "M/O", "")
        txtDesc.Text = Replace(txtDesc.Text, Chr(34), "")


    End Sub

    Private Sub txtNp_TextChanged(sender As Object, e As EventArgs) Handles txtNp.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtFolio.TextLength > 0 And TablaDetalle.Rows.Count > 0 Then
            frmFacturas_Info.Dispose()
            With frmFacturas_Info
                .lblFolio.Text = txtFolio.Text
                .lblProveedor.Text = lblProveedor.Text
                .lblfecha.Text = fecha.Value.ToShortDateString
                .lblestado.Text = CBPago.Text
                .lbltotal.Text = FormatCurrency(NTotal.Value)

            End With

            frmFacturas_Info.ShowDialog()

        Else
            MsgBox("No hay articulo en la lista", MsgBoxStyle.Information)
            btnAgregar.Focus()
        End If
    End Sub
    Public Sub Guardar()
        Dim continuar As Boolean = False
        Dim valores As String = ""
        Dim idFactura As Integer = 0
        Dim cant_unidad As Integer = 1
        Dim valores_pago As String = ""
        Dim reg_inventario As Integer
        frmServicio_Info.Dispose()
        Dim idpago As Integer = 0
        Dim c As Integer

        Dim tool As New Herramienta
        Dim tablaResultado As New DataTable
        Dim transaccionActualizar As MySql.Data.MySqlClient.MySqlTransaction = Nothing
        Dim consulta As String = ""
        Dim comando As New MySql.Data.MySqlClient.MySqlCommand

        If txtFolio.TextLength > 0 And TablaDetalle.Rows.Count > 0 Then
            If NTotal.Value <> 0 Then
            Else
                MsgBox("El total debe ser diferente de cero", MsgBoxStyle.Information)
                Exit Sub

            End If

            If pago_panel.Visible = True Then
                If CBMetodo.SelectedIndex >= 0 Then
                    continuar = True
                Else
                    continuar = False
                    MsgBox("Selecione un metodo de pago", MsgBoxStyle.Information)
                    CBMetodo.Focus()
                End If
            End If
            If lblTitulo.Text = "Agregando Nota Cred." Then
                If lblIdRelacion.Text = 0 Then
                    If MessageBox.Show("No existe una factura relacionada a esta Nota de credito, ¿Desea continuar?", "Nota de credito", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Else
                        Exit Sub

                    End If


                End If
            End If
            ''comprobando entrada de inventario
            frmAviso.Dispose()
            For i = 0 To TablaDetalle.Rows.Count - 1
                With TablaDetalle.Rows(i)
                    If .Cells("idnp").Value <> 0 Then

                        frmAviso.tabla.Rows.Add(.Cells("cant").Value & "  X " & .Cells("c_unidad").Value & " = " & (.Cells("cant").Value * .Cells("c_unidad").Value), .Cells("desc").Value, " se sumarán" & (.Cells("cant").Value * .Cells("c_unidad").Value) & " MÁS ")

                        c += 1
                        If .Cells("idnp").Value <> 0 Then
                            frmAviso.tabla.Rows(c - 1).Cells("cant").Style.BackColor = Color.YellowGreen
                            frmAviso.tabla.Rows(c - 1).Cells("desc").Style.BackColor = Color.YellowGreen

                        End If


                    End If
                End With
            Next
            If frmAviso.tabla.Rows.Count > 0 Then
                frmAviso.ShowDialog()
                If frmAviso.btnCLose.Text = "cancelar" Then
                    Exit Sub

                End If
            End If



            If pago_panel.Visible = False Then
                continuar = True

            End If
            If continuar Then

                Try

                    comando.Connection = New MySql.Data.MySqlClient.MySqlConnection
                    comando.Connection.ConnectionString = con.ConnectionString
                    comando.Connection.Open()

                    transaccionActualizar = comando.Connection.BeginTransaction
                    comando.Transaction = transaccionActualizar

                    consulta = "SELECT estado FROM factura WHERE idproveedor=" & lblid.Text & " AND estado='PENDIENTE' AND folio='" & txtFolio.Text & "'"
                    tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                    If tablaResultado.Rows.Count > 0 Then
                        continuar = False
                        MsgBox("Existe una factura con este folio registrado", MsgBoxStyle.Information)
                        If MsgBox("Deseas continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            continuar = True
                            panelFolio.Enabled = False
                            Botones.Enabled = True
                            btnProducto.Focus()
                        End If
                    Else
                        continuar = True
                    End If

                    If CBPago.Text <> "PAGADO" Then
                        'para confirmar saldo al proveedor
                        If MsgBox("¿Deseas Agregar Saldo a: " & lblProveedor.Text & " ?", MsgBoxStyle.YesNo) = vbYes Then
                            continuar = True
                        Else
                            continuar = False
                        End If
                    End If

                    If continuar Then
                        'inicio de transaccion

                        valores = ""
                        valores &= "'" & txtFolio.Text & "',"
                        valores &= lblid.Text & ","
                        valores &= "'" & lblProveedor.Text & "',"
                        valores &= "'" & Format(fecha.Value, "yyyy/MM/dd") & "',"
                        valores &= NSub.Value & ","
                        valores &= NIva.Value & ","
                        valores &= NTotal.Value & ","
                        valores &= "'" & txtObservacion.Text & "',"
                        valores &= "'" & MDIPrincipal.lblUser.Text & "',"
                        valores &= MDIPrincipal.lblidUser.Text & ","
                        valores &= "'" & CBPago.Text & "',"
                        valores &= lblIdRelacion.Text & ","
                        valores &= "'" & lblfoliofac.Text & "',"
                        If CBPago.Text = "PAGADO" Then
                            valores &= "0," & NTotal.Value
                        Else
                            valores &= NTotal.Value & ", 0"
                        End If


                        consulta = "INSERT INTO factura (folio,idproveedor,proveedor,fecha,subtotal,iva,total,observacion,usuario,id_usuario,estado,idfac_relacion,foliofac_relacion, saldopendiente, saldopagado) VALUES (" & valores & ")"

                        If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then

                            If pago_panel.Visible = True Then
                                valores_pago = ""
                                valores_pago &= "'" & Format(fechapago.Value, "yyyy/MM/dd") & "',"
                                valores_pago &= "'" & txtobser_pago.Text & "',"
                                valores_pago &= lblid.Text & ","
                                valores_pago &= "'" & lblProveedor.Text & "',"
                                valores_pago &= NTotal.Value & ","
                                valores_pago &= "'" & CBMetodo.Text & "',"
                                valores_pago &= MDIPrincipal.lblidUser.Text & ","
                                valores_pago &= "'" & MDIPrincipal.lblUser.Text & "'"

                                consulta = "INSERT INTO facturas_pagos (fecha,observacion,idproveedor,proveedor,total,metodo,iduser,user) values (" & valores_pago & ")"

                                If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then

                                Else
                                    Throw New Exception("no se pudo insertar el pago")
                                End If

                            End If

                            consulta = "SELECT max(id) FROM factura"

                            tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                            If tablaResultado.Rows.Count > 0 Then
                                idFactura = tablaResultado.Rows(0).Item(0)
                            Else
                                Throw New Exception("no se pudo obtener el id de factura")
                            End If

                            consulta = "SELECT max(folio) FROM facturas_pagos"
                            tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                            If tablaResultado.Rows.Count > 0 Then
                                idpago = tablaResultado.Rows(0).Item(0)
                            Else
                                Throw New Exception("no se obtuvo el folio de pago")
                            End If

                            If pago_panel.Visible = True Then
                                consulta = "UPDATE factura SET fechapago=" & "'" & Format(fechapago.Value, "yyyy/MM/dd") & "',idpago=" & idpago & " WHERE id=" & idFactura

                                If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                                Else
                                    Throw New Exception("no se actualizo los datos de pago")
                                End If

                            End If

                            For a = 0 To TablaDetalle.Rows.Count - 1
                                frmServicio_Info.lblestado.Text = "GUARDADO"
                                frmServicio_Info.lblFolio.Text = txtFolio.Text
                                '## ENCABEZADO DE INFO
                                Dim cantidad_inv As Decimal = 0
                                Dim idDetalleCandelado As String = "0"

                                If TablaDetalle.Rows(a).Cells("id_det").Value IsNot Nothing Then
                                    idDetalleCandelado = TablaDetalle.Rows(a).Cells("id_det").Value
                                End If

                                valores = ""
                                valores &= idFactura & ","
                                valores &= "'" & txtFolio.Text & "',"
                                valores &= lblid.Text & ","
                                valores &= "'" & lblProveedor.Text & "',"
                                valores &= "'" & Format(fecha.Value, "yyyy/MM/dd") & "',"
                                With TablaDetalle.Rows(a)
                                    valores &= .Cells("cant").Value.ToString & ","
                                    valores &= "'" & .Cells("np").Value.ToString & "',"
                                    valores &= "'" & .Cells("desc").Value.ToString & "',"
                                    valores &= .Cells("costo").Value.ToString & ","
                                    valores &= "'" & txtObservacion.Text & "',"
                                    valores &= "'" & .Cells("tipo").Value.ToString & "',"
                                    valores &= .Cells("idnp").Value.ToString & ","
                                    valores &= .Cells("c_unidad").Value.ToString & ","
                                    valores &= vIva & ","
                                    valores &= idDetalleCandelado
                                End With

                                consulta = "INSERT INTO facturadetalle (idfactura,folio,idproveedor,proveedor,fecha,cant,np,descripcion,costo,observacion,tipo,idnp_inv,cant_unidad, iva, id_detallecancelado) VALUES (" & valores & ")"

                                If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                                    If TablaDetalle.Rows(a).Cells("idnp").Value.ToString <> 0 Then 'SI VA AFECTAR UN NP DEL INVETARIO
                                        consulta = "SELECT cantidad,cant_unidad FROM articulos_inventario WHERE id=" & TablaDetalle.Rows(a).Cells("idnp").Value.ToString

                                        tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                        Dim cant_inv_anterior As Integer
                                        If tablaResultado.Rows.Count > 0 Then

                                            cantidad_inv = tablaResultado.Rows(0).Item("cantidad")
                                            reg_inventario = cantidad_inv
                                            cant_inv_anterior = tablaResultado.Rows(0).Item("cantidad")
                                            cant_unidad = TablaDetalle.Rows(a).Cells("c_unidad").Value

                                        End If
                                        If Not TablaDetalle.Rows(a).Cells("tipo").Value = "DES" Then

                                            If lblTitulo.Text = "Agregando Factura" Then
                                                If TablaDetalle.Rows(a).Cells("tipo_art").Value = "SERVICIO" Or TablaDetalle.Rows(a).Cells("tipo_art").Value = "0" Then
                                                    cantidad_inv = cantidad_inv
                                                Else
                                                    cantidad_inv += (TablaDetalle.Rows(a).Cells("cant").Value * cant_unidad)
                                                End If


                                            Else
                                                If TablaDetalle.Rows(a).Cells("tipo_art").Value = "SERVICIO" Or TablaDetalle.Rows(a).Cells("tipo_art").Value = "0" Then
                                                    cantidad_inv = cantidad_inv
                                                Else
                                                    cantidad_inv -= (TablaDetalle.Rows(a).Cells("cant").Value * cant_unidad)
                                                End If


                                            End If
                                        End If

                                        'cantidad_inv = cantidad_inv * cant_unidad

                                        consulta = "UPDATE articulos_inventario SET cantidad=" & cantidad_inv & " WHERE id=" & TablaDetalle.Rows(a).Cells("idnp").Value.ToString

                                        If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                                            With TablaDetalle.Rows(a)
                                                If .Cells("tipo_art").Value = "SERVICIOS" Or TablaDetalle.Rows(a).Cells("tipo_art").Value = "0" Then

                                                    frmServicio_Info.tabla_articulos.Rows.Add(0 & " *SER", .Cells("np").Value.ToString, .Cells("DESC").Value, cantidad_inv)

                                                Else
                                                    frmServicio_Info.tabla_articulos.Rows.Add(.Cells("cant").Value & " X " & .Cells("c_unidad").Value, .Cells("np").Value.ToString, .Cells("DESC").Value, cantidad_inv)
                                                End If

                                                tool.Insertar_Movimiento_ModuloTransaccion("FACTURA", txtFolio.Text, idFactura, .Cells("idnp").Value.ToString, .Cells("np").Value, tipo_movimiento, .Cells("tipo_art").Value, (TablaDetalle.Rows(a).Cells("cant").Value * cant_unidad), DateTime.Today, .Cells("DESC").Value, cant_inv_anterior, cantidad_inv, lblid.Text, lblProveedor.Text, .Cells("c_unidad").Value, motivo, transaccionActualizar)

                                                'limpiar el campo de id_inv del detaller si es nota
                                                If lblTitulo.Text = "Agregando Factura" Then
                                                Else
                                                    If .Cells("id_det").Value > 0 Then
                                                        consulta = "UPDATE facturadetalle SET idnp_inv=0 WHERE id=" & .Cells("id_det").Value
                                                        If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                                                        Else
                                                            Throw New Exception("no se pudo actualizar detalle con inventario")
                                                        End If

                                                    End If

                                                End If

                                            End With


                                        End If
                                    End If


                                    If a = TablaDetalle.Rows.Count - 1 Then
                                        transaccionActualizar.Commit()
                                        If frmServicio_Info.tabla_articulos.Rows.Count > 0 Then
                                            frmServicio_Info.ShowDialog()
                                        End If


                                        Me.Close()
                                        Facturas.Mostrar_ultimo_agregados()

                                    End If
                                End If
                            Next

                        End If

                    End If

                Catch ex As Exception
                    If transaccionActualizar IsNot Nothing Then
                        If transaccionActualizar.Connection IsNot Nothing Then
                            transaccionActualizar.Rollback()
                        End If

                    End If
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    Me.Close()

                End Try

            End If
        End If






    End Sub

    Private Sub CBPago_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBPago.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            btnAceptar.PerformClick()



        End If
    End Sub

    Private Sub CBPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPago.SelectedIndexChanged
        If CBPago.Text = "PAGADO" Then
            pago_panel.Show()
        Else
            pago_panel.Hide()

        End If
        fechapago.Value = fecha.Value
    End Sub


    Private Sub NSub_ValueChanged(sender As Object, e As EventArgs) Handles NSub.ValueChanged
        NSub.ReadOnly = True

    End Sub

    Private Sub Ncantidad_GotFocus(sender As Object, e As EventArgs) Handles Ncantidad.GotFocus
        Ncantidad.Select(0, 1000)

    End Sub

    Private Sub Ncantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Ncantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            txtNp.Focus()
        End If
    End Sub

    Private Sub Ncantidad_ValueChanged(sender As Object, e As EventArgs) Handles Ncantidad.ValueChanged

    End Sub

    Private Sub txtDesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            NCosto.Focus()
        End If
    End Sub

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles txtDesc.TextChanged

    End Sub

    Private Sub NCosto_GotFocus(sender As Object, e As EventArgs) Handles NCosto.GotFocus
        NCosto.Select(0, 10000)

    End Sub

    Private Sub NCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NCosto.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            btnAgregar.PerformClick()

        End If
    End Sub

    Private Sub Cargar_INV()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        panel_inv.Hide()
        If TablaDetalle.Rows.Count > 0 Then
            Dim i As Integer = TablaDetalle.CurrentRow.Index

            If i <= -1 Then
                Return
            End If

            Try

                consulta = "SELECT id,descripcion,cantidad from articulos_inventario where id=" & TablaDetalle.Rows(i).Cells("idnp").Value

                tablaResultado = tool.ObtenerTabla(consulta)

                If tablaResultado.Rows.Count > 0 Then
                    panel_inv.Show()

                    lbldesc.Text = tablaResultado.Rows(0).Item("descripcion")
                    lblCant_Inv.Text = tablaResultado.Rows(0).Item("cantidad")
                Else
                    panel_inv.Hide()
                    lbldesc.Text = ""
                    lblCant_Inv.Text = ""
                End If
            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub TablaDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaDetalle.CellContentClick
        If TablaDetalle.Rows.Count > 0 Then
            Dim i As Integer = TablaDetalle.CurrentRow.Index
            Dim nombreColumna As String = ""
            nombreColumna = TablaDetalle.Columns.Item(e.ColumnIndex).Name.ToString
            If nombreColumna = "eliminar" Then
                If MsgBox("¿Quieres Eliminar el renglon: " & TablaDetalle.Rows(i).Cells("desc").Value, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    TablaDetalle.Rows.RemoveAt(i)
                    SumarTotales()

                End If
            End If
            If nombreColumna = "editar" Then
                With FacturasAgregarEdit
                    .lblindex.Text = i
                    .Ncantidad.Value = TablaDetalle.Rows(i).Cells("cant").Value
                    .txtNp.Text = TablaDetalle.Rows(i).Cells("np").Value
                    .txtDesc.Text = TablaDetalle.Rows(i).Cells("desc").Value
                    .NCosto.Value = TablaDetalle.Rows(i).Cells("costo").Value
                    .ShowDialog()
                    SumarTotales()
                End With

            End If

        End If

    End Sub

    Private Sub FacturasAgregar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        For Each Todaventana As Form In Me.MdiChildren
            If Todaventana.Name = "facturas" Then
            Else
                Todaventana.Close()
            End If

        Next
        Facturas.MdiParent = MDIPrincipal
        Facturas.Show()
        Facturas.WindowState = FormWindowState.Normal


        Facturas.SelectUltimo()



    End Sub

    Private Sub FacturasAgregar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("¿Deseas Cerrar esta Ventana", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
        If e.KeyCode = Keys.F5 Then
            abrir_inventario()
        End If
    End Sub

    Private Sub FacturasAgregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.Manual
        Me.Top = 0
        Me.ControlBox = False
        NSub.Controls(0).Hide()
        NIva.Controls(0).Hide()
        estructura_ventana(Me)
        NSub.Controls(0).Hide()
        NIva.Controls(0).Hide()
        lblPorcentajeIva.Text = " (" & CInt(vIva * 100).ToString & " %)  IVA:"
        If lblTitulo.Text = "Agregando Nota Cred." Then
            CBPago.SelectedItem = "PENDIENTE"
            tipo_movimiento = "SALIDA"
            motivo = "NOTA DE CREDITO"
            tipo_doc = "FACTURAS-NOTACRED"
        Else
            tipo_movimiento = "ENTRADA"
            motivo = "COMPRA"
            tipo_doc = "FACTURAS"
        End If

        ' NTotal.Controls(0).Hide()

    End Sub
    Public Sub activar_tiempo()
        tiempoNota.Start()
    End Sub

    Private Sub FacturasAgregar_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        fecha.Focus()
        Me.StartPosition = FormStartPosition.Manual
        Me.Top = 0
        Me.ControlBox = False
        Me.MaximizeBox = False
        estructura_ventana(Me)
        NSub.Controls(0).Hide()
        NIva.Controls(0).Hide()
        ' NTotal.Controls(0).Hide()
    End Sub

    Private Sub fecha_GotFocus(sender As Object, e As EventArgs) Handles fecha.GotFocus
        FechaPanel.BackColor = Color.Yellow

    End Sub

    Private Sub fecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles fecha.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            comprobar_fecha()



        End If
    End Sub
    Private Sub comprobar_fecha()
        Dim hoy As Date = Date.Now.ToLongDateString
        If fecha.Value.ToShortDateString > hoy Then
            'MsgBox("Ingrese fecha actual o anterior " & fecha.Value.ToShortDateString, MsgBoxStyle.Information)
            fecha.Focus()
        Else
            txtFolio.Focus()
        End If
    End Sub

    Private Sub fecha_LostFocus(sender As Object, e As EventArgs) Handles fecha.LostFocus
        If Me.Visible = True Then
            comprobar_fecha()
        End If
        FechaPanel.BackColor = Color.White
    End Sub
    Private Sub fecha_ValueChanged(sender As Object, e As EventArgs) Handles fecha.ValueChanged

    End Sub

    Private Sub btnInventario_Click(sender As Object, e As EventArgs) Handles btnInventario.Click
        abrir_inventario()
    End Sub
    Private Sub abrir_inventario()
        FrmFacturasAgregar_INV.Dispose()
        lblidNp.Text = 0
        FrmFacturasAgregar_INV.ShowDialog()
        If txtDesc.TextLength > 0 Then
            NCosto.Focus()
        End If
    End Sub

    Private Sub cambiar_color1(sender As Object, e As EventArgs) Handles txtObservacion.Enter, txtFolio.Enter, CBPago.Enter
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub regresar_color1(sender As Object, e As EventArgs) Handles txtObservacion.Leave, txtFolio.Leave, CBPago.Leave
        sender.BackColor = Color.White
    End Sub

    Private Sub cambiar_color2(sender As Object, e As EventArgs) Handles btnServicio.Enter, btnProducto.Enter, btnDescuento.Enter
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub cambiar_foco3(sender As Object, e As EventArgs) Handles txtNp.Enter, txtDesc.Enter, NCosto.Enter, Ncantidad.Enter
        sender.BackColor = Color.Yellow
    End Sub

    Private Sub regresar_color3(sender As Object, e As EventArgs) Handles txtNp.Leave, txtDesc.Leave, NCosto.Leave, Ncantidad.Leave
        sender.BackColor = Color.White

    End Sub

    Private Sub regresar_color2(sender As Object, e As EventArgs) Handles btnServicio.Leave, btnProducto.Leave, btnDescuento.Leave
        sender.BackColor = Color.White
    End Sub

    Private Sub txtDesc_LostFocus(sender As Object, e As EventArgs) Handles txtDesc.LostFocus
        txtDesc.Text = Replace(txtDesc.Text, "'", "")
        txtDesc.Text = Replace(txtDesc.Text, Chr(34), "")
    End Sub

    Private Sub txtObservacion_LostFocus(sender As Object, e As EventArgs) Handles txtObservacion.LostFocus
        txtObservacion.Text = Replace(txtObservacion.Text, "'", "")
        txtObservacion.Text = Replace(txtObservacion.Text, Chr(34), "")
    End Sub


    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.StartPosition = FormStartPosition.Manual
        Me.Top = 50
        Me.ControlBox = False
    End Sub


    Private Sub tiempoNota_Tick(sender As Object, e As EventArgs) Handles tiempoNota.Tick
        t += 1
        If t = 4 Then
            FacturasNotaDetalle.Dispose()
            FacturasNotaDetalle.ShowDialog()
            tiempoNota.Stop()
            t = 0
        End If
    End Sub

    Private Sub TablaDetalle_KeyDown(sender As Object, e As KeyEventArgs) Handles TablaDetalle.KeyDown

        If e.KeyCode = Keys.Enter Then
            If TablaDetalle.Rows.Count > 0 Then
                Dim i As Integer = TablaDetalle.CurrentRow.Index
                Dim nombreColumna As String = ""
                FacturasAgregarEdit.Dispose()


                With FacturasAgregarEdit
                    .lblindex.Text = i
                    .Ncantidad.Value = TablaDetalle.Rows(i).Cells("cant").Value
                    .txtNp.Text = TablaDetalle.Rows(i).Cells("np").Value
                    .txtDesc.Text = TablaDetalle.Rows(i).Cells("desc").Value
                    .NCosto.Value = TablaDetalle.Rows(i).Cells("costo").Value
                    .ShowDialog()


                    SumarTotales()
                End With



            End If
        End If


    End Sub

    Private Sub TablaDetalle_SelectionChanged(sender As Object, e As EventArgs) Handles TablaDetalle.SelectionChanged
        Cargar_INV()
    End Sub

    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click
        Facturas.Mostrar_ultimo_agregados()
    End Sub

    Private Sub NCosto_LostFocus(sender As Object, e As EventArgs) Handles NCosto.LostFocus
        If sender.Controls.Item(1).Text = "" Then
            sender.Controls.Item(1).Text = 0
        End If
    End Sub

    Private Sub Ncantidad_LostFocus(sender As Object, e As EventArgs) Handles Ncantidad.LostFocus
        If sender.Controls.Item(1).Text = "" Then
            sender.Controls.Item(1).Text = 0
        End If
    End Sub

    Private Sub NTotal_LostFocus(sender As Object, e As EventArgs) Handles NTotal.LostFocus
        If sender.Controls.Item(1).Text = "" Then
            sender.Controls.Item(1).Text = 0
        End If
    End Sub

    Private Sub NTotal_ValueChanged(sender As Object, e As EventArgs) Handles NTotal.ValueChanged

    End Sub
End Class