Public Class frmCotizacion
    Public ventana As String = ""
    Private xBuscarCotizaciones As Boolean = False
    Dim xTiempoBusqueda As Integer = 0
    Private Sub frmCotizacion_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            e.Handled = True
            Me.Close()
        End If
    End Sub

    Private Sub frmCotizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estructura_ventana(Me)
        Tamaño.Maximum = Me.Width - 20
        Tamaño.Minimum = 20

        Tamaño.Value = CotizacionesPanel.Width

        cargar_facturas()
        cargar_detalle()
    End Sub
    Public Sub cargar_facturas()
        Me.Cursor = Cursors.AppStarting
        tablaCOT.Rows.Clear()
        GridDetalle.Rows.Clear()
        Dim suma As Decimal = 0

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Try

            consulta = "Select * from servicios where numero like '%" & txtCOT.Text & "%' AND OC like '%" & txtOC.Text.ToString & "%' AND factura like '%" & txtFac.Text & "%' AND sc like '%" & txtsc.Text & "%'order by numero desc LIMIT " & maximo.Value
            'MsgBox("Select * from servicios where numero like '%" & txtCOT.Text & "%' AND OC like '%" & txtOC.Text.ToString & "%' AND factura like '%" & txtFac.Text & "%' order by numero desc LIMIT " & maximo.Value)
            tablaResultado = tool.ObtenerTabla(consulta)
            tablaCOT.Rows.Clear()
            If tablaResultado.Rows.Count > 0 Then
                For Each xRow As DataRow In tablaResultado.Rows
                    If IsNumeric(xRow.Item("valor")) Then
                        suma += xRow.Item("valor")
                    Else
                        suma += 0
                    End If

                    'If xRow.Item("cotizar") = "SI" Then
                    '"01/01/0001 12:00:00 a.m."
                    If IsDBNull(xRow.Item("fecha_fac")) Then

                        tablaCOT.Rows.Add(xRow.Item("numero").ToString, xRow.Item("fecha_cot"), xRow.Item("camion"), Val(xRow.Item("valor")), xRow.Item("OC"), xRow.Item("FACTURA"), xRow.Item("SC"), xRow.Item("PAGADO"), xRow.Item("METODO"), (Val(xRow.Item("valor")) / (1 + (CDbl(xRow.Item("iva").ToString)))), "COT", xRow.Item("para"), xRow.Item("ss"), "", xRow.Item("id"))
                    Else
                        If xRow.Item("fecha_fac").ToString = "01/01/0001 12:00:00 a.m." Then
                            tablaCOT.Rows.Add(xRow.Item("numero").ToString, xRow.Item("fecha_cot"), xRow.Item("camion"), Val(xRow.Item("valor")), xRow.Item("OC"), xRow.Item("FACTURA"), xRow.Item("SC"), xRow.Item("PAGADO"), xRow.Item("METODO"), (Val(xRow.Item("valor")) / (1 + (CDbl(xRow.Item("iva").ToString)))), "COT", xRow.Item("para"), xRow.Item("ss"), "", xRow.Item("id"))
                        Else
                            tablaCOT.Rows.Add(xRow.Item("numero").ToString, xRow.Item("fecha_cot"), xRow.Item("camion"), Val(xRow.Item("valor")), xRow.Item("OC"), xRow.Item("FACTURA"), xRow.Item("SC"), xRow.Item("PAGADO"), xRow.Item("METODO"), (Val(xRow.Item("valor")) / (1 + (CDbl(xRow.Item("iva").ToString)))), "COT", xRow.Item("para"), xRow.Item("ss"), FormatDateTime(xRow.Item("fecha_fac"), DateFormat.ShortDate), xRow.Item("id"))
                        End If

                    End If
                Next
                
            End If

            lblcount.Text = tablaCOT.Rows.Count
            lbltotal.Text = FormatCurrency(suma)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "buscar cot ser")

        Finally
            Me.Cursor = Cursors.Default
        End Try
        tablaCOT.Rows.Add()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub BUSCAR(sender As Object, e As EventArgs) Handles txtOC.TextChanged, txtFac.TextChanged, txtCOT.TextChanged, txtsc.TextChanged
        If txtCOT.Focused Then
            txtsc.Clear()
            txtFac.Clear()
            txtOC.Clear()
        End If
        If txtFac.Focused Then
            txtsc.Clear()
            txtOC.Clear()
            txtCOT.Clear()
        End If
        If txtOC.Focused Then
            txtsc.Clear()
            txtCOT.Clear()
            txtFac.Clear()
        End If
        If txtsc.Focused Then
            txtCOT.Clear()
            txtFac.Clear()
            txtOC.Clear()

        End If
        xTiempoBusqueda = 0
        Me.Cursor = Cursors.AppStarting
        TiempoDeEsperaBusqueda.Start()
        tablaCOT.Rows.Clear()
        tablaRenglon.Rows.Clear()
        'cargar_facturas()
        'cargar_detalle()
    End Sub

    Private Sub maximo_ValueChanged(sender As Object, e As EventArgs) Handles maximo.ValueChanged
        cargar_facturas()
    End Sub

    Private Sub btnSinOC_Click(sender As Object, e As EventArgs) Handles btnSinOC.Click

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Dim suma As Decimal = 0
        Try

            consulta = "Select * from servicios where numero >1200 AND OC='' order by numero desc"
            tablaResultado = tool.ObtenerTabla(consulta)
            tablaCOT.Rows.Clear()

            If tablaResultado.Rows.Count > 0 Then
                For Each xRow As DataRow In tablaResultado.Rows
                    suma += xRow.Item("valor")
                    tablaCOT.Rows.Add(xRow.Item("numero"), xRow.Item("fecha_cot"), xRow.Item("camion"), Val(xRow.Item("valor")), xRow.Item("OC"), xRow.Item("FACTURA"), xRow.Item("sc"), xRow.Item("PAGADO"), xRow.Item("METODO"), (Val(xRow.Item("valor")) / (1 + (CDbl(xRow.Item("iva").ToString)))), "COT", xRow.Item("para"), xRow.Item("ss"))
                Next

            End If
            lblcount.Text = tablaCOT.Rows.Count
            lbltotal.Text = FormatCurrency(suma)
        Catch ex As Exception        
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub tablaCOT_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaCOT.CellClick
        cargar_detalle()
    End Sub
    Private Sub cargar_detalle()
        Dim letra As String
        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        tablaRenglon.Rows.Clear()
        GridDetalle.Rows.Clear()
        If tablaCOT.Rows.Count > 0 And tablaCOT.SelectedCells.Count > 0 Then

            Me.Cursor = Cursors.AppStarting

            Try
                Dim i As Integer = tablaCOT.CurrentRow.Index
                If i < 0 Then
                    Return
                End If
                If tablaCOT.Rows(i).Cells("cot").Value > 0 Then
                    txtobser.Text = tablaCOT.Rows(i).Cells("obser").Value
                    txt_texto.Text = "COT" & tablaCOT.Rows(i).Cells("cot").Value & " ATQ " & tablaCOT.Rows(i).Cells("atq").Value
                Else
                    Exit Sub

                End If

                If tablaCOT.Rows(i).Cells("tipo").Value = "SER" Then

                    consulta = "SELECT * FROM servicios_detalle WHERE folio=" & tablaCOT.Rows(i).Cells("cot").Value
                    tablaResultado = tool.ObtenerTabla(consulta)

                    tablaRenglon.Rows.Clear()

                    If tablaResultado.Rows.Count > 0 Then

                        For Each xRow As DataRow In tablaResultado.Rows
                            tablaRenglon.Rows.Add(xRow.Item("cant"), xRow.Item("np"), xRow.Item("descripcion"), xRow.Item("precio"))
                        Next

                    End If
                Else
                    consulta = "SELECT * FROM servicios_cotdetalle WHERE ncotizacion=" & tablaCOT.Rows(i).Cells("cot").Value
                    tablaResultado = tool.ObtenerTabla(consulta)

                    tablaRenglon.Rows.Clear()
                    If tablaResultado.Rows.Count > 0 Then
                        For Each xRow As DataRow In tablaResultado.Rows
                            letra = xRow.Item("tipo").ToString.Chars(0)
                            tablaRenglon.Rows.Add(xRow.Item("cantidad"), xRow.Item("np"), xRow.Item("descripcion"), xRow.Item("precio"), letra)
                        Next
                        
                    End If
                End If
                If tablaCOT.Rows(i).Cells(ColIdServicio.Name).Value IsNot Nothing AndAlso tablaCOT.Rows(i).Cells(ColIdServicio.Name).Value.ToString.Length > 0 Then
                    consulta = "SELECT * FROM servicios_detalle WHERE folio=" & tablaCOT.Rows(i).Cells(ColIdServicio.Name).Value
                    tablaResultado = tool.ObtenerTabla(consulta)
                    If tablaResultado.Rows.Count > 0 Then
                        For Each xRow As DataRow In tablaResultado.Rows
                            GridDetalle.Rows.Add(xRow.Item("cant"), xRow.Item("np"), xRow.Item("descripcion"), xRow.Item("precio"), xRow.Item("MARCADO"))
                        Next

                    End If
                End If
                
                lblser.Text = "Servicios COTIZADO " & tablaCOT.Rows(i).Cells("tipo").Value
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try

            Me.Cursor = Cursors.Default

        End If
    End Sub

    Private Sub tablaCOT_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaCOT.CellContentClick

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles CotizacionesPanel.Paint

    End Sub

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        If tablaCOT.Rows.Count > 0 Then
            frmCotizacion_Detalle.Dispose()
            ventana = "cot"
            Dim i As Integer
            If tablaCOT.CurrentRow IsNot Nothing Then
                i = tablaCOT.CurrentRow.Index
            Else
                Return
            End If

            If tablaCOT.Rows(i).Cells("cot").Value Is Nothing Then
                MessageBox.Show(Me, "El renglon seleccionado no tiene numero de cotización", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return

            End If
            frmCotizacion_Detalle.txtOC.Text = tablaCOT.Rows(i).Cells("OC").Value
            frmCotizacion_Detalle.txtFactura.Text = tablaCOT.Rows(i).Cells("factura").Value

            frmCotizacion_Detalle.txtSC.Text = tablaCOT.Rows(i).Cells("SC").Value
            frmCotizacion_Detalle.NPagado.Value = tablaCOT.Rows(i).Cells("pagado").Value
            frmCotizacion_Detalle.ntotal.Value = Val(tablaCOT.Rows(i).Cells("total").Value)
            frmCotizacion_Detalle.CBMetodo.Text = tablaCOT.Rows(i).Cells("metodo").Value.ToString
            With frmCotizacion_Detalle
                If tablaCOT.Rows(i).Cells("tipo").Value = "COT" Then
                    'es una cotización 

                    .lbltitulo.Text = "COTIZACION"
                    .lbltipo.Text = "COT"
                    .lblCOT.Text = tablaCOT.Rows(i).Cells("cot").Value
                ElseIf tablaCOT.Rows(i).Cells("tipo").Value = "SER" Then
                    'es servicio
                    .lbltitulo.Text = "SERVICIO"
                    .lbltipo.Text = "SER"
                    .lblCOT.Text = tablaCOT.Rows(i).Cells("cot").Value
                Else
                    MsgBox("Detalle del servicio no encotrado")
                End If
            End With

            frmCotizacion_Detalle.ShowDialog()
            ventana = ""

        End If
    End Sub
    Public Sub actualizar_renglon()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Try
            consulta = "SELECT * FROM servicios WHERE numero=" & tablaCOT.Rows(tablaCOT.CurrentRow.Index).Cells("COT").Value
            tablaResultado = tool.ObtenerTabla(consulta)
            If tablaResultado.Rows.Count > 0 Then
                    With tablaCOT.Rows(tablaCOT.CurrentRow.Index)
                    .Cells("OC").Value = tablaResultado.Rows(0).Item("OC")
                    .Cells("FACTURA").Value = tablaResultado.Rows(0).Item("FACTURA")
                    .Cells("METODO").Value = tablaResultado.Rows(0).Item("METODO")
                    .Cells("sc").Value = tablaResultado.Rows(0).Item("SC")
                    .Cells("pagado").Value = tablaResultado.Rows(0).Item("PAGADO")

                    If Not IsDBNull(tablaResultado.Rows(0).Item("fecha_fac")) Then
                        .Cells("fecha_fac").Value = FormatDateTime(tablaResultado.Rows(0).Item("fecha_fac"), DateFormat.ShortDate)
                    End If
                    End With
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Detalle actualizar")
        End Try
    End Sub

    Private Sub tablaCOT_KeyDown(sender As Object, e As KeyEventArgs) Handles tablaCOT.KeyDown
        If tablaCOT.Rows.Count > 0 Then
            If e.KeyCode = Keys.Enter Then
                e.Handled = True
                btnDetalle.PerformClick()
            End If



        End If
    End Sub

    Private Sub abrir(sender As Object, e As KeyPressEventArgs) Handles txtOC.KeyPress, txtFac.KeyPress, txtCOT.KeyPress, txtsc.KeyPress
        If tablaCOT.Rows.Count > 0 Then
            If Asc(e.KeyChar) = 13 Then
                e.Handled = True
                btnDetalle.PerformClick()
            End If

        End If
    End Sub

    Private Sub btnSinFac_Click(sender As Object, e As EventArgs) Handles btnSinFac.Click
        Dim suma As Decimal = 0
        Dim filtro As String = "NOREALIZADO,pendiente"
        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Try
            consulta = "Select * from servicios where numero >1200 AND OC <>'' AND FACTURA='' AND OC <>'NOREALIZADO' AND OC<>'pendiente' order by numero desc"
            tablaResultado = tool.ObtenerTabla(consulta)
            tablaCOT.Rows.Clear()
            If tablaResultado.Rows.Count > 0 Then

                For Each xRow As DataRow In tablaResultado.Rows
                    suma += xRow.Item("valor")
                    tablaCOT.Rows.Add(xRow.Item("numero"), xRow.Item("fecha"), xRow.Item("camion"), Val(xRow.Item("valor")), xRow.Item("OC"), xRow.Item("FACTURA"), xRow.Item("sc"), xRow.Item("PAGADO"), xRow.Item("METODO"), (Val(xRow.Item("valor")) / (1 + (CDbl(xRow.Item("iva").ToString)))), "COT", xRow.Item("para"), xRow.Item("ss"))
                Next

            End If
            lblcount.Text = tablaCOT.Rows.Count
            lbltotal.Text = FormatCurrency(suma)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim suma As Decimal = 0
        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        If MsgBox("¿Desea ver el reporte de las cotizaciones?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            frmCotizacion_Reporte.Dispose()
            frmCotizacion_Reporte.ShowDialog()


        Else
       
            Try
                If MsgBox("¿Mostrar las Cotizaciones no realizadas?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    consulta = "Select * from servicios where numero >1200 AND FACTURA='' order by numero desc"
                Else
                    consulta = "Select * from servicios where numero >1200 AND FACTURA='' AND OC<>'NOREALIZADO' order by numero desc"
                End If

                tablaResultado = tool.ObtenerTabla(consulta)
                tablaCOT.Rows.Clear()
                If tablaResultado.Rows.Count > 0 Then

                    For Each xRow As DataRow In tablaResultado.Rows
                        suma += xRow.Item("valor")
                        tablaCOT.Rows.Add(xRow.Item("numero"), xRow.Item("fecha"), xRow.Item("camion"), Val(xRow.Item("valor")), xRow.Item("OC"), xRow.Item("FACTURA"), xRow.Item("sc"), xRow.Item("PAGADO"), xRow.Item("METODO"), (Val(xRow.Item("valor")) / (1 + (CDbl(xRow.Item("iva").ToString)))), "COT", xRow.Item("para"), xRow.Item("ss"))
                    Next
                End If
                lblcount.Text = tablaCOT.Rows.Count
                lbltotal.Text = FormatCurrency(suma)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If

    End Sub
    Private Sub buscar_pendientes()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Try
            If tablaCOT.Rows.Count > 0 Then
                For i = 0 To tablaCOT.Rows.Count - 1
                    consulta = "SELECT descripcion FROM servicios_cotdetalle WHERE ncotizacion=" & tablaCOT.Rows(i).Cells("cot").Value & " AND tipo='PENDIENTE'"
                    tablaResultado = tool.ObtenerTabla(consulta)

                    If tablaResultado.Rows.Count > 0 Then
                        tablaCOT.Rows(i).Cells("SC").Value &= tablaResultado.Rows(0).Item("descripcion")

                    End If

                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "Pendientes")
        End Try

    End Sub
    Private Sub btnMenor_Click(sender As Object, e As EventArgs) Handles btnMenor.Click
        Dim suma As Decimal = 0
        Dim diferencia As Decimal = 0
        Dim difString As Decimal = 0
        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable


        Try

            consulta = "Select * from servicios where numero >1200 and PAGADO>0 and (pagado< valor) order by numero desc"
            tablaResultado = tool.ObtenerTabla(consulta)

            tablaCOT.Rows.Clear()
            If tablaResultado.Rows.Count > 0 Then

                For Each xRow As DataRow In tablaResultado.Rows
                    suma += xRow.Item("valor")
                    diferencia = diferencia + (Val(xRow.Item("valor")) - xRow.Item("PAGADO"))
                    difString = (Val(xRow.Item("valor")) - xRow.Item("PAGADO"))

                    tablaCOT.Rows.Add(xRow.Item("numero"), xRow.Item("fecha"), xRow.Item("camion"), Val(xRow.Item("valor")), xRow.Item("OC"), xRow.Item("FACTURA"), xRow.Item("SC"), xRow.Item("PAGADO"), xRow.Item("METODO"), difString, "COT", xRow.Item("para"), xRow.Item("ss"))
                Next

            End If

            lblcount.Text = tablaCOT.Rows.Count
            lbltotal.Text = FormatCurrency(suma)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub


    Private Sub btnMayor_Click(sender As Object, e As EventArgs) Handles btnMayor.Click
        Dim suma As Decimal = 0
        Dim Diferencia As Decimal = 0
        Dim difString As Decimal = 0.2F
        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Try
            consulta = "Select * from servicios where numero >1200 and PAGADO>0 and (pagado> valor) order by numero desc"
            tablaResultado = tool.ObtenerTabla(consulta)
                tablaCOT.Rows.Clear()
            If tablaResultado.Rows.Count > 0 Then
                For Each xRow As DataRow In tablaResultado.Rows
                    suma += xRow.Item("valor")
                    Diferencia = Diferencia + (xRow.Item("PAGADO") - Val(xRow.Item("valor")))
                    difString = (Val(xRow.Item("valor")) - xRow.Item("PAGADO"))
                    tablaCOT.Rows.Add(xRow.Item("numero"), xRow.Item("fecha"), xRow.Item("camion"), Val(xRow.Item("valor")), xRow.Item("OC"), xRow.Item("FACTURA"), xRow.Item("SC"), xRow.Item("PAGADO"), xRow.Item("METODO"), difString, "DIFERENCIA")
                Next
            End If
            MsgBox(FormatCurrency(Diferencia))
            lblcount.Text = tablaCOT.Rows.Count
            lbltotal.Text = FormatCurrency(suma)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Tamaño_Scroll(sender As Object, e As EventArgs) Handles Tamaño.Scroll
        CotizacionesPanel.Width = Tamaño.Value

    End Sub

    Private Sub tablaCOT_SelectionChanged(sender As Object, e As EventArgs) Handles tablaCOT.SelectionChanged

        cargar_detalle()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()

    End Sub

    Private Sub frmCotizacion_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        estructura_ventana(Me)
    End Sub

    Private Sub Mover_Click(sender As Object, e As EventArgs) Handles Mover.Click
        If tablaCOT.SelectionMode = DataGridViewSelectionMode.FullRowSelect Then
            tablaCOT.SelectionMode = DataGridViewSelectionMode.CellSelect
        Else
            tablaCOT.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Clipboard.SetText(txt_texto.Text)
    End Sub

    Private Sub btnMas_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TiempoDeEsperaBusqueda_Tick(sender As Object, e As EventArgs) Handles TiempoDeEsperaBusqueda.Tick
        xTiempoBusqueda = xTiempoBusqueda + 1
        If xTiempoBusqueda = 4 Then
            Me.Cursor = Cursors.WaitCursor
        End If
        If xTiempoBusqueda = 6 Then
            xTiempoBusqueda = 0
            cargar_facturas()
            cargar_detalle()
            TiempoDeEsperaBusqueda.Stop()

        End If
    End Sub

   
    Private Sub btnBusquedaAvanzada_Click(sender As Object, e As EventArgs) Handles btnBusquedaAvanzada.Click

        Me.Cursor = Cursors.AppStarting
        tablaCOT.Rows.Clear()
        GridDetalle.Rows.Clear()
        Dim suma As Decimal = 0

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        Try

            consulta = "Select * from servicios "
            consulta = consulta & " WHERE numero >= " & NDesdeCotizacion.Value
            If CheckSinOc.Checked Then
                consulta = consulta & " AND (OC='' OR OC='pendiente'  )"
            End If
            If CheckConOC.Checked Then
                consulta = consulta & " AND (OC>0 )"
            End If
            If CheckConFactura.Checked Then
                consulta = consulta & " AND (FACTURA<>'' )"
            End If
            If CheckSinFactura.Checked Then
                consulta = consulta & " AND (FACTURA='' )"
            End If
            If CheckConSolC.Checked Then
                consulta = consulta & " AND (SC>0 )"
            End If
            If checkSinSolC.Checked Then
                consulta = consulta & " AND (SC='' )"
            End If
            If CheckMayorA.Checked Then
                consulta = consulta & " AND (valor>" & NMayorA.Value & ")"
            End If


            consulta = consulta & " order by numero desc  "

            tablaResultado = tool.ObtenerTabla(consulta)
            tablaCOT.Rows.Clear()
            If tablaResultado.Rows.Count > 0 Then
                Dim fechaTexto As String = ""
                For Each xRow As DataRow In tablaResultado.Rows

                    If IsNumeric(xRow.Item("valor")) Then
                        suma += xRow.Item("valor")
                    Else
                        suma += 0
                    End If
                    If Not IsDBNull(xRow.Item("fecha_fac")) AndAlso xRow.Item("fecha_fac").ToString = "01/01/0001 12:00:00 a.m." Then
                        fechaTexto = ""
                    Else
                        If IsDBNull(xRow.Item("fecha_fac")) Then
                            fechaTexto = ""
                        Else
                            fechaTexto = xRow.Item("fecha_fac")
                        End If

                    End If

                    If fechaTexto.Length > 0 Then
                        fechaTexto = FormatDateTime(fechaTexto, DateFormat.ShortDate).ToString
                    Else

                    End If

                    tablaCOT.Rows.Add(xRow.Item("numero").ToString, xRow.Item("fecha_cot"), xRow.Item("camion"), Val(xRow.Item("valor")), xRow.Item("OC"), xRow.Item("FACTURA"), xRow.Item("SC"), xRow.Item("PAGADO"), xRow.Item("METODO"), (Val(xRow.Item("valor")) / (1 + (CDbl(xRow.Item("iva").ToString)))), "COT", xRow.Item("para"), xRow.Item("ss"), fechaTexto, xRow.Item("id"))

                Next

            End If

            lblcount.Text = tablaCOT.Rows.Count
            lbltotal.Text = FormatCurrency(suma)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "buscar cot ser")

        Finally
            Me.Cursor = Cursors.Default
        End Try

        Me.Cursor = Cursors.Default

    End Sub
End Class