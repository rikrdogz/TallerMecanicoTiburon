Public Class frmArticulos_aviso

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub frmArticulos_aviso_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub

    Private Sub frmArticulos_aviso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub frmArticulos_aviso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lbl_id_inv_Click(sender As Object, e As EventArgs) Handles lbl_id_inv.Click

    End Sub

    Private Sub lbl_id_inv_TextChanged(sender As Object, e As EventArgs) Handles lbl_id_inv.TextChanged

    End Sub
    Public Sub cargar_relacionados()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If con.State = ConnectionState.Open Then
                cmd.Connection = con
                cmd.CommandText = "SELECT descripcion, precio,mano, marca, modelo, year FROM articulos WHERE id_inv=" & lbl_id_inv.Text
                datos = cmd.ExecuteReader
                If datos.HasRows Then
                    While datos.Read
                        lista_articulos.Items.Add(datos("descripcion") & "  | precio:  " & FormatCurrency(datos("precio")) & "  | mano: " & datos("mano") & "  | marca:  " & datos("marca") & "  | modelo:  " & datos("modelo"))

                    End While
                End If
                If Not datos.IsClosed Then datos.Close()
            End If
        Catch ex As Exception
            If Not datos.IsClosed Then datos.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information, "Buscando articulos relacionados")
        End Try
    End Sub
End Class