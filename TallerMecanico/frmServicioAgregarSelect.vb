Public Class frmServicioAgregarSelect
    Public editar_renglon As Boolean = False
    Private Sub frmServicioAgregarSelect_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If ventana.Text = "EDITAR" Then
            'frmServicio_Editar.seleccionar_ultimo()

        End If
    End Sub

    Private Sub frmServicioAgregarSelect_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub


    Private Sub frmServicioAgregarSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.StartPosition = FormStartPosition.Manual
        Me.Top = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height - (Me.Height + 50)
        Me.Left = 0
        txtMarca.Text = txtInfoMarca.Text

        CargarArticulos()
    End Sub
    Private Sub CargarArticulos()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultados As New DataTable

        If txtNP.TextLength > 0 Or txtdesc.TextLength > 0 Then
            Try
                If txtNP.TextLength > 0 And txtdesc.TextLength = 0 Then

                    consulta = "SELECT art.id,art.np,art.descripcion,art.marca,art.modelo,art.year,art.tipo,art.id_inv,art.costo,art.mano,art.precio,art.activo,inv.cantidad FROM articulos art inner join articulos_inventario inv on (inv.id=art.id_inv AND (art.np LIKE '%" & txtNP.Text & "%') AND (art.marca LIKE '%" & txtMarca.Text & "%' AND (art.modelo LIKE '%" & txtmodelo.Text & "%' OR art.modelo='') AND (art.year LIKE '%" & txtAño.Text & "%' or art.year =''))) AND inv.activo='SI'"
                End If
                If txtdesc.TextLength > 0 And txtNP.TextLength = 0 Then

                    consulta = "SELECT art.id,art.np,art.descripcion,art.marca,art.modelo,art.year,art.tipo,art.id_inv,art.costo,art.mano,art.precio,art.activo,inv.cantidad FROM articulos art inner join articulos_inventario inv on (inv.id=art.id_inv AND (art.descripcion LIKE '%" & txtdesc.Text & "%') AND (art.marca LIKE '%" & txtMarca.Text & "%' AND (art.modelo LIKE '%" & txtmodelo.Text & "%' OR art.modelo='') AND (art.year LIKE '%" & txtAño.Text & "%' or art.year =''))) AND inv.activo='SI'"
                End If
                If txtNP.TextLength > 0 And txtdesc.TextLength > 0 Then
                    consulta = "SELECT art.id,art.np,art.descripcion,art.marca,art.modelo,art.year,art.tipo,art.id_inv,art.costo,art.mano,art.precio,art.activo,inv.cantidad FROM articulos art inner join articulos_inventario inv on (inv.id=art.id_inv AND (art.np LIKE '%" & txtNP.Text & "%' AND art.descripcion LIKE '%" & txtdesc.Text & "%') AND (art.marca LIKE '%" & txtMarca.Text & "%' AND (art.modelo LIKE '%" & txtmodelo.Text & "%' OR art.modelo='') AND (art.year LIKE '%" & txtAño.Text & "%' or art.year =''))) AND inv.activo='SI'"
                End If

                tablaArticulos.Rows.Clear()

                tablaResultados = tool.ObtenerTabla(consulta)

                If tablaResultados.Rows.Count > 0 Then
                    For Each xRow As DataRow In tablaResultados.Rows
                        tablaArticulos.Rows.Add(xRow.Item("id"), xRow.Item("np"), xRow.Item("descripcion"), xRow.Item("marca"), xRow.Item("modelo"), xRow.Item("year"), xRow.Item("tipo"), xRow.Item("id_inv"), xRow.Item("costo"), xRow.Item("mano"), xRow.Item("precio"), xRow.Item("cantidad"))
                    Next
                End If
        lblarticulos.Text = tablaArticulos.Rows.Count
            Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Articulos")
        End Try
        End If

    End Sub

    Private Sub txtAño_TextAlignChanged(sender As Object, e As EventArgs) Handles txtAño.TextAlignChanged

    End Sub

    Private Sub BUSCAR(sender As Object, e As EventArgs) Handles txtNP.TextChanged, txtmodelo.TextChanged, txtMarca.TextChanged, txtdesc.TextChanged, txtAño.TextChanged
        CargarArticulos()
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        editar_renglon = True

        AgregarALista()
    End Sub
    Private Sub AgregarALista()
        If tablaArticulos.Rows.Count > 0 Then
            Dim i As Integer = tablaArticulos.CurrentRow.Index

            With tablaArticulos.Rows(i)


                If ventana.Text = "AGREGAR" Then
                    frmServicio_Agregar.TablaPiezas.Rows.Add(.Cells("id").Value, NCantidad.Value, .Cells("np").Value, .Cells("tipo").Value, .Cells("desc").Value, .Cells("id_inv").Value, .Cells("costo").Value, .Cells("precio").Value, .Cells("mano").Value, 0, 0, "REAL")
                End If
                If ventana.Text = "EDITAR" Then
                    frmServicio_Editar.TablaPiezas.Rows.Add(0, .Cells("id").Value, .Cells("np").Value, .Cells("tipo").Value, .Cells("desc").Value, NCantidad.Value, .Cells("id_inv").Value, .Cells("costo").Value, .Cells("precio").Value, .Cells("mano").Value, 0, "REAL")
                End If
                If ventana.Text = "COTIZAR" Then
                    frmCotizacionNuevoEdtar.TablaPiezas.Rows.Add(.Cells("id").Value, .Cells("np").Value, .Cells("tipo").Value, NCantidad.Value, .Cells("desc").Value, .Cells("costo").Value, .Cells("precio").Value, .Cells("mano").Value, 0, 0, "AGREGADO (*)")
                End If
                If ventana.Text = "EDIT_COT" Then
                    frmCotizacion_Editar.TablaPiezas.Rows.Add(0, .Cells("id").Value, .Cells("np").Value, NCantidad.Value, .Cells("desc").Value, .Cells("costo").Value, .Cells("precio").Value, .Cells("mano").Value, 0, 0, "AGREGADO (*)")
                End If
             

            End With
            Me.Close()


        End If
    End Sub
    Private Sub SIN_INV()
        If tablaArticulos.Rows.Count > 0 Then
            Dim i As Integer = tablaArticulos.CurrentRow.Index

            With tablaArticulos.Rows(i)


                If ventana.Text = "AGREGAR" Then
                    frmServicio_Agregar.TablaPiezas.Rows.Add(.Cells("id").Value, NCantidad.Value, .Cells("np").Value, .Cells("tipo").Value, .Cells("desc").Value, 0, .Cells("costo").Value, .Cells("precio").Value, .Cells("mano").Value, 0, 0, "REAL")
                End If
                If ventana.Text = "EDITAR" Then
                    frmServicio_Editar.TablaPiezas.Rows.Add(0, .Cells("id").Value, .Cells("np").Value, .Cells("tipo").Value, .Cells("desc").Value, NCantidad.Value, 0, .Cells("costo").Value, .Cells("precio").Value, .Cells("mano").Value, 0, "REAL")

                End If



            End With
            Me.Close()


        End If
    End Sub

    Private Sub NCantidad_GotFocus(sender As Object, e As EventArgs) Handles NCantidad.GotFocus
        NCantidad.Select(0, 100000)

    End Sub

    Private Sub NCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NCantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            If NCantidad.Value > 0 Then
                btnSeleccionar.Focus()

            End If
        End If
    End Sub

    Private Sub NCantidad_ValueChanged(sender As Object, e As EventArgs) Handles NCantidad.ValueChanged

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub tablaArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaArticulos.CellContentClick

    End Sub

    Private Sub tablaArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles tablaArticulos.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            NCantidad.Focus()

        End If
    End Sub

    Private Sub txtNP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNP.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            NCantidad.Focus()

        End If
    End Sub

    Private Sub txtdesc_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            NCantidad.Focus()

        End If
    End Sub

  

    Private Sub frmServicioAgregarSelect_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If lbltipo.Text = "SERVICIO" Then
            txtdesc.Focus()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMano.Click
        If tablaArticulos.Rows.Count > 0 Then
            Dim i As Integer = tablaArticulos.CurrentRow.Index
            Dim TEXTO As String


            With tablaArticulos.Rows(i)
                TEXTO = .Cells("desc").Value
                TEXTO = Replace(TEXTO, "Y M/O", "")
                TEXTO = Replace(TEXTO, "y m/o", "")
                TEXTO = "M/O DE " & TEXTO
                frmServicio_Editar.TablaPiezas.Rows.Add(0, 0, 0, .Cells("tipo").Value, TEXTO, NCantidad.Value, 0, 0, 0, .Cells("mano").Value)
            End With
            Me.Close()

        End If
    End Sub

    Private Sub txtdesc_KeyPress_1(sender As Object, e As KeyPressEventArgs) Handles txtdesc.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            NCantidad.Focus()

        End If

    End Sub

    Private Sub txtMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMarca.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            NCantidad.Focus()

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSININV.Click
        editar_renglon = True

        SIN_INV()

    End Sub

    Private Sub cambio_1(sender As Object, e As EventArgs) Handles btnSININV.Enter, btnMano.Enter, btnSeleccionar.Enter
        sender.BackColor = Color.Yellow

    End Sub

    Private Sub btnSeleccionar_GotFocus(sender As Object, e As EventArgs) Handles btnSeleccionar.GotFocus
        btnSeleccionar.ForeColor = Color.White
        btnSeleccionar.BackColor = Color.Black


    End Sub

    Private Sub cambio_2(sender As Object, e As EventArgs) Handles btnSININV.Leave, btnMano.Leave, btnSeleccionar.Leave
        sender.BackColor = Color.White

    End Sub

    Private Sub BAJAR(sender As Object, e As KeyEventArgs) Handles txtNP.KeyDown, txtmodelo.KeyDown, txtMarca.KeyDown, txtdesc.KeyDown
        If e.KeyCode = Keys.Down Then
            e.Handled = True

            tablaArticulos.Focus()

        End If
    End Sub

    Private Sub btnSeleccionar_LostFocus(sender As Object, e As EventArgs) Handles btnSeleccionar.LostFocus
        btnSeleccionar.ForeColor = Color.White
        btnSeleccionar.BackColor = Color.DarkGreen

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles BtnPendiente.Click
        editar_renglon = True

        If tablaArticulos.Rows.Count > 0 Then
            Dim i As Integer = tablaArticulos.CurrentRow.Index

            With tablaArticulos.Rows(i)


                If ventana.Text = "AGREGAR" Then
                    frmServicio_Agregar.TablaPiezas.Rows.Add(.Cells("id").Value, NCantidad.Value, .Cells("np").Value, .Cells("tipo").Value, .Cells("desc").Value, 0, .Cells("costo").Value, .Cells("precio").Value, .Cells("mano").Value, 0, 0, "PENDIENTE")
                End If
                If ventana.Text = "EDITAR" Then
                    frmServicio_Editar.TablaPiezas.Rows.Add(0, .Cells("id").Value, .Cells("np").Value, .Cells("tipo").Value, .Cells("desc").Value, NCantidad.Value, 0, .Cells("costo").Value, .Cells("precio").Value, .Cells("mano").Value, 0, "PENDIENTE")

                End If



            End With
            Me.Close()


        End If
    End Sub


    Private Sub BtnPendiente_GotFocus(sender As Object, e As EventArgs) Handles BtnPendiente.GotFocus
        BtnPendiente.ForeColor = Color.Black
        BtnPendiente.BackColor = Color.Yellow

    End Sub

    Private Sub BtnPendiente_LostFocus(sender As Object, e As EventArgs) Handles BtnPendiente.LostFocus
        BtnPendiente.ForeColor = Color.Black
        BtnPendiente.BackColor = Color.White
    End Sub
End Class