Public Class frmArticulosEditar
    Public guardado As Boolean

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub frmArticulosEditar_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub frmArticulosEditar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then

            If MessageBox.Show("¿Desea cerrar la ventana de editar articulo?", "cerrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                Me.Close()
            End If


        End If
    End Sub

    Private Sub frmArticulosEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarInfo()

    End Sub
    Private Sub cargarInfo()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()

            End If
            'CBActivo.Text = "SI"
            If con.State = ConnectionState.Open Then
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM articulos WHERE id=" & lblid.Text
                datos = cmd.ExecuteReader
                If datos.HasRows Then
                    While datos.Read
                        txtcodigo.Text = datos("np")
                        txtdesc.Text = datos("descripcion")
                        nprecio.Value = datos("precio")
                        nminimo.Value = datos("minimo")
                        CBMarca.Text = datos("marca")
                        txtmodelo.Text = datos("modelo")
                        txtaño.Text = datos("year")
                        ' CBInventario.SelectedItem = datos("inventario")
                        NMano.Value = datos("mano")
                        cbIncluir.SelectedItem = datos("incluido")
                        txtObservaciones.Text = datos("obser")
                        NCosto.Value = datos("costo")
                        CBTipo.SelectedItem = datos("tipo")
                        txtUbicacion.Text = datos("ubicacion")
                        ' CBActivo.Text = datos("activo")

                    End While
                End If
                datos.Close()
                cmd.CommandText = "SELECT id,np,descripcion,cantidad,cant_unidad from articulos_inventario where np='" & txtcodigo.Text & "'"
                datos = cmd.ExecuteReader
                If datos.HasRows Then
                    While datos.Read

                        lblid_inv.Text = datos("id")
                        lblDesc_Inv.Text = datos("descripcion")
                        lblCant_Inv.Text = datos("cantidad")
                        lblnp.Text = datos("np")
                        lblcant_unidad.Text = datos("cant_unidad")
                        'nunidad.Value = datos("cant_unidad")
                    End While
                Else
                    MsgBox("No hay NP en INV")
                End If
                datos.Close()



            End If
        Catch ex As Exception
            datos.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtcodigo.TextLength > 0 Then
            If txtdesc.TextLength > 0 Then
                If nprecio.Value > 0 Then

                    If CBMarca.Text.Length > 0 Then


                        If CBTipo.Text = "ARTICULO" Then


                            If nminimo.Value >= 0 Then
                                ActualizarArticulo()
                                guardado = True
                            Else
                                MsgBox("Ingrese Cantidad minima", MsgBoxStyle.Information)
                                nminimo.Focus()
                            End If


                        ElseIf CBTipo.Text = "SERVICIO" Or CBTipo.Text = "PACK" Then
                            ActualizarArticulo()
                            guardado = True
                        End If

                    
                Else
                    MsgBox("Ingrese Marca", MsgBoxStyle.Information)
                    CBMarca.Focus()

                End If
                Else
                    MsgBox("Ingrese Precio del Articulo / Servicio", MsgBoxStyle.Information)
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
    Private Sub sumar_2valores()
        lblvalor.Text = FormatCurrency(nprecio.Value + NMano.Value, 2)

    End Sub
    Private Sub ActualizarArticulo()
        Dim editar_np As Boolean = False
        Dim id_np As Integer = 0
        If lblid_inv.Text = 0 Then ' es un numero de parte nuevo
            'se procede a insertar np y despues leer el id nuevo
            cmd.CommandText = "INSERT INTO articulos_inventario (np,descripcion,minimo,tipo) VALUES ('" & txtcodigo.Text & "','" & txtdesc.Text & "'," & nminimo.Value & ",'" & CBTipo.Text & "')"
            If cmd.ExecuteNonQuery() Then ' si se inserta el numero de parte
                cmd.CommandText = "SELECT MAX(id) FROM articulos_inventario"
                datos = cmd.ExecuteReader
                If datos.HasRows Then
                    While datos.Read
                        id_np = datos.GetValue(0)
                    End While
                End If
                If Not datos.IsClosed Then datos.Close()
                If id_np > 0 Then ' si el id se pudo leer
                    cmd.CommandText = "UPDATE articulos SET np='" & txtcodigo.Text & "', descripcion='" & txtdesc.Text & "', precio=" & nprecio.Value & ", minimo=" & nminimo.Value & ",marca='" & CBMarca.Text & "', modelo='" & txtmodelo.Text & "', year='" & txtaño.Text & "', mano=" & NMano.Value & ", incluido='" & cbIncluir.Text & "',obser='" & txtObservaciones.Text & "', costo=" & NCosto.Value & ", tipo='" & CBTipo.Text & "', id_inv=" & lblid_inv.Text & ", ubicacion='" & txtUbicacion.Text & "' WHERE id=" & lblid.Text
                    If cmd.ExecuteNonQuery Then
                        MsgBox("Articulo Actualizado con el nuevo numero de parte " & txtcodigo.Text & " ID: " & id_np, MsgBoxStyle.Information)
                    End If
                End If
            End If
        End If
        If lblid_inv.Text > 0 Then ' si ya existe el numero de parte
            cmd.CommandText = "UPDATE articulos SET np='" & txtcodigo.Text & "', descripcion='" & txtdesc.Text & "', precio=" & nprecio.Value & ", minimo=" & nminimo.Value & ",marca='" & CBMarca.Text & "', modelo='" & txtmodelo.Text & "', year='" & txtaño.Text & "', mano=" & NMano.Value & ", incluido='" & cbIncluir.Text & "',obser='" & txtObservaciones.Text & "', costo=" & NCosto.Value & ", tipo='" & CBTipo.Text & "', id_inv=" & lblid_inv.Text & ", ubicacion='" & txtUbicacion.Text & "' WHERE id=" & lblid.Text
            If cmd.ExecuteNonQuery Then
                MsgBox("Articulo Actualizado con el numero de parte existente " & txtcodigo.Text & " ID: " & lblid_inv.Text, MsgBoxStyle.Information)

            End If
        End If
        Me.Close() ' se cierra el programa aunque no se cumplan las condiciones
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)
        frmServicioAgregarSelect.Dispose()
        frmServicioAgregarSelect.ventana.Text = "pack_ed"
        frmServicioAgregarSelect.ShowDialog()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CBTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTipo.SelectedIndexChanged
        precio_panel.BackColor = Color.Transparent
        Mano_panel.BackColor = Color.Transparent

        If CBTipo.Text = "ARTICULO" Then
            precio_panel.BackColor = Color.Yellow
            nminimo.Value = 0
            minimo_panel.Show()
        End If
        If CBTipo.Text = "SERVICIO" Then
            Mano_panel.BackColor = Color.Yellow
            nminimo.Value = 0
            minimo_panel.Hide()
        End If
    End Sub

    Private Sub txtcodigo_LostFocus(sender As Object, e As EventArgs) Handles txtcodigo.LostFocus
        lbldesc.Text = ""
        'lblid_inv.Text = ""
        Info_panel.Hide()


        frmArticulos_aviso.Dispose()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If con.State = ConnectionState.Open Then
                cmd.Connection = con
                cmd.CommandText = "SELECT id,np, descripcion,cantidad,minimo,tipo,activo,cant_unidad FROM articulos_inventario WHERE id='" & lblid_inv.Text & "' limit 1"
                datos = cmd.ExecuteReader
                If datos.HasRows Then

                    While datos.Read

                        lblid_inv.Text = datos("id")
                        lbldesc.Text = datos("descripcion")
                        txtdesc.Text = datos("descripcion")
                        lblCant_Inv.Text = datos("cantidad")
                        nminimo.Value = datos("minimo")
                        Info_panel.Show()
                        With frmArticulos_aviso

                            .lbleste.Text = "Este " & datos("tipo") & " existe con el Numero de parte:"
                            .lblnp.Text = txtcodigo.Text
                            .lbldesc.Text = datos("descripcion")
                            .lbltipo.Text = datos("tipo")
                            .lblcantidad_articulo.Text = datos("cant_unidad")
                            .lblexistencia.Text = datos("cantidad")
                            If datos("activo") = "NO" Then
                                .lblactivo.Text = "NO esta activo!!!!"
                            End If
                            If datos("activo") = "SI" Then
                                .lblactivo.Text = "está activo."
                            End If

                            .lbl_id_inv.Text = datos("id")
                        End With

                    End While
                    If Not datos.IsClosed Then datos.Close()
                    txtcodigo.Enabled = False
                    'EditarNP.Checked = False
                    frmArticulos_aviso.cargar_relacionados()
                    frmArticulos_aviso.ShowDialog()



                Else
                    '----BUSCAR POR NP
                    If Not datos.IsClosed Then datos.Close()
                    cmd.CommandText = "SELECT id,np, descripcion,cantidad,minimo,tipo,activo,cant_unidad FROM articulos_inventario WHERE np='" & txtcodigo.Text & "' limit 1"
                    datos = cmd.ExecuteReader
                    If datos.HasRows Then

                        While datos.Read

                            lblid_inv.Text = datos("id")
                            lbldesc.Text = datos("descripcion")
                            txtdesc.Text = datos("descripcion")
                            lblCant_Inv.Text = datos("cantidad")
                            nminimo.Value = datos("minimo")
                            Info_panel.Show()
                            With frmArticulos_aviso

                                .lbleste.Text = "Este " & datos("tipo") & " existe con el Numero de parte:"
                                .lblnp.Text = txtcodigo.Text
                                .lbldesc.Text = datos("descripcion")
                                .lbltipo.Text = datos("tipo")
                                .lblcantidad_articulo.Text = datos("cant_unidad")
                                .lblexistencia.Text = datos("cantidad")
                                If datos("activo") = "NO" Then
                                    .lblactivo.Text = "NO esta activo!!!!"
                                End If
                                If datos("activo") = "SI" Then
                                    .lblactivo.Text = "está activo."
                                End If

                                .lbl_id_inv.Text = datos("id")
                            End With

                        End While
                        If Not datos.IsClosed Then datos.Close()
                        txtcodigo.Enabled = False
                        'EditarNP.Checked = False
                        frmArticulos_aviso.cargar_relacionados()
                    Else
                        lbldesc.Text = ""
                        lblCant_Inv.Text = "0"
                    End If
                    ' lblid_inv.Text = ""
                    

                    End If
                    If Not datos.IsClosed Then datos.Close()
            End If
        Catch ex As Exception
            ' If Not datos.IsClosed Then datos.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information, "Insertar")
        End Try

    End Sub

    Private Sub txtcodigo_TextChanged(sender As Object, e As EventArgs) Handles txtcodigo.TextChanged

    End Sub

    Private Sub txtdesc_TextChanged(sender As Object, e As EventArgs) Handles txtdesc.TextChanged

    End Sub

    Private Sub lblid_Click(sender As Object, e As EventArgs) Handles lblid.Click

    End Sub

    Private Sub nprecio_ValueChanged(sender As Object, e As EventArgs) Handles nprecio.ValueChanged
        sumar_2valores()
    End Sub

    Private Sub NMano_ValueChanged(sender As Object, e As EventArgs) Handles NMano.ValueChanged
        sumar_2valores()
    End Sub

    Private Sub seleccionar_valor(sender As Object, e As EventArgs) Handles nprecio.Click, nminimo.Click, NMano.Click, NCosto.Click
        sender.select(0, 1000)
    End Sub

    Private Sub cbIncluir_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIncluir.SelectedIndexChanged

    End Sub
End Class