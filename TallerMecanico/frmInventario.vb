Public Class frmInventario
    Public idinventario As Integer



    Private Sub frmInventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBActivo.SelectedIndex = 0
        estructura_ventana(Me)
        Cargar_Inventario()

    End Sub
    Private Sub Cargar_Inventario()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Try

            consulta = "SELECT * FROM articulos_inventario WHERE np like '%" & txtnp.Text & "%' AND descripcion like '%" & txtdesc.Text & "%'"
            If (CBPorTipos.SelectedIndex > 0) Then
                consulta = consulta & " AND tipo='" & CBPorTipos.Text & "'"
            End If
            If (CBSoloActivos.SelectedIndex > 0) Then
                consulta = consulta & " AND activo='" & CBSoloActivos.Text & "'"
            End If
            tablaResultado = tool.ObtenerTabla(consulta)
            tablaInventario.Rows.Clear()
            If tablaResultado.Rows.Count > 0 Then
                For Each xRow As DataRow In tablaResultado.Rows
                    tablaInventario.Rows.Add(xRow.Item("id"), xRow.Item("np"), xRow.Item("descripcion"), xRow.Item("cantidad"), xRow.Item("minimo"), "", xRow.Item("tipo"), xRow.Item("activo"), xRow.Item("preguntar"))
                Next

            End If
            lblCount.Text = tablaInventario.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub
    Public Sub CargarInfoUno()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Try
            If tablaInventario.Rows.Count > 0 And Me.Visible = True Then
                Dim i As Integer = tablaInventario.CurrentRow.Index

                If i <= -1 Then Return

                consulta = "SELECT * FROM articulos_inventario WHERE id=" & tablaInventario.Rows(i).Cells("id").Value
                tablaResultado = tool.ObtenerTabla(consulta)

                If tablaResultado.Rows.Count > 0 Then

                    With tablaInventario.Rows(i)
                        .Cells("id").Value = tablaResultado.Rows(0).Item("id")
                        .Cells("desc").Value = tablaResultado.Rows(0).Item("descripcion")
                        .Cells("cant").Value = tablaResultado.Rows(0).Item("cantidad")
                        .Cells("minimo").Value = tablaResultado.Rows(0).Item("minimo")
                        .Cells("tipo").Value = tablaResultado.Rows(0).Item("tipo")
                        .Cells("activo").Value = tablaResultado.Rows(0).Item("activo")
                        .Cells("preguntar").Value = tablaResultado.Rows(0).Item("preguntar")
                    End With
                End If
            End If
            lblCount.Text = tablaInventario.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Uno")
        End Try
    End Sub
    Private Sub Cargar_Detalle()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        tabla_lista.Rows.Clear()

        If tablaInventario.Rows.Count > 0 And Me.Visible = True Then
            Dim i As Integer = tablaInventario.CurrentRow.Index
            Try
                consulta = "SELECT id,descripcion,marca,modelo,obser FROM articulos WHERE id_inv=" & tablaInventario.Rows(i).Cells("id").Value
                tablaResultado = tool.ObtenerTabla(consulta)
                tabla_lista.Rows.Clear()
                If tablaResultado.Rows.Count > 0 Then

                    CBActivo.SelectedItem = tablaInventario.Rows(i).Cells("activo").Value
                    CbArticulo.SelectedItem = tablaInventario.Rows(i).Cells("tipo").Value
                    tablaInventario.Rows(i).Cells("proveedor").Value = tablaResultado.Rows(0).Item("obser")
                    For Each xRow As DataRow In tablaResultado.Rows
                        tabla_lista.Rows.Add(xRow.Item("id"), xRow.Item("descripcion"), xRow.Item("marca"), xRow.Item("modelo"))
                        
                    Next

                End If

                    tabla_compras.Rows.Clear()
                consulta = "select * from facturadetalle WHERE idnp_inv=" & tablaInventario.Rows(i).Cells("id").Value
                tablaResultado = tool.ObtenerTabla(consulta)

                If tablaResultado.Rows.Count > 0 Then
                    For Each xRow As DataRow In tablaResultado.Rows
                        tabla_compras.Rows.Add(xRow.Item("fecha"), xRow.Item("proveedor"), xRow.Item("costo"), xRow.Item("cant"))
                    Next
                End If
                    tabla_mov.Rows.Clear()
                consulta = "select * from articulos_movimiento WHERE id_np=" & tablaInventario.Rows(i).Cells("id").Value & " ORDER BY id DESC LIMIT " & NUltimos.Value
                tablaResultado = tool.ObtenerTabla(consulta)
                If tablaResultado.Rows.Count > 0 Then
                    For Each xRow As DataRow In tablaResultado.Rows
                        tabla_mov.Rows.Add(xRow.Item("id"), xRow.Item("fecha"), xRow.Item("tipo_mov"), xRow.Item("cant"), xRow.Item("folio"), xRow.Item("existencia"), xRow.Item("saldo"), xRow.Item("ventana"), xRow.Item("motivo"))
                    Next

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "factura, mov")
            End Try
        End If

    End Sub

    Private Sub txtnp_GotFocus(sender As Object, e As EventArgs) Handles txtnp.GotFocus
        txtnp.Select(0, 10000)
    End Sub

    Private Sub txtnp_KeyDown(sender As Object, e As KeyEventArgs) Handles txtnp.KeyDown

    End Sub

    Private Sub txtnp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnp.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            If tablaInventario.Rows.Count > 0 Then
                Dim i As Integer = tablaInventario.CurrentRow.Index
                lblid.Text = tablaInventario.Rows(i).Cells("id").Value
                editar(i)
            End If

        End If
    End Sub
    Private Sub editar(i As Integer)



        lblid.Text = tablaInventario.Rows(i).Cells("id").Value
        Nminimo.Value = tablaInventario.Rows(i).Cells("minimo").Value
        CBActivo.Text = tablaInventario.Rows(i).Cells("activo").Value
        CbArticulo.Text = tablaInventario.Rows(i).Cells("tipo").Value
        tablaInventario.Enabled = False
        Editar_panel.Show()
        CBtipo.Focus()
        Mostrar_info()
        CBMOTIVO.Text = ""


    End Sub
    Private Sub activar()
        tablaInventario.Enabled = True

    End Sub
    Private Sub txtnp_TextChanged(sender As Object, e As EventArgs) Handles txtnp.TextChanged
        cancelar()
        Cargar_Inventario()
    End Sub

    Private Sub txtdesc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdesc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            If tablaInventario.Rows.Count > 0 Then
                Dim i As Integer = tablaInventario.CurrentRow.Index
                lblid.Text = tablaInventario.Rows(i).Cells("id").Value
                editar(i)
            End If



        End If
    End Sub

    Private Sub txtdesc_TextChanged(sender As Object, e As EventArgs) Handles txtdesc.TextChanged
        Cargar_Inventario()
    End Sub
    Private Sub Mostrar_info()
        Dim suma As Decimal = 0
        If tablaInventario.Rows.Count > 0 Then

            Dim i As Integer = tablaInventario.CurrentRow.Index

            suma = tablaInventario.Rows(tablaInventario.CurrentRow.Index).Cells("cant").Value
            Nminimo.Value = tablaInventario.Rows(tablaInventario.CurrentRow.Index).Cells("minimo").Value
            lblid.Text = tablaInventario.Rows(i).Cells("id").Value
            lblsuma.Text = suma



        End If
        Cargar_Detalle()
    End Sub

    Private Sub tablaInventario_ColumnHeaderMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tablaInventario.ColumnHeaderMouseDoubleClick
     
    End Sub

  
    Private Sub tablaInventario_KeyDown(sender As Object, e As KeyEventArgs) Handles tablaInventario.KeyDown
        If tablaInventario.Rows.Count > 0 Then
            If e.KeyCode = Keys.Enter Then
                e.Handled = True ' PARA NO BRINCAR ROW
                Dim i As Integer = tablaInventario.CurrentRow.Index
                editar(i)

            End If
        End If
    End Sub
    Private Sub tablaInventario_SelectionChanged(sender As Object, e As EventArgs) Handles tablaInventario.SelectionChanged
        ' Mostrar_info()

    End Sub
    Private Sub NCant_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Nminimo.Focus()

        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cancelar()
    End Sub
    Private Sub cancelar()
        Editar_panel.Hide()

        CBtipo.SelectedIndex = -1
        NCant.Value = 0
        tablaInventario.Enabled = True

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Editar_panel.Visible Then
            btnCancel.PerformClick()
        Else
            Me.Close()
        End If


    End Sub

    Private Sub Nminimo_GotFocus(sender As Object, e As EventArgs) Handles Nminimo.GotFocus
        Nminimo.Select(0, 100000)
    End Sub

    Private Sub Nminimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Nminimo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            btnActualizacion.PerformClick()
            tablaInventario.Enabled = True

        End If
    End Sub

    Private Sub CBtipo_KeyDown(sender As Object, e As KeyEventArgs) Handles CBtipo.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            If CBtipo.SelectedIndex >= 0 Then
                NCant.Focus()

            End If
        End If
    End Sub

    Private Sub CBtipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBtipo.SelectedIndexChanged
        calcular()
    End Sub
    Private Sub calcular()
        Dim suma As Decimal = 0
        If CBtipo.Text = "ENTRADA" Then
            suma = tablaInventario.Rows(tablaInventario.CurrentRow.Index).Cells("cant").Value
            suma = NCant.Value + suma
            lblsuma.Text = suma
        End If
        If CBtipo.Text = "SALIDA" Then
            suma = tablaInventario.Rows(tablaInventario.CurrentRow.Index).Cells("cant").Value
            suma -= NCant.Value
            lblsuma.Text = suma
        End If
    End Sub

    Private Sub NCant_GotFocus1(sender As Object, e As EventArgs) Handles NCant.GotFocus
        NCant.Select(0, 1000)
    End Sub

    Private Sub NCant_KeyDown(sender As Object, e As KeyEventArgs) Handles NCant.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            CBMOTIVO.Focus()

        End If
    End Sub

    Private Sub NCant_ValueChanged_1(sender As Object, e As EventArgs) Handles NCant.ValueChanged
        calcular()
    End Sub

    Private Sub btnaplicar_Click(sender As Object, e As EventArgs) Handles btnaplicar.Click
        Dim valores As String = ""
        Dim INV As Integer = 0
        Dim id_inv As Integer = 0
        Dim inv_existencia As Integer = 0

        Dim tool As New Herramienta
        Dim tablaResutado As New DataTable
        Dim consulta As String = ""
        Dim transaccionActualizar As MySql.Data.MySqlClient.MySqlTransaction = Nothing
        Dim comando As New MySql.Data.MySqlClient.MySqlCommand
        If tablaInventario.Rows.Count > 0 Then
            Dim i As Integer = tablaInventario.CurrentRow.Index
            If CBMOTIVO.Text.Length > 5 Then

                Try
                    comando.Connection = New MySql.Data.MySqlClient.MySqlConnection
                    comando.Connection.ConnectionString = con.ConnectionString
                    comando.Connection.Open()
                    transaccionActualizar = comando.Connection.BeginTransaction
                    comando.Transaction = transaccionActualizar

                Catch ex As Exception
                    If transaccionActualizar IsNot Nothing Then
                        If transaccionActualizar.Connection IsNot Nothing Then
                            transaccionActualizar.Rollback()
                        End If
                    End If
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    Return
                End Try

                If CBtipo.Text = "ENTRADA" Then
                    Try

                        consulta = "SELECT id,cantidad FROM articulos_inventario WHERE id=" & lblid.Text
                        tablaResutado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)
                        If tablaResutado.Rows.Count > 0 Then
                            With tablaResutado.Rows(0)
                                INV = .Item("cantidad")
                                inv_existencia = .Item("cantidad")
                                id_inv = .Item("id")
                            End With
                        End If
                        INV += NCant.Value
                        consulta = "UPDATE articulos_inventario SET cantidad=" & INV & " WHERE id=" & id_inv
                        If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                            With tablaInventario.Rows(i)
                                tool.Insertar_Movimiento_ModuloTransaccion("INVENTARIO", 0, 0, .Cells("id").Value, .Cells("np").Value, CBtipo.Text, .Cells("tipo").Value, NCant.Value, DateTime.Today, .Cells("desc").Value, inv_existencia, INV, 0, "TALLER TIBURON", 1, "AJUSTE: " & CBMOTIVO.Text, transaccionActualizar)
                                transaccionActualizar.Commit()
                                MsgBox("inv actualizado a " & INV, MsgBoxStyle.Information)
                                actualizar_info(i)
                                cancelar()
                                txtnp.Focus()
                            End With
                        End If

                    Catch ex As Exception
                        If transaccionActualizar IsNot Nothing Then
                            If transaccionActualizar.Connection IsNot Nothing Then
                                transaccionActualizar.Rollback()
                            End If
                        End If
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                End If

                If CBtipo.Text = "SALIDA" Then
                    Try

                        consulta = "SELECT id,cantidad FROM articulos_inventario WHERE id=" & lblid.Text
                        tablaResutado = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)
                        If tablaResutado.Rows.Count > 0 Then
                            With tablaResutado.Rows(0)
                                INV = .Item("cantidad")
                                inv_existencia = .Item("cantidad")
                                id_inv = .Item("id")
                            End With

                        End If
                        INV -= NCant.Value
                        consulta = "UPDATE articulos_inventario SET cantidad=" & INV & " WHERE id=" & id_inv
                        If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                            With tablaInventario.Rows(i)
                                tool.Insertar_Movimiento_ModuloTransaccion("INVENTARIO", 0, 0, .Cells("id").Value, .Cells("np").Value, CBtipo.Text, .Cells("tipo").Value, NCant.Value, DateTime.Today, .Cells("desc").Value, inv_existencia, INV, 0, "TALLER TIBURON", 1, "AJUSTE: " & CBMOTIVO.Text, transaccionActualizar)
                                transaccionActualizar.Commit()
                                MsgBox("Inventario Actualizado a " & INV, MsgBoxStyle.Information)
                                actualizar_info(i)
                                cancelar()
                                txtnp.Focus()
                            End With
                        End If
                    Catch ex As Exception
                        If transaccionActualizar IsNot Nothing Then
                            If transaccionActualizar.Connection IsNot Nothing Then
                                transaccionActualizar.Rollback()
                            End If
                        End If
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                End If
            Else
                MsgBox("Ingrese un motivo especifico mayor a 5 caracteres", MsgBoxStyle.Information)
                CBMOTIVO.Focus()
            End If

        End If

    End Sub
    Private Sub actualizar_info(pos As Integer)
        Dim tool As New Herramienta
        Dim tablaResultado As New DataTable
        Dim consulta As String = ""
        Try

            consulta = "SELECT cantidad,minimo,activo FROM articulos_inventario WHERE id=" & lblid.Text
            tablaResultado = tool.ObtenerTabla(consulta)
            If tablaResultado.Rows.Count > 0 Then
                With tablaResultado.Rows(0)
                    tablaInventario.Rows(pos).Cells("cant").Value = .Item("cantidad")
                    tablaInventario.Rows(pos).Cells("minimo").Value = .Item("minimo")
                    tablaInventario.Rows(pos).Cells("activo").Value = .Item("activo")
                End With
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cancelar()
    End Sub

    Private Sub tablaInventario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaInventario.CellContentClick

    End Sub

    Private Sub btnReq_Click(sender As Object, e As EventArgs) Handles btnReq.Click
        tablaInventario.Rows.Clear()
        Editar_panel.Hide()

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If con.State = ConnectionState.Open Then
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM articulos_inventario WHERE cantidad < minimo and minimo > 0"
                datos = cmd.ExecuteReader
                If datos.HasRows Then
                    While datos.Read
                        tablaInventario.Rows.Add(datos("id"), datos("np"), datos("descripcion"), datos("cantidad"), datos("minimo"), datos("tipo"))
                    End While
                End If
                datos.Close()
            End If
            lblCount.Text = tablaInventario.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnActualizacion_Click(sender As Object, e As EventArgs) Handles btnActualizacion.Click
        If tablaInventario.Rows.Count > 0 Then
            Dim i As Integer = tablaInventario.CurrentRow.Index
            If CBActivo.Text = "NO" Then
                If MsgBox("Este articulo quedara Inactivo hasta nuevo aviso, ¿Desea Continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Else
                    Exit Sub
                End If
            End If
            If Not CbArticulo.SelectedIndex >= 0 Then
                MsgBox("Debe seleccionar si es un tipo Articulo, Servicio o Pack", MsgBoxStyle.Information)
                CbArticulo.Focus()
                Exit Sub
            End If
            Try
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                If con.State = ConnectionState.Open Then
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE articulos_inventario SET minimo=" & Nminimo.Value & ", tipo='" & CbArticulo.Text & "', activo='" & CBActivo.Text & "' WHERE id=" & lblid.Text
                    If cmd.ExecuteNonQuery Then
                        MsgBox("Inventario Actualizado minimo: " & Nminimo.Value, MsgBoxStyle.Information)
                        actualizar_info(i)
                        cancelar()
                        txtnp.Focus()

                    End If
                End If

            Catch ex As Exception

                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If tablaInventario.Rows.Count > 0 Then

            Try
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                If con.State = ConnectionState.Open Then
                    cmd.Connection = con
                    For i = 0 To tablaInventario.Rows.Count - 1
                        cmd.CommandText = "SELECT tipo FROM articulos WHERE id_inv=" & tablaInventario.Rows(i).Cells("id").Value
                        datos = cmd.ExecuteReader
                        If datos.HasRows Then
                            While datos.Read
                                tablaInventario.Rows(i).Cells("tipo").Value = datos("tipo")
                            End While
                        End If
                        datos.Close()

                    Next
                    For i = 0 To tablaInventario.Rows.Count - 1
                        With tablaInventario.Rows(i)
                            cmd.CommandText = "UPDATE articulos_inventario SET tipo='" & .Cells("tipo").Value & "' WHERE id=" & .Cells("id").Value
                            If cmd.ExecuteNonQuery Then
                                If i = tablaInventario.Rows.Count - 1 Then
                                    MsgBox("tipo actualizado")
                                End If
                            End If
                        End With

                    Next
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If
   
    End Sub



    Private Sub CBMOTIVO_KeyDown(sender As Object, e As KeyEventArgs) Handles CBMOTIVO.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            btnaplicar.Focus()

        End If
    End Sub



    Private Sub tablaInventario_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaInventario.CellDoubleClick
        If tablaInventario.Rows.Count > 0 Then
            Dim i As Integer = tablaInventario.CurrentRow.Index
            With tablaInventario.Rows(i)
                frmInventario_detalle.Dispose()
                frmInventario_detalle.lbldesc.Text = .Cells("np").Value & " " & .Cells("desc").Value
                frmInventario_detalle.cbPreguntar.SelectedItem = .Cells("preguntar").Value
                idinventario = .Cells("id").Value
                frmInventario_detalle.ShowDialog()


            End With

        End If
    End Sub

    Private Sub tablaInventario_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tablaInventario.CellMouseDoubleClick
 
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Cargar_Detalle()
    End Sub

    Private Sub CBMOTIVO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMOTIVO.SelectedIndexChanged

    End Sub

    Private Sub CBMOTIVO_TextChanged(sender As Object, e As EventArgs) Handles CBMOTIVO.TextChanged
        If CBMOTIVO.Text.Length <= 20 Then
            lbl_caracteres.Text = "Caracteres: " & CBMOTIVO.Text.Length & " de 20"

        End If


    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If tablaInventario.Rows.Count > 0 Then
            Dim index As Integer = -1
            Dim idNp As Integer
            If tablaInventario.CurrentRow Is Nothing Then
                Return
            End If
            index = tablaInventario.CurrentRow.Index

            If (index < 0) Then
                Return
            End If

            idNp = Val(tablaInventario.Rows(index).Cells("id").Value.ToString)

            Dim frmEditar As New frmInventarioEditar(idNp)
            frmEditar.ShowDialog()
            actualizar_info(index)
        End If
    End Sub

    
    Private Sub CBPorTipos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPorTipos.SelectedIndexChanged
        Cargar_Inventario()
    End Sub

    Private Sub CBSoloActivos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSoloActivos.SelectedIndexChanged
        Cargar_Inventario()
    End Sub
End Class