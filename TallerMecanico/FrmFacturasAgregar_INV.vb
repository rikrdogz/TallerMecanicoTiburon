Public Class FrmFacturasAgregar_INV
    Public numero_parte As String = ""
    Public id_numero_parte As Integer = 0
    Public ventana As String


    Private Sub FrmFacturasAgregar_INV_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub

    Private Sub FrmFacturasAgregar_INV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If numero_parte.Length > 0 Then
            txtNP.Text = numero_parte

        End If
        CargarArticulos()
    End Sub
    Private Sub CargarArticulos()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If con.State = ConnectionState.Open Then
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM articulos_inventario WHERE np LIKE '%" & txtNP.Text & "%' AND descripcion LIKE '%" & txtdesc.Text & "%' AND tipo <>'' AND activo='SI'"
                tablaArticulos.Rows.Clear()
                datos = cmd.ExecuteReader
                If datos.HasRows Then
                    While datos.Read
                        tablaArticulos.Rows.Add(datos("id"), datos("np"), datos("descripcion"), datos("cantidad"), datos("tipo"))
                    End While
                End If
                datos.Close()
            End If
            lblarticulos.Text = tablaArticulos.Rows.Count
        Catch ex As Exception
            datos.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information, "Articulos")
        End Try
    End Sub

    Private Sub tablaArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaArticulos.CellContentClick

    End Sub

    Private Sub tablaArticulos_KeyDown(sender As Object, e As KeyEventArgs) Handles tablaArticulos.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            Agregar()
        End If
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Agregar()
    End Sub
    Private Sub Agregar()
        If ventana = "factura_inv" Then
            If tablaArticulos.Rows.Count > 0 Then
                Dim i As Integer = tablaArticulos.CurrentRow.Index
                id_numero_parte = tablaArticulos.Rows(i).Cells("id").Value
                numero_parte = tablaArticulos.Rows(i).Cells("np").Value

            End If
        End If
        If tablaArticulos.Rows.Count > 0 Then
            Dim i As Integer = tablaArticulos.CurrentRow.Index

            FacturasAgregar.txtNp.Text = tablaArticulos.Rows(i).Cells("np").Value
            FacturasAgregar.txtDesc.Text = tablaArticulos.Rows(i).Cells("desc").Value
            FacturasAgregar.lblidNp.Text = tablaArticulos.Rows(i).Cells("id").Value
            FacturasAgregar.tipo_a.Text = tablaArticulos.Rows(i).Cells("tipo").Value
            Me.Close()

        End If
    End Sub

    Private Sub txtNP_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNP.KeyDown
        If e.KeyCode = Keys.Down Then
            e.Handled = True
            tablaArticulos.Focus()

        End If
    End Sub

    Private Sub txtNP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNP.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            Agregar()
        End If
    End Sub

    Private Sub txtNP_TextChanged(sender As Object, e As EventArgs) Handles txtNP.TextChanged
        CargarArticulos()
    End Sub

    Private Sub txtdesc_TextChanged(sender As Object, e As EventArgs) Handles txtdesc.TextChanged
        CargarArticulos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class