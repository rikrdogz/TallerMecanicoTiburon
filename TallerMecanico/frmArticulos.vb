Public Class frmArticulos

    Private Sub frmArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If MsgBox("¿Deseas Cerrar esta Ventana", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub frmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estructura_ventana(Me)
        Tamaño.Maximum = Me.Width - 20
        Tamaño.Minimum = 20

        Tamaño.Value = Panel_articulo.Width

        'CargarArticulos() se omite para rapidez
    End Sub
    Private Sub CargarArticulos()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        tablaArticulos.Rows.Clear()
        tabla_compras.Rows.Clear()
        panelInfo.Hide()

        Try

            consulta = "SELECT * FROM articulos WHERE np LIKE '%" & txtNP.Text & "%' AND descripcion LIKE '%" & txtdesc.Text & "%' AND marca LIKE '%" & txtMarca.Text & "%' AND modelo LIKE '%" & txtmodelo.Text & "%' AND year LIKE '%" & txtAño.Text & "%' AND obser like '%" & txtObser.Text & "%' AND activo='SI'"

            tablaResultado = tool.ObtenerTabla(consulta)
            If tablaResultado.Rows.Count > 0 Then
                For Each xRow As DataRow In tablaResultado.Rows
                    tablaArticulos.Rows.Add(xRow.Item("id"), xRow.Item("np"), xRow.Item("descripcion"), xRow.Item("precio"), xRow.Item("costo"), xRow.Item("obser"), xRow.Item("minimo"), xRow.Item("mano"), (xRow.Item("mano") + xRow.Item("precio")), xRow.Item("marca"), xRow.Item("modelo"), xRow.Item("year"), xRow.Item("id_inv"), xRow.Item("ubicacion"))
                Next

            End If

            lblarticulos.Text = tablaArticulos.Rows.Count
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Articulos carga")
        End Try
        cargarInfo()
    End Sub
    Private Sub CargarUnArticulo()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        If tablaArticulos.Rows.Count > 0 Then
            Dim i As Integer = tablaArticulos.CurrentRow.Index

            If i <= -1 Then
                Return
            End If
            Try

                consulta = "SELECT * FROM articulos WHERE id=" & tablaArticulos.Rows(i).Cells("id").Value

                tablaResultado = tool.ObtenerTabla(consulta)
                If tablaResultado.Rows.Count > 0 Then

                    With tablaArticulos.Rows(i)
                        .Cells("id").Value = tablaResultado.Rows(0).Item("id")
                        .Cells("np").Value = tablaResultado.Rows(0).Item("np")
                        .Cells("desc").Value = tablaResultado.Rows(0).Item("descripcion")
                        .Cells("precio").Value = tablaResultado.Rows(0).Item("precio")
                        .Cells("costo").Value = tablaResultado.Rows(0).Item("costo")
                        .Cells("observacion").Value = tablaResultado.Rows(0).Item("obser")
                        .Cells("minimo").Value = tablaResultado.Rows(0).Item("minimo")
                        .Cells("mano").Value = tablaResultado.Rows(0).Item("mano")
                        .Cells("importe").Value = (tablaResultado.Rows(0).Item("mano") + tablaResultado.Rows(0).Item("precio"))
                        .Cells("modelo").Value = tablaResultado.Rows(0).Item("modelo")
                        .Cells("año").Value = tablaResultado.Rows(0).Item("year")
                        .Cells("ubicacion").Value = tablaResultado.Rows(0).Item("ubicacion")
                    End With
                End If
                lblarticulos.Text = tablaArticulos.Rows.Count
                tablaArticulos.Rows(i).Cells("np").Selected = True
                tablaArticulos.Rows(i).Cells("precio").Selected = True
                tablaArticulos.Rows(i).Cells("costo").Selected = True
                tablaArticulos.Rows(i).Cells("mano").Selected = True
                tablaArticulos.Rows(i).Cells("importe").Selected = True
                tablaArticulos.Rows(i).Cells("marca").Selected = True
                tablaArticulos.Rows(i).Cells("modelo").Selected = True
                tablaArticulos.Rows(i).Cells("año").Selected = True

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Articulos 1")
            End Try
        End If
    End Sub
    Private Sub CargarArticulosDesactivados()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        tablaArticulosDesactivados.Rows.Clear()


        TabDesactivados.Text = "Articulos Desactivados"
        'tabla_compras.Rows.Clear()

        Try

            consulta = "SELECT * FROM articulos WHERE np LIKE '%" & txtNP.Text & "%' AND descripcion LIKE '%" & txtdesc.Text & "%' AND marca LIKE '%" & txtMarca.Text & "%' AND modelo LIKE '%" & txtmodelo.Text & "%' AND year LIKE '%" & txtAño.Text & "%' AND obser like '%" & txtObser.Text & "%' AND activo='NO'"

            tablaResultado = tool.ObtenerTabla(consulta)
            If tablaResultado.Rows.Count > 0 Then
                For Each xRow As DataRow In tablaResultado.Rows
                    tablaArticulosDesactivados.Rows.Add(xRow.Item("id"), xRow.Item("np"), xRow.Item("descripcion"), xRow.Item("precio"), xRow.Item("costo"), xRow.Item("obser"), xRow.Item("minimo"), xRow.Item("mano"), (xRow.Item("mano") + xRow.Item("precio")), xRow.Item("marca"), xRow.Item("modelo"), xRow.Item("year"), xRow.Item("id_inv"), xRow.Item("ubicacion"))
                Next

            End If

            TabDesactivados.Text = "Articulos Desactivados (" & tablaArticulosDesactivados.Rows.Count & ")"
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Articulos carga")
        End Try

    End Sub

    Private Sub txtAño_KeyPress(sender As Object, e As KeyPressEventArgs)

    End Sub


    Private Sub buscar(sender As Object, e As EventArgs) Handles txtNP.TextChanged, txtmodelo.TextChanged, txtMarca.TextChanged, txtdesc.TextChanged, txtAño.TextChanged
        '--- se quitara busqueda para mejorar performance
        '--- 24 enero 
        ' CargarArticulos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        txtNP.Clear()
        txtAño.Clear()
        txtdesc.Clear()
        txtMarca.Clear()
        txtmodelo.Clear()

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        If tablaArticulos.Rows.Count > 0 Then
            Dim i As Integer = tablaArticulos.CurrentRow.Index
            frmArticulosEditar.Dispose()
            frmArticulosEditar.lblid.Text = tablaArticulos.Rows(i).Cells("id").Value
            frmArticulosEditar.ShowDialog()
            If frmArticulosEditar.guardado Then
                CargarUnArticulo()
            End If
            'CargarArticulos()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub tablaArticulos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaArticulos.CellClick

    End Sub

    Private Sub tablaArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaArticulos.CellContentClick

    End Sub


    Private Sub txtNP_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            If tablaArticulos.Rows.Count > 0 Then
                Dim i As Integer = tablaArticulos.CurrentRow.Index
                btnEditar.PerformClick()

            End If
        End If
    End Sub

    Private Sub txtObser_TextChanged(sender As Object, e As EventArgs) Handles txtObser.TextChanged
        CargarArticulos()
    End Sub

    Private Sub Tamaño_Scroll(sender As Object, e As EventArgs) Handles Tamaño.Scroll

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel_articulo.Width = Tamaño.Value

    End Sub

    Private Sub frmArticulos_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        estructura_ventana(Me)
    End Sub

    Private Sub frmArticulos_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        estructura_ventana(Me)
    End Sub

    Private Sub tablaArticulos_SelectionChanged(sender As Object, e As EventArgs) Handles tablaArticulos.SelectionChanged
        tabla_compras.Rows.Clear()
        If tablaArticulos.Rows.Count > 0 Then
            cargarInfo()
        Else

        End If
        lblObserv.Text = ""
        If tablaArticulos.SelectedCells.Count >= 1 Then
            Dim i As Integer = tablaArticulos.CurrentRow.Index
            lblObserv.Text = tablaArticulos.Rows(i).Cells("observacion").Value
            lblUbicacion.Text = tablaArticulos.Rows(i).Cells("ubicacion").Value
        End If

    End Sub
    Private Sub cargarInfo()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        If tablaArticulos.Rows.Count > 0 Then
            Dim i As Integer = tablaArticulos.CurrentRow.Index

            If i <= -1 Then
                Return
            End If
            Try

                consulta = "SELECT id,descripcion,cantidad from articulos_inventario where np='" & tablaArticulos.Rows(i).Cells("np").Value & "'"

                tablaResultado = tool.ObtenerTabla(consulta)
                If tablaResultado.Rows.Count Then

                    lbldesc.Text = tablaResultado.Rows(0).Item("descripcion")
                    lblCant_Inv.Text = tablaResultado.Rows(0).Item("cantidad")
                    panelInfo.Show()
                Else
                    panelInfo.Hide()

                    lbldesc.Text = ""
                    lblCant_Inv.Text = ""
                End If
                CARGAR_COMPRAS(i)
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Info fac detalle")
            End Try
        End If

    End Sub
    Private Sub CARGAR_COMPRAS(I As Integer)

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

            tabla_compras.Rows.Clear()
        consulta = "select * from facturadetalle WHERE idnp_inv='" & tablaArticulos.Rows(I).Cells("id_inv").Value & "' order by fecha DESC, id DESC LIMIT " & Nultimas.Value
        tablaResultado = tool.ObtenerTabla(consulta)
        If tablaResultado.Rows.Count > 0 Then
            For Each xRow As DataRow In tablaResultado.Rows
                tabla_compras.Rows.Add(xRow.Item("fecha"), xRow.Item("proveedor"), (xRow.Item("costo") + (xRow.Item("iva") * 100)), xRow.Item("cant"), xRow.Item("folio"))
            Next

        End If

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tabla_compras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_compras.CellContentClick

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Nultimas_ValueChanged(sender As Object, e As EventArgs) Handles Nultimas.ValueChanged
        If tablaArticulos.SelectedCells.Count >= 1 Then
            Dim i As Integer = tablaArticulos.CurrentRow.Index
            CARGAR_COMPRAS(i)

        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        CargarArticulos()
        CargarArticulosDesactivados()
    End Sub

    Private Sub buscarPorEnter(sender As Object, e As KeyPressEventArgs) Handles txtObser.KeyPress, txtNP.KeyPress, txtmodelo.KeyPress, txtMarca.KeyPress, txtdesc.KeyPress, txtAño.KeyPress

    End Sub

    Private Sub busquedaPorEnter(sender As Object, e As KeyEventArgs) Handles txtObser.KeyDown, txtNP.KeyDown, txtmodelo.KeyDown, txtMarca.KeyDown, txtdesc.KeyDown, txtAño.KeyDown
        If e.KeyCode = Keys.Enter Then
            CargarArticulos()
            CargarArticulosDesactivados()
        End If
    End Sub
End Class