Public Class frmAutosEditar

    Private Sub btnCLose_Click(sender As Object, e As EventArgs) Handles btnCLose.Click
        Me.Close()

    End Sub

    Private Sub frmAutosEditar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()

        End If
    End Sub

    Private Sub frmAutosEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtNuevoATQ.TextLength > 0 Then
            If txtAnteriorRuta.TextLength > 0 Then
                Try
                    If con.State = ConnectionState.Closed Then
                        con.Open()
                    End If
                    If con.State = ConnectionState.Open Then
                        cmd.Connection = con
                        cmd.CommandText = "UPDATE autos SET anterior='" & txtAnteriorRuta.Text & "', nuevo='" & txtNuevoATQ.Text & "'," _
                            & "marca='" & txtMarca.Text & "',modelo='" & txtModelo.Text & "', serie='" & txtserie.Text & "', placas='" & txtplacas.Text & "', texto='" & txtTexto.Text & "', year='" & txtAño.Text & "', Activo = '" & IIf(CheckActivo.Checked, 1, 0) & "' WHERE id=" & lblID.Text
                        If cmd.ExecuteNonQuery Then
                            MsgBox("Actualizado", MsgBoxStyle.Information)
                            Me.Close()
                        End If
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information)
                End Try
            End If
        End If
    End Sub
End Class