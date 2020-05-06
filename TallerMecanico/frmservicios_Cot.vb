Public Class frmservicios_Cot

    Private Sub frmservicios_Cot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
  
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If con.State = ConnectionState.Open Then
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM servicios_cotdetalle"
                datos = cmd.ExecuteReader
                If datos.HasRows Then
                    While datos.Read
                        tabla.Rows.Add(datos("ncotizacion"), datos("camion"), 0, 0)
                    End While
                End If
                datos.Close()
                If tabla.Rows.Count > 0 Then
                    For i = 0 To tabla.Rows.Count - 1
                        cmd.CommandText = "SELECT * FROM servicios WHERE numero=" & tabla.Rows(i).Cells("numero").Value
                        datos = cmd.ExecuteReader
                        If datos.HasRows Then
                            While datos.Read
                                tabla.Rows(i).Cells("camion").Value = datos("ncamion")
                                tabla.Rows(i).Cells("id").Value = datos("id")
                            End While
                        End If
                        datos.Close()
                    Next
                    For i = 0 To tabla.Rows.Count - 1
                        cmd.CommandText = "UPDATE servicios_cotdetalle SET id_servicio=" & tabla.Rows(i).Cells("id").Value & " WHERE ncotizacion=" & tabla.Rows(i).Cells("numero").Value
                        If cmd.ExecuteNonQuery Then
                            If i = tabla.Rows.Count - 1 Then
                                MsgBox("Actualizado")
                            End If
                        End If
                    Next
                End If
            End If

        Catch ex As Exception
            datos.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class