Imports MySql.Data.MySqlClient

Public Class Facturas

    Private Sub Facturas_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()

        End If
    End Sub

    Private Sub Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estructura_ventana(Me)
        CargarFolios()
        GrupoPanel.Show()

    End Sub
    Public Sub SelectUltimo()
        If TablaFacturas.Rows.Count > 0 Then
            Try
                TablaFacturas.Rows(0).Selected = True
            Catch ex As Exception

            End Try
            TablaFacturas.CurrentCell = TablaFacturas(1, 0)
            TablaFacturas.FirstDisplayedScrollingRowIndex = 0

            btnAgregar.Focus()

        End If
    End Sub
    Public Sub CargarFolios()
        TablaFacturas.Rows.Clear()
        TablaDetalle.Rows.Clear()
        Me.Cursor = Cursors.WaitCursor

        Dim tool As New Herramienta
        Dim tablaResultado As New DataTable
        Dim consulta As String = ""

        Try

            consulta = "SELECT factura.id, factura.folio, factura.idproveedor, factura.proveedor, factura.fecha, factura.estado, factura.total, factura.observacion, usuarios.name, factura.saldopendiente, factura.saldopagado FROM factura LEFT JOIN usuarios ON usuarios.id = factura.id_usuario WHERE folio LIKE '%" & txtFolio.Text & "%' AND proveedor LIKE '%" & txtRefa.Text & "%' AND observacion LIKE '%" & txtObserv.Text & "%' AND estado LIKE '%" & txtEstado.Text & "%' Order By id DESC LIMIT " & NMax.Value

            tablaResultado = tool.ObtenerTabla(consulta)

            If tablaResultado.Rows.Count > 0 Then
                For Each xRow As DataRow In tablaResultado.Rows
                    TablaFacturas.Rows.Add(xRow.Item("id"), xRow.Item("folio"), xRow.Item("idproveedor"), xRow.Item("proveedor"), xRow.Item("fecha"), xRow.Item("estado"), xRow.Item("total"), xRow.Item("observacion"), xRow.Item("name"), xRow.Item("saldopendiente"), xRow.Item("saldopagado"))
                Next
            End If

            lblFolios.Text = TablaFacturas.Rows.Count
            If TablaFacturas.Rows.Count > 99 Then
                NMax.BackColor = Color.DarkRed
            Else
                NMax.BackColor = Color.White

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "folios")
        End Try
        Try
            SumarTotales()

            CargarDetalle(0, "Cargar Folios")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Public Sub Mostrar_ultimo_agregados()

        Dim tool As New Herramienta
        Dim tablaResultado As New DataTable
        Dim consulta As String = ""

        TablaFacturas.Rows.Clear()
        TablaDetalle.Rows.Clear()
        txtEstado.Clear()
        txtFolio.Clear()
        txtObserv.Clear()



        Me.Cursor = Cursors.AppStarting
        Dim IdMax As Integer

        Try



            consulta = "SELECT max(id) FROM factura"

            tablaResultado = tool.ObtenerTabla(consulta)

            If tablaResultado.Rows.Count > 0 Then
                IdMax = tablaResultado.Rows(0).Item(0)
            End If

            If IdMax > 0 Then
                IdMax -= NMax.Value
                If Not IdMax > 0 Then
                    IdMax = 1

                End If
            Else
                Exit Sub

            End If

            consulta = "SELECT factura.id, factura.folio, factura.idproveedor, factura.proveedor, factura.fecha, factura.estado, factura.total, factura.observacion, usuarios.name, factura.saldopendiente, factura.saldopagado FROM factura LEFT JOIN usuarios ON usuarios.id = factura.id_usuario WHERE factura.id >" & IdMax & " ORDER BY id DESC LIMIT " & NMax.Value

            tablaResultado = tool.ObtenerTabla(consulta)

            If tablaResultado.Rows.Count > 0 Then
                For Each xRow As DataRow In tablaResultado.Rows
                    TablaFacturas.Rows.Add(xRow.Item("id"), xRow.Item("folio"), xRow.Item("idproveedor"), xRow.Item("proveedor"), xRow.Item("fecha"), xRow.Item("estado"), xRow.Item("total"), xRow.Item("observacion"), xRow.Item("name"), xRow.Item("saldopendiente"), xRow.Item("saldopagado"))
                Next
            End If

            lblFolios.Text = TablaFacturas.Rows.Count
            If TablaFacturas.Rows.Count > 99 Then
                NMax.BackColor = Color.DarkRed
            Else
                NMax.BackColor = Color.White

            End If


            If TablaFacturas.SelectedCells.Count > 0 And TablaFacturas.CurrentRow.Index >= 0 Then

                CargarDetalle(TablaFacturas.CurrentRow.Index, "UltimosAgre")

            Else
                If TablaFacturas.Rows.Count > 0 Then
                    CargarDetalle(0, "Ultimosagre")
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Ultimos Agregados")
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SumarTotales()
        Dim total As Decimal = 0
        If TablaFacturas.Rows.Count > 0 Then

            For i = 0 To TablaFacturas.Rows.Count - 1
                total += TablaFacturas.Rows(i).Cells("total").Value

            Next

        End If
        'NTotal.Value = total
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FacturasSelectProveedor.Dispose()
        Me.WindowState = FormWindowState.Minimized
        FacturasSelectProveedor.lblVentana.Text = "FAC"


        FacturasSelectProveedor.ShowDialog()
        btnAgregar.Focus()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        SelectUltimo()
    End Sub

    Private Sub buscar(sender As Object, e As EventArgs) Handles txtRefa.TextChanged, txtObserv.TextChanged
        If sender.TextLength > 0 Then
            CargarFolios()
        End If

    End Sub

    Private Sub TablaFacturas_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles TablaFacturas.CellBeginEdit

    End Sub

    Private Sub TablaFacturas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaFacturas.CellClick

    End Sub
    Private Sub CargarDetalle(i As Integer, operacion As String)

        Dim tool As New Herramienta
        Dim tablaResultado As New DataTable
        Dim consulta As String = ""

        Me.Cursor = Cursors.AppStarting

        If TablaFacturas.Rows.Count > 0 And GrupoPanel.Visible = True Then
            TablaDetalle.Rows.Clear()
            If i = 0 Then
                If TablaFacturas.CurrentRow.Index > 0 Then
                    i = TablaFacturas.CurrentRow.Index

                Else
                    i = 0

                End If

            End If
            txtObservacion.Text = TablaFacturas.Rows(i).Cells("observacion").Value
            'MsgBox(i & operacion)
            Try

                consulta = "SELECT * FROM facturadetalle WHERE idfactura =" & TablaFacturas.Rows(i).Cells("id").Value

                tablaResultado = tool.ObtenerTabla(consulta)

                If tablaResultado.Rows.Count > 0 Then
                    For Each xRow As DataRow In tablaResultado.Rows
                        TablaDetalle.Rows.Add(xRow.Item("cant"), xRow.Item("np"), xRow.Item("descripcion"), xRow.Item("costo"), xRow.Item("idnp_inv"), xRow.Item("id"), xRow.Item("cant_unidad"))
                    Next
                End If

                lbldetalle.Text = TablaDetalle.Rows.Count

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub TablaFacturas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaFacturas.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub txtEstado_TextChanged(sender As Object, e As EventArgs) Handles txtEstado.TextChanged
        CargarFolios()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

        Dim tool As New Herramienta
        Dim consulta As String = ""


        If TablaFacturas.Rows.Count > 0 Then
            Dim i As Integer = TablaFacturas.CurrentRow.Index
            Try

                consulta = "UPDATE factura SET observacion='" & txtObservacion.Text & "' WHERE id=" & TablaFacturas.Rows(i).Cells("id").Value

                If tool.ActualizarDatos(consulta) Then
                    MsgBox("Actualizado", MsgBoxStyle.Information)
                    CargarFolios()
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If
    End Sub

    Private Sub btnCancelarFAC_Click(sender As Object, e As EventArgs) Handles btnCancelarFAC.Click
        Dim respuestas As String = ""
        Dim cant_INV As Integer = 0
        Dim cant_exitencia As Integer = 0
        Dim id_provee As Integer
        Dim proveedor As String = ""
        Dim motivo As String = "FAC CANCELADA"
        Dim tipo_mov As String = "SALIDA"

        Dim comando As New MySqlCommand
        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable
        Dim transaccionActualizar As MySqlTransaction = Nothing

        If TablaFacturas.Rows.Count > 0 Then
            If Not (TablaFacturas.CurrentRow Is Nothing) Then
                Dim i As Integer = TablaFacturas.CurrentRow.Index
                If i >= 0 And TablaFacturas.Rows(i).Selected = True Then ' si no esta seleccionado nada
                    id_provee = TablaFacturas.Rows(i).Cells("idpro").Value
                    proveedor = TablaFacturas.Rows(i).Cells("refa").Value
                Else
                    MsgBox("Seleccione una factura para cancelar", MsgBoxStyle.Information)
                    Exit Sub

                End If



                If TablaDetalle.Rows.Count > 0 Then

                Else
                    If MsgBox("¿esta factura no tiene articulos ¿desea cancelarlo ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Else
                        Exit Sub
                    End If
                End If
                If Not TablaFacturas.Rows(i).Cells("estado").Value = "CANCELADO" Then

                Else
                    MsgBox("Esta factura ya se encontraba cancelada", MsgBoxStyle.Information)
                    Exit Sub
                End If
                frmFacturas_Det.Dispose()
                For a = 0 To TablaDetalle.Rows.Count - 1
                    If TablaDetalle.Rows(a).Cells("idinv").Value > 0 Then
                        With TablaDetalle.Rows(a)
                            frmFacturas_Det.TablaDetalle.Rows.Add(.Cells("cant").Value, .Cells("np").Value, .Cells("desc").Value, .Cells("costo").Value, .Cells("idinv").Value, "", .Cells("iddet").Value, .Cells("x_cant").Value)

                        End With

                    End If

                Next
                For x = 0 To frmFacturas_Det.TablaDetalle.Rows.Count - 1

                    consulta = "SELECT cantidad FROM articulos_inventario WHERE id=" & frmFacturas_Det.TablaDetalle.Rows(x).Cells("idinv").Value

                    tablaResultado = tool.ObtenerTabla(consulta)

                    If tablaResultado.Rows.Count > 0 Then
                        frmFacturas_Det.TablaDetalle.Rows(x).Cells("C_Actual").Value = tablaResultado.Rows(0).Item("cantidad")
                    End If
                Next
                If frmFacturas_Det.TablaDetalle.Rows.Count > 0 Then
                    frmFacturas_Det.ShowDialog()
                End If
                If frmFacturas_Det.lbltitulo.Text = "cancelando..." Then
                    Exit Sub

                End If

                If MsgBox("Deseas Cancelar esta Factura: " & TablaFacturas.Rows(i).Cells("folio").Value & " Proveedor: " & TablaFacturas.Rows(i).Cells("refa").Value, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    respuestas = InputBox("Ingrese una observación del concepto de la cancelación", "CANCELAR FACTURA", "Cancelacion del Sistema Proveedor")
                    Dim folio_factura As String = TablaFacturas.Rows(i).Cells("folio").Value

                    If respuestas.Length > 0 Then
                        Try

                            comando.Connection = New MySqlConnection
                            comando.Connection.ConnectionString = con.ConnectionString
                            comando.Connection.Open()

                            transaccionActualizar = comando.Connection.BeginTransaction


                            consulta = "UPDATE factura SET estado='CANCELADO', observacion='" & TablaFacturas.Rows(i).Cells("observacion").Value & " Cancelado: " & respuestas & "' WHERE id=" & TablaFacturas.Rows(i).Cells("id").Value

                            If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                                For i = 0 To frmFacturas_Det.TablaDetalle.Rows.Count - 1

                                    consulta = "SELECT cantidad FROM articulos_inventario where id =" & frmFacturas_Det.TablaDetalle.Rows(i).Cells("idinv").Value

                                    tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)

                                    If tablaResultado.Rows.Count > 0 Then
                                        cant_INV = tablaResultado.Rows(0).Item("cantidad")
                                        cant_exitencia = tablaResultado.Rows(0).Item("cantidad")
                                    Else
                                        Throw New Exception("no se encontro la cantidad de inventario")
                                    End If

                                    If TablaFacturas.Rows(i).Cells("total").Value > 0 Then
                                        'FACTURA SALIDA
                                        motivo = "FAC CANCELADA"
                                        tipo_mov = "SALIDA"

                                        cant_INV -= (frmFacturas_Det.TablaDetalle.Rows(i).Cells("cant").Value * frmFacturas_Det.TablaDetalle.Rows(i).Cells("x_cant").Value)

                                    Else
                                        tipo_mov = "ENTRADA"
                                        motivo = "NOTA DE CRED. CANCELADA"
                                        cant_INV += (frmFacturas_Det.TablaDetalle.Rows(i).Cells("cant").Value * frmFacturas_Det.TablaDetalle.Rows(i).Cells("x_cant").Value)
                                        'NOTA DE CREDITO ENTRADA
                                    End If

                                    consulta = "UPDATE articulos_inventario SET cantidad=" & cant_INV & " WHERE id=" & frmFacturas_Det.TablaDetalle.Rows(i).Cells("idinv").Value

                                    If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then

                                        consulta = "UPDATE facturadetalle SET idnp_inv=0 WHERE id=" & frmFacturas_Det.TablaDetalle.Rows(i).Cells("id").Value

                                        If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then

                                        Else
                                            Throw New Exception("no se pudo actualizar detalle de la factura")
                                        End If

                                        Dim id_factura As Integer = TablaFacturas.Rows(i).Cells("id").Value

                                        With frmFacturas_Det.TablaDetalle.Rows(i)
                                            tool.Insertar_Movimiento_ModuloTransaccion("FACTURA", folio_factura, id_factura, .Cells("idinv").Value, .Cells("np").Value, tipo_mov, "*", .Cells("cant").Value, DateTime.Today, .Cells("desc").Value, cant_exitencia, cant_INV, id_provee, proveedor, frmFacturas_Det.TablaDetalle.Rows(i).Cells("x_cant").Value, motivo, transaccionActualizar)

                                            .Cells("c_actual").Value = cant_INV

                                        End With

                                    End If

                                Next

                                transaccionActualizar.Commit()

                                frmFacturas_Det.ShowDialog()
                                Mostrar_ultimo_agregados()
                                SelectUltimo()
                                SumarTotales()

                            End If


                        Catch ex As Exception

                            If transaccionActualizar IsNot Nothing Then
                                transaccionActualizar.Rollback()
                            End If

                            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                        Finally

                        End Try
                    End If

                End If
            End If



        End If
    End Sub

    Private Sub Facturas_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint


    End Sub

    Private Sub Facturas_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' estructura_ventana(Me)

        '  CargarDetalle(0)



    End Sub



    Private Sub txtFolio_TextChanged(sender As Object, e As EventArgs) Handles txtFolio.TextChanged

        If txtFolio.TextLength = 0 Then

        Else
            NMax.Value = 100
            txtEstado.Clear()
            CargarFolios()
        End If


    End Sub

    Private Sub btnNota_Click(sender As Object, e As EventArgs) Handles btnNota.Click
        FacturasSelectProveedor.Dispose()
        FacturasSelectProveedor.lblVentana.Text = "NOTA"
        FacturasSelectProveedor.ShowDialog()
    End Sub

    Private Sub NMax_KeyDown(sender As Object, e As KeyEventArgs) Handles NMax.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            CargarFolios()


        End If
    End Sub

    Private Sub NMax_ValueChanged(sender As Object, e As EventArgs) Handles NMax.ValueChanged

    End Sub

    Private Sub TablaFacturas_CellContextMenuStripChanged(sender As Object, e As DataGridViewCellEventArgs) Handles TablaFacturas.CellContextMenuStripChanged

    End Sub

    Private Sub TablaFacturas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles TablaFacturas.CellEndEdit

    End Sub

    Private Sub TablaFacturas_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles TablaFacturas.RowValidated

    End Sub

    Private Sub TablaFacturas_SelectionChanged(sender As Object, e As EventArgs) Handles TablaFacturas.SelectionChanged
        TablaDetalle.Rows.Clear()
        If TablaFacturas.MultiSelect = False Then
            btnCancelarFAC.Enabled = True
            Mover.BackColor = Color.White
        Else
            btnCancelarFAC.Enabled = False
        End If
        ' 
            If TablaFacturas.Rows.Count > 0 Then
                If TablaFacturas.Rows(TablaFacturas.Rows.Count - 1).Selected = True And TablaFacturas.MultiSelect = False Then
                    TablaFacturas.CurrentCell = TablaFacturas(1, TablaFacturas.RowCount - 1)
                    CargarDetalle(TablaFacturas.CurrentRow.Index, "Selection changed")

                Else
                    If TablaFacturas.SelectedCells.Count > 0 Then
                        CargarDetalle(TablaFacturas.CurrentRow.Index, "Selection changed")
                    End If

                End If



            End If
            If TablaFacturas.SelectedCells.Count > 0 And TablaFacturas.MultiSelect = False Then
                'esta visible la seleccion
                _pagos.Show()
            Else
                _pagos.Hide()
            End If



    End Sub

    

    Private Sub GrupoPanel_Paint(sender As Object, e As PaintEventArgs) Handles GrupoPanel.Paint

    End Sub

    Private Sub btnINV_Click(sender As Object, e As EventArgs) Handles btnINV.Click
        If TablaFacturas.Rows.Count > 0 Then
            Dim i As Integer = TablaFacturas.CurrentRow.Index
            With Facturas_INV
                .index_fac = i

                .lblidfac.Text = TablaFacturas.Rows(i).Cells("id").Value
                .lblfolio.Text = TablaFacturas.Rows(i).Cells("folio").Value
                .lblproveedor.Text = TablaFacturas.Rows(i).Cells("refa").Value
                .cargar_detalle()
                .ShowDialog()
                If .index_fac >= 0 Then
                    CargarDetalle(i, "invetario")
                End If
            End With
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Mover_Click(sender As Object, e As EventArgs) Handles Mover.Click
        If TablaFacturas.MultiSelect = True Then
            TablaFacturas.MultiSelect = False
            TablaFacturas.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            btnCancelarFAC.Enabled = True
            Mover.BackColor = Color.White


        Else
            TablaFacturas.MultiSelect = True
            TablaFacturas.SelectionMode = DataGridViewSelectionMode.CellSelect
            btnCancelarFAC.Enabled = False
            Mover.BackColor = Color.Yellow


        End If
    End Sub

    Private Sub lblFolios_Click(sender As Object, e As EventArgs) Handles lblFolios.Click
        Mostrar_ultimo_agregados()
        SelectUltimo()
        SumarTotales()



    End Sub
End Class