Public Class frmInventario_detalle

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            cmd.CommandText = "UPDATE articulos_inventario SET preguntar='" & cbPreguntar.Text & "' WHERE id =" & frmInventario.idinventario
            If cmd.ExecuteNonQuery Then
                MsgBox("Guardado", MsgBoxStyle.Information)
                frmInventario.CargarInfoUno()
                Me.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub frmInventario_detalle_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Dispose()

        End If
    End Sub

    Private Sub frmInventario_detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class