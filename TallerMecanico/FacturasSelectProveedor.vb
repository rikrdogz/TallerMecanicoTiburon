Public Class FacturasSelectProveedor

    Private Sub FacturasSelectProveedor_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()

        End If
    End Sub

    Private Sub FacturasSelectProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarProveerdores()
    End Sub
    Private Sub cargarProveerdores()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        If txtBusqueda.TextLength > 0 Then
            Try

                consulta = "SELECT id,proveedor, credito, tipo, iva FROM proveedores WHERE proveedor LIKE '%" & txtBusqueda.Text & "%' ORDER BY id"
                tablaResultado = tool.ObtenerTabla(consulta)
                TablaProveedores.Rows.Clear()
                If tablaResultado.Rows.Count > 0 Then
                    For Each xRow As DataRow In tablaResultado.Rows
                        TablaProveedores.Rows.Add(xRow.Item("id"), xRow.Item("proveedor"), xRow.Item("credito"), xRow.Item("tipo"), xRow.Item("iva"))
                    Next

                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If

    End Sub

    Private Sub txtBusqueda_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyDown
        If e.KeyCode = Keys.Down Then
            TablaProveedores.Focus()

        End If
    End Sub

    Private Sub txtBusqueda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBusqueda.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            btnAceptar.PerformClick()

        End If
    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        cargarProveerdores()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If TablaProveedores.Rows.Count > 0 Then
            Dim i As Integer = TablaProveedores.CurrentRow.Index
            'MDIPrincipal.CerrarVentanas()
            FacturasAgregar.Dispose()

            Me.Close()
            FacturasAgregar.vIva = CDec(TablaProveedores.Rows(i).Cells("iva").Value.ToString)
            FacturasAgregar.lblid.Text = TablaProveedores.Rows(i).Cells("id").Value.ToString
            FacturasAgregar.lblProveedor.Text = TablaProveedores.Rows(i).Cells("proveedor").Value.ToString
            FacturasAgregar.lblClave.Text = TablaProveedores.Rows(i).Cells("clave").Value.ToString

            Me.Close()

             For Each Todaventana As Form In Me.MdiChildren
                Todaventana.Close()
            Next
            FacturasAgregar.MdiParent = MDIPrincipal
            If lblVentana.Text = "NOTA" Then
                FacturasAgregar.NCosto.Minimum = -10000000000
                FacturasAgregar.NCosto.Maximum = 0
                FacturasAgregar.lblTitulo.Text = "Agregando Nota Cred."
                FacturasAgregar.tiempoNota.Start()

            End If
            FacturasAgregar.Show()
            FacturasAgregar.WindowState = FormWindowState.Normal
            FacturasAgregar.MaximizeBox = False
            ' FacturasAgregar.Width = MDIPrincipal.Width
            ' FacturasAgregar.Height = MDIPrincipal.Height - 88
        End If

    End Sub

    Private Sub TablaProveedores_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaProveedores.CellClick

    End Sub

    Private Sub TablaProveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaProveedores.CellContentClick

    End Sub

    Private Sub TablaProveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaProveedores.CellDoubleClick
        btnAceptar.PerformClick()
    End Sub

    Private Sub TablaProveedores_KeyDown(sender As Object, e As KeyEventArgs) Handles TablaProveedores.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.PerformClick()

        End If
    End Sub
End Class