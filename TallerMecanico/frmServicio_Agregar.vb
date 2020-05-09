Imports Spire.Xls

Public Class frmServicio_Agregar
    Dim tablaBD As String = "servicios"
    Private Sub frmServicio_Agregar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()

        End If
    End Sub

    Private Sub frmServicioAgregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estructura_ventana(Me)
        NSub.Controls(0).Hide()
        NIva.Controls(0).Hide()
        NTotal.Controls(0).Hide()
        CBEstado.SelectedIndex = 0
        MostrarFolio()
        CBCotizar.SelectedIndex = 0

    End Sub
    Private Sub MostrarFolio()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Try

            consulta = "SELECT max(id) FROM servicios"
            tablaResultado = tool.ObtenerTabla(consulta)
            If tablaResultado.Rows.Count > 0 Then
                If IsNumeric(tablaResultado.Rows(0).Item(0)) Then
                    NFolio.Value = tablaResultado.Rows(0).Item(0) + 1
                Else
                    NFolio.Value = 1
                End If
            Else
                NFolio.Value = 1
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        frmServicioAgregarSelect.Dispose()

        frmServicioAgregarSelect.txtInfoMarca.Text = lblMarca.Text
        frmServicioAgregarSelect.txtInfoModelo.Text = lblmodelo.Text
        frmServicioAgregarSelect.txtInfoAño.Text = lblaño.Text
        frmServicioAgregarSelect.txtmodelo.Text = lblmodelo.Text

        frmServicioAgregarSelect.lbltipo.Text = "PIEZA"
        frmServicioAgregarSelect.ventana.Text = "AGREGAR"
        frmServicioAgregarSelect.ShowDialog()

        Calcular()
        SelectUltimo()

        ' CalcularTotal()
    End Sub
    Public Sub SelectUltimo()
        If TablaPiezas.Rows.Count > 0 Then
            TablaPiezas.CurrentCell = TablaPiezas.Item(1, (TablaPiezas.Rows.Count - 1))

            TablaPiezas.Rows(TablaPiezas.Rows.Count - 1).Selected = True
            TablaPiezas.FirstDisplayedScrollingRowIndex = TablaPiezas.RowCount - 1
            Dim celdaSelecionada As Integer = TablaPiezas.Rows.Count
            ' celdaSelecionada = TablaPiezas.GetCellCount(DataGridViewElementStates.Selected)

            Mostrar_INVENTARIO()

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If TablaPiezas.Rows.Count > 0 Then
            Dim i As Integer = TablaPiezas.CurrentRow.Index
            If MsgBox("¿deseas eliminar " & TablaPiezas.Rows(i).Cells("desc").Value & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                TablaPiezas.Rows.RemoveAt(i)
                ' CalcularTotal()
            End If
        End If
        Calcular()
    End Sub
    Private Sub CalcularTotal()
        Dim cantidad As Integer = 0
        Dim precio As Decimal = 0
        Dim importeprecio As Decimal = 0
        Dim mano As Decimal = 0
        Dim importeMano As Decimal = 0
        Dim total As Decimal = 0
        If TablaPiezas.Rows.Count > 0 Then
            For i = 0 To TablaPiezas.Rows.Count - 1
                cantidad = TablaPiezas.Rows(i).Cells("cant").Value
                precio = TablaPiezas.Rows(i).Cells("precio").Value
                importeprecio = cantidad * precio
                TablaPiezas.Rows(i).Cells("importe").Value = importeprecio
                mano = TablaPiezas.Rows(i).Cells("mano").Value
                importeMano = cantidad * mano
                TablaPiezas.Rows(i).Cells("importemano").Value = importeMano
                TablaPiezas.Rows(i).Cells("importetotal").Value = importeMano + importeprecio
                total += importeMano + importeprecio

            Next
        Else
            NSub.Value = 0
            NIva.Value = 0
            NTotal.Value = 0
        End If
        NSub.Value = total
        NIva.Value = total * 0.16
        NTotal.Value = NIva.Value + NSub.Value
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If TablaPiezas.Rows.Count > 0 Then
            Dim i As Integer = TablaPiezas.CurrentRow.Index
            frmServicio_ArtEDIT.Dispose()
            With frmServicio_ArtEDIT
                .lblindex.Text = i
                .lblventana.Text = "AGREGAR"
                .txtdesc.Text = TablaPiezas.Rows(i).Cells("desc").Value
                .NCant.Value = TablaPiezas.Rows(i).Cells("cant").Value
                .Ncosto.Value = TablaPiezas.Rows(i).Cells("costo").Value
                .Nprecio.Value = TablaPiezas.Rows(i).Cells("precio").Value
                .NMano.Value = TablaPiezas.Rows(i).Cells("mano").Value
                .ShowDialog()
            End With
            'CalcularTotal()

        End If
        Calcular()
    End Sub
    Private Sub Calcular()
        Dim suma As Decimal = 0
        If TablaPiezas.Rows.Count > 0 Then
            For i = 0 To TablaPiezas.Rows.Count - 1
                With TablaPiezas.Rows(i)
                    .Cells("importe").Value = (.Cells("precio").Value + .Cells("mano").Value)
                    .Cells("total").Value = .Cells("importe").Value * .Cells("cant").Value
                End With
                suma += TablaPiezas.Rows(i).Cells("total").Value
            Next

        End If
        lblcant.Text = TablaPiezas.Rows.Count
        NSub.Value = suma
        NIva.Value = NSub.Value * My.Settings.Iva
        NTotal.Value = NSub.Value + NIva.Value
    End Sub
    Private Sub Insertar_Salida(posicion As Integer, foliodoc As Integer)
        Dim valores_mov As String = ""
        Dim id_inv_mov As Integer = 0
        cmd.CommandText = "SELECT MAX(id) FROM servicios_detalle"
        datos = cmd.ExecuteReader
        If datos.HasRows Then
            While datos.Read
                id_inv_mov = datos.GetValue(0)
            End While
        End If
        datos.Close()
        valores_mov = id_inv_mov & ","
        valores_mov &= TablaPiezas.Rows(posicion).Cells("id_inv").Value & ","
        valores_mov &= "'SALIDA',"
        valores_mov &= "'" & TablaPiezas.Rows(posicion).Cells("tipo").Value & "',"
        valores_mov &= -(TablaPiezas.Rows(posicion).Cells("cant").Value) & ","
        valores_mov &= "'" & Format(fecha.Value, "yyyy/MM/dd") & "',"
        valores_mov &= "'" & TablaPiezas.Rows(posicion).Cells("np").Value & "',"
        valores_mov &= "'" & TablaPiezas.Rows(posicion).Cells("desc").Value & "',"
        valores_mov &= "'SERVICIO',"
        valores_mov &= foliodoc
        cmd.CommandText = "INSERT INTO articulos_movimiento (id_det,id_np,tipo_mov,tipo_art,cant,fecha,np,descripcion,ventana,folio) VALUES (" & valores_mov & ")"
        If cmd.ExecuteNonQuery Then

        End If
    End Sub
    Private Sub Insertar_Salida_Pack(posicion As Integer, id_nparte As Integer, cant_np As Decimal, nparte As String, descR As String, foliodoc As Integer)
        Dim valores_mov As String = ""
        Dim id_inv_mov As Integer = 0
        cmd.CommandText = "SELECT MAX(id) FROM servicios_detalle"
        datos = cmd.ExecuteReader
        If datos.HasRows Then
            While datos.Read
                id_inv_mov = datos.GetValue(0)
            End While
        End If
        datos.Close()

        valores_mov = id_inv_mov & ","
        valores_mov &= id_nparte & ","
        valores_mov &= "'SALIDA',"
        valores_mov &= "'ARTICULO',"
        valores_mov &= cant_np & ","
        valores_mov &= "'" & Format(fecha.Value, "yyyy/MM/dd") & "',"
        valores_mov &= "'" & nparte & "',"
        valores_mov &= "'" & descR & "',"
        valores_mov &= "'SERVICIO',"
        valores_mov &= foliodoc
        cmd.CommandText = "INSERT INTO articulos_movimiento (id_det,id_np,tipo_mov,tipo_art,cant,fecha,np,descripcion,ventana,folio) VALUES (" & valores_mov & ")"
        If cmd.ExecuteNonQuery Then
            frmServicio_Info.tabla_articulos.Rows.Add("", "", "Insertado Mov PACK")
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim valores As String = ""
        Dim continuar As Boolean = False
        Dim folio As Integer = 0
        Dim cant_inv As Decimal = 0
        Dim id_inv_pack As Integer = 0
        Dim id_det As Integer = 0
        Dim c As Integer = 0
        Dim cant_exitencia As Integer = 0
        Dim cant_individual_pack As Integer = 0
        Dim transaccionActualizar As MySql.Data.MySqlClient.MySqlTransaction = Nothing
        Dim tool As New Herramienta
        Dim consultaActualizar As String = ""
        Dim tablaConsulta As New DataTable
        Dim comando As New MySql.Data.MySqlClient.MySqlCommand

        frmAviso.Dispose()
        frmServicio_Info.tabla_articulos.Rows.Clear()
        Dim inventario As String = ""
        If TablaPiezas.Rows.Count > 0 Then
            For i = 0 To TablaPiezas.Rows.Count - 1
                With TablaPiezas.Rows(i)
                    If .Cells("id_inv").Value <> 0 Or .Cells("realizado").Value = "REAL" Then

                        frmAviso.tabla.Rows.Add(.Cells("cant").Value, .Cells("desc").Value, .Cells("realizado").Value)

                        c += 1
                        If .Cells("id_inv").Value <> 0 And .Cells("tipo").Value = "ARTICULO" Then
                            frmAviso.tabla.Rows(c - 1).Cells("cant").Style.BackColor = Color.YellowGreen
                            frmAviso.tabla.Rows(c - 1).Cells("desc").Style.BackColor = Color.YellowGreen

                        End If


                    End If
                    If .Cells("mano").Value = 0 Then
                        If MsgBox("El concepto " & .Cells("desc").Value & " NO TIENE MANO DE OBRA, Desea Continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        Else
                            Exit Sub
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

            If lblID.Text = "0" Then
                MsgBox("No se pudo establecer la información del auto")
                Return
            End If

            If txtKM.TextLength > 0 Then
                continuar = True
            Else
                If MsgBox("¿Deseas Continuar sin ingresar KM?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    continuar = True
                Else
                    Exit Sub
                    continuar = False
                End If

            End If
            If txtObservacion.TextLength > 0 Then
                continuar = True
            Else
                If MsgBox("¿Deseas Continuar sin Ingresar Observación ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    continuar = True
                Else
                    continuar = False
                End If

            End If
            If continuar Then
                For i = 0 To TablaPiezas.Rows.Count - 1
                    If TablaPiezas.Rows(i).Cells("mano").Value.ToString.Length = 0 Or TablaPiezas.Rows(i).Cells("precio").Value.ToString.Length = 0 Then
                        continuar = False
                        MsgBox("Renglon con Mano o Precio en Ceros")
                    End If

                Next
            End If
            If continuar Then
                Try

                    comando.Connection = New MySql.Data.MySqlClient.MySqlConnection
                    comando.Connection.ConnectionString = con.ConnectionString
                    comando.Connection.Open()

                    transaccionActualizar = comando.Connection.BeginTransaction
                    comando.Transaction = transaccionActualizar


                    valores = ""
                    valores &= "'" & Format(fecha.Value, "yyyy/MM/dd") & "',"
                    valores &= lblID.Text & ","
                    valores &= "'" & lblNuevo.Text & "',"
                    valores &= "'" & lblAnterior.Text & "',"
                    valores &= "'" & lblMarca.Text & "',"
                    valores &= "'" & lblaño.Text & "',"
                    valores &= "'" & txtObservacion.Text & "',"
                    valores &= "'" & CBEstado.Text & "',"
                    valores &= "'" & txtKM.Text & "',"
                    valores &= "'" & CBCotizar.Text & "',"
                    valores &= "'" & txtOC.Text & "',"
                    valores &= My.Settings.Iva & ","
                    valores &= "0,"
                    valores &= NTotal.Value

                    consultaActualizar = "INSERT INTO servicios (fecha,ncamion,nuevo,anterior,marca,year,para,estado,km,cotizar,OC,iva,valor, total) VALUES (" & valores & ")"
                    If tool.ActualizarDatosTransaccion(transaccionActualizar, consultaActualizar) Then
                        tablaConsulta = tool.ObtenerTablaTransaccion(transaccionActualizar, "SELECT max(id) FROM servicios")
                    Else
                        Throw New Exception("No se pudo ejecutar la actualización de datos")
                    End If
                    If tablaConsulta.Rows.Count Then
                        folio = tablaConsulta.Rows(0).Item(0)
                    Else
                        folio = 1
                    End If



                    For i = 0 To TablaPiezas.Rows.Count - 1
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
                        valores &= folio & ","
                        valores &= TablaPiezas.Rows(i).Cells("id_inv").Value & ","
                        valores &= TablaPiezas.Rows(i).Cells("precio").Value & ","
                        valores &= TablaPiezas.Rows(i).Cells("mano").Value & ","
                        valores &= "'" & TablaPiezas.Rows(i).Cells("realizado").Value & "'"

                        consultaActualizar = "INSERT INTO servicios_detalle (idpieza,np,tipo,descripcion,cant,idauto,nuevo,anterior,fecha,costo,folio,id_inv,precio,mano,MARCADO) VALUES (" & valores & ")"

                        If tool.ActualizarDatosTransaccion(transaccionActualizar, consultaActualizar) Then
                            If TablaPiezas.Rows(i).Cells("tipo").Value = "ARTICULO" Then
                                If TablaPiezas.Rows(i).Cells("id_inv").Value <> 0 Then
                                    consultaActualizar = "SELECT cantidad FROM articulos_inventario WHERE id=" & TablaPiezas.Rows(i).Cells("id_inv").Value

                                    tablaConsulta = tool.ObtenerTablaTransaccion(transaccionActualizar, consultaActualizar)

                                    If tablaConsulta.Rows.Count > 0 Then
                                        cant_inv = tablaConsulta.Rows(0).Item("cantidad")
                                        cant_exitencia = tablaConsulta.Rows(0).Item("cantidad")
                                    End If

                                    cant_inv -= TablaPiezas.Rows(i).Cells("cant").Value

                                    consultaActualizar = "UPDATE articulos_inventario SET cantidad=" & cant_inv & " WHERE id=" & TablaPiezas.Rows(i).Cells("id_inv").Value

                                    If tool.ActualizarDatosTransaccion(transaccionActualizar, consultaActualizar) Then
                                        With TablaPiezas.Rows(i)

                                            consultaActualizar = "SELECT max(id) FROM servicios_detalle"

                                            tablaConsulta = tool.ObtenerTablaTransaccion(transaccionActualizar, consultaActualizar)

                                            If tablaConsulta.Rows.Count > 0 Then
                                                id_det = tablaConsulta.Rows(0).Item(0)
                                            Else
                                                Throw New Exception("No se pudo obtener el valor maximo id detalle")
                                            End If

                                            tool.Insertar_Movimiento_ModuloTransaccion("SERVICIO", folio, id_det, .Cells("id_inv").Value, .Cells("np").Value, "SALIDA", .Cells("tipo").Value, .Cells("cant").Value, DateTime.Today, .Cells("desc").Value, cant_exitencia, cant_inv, 0, "TALLER TIBURON SERVICIO", 1, "NUEVO SERVICIO", transaccionActualizar)

                                            frmServicio_Info.tabla_articulos.Rows.Add(.Cells("cant").Value, .Cells("np").Value, .Cells("desc").Value, cant_inv)
                                        End With
                                    End If

                                End If
                            Else
                                If TablaPiezas.Rows(i).Cells("tipo").Value = "PACK" And TablaPiezas.Rows(i).Cells("id_inv").Value <> 0 Then
                                    tabladetalle.Rows.Clear()

                                    consultaActualizar = "SELECT * FROM articulos_pack WHERE id_pack=" & TablaPiezas.Rows(i).Cells("id").Value

                                    tablaConsulta = tool.ObtenerTablaTransaccion(transaccionActualizar, consultaActualizar)

                                    If tablaConsulta.Rows.Count > 0 Then
                                        For Each xRow As DataRow In tablaConsulta.Rows
                                            tabladetalle.Rows.Add(xRow.Item("id_np"), xRow.Item("cant"), xRow.Item("np"), xRow.Item("descripcion"), 0)
                                        Next
                                    Else
                                        Throw New Exception("no se pudo obtener información de paquete (pack)")
                                    End If

                                    For a = 0 To tabladetalle.Rows.Count - 1

                                        consultaActualizar = "SELECT id_inv FROM articulos WHERE id=" & tabladetalle.Rows(a).Cells("id_np").Value

                                        tablaConsulta = tool.ObtenerTablaTransaccion(transaccionActualizar, consultaActualizar)

                                        If tablaConsulta.Rows.Count > 0 Then
                                            tabladetalle.Rows(a).Cells("lista").Value = tablaConsulta.Rows(0).Item("id_inv")
                                        Else
                                            Throw New Exception("no hay información de Inventario" & tabladetalle.Rows(a).Cells("id_np").Value)
                                        End If

                                    Next
                                    For a = 0 To tabladetalle.Rows.Count - 1

                                        consultaActualizar = "SELECT cantidad FROM articulos_inventario WHERE id=" & tabladetalle.Rows(a).Cells("lista").Value

                                        tablaConsulta = tool.ObtenerTablaTransaccion(transaccionActualizar, consultaActualizar)

                                        If tablaConsulta.Rows.Count > 0 Then
                                            cant_inv = tablaConsulta.Rows(0).Item("cantidad")
                                            cant_exitencia = tablaConsulta.Rows(0).Item("cantidad")
                                        Else
                                            Throw New Exception("Ocurrio un al obtener la cantidad de inventario")
                                        End If


                                        cant_individual_pack = (tabladetalle.Rows(a).Cells("cant_np").Value * TablaPiezas.Rows(i).Cells("cant").Value)
                                        cant_inv -= cant_individual_pack

                                        consultaActualizar = "UPDATE articulos_inventario SET cantidad=" & cant_inv & " WHERE id=" & tabladetalle.Rows(a).Cells("lista").Value

                                        If tool.ActualizarDatosTransaccion(transaccionActualizar, consultaActualizar) Then
                                            With tabladetalle.Rows(a)

                                                consultaActualizar = "SELECT max(id) FROM servicios_detalle"

                                                tablaConsulta = tool.ObtenerTablaTransaccion(transaccionActualizar, consultaActualizar)

                                                If tablaConsulta.Rows.Count > 0 Then
                                                    id_det = tablaConsulta.Rows(0).Item(0)
                                                Else
                                                    Throw New Exception("no se pudo obtener el id maximo del detalle")
                                                End If

                                                tool.Insertar_Movimiento_ModuloTransaccion("SERVICIO", folio, id_det, .Cells("lista").Value, .Cells("np_np").Value, "SALIDA", "*", cant_individual_pack, DateTime.Today, .Cells("desc_np").Value, cant_exitencia, cant_inv, 0, "TALLER TIBURON SERVICIO", .Cells("cant_np").Value, "NUEVO SERVICIO", transaccionActualizar)

                                                frmServicio_Info.tabla_articulos.Rows.Add(.Cells("cant_np").Value, .Cells("np_np").Value, .Cells("desc_np").Value, cant_inv)
                                            End With
                                        End If
                                    Next
                                End If


                            End If

                            If i = TablaPiezas.Rows.Count - 1 Then
                                'MsgBox("Servicio " & folio & " guardado", MsgBoxStyle.Information)
                                transaccionActualizar.Commit()

                                frmServicio_Info.lblFolio.Text = folio
                                frmServicio_Info.lblestado.Text = "Guardado"

                                frmServicio_Info.ShowDialog()
                                btnClose.PerformClick()

                                frmAutos.WindowState = FormWindowState.Normal
                            End If
                        Else
                            Throw New Exception("no se pudo actualizar los datos")
                        End If

                    Next

                Catch ex As Exception
                    If transaccionActualizar IsNot Nothing Then
                        transaccionActualizar.Rollback()
                    End If
                    If transaccionActualizar.Connection IsNot Nothing Then
                        If transaccionActualizar.Connection.State = ConnectionState.Open Then
                            transaccionActualizar.Connection.Close()
                        End If
                    End If
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If
        Else
            MsgBox("Agrege articulos o servicios", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()
        For i = 0 To MDIPrincipal.MdiChildren.Length - 1
            If MDIPrincipal.MdiChildren(i).Name = "frmAutos" Then
                MDIPrincipal.MdiChildren(i).WindowState = FormWindowState.Normal
                MDIPrincipal.MdiChildren(i).MaximizeBox = False
            End If
        Next
    End Sub

    Private Sub btnDescuento_Click(sender As Object, e As EventArgs) Handles btnDescuento.Click
        frmServicio_AddManual.Dispose()
        frmServicio_AddManual.lblVentana.Text = "AGREGAR"
        frmServicio_AddManual.ShowDialog()
        Calcular()
    End Sub

    Private Sub TablaPiezas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaPiezas.CellClick

    End Sub
    Private Sub Mostrar_INVENTARIO()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        tabladetalle.Rows.Clear()

        lblInv.Text = ""
        lblcant_inv.Text = ""
        If TablaPiezas.Rows.Count > 0 Then
            Dim i As Integer = TablaPiezas.CurrentRow.Index

            If i <= -1 Then
                Return
            End If
            Try

                consulta = "SELECT cantidad FROM articulos_inventario WHERE id=" & TablaPiezas.Rows(i).Cells("id_inv").Value
                tablaResultado = tool.ObtenerTabla(consulta)
                If tablaResultado.Rows.Count Then
                    lblcant_inv.Text = tablaResultado.Rows(0).Item("cantidad")
                End If

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
                lblInv.Text = "Invetario " & TablaPiezas.Rows(i).Cells("id_inv").Value
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Obteniendo Inventario")
            End Try
        End If
    End Sub

    Private Sub TablaPiezas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaPiezas.CellContentClick

    End Sub

    Private Sub btnServicio_Click(sender As Object, e As EventArgs) Handles btnServicio.Click

    End Sub

    Private Sub CBCotizar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCotizar.SelectedIndexChanged
        If CBCotizar.SelectedIndex = 1 Then
            PANELOC.Show()
        Else
            PANELOC.Hide()
        End If
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

    Private Sub TablaPiezas_KeyDown(sender As Object, e As KeyEventArgs) Handles TablaPiezas.KeyDown
        If e.KeyCode = Keys.Delete Then
            If (TablaPiezas.CurrentRow.Index > 0) Then
                btnEliminar.PerformClick()

            End If
        End If
    End Sub

    Private Sub TablaPiezas_SelectionChanged(sender As Object, e As EventArgs) Handles TablaPiezas.SelectionChanged
        Mostrar_INVENTARIO()
    End Sub

    Private Sub Nprecio_GotFocus(sender As Object, e As EventArgs) Handles Nprecio.GotFocus
        Nprecio.Select(0, 1000)
    End Sub

    Private Sub Nprecio_KeyDown(sender As Object, e As KeyEventArgs) Handles Nprecio.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            btnGuardar.Focus()

        End If
    End Sub

    Private Sub Nprecio_ValueChanged(sender As Object, e As EventArgs) Handles Nprecio.ValueChanged

    End Sub
End Class