Public Class frmCotizacion_Detalle

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        validar()
        If frmCotizacion.ventana = "cot" Then
            frmCotizacion.actualizar_renglon()
        End If




    End Sub
    Private Sub validar()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable
        Dim transaccionActualizar As MySql.Data.MySqlClient.MySqlTransaction = Nothing
        Dim comando As New MySql.Data.MySqlClient.MySqlCommand

        Dim resultOC As Integer
        Dim guardar As Boolean = False
        Dim valor_ing As Decimal

        If txtOC.Text.Trim.Length > 0 And txtOC.Text <> "pendiente" Then
            If Integer.TryParse(txtOC.Text, resultOC) Then
            Else
                MsgBox("ingrese una orden de compra numerico o con el texto 'pendiente'")
                Return
            End If
        End If

        If txtFactura.TextLength > 0 Then
            Dim hoy As Date = Date.Now.ToLongDateString
            If fecha_fac.Value.ToShortDateString > hoy Then
                MsgBox("Ingrese fecha actual o anterior " & fecha_fac.Value.ToShortDateString, MsgBoxStyle.Information)
                fecha_fac.Focus()
                Exit Sub
            Else

            End If
            If NPagado.Value > 0 Then
                If CBMetodo.SelectedIndex >= 0 Then
                    If tablarelacion.Rows.Count > 0 Then
                        If MessageBox.Show("Esta acción afectará a " & tablarelacion.Rows.Count & " Servicios ¿Desea Continuar?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then

                        Else
                            Exit Sub
                        End If
                    End If
                    Dim dif As String = ""
                    Try


                        valor_ing = ntotal.Value
                        comando = New MySql.Data.MySqlClient.MySqlCommand
                        comando.Connection = New MySql.Data.MySqlClient.MySqlConnection
                        comando.Connection.ConnectionString = con.ConnectionString
                        comando.Connection.Open()

                        transaccionActualizar = comando.Connection.BeginTransaction
                        comando.Transaction = transaccionActualizar

                        If NPagado.Value < Val((ntotal.Value)) Then
                            dif = "MENOR"
                        End If
                        If NPagado.Value > Val((ntotal.Value)) Then
                            dif = "MAYOR"
                        End If
                        If NPagado.Value = Val((ntotal.Value)) Then
                            dif = "IGUAL"
                        End If
                        If Not dif = "IGUAL" Then

                            If MessageBox.Show("El valor pagado es " & dif & " ¿deseas continuar?", "pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                            Else
                                Exit Sub
                            End If

                        End If
                        If tablarelacion.Rows.Count > 0 Then
                            'si hay elementos
                            For i = 0 To tablarelacion.Rows.Count - 1
                                consulta = "UPDATE servicios SET OC='" & txtOC.Text & "', FACTURA='" & txtFactura.Text & "', PAGADO='" & NPagado.Value & "', METODO='" & CBMetodo.Text & "', DIFERENCIA='" & dif & "', SC='" & txtSC.Text & "', fecha_fac='" & Format(fecha_fac.Value, "yyyy/MM/dd") & "', ss='" & txtser.Text & "' WHERE id=" & tablarelacion.Rows(i).Cells("ID").Value
                                If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                                    MsgBox("Actualizado Servicio: " & tablarelacion.Rows(i).Cells("ID").Value, MsgBoxStyle.Information)

                                End If

                                If i = tablarelacion.Rows.Count - 1 Then
                                    transaccionActualizar.Commit()
                                    Me.Close()
                                End If
                            Next
                        Else
                            'si es cotizacion
                            consulta = "UPDATE servicios SET OC='" & txtOC.Text & "', FACTURA='" & txtFactura.Text & "', PAGADO='" & NPagado.Value & "', METODO='" & CBMetodo.Text & "', DIFERENCIA='" & dif & "', SC='" & txtSC.Text & "', fecha_fac='" & Format(fecha_fac.Value, "yyyy/MM/dd") & "' WHERE numero=" & lblCOT.Text
                            If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                                MsgBox("Actualizado COTIZACION", MsgBoxStyle.Information)
                                transaccionActualizar.Commit()
                                If frmCotizacion.ventana = "COT" Then
                                    frmCotizacion.cargar_facturas()

                                End If
                                Me.Close()
                            Else
                                Throw New Exception("No se pudo actualizar cotización")
                            End If
                        End If

                    Catch ex As Exception
                        If transaccionActualizar IsNot Nothing Then
                            transaccionActualizar.Rollback()
                        End If
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    Finally
                        If comando IsNot Nothing Then
                            If comando.Connection IsNot Nothing Then
                                If comando.Connection.State = ConnectionState.Open Then
                                    comando.Connection.Close()
                                End If
                            End If
                        End If
                    End Try

                Else

                    MsgBox("Seleccione metodo de pago", MsgBoxStyle.Information)
                    CBMetodo.Focus()
                End If
            Else
                MsgBox("Ingrese monto pagado", MsgBoxStyle.Information)
                NPagado.Focus()

            End If
        End If
        If (txtOC.TextLength > 0 Or txtSC.TextLength > 0) And txtFactura.TextLength = 0 Then
            Dim dif As String = ""
            Try
                tool = New Herramienta

                If NPagado.Value < Val(ntotal.Value) Then
                    dif = "MENOR"
                End If
                If NPagado.Value > Val(ntotal.Value) Then
                    dif = "MAYOR"
                End If
                If NPagado.Value = Val(ntotal.Value) Then
                    dif = "IGUAL"
                End If
                If lbltipo.Text = "SER" Then
                    consulta = "UPDATE servicios SET OC='" & txtOC.Text & "', FACTURA='" & txtFactura.Text & "', PAGADO='" & NPagado.Value & "', METODO='" & CBMetodo.Text & "', DIFERENCIA='" & dif & "', SC='" & txtSC.Text & "' WHERE id=" & lblCOT.Text
                Else
                    consulta = "UPDATE servicios SET OC='" & txtOC.Text & "', FACTURA='" & txtFactura.Text & "', PAGADO='" & NPagado.Value & "', METODO='" & CBMetodo.Text & "', DIFERENCIA='" & dif & "', SC='" & txtSC.Text & "' WHERE numero=" & lblCOT.Text
                End If

                If tool.ActualizarDatos(consulta) Then
                    MsgBox("Actualizado " & lbltitulo.Text, MsgBoxStyle.Information)
                    Me.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If
    End Sub
    
    Private Sub frmCotizacion_Detalle_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
        If e.KeyCode = Keys.F2 Then
            btnGuardar.PerformClick()
            btnSAVE.PerformClick()

        End If
    End Sub

    Private Sub frmCotizacion_Detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable


        CBFac.SelectedIndex = 0
        CBMetodo.SelectedIndex = -1

        If lbltipo.Text = "SER" Then
            Try
                consulta = "SELECT * FROM servicios WHERE id=" & lblCOT.Text
                tablaResultado = tool.ObtenerTabla(consulta)
                If tablaResultado.Rows.Count > 0 Then
                    txtOC.Text = tablaResultado.Rows(0).Item("OC")
                    txtFactura.Text = tablaResultado.Rows(0).Item("FACTURA")
                    ntotal.Value = tablaResultado.Rows(0).Item("valor")
                    CBMetodo.SelectedItem = tablaResultado.Rows(0).Item("METODO")
                    txtser.Text = tablaResultado.Rows(0).Item("ss")
                    NPagado.Value = tablaResultado.Rows(0).Item("PAGADO")
                    txtSC.Text = tablaResultado.Rows(0).Item("sc")
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

        End If
        If lbltipo.Text = "COT" Then
            Try
                consulta = "SELECT * FROM servicios WHERE numero=" & lblCOT.Text
                tablaResultado = tool.ObtenerTabla(consulta)
                If tablaResultado.Rows.Count > 0 Then
                    txtOC.Text = tablaResultado.Rows(0).Item("OC")
                    txtSC.Text = tablaResultado.Rows(0).Item("sc")
                    txtFactura.Text = tablaResultado.Rows(0).Item("FACTURA")
                    ntotal.Value = tablaResultado.Rows(0).Item("valor")
                    CBMetodo.SelectedItem = tablaResultado.Rows(0).Item("METODO")
                    txtser.Text = tablaResultado.Rows(0).Item("ss")
                    NPagado.Value = tablaResultado.Rows(0).Item("PAGADO")
                    CBFac.SelectedValue = tablaResultado.Rows(0).Item("req_fac")
                    If IsDBNull(tablaResultado.Rows(0).Item("fecha_fac")) Then

                    Else
                        If IsDate(tablaResultado.Rows(0).Item("fecha_fac")) And tablaResultado.Rows(0).Item("fecha_fac").ToString > fecha_fac.MinDate Then
                            fecha_fac.Value = tablaResultado.Rows(0).Item("fecha_fac")
                            lblfecha.ForeColor = Color.DarkBlue
                        End If

                    End If


                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Cargar Informacion cot_detalle")
            End Try
        End If

        buscarRelacionado()

    End Sub
    Private Sub buscarRelacionado()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable
        txtOC.Text = txtOC.Text.Trim
        Try
            If txtOC.TextLength > 0 Then
                consulta = "SELECT * FROM servicios WHERE OC = '" & txtOC.Text & "' AND OC<>'pendiente'"
                tablaResultado = tool.ObtenerTabla(consulta)

                tablarelacion.Rows.Clear()
                npreven.Value = 0
                If tablaResultado.Rows.Count > 0 Then
                    For Each xRow As DataRow In tablaResultado.Rows
                        If IsNumeric(xRow.Item("valor")) Then
                            If xRow.Item("numero") > 0 Then 'si se cotizo
                                'sacar el subtotal

                                npreven.Value += (xRow.Item("valor") / 1.16)
                                tablarelacion.Rows.Add(xRow.Item("id"), (xRow.Item("valor") / 1.16), xRow.Item("ncamion"), xRow.Item("FACTURA"), xRow.Item("numero"))
                            Else
                                npreven.Value += xRow.Item("valor")
                                tablarelacion.Rows.Add(xRow.Item("id"), Val(xRow.Item("valor")), xRow.Item("ncamion"), xRow.Item("FACTURA"), xRow.Item("numero"))
                            End If


                        Else
                            tablarelacion.Rows.Add(xRow.Item("id"), 0, xRow.Item("ncamion"), xRow.Item("FACTURA"))

                        End If
                    Next

                    npreven.Value = npreven.Value * 1.16
                    npreven.Value = Math.Round(npreven.Value, 2)
                    ntotal.Value = npreven.Value

                End If


                For i = 0 To tablarelacion.Rows.Count - 1
                    If IsNumeric(Val(tablarelacion.Rows(i).Cells("atq").Value)) Then
                        consulta = "SELECT nuevo,anterior,texto FROM autos Where id=" & tablarelacion.Rows(i).Cells("atq").Value
                        tablaResultado = tool.ObtenerTabla(consulta)
                        If tablaResultado.Rows.Count > 0 Then
                            With tablaResultado.Rows(0)
                                tablarelacion.Rows(i).Cells("atq").Value = " " & .Item("nuevo") & " " & .Item("texto") & " " & .Item("anterior")
                            End With

                        End If

                    End If

                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        

    End Sub

    Private Sub txtOC_GotFocus(sender As Object, e As EventArgs) Handles txtOC.GotFocus
        txtOC.Select(0, 1000)

    End Sub

    Private Sub txtOC_LostFocus(sender As Object, e As EventArgs) Handles txtOC.LostFocus
        buscarRelacionado()
    End Sub

    Private Sub txtOC_TextChanged(sender As Object, e As EventArgs) Handles txtOC.TextChanged

    End Sub

    Private Sub txtSC_GotFocus(sender As Object, e As EventArgs) Handles txtSC.GotFocus
        sender.Select(0, 1000)
    End Sub

    Private Sub txtFactura_GotFocus(sender As Object, e As EventArgs) Handles txtFactura.GotFocus
        sender.Select(0, 1000)
    End Sub

    Private Sub siguiente(sender As Object, e As KeyPressEventArgs) Handles txtSC.KeyPress, txtOC.KeyPress, txtFactura.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.Send("{TAB}")

        End If
    End Sub

    Private Sub NPagado_GotFocus(sender As Object, e As EventArgs) Handles NPagado.GotFocus
        sender.Select(0, 1000)
    End Sub

    Private Sub NPagado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NPagado.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = False
            CBMetodo.Focus()



        End If
    End Sub




    Private Sub sig(sender As Object, e As KeyPressEventArgs) Handles CBMetodo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btnGuardar.Focus()

        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub


    Private Sub CBFac_KeyDown(sender As Object, e As KeyEventArgs) Handles CBFac.KeyDown
        If e.KeyCode = Keys.Enter Then
            NPagado.Focus()

        End If
    End Sub

    Private Sub CBFac_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBFac.KeyPress


    End Sub

    Private Sub CBFac_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBFac.SelectedIndexChanged
        If CBFac.Text = "NO" Then
            txtFactura.Text = "sinFAC"
            If txtOC.TextLength > 0 Then
            Else
                txtOC.Text = "sinOC"
            End If
        End If
    End Sub

    Private Sub CBMetodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMetodo.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnLimpiarGuardar.Click

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Try

            CBMetodo.SelectedIndex = -1
            If lbltipo.Text = "SER" Then
                consulta = "UPDATE servicios SET OC='" & txtOC.Text & "', FACTURA='" & txtFactura.Text & "', PAGADO='" & NPagado.Value & "', METODO='" & CBMetodo.Text & "', SC='" & txtSC.Text & "' WHERE id=" & lblCOT.Text
            Else

                consulta = "UPDATE servicios SET OC='" & txtOC.Text & "', FACTURA='" & txtFactura.Text & "', PAGADO='" & NPagado.Value & "', METODO='" & CBMetodo.Text & "', SC='" & txtSC.Text & "' WHERE numero=" & lblCOT.Text
            End If

            If tool.ActualizarDatos(consulta) Then
                MsgBox("Actualizado" & lbltitulo.Text, MsgBoxStyle.Information)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnSAVE_Click(sender As Object, e As EventArgs) Handles btnSAVE.Click
        Dim guardar As Boolean = True

        guardar = True

        Dim insertar As Boolean = False
        Dim actualizar As Boolean

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If con.State = ConnectionState.Open Then
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM preventivo WHERE OC='" & txtOC.Text & "'"
                datos = cmd.ExecuteReader
                If datos.HasRows Then
                    actualizar = True
                    insertar = False
                Else
                    actualizar = False
                    insertar = True
                End If
                datos.Close()
                If insertar Then

                    cmd.CommandText = "INSERT INTO preventivo (OC,TOTAL,FACTURA,PAGADO) VALUES ('" & txtOC.Text & "'," & npreven.Value & ",'" & txtFactura.Text & "'," & NPagado.Value & ")"
                    If cmd.ExecuteNonQuery Then
                        MsgBox("Insertado")
                        For i = 0 To tablarelacion.Rows.Count - 1
                            cmd.CommandText = "UPDATE servicios SET FACTURA=" & txtFactura.Text & ", PAGADO=" & NPagado.Value & ",METODO='" & CBMetodo.Text & "', estado='TERMINADO', ss='" & txtser.Text & "' WHERE id=" & tablarelacion.Rows(i).Cells("id").Value
                            If cmd.ExecuteNonQuery Then
                                If i = tablarelacion.Rows.Count - 1 Then
                                    MsgBox("Actualizado", insertar)
                                End If
                            End If

                        Next


                        'Me.Close()

                    End If
                ElseIf actualizar Then


                Else


                    For i = 0 To tablarelacion.Rows.Count - 1
                        cmd.CommandText = "UPDATE servicios SET OC='" & txtOC.Text & "', FACTURA='" & txtFactura.Text & "', PAGADO=" & NPagado.Value & ",METODO='" & CBMetodo.Text & "', estado='TERMINADO',req_fac='" & CBFac.Text & "' WHERE id=" & tablarelacion.Rows(i).Cells("id").Value

                        If cmd.ExecuteNonQuery Then
                            If i = tablarelacion.Rows.Count - 1 Then
                                MsgBox("Actualizado", insertar)
                            End If
                        End If

                    Next
                    cmd.CommandText = "UPDATE preventivo SET total=" & npreven.Value & ", factura='" & txtFactura.Text & "', PAGADO=" & NPagado.Value & " WHERE OC='" & txtOC.Text & "'"
                    If cmd.ExecuteNonQuery Then
                        MsgBox("Actualizado OC SERVICIOS", MsgBoxStyle.Information)
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub txtser_GotFocus(sender As Object, e As EventArgs) Handles txtser.GotFocus
        sender.Select(0, 1000)
    End Sub

    Private Sub txtser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtser.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True

            txtFactura.Focus()

        End If
    End Sub

    Private Sub txtser_TextChanged(sender As Object, e As EventArgs) Handles txtser.TextChanged

    End Sub

    Private Sub txtFactura_TextChanged(sender As Object, e As EventArgs) Handles txtFactura.TextChanged
        If txtFactura.TextLength > 0 Then

            fecha_fac.Show()
            lblfecha.Show()
        Else
            lblfecha.Hide()
            fecha_fac.Hide()
        End If
    End Sub

    Private Sub NPagado_ValueChanged(sender As Object, e As EventArgs) Handles NPagado.ValueChanged

    End Sub

    Private Sub fecha_fac_KeyDown(sender As Object, e As KeyEventArgs) Handles fecha_fac.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = False
            CBMetodo.Focus()
        End If
    End Sub

    Private Sub fecha_fac_ValueChanged(sender As Object, e As EventArgs) Handles fecha_fac.ValueChanged

    End Sub

    Private Sub txtSC_TextChanged(sender As Object, e As EventArgs) Handles txtSC.TextChanged

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtFactura.TextLength = 0 Then
            txtOC.Text = "NOREALIZADO"
        End If
    End Sub

    Private Sub tablarelacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablarelacion.CellContentClick

    End Sub
End Class