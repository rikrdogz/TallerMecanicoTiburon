Imports Spire.Xls
Public Class frmCotizacion_Editar

    Private Sub frmCotizacion_Editar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estructura_ventana(Me)
        NSub.Controls(0).Hide()
        NIva.Controls(0).Hide()
        NTotal.Controls(0).Hide()
        cargar_detalle()
        Calcular()
    End Sub
    Private Sub cargar_detalle()
        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultados As New DataTable

        Try

            consulta = "SELECT * FROM servicios_cotdetalle WHERE ncotizacion=" & NFolio.Value
            tablaResultados = tool.ObtenerTabla(consulta)
            TablaPiezas.Rows.Clear()

            If tablaResultados.Rows.Count > 0 Then
                If lblID.Text = "0" Then lblID.Text = tablaResultados.Rows(0).Item("camion")

                For Each xRow As DataRow In tablaResultados.Rows
                    TablaPiezas.Rows.Add(xRow.Item("numero"), xRow.Item("idpieza"), xRow.Item("np"), xRow.Item("cantidad"), xRow.Item("descripcion"), xRow.Item("costo"), (xRow.Item("precio") - xRow.Item("mano")), xRow.Item("mano"), 0, 0, xRow.Item("tipo"))
                Next
            End If

            lblcant.Text = TablaPiezas.Rows.Count
            Info_Camion()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            btnGuardar.Enabled = False

        End Try
    End Sub
    Private Sub Info_Camion()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultados As New DataTable

        Try
            If lblID.Text = "0" Then
                Throw New Exception("no se pudo establecer la información del auto")
            End If

            consulta = "SELECT * FROM autos WHERE id=" & lblID.Text
            tablaResultados = tool.ObtenerTabla(consulta)
            If tablaResultados.Rows.Count > 0 Then
                With tablaResultados.Rows(0)
                    lblNuevo.Text = .Item("nuevo")
                    lblAnterior.Text = .Item("anterior")
                    lblMarca.Text = .Item("marca")
                    lblmodelo.Text = .Item("modelo")
                    lblserie.Text = .Item("serie")
                    lblplacas.Text = .Item("placas")
                    lbltexto.Text = .Item("texto")
                End With

            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)

        End Try
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If TablaPiezas.Rows.Count > 0 Then
            Dim i As Integer = TablaPiezas.CurrentRow.Index
            If MsgBox("¿deseas eliminar " & TablaPiezas.Rows(i).Cells("desc").Value & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If TablaPiezas.Rows(i).Cells("iddetalle").Value <> 0 Then
                    tabla_eliminar.Rows.Add(TablaPiezas.Rows(i).Cells("iddetalle").Value)
                End If
                TablaPiezas.Rows.RemoveAt(i)
                Calcular()
            End If
        End If
    End Sub
    Private Sub Calcular()
        Dim suma As Decimal = 0
        Dim sumacant As Decimal = 0
        If TablaPiezas.Rows.Count > 0 Then
            For i = 0 To TablaPiezas.Rows.Count - 1
                With TablaPiezas.Rows(i)
                    .Cells("importe").Value = (.Cells("precio").Value + .Cells("mano").Value)
                    .Cells("total").Value = .Cells("importe").Value * .Cells("cant").Value
                    sumacant += .Cells("cant").Value
                End With
                suma += TablaPiezas.Rows(i).Cells("total").Value
            Next

        End If
       
        NSub.Value = suma
        NIva.Value = NSub.Value * My.Settings.Iva
        NTotal.Value = NSub.Value + NIva.Value
        lblsuma.Text = sumacant

    End Sub


    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        frmServicioAgregarSelect.Dispose()

        frmServicioAgregarSelect.txtInfoMarca.Text = lblMarca.Text
        frmServicioAgregarSelect.txtInfoModelo.Text = lblmodelo.Text
        frmServicioAgregarSelect.txtInfoAño.Text = lblaño.Text
        frmServicioAgregarSelect.lbltipo.Text = "PIEZA"
        frmServicioAgregarSelect.ventana.Text = "EDIT_COT"
        frmServicioAgregarSelect.ShowDialog()
        Calcular()
    End Sub

    Private Sub btnServicio_Click(sender As Object, e As EventArgs) Handles btnServicio.Click
        frmServicioAgregarSelect.Dispose()

        frmServicioAgregarSelect.txtInfoMarca.Text = lblMarca.Text
        frmServicioAgregarSelect.txtInfoModelo.Text = lblmodelo.Text
        frmServicioAgregarSelect.txtInfoAño.Text = lblaño.Text
        frmServicioAgregarSelect.lbltipo.Text = "SERVICIO"
        frmServicioAgregarSelect.ventana.Text = "EDIT_COT"
        frmServicioAgregarSelect.ShowDialog()
        frmServicioAgregarSelect.txtdesc.Focus()

        If TablaPiezas.Rows.Count > 0 Then
            For i = 0 To TablaPiezas.Rows.Count - 1
                With TablaPiezas.Rows(i)
                    .Cells("importe").Value = (.Cells("precio").Value + .Cells("mano").Value)
                    .Cells("total").Value = .Cells("importe").Value * .Cells("cant").Value
                End With
            Next

        End If
        Calcular()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultados As New DataTable
        Dim comando As New MySql.Data.MySqlClient.MySqlCommand
        Dim transaccionActualizar As MySql.Data.MySqlClient.MySqlTransaction = Nothing
        Dim cotizacionGuardada As Boolean = False

        If TablaPiezas.Rows.Count > 0 Then
            Dim continuar As Boolean = False
            Dim folio As Integer = 0
            Dim valores As String = ""
            Dim cambiarfecha As Boolean = False
            Try

                comando.Connection = New MySql.Data.MySqlClient.MySqlConnection
                comando.Connection.ConnectionString = con.ConnectionString
                comando.Connection.Open()

                transaccionActualizar = comando.Connection.BeginTransaction
                comando.Transaction = transaccionActualizar

                'ACTUALIZANDO FOLIO COT
                consulta = "UPDATE servicios SET valor=" & NTotal.Value & ", km='" & txtKM.Text & "', para='" & txtObservacion.Text & "', iva=" & My.Settings.Iva & " WHERE id=" & lblservicio.Text
                If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                    For i = 0 To tabla_eliminar.Rows.Count - 1
                        consulta = "DELETE FROM servicios_cotdetalle WHERE numero=" & tabla_eliminar.Rows(i).Cells("iddet").Value
                        If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                            If i = tabla_eliminar.Rows.Count - 1 Then
                                MsgBox("Renglones limpios", MsgBoxStyle.Information)
                            End If
                        Else
                            Throw New Exception("no se pudo eliminar un concepto" & tabla_eliminar.Rows(i).Cells("iddet").Value)
                        End If
                    Next

                    For i = 0 To TablaPiezas.Rows.Count - 1
                        If TablaPiezas.Rows(i).Cells("iddetalle").Value = 0 Then
                            valores = lblservicio.Text & ","
                            valores &= lblID.Text & ","
                            valores &= "'" & Format(fecha.Value, "yyyy/MM/dd") & "',"
                            valores &= TablaPiezas.Rows(i).Cells("total").Value & ","
                            valores &= TablaPiezas.Rows(i).Cells("id").Value & ","
                            valores &= "'" & TablaPiezas.Rows(i).Cells("np").Value & "',"
                            valores &= "'" & TablaPiezas.Rows(i).Cells("desc").Value & "',"
                            valores &= TablaPiezas.Rows(i).Cells("cant").Value & ","
                            valores &= TablaPiezas.Rows(i).Cells("importe").Value & ","
                            valores &= NFolio.Value & ","
                            valores &= "'" & TablaPiezas.Rows(i).Cells("marcado").Value & "',"
                            valores &= TablaPiezas.Rows(i).Cells("mano").Value & ","
                            valores &= TablaPiezas.Rows(i).Cells("costo").Value
                            consulta = "INSERT INTO servicios_cotdetalle (id_servicio,camion,fecha,valor,idpieza,np,descripcion,cantidad,precio,ncotizacion,tipo,mano,costo) VALUES (" & valores & ")"
                            If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                                If i = TablaPiezas.Rows.Count - 1 Then
                                    Generar_COT()
                                    transaccionActualizar.Commit()
                                    MsgBox("Guardado, Archivo excel generado", MsgBoxStyle.Information)
                                    cotizacionGuardada = True

                                End If
                            End If
                        Else

                            With TablaPiezas.Rows(i)
                                'buscar modificacion
                                consulta = "SELECT tipo FROM servicios_cotdetalle where numero=" & .Cells("iddetalle").Value
                                tablaResultados = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)
                                If tablaResultados.Rows.Count > 0 Then

                                    If tablaResultados.Rows(0).Item("tipo") <> .Cells("marcado").Value Then

                                        cambiarfecha = True
                                    Else
                                        cambiarfecha = False
                                    End If

                                End If
                                If cambiarfecha Then
                                    consulta = "UPDATE servicios_cotdetalle SET cantidad=" & .Cells("cant").Value & ", descripcion='" & .Cells("desc").Value & "'," & _
                                  "costo=" & .Cells("costo").Value & ", mano=" & .Cells("mano").Value & ", precio=" & .Cells("importe").Value & ", valor=" & .Cells("total").Value & ", tipo='" & .Cells("marcado").Value & "', fecha='" & Format(fecha.Value, "yyyy/MM/dd") & "' WHERE numero=" & .Cells("iddetalle").Value
                                Else
                                    consulta = "UPDATE servicios_cotdetalle SET cantidad=" & .Cells("cant").Value & ", descripcion='" & .Cells("desc").Value & "'," & _
                                  "costo=" & .Cells("costo").Value & ", mano=" & .Cells("mano").Value & ", precio=" & .Cells("importe").Value & ", valor=" & .Cells("total").Value & ", tipo='" & .Cells("marcado").Value & "' WHERE numero=" & .Cells("iddetalle").Value
                                End If

                                If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                                    If i = TablaPiezas.Rows.Count - 1 Then
                                        Generar_COT()
                                        transaccionActualizar.Commit()
                                        MsgBox("Guardado, Archivo excel generado", MsgBoxStyle.Information)
                                        cotizacionGuardada = True
                                        frmServicio.cargar_info()

                                        frmServicio.cargar_Detalle()
                                    End If
                                Else
                                    Throw New Exception("No se pudo actualizar la información por el articulo " & .Cells("desc").Value.ToString)
                                End If
                            End With

                        End If


                    Next

                End If

                If cotizacionGuardada Then

                    Dim EnviarCotizacion As New frmEnviarCotizacion(NFolio.Value, lblNuevo.Text, lbltexto.Text, lblAnterior.Text)
                    EnviarCotizacion.ShowDialog()
                    btnClose.PerformClick()
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

    End Sub
    Private Sub Generar_COT()
        Dim j As Integer = 16
        Try
            Dim workbook As Workbook = New Workbook()
            workbook.Version = ExcelVersion.Version2007
            workbook.LoadFromFile(Application.StartupPath & "\formato.xlsx")
            Dim sheet As Worksheet = workbook.Worksheets(0)
            sheet.Range("D9").Value = NFolio.Value
            sheet.Range("B9").Value = fecha.Value
            sheet.Range("B12").Text = lblNuevo.Text & " " & lbltexto.Text & " " & lblAnterior.Text
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
            sheet.Range("D41").Value = NSub.Value
            sheet.Range("D42").Value = NIva.Value
            sheet.Range("D43").Value = NTotal.Value
            workbook.SaveToFile(Application.StartupPath & "\cot\cot" & NFolio.Value & ".xlsx")
            MsgBox("GENERADO", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If TablaPiezas.Rows.Count > 0 Then
            Dim i As Integer = TablaPiezas.CurrentRow.Index
            frmCotizacion_RenglonEdit.Dispose()
            frmCotizacion_RenglonEdit.lblindex.Text = i
            With TablaPiezas.Rows(i)
                frmCotizacion_RenglonEdit.NCant.Value = .Cells("cant").Value
                frmCotizacion_RenglonEdit.txtdesc.Text = .Cells("desc").Value
                frmCotizacion_RenglonEdit.Ncosto.Value = .Cells("costo").Value
                frmCotizacion_RenglonEdit.Nmano.Value = .Cells("mano").Value
                frmCotizacion_RenglonEdit.Nprecio.Value = .Cells("precio").Value
            End With
            frmCotizacion_RenglonEdit.lblventana.Text = "EDIT_COT"
            frmCotizacion_RenglonEdit.ShowDialog()
            Calcular()
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

        For i = 0 To MDIPrincipal.MdiChildren.Length - 1
            If MDIPrincipal.MdiChildren(i).Name = "frmServicio" Then
                MDIPrincipal.MdiChildren(i).WindowState = FormWindowState.Normal



                MDIPrincipal.MdiChildren(i).MaximizeBox = False
            End If
        Next
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Generar_COTprecio()
    End Sub
    Private Sub Generar_COTprecio()
        Dim j As Integer = 16
        Try
            Dim workbook As Workbook = New Workbook()
            workbook.LoadFromFile(Application.StartupPath & "\formato.xlsx")
            Dim sheet As Worksheet = workbook.Worksheets(0)
            sheet.Range("D9").Value = NFolio.Value
            sheet.Range("B12").Text = lblNuevo.Text & " ANTERIOR " & lblAnterior.Text
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
                sheet.Range(j, 3).Value = TablaPiezas.Rows(i).Cells("precio").Value
                sheet.Range(j, 4).Value = TablaPiezas.Rows(i).Cells("precio").Value * TablaPiezas.Rows(i).Cells("cant").Value

            Next
            workbook.SaveToFile(Application.StartupPath & "\cot\cot" & NFolio.Value & ".xlsx")
            MsgBox("GENERADO", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnDescuento_Click(sender As Object, e As EventArgs) Handles btnDescuento.Click
        frmServicio_AddManual.lblVentana.Text = "EDIT_COT"
        frmServicio_AddManual.ShowDialog()
        Calcular()
    End Sub

    Private Sub TablaPiezas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaPiezas.CellClick
     
    End Sub

    Private Sub TablaPiezas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaPiezas.CellContentClick

    End Sub

    Private Sub TablaPiezas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaPiezas.CellContentDoubleClick
        If TablaPiezas.Rows.Count > 0 Then
            Dim i As Integer = TablaPiezas.CurrentRow.Index
            btnEditar.PerformClick()

        End If
    End Sub
End Class