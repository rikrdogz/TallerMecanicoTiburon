Public Class frmFacturasBuscarNP

    Private Sub frmFacturasBuscarNP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estructura_ventana(Me)

    End Sub
    Private Sub cargarNP()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultados As New DataTable

        TablaDetalle.Rows.Clear()

        Try

            consulta = "SELECT * FROM facturadetalle WHERE np LIKE '%" & txtNP.Text & "%' AND descripcion LIKE '%" & txtdesc.Text & "%' AND proveedor LIKE '%" & txtproveedor.Text & "%' AND observacion LIKE '%" & txtObserv.Text & "%'"
            tablaResultados = tool.ObtenerTabla(consulta)


            If tablaResultados.Rows.Count > 0 Then
                For Each xRow As DataRow In tablaResultados.Rows
                    TablaDetalle.Rows.Add(xRow.Item("cant"), xRow.Item("np"), xRow.Item("descripcion"), xRow.Item("costo"), (xRow.Item("costo") * 1.16), xRow.Item("folio"), xRow.Item("proveedor"), xRow.Item("fecha"), xRow.Item("idfactura"), xRow.Item("observacion"), xRow.Item("idnp_inv"))
                Next

            Else
                tablaFactura.Rows.Clear()
            End If
            CargarDetalle()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub buscar(sender As Object, e As EventArgs) Handles txtproveedor.TextChanged, txtNP.TextChanged, txtdesc.TextChanged, txtObserv.TextChanged


    End Sub

    Private Sub TablaDetalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaDetalle.CellClick
        CargarDetalle()
    End Sub

    Private Sub TablaDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaDetalle.CellContentClick

    End Sub
    Private Sub CargarDetalle()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultados As New DataTable

        If TablaDetalle.Rows.Count > 0 Then
            Dim i As Integer = TablaDetalle.CurrentRow.Index

            If i <= -1 Then
                Return
            End If
            Try

                consulta = "SELECT * FROM facturadetalle WHERE idfactura =" & TablaDetalle.Rows(i).Cells("idfactura").Value
                tablaFactura.Rows.Clear()
                tablaResultados = tool.ObtenerTabla(consulta)
                If tablaResultados.Rows.Count > 0 Then
                    For Each xRow As DataRow In tablaResultados.Rows
                        tablaFactura.Rows.Add(xRow.Item("cant"), xRow.Item("np"), xRow.Item("descripcion"), xRow.Item("costo"))
                    Next
  
                Else
                    tablaFactura.Rows.Clear()
                End If

                lbldetalle.Text = tablaFactura.Rows.Count

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub


    Private Sub buscarConEnter(sender As Object, e As KeyEventArgs) Handles txtObserv.KeyDown, txtdesc.KeyDown, txtNP.KeyDown, txtproveedor.KeyDown
        If e.KeyCode = Keys.Enter Then

            cargarNP()

        End If
    End Sub
End Class