Public Class frmAutosAgregar

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim continuar As Boolean = False
        If txtNuevoATQ.TextLength > 0 Then
            Try
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                If con.State = ConnectionState.Open Then
                    cmd.Connection = con
                    cmd.CommandText = "SELECT * FROM autos WHERE nuevo='" & txtNuevoATQ.Text & "'"
                    datos = cmd.ExecuteReader
                    If datos.HasRows Then
                        While datos.Read
                            MsgBox("Existe un camion con este numero de ATQ " & datos("nuevo") & " - " & datos("anterior") & " - " & datos("marca"), MsgBoxStyle.Information)
                            continuar = False
                        End While
                   
                    Else
                        continuar = True
                    End If
                    datos.Close()
                    If continuar = False Then
                        If MsgBox("¿deseas continuar, para guardar el camion / auto?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            continuar = True
                        End If
                    End If
                    If continuar Then
                        Dim valores As String = ""
                        valores &= "'" & txtNuevoATQ.Text & "',"
                        valores &= "'" & txtAnteriorRuta.Text & "',"
                        valores &= "'" & CBMarca.Text & "',"
                        valores &= "'" & txtModelo.Text & "',"
                        valores &= "'" & txtserie.Text & "',"
                        valores &= "'" & txtplacas.Text & "',"

                        valores &= "'" & txtAño.Text & "',"
                        valores &= "'" & txtTexto.Text & "'"
                        cmd.CommandText = "INSERT INTO autos (nuevo, anterior,marca,modelo,serie,placas,year,texto) VALUES (" & valores & ")"
                        If cmd.ExecuteNonQuery Then
                            MsgBox("listo, guardado")
                            Me.Close()

                        End If

                    End If
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information)
            End Try
        End If
    End Sub

    Private Sub btnCLose_Click(sender As Object, e As EventArgs) Handles btnCLose.Click
        Me.Close()

    End Sub

    Private Sub frmAutosAgregar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub

    Private Sub frmAutosAgregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CBMarca_LostFocus(sender As Object, e As EventArgs) Handles CBMarca.LostFocus
        CBMarca.Text = CBMarca.Text.ToUpper

    End Sub

    Private Sub CBMarca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBMarca.SelectedIndexChanged

    End Sub
End Class