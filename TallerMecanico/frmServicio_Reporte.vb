Public Class frmServicio_Reporte

    Private Sub frmServicio_Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Sub cargar_pendientes()
        Dim importe As Decimal
        tabla.Rows.Clear()

        Dim a As Integer = 0
        Dim i As Integer = 0
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()

            End If
            If con.State = ConnectionState.Open Then
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM servicios_detalle WHERE MARCADO='PENDIENTE'"
                datos = cmd.ExecuteReader
                If datos.HasRows Then
                    While datos.Read

                        tabla.Rows.Add(datos("id"), datos("cant"), datos("np"), datos("descripcion"), datos("nuevo") & "  -  " & datos("anterior"), datos("id_inv"), datos("precio"), (datos("precio") * datos("cant")), 0, datos("folio"), 0, datos("fecha"))



                    End While
                End If
                datos.Close()
                While Not i = tabla.Rows.Count
                    cmd.CommandText = "SELECT numero,OC,FACTURA FROM servicios WHERE id=" & tabla.Rows(i).Cells("serv").Value & " limit 1"
                    datos = cmd.ExecuteReader
                    If datos.HasRows Then
                        While datos.Read

                  

                            tabla.Rows(i).Cells("cot").Value = datos("numero")
                            tabla.Rows(i).Cells("oc").Value = datos("OC")
                            tabla.Rows(i).Cells("fac").Value = datos("factura")

                        End While
                        i += 1
                    End If
                    datos.Close()
                End While


            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        Dim importe As Decimal

        While a < tabla.Rows.Count

            With tabla.Rows(a)

                If IsNumeric(.Cells("oc").Value.ToString) Then
                    importe += .Cells("precio").Value * .Cells("cant").Value
                    a += 1
                Else

                    tabla.Rows.RemoveAt(a)

                End If
            End With

            lbla.Text = a
        End While
        lbltotal.Text = importe

    End Sub
End Class