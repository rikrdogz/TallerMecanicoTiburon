Public Class frmProveedores

    Private Sub frmProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estructura_ventana(Me)
        CargarProveedores()
    End Sub
    Public Sub CargarProveedores()
        tablaProveedores.Rows.Clear()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If con.State = ConnectionState.Open Then
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM proveedores WHERE proveedor like '%" & txtBusqueda.Text & "%' ORDER BY id"
                datos = cmd.ExecuteReader
                tablaProveedores.Rows.Clear()
                If datos.HasRows Then
                    While datos.Read
                        tablaProveedores.Rows.Add(datos("id"), datos("proveedor"), datos("telefono"), datos("tipo"), datos("credito"), datos("iva"))
                    End While
                End If
                datos.Close()
                lblresultados.Text = tablaProveedores.Rows.Count

            End If
        Catch ex As Exception
            datos.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnagregar.Click
        frmProveedorAgregar.Dispose()
        frmProveedorAgregar.ShowDialog()

    End Sub

    Private Sub txtBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBusqueda.TextChanged
        CargarProveedores()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        editar()
    End Sub
    Private Sub editar()
        If tablaProveedores.Rows.Count > 0 Then
            frmProveedor_edit.Dispose()
            Dim i As Integer = tablaProveedores.CurrentRow.Index
            With frmProveedor_edit
                .lblid.Text = tablaProveedores.Rows(i).Cells("id").Value
                .ShowDialog()
            End With
            CargarProveedores()

        End If
    End Sub

    Private Sub tablaProveedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaProveedores.CellContentClick

    End Sub

    Private Sub tablaProveedores_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaProveedores.CellContentDoubleClick

    End Sub

    Private Sub tablaProveedores_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaProveedores.CellDoubleClick
        editar()
    End Sub
End Class