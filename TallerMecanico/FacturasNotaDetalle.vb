Public Class FacturasNotaDetalle

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        tablaFacturas.Rows.Clear()

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If con.State = ConnectionState.Open Then
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM factura WHERE folio = '" & txtfolio.Text & "' AND idproveedor=" & FacturasAgregar.lblid.Text
                datos = cmd.ExecuteReader
                If datos.HasRows Then
                    While datos.Read
                        tablaFacturas.Rows.Add(datos("id"), datos("folio"), datos("total"), datos("estado"), datos("observacion"))
                    End While
                    panelFacturas.Show()
                    txtfolio.Enabled = False
                    tablaFacturas.Focus()
                Else
                    MessageBox.Show("No existe factura con ese folio, verifique el folio", "factura")
                    txtfolio.Focus()
                    txtfolio.Select(0, 1000)
                End If
                datos.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, "fACTURA")
        End Try
    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        If tablaFacturas.Rows.Count > 0 Then
            TablaDetalle.Rows.Clear()
            Dim i As Integer = tablaFacturas.CurrentRow.Index
            lblid.Text = tablaFacturas.Rows(i).Cells("idfac").Value
            lblfolio.Text = tablaFacturas.Rows(i).Cells("folio").Value
      
            btnaceptar.Enabled = False

            Try
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                If con.State = ConnectionState.Open Then
                    cmd.Connection = con
                    cmd.CommandText = "SELECT * FROM facturadetalle WHERE idfactura=" & lblid.Text
                    datos = cmd.ExecuteReader
                    If datos.HasRows Then
                        While datos.Read
                            TablaDetalle.Rows.Add(datos("id"), datos("cant"), datos("np"), datos("descripcion"), datos("costo"), "AGREGAR", datos("tipo"), datos("idnp_inv"))
                        End While
                    End If
                    datos.Close()
                    TablaDetalle.Focus()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "DETALLE")
            End Try
        End If
  
    End Sub

    Private Sub TablaDetalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TablaDetalle.CellContentClick
        If TablaDetalle.Rows.Count > 0 Then
            Dim i As Integer = TablaDetalle.CurrentRow.Index
            Dim tipo As String = ""
            Dim nombreColumna As String = ""
            Dim cunidad As Integer = 1
            nombreColumna = TablaDetalle.Columns.Item(e.ColumnIndex).Name.ToString
            If nombreColumna = "agregar" Then
                With TablaDetalle.Rows(i)
                    cmd.CommandText = "SELECT tipo, descripcion, cant_unidad FROM articulos_inventario WHERE id=" & .Cells("idnp").Value
                    datos = cmd.ExecuteReader
                    If datos.HasRows Then
                        While datos.Read
                            'cunidad = datos("cant_unidad")
                            tipo = datos("tipo")

                        End While
                    End If
                    datos.Close()
                    cmd.CommandText = "SELECT cant_unidad FROM facturadetalle WHERE id=" & .Cells("iddet").Value
                    datos = cmd.ExecuteReader
                    If datos.HasRows Then
                        While datos.Read
                            cunidad = datos("cant_unidad")
                        End While
                    Else
                        MsgBox("No se encontro la cantidad por unidad de " & .Cells("desc").Value)
                        Exit Sub
                    End If
                    If Not datos.IsClosed Then datos.Close()

                    FacturasAgregar.TablaDetalle.Rows.Add(.Cells("cant").Value, .Cells("np").Value, .Cells("desc").Value, -(.Cells("precio").Value), .Cells("tipo").Value, (.Cells("cant").Value * -(.Cells("precio").Value)), "editar", "eliminar", .Cells("idnp").Value, tipo, cunidad, .Cells("iddet").Value)

                    TablaDetalle.Rows.RemoveAt(i)
                    FacturasAgregar.SumarTotales()

                End With

            End If
        End If
    End Sub

    Private Sub txtfolio_KeyDown(sender As Object, e As KeyEventArgs) Handles txtfolio.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            btnBuscar.PerformClick()

        End If
    End Sub

    Private Sub txtfolio_TextChanged(sender As Object, e As EventArgs) Handles txtfolio.TextChanged

    End Sub

    Private Sub btnListo_Click(sender As Object, e As EventArgs) Handles btnListo.Click
        If FacturasAgregar.TablaDetalle.Rows.Count > 0 Then

            FacturasAgregar.lblfoliofac.Text = lblfolio.Text
            FacturasAgregar.lblIdRelacion.Text = lblid.Text
            FacturasAgregar.txtObservacion.Text = tablaFacturas.Rows(tablaFacturas.CurrentRow.Index).Cells("observ").Value & " CANCELACION"
            Me.Close()
        End If


    End Sub

    Private Sub tablaFacturas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaFacturas.CellContentClick

    End Sub

    Private Sub tablaFacturas_KeyDown(sender As Object, e As KeyEventArgs) Handles tablaFacturas.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            btnaceptar.PerformClick()

        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        txtfolio.Enabled = False
        tablaFacturas.Rows.Clear()
        TablaDetalle.Rows.Clear()
        btnaceptar.Enabled = True
        Me.Close()
        FacturasAgregar.Close()


    End Sub

    Private Sub FacturasNotaDetalle_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If FacturasAgregar.TablaDetalle.Rows.Count = 0 Then
            FacturasAgregar.Close()

        End If
    End Sub

    Private Sub FacturasNotaDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class