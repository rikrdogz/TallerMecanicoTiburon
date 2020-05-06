Public Class frmArticuloAgregar
    Dim seguirBuscandoNP As Boolean = True
    Dim NumeroDeParte As String = ""
    Private Sub frmArticuloAgregar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("¿Deseas Cerrar esta Ventana", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmArticuloAgregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximizeBox = False
        Me.Width = MDIPrincipal.Width
        Me.Height = MDIPrincipal.Height - 88
        txtcodigo.Focus()


    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim suma As Decimal
        suma = nprecio.Value + NMano.Value

        If txtcodigo.TextLength > 0 Then

            If txtdesc.TextLength > 0 Then
                If suma > 0 Then 'OJO VER SI ES SERVICIO O ARTICULO


                    If CBMarca.Text.Length > 2 Then
                        If CBTipo.SelectedIndex >= 0 Then
                            If CBTipo.Text = "ARTICULO" Then
                                InsertarArticulo()
                            ElseIf CBTipo.Text = "SERVICIO" Or CBTipo.Text = "PACK" Then
                                InsertarArticulo()

                            End If
                        Else
                            MsgBox("Ingrese un tipo SERVICIO o ARTICULO", MsgBoxStyle.Information)
                            CBTipo.Focus()
                        End If

                    Else
                        MsgBox("Ingrese Marca mayor a 2 caracteres", MsgBoxStyle.Information)
                        CBMarca.Focus()
                    End If
                Else
                    If CBTipo.Text = "ARTICULO" Then
                        MsgBox("ingrese precio del articulo", MsgBoxStyle.Information)
                    ElseIf CBTipo.Text = "SERVICIO" Then
                        MsgBox("Ingrese precio del servicio", MsgBoxStyle.Information)
                    Else
                        MsgBox("NO HAY VALOR $ DE VENTA", MsgBoxStyle.Information)
                    End If
                    nprecio.Focus()
                End If
            Else
                MsgBox("Ingrese Descripcion", MsgBoxStyle.Information)
                txtdesc.Focus()
            End If
        Else
            MsgBox("Ingrese Numero de parte / Codigo", MsgBoxStyle.Information)
            txtcodigo.Focus()

        End If
    End Sub
    Private Sub InsertarArticulo()
        Dim valores As String = ""
        Dim crearNP As Double = True
        Dim id_inv As Integer = 0
        Dim cant_unidad As Integer = 0
        Dim comando As New MySql.Data.MySqlClient.MySqlCommand
        Dim transaccionActualizar As MySql.Data.MySqlClient.MySqlTransaction = Nothing

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Try
            comando.Connection = New MySql.Data.MySqlClient.MySqlConnection
            comando.Connection.ConnectionString = con.ConnectionString
            comando.Connection.Open()

            transaccionActualizar = comando.Connection.BeginTransaction
            comando.Transaction = transaccionActualizar

            consulta = "SELECT id,np, descripcion,cant_unidad FROM articulos_inventario WHERE np='" & txtcodigo.Text & "'"
            tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)
            If tablaResultado.Rows.Count > 0 Then

                id_inv = tablaResultado.Rows(0).Item("id")
                cant_unidad = tablaResultado.Rows(0).Item("cant_unidad")
                crearNP = False
            Else
                crearNP = True

            End If
            If crearNP Then
                consulta = "INSERT INTO articulos_inventario (np,descripcion,cantidad,tipo) VALUES ('" & txtcodigo.Text & "','" & txtdesc.Text & "'," & Nexistencia.Value & ",'" & CBTipo.Text & "')"
                If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                Else
                    Throw New Exception("no se pudo generar inventario")
                End If
                consulta = "select max(id) from articulos_inventario"
                tablaResultado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)
                If tablaResultado.Rows.Count > 0 Then
                    id_inv = tablaResultado.Rows(0).Item(0)
                Else
                    Throw New Exception("no se pudo obtener el Identificador del Inventario")
                End If
            End If

            valores &= "'" & txtcodigo.Text.Trim & "',"
            valores &= "'" & txtdesc.Text.Trim & "',"
            valores &= nprecio.Value & ","
            valores &= "'" & CBMarca.Text & "',"
            valores &= "'" & txtmodelo.Text.Trim & "',"
            valores &= "'" & txtaño.Text.Trim & "',"
            valores &= "'" & CBInventario.Text & "',"
            valores &= nminimo.Value & ","
            valores &= "'" & cbIncluir.Text & "',"
            valores &= "'" & txtObservaciones.Text.Trim & "',"
            valores &= NCosto.Value & ","
            valores &= NMano.Value & ","
            valores &= "'" & CBTipo.Text & "',"
            valores &= id_inv
            consulta = "INSERT INTO articulos (np,descripcion,precio,marca,modelo,year,inventario,minimo,incluido,obser,costo,mano,tipo,id_inv) VALUES (" & valores & ")"

            If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                transaccionActualizar.Commit()
                MsgBox("Articulo Guardado", MsgBoxStyle.Information)
                Me.Close()
                For Each Todaventana As Form In Me.MdiChildren
                    Todaventana.Close()
                Next
                frmArticulos.MdiParent = MDIPrincipal
                frmArticulos.Show()

            End If
        Catch ex As Exception
            If transaccionActualizar IsNot Nothing Then
                If transaccionActualizar.Connection IsNot Nothing Then
                    transaccionActualizar.Rollback()
                End If
            End If
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Insertar")
        End Try
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

        For Each Todaventana As Form In Me.MdiChildren
            Todaventana.Close()
        Next
        frmArticulos.MdiParent = MDIPrincipal
        frmArticulos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        CBMarca.Text = "CHEVROLET,FORD,JEEP,MAZDA,DODGE"
    End Sub

    Private Sub CBTipo_KeyDown(sender As Object, e As KeyEventArgs) Handles CBTipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = False
            txtdesc.Focus()
        End If
    End Sub

    Private Sub CBTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTipo.SelectedIndexChanged
        Precio_panel.BackColor = Color.Transparent
        Mano_panel.BackColor = Color.Transparent

        If CBTipo.Text = "ARTICULO" Then
            Precio_panel.BackColor = Color.Yellow

        End If
        If CBTipo.Text = "SERVICIO" Then
            Mano_panel.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub txtcodigo_GotFocus(sender As Object, e As EventArgs) Handles txtcodigo.GotFocus
        sender.select(0, 100000)

    End Sub

    Private Sub txtcodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtcodigo.KeyDown
        If e.KeyCode = Keys.Enter And txtcodigo.TextLength > 0 Then
            e.Handled = False
            CBTipo.Focus()

        End If
    End Sub



    Private Sub txtcodigo_LocationChanged(sender As Object, e As EventArgs) Handles txtcodigo.LocationChanged

    End Sub

    Private Sub txtcodigo_LostFocus(sender As Object, e As EventArgs) Handles txtcodigo.LostFocus

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable
        Dim buscarMasInfo As Boolean = False

        info_panel.Hide()
        txtcodigo.Text = txtcodigo.Text.Replace(" ", "")

        If txtcodigo.Text.Trim.Length = 0 Then

            Return
        End If

        Try
            consulta = "SELECT id, np, descripcion, cantidad, tipo, cant_unidad FROM articulos_inventario WHERE np = '" & txtcodigo.Text.Trim & "' ORDER BY id"
            tablaResultado = tool.ObtenerTabla(consulta)

            If tablaResultado.Rows.Count > 0 Then
                With tablaResultado.Rows(0)

                    If NumeroDeParte = .Item("np") Then
                    Else
                        lblAvisoArticuloNuevoExistente.Text = "NP EXISTENTE " & .Item("descripcion").ToString
                        lblid_inv.Text = .Item("id").ToString
                        CBTipo.SelectedItem = .Item("tipo").ToString
                        txtdesc.Text = .Item("descripcion").ToString
                        lbldesc.Text = .Item("descripcion").ToString
                        lblCant_Inv.Text = .Item("cantidad").ToString
                        lblcant_unidad.Text = .Item("cant_unidad").ToString
                        info_panel.Show()

                        If CBTipo.SelectedIndex >= 0 Then CBTipo.Enabled = False


                        buscarMasInfo = True

                        BloquearControles()

                    End If
                End With

                If buscarMasInfo Then
                    consulta = "SELECT costo, precio, mano, incluido FROM articulos WHERE id_inv =" & lblid_inv.Text & " LIMIT 1"
                    tablaResultado = tool.ObtenerTabla(consulta)
                    If tablaResultado.Rows.Count > 0 Then
                        With tablaResultado.Rows(0)
                            NCosto.Value = .Item("costo")
                            nprecio.Value = .Item("precio")
                            NMano.Value = .Item("mano")
                            cbIncluir.SelectedItem = .Item("incluido").ToString
                            If cbIncluir.SelectedIndex >= 0 Then cbIncluir.Enabled = False
                        End With
                    End If
                End If

            Else
                info_panel.Hide()
                MessageBox.Show("El Número de parte es nuevo")
                lblAvisoArticuloNuevoExistente.Text = "NP NUEVO"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "error en busqueda", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        



    End Sub

    Public Sub TareaBuscarNP(listaNP As List(Of String))
        Dim tarea As task
        tarea = New Task(Sub() BuscarNpRelacionados(listaNP))
        tarea.Start()
    End Sub

    Private Sub txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigo.TextChanged

       
        Dim listaNp As New List(Of String)
        Dim limiteTexto As Integer = 3
        Dim cantidaTexto As Integer = 0


        TablaNPRelacion.Rows.Clear()
        listaNp.Clear()

        If txtcodigo.Text.Trim.Length >= 3 Then
            cantidaTexto = txtcodigo.Text.Length

            For letraIndex = 0 To cantidaTexto - 1

                If letraIndex = cantidaTexto - 2 Then
                    limiteTexto = 1
                End If

                If letraIndex >= 0 And letraIndex < cantidaTexto Then
                    If txtcodigo.Text.Substring(letraIndex, limiteTexto).Length > 1 Then
                        listaNp.Add(txtcodigo.Text.Substring(letraIndex, limiteTexto))
                    End If
                End If

            Next
        End If

        BuscarNpRelacionados(listaNp)
    End Sub

    Public Delegate Sub EstablecerNPRelacionados(listaNp As List(Of String))


    Private Sub BuscarNpRelacionados(listaNP As List(Of String))

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable
        Dim agregarArticulo As Boolean = False

        If seguirBuscandoNP = False Then Return

        TablaNPRelacion.Rows.Clear()

        btnGuardar.Enabled = False

        For Each npBuscar As String In listaNP
            consulta = "SELECT id, np, descripcion, cantidad FROM articulos_inventario WHERE np like '%" & npBuscar & "%' ORDER BY id"
            tablaResultado = tool.ObtenerTabla(consulta)
            

            For Each xRow As DataRow In tablaResultado.Rows
                agregarArticulo = True
                For Each xRowAgregado As DataGridViewRow In TablaNPRelacion.Rows
                    If xRowAgregado.Cells("id_inv").Value = xRow.Item("id") Then
                        agregarArticulo = False
                    End If
                Next
                If agregarArticulo Then
                    TablaNPRelacion.Rows.Add(xRow.Item("id"), xRow.Item("np"), xRow.Item("descripcion"), xRow.Item("cantidad"))
                End If

            Next
        Next

        btnGuardar.Enabled = True
    End Sub


    Private Sub nprecio_KeyDown(sender As Object, e As KeyEventArgs) Handles nprecio.KeyDown
        If e.KeyCode = Keys.Enter Then
            nminimo.Focus()

        End If
    End Sub

    Private Sub nprecio_ValueChanged(sender As Object, e As EventArgs) Handles nprecio.ValueChanged
        sumar_2valores()

    End Sub
    Private Sub sumar_2valores()
        lblvalor.Text = FormatCurrency(nprecio.Value + NMano.Value, 2)

    End Sub



    Private Sub Seleccion(sender As Object, e As EventArgs) Handles nprecio.Enter, nminimo.Enter, NMano.Enter, Nexistencia.Enter, NCosto.Enter
        sender.select(0, 100000)
    End Sub

    Private Sub Panel23_Paint(sender As Object, e As PaintEventArgs) Handles info_panel.Paint

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        NCosto.Value *= 1.16

    End Sub

    Private Sub frmArticuloAgregar_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        estructura_ventana(Me)
    End Sub

    Private Sub txtdesc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdesc.KeyDown
        If e.KeyCode = Keys.Enter Then
            nprecio.Focus()

        End If

    End Sub

    Private Sub txtdesc_LostFocus(sender As Object, e As EventArgs) Handles txtdesc.LostFocus

    End Sub

    Private Sub txtdesc_TextChanged(sender As Object, e As EventArgs) Handles txtdesc.TextChanged

    End Sub

    Private Sub nminimo_GotFocus(sender As Object, e As EventArgs) Handles nminimo.GotFocus
        sender.select(0, 100000)
    End Sub

    Private Sub nminimo_ValueChanged(sender As Object, e As EventArgs) Handles nminimo.ValueChanged

    End Sub

    Private Sub NMano_GotFocus(sender As Object, e As EventArgs) Handles NMano.GotFocus
        sender.select(0, 100000)
    End Sub

    Private Sub NMano_ValueChanged(sender As Object, e As EventArgs) Handles NMano.ValueChanged
        sumar_2valores()
    End Sub

    Private Sub NCosto_GotFocus(sender As Object, e As EventArgs) Handles NCosto.GotFocus
        sender.select(0, 100000)
    End Sub

    Private Sub NCosto_ValueChanged(sender As Object, e As EventArgs) Handles NCosto.ValueChanged

    End Sub

    Private Sub tabla_articulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub seleccionar_conclick(sender As Object, e As EventArgs) Handles nprecio.Click, nminimo.Click, NMano.Click, Nexistencia.Click, NCosto.Click
        sender.select(0, 1000)
    End Sub

    Private Sub CBInventario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBInventario.SelectedIndexChanged

    End Sub

    Private Sub nminimo_KeyDown(sender As Object, e As KeyEventArgs) Handles nminimo.KeyDown
        If e.KeyCode = Keys.Enter Then
            NMano.Focus()

        End If
    End Sub

    Private Sub NMano_KeyDown(sender As Object, e As KeyEventArgs) Handles NMano.KeyDown
        If e.KeyCode = Keys.Enter Then
            CBMarca.Focus()

        End If
    End Sub

    Private Sub txtmodelo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtmodelo.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtaño.Focus()

        End If
    End Sub

    Private Sub txtmodelo_TextChanged(sender As Object, e As EventArgs) Handles txtmodelo.TextChanged

    End Sub

    Private Sub CBMarca_KeyDown(sender As Object, e As KeyEventArgs) Handles CBMarca.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtmodelo.Focus()

        End If
    End Sub

    Private Sub CBMarca_LostFocus(sender As Object, e As EventArgs) Handles CBMarca.LostFocus
        CBMarca.Text = CBMarca.Text.ToUpper()


    End Sub

    Private Sub CBMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMarca.SelectedIndexChanged

    End Sub

    Private Sub txtaño_KeyDown(sender As Object, e As KeyEventArgs) Handles txtaño.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtObservaciones.Focus()

        End If
    End Sub

    Private Sub txtaño_TextChanged(sender As Object, e As EventArgs) Handles txtaño.TextChanged

    End Sub

    Private Sub txtObservaciones_KeyDown(sender As Object, e As KeyEventArgs) Handles txtObservaciones.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Nexistencia.Enabled = True Then
                Nexistencia.Focus()
            Else
                NCosto.Focus()

            End If
        End If
    End Sub

    Private Sub txtObservaciones_TextChanged(sender As Object, e As EventArgs) Handles txtObservaciones.TextChanged

    End Sub

    Private Sub Nexistencia_ValueChanged(sender As Object, e As EventArgs) Handles Nexistencia.ValueChanged

    End Sub

    Private Sub Nexistencia_KeyDown(sender As Object, e As KeyEventArgs) Handles Nexistencia.KeyDown
        If e.KeyCode = Keys.Enter Then
            NCosto.Focus()

        End If
    End Sub

    Private Sub nprecio_LostFocus(sender As Object, e As EventArgs) Handles nprecio.LostFocus
        If sender.Controls.Item(1).Text = "" Then
            sender.Controls.Item(1).Text = 0
        End If

    End Sub

    Private Sub nminimo_LostFocus(sender As Object, e As EventArgs) Handles nminimo.LostFocus
        If sender.Controls.Item(1).Text = "" Then
            sender.Controls.Item(1).Text = 0
        End If
    End Sub

    Private Sub NMano_LostFocus(sender As Object, e As EventArgs) Handles NMano.LostFocus
        If sender.Controls.Item(1).Text = "" Then
            sender.Controls.Item(1).Text = 0
        End If
    End Sub

    Private Sub NCosto_LostFocus(sender As Object, e As EventArgs) Handles NCosto.LostFocus
        If sender.Controls.Item(1).Text = "" Then
            sender.Controls.Item(1).Text = 0
        End If
    End Sub

    Private Sub Panel22_Paint(sender As Object, e As PaintEventArgs) Handles Panel22.Paint

    End Sub

    Private Sub TablaNPRelacion_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaNPRelacion.CellClick
   
    End Sub

    Private Sub TablaNPRelacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaNPRelacion.CellContentClick

    End Sub

    Private Sub btnContinuar_Click(sender As Object, e As EventArgs) Handles btnContinuar.Click
        If txtcodigo.Text.Trim.Length > 0 Then
            BloquearControles()


        End If
    End Sub
    Private Sub BloquearControles()
        seguirBuscandoNP = False
        txtcodigo.Enabled = False
        btnContinuar.Enabled = False
        PanelCodigo.Height = 42
        TablaNPRelacion.Enabled = False
    End Sub

    Private Sub TablaNPRelacion_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaNPRelacion.CellDoubleClick
        If TablaNPRelacion.Rows.Count > 0 Then
            If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
                BloquearControles()
                lblAvisoArticuloNuevoExistente.Text = "NP EXISTENTE " & TablaNPRelacion.Rows(e.RowIndex).Cells(Desc.Name).Value.ToString
                lblid_inv.Text = TablaNPRelacion.Rows(e.RowIndex).Cells(id_inv.Name).Value
                NumeroDeParte = TablaNPRelacion.Rows(e.RowIndex).Cells(np.Name).Value
                txtcodigo.Text = NumeroDeParte
            Else

                Return
            End If
        End If
    End Sub
End Class