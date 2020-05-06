Public Class frmAutos
    Public ncamion As Integer = 0

    Private Sub frmAutos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            e.Handled = True
            Me.Close()

        End If
    End Sub

    Private Sub frmAutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.AppStarting
        cargarAuto()
        estructura_ventana(Me)
        barra.Maximum = Me.Width
        barra.Value = PanelAutos.Width
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cargarAuto()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultados As New DataTable
        

        LimpiarRegistrosDataGrid()
        Try

            consulta = "SELECT id,nuevo,anterior,marca,modelo,serie,placas,year,texto, Activo FROM autos WHERE activo = 1 and nuevo LIKE '%" & txtATQ.Text & "%' AND anterior LIKE '%" & txtAnterior.Text & "%' AND marca LIKE '%" & txtMarca.Text & "%' AND year LIKE '%" & txtaño.Text & "%'"
            tablaResultados = tool.ObtenerTabla(consulta)

            If tablaResultados.Rows.Count > 0 Then
                For Each xRow As DataRow In tablaResultados.Rows
                    tablaAutos.Rows.Add(xRow.Item("id"), xRow.Item("nuevo"), xRow.Item("anterior"), xRow.Item("marca"), xRow.Item("modelo"), xRow.Item("serie"), xRow.Item("placas"), xRow.Item("year"), xRow.Item("texto"), xRow.Item("Activo"))
                Next

            End If

            lblAutos.Text = tablaAutos.Rows.Count
            If tablaAutos.Rows.Count > 0 Then
                ncamion = tablaAutos.Rows(tablaAutos.CurrentRow.Index).Cells("id").Value
                cargarDetalle(ncamion)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "AUTO")
        End Try


        '-------------- AUTOS DESACTIVADOS
        Try
            tool = New Herramienta

            consulta = "SELECT id,nuevo,anterior,marca,modelo,serie,placas,year,texto, Activo FROM autos WHERE activo = 0 and nuevo LIKE '%" & txtATQ.Text & "%' AND anterior LIKE '%" & txtAnterior.Text & "%' AND marca LIKE '%" & txtMarca.Text & "%' AND year LIKE '%" & txtaño.Text & "%'"
            tablaResultados = tool.ObtenerTabla(consulta)

            If tablaResultados.Rows.Count > 0 Then
                If tablaResultados.Rows.Count > 0 Then
                    For Each xRow As DataRow In tablaResultados.Rows
                        tablaAutosDesactivados.Rows.Add(xRow.Item("id"), xRow.Item("nuevo"), xRow.Item("anterior"), xRow.Item("marca"), xRow.Item("modelo"), xRow.Item("serie"), xRow.Item("placas"), xRow.Item("year"), xRow.Item("texto"), xRow.Item("Activo"))
                    Next

                End If
            End If
            TabDesactivados.Text = "Autos Viejos (Desactivados) (" & tablaAutosDesactivados.Rows.Count & ")"

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "AUTO")
        End Try
    End Sub

    Private Sub txtAnterior_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            'btnServicio.PerformClick()

        End If
    End Sub





    Private Sub buscar(sender As Object, e As EventArgs)
        cargarAuto()
    End Sub

    Private Sub btnServicio_Click(sender As Object, e As EventArgs) Handles btnServicio.Click
        Dim folio_ser As Integer = 0
        Dim result As String = ""
        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultados As New DataTable

        pendientes.tabla.Rows.Clear()
        Dim primera As Boolean = True
        If tablaAutos.Rows.Count > 0 Then
            Dim i As Integer = tablaAutos.CurrentRow.Index
            'CONSULTAR
            Try

                pendientes.lblUnidad.Text = tablaAutos.Rows(i).Cells("nuevo").Value & " " & tablaAutos.Rows(i).Cells("texto").Value & " " & tablaAutos.Rows(i).Cells("anterior").Value

                consulta = "SELECT det.cant,det.id_inv, det.np, det.descripcion, det.precio, det.folio, det.fecha, det.MARCADO, ser.numero, ser.OC, ser.para from servicios_detalle det LEFT JOIN servicios ser ON ser.id = det.folio WHERE (det.idauto=" & tablaAutos.Rows(i).Cells("id").Value & " AND det.MARCADO='PENDIENTE') or (ser.numero =0 AND ser.cotizar='SI' AND ser.ncamion=" & tablaAutos.Rows(i).Cells("id").Value & ") order by det.fecha DESC, det.id DESC"
                tablaResultados = tool.ObtenerTabla(consulta)
                If tablaResultados.Rows.Count > 0 Then
                    For Each xRow As DataRow In tablaResultados.Rows
                        Dim textoCotMarcado As String = ""
                        If Val(xRow.Item("numero")) = 0 Then
                            textoCotMarcado = "SinCotizar"
                        Else
                            textoCotMarcado = xRow.Item("MARCADO")
                        End If
                        pendientes.tabla.Rows.Add(xRow.Item("cant"), xRow.Item("id_inv"), xRow.Item("np"), xRow.Item("descripcion"), xRow.Item("precio"), xRow.Item("folio"), xRow.Item("numero"), xRow.Item("fecha"), textoCotMarcado, xRow.Item("OC"), xRow.Item("para"))
                    Next

                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try


            If pendientes.tabla.Rows.Count > 0 Then
                pendientes.btnAbrir.Enabled = True
            Else
                pendientes.btnAbrir.Enabled = False
            End If
            pendientes.ShowDialog()
            'cargarDetalle()

        End If


    End Sub
    Private Sub codigo_viejo_pendietes()
        Dim folio_ser As Integer
        Dim result As Integer
        If folio_ser <> 0 Then
            result = MsgBox("Hay un servicio pendiente ¿Deseas abrir este servicio PENDIENTE?", MsgBoxStyle.YesNoCancel)

            If result = 6 Then
                Me.WindowState = FormWindowState.Minimized
                frmServicio_Editar.MdiParent = MDIPrincipal
                frmServicio_Editar.NFolio.Value = folio_ser
                frmServicio_Editar.Show()
                Exit Sub
            ElseIf result = 7 Then


                agregar_servicio()

            End If
        Else
            agregar_servicio()
        End If
    End Sub
    Public Sub agregar_servicio()
        Dim i As Integer = tablaAutos.CurrentRow.Index
        frmServicio_Agregar.Dispose()
        With frmServicio_Agregar
            .lblID.Text = tablaAutos.Rows(i).Cells("id").Value
            .lblNuevo.Text = tablaAutos.Rows(i).Cells("nuevo").Value
            .lblAnterior.Text = tablaAutos.Rows(i).Cells("anterior").Value
            .lblplacas.Text = tablaAutos.Rows(i).Cells("placas").Value
            .lblserie.Text = tablaAutos.Rows(i).Cells("serie").Value
            .lblaño.Text = tablaAutos.Rows(i).Cells("año").Value
            .lblMarca.Text = tablaAutos.Rows(i).Cells("marca").Value
            .lblmodelo.Text = tablaAutos.Rows(i).Cells("modelo").Value
        End With
        Me.WindowState = FormWindowState.Minimized


        frmServicio_Agregar.MdiParent = MDIPrincipal
        frmServicio_Agregar.Show()
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If tablaAutos.Rows.Count > 0 Then
            Dim i As Integer = tablaAutos.CurrentRow.Index
            With frmAutosEditar
                .lblNuevo.Text = tablaAutos.Rows(i).Cells("nuevo").Value
                .lblAnterior.Text = tablaAutos.Rows(i).Cells("anterior").Value.ToString
                .lblID.Text = tablaAutos.Rows(i).Cells("id").Value
                .txtNuevoATQ.Text = tablaAutos.Rows(i).Cells("nuevo").Value
                .txtAnteriorRuta.Text = tablaAutos.Rows(i).Cells("anterior").Value
                .txtAño.Text = tablaAutos.Rows(i).Cells("año").Value
                .txtMarca.Text = tablaAutos.Rows(i).Cells("marca").Value
                .txtModelo.Text = tablaAutos.Rows(i).Cells("modelo").Value
                .txtserie.Text = tablaAutos.Rows(i).Cells("serie").Value
                .txtplacas.Text = tablaAutos.Rows(i).Cells("placas").Value
                .txtTexto.Text = tablaAutos.Rows(i).Cells("texto").Value
                .CheckActivo.Checked = CBool(tablaAutos.Rows(i).Cells("Activo").Value)

            End With
            frmAutosEditar.ShowDialog()
            cargarAuto()
        End If
    End Sub

    Private Sub cargarDetalle(IdAuto As Integer)

        tablaNP.Rows.Clear()

        Dim consulta As String = ""
        Dim tool As New Herramienta
        Dim tablaResultado As New DataTable
        Dim Atq As String, Ruta As String, esActivo As Boolean

        consulta = "SELECT id, anterior, nuevo, activo FROM autos WHERE id =" & IdAuto
        Try
            tablaResultado = tool.ObtenerTabla(consulta)
            If tablaResultado.Rows.Count > 0 Then
                Atq = tablaResultado.Rows(0).Item("nuevo")
                Ruta = tablaResultado.Rows(0).Item("anterior")
                esActivo = tablaResultado.Rows(0).Item("activo")
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Return
        End Try
        

        TabServiciosRealizados.Text = "DETALLE DE #" & IdAuto & " ATQ:" & Atq & " - " & Ruta
        If esActivo Then
            TabServiciosRealizados.Text &= " (ACTIVO)"
        Else
            TabServiciosRealizados.Text &= " (DESACTIVADO)"
        End If
        Try

            If tablaAutos.Rows.Count > 0 Then
                ' tablaAutos.CurrentCell = tablaAutos(1, 0)
            End If

            If tablaAutos.Rows.Count > 0 And datos.IsClosed And tablaAutos.SelectedCells.Count > 0 Then
                Dim i As Integer = tablaAutos.CurrentRow.Index

                If i <= -1 Then
                    Return
                End If

                
                consulta = "SELECT det.idpieza,det.np,det.descripcion,det.cant,det.precio,det.costo,det.mano,det.fecha, det.MARCADO, det.folio,det.id_inv,serv.para,serv.numero, serv.OC, serv.SC, serv.FACTURA FROM servicios_detalle det INNER JOIN servicios serv ON det.folio=serv.id AND det.idauto=" & IdAuto & " AND det.descripcion LIKE '%" & txtDESC.Text & "%' AND det.np like '%" & txtnp.Text & "%'"

                If cbMarcado.SelectedIndex > 0 Then
                    consulta = consulta + "AND det.MARCADO='" & cbMarcado.Text & "'"
                End If

                consulta = consulta + " ORDER BY det.fecha DESC, det.idpieza DESC"

                tablaResultado = tool.ObtenerTabla(consulta)

                If tablaResultado.Rows.Count > 0 Then
                    For Each xRow As DataRow In tablaResultado.Rows
                        tablaNP.Rows.Add(xRow.Item("idpieza"), xRow.Item("np"), xRow.Item("descripcion"), xRow.Item("cant"), xRow.Item("precio"), xRow.Item("costo"), xRow.Item("mano"), xRow.Item("fecha"), xRow.Item("MARCADO"), xRow.Item("folio"), xRow.Item("id_inv"), xRow.Item("para"), xRow.Item("numero"), xRow.Item("OC"), xRow.Item("FACTURA"), xRow.Item("SC"))
                    Next
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "CargarDetalle")
        End Try


    End Sub


    Private Sub buscar_conceptos()

        tablaRenglon.Rows.Clear()
        Dim tool As New Herramienta
        Dim tablaResultado As New DataTable
        Dim consulta As String = ""
        Dim tx As String = ""
        Dim i As Integer = -1
        Try
            If tablaAutos.Rows.Count > 0 Then

                i = tablaAutos.CurrentRow.Index

                If i <= -1 Then
                    Return
                End If

                consulta = "SELECT det.cantidad, det.fecha, det.descripcion, det.precio, det.ncotizacion, det.tipo, ser.OC FROM servicios_cotdetalle det LEFT JOIN servicios ser ON ser.id = det.id_servicio WHERE det.camion=" & tablaAutos.Rows(i).Cells("id").Value & " AND det.descripcion like '%" & txtConcepto.Text & "%' ORDER BY det.fecha DESC, det.numero DESC"
                tablaResultado = tool.ObtenerTabla(consulta)

                If tablaResultado.Rows.Count > 0 Then
                    For Each xRow As DataRow In tablaResultado.Rows
                        If xRow.Item("tipo") = "REAL" Then
                            tx = ""
                        End If
                        If xRow.Item("tipo") = "ANEXADO (+)" Then
                            tx = "+"
                        End If
                        If xRow.Item("tipo") = "AGREGADO (*)" Then
                            tx = "*"
                        End If
                        tablaRenglon.Rows.Add(xRow.Item("cantidad"), xRow.Item("fecha"), 0, xRow.Item("descripcion") + tx, xRow.Item("precio"), xRow.Item("ncotizacion"), "", "", xRow.Item("OC"))
                    Next

                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "buscar")
        End Try

    End Sub

    Private Sub txtnp_TextChanged(sender As Object, e As EventArgs) Handles txtDESC.TextChanged
        cargarDetalle(ncamion)
    End Sub
    Private Sub BuscarNP()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub frmAutos_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        cbMarcado.SelectedIndex = 0

    End Sub

    Private Sub txtATQ_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            'btnServicio.PerformClick()

        End If
    End Sub


    Private Sub txtATQ_TextChanged(sender As Object, e As EventArgs)
        tabladetalle.Rows.Clear()
        tablacot.Rows.Clear()
        tablaRenglon.Rows.Clear()
        tablaNP.Rows.Clear()
        'cargarAuto()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        frmAutosAgregar.Dispose()
        frmAutosAgregar.ShowDialog()

    End Sub

    Private Sub txtConcepto_TextChanged(sender As Object, e As EventArgs) Handles txtConcepto.TextChanged
        'buscar_conceptos()
    End Sub

    Private Sub tablaAutos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaAutos.CellDoubleClick
        btnEditar.PerformClick()
    End Sub


    Private Sub tablaAutos_KeyDown(sender As Object, e As KeyEventArgs) Handles tablaAutos.KeyDown
        'cargarDetalle()
        ' buscar_conceptos()
        'If e.KeyCode = Keys.Enter Then
        '    e.Handled = True
        '    btnServicio.PerformClick()

        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim tool As New Herramienta
        Dim tablaResultado As New DataTable
        Dim consulta As String = ""

        If txtConcepto.TextLength > 0 Then
        Else
            MsgBox("Ingrese un concepto a buscar, para todas la unidades (atq)", MsgBoxStyle.Information)
            txtConcepto.Focus()
            Exit Sub

        End If

        Try

            consulta = "SELECT det.cantidad, det.fecha, det.np, det.descripcion, det.precio, det.ncotizacion, det.camion, autos.nuevo, autos.marca, autos.anterior, ser.OC FROM servicios_cotdetalle det LEFT JOIN autos ON det.camion= autos.id LEFT JOIN servicios ser ON ser.id = det.id_servicio WHERE descripcion like '%" & txtConcepto.Text & "%' order by det.fecha desc, det.numero desc"
            tablaResultado = tool.ObtenerTabla(consulta)
            tablaRenglon.Rows.Clear()

            If tablaResultado.Rows.Count > 0 Then
                tablaRenglon.Columns("ATQ").Visible = True
                tablaRenglon.Columns("MARCA1").Visible = True
                tablaRenglon.Columns("OC").Visible = True
                For Each xRow As DataRow In tablaResultado.Rows
                    tablaRenglon.Rows.Add(xRow.Item("cantidad"), xRow.Item("fecha"), xRow.Item("np"), xRow.Item("descripcion"), xRow.Item("precio"), xRow.Item("ncotizacion"), xRow.Item("nuevo") & " - " & xRow.Item("anterior"), xRow.Item("marca"), xRow.Item("OC"))
                Next
            End If



        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "btn")
        End Try
    End Sub

    Private Sub tablaRenglon_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaRenglon.CellClick

    End Sub

    Private Sub tablaRenglon_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaRenglon.CellContentClick

    End Sub

    Private Sub tablaRenglon_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaRenglon.CellDoubleClick
        If tablaRenglon.Rows.Count > 0 And tablaRenglon.SelectedCells.Count >= 1 Then

            Dim i As Integer = tablaRenglon.CurrentRow.Index

            'tablaRenglon.Rows(i).Cells("cot").Value

            MDIPrincipal.Button7.PerformClick()
            frmServicio.txtNumero.Text = tablaRenglon.Rows(i).Cells("cot").Value
            frmServicio.btnConsultar.PerformClick()


        End If
    End Sub

    Private Sub tablaAutos_SelectionChanged(sender As Object, e As EventArgs) Handles tablaAutos.SelectionChanged

        Dim Atq As String = ""
        Dim ruta As String = ""

        Try
            If tablaAutos.SelectedCells.Count > 0 Then
                If tablaAutos.Rows.Count > 0 Then
                    ' tablaAutos.CurrentCell = tablaAutos(1, 0)
                    If tablaAutos.CurrentRow Is Nothing Then
                        Return
                    End If
                    If tablaAutos.CurrentRow.Index <= -1 Then
                        Return
                    End If
                    ncamion = tablaAutos.Rows(tablaAutos.CurrentRow.Index).Cells("id").Value
                    Atq = tablaAutos.Rows(tablaAutos.CurrentRow.Index).Cells("nuevo").Value.ToString
                    ruta = tablaAutos.Rows(tablaAutos.CurrentRow.Index).Cells("anterior").Value.ToString
                    'buscar_conceptos()

                    cargarDetalle(ncamion)
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Seleccion")
        End Try

    End Sub


    Private Sub barra_Scroll(sender As Object, e As EventArgs) Handles barra.Scroll
        PanelAutos.Width = barra.Value
    End Sub

    Private Sub txtnp_TextChanged_1(sender As Object, e As EventArgs) Handles txtnp.TextChanged
        'cargarDetalle()
    End Sub

    Private Sub btnReporte_Click(sender As Object, e As EventArgs) Handles btnReporte.Click
        frmServicio_Reporte.cargar_pendientes()
        frmServicio_Reporte.ShowDialog()
    End Sub


    Private Sub tablaNP_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tablaNP.CellMouseDoubleClick
        If tablaNP.SelectedCells.Count >= 1 Then
            Dim i As Integer = tablaNP.CurrentRow.Index
            If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then

                MDIPrincipal.Button7.PerformClick()
                frmServicio.txtSER.Text = tablaNP.Rows(i).Cells("folio").Value
                frmServicio.btnConsultar.PerformClick()
            End If

        End If
    End Sub

    Private Sub LimpiarParaBusqueda(sender As Object, e As EventArgs)
        LimpiarRegistrosDataGrid()
        TabDesactivados.Text = "Autos Viejos (Desactivados)"

    End Sub
    Private Sub LimpiarRegistrosDataGrid()
        tablaAutos.Rows.Clear()
        tablacot.Rows.Clear()
        tabladetalle.Rows.Clear()
        tablaAutosDesactivados.Rows.Clear()
        tablaNP.Rows.Clear()
    End Sub


    Private Sub BuscarConBoton(sender As Object, e As KeyEventArgs) Handles txtATQ.KeyDown, txtAnterior.KeyDown, txtMarca.KeyDown, txtaño.KeyDown
        If e.KeyCode = Keys.Enter Then
            cargarAuto()
            btnBuscar.Focus()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBuscarDetalle.Click
        'cargarDetalle()

    End Sub

    Private Sub btnBuscarConceptos_Click(sender As Object, e As EventArgs) Handles btnBuscarConceptos.Click
        buscar_conceptos()
    End Sub

    Private Sub btnBuscar_Click_1(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cargarAuto()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarRegistrosDataGrid()
        txtATQ.Clear()
        txtAnterior.Clear()
        txtMarca.Clear()
        txtaño.Clear()

    End Sub

    Private Sub TecleadoNuevaInformacion(sender As Object, e As EventArgs) Handles txtMarca.TextChanged, txtATQ.TextChanged, txtAnterior.TextChanged, txtaño.TextChanged

        LimpiarRegistrosDataGrid()

    End Sub

    Private Sub tablaAutosDesactivados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaAutosDesactivados.CellClick

        Dim IndexAutoDesactivado As Integer = -1


        tablaNP.Rows.Clear()
        tablacot.Rows.Clear()
        tabladetalle.Rows.Clear()

        If tablaAutosDesactivados.Rows.Count = 0 Then
            Return
        End If

        If tablaAutosDesactivados.CurrentRow Is Nothing Then
            Return
        End If

        IndexAutoDesactivado = tablaAutosDesactivados.CurrentRow.Index

        If IndexAutoDesactivado = -1 Then
            Return
        End If

        With tablaAutosDesactivados.Rows(IndexAutoDesactivado)
            ncamion = .Cells(ColDesactivadoID.Name).Value
            
            cargarDetalle(ncamion)
        End With

    End Sub

    Private Sub tablaAutosDesactivados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaAutosDesactivados.CellContentClick

    End Sub

    Private Sub btnCotizar_Click(sender As Object, e As EventArgs) Handles btnCotizar.Click
        If tablaAutos.Rows.Count > 0 Then
            Dim ventanaNuevaCot As New frmCotizacionNuevoEditar
            ventanaNuevaCot.MdiParent = MDIPrincipal
            Me.WindowState = FormWindowState.Minimized
            ventanaNuevaCot.Show()
        End If
    End Sub
End Class