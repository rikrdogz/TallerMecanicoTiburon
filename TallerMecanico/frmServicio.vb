

Public Class frmServicio

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub frmServicio_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            e.Handled = True
            If txtNumero.TextLength = 0 And txtNuevo.TextLength = 0 And txtAnterior.TextLength = 0 And txtMarca.TextLength = 0 And txtEstado.TextLength = 0 And TXTOC.TextLength = 0 Then
                Me.Close()
            Else

                txtNumero.Clear()
                txtNuevo.Clear()
                txtAnterior.Clear()
                txtMarca.Clear()
                txtEstado.Clear()
                TXTOC.Clear()

            End If
        End If
    End Sub

    Private Sub frmServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        estructura_ventana(Me)
        barra.Maximum = Me.Width

        barra.Value = Panel4.Width
        CBCotizar.SelectedIndex = 0
    End Sub
    Public Sub CargarServicios()
        Dim state As String = "TERMINADO"
        Try

            Dim tool As New Herramienta
            Dim consulta As String
            Dim tablaResultado As New DataTable

            consulta = "SELECT * FROM servicios WHERE numero like '%" & txtNumero.Text & "%' AND nuevo like '%" & txtNuevo.Text & "%' AND anterior like '%" & txtAnterior.Text & "%' AND marca like '%" & txtMarca.Text & "%' AND estado like '%" & txtEstado.Text & "%' AND OC like '%" & TXTOC.Text & "%' AND para like '%" & txtObser.Text & "%' AND id like '%" & txtSER.Text & "%' ORDER BY id DESC LIMIT " & Maximos.Value

            tablaResultado = tool.ObtenerTabla(consulta)
            tablaAutos.Rows.Clear()

            If tablaResultado.Rows.Count > 0 Then
                For Each xRow As DataRow In tablaResultado.Rows
                    tablaAutos.Rows.Add(
                        xRow.Item("id"), xRow.Item("fecha"), xRow.Item("ncamion"), xRow.Item("nuevo"), xRow.Item("anterior"), xRow.Item("marca"), xRow.Item("year"), xRow.Item("estado"), xRow.Item("numero"), xRow.Item("para"), xRow.Item("km"), xRow.Item("oc"), xRow.Item("factura"), xRow.Item("SC"), xRow.Item("cotizar"), Val(xRow.Item("valor")), Val(xRow.Item("total"))
                        )
                Next
            End If


            lblcount.Text = tablaAutos.Rows.Count


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        cargar_info()
        cargar_Detalle()
    End Sub
    Public Sub cargar_Detalle()
        tabladetalle.Rows.Clear()

        If tablaAutos.Rows.Count > 0 Then
            Dim i As Integer = tablaAutos.CurrentRow.Index

            If i <= -1 Then
                Return
            End If

            Try
                Dim tool As New Herramienta
                Dim tablaResultado As New DataTable
                Dim consulta As String = "SELECT * FROM servicios_detalle WHERE folio=" & tablaAutos.Rows(i).Cells("servicio").Value

                tablaResultado = tool.ObtenerTabla(consulta)

                For Each xRow As DataRow In tablaResultado.Rows
                    tabladetalle.Rows.Add(xRow.Item("cant"), xRow.Item("np"), xRow.Item("descripcion"), Val(xRow.Item("precio") + xRow.Item("mano")), xRow.Item("fecha"), xRow.Item("marcado"), xRow.Item("id_inv"))
                Next

                tablaRenglon.Rows.Clear()

                If IsNumeric(tablaAutos.Rows(i).Cells("cotizacion").Value.ToString) Then

                    tablaResultado = New DataTable

                    consulta = "SELECT cantidad,descripcion,precio,tipo FROM servicios_cotdetalle WHERE ncotizacion=" & tablaAutos.Rows(i).Cells("cotizacion").Value.ToString

                    tablaResultado = tool.ObtenerTabla(consulta)

                    For Each xRow As DataRow In tablaResultado.Rows
                        tablaRenglon.Rows.Add(xRow.Item("cantidad"), xRow.Item("descripcion"), xRow.Item("precio"), xRow.Item("tipo"))
                    Next
                Else
                    tablaRenglon.Rows.Clear()
                End If

                btnEdit.Text = "Editar: Servicio " & tablaAutos.Rows(i).Cells("servicio").Value
                btnCOT.Text = "COT:" & tablaAutos.Rows(i).Cells("cotizacion").Value.ToString

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If

    End Sub

    Private Sub buscar(sender As Object, e As EventArgs) Handles txtNumero.TextChanged, txtNuevo.TextChanged, txtMarca.TextChanged, txtEstado.TextChanged, txtAnterior.TextChanged, txtSER.TextChanged

        'CargarServicios()
        'cargar_Detalle()
    End Sub

    Private Sub tablaAutos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaAutos.CellClick

    End Sub
    Public Sub cargar_info()
        lbltotal.Text = "TOTAL =$0"
        lblFAC.Text = "FAC "
        If tablaAutos.Rows.Count > 0 Then
            Dim i As Integer = tablaAutos.CurrentRow.Index

            If i <= -1 Then
                Return
            End If

            Try

                Dim tool As New Herramienta
                Dim consulta As String = "SELECT * FROM servicios WHERE id=" & tablaAutos.Rows(i).Cells("servicio").Value
                Dim tablaResultado As New DataTable

                tablaResultado = tool.ObtenerTabla(consulta)

                For Each xRow As DataRow In tablaResultado.Rows
                    If xRow.Item("numero") = 0 Then
                        tablaAutos.Rows(i).Cells("cotizacion").Value = xRow.Item("numero")
                    Else
                        tablaAutos.Rows(i).Cells("cotizacion").Value = xRow.Item("numero")
                    End If
                    tablaAutos.Rows(i).Cells("estado").Value = xRow.Item("estado")
                    tablaAutos.Rows(i).Cells("km").Value = xRow.Item("km")
                    tablaAutos.Rows(i).Cells("oc").Value = xRow.Item("OC")
                    tablaAutos.Rows(i).Cells("fac").Value = xRow.Item("FACTURA")
                    tablaAutos.Rows(i).Cells("observacion").Value = xRow.Item("para")
                    lblObserv.Text = tablaAutos.Rows(i).Cells("observacion").Value
                    lbltotal.Text = "TOTAL: " & FormatCurrency(xRow.Item("valor"))
                    lblFAC.Text = xRow.Item("FACTURA")
                Next

                btnEdit.Text = "Editar: Servicio " & tablaAutos.Rows(i).Cells("servicio").Value
                btnCOT.Text = "COT:" & tablaAutos.Rows(i).Cells("cotizacion").Value.ToString
                lblcount.Text = tablaAutos.Rows.Count

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try

        End If
    End Sub

    Private Sub MostrarInfoEnPanel(IndexServicio As Integer)
        If IndexServicio < 0 Then
            'Ocultar panel de titulo
            PanelTituloServicio.Hide()
            lblTotalServicio.Hide()
            Return
        Else
            lblTotalServicio.Show()
            PanelTituloServicio.Show()
        End If
        With tablaAutos.Rows(IndexServicio)
            If (.Cells("total")?.Value IsNot Nothing) Then
                lblTotalServicio.Text = "Servicio: " + FormatCurrency(.Cells("total").Value.ToString)
            Else
                lblTotalServicio.Text = "Servicio: " + FormatCurrency("0")
            End If

            btnEdit.Text = "Editar: Servicio " & .Cells("servicio").Value
            lblNumeroServicio.Text = .Cells("servicio").Value.ToString
            lblATQ.Text = .Cells("nuevo").Value.ToString & "  -  " & .Cells("anterior").Value.ToString
        End With


    End Sub

    Private Sub frmServicio_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        estructura_ventana(Me)
    End Sub


    Private Sub btnSINCOT_Click(sender As Object, e As EventArgs) Handles btnSINCOT.Click
        Cargar_SINcot()
        cargar_Detalle()
        cargar_info()
    End Sub
    Private Sub Cargar_SINcot()
        tablaAutos.Rows.Clear()
        Dim criterio As String = ""
        Dim c As Integer
        Dim marcar As Boolean
        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Try

            If CBCotizar.Text = "TODOS" Then
                If MsgBox("Mostrar los que tienen Orden de compra?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    '   criterio = "AND OC>0 "
                    consulta = "SELECT * FROM servicios WHERE (cotizar = 'NO' AND factura = ''" & " AND OC<>'') ORDER BY id DESC"
                Else
                    ' criterio = "AND OC=''"

                    consulta = "SELECT * FROM servicios WHERE (cotizar = 'SI' AND numero =0" & ") ORDER BY id DESC"

                End If

            Else
                If MsgBox("Mostrar los que tienen Orden de compra?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    criterio = "AND OC>0 "
                End If
                consulta = "SELECT * FROM servicios WHERE (numero = 0 AND cotizar='" & CBCotizar.Text & "' " & criterio & ")  ORDER BY id DESC"
            End If


            tablaResultado = tool.ObtenerTabla(consulta)

            If tablaResultado.Rows.Count > 0 Then

                For Each xRow As DataRow In tablaResultado.Rows
                    If xRow.Item("cotizar") = "NO" Then
                        marcar = True
                    Else
                        marcar = False
                    End If
                    c += 1
                    tablaAutos.Rows.Add(xRow.Item("id"), xRow.Item("fecha"), xRow.Item("ncamion"), xRow.Item("nuevo"), xRow.Item("anterior"), xRow.Item("marca"), xRow.Item("year"), xRow.Item("estado"), xRow.Item("numero"), xRow.Item("para"), xRow.Item("km"), xRow.Item("oc"), xRow.Item("factura"), xRow.Item("SC"), xRow.Item("cotizar"), xRow.Item("valor"))
                    If marcar Then
                        tablaAutos.Rows(c - 1).Cells("cotizacion").Style.BackColor = Color.Orange
                        tablaAutos.Rows(c - 1).Cells("nuevo").Style.BackColor = Color.Orange
                    End If
                Next

            End If
            lblcount.Text = tablaAutos.Rows.Count

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub tablaAutos_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles tablaAutos.RowHeaderMouseClick

    End Sub

    Private Sub tablaAutos_SelectionChanged(sender As Object, e As EventArgs) Handles tablaAutos.SelectionChanged
        Dim state As String = "TERMINADO"
        lblObserv.Text = ""
        tabladetalle.Rows.Clear()
        tablaRenglon.Rows.Clear()
        

        If tablaAutos.RowCount > 0 Then
            Dim i As Integer = tablaAutos.CurrentRow.Index
            cargar_Detalle()
            cargar_info()
            MostrarInfoEnPanel(i)
            If tabladetalle.RowCount > 0 Then
                
                For a = 0 To tabladetalle.RowCount - 1
                    If state = "TERMINADO" Then
                        If tabladetalle.Rows(a).Cells("inv").Value = 0 Then
                            state = "PENDIENTE"

                            Exit For

                        End If
                    Else
                        state = "TERMINADO"
                    End If
                Next
                ' MsgBox(state)


            End If
        End If
        If tablaAutos.SelectedCells.Count > 0 Then
            Dim i As Integer = tablaAutos.CurrentRow.Index
            lblObserv.Text = tablaAutos.Rows(i).Cells("observacion").Value

        End If

    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub btnPendiente_Click(sender As Object, e As EventArgs) Handles btnPendiente.Click
        Dim continuar As Boolean = False
        If tablaAutos.Rows.Count > 0 Then
            Dim i As Integer = tablaAutos.CurrentRow.Index
            If tablaAutos.Rows(i).Cells("cotizacion").Value = 0 Then
                continuar = True
            Else
                If MsgBox("¿Desea cambiar a pendiente el servicio que tiene cotización ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    continuar = True
                Else
                    continuar = False
                End If
            End If

            If continuar Then

                Try
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    If con.State = ConnectionState.Open Then
                        cmd.Connection = con
                        cmd.CommandText = "UPDATE servicios SET estado='PENDIENTE' WHERE id=" & tablaAutos.Rows(i).Cells("servicio").Value
                        If cmd.ExecuteNonQuery Then
                            tablaAutos.Rows(i).Cells("estado").Value = "PENDIENTE"
                        End If


                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If


        End If
        cargar_Detalle()
    End Sub

    Private Sub Maximos_ValueChanged(sender As Object, e As EventArgs) Handles Maximos.ValueChanged
        'CargarServicios()
    End Sub

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        If tablaAutos.Rows.Count > 0 Then
            frmCotizacion_Detalle.Dispose()
            Dim i As Integer = tablaAutos.CurrentRow.Index
            Dim number As Integer
            With frmCotizacion_Detalle
                consulta = "SELECT numero FROM servicios WHERE id=" & tablaAutos.Rows(i).Cells("servicio").Value
                tablaResultado = tool.ObtenerTabla(consulta)
                If tablaResultado.Rows.Count > 0 Then
                    number = tablaResultado.Rows(0).Item("numero")
                    If IsNumeric(number) And number > 0 Then
                        'es una cotización 

                        .lbltitulo.Text = "COTIZACION"
                        .lbltipo.Text = "COT"
                        .lblCOT.Text = tablaAutos.Rows(i).Cells("cotizacion").Value
                    Else
                        'es servicio
                        .lbltitulo.Text = "SERVICIO"
                        .lbltipo.Text = "SER"
                        .lblCOT.Text = tablaAutos.Rows(i).Cells("servicio").Value
                    End If
                Else
                    Exit Sub

                End If
                .ShowDialog()
                cargar_info()

            End With
        End If
    End Sub

    Private Sub TXTOC_TextChanged(sender As Object, e As EventArgs) Handles TXTOC.TextChanged

    End Sub

    Private Sub CBCotizar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCotizar.SelectedIndexChanged
        'Cargar_SINcot()
        ' CargarServicios()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If tablaAutos.Rows.Count > 0 Then
            Dim punto As Integer = tablaAutos.CurrentRow.Index
            frmServicio_Editar.Dispose()
            If tablaAutos.Rows(punto).Cells("estado").Value = "PENDIENTE" Then

                For i = 0 To MDIPrincipal.MdiChildren.Length - 1

                    Me.WindowState = FormWindowState.Minimized

                Next

                frmServicio_Editar.MdiParent = MDIPrincipal
                frmServicio_Editar.NFolio.Value = tablaAutos.Rows(punto).Cells("servicio").Value
                frmServicio_Editar.Width = ventana_ancho
                frmServicio_Editar.Height = ventana_alto


                frmServicio_Editar.Show()
                tablaAutos.Refresh()
            End If
        End If
    End Sub

    Private Sub btnCOT_Click(sender As Object, e As EventArgs) Handles btnCOT.Click
        If tablaAutos.Rows.Count > 0 Then
            Dim punto As Integer = tablaAutos.CurrentRow.Index
            Try
                If tablaAutos.Rows(punto).Cells("cotizacion").Value.ToString = 0 Then

                    If tablaAutos.Rows(punto).Cells("cotizar").Value = "NO" Then
                        If MsgBox("Este servicio esta como NO COTIZAR, ¿deseas continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                        Else
                            Exit Sub
                        End If
                    End If

                    For i = 0 To MDIPrincipal.MdiChildren.Length - 1

                        Me.WindowState = FormWindowState.Minimized


                    Next
                    frmCotizacionNuevoEdtar.Dispose()
                    frmCotizacionNuevoEdtar.lblservicio.Text = tablaAutos.Rows(punto).Cells("servicio").Value
                    frmCotizacionNuevoEdtar.txtKM.Text = tablaAutos.Rows(punto).Cells("km").Value
                    frmCotizacionNuevoEdtar.txtObservacion.Text = tablaAutos.Rows(punto).Cells("observacion").Value
                    frmCotizacionNuevoEdtar.MdiParent = MDIPrincipal
                    estructura_ventana(frmCotizacionNuevoEdtar)
                    frmCotizacionNuevoEdtar.Show()
                    tablaAutos.Refresh()

                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "crear cotizacion")
            End Try

            If IsNumeric(tablaAutos.Rows(punto).Cells("cotizacion").Value.ToString) And tablaAutos.Rows(punto).Cells("cotizacion").Value > 0 Then
                Try
                    For i = 0 To MDIPrincipal.MdiChildren.Length - 1
                        If MDIPrincipal.MdiChildren(i).Name = "frmServicio" Then
                            Me.WindowState = FormWindowState.Minimized

                        Else
                            MDIPrincipal.MdiChildren(i).Hide()
                        End If
                    Next
                    frmCotizacion_Editar.Dispose()
                    frmCotizacion_Editar.lblservicio.Text = tablaAutos.Rows(punto).Cells("servicio").Value
                    frmCotizacion_Editar.txtKM.Text = tablaAutos.Rows(punto).Cells("km").Value
                    frmCotizacion_Editar.NFolio.Value = tablaAutos.Rows(punto).Cells("cotizacion").Value
                    frmCotizacion_Editar.txtObservacion.Text = tablaAutos.Rows(punto).Cells("observacion").Value
                    frmCotizacion_Editar.lblID.Text = tablaAutos.Rows(punto).Cells("idauto").Value.ToString

                    frmCotizacion_Editar.MdiParent = MDIPrincipal
                    frmCotizacion_Editar.Show()
                    tablaAutos.Refresh()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information, "editar cotizacion")
                End Try



            End If
            cargar_Detalle()
        End If
    End Sub



    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        CargarServicios()
        cargar_Detalle()
    End Sub

    Private Sub botonBuscar(sender As Object, e As KeyEventArgs) Handles txtNumero.KeyDown, txtNuevo.KeyDown, txtMarca.KeyDown, txtEstado.KeyDown, txtAnterior.KeyDown, Maximos.KeyDown, CBCotizar.KeyDown, txtSER.KeyDown, TXTOC.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = False
            btnConsultar.PerformClick()

        End If
    End Sub




    Private Sub Button4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub barra_Scroll(sender As Object, e As EventArgs) Handles barra.Scroll
        Panel4.Width = barra.Value
    End Sub

    Private Sub Mover_Click(sender As Object, e As EventArgs) Handles Mover.Click
        If tablaAutos.MultiSelect = False Then
            tablaAutos.MultiSelect = True
            btnDetalle.Enabled = False
            btnCOT.Enabled = False
            btnEdit.Enabled = False
            Mover.BackColor = Color.YellowGreen
            tablaAutos.SelectionMode = DataGridViewSelectionMode.CellSelect

        Else
            tablaAutos.MultiSelect = False
            btnDetalle.Enabled = True
            btnCOT.Enabled = True
            btnEdit.Enabled = True
            Mover.BackColor = Color.White
            tablaAutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
    End Sub

    Private Sub btnCambiarATQ_Click(sender As Object, e As EventArgs) Handles btnCambiarATQ.Click

        Dim IdAutoCambiar As Integer
        Dim idServicioCambiar As Integer

        If tablaAutos.CurrentRow Is Nothing Then
            Return
        End If
        If tablaAutos.CurrentRow.Index <= -1 Then
            Return
        End If

        If MDIPrincipal.lblUser.Text = "luis" Then
            If tablaAutos.Rows.Count > 0 Then
                Integer.TryParse(tablaAutos.Rows(tablaAutos.CurrentRow.Index).Cells(idauto.Name).Value.ToString, IdAutoCambiar)
                Integer.TryParse(tablaAutos.Rows(tablaAutos.CurrentRow.Index).Cells(servicio.Name).Value.ToString, idServicioCambiar)
            End If



            Dim frmModificarAtq As New frmServicioCambiarAtq(idServicioCambiar, IdAutoCambiar, tablaAutos.Rows(tablaAutos.CurrentRow.Index).Cells(nuevo.Name).Value.ToString)

            frmModificarAtq.ShowDialog()

        End If
    End Sub

    Private Sub tablaAutos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaAutos.CellContentClick

    End Sub
End Class