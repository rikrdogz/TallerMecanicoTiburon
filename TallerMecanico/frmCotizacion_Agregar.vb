Imports Spire.Xls
Public Class frmCotizacionNuevoEdtar
    Dim lista_ultimos As New List(Of Integer)
    Private Sub frmCotizacion_Agregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        estructura_ventana(Me)

        NSub.Controls(0).Hide()
        NIva.Controls(0).Hide()
        NTotal.Controls(0).Hide()

        buscar_folio()
        cargar_detalle()

    End Sub
    Private Sub buscar_folio()

        Dim consulta As String = ""
        Dim tool As New Herramienta
        Dim tablaResultados As New DataTable

        Try

            consulta = "SELECT max(numero),OC FROM servicios"
            tablaResultados = tool.ObtenerTabla(consulta)
            If tablaResultados.Rows.Count > 0 Then
                NFolio.Value = tablaResultados.Rows(0).Item(0) + 1
            End If
            consulta = "SELECT OC FROM servicios WHERE id=" & lblservicio.Text
            tablaResultados = tool.ObtenerTabla(consulta)
            If tablaResultados.Rows.Count > 0 Then
                lblOC.Text = tablaResultados.Rows(0).Item("OC")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Info_Camion()

        Dim consulta As String = ""
        Dim tool As New Herramienta
        Dim tablaResultados As New DataTable

        Try

            If lblID.Text = "0" Then
                Throw New Exception("no se establecio el ID del auto")
            End If

            consulta = "SELECT * FROM autos WHERE id=" & lblID.Text
            tablaResultados = tool.ObtenerTabla(consulta)
            If tablaResultados.Rows.Count > 0 Then
                With tablaResultados.Rows(0)
                    lblMarca.Text = .Item("marca")
                    lblmodelo.Text = .Item("modelo")
                    lblserie.Text = .Item("serie")
                    lblplacas.Text = .Item("placas")
                    lbltexto.Text = .Item("texto")
                    lblaño.Text = .Item("year")
                End With

            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            Me.Close()

        End Try
    End Sub
    Private Sub cargar_detalle()

        Dim consulta As String = ""
        Dim tool As New Herramienta
        Dim tablaResultados As New DataTable

        Try

            consulta = "SELECT * FROM servicios_detalle WHERE folio=" & lblservicio.Text
            tablaResultados = tool.ObtenerTabla(consulta)
            TablaPiezas.Rows.Clear()

            If tablaResultados.Rows.Count > 0 Then
                With tablaResultados.Rows(0)
                    lblID.Text = .Item("idauto")
                    lblNuevo.Text = .Item("nuevo")
                    lblAnterior.Text = .Item("anterior")
                End With

                For Each xRow As DataRow In tablaResultados.Rows
                    TablaPiezas.Rows.Add(xRow.Item("idpieza"), xRow.Item("np"), xRow.Item("tipo"), xRow.Item("cant"), xRow.Item("descripcion"), xRow.Item("costo"), xRow.Item("precio"), xRow.Item("mano"), 0, 0, xRow.Item("marcado"))
                Next
            End If
            lblcant.Text = TablaPiezas.Rows.Count
            Buscar_Precios()
            Info_Camion()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        borrar_text_atq()
    End Sub
    Private Sub borrar_text_atq()
        Dim texto As String = ""
        Dim avisar As Boolean = False

        If TablaPiezas.Rows.Count > 0 Then

            For i = 0 To TablaPiezas.Rows.Count - 1
                texto = TablaPiezas.Rows(i).Cells("desc").Value

                texto = Replace(texto, "ATQ", "")
                If TablaPiezas.Rows(i).Cells("desc").Value <> texto Then
                    TablaPiezas.Rows(i).Cells("desc").Value = texto
                    avisar = True

                End If

            Next
            If avisar Then
                MsgBox("Se encontro un concepto con el valor ATQ y se eliminó", MsgBoxStyle.Information)
            End If
        End If
    End Sub
    Private Sub Buscar_Precios()
        If TablaPiezas.Rows.Count > 0 Then
            Try

                For i = 0 To TablaPiezas.Rows.Count - 1

                    With TablaPiezas.Rows(i)
                        .Cells("importe").Value = (.Cells("precio").Value + .Cells("mano").Value)
                        .Cells("total").Value = .Cells("importe").Value * .Cells("cant").Value
                    End With

                Next

                lblcant.Text = TablaPiezas.Rows.Count
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If
        Calcular()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        If TablaPiezas.Rows.Count > 0 Then
            Dim i As Integer = TablaPiezas.CurrentRow.Index
            If MsgBox("¿deseas eliminar " & TablaPiezas.Rows(i).Cells("desc").Value & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                TablaPiezas.Rows.RemoveAt(i)
                Calcular()
            End If
        End If
        lblcant.Text = TablaPiezas.Rows.Count
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        frmServicioAgregarSelect.Dispose()

        frmServicioAgregarSelect.txtInfoMarca.Text = lblMarca.Text
        frmServicioAgregarSelect.txtInfoModelo.Text = lblmodelo.Text
        frmServicioAgregarSelect.txtInfoAño.Text = lblaño.Text
        frmServicioAgregarSelect.lbltipo.Text = "PIEZA"
        frmServicioAgregarSelect.ventana.Text = "COTIZAR"
        frmServicioAgregarSelect.ShowDialog()
        If TablaPiezas.Rows.Count > 0 Then
            For i = 0 To TablaPiezas.Rows.Count - 1
                With TablaPiezas.Rows(i)
                    .Cells("importe").Value = (.Cells("precio").Value + .Cells("mano").Value)
                    .Cells("total").Value = .Cells("importe").Value * .Cells("cant").Value
                End With
            Next

        End If
        lblcant.Text = TablaPiezas.Rows.Count
        Calcular()

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
        lblcant.Text = TablaPiezas.Rows.Count
        NSub.Value = suma
        NIva.Value = NSub.Value * My.Settings.Iva
        NTotal.Value = NSub.Value + NIva.Value
        lblsuma.Text = sumacant
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        Dim comando As New MySql.Data.MySqlClient.MySqlCommand
        Dim consulta As String = ""
        Dim tool As New Herramienta
        Dim tablaResultados As New DataTable
        Dim transaccionActualizar As MySql.Data.MySqlClient.MySqlTransaction = Nothing

        If TablaPiezas.Rows.Count > 0 Then
            Dim continuar As Boolean = False
            Dim folio As Integer = 0
            Dim valores As String = ""
            Dim oc_string As String = "pendiente"
            If NTotal.Value > 0 Then
            Else
                MsgBox("Esta cotizacion tiene valor cero, debe agregar un precio/mano", MsgBoxStyle.Information)
                Exit Sub
            End If

            Try
                comando.Connection = New MySql.Data.MySqlClient.MySqlConnection
                comando.Connection.ConnectionString = con.ConnectionString
                comando.Connection.Open()

                transaccionActualizar = comando.Connection.BeginTransaction
                comando.Transaction = transaccionActualizar

                consulta = "SELECT numero FROM servicios WHERE id=" & lblservicio.Text
                tablaResultados = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)
                If tablaResultados.Rows.Count > 0 Then
                    If tablaResultados.Rows(0).Item("numero") = 0 Then
                        continuar = True
                    Else
                        continuar = False
                        Throw New Exception("Este Servicio ya se encontraba cotizado")
                    End If

                End If
                If continuar Then
                    consulta = "SELECT max(numero) FROM servicios"
                    tablaResultados = tool.ObtenerTablaTransaccion(transaccionActualizar, consulta)
                    If tablaResultados.Rows.Count > 0 Then
                        folio = tablaResultados.Rows(0).Item(0) + 1
                    End If

                    'ACTUALIZANDO FOLIO COT
                    If lblOC.Text.Trim() = "" Then
                        lblOC.Text = "pendiente"
                    End If
                    consulta = "UPDATE servicios SET numero=" & folio & ", fecha_cot='" & Format(fecha.Value, "yyyy/MM/dd") & "',valor=" & NTotal.Value & ", camion='" & lblNuevo.Text & " " & lbltexto.Text & " " & lblAnterior.Text & "', km='" & txtKM.Text & "', para='" & txtObservacion.Text & "', OC='" & lblOC.Text.Trim & "', iva=" & My.Settings.Iva & " WHERE id=" & lblservicio.Text
                    If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then

                        For i = 0 To TablaPiezas.Rows.Count - 1
                            valores = lblservicio.Text & ","
                            valores &= lblID.Text & ","
                            valores &= "'" & Format(fecha.Value, "yyyy/MM/dd") & "',"
                            valores &= TablaPiezas.Rows(i).Cells("total").Value & ","
                            valores &= TablaPiezas.Rows(i).Cells("id").Value & ","
                            valores &= "'" & TablaPiezas.Rows(i).Cells("np").Value & "',"
                            valores &= "'" & TablaPiezas.Rows(i).Cells("desc").Value & "',"
                            valores &= TablaPiezas.Rows(i).Cells("cant").Value & ","
                            valores &= TablaPiezas.Rows(i).Cells("importe").Value & ","
                            valores &= folio & ","
                            valores &= "'" & TablaPiezas.Rows(i).Cells("marcado").Value & "',"
                            valores &= TablaPiezas.Rows(i).Cells("mano").Value & ","
                            valores &= TablaPiezas.Rows(i).Cells("costo").Value
                            consulta = "INSERT INTO servicios_cotdetalle (id_servicio,camion,fecha,valor,idpieza,np,descripcion,cantidad,precio,ncotizacion,tipo,mano,costo) VALUES (" & valores & ")"
                            If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                                If i = TablaPiezas.Rows.Count - 1 Then
                                    transaccionActualizar.Commit()
                                    MsgBox("Cotización Guardada, generando archivo Excel...", MsgBoxStyle.Information)
                                    Generar_COT()
                                    Dim EnviarCorreo As New frmEnviarCotizacion(CInt(NFolio.Value), lblNuevo.Text, lbltexto.Text, lblAnterior.Text)
                                    EnviarCorreo.ShowDialog()
                                    btnClose.PerformClick()
                                    frmServicio.cargar_info()
                                    frmServicio.cargar_Detalle()
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
            End Try
        End If
    End Sub
    Private Sub Generar_COT()
        Dim j As Integer = 16
        Try
            Dim workbook As Workbook = New Workbook()
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

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        For i = 0 To MDIPrincipal.MdiChildren.Length - 1
            If MDIPrincipal.MdiChildren(i).Name = "frmServicio" Then
                MDIPrincipal.MdiChildren(i).WindowState = FormWindowState.Normal
                MDIPrincipal.MdiChildren(i).MaximizeBox = False
            End If
        Next
        Me.Close()

    End Sub

    Private Sub btnServicio_Click(sender As Object, e As EventArgs) Handles btnServicio.Click
        frmServicioAgregarSelect.Dispose()

        frmServicioAgregarSelect.txtInfoMarca.Text = lblMarca.Text
        frmServicioAgregarSelect.txtInfoModelo.Text = lblmodelo.Text
        frmServicioAgregarSelect.txtInfoAño.Text = lblaño.Text
        frmServicioAgregarSelect.lbltipo.Text = "SERVICIO"
        frmServicioAgregarSelect.ventana.Text = "COTIZAR"
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

    Private Sub btnDescuento_Click(sender As Object, e As EventArgs) Handles btnDescuento.Click
        frmServicio_AddManual.Dispose()
        frmServicio_AddManual.lblVentana.Text = "ADD_COT"
        frmServicio_AddManual.ShowDialog()
        Calcular()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Generar_COT()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If TablaPiezas.Rows.Count > 0 Then
            Dim i As Integer = TablaPiezas.CurrentRow.Index
            With frmCotizacion_RenglonEdit
                .lblindex.Text = i
                .lblventana.Text = "ADD_COT"
                .NCant.Value = TablaPiezas.Rows(i).Cells("cant").Value
                .txtdesc.Text = TablaPiezas.Rows(i).Cells("desc").Value
                .Ncosto.Value = TablaPiezas.Rows(i).Cells("costo").Value
                .Nprecio.Value = TablaPiezas.Rows(i).Cells("precio").Value
                .Nmano.Value = TablaPiezas.Rows(i).Cells("mano").Value
                .ShowDialog()

            End With
            Calcular()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub



    Private Sub TablaPiezas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaPiezas.CellContentClick

    End Sub

    Private Sub TablaPiezas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaPiezas.CellDoubleClick
        btnEditar.PerformClick()
    End Sub

    Private Sub lblultimo_ser_Click(sender As Object, e As EventArgs) Handles lblultimo_ser.Click
        MsgBox(lblultimo_ser.Text, MsgBoxStyle.Information)
    End Sub


    Private Sub TablaPiezas_KeyDown(sender As Object, e As KeyEventArgs) Handles TablaPiezas.KeyDown
        If e.KeyCode = Keys.Delete Then
            btnEliminar.PerformClick()
        End If
    End Sub



    Private Sub txtKM_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKM.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            If MsgBox("¿Deseas CREAR cotización?", MsgBoxStyle.YesNo, "Confirmación") = MsgBoxResult.Yes Then
                btnGuardar.PerformClick()

            End If
        End If
    End Sub

    Private Sub txtKM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKM.KeyPress

    End Sub

    Private Sub txtKM_TextChanged(sender As Object, e As EventArgs) Handles txtKM.TextChanged

    End Sub

    Private Sub frmCotizacion_Agregar_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' estructura_ventana(Me)
    End Sub

    Private Sub NSub_ValueChanged(sender As Object, e As EventArgs) Handles NSub.ValueChanged
        NSub.ReadOnly = True
    End Sub

    Private Sub NIva_ValueChanged(sender As Object, e As EventArgs) Handles NIva.ValueChanged
        NIva.ReadOnly = True
    End Sub

    Private Sub NTotal_ValueChanged(sender As Object, e As EventArgs) Handles NTotal.ValueChanged
        NIva.ReadOnly = True
    End Sub

    Private Sub Panel8_Paint(sender As Object, e As PaintEventArgs) Handles Panel8.Paint

    End Sub
End Class