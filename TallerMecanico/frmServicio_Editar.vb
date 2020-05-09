Imports Spire.Xls
Public Class frmServicio_Editar

    Private Sub frmServicio_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estructura_ventana(Me)

        Cargar_Titulo()
        cargar_detalle()
        Dim ver_panel As Boolean
        Dim ver_boton As Boolean

        If tablaEliminados.Rows.Count = 0 Then

            If TablaPiezas.Rows.Count > 0 Then
                For i = 0 To TablaPiezas.Rows.Count - 1

                    With TablaPiezas.Rows(i)
                        If .Cells("id_inv").Value = 0 And .Cells("realizado").Value = "PENDIENTE" Then
                            ver_boton = True
                            ver_panel = True

                        Else

                            If .Cells("id_inv").Value = 0 Or .Cells("realizado").Value = "PENDIENTE" Then
                                ver_panel = True

                                Exit Sub
                            End If

                            ver_boton = False
                            Exit Sub

                        End If
                    End With
                Next
            End If

        End If
        If ver_boton Then
            btnNoreal.Show()
        End If
        If ver_panel Then
            P_NOREAL.Show()
        End If
        'CBCotizar.SelectedIndex = 0
    End Sub
    Private Sub Cargar_Titulo()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Try

            consulta = "SELECT * FROM servicios WHERE id=" & NFolio.Value
            tablaResultado = tool.ObtenerTabla(consulta)
            If tablaResultado.Rows.Count > 0 Then
                With tablaResultado.Rows(0)
                    lblNuevo.Text = .Item("nuevo")
                    lblAnterior.Text = .Item("anterior")
                    lblMarca.Text = .Item("marca")
                    lblaño.Text = .Item("year")

                    lblID.Text = .Item("ncamion")
                    txtObservacion.Text = .Item("para")
                    lblcot.Text = .Item("numero")
                    txtKM.Text = .Item("km")
                    CBEstado.Text = .Item("estado")
                    CBCotizar.SelectedItem = .Item("cotizar")
                    txtOC.Text = .Item("OC")
                    Nprecio.Value = .Item("valor")
                    lblfecha.Text = FormatDateTime(.Item("fecha"), DateFormat.ShortDate)
                End With
            Else
                Throw New Exception("no se pudo obtener la informacion principal del servicio ")

            End If

            consulta = "SELECT modelo FROM autos where id=" & lblID.Text
            tablaResultado = tool.ObtenerTabla(consulta)
            If tablaResultado.Rows.Count Then
                lblmodelo.Text = tablaResultado.Rows(0).Item("modelo")
            Else
                Throw New Exception("no se pudo obtener el modelo del auto/camion")

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Me.Close()
        End Try
    End Sub
    Private Sub cargar_detalle()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Try

            consulta = "SELECT * FROM servicios_detalle WHERE folio=" & NFolio.Value
            tablaResultado = tool.ObtenerTabla(consulta)
            TablaPiezas.Rows.Clear()

            If tablaResultado.Rows.Count > 0 Then
                For Each xRow As DataRow In tablaResultado.Rows
                    TablaPiezas.Rows.Add(xRow.Item("id"), xRow.Item("idpieza"), xRow.Item("np"), xRow.Item("tipo"), xRow.Item("descripcion"), xRow.Item("cant"), xRow.Item("id_inv"), xRow.Item("costo"), xRow.Item("precio"), xRow.Item("mano"), xRow.Item("cant"), xRow.Item("MARCADO"))
                Next

            End If
            Mostrar_INV()
            lblcant.Text = TablaPiezas.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        Calcular()
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        For i = 0 To MDIPrincipal.MdiChildren.Length - 1
            If MDIPrincipal.MdiChildren(i).Name = "frmServicio" Then
                MDIPrincipal.MdiChildren(i).WindowState = FormWindowState.Normal
                MDIPrincipal.MdiChildren(i).MaximizeBox = False
            End If
        Next
  
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        frmServicioAgregarSelect.Dispose()

        frmServicioAgregarSelect.txtInfoMarca.Text = lblMarca.Text
        frmServicioAgregarSelect.txtInfoModelo.Text = lblmodelo.Text
        frmServicioAgregarSelect.txtInfoAño.Text = lblaño.Text
        frmServicioAgregarSelect.lbltipo.Text = "PIEZA"
        frmServicioAgregarSelect.ventana.Text = "EDITAR"
        frmServicioAgregarSelect.ShowDialog()
        seleccionar_ultimo()
        Calcular()
    End Sub
    Public Sub seleccionar_ultimo()
        If TablaPiezas.Rows.Count > 0 Then
            TablaPiezas.Rows(TablaPiezas.Rows.Count - 1).Selected = True
            TablaPiezas.FirstDisplayedScrollingRowIndex = TablaPiezas.RowCount - 1
            Dim celdaSelecionada As Integer = TablaPiezas.Rows.Count
            TablaPiezas.CurrentCell = TablaPiezas.Item(2, celdaSelecionada - 1)
            celdaSelecionada = TablaPiezas.GetCellCount(DataGridViewElementStates.Selected)
            Mostrar_INV()
            If lblNuevo.Text = "VARIOS" Then
                If frmServicioAgregarSelect.editar_renglon Then
                    btnEditar.PerformClick()
                End If


            End If



        End If
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If TablaPiezas.Rows.Count > 0 Then
            Dim i As Integer = TablaPiezas.CurrentRow.Index

            If MsgBox("¿deseas eliminar " & TablaPiezas.Rows(i).Cells("desc").Value & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If TablaPiezas.Rows(i).Cells("iddetalle").Value <> 0 Then
                    If TablaPiezas.Rows(i).Cells("tipo").Value = "ARTICULO" Then
                        tablaEliminados.Rows.Add(TablaPiezas.Rows(i).Cells("iddetalle").Value, TablaPiezas.Rows(i).Cells("desc").Value, TablaPiezas.Rows(i).Cells("cant").Value, TablaPiezas.Rows(i).Cells("id_inv").Value, TablaPiezas.Rows(i).Cells("tipo").Value)

                    End If
                    If TablaPiezas.Rows(i).Cells("tipo").Value = "PACK" Then
                        tablaEliminados.Rows.Add(TablaPiezas.Rows(i).Cells("iddetalle").Value, TablaPiezas.Rows(i).Cells("desc").Value, TablaPiezas.Rows(i).Cells("cant").Value, TablaPiezas.Rows(i).Cells("id").Value, TablaPiezas.Rows(i).Cells("tipo").Value)
                    End If
                    If TablaPiezas.Rows(i).Cells("tipo").Value = "SERVICIO" Then
                        tablaEliminados.Rows.Add(TablaPiezas.Rows(i).Cells("iddetalle").Value, TablaPiezas.Rows(i).Cells("desc").Value, TablaPiezas.Rows(i).Cells("cant").Value, TablaPiezas.Rows(i).Cells("id").Value, TablaPiezas.Rows(i).Cells("tipo").Value)
                    End If

                End If

                TablaPiezas.Rows.RemoveAt(i)
                ' CalcularTotal()
            End If
        End If
        Calcular()
    End Sub
    


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        ActualizarServicio()
    End Sub
    Private Function CompararRegistros(xRowDetalle As DataGridViewRow, transaccionActualizar As MySql.Data.MySqlClient.MySqlTransaction) As Boolean

        Dim IdDetalle As Integer = 0
        Dim consulta As String = ""
        Dim tool As New Herramienta
        Dim tablaResultado As New DataTable

        Dim idpiezaAnterior As Integer
        Dim npAnterior As String
        Dim descripcionAnterior As String
        Dim cantidadAnterior As Integer
        Dim PrecioAnterior As Double
        Dim manoAnterior As Double
        Dim costoAnterior As Double
        Dim marcadoAnterior As String
        Dim id_invAnterior As Integer
        Const InsertDetalleText As String = "INSERT INTO servicios_detallemodificado (campo, valoranterior, valornuevo,idusuario, fecharegistro, idservicio, iddetalle) VALUES "

        Integer.TryParse(xRowDetalle.Cells("iddetalle").Value.ToString, IdDetalle)

        If NFolio.Value = 0 Then
            Throw New Exception("El numero del folio debe ser mayor a cero")
        End If

        If IdDetalle > 0 Then
            consulta = "SELECT idpieza, np, descripcion, cant, precio, mano, costo, MARCADO, id_inv FROM servicios_detalle WHERE id=" & IdDetalle

            tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

            If tablaResultado.Rows.Count > 0 Then
                With tablaResultado.Rows(0)
                    idpiezaAnterior = .Item("idpieza")
                    npAnterior = .Item("np")
                    descripcionAnterior = .Item("descripcion")
                    cantidadAnterior = .Item("cant")
                    PrecioAnterior = .Item("precio")
                    manoAnterior = .Item("mano")
                    costoAnterior = .Item("costo")
                    marcadoAnterior = .Item("MARCADO")
                    id_invAnterior = .Item("id_inv")
                End With
            End If
            'comparar
            If tablaResultado.Rows.Count > 0 Then
                'obtuvo datos a comparar
                With xRowDetalle
                    consulta = ""
                    Dim IdUserMdi As Integer = 0
                    Integer.TryParse(MDIPrincipal.lblidUser.Text, IdUserMdi)
                    If .Cells(id.Name).Value <> idpiezaAnterior Then
                        consulta = InsertDetalleText & "('IdPieza','" & idpiezaAnterior & "','" & .Cells(id.Name).Value.ToString & "', " & IdUserMdi & ", '" & Format(fecha.Value, "yyyy/MM/dd") & "', " & NFolio.Value & ", " & IdDetalle & "); "
                    End If
                    If .Cells(np.Name).Value <> npAnterior Then
                        consulta &= InsertDetalleText & "('np','" & npAnterior & "','" & .Cells(np.Name).Value.ToString & "', " & IdUserMdi & ", '" & Format(fecha.Value, "yyyy/MM/dd") & "', " & NFolio.Value & ", " & IdDetalle & "); "
                    End If
                    If .Cells(desc.Name).Value <> descripcionAnterior Then
                        consulta &= InsertDetalleText & " ('descripcion','" & descripcionAnterior & "','" & .Cells(desc.Name).Value.ToString & "', " & IdUserMdi & ", '" & Format(fecha.Value, "yyyy/MM/dd") & "', " & NFolio.Value & ", " & IdDetalle & "); "
                    End If
                    If .Cells(cant.Name).Value <> cantidadAnterior Then
                        consulta &= InsertDetalleText & " ('cantidad','" & cantidadAnterior & "','" & .Cells(cant.Name).Value.ToString & "', " & IdUserMdi & ", '" & Format(fecha.Value, "yyyy/MM/dd") & "', " & NFolio.Value & ", " & IdDetalle & " ); "
                    End If
                    If .Cells(precio.Name).Value <> PrecioAnterior Then
                        consulta &= InsertDetalleText & "('precio','" & PrecioAnterior & "','" & .Cells(precio.Name).Value.ToString & "', " & IdUserMdi & ", '" & Format(fecha.Value, "yyyy/MM/dd") & "', " & NFolio.Value & ", " & IdDetalle & " ); "
                    End If
                    If .Cells(mano.Name).Value <> manoAnterior Then
                        consulta &= InsertDetalleText & "('mano','" & manoAnterior & "','" & .Cells(mano.Name).Value.ToString & "', " & IdUserMdi & ", '" & Format(fecha.Value, "yyyy/MM/dd") & "', " & NFolio.Value & ", " & IdDetalle & " ); "
                    End If
                    If .Cells(costo.Name).Value <> costoAnterior Then
                        consulta &= InsertDetalleText & "('costo','" & costoAnterior & "','" & .Cells(costo.Name).Value.ToString & "', " & IdUserMdi & ", '" & Format(fecha.Value, "yyyy/MM/dd") & "', " & NFolio.Value & ", " & IdDetalle & "); "
                    End If
                    If .Cells(realizado.Name).Value <> marcadoAnterior Then
                        consulta &= InsertDetalleText & "('marcado','" & marcadoAnterior & "','" & .Cells(realizado.Name).Value.ToString & "', " & IdUserMdi & ", '" & Format(fecha.Value, "yyyy/MM/dd") & "', " & NFolio.Value & ", " & IdDetalle & " ); "
                    End If
                    If .Cells(id_inv.Name).Value <> id_invAnterior Then
                        consulta &= InsertDetalleText & "('InventarioID','" & id_invAnterior & "','" & .Cells(id_inv.Name).Value.ToString & "', " & IdUserMdi & ", '" & Format(fecha.Value, "yyyy/MM/dd") & "', " & NFolio.Value & ", " & IdDetalle & " ); "
                    End If
                    If consulta <> "" Then
                        If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                            Return True
                        Else
                            Return False
                        End If
                    End If
                End With
            End If
        End If
        Return False
    End Function

    Private Sub ActualizarServicio()

        frmServicio_Info.tabla_articulos.Rows.Clear()
        frmAviso.Dispose()
        Dim c As Integer
        Dim cant_dif_rev As Integer
        If TablaPiezas.Rows.Count > 0 Then
            For i = 0 To TablaPiezas.Rows.Count - 1
                With TablaPiezas.Rows(i)
                    If .Cells("id_inv").Value <> 0 And (.Cells("cantactual").Value = 0 Or .Cells("cantactual").Value <> .Cells("cant").Value) Or .Cells("realizado").Value = "REAL" Then
                        frmAviso.tabla.Rows.Add(.Cells("cant").Value, .Cells("desc").Value, .Cells("realizado").Value)
                        c += 1
                        cant_dif_rev = TablaPiezas.Rows(i).Cells("cantActual").Value - TablaPiezas.Rows(i).Cells("cant").Value
                        If .Cells("id_inv").Value <> 0 And .Cells("tipo").Value = "ARTICULO" And cant_dif_rev <> 0 Then
                            frmAviso.tabla.Rows(c - 1).Cells("cant").Style.BackColor = Color.YellowGreen
                            frmAviso.tabla.Rows(c - 1).Cells("desc").Style.BackColor = Color.YellowGreen

                        End If

                    End If

                End With
            Next
            If frmAviso.tabla.Rows.Count > 0 Then
                frmAviso.ShowDialog()
                If frmAviso.btnCLose.Text = "cancelar" Or frmAviso.btnCLose.Text = "NO" Then
                    If frmAviso.btnSI.Text = "continuar" Then

                    Else
                        Exit Sub
                    End If


                End If
            End If

            ' VERIFICAR SI HAY ELIMINADOR
            Dim valores As String = ""
            Dim cant_inv As Decimal = 0
            Dim cant_dif As Decimal = 0
            Dim cant_exitencia As Integer = 0
            Dim np_inv As String = ""
            Dim cant_individual_pack As Integer = 0
            Dim transaccionActualizar As MySql.Data.MySqlClient.MySqlTransaction = Nothing
            Dim tool As New Herramienta
            Dim consulta As String = ""
            Dim tablaResultado As New DataTable
            Dim comando As New MySql.Data.MySqlClient.MySqlCommand
            Try
                comando.Connection = New MySql.Data.MySqlClient.MySqlConnection
                comando.Connection.ConnectionString = con.ConnectionString
                comando.Connection.Open()

                transaccionActualizar = comando.Connection.BeginTransaction
                comando.Transaction = transaccionActualizar

                If tablaEliminados.Rows.Count > 0 Then
                    For i = 0 To tablaEliminados.Rows.Count - 1
                        'HAY QUE ACTUALIZAR INVENTARIO y si es articulo
                        consulta = "INSERT INTO servicios_detalleeliminados(cantidad,costo,descripcion, precio, mano, tipo, id_inv, np, id_servicio, id_pieza, marcado, fecha, iddetalle, idusuario) SELECT cant, costo, descripcion, precio, mano, tipo, id_inv, np, folio, idpieza, MARCADO, fecha, servicios_detalle.id, usuarios.id FROM servicios_detalle LEFT JOIN usuarios ON usuarios.id=" & MDIPrincipal.lblidUser.Text & " WHERE servicios_detalle.id=" & tablaEliminados.Rows(i).Cells("idborrar").Value

                        If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                        Else
                            Throw New Exception("no se pudo insertar historico de eliminados")
                        End If

                        consulta = "DELETE FROM servicios_detalle WHERE id=" & tablaEliminados.Rows(i).Cells("idborrar").Value

                        If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                            If tablaEliminados.Rows(i).Cells("id_inv_borrar").Value <> 0 And tablaEliminados.Rows(i).Cells("tipo_Art").Value = "ARTICULO" Then

                                consulta = "SELECT cantidad,np FROM articulos_inventario WHERE id=" & tablaEliminados.Rows(i).Cells("id_inv_borrar").Value

                                tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)
                                If tablaResultado.Rows.Count > 0 Then
                                    cant_inv = tablaResultado.Rows(0).Item("cantidad")
                                    cant_exitencia = tablaResultado.Rows(0).Item("cantidad")
                                    np_inv = tablaResultado.Rows(0).Item("np")
                                Else
                                    Throw New Exception("no se pudo encontrar información del inventario")
                                End If

                                cant_inv += tablaEliminados.Rows(i).Cells("cant_borrar").Value


                                consulta = "UPDATE articulos_inventario SET cantidad=" & cant_inv & " WHERE id=" & tablaEliminados.Rows(i).Cells("id_inv_borrar").Value

                                If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then

                                    With tablaEliminados.Rows(i)


                                        tool.Insertar_Movimiento_ModuloTransaccion("SERVICIO", NFolio.Value, .Cells("idborrar").Value, .Cells("id_inv_borrar").Value, np_inv, "ENTRADA", .Cells("tipo_Art").Value, .Cells("cant_borrar").Value, DateTime.Today, .Cells("descborrar").Value, cant_exitencia, cant_inv, 0, "TALLER TIBURON SERVICIO", 1, "BORRADO PACK DETALLE SERV EDITADO", transaccionActualizar)

                                        frmServicio_Info.tabla_articulos.Rows.Add(.Cells("cant_borrar").Value, np_inv, .Cells("descborrar").Value, cant_inv)
                                    End With
                                Else
                                    Throw New Exception("no se pudo actualizar la información del inventario")
                                End If

                            End If

                            ''para PACK paquetes
                            If tablaEliminados.Rows(i).Cells("id_inv_borrar").Value <> 0 And tablaEliminados.Rows(i).Cells("tipo_Art").Value = "PACK" Then
                                tabladetalle.Rows.Clear()

                                consulta = "SELECT * FROM articulos_pack WHERE id_pack=" & tablaEliminados.Rows(i).Cells("id_inv_borrar").Value

                                tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                If tablaResultado.Rows.Count > 0 Then
                                    tabladetalle.Rows.Add(tablaResultado.Rows(0).Item("id_np"), tablaResultado.Rows(0).Item("cant"), tablaResultado.Rows(0).Item("np"), tablaResultado.Rows(0).Item("descripcion"), 0)
                                Else
                                    Throw New Exception("no se pudo obtener la información del paquete (PACK)")
                                End If


                                For a = 0 To tabladetalle.Rows.Count - 1

                                    consulta = "SELECT id_inv,descripcion FROM articulos WHERE id=" & tabladetalle.Rows(a).Cells("id_np").Value

                                    tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                    If tablaResultado.Rows.Count > 0 Then
                                        tabladetalle.Rows(a).Cells("lista").Value = tablaResultado.Rows(0).Item("id_inv")
                                    End If

                                Next
                                For a = 0 To tabladetalle.Rows.Count - 1

                                    consulta = "SELECT cantidad FROM articulos_inventario WHERE id=" & tabladetalle.Rows(a).Cells("lista").Value

                                    tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                    If tablaResultado.Rows.Count > 0 Then
                                        cant_inv = tablaResultado.Rows(0).Item("cantidad")
                                        cant_exitencia = tablaResultado.Rows(0).Item("cantidad")
                                    End If

                                    cant_individual_pack = (tabladetalle.Rows(a).Cells("cant_np").Value * tablaEliminados.Rows(i).Cells("cant_borrar").Value)
                                    cant_inv += cant_individual_pack


                                    consulta = "UPDATE articulos_inventario SET cantidad=" & cant_inv & " WHERE id=" & tabladetalle.Rows(a).Cells("lista").Value

                                    If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                                        With tabladetalle.Rows(a)
                                            'SON RENGLONES INDIVIDUALES POR EL NO INDIVIDUAL

                                            tool.Insertar_Movimiento_ModuloTransaccion("SERVICIO", NFolio.Value, tablaEliminados.Rows(i).Cells("idborrar").Value, .Cells("lista").Value, .Cells("np_np").Value, "ENTRADA", "*", cant_individual_pack, DateTime.Today, .Cells("desc_np").Value, cant_exitencia, cant_inv, 0, "TALLER TIBURON SERVICIO PACK", .Cells("cant_np").Value, "BORRADO PACK DETALLE SERV EDITADO", transaccionActualizar)

                                            frmServicio_Info.tabla_articulos.Rows.Add(cant_individual_pack, .Cells("np_np").Value, .Cells("desc_np").Value, cant_inv)

                                        End With
                                    End If


                                Next
                            End If
                        Else
                            Throw New Exception("No se pudo eliminar renglones")
                        End If

                    Next
                End If



                'ACTUALIZAR renglones
                For i = 0 To TablaPiezas.Rows.Count - 1
                    If TablaPiezas.Rows(i).Cells("iddetalle").Value = 0 Then
                        

                        'SI ES NUEVO
                        valores = ""
                        valores &= TablaPiezas.Rows(i).Cells("id").Value & ","
                        valores &= "'" & TablaPiezas.Rows(i).Cells("np").Value & "',"
                        valores &= "'" & TablaPiezas.Rows(i).Cells("tipo").Value & "',"
                        valores &= "'" & TablaPiezas.Rows(i).Cells("desc").Value & "',"
                        valores &= TablaPiezas.Rows(i).Cells("cant").Value & ","

                        valores &= lblID.Text & ","
                        valores &= "'" & lblNuevo.Text & "',"
                        valores &= "'" & lblAnterior.Text & "',"
                        valores &= "'" & Format(fecha.Value, "yyyy/MM/dd") & "',"
                        valores &= TablaPiezas.Rows(i).Cells("costo").Value & ","
                        valores &= NFolio.Value & ","
                        valores &= TablaPiezas.Rows(i).Cells("id_inv").Value & ","
                        valores &= TablaPiezas.Rows(i).Cells("precio").Value & ","
                        valores &= TablaPiezas.Rows(i).Cells("mano").Value & ","
                        valores &= "'" & TablaPiezas.Rows(i).Cells("realizado").Value & "'"

                        consulta = "INSERT INTO servicios_detalle (idpieza,np,tipo,descripcion,cant,idauto,nuevo,anterior,fecha,costo,folio,id_inv,precio,mano,MARCADO) VALUES (" & valores & ")"

                        If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                            'SI ES NUEVO ARTICULO E INVETARIO

                            If TablaPiezas.Rows(i).Cells("id_inv").Value <> 0 And TablaPiezas.Rows(i).Cells("tipo").Value = "ARTICULO" Then

                                consulta = "SELECT cantidad FROM articulos_inventario WHERE id=" & TablaPiezas.Rows(i).Cells("id_inv").Value

                                tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                If tablaResultado.Rows.Count > 0 Then
                                    cant_inv = tablaResultado.Rows(0).Item("cantidad")
                                    cant_exitencia = tablaResultado.Rows(0).Item("cantidad")
                                End If


                                cant_inv -= TablaPiezas.Rows(i).Cells("cant").Value


                                consulta = "UPDATE articulos_inventario SET cantidad=" & cant_inv & " WHERE id=" & TablaPiezas.Rows(i).Cells("id_inv").Value

                                If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then

                                    ''*** INSERTAR MOV
                                    'Insertar_Salida(i, cant_inv)
                                    'OBTENER id_detalle de el renglon
                                    Dim id_det As Integer = 0

                                    'ES UN ARTICULO TIENE MOVIMIENTO

                                    consulta = "SELECT max(id) FROM servicios_detalle"

                                    tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                    If tablaResultado.Rows.Count > 0 Then
                                        id_det = tablaResultado.Rows(0).Item(0)
                                    End If

                                    With TablaPiezas.Rows(i)

                                        tool.Insertar_Movimiento_ModuloTransaccion("SERVICIO", NFolio.Value, id_det, .Cells("id_inv").Value, .Cells("np").Value, "SALIDA", .Cells("tipo").Value, .Cells("cant").Value, DateTime.Today, .Cells("desc").Value, cant_exitencia, cant_inv, 0, "TALLER TIBURON SERVICIO", 1, "NUEVO ARTICULO AÑADIDO", transaccionActualizar)

                                        frmServicio_Info.tabla_articulos.Rows.Add(.Cells("cant").Value, .Cells("np").Value, .Cells("desc").Value, cant_inv)
                                    End With

                                End If

                            End If
                            'SI ES UN PACK E INVENTARIO
                            If TablaPiezas.Rows(i).Cells("id_inv").Value <> 0 And TablaPiezas.Rows(i).Cells("tipo").Value = "PACK" Then
                                tabladetalle.Rows.Clear()


                                consulta = "SELECT * FROM articulos_pack WHERE id_pack=" & TablaPiezas.Rows(i).Cells("id").Value
                                tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                If tablaResultado.Rows.Count > 0 Then
                                    For Each xRow As DataRow In tablaResultado.Rows
                                        tabladetalle.Rows.Add(xRow.Item("id_np"), xRow.Item("cant"), xRow.Item("np"), xRow.Item("descripcion"), 0)
                                    Next
                                Else
                                    Throw New Exception("no se pudo obtener las piezas del paquete (PACK)")
                                End If


                                For a = 0 To tabladetalle.Rows.Count - 1


                                    consulta = "SELECT id_inv FROM articulos WHERE id=" & tabladetalle.Rows(a).Cells("id_np").Value

                                    tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                    If tablaResultado.Rows.Count > 0 Then
                                        tabladetalle.Rows(a).Cells("lista").Value = tablaResultado.Rows(0).Item("id_inv")
                                    End If

                                Next
                                For a = 0 To tabladetalle.Rows.Count - 1

                                    consulta = "SELECT cantidad FROM articulos_inventario WHERE id=" & tabladetalle.Rows(a).Cells("lista").Value

                                    tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                    If tablaResultado.Rows.Count > 0 Then
                                        cant_inv = tablaResultado.Rows(0).Item("cantidad")
                                        cant_exitencia = tablaResultado.Rows(0).Item("cantidad")
                                    Else
                                        Throw New Exception("No se pudo obtener la cantidad de inventario id " & tabladetalle.Rows(a).Cells("lista").Value.ToString)
                                    End If

                                    cant_individual_pack = (tabladetalle.Rows(a).Cells("cant_np").Value * TablaPiezas.Rows(i).Cells("cant").Value)

                                    cant_inv -= cant_individual_pack

                                    consulta = "UPDATE articulos_inventario SET cantidad=" & cant_inv & " WHERE id=" & tabladetalle.Rows(a).Cells("lista").Value


                                    If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                                        With tabladetalle.Rows(a)
                                            'es nuevo 

                                            tool.Insertar_Movimiento_ModuloTransaccion("SERVICIO", NFolio.Value, TablaPiezas.Rows(i).Cells("iddetalle").Value, .Cells("lista").Value, .Cells("np_np").Value, "SALIDA", "*", cant_individual_pack, DateTime.Today, .Cells("desc_np").Value, cant_exitencia, cant_inv, 0, "TALLER TIBURON SERVICIO PACK", .Cells("cant_np").Value, "NUEVO ARTICULO AÑADIDO PACK", transaccionActualizar)

                                            frmServicio_Info.tabla_articulos.Rows.Add(cant_individual_pack, .Cells("np_np").Value, .Cells("desc_np").Value, cant_inv)

                                        End With
                                    End If

                                Next
                            End If

                        End If

                    End If
                    If TablaPiezas.Rows(i).Cells("iddetalle").Value <> 0 And TablaPiezas.Rows(i).Cells("id_inv").Value <> 0 Then
                        'comparar
                        CompararRegistros(TablaPiezas.Rows(i), transaccionActualizar)

                        'SI existia en la lista SE EDITARA
                        cant_dif = TablaPiezas.Rows(i).Cells("cantActual").Value - TablaPiezas.Rows(i).Cells("cant").Value

                        If TablaPiezas.Rows(i).Cells("tipo").Value = "ARTICULO" Then

                            If cant_dif > 0 Then ' AUMENTA el inventario 

                                consulta = "SELECT cantidad FROM articulos_inventario WHERE id=" & TablaPiezas.Rows(i).Cells("id_inv").Value

                                tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                If tablaResultado.Rows.Count > 0 Then
                                    cant_inv = tablaResultado.Rows(0).Item("cantidad")
                                    cant_exitencia = tablaResultado.Rows(0).Item("cantidad")
                                End If

                                cant_inv += cant_dif '  ej 3 + (+1) 

                                consulta = "UPDATE articulos_inventario SET cantidad=" & cant_inv & " WHERE id=" & TablaPiezas.Rows(i).Cells("id_inv").Value

                                If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then

                                    With TablaPiezas.Rows(i)

                                        tool.Insertar_Movimiento_ModuloTransaccion("SERVICIO", NFolio.Value, .Cells("iddetalle").Value, .Cells("id_inv").Value, .Cells("np").Value, "ENTRADA", .Cells("tipo").Value, cant_dif, DateTime.Today, .Cells("desc").Value, cant_exitencia, cant_inv, 0, "TALLER TIBURON SERVICIO", 1, "ARTICULO EDITADO AUMENTA INVETARIO", transaccionActualizar)

                                        frmServicio_Info.tabla_articulos.Rows.Add(cant_dif, .Cells("np").Value, .Cells("desc").Value, cant_inv)

                                    End With

                                End If

                            End If
                            'solo para pieza

                            If cant_dif < 0 Then ' REDUCE INVENTARIO

                                consulta = "SELECT cantidad FROM articulos_inventario WHERE id=" & TablaPiezas.Rows(i).Cells("id_inv").Value

                                tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                If tablaResultado.Rows.Count > 0 Then
                                    cant_inv = tablaResultado.Rows(0).Item("cantidad")
                                    cant_exitencia = tablaResultado.Rows(0).Item("cantidad")
                                End If

                                cant_inv += cant_dif ' ej. 3 + (-1)= +-=-1 ... 3-1=2

                                consulta = "UPDATE articulos_inventario SET cantidad=" & cant_inv & " WHERE id=" & TablaPiezas.Rows(i).Cells("id_inv").Value

                                If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                                    With TablaPiezas.Rows(i)

                                        tool.Insertar_Movimiento_ModuloTransaccion("SERVICIO", NFolio.Value, .Cells("iddetalle").Value, .Cells("id_inv").Value, .Cells("np").Value, "SALIDA", .Cells("tipo").Value, -(cant_dif), DateTime.Today, .Cells("desc").Value, cant_exitencia, cant_inv, 0, "TALLER TIBURON SERVICIO", 1, "ARTICULO EDITADO REDUCE INVENTARIO", transaccionActualizar)

                                        frmServicio_Info.tabla_articulos.Rows.Add(-(cant_dif), .Cells("np").Value, .Cells("desc").Value, cant_inv)

                                    End With
                                End If

                            End If

                        End If
                        If TablaPiezas.Rows(i).Cells("tipo").Value = "PACK" Then
                            If cant_dif > 0 Then 'AUMENTA INVENTARIO
                                tabladetalle.Rows.Clear()

                                consulta = "SELECT * FROM articulos_pack WHERE id_pack=" & TablaPiezas.Rows(i).Cells("id").Value

                                tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                If tablaResultado.Rows.Count > 0 Then
                                    For Each xRow As DataRow In tablaResultado.Rows
                                        tabladetalle.Rows.Add(xRow.Item("id_np"), xRow.Item("cant"), xRow.Item("np"), xRow.Item("descripcion"), 0)
                                    Next
                                End If

                                For a = 0 To tabladetalle.Rows.Count - 1


                                    consulta = "SELECT id_inv FROM articulos WHERE id=" & tabladetalle.Rows(a).Cells("id_np").Value

                                    tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                    If tablaResultado.Rows.Count > 0 Then
                                        tabladetalle.Rows(a).Cells("lista").Value = tablaResultado.Rows(0).Item("id_inv")
                                    End If

                                Next
                                For a = 0 To tabladetalle.Rows.Count - 1

                                    consulta = "SELECT cantidad FROM articulos_inventario WHERE id=" & tabladetalle.Rows(a).Cells("lista").Value

                                    tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                    If tablaResultado.Rows.Count > 0 Then
                                        cant_inv = tablaResultado.Rows(0).Item("cantidad")
                                        cant_exitencia = tablaResultado.Rows(0).Item("cantidad")
                                    End If

                                    'OJO VALOR NEGATIVO - * - = +
                                    cant_individual_pack = (tabladetalle.Rows(a).Cells("cant_np").Value * cant_dif)
                                    cant_inv += cant_individual_pack

                                    consulta = "UPDATE articulos_inventario SET cantidad=" & cant_inv & " WHERE id=" & tabladetalle.Rows(a).Cells("lista").Value

                                    If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                                        With tabladetalle.Rows(a)

                                            tool.Insertar_Movimiento_ModuloTransaccion("SERVICIO", NFolio.Value, TablaPiezas.Rows(i).Cells("iddetalle").Value, .Cells("lista").Value, .Cells("np_np").Value, "ENTRADA", "*", cant_individual_pack, DateTime.Today, .Cells("desc_np").Value, cant_exitencia, cant_inv, 0, "TALLER TIBURON SERVICIO PACK", .Cells("cant_np").Value, "PACK EDIT AUMENTA INVETARIO", transaccionActualizar)

                                            frmServicio_Info.tabla_articulos.Rows.Add(cant_individual_pack, .Cells("np_np").Value, .Cells("desc_np").Value, cant_inv)

                                        End With
                                    End If

                                Next
                            End If
                            If cant_dif < 0 Then 'REDUCE INVENTARIO
                                tabladetalle.Rows.Clear()

                                consulta = "SELECT * FROM articulos_pack WHERE id_pack=" & TablaPiezas.Rows(i).Cells("id").Value

                                tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                If tablaResultado.Rows.Count > 0 Then
                                    For Each xRow As DataRow In tablaResultado.Rows
                                        tabladetalle.Rows.Add(xRow.Item("id_np"), xRow.Item("cant"), xRow.Item("np"), xRow.Item("descripcion"), 0)
                                    Next
                                End If

                                For a = 0 To tabladetalle.Rows.Count - 1

                                    consulta = "SELECT id_inv FROM articulos WHERE id=" & tabladetalle.Rows(a).Cells("id_np").Value

                                    tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                    If tablaResultado.Rows.Count > 0 Then
                                        tabladetalle.Rows(a).Cells("lista").Value = tablaResultado.Rows(0).Item("id_inv")
                                    End If

                                Next
                                For a = 0 To tabladetalle.Rows.Count - 1

                                    consulta = "SELECT cantidad FROM articulos_inventario WHERE id=" & tabladetalle.Rows(a).Cells("lista").Value

                                    tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                    If tablaResultado.Rows.Count > 0 Then
                                        cant_inv = tablaResultado.Rows(0).Item("cantidad")
                                        cant_exitencia = tablaResultado.Rows(0).Item("cantidad")
                                    End If

                                    cant_individual_pack = (tabladetalle.Rows(a).Cells("cant_np").Value * (cant_dif))
                                    cant_inv += cant_individual_pack

                                    consulta = "UPDATE articulos_inventario SET cantidad=" & cant_inv & " WHERE id=" & tabladetalle.Rows(a).Cells("lista").Value

                                    If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                                        With tabladetalle.Rows(a)

                                            tool.Insertar_Movimiento_ModuloTransaccion("SERVICIO", NFolio.Value, TablaPiezas.Rows(i).Cells("iddetalle").Value, .Cells("lista").Value, .Cells("np_np").Value, "SALIDA", "*", -(cant_individual_pack), DateTime.Today, .Cells("desc_np").Value, cant_exitencia, cant_inv, 0, "TALLER TIBURON SERVICIO PACK", .Cells("cant_np").Value, "PACK EDIT REDUCE INVETARIO", transaccionActualizar)

                                            frmServicio_Info.tabla_articulos.Rows.Add(-(cant_individual_pack), .Cells("np_np").Value, .Cells("desc_np").Value, cant_inv)

                                        End With
                                    End If

                                Next
                            End If

                        End If
                    End If

                    consulta = "UPDATE servicios_detalle SET descripcion='" & TablaPiezas.Rows(i).Cells("desc").Value & "',cant=" & TablaPiezas.Rows(i).Cells("cant").Value & " , costo=" & TablaPiezas.Rows(i).Cells("costo").Value & ", mano=" & TablaPiezas.Rows(i).Cells("mano").Value & ", precio=" & TablaPiezas.Rows(i).Cells("precio").Value & ", MARCADO='" & TablaPiezas.Rows(i).Cells("realizado").Value & "' WHERE id=" & TablaPiezas.Rows(i).Cells("iddetalle").Value
                    If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                    Else
                        If TablaPiezas.Rows(i).Cells("iddetalle").Value.ToString = "0" Then
                        Else
                            Throw New Exception("No se pudo actualizar el detalle del servicio")
                        End If

                    End If

                Next
                'ACTUALIZAR TITULO

                consulta = "UPDATE servicios SET estado='" & CBEstado.Text & "', para='" & txtObservacion.Text & "', km='" & txtKM.Text & "', cotizar='" & CBCotizar.Text & "', OC='" & txtOC.Text & "', total=" & NTotal.Value & ", iva=" & My.Settings.Iva & " WHERE id=" & NFolio.Value

                If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                    'VERIFICAR SI TIENE COTIZACION
                    '-------------- se omitira la actualización de la cotización
                    '--- 24 enero 2020
                    'Try
                    '    verificar_cotizacion()
                    'Catch ex As Exception
                    '    btnClose.PerformClick()
                    'End Try

                    transaccionActualizar.Commit()

                    frmServicio_Info.lblFolio.Text = NFolio.Value
                    frmServicio_Info.lblestado.Text = "Guardado"
                    btnClose.PerformClick()

                    frmServicio_Info.ShowDialog()
                    frmServicio.cargar_info()
                    frmServicio.cargar_Detalle()
                End If

            Catch ex As Exception
                If transaccionActualizar IsNot Nothing Then
                    If transaccionActualizar.Connection IsNot Nothing Then
                        transaccionActualizar.Rollback()
                    End If


                End If

                If comando.Connection IsNot Nothing Then
                    If comando.Connection.State = ConnectionState.Open Then
                        comando.Connection.Close()
                    End If
                End If

                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If
    End Sub

    
    
    Private Sub Calcular()
        Dim suma As Decimal = 0
        Dim importe As Decimal = 0
        Dim v_total As Decimal = 0
        If TablaPiezas.Rows.Count > 0 Then
            For i = 0 To TablaPiezas.Rows.Count - 1
                With TablaPiezas.Rows(i)
                    importe = (.Cells("precio").Value + .Cells("mano").Value)
                    v_total = importe * .Cells("cant").Value
                End With
                suma += v_total
                v_total = 0
                importe = 0

            Next

        End If
        lblcant.Text = TablaPiezas.Rows.Count
        NSub.Value = suma
        NIva.Value = NSub.Value * My.Settings.Iva
        NTotal.Value = NSub.Value + NIva.Value
    End Sub

    Private Sub TablaPiezas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaPiezas.CellClick

    End Sub

    Private Sub TablaPiezas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaPiezas.CellContentClick

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If TablaPiezas.Rows.Count > 0 Then
            Dim i As Integer = TablaPiezas.CurrentRow.Index
            With frmServicio_ArtEDIT
                .lblindex.Text = i
                .lblventana.Text = "SER_EDIT"
                .NCant.Value = TablaPiezas.Rows(i).Cells("cant").Value
                .txtdesc.Text = TablaPiezas.Rows(i).Cells("desc").Value
                .Ncosto.Value = TablaPiezas.Rows(i).Cells("costo").Value
                .Nprecio.Value = TablaPiezas.Rows(i).Cells("precio").Value
                .NMano.Value = TablaPiezas.Rows(i).Cells("mano").Value
                .ShowDialog()

            End With

        End If
        Calcular()

    End Sub

    Private Sub btnDescuento_Click(sender As Object, e As EventArgs) Handles btnDescuento.Click
        frmServicio_AddManual.lblVentana.Text = "EDIT_SER"

        frmServicio_AddManual.ShowDialog()
        Calcular()
    End Sub

    Private Sub CBCotizar_KeyDown(sender As Object, e As KeyEventArgs) Handles CBCotizar.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            If CBCotizar.SelectedIndex = 1 Then
                txtOC.Focus()

            End If
        End If
    End Sub

    Private Sub CBCotizar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCotizar.SelectedIndexChanged
        If CBCotizar.SelectedIndex = 1 Then
            PANELOC.Show()
            txtOC.Focus()

        Else
            PANELOC.Hide()
        End If
    End Sub

    Private Sub btnServicio_Click(sender As Object, e As EventArgs) Handles btnServicio.Click
        frmServicioAgregarSelect.Dispose()

        frmServicioAgregarSelect.txtInfoMarca.Text = lblMarca.Text
        frmServicioAgregarSelect.txtInfoModelo.Text = lblmodelo.Text
        frmServicioAgregarSelect.txtInfoAño.Text = lblaño.Text
        frmServicioAgregarSelect.lbltipo.Text = "PIEZA"
        frmServicioAgregarSelect.ventana.Text = "EDITAR"
        frmServicioAgregarSelect.ShowDialog()
        Calcular()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim j As Integer = 16
        Try
            Dim workbook As Workbook = New Workbook()
            workbook.LoadFromFile(Application.StartupPath & "\formato.xlsx")
            Dim sheet As Worksheet = workbook.Worksheets(0)
            sheet.Range("D9").Value = NFolio.Value
            sheet.Range("B12").Text = lblNuevo.Text & " - " & lblAnterior.Text
            sheet.Range("B13").Text = lblplacas.Text
            sheet.Range("B14").Text = lblserie.Text

            If txtKM.TextLength = 0 Then
            Else
                sheet.Range("B15").Value = txtKM.Text

            End If
            For i = 0 To TablaPiezas.Rows.Count - 1
                j += 1
                sheet.Range(j, 1).Value = TablaPiezas.Rows(i).Cells("cant").Value
                sheet.Range(j, 2).Value = TablaPiezas.Rows(i).Cells("desc").Value
                sheet.Range(j, 3).Value = TablaPiezas.Rows(i).Cells("importe").Value
                sheet.Range(j, 4).Value = TablaPiezas.Rows(i).Cells("total").Value

            Next
            workbook.SaveToFile(Application.StartupPath & "\cot\cot\cot_Ser" & NFolio.Value & ".xlsx")
            MsgBox("GENERADO", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub TablaPiezas_SelectionChanged(sender As Object, e As EventArgs) Handles TablaPiezas.SelectionChanged
        lblTitulo.Text = ""
        Mostrar_INV()
    End Sub
    Private Sub Mostrar_INV()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

            If TablaPiezas.Rows.Count > 0 And TablaPiezas.SelectedCells.Count > 0 Then
                Dim i As Integer = TablaPiezas.CurrentRow.Index
            Try

                consulta = "SELECT cantidad FROM articulos_inventario WHERE id=" & TablaPiezas.Rows(i).Cells("id_inv").Value
                tablaResultado = tool.ObtenerTabla(consulta)
                If tablaResultado.Rows.Count > 0 Then
                    With tablaResultado.Rows(0)
                        lblTitulo.Text = TablaPiezas.Rows(i).Cells("np").Value & "  " & TablaPiezas.Rows(i).Cells("desc").Value
                        lblcant_inv.Text = .Item("cantidad")
                    End With
                Else
                    lblcant_inv.Text = ""
                End If
                tabladetalle.Rows.Clear()
                consulta = "SELECT * FROM articulos_pack WHERE id_pack=" & TablaPiezas.Rows(i).Cells("id").Value
                tablaResultado = tool.ObtenerTabla(consulta)
                If tablaResultado.Rows.Count > 0 Then
                    For Each xRow As DataRow In tablaResultado.Rows
                        tabladetalle.Rows.Add(xRow.Item("id_np"), xRow.Item("cant"), xRow.Item("np"), xRow.Item("descripcion"), 0)
                    Next
                End If

                For a = 0 To tabladetalle.Rows.Count - 1
                    consulta = "SELECT id_inv FROM articulos WHERE id=" & tabladetalle.Rows(a).Cells("id_np").Value
                    tablaResultado = tool.ObtenerTabla(consulta)
                    If tablaResultado.Rows.Count > 0 Then
                        tabladetalle.Rows(a).Cells("lista").Value = tablaResultado.Rows(0).Item("id_inv")
                    End If
                Next
            Catch ex As Exception
                lblTitulo.Text = ""
                lblcant.Text = ""
                Panel_Inv.Hide()
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
            End If
    End Sub

    Private Sub txtOC_GotFocus(sender As Object, e As EventArgs) Handles txtOC.GotFocus
        txtOC.Select(0, 1000)
    End Sub

    Private Sub txtOC_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOC.KeyDown
        If e.KeyCode = Keys.Enter Then
            Nprecio.Focus()
            Nprecio.Select(0, 10000)
        End If
    End Sub

    Private Sub txtOC_TextChanged(sender As Object, e As EventArgs) Handles txtOC.TextChanged

    End Sub

    Private Sub Nprecio_GotFocus(sender As Object, e As EventArgs) Handles Nprecio.GotFocus
        Nprecio.Select(0, 1000)
    End Sub

    Private Sub Nprecio_KeyDown(sender As Object, e As KeyEventArgs) Handles Nprecio.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnGuardar.Focus()

        End If
    End Sub

    Private Sub Nprecio_ValueChanged(sender As Object, e As EventArgs) Handles Nprecio.ValueChanged

    End Sub

    Private Sub lblcant_inv_Click(sender As Object, e As EventArgs) Handles lblcant_inv.Click

    End Sub
End Class