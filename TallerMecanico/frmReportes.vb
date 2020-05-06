Public Class frmReportes

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim suma As Decimal = 0
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()

            End If
            If con.State = ConnectionState.Open Then
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM servicios_cotdetalle WHERE (fecha BETWEEN '" & Format(Finicial.Value, "yyyy/MM/dd") & "' AND '" & Format(FFINAL.Value, "yyyy/MM/dd") & "') AND " & filtroFecha.Text & " ORDER BY fecha"
                               ' InputBox("txt", "titlo", cmd.CommandText)
                datos = cmd.ExecuteReader
                tabladetalle.Rows.Clear()
                If datos.HasRows Then
                    While datos.Read
                        tabladetalle.Rows.Add(datos("numero"), datos("cantidad"), datos("descripcion"), datos("precio"), (datos("precio") * datos("cantidad")), datos("ncotizacion"), datos("fecha"))
                        suma += datos("precio") * datos("cantidad")
                    End While
                Else
                    MsgBox("NO hay datos", MsgBoxStyle.Information)
                End If
                datos.Close()
                If tabladetalle.Rows.Count > 0 Then
                    For i = 0 To tabladetalle.Rows.Count - 1
                        cmd.CommandText = "SELECT FACTURA,OC,PAGADO,METODO FROM servicios WHERE numero=" & tabladetalle.Rows(i).Cells("cot").Value
                        datos = cmd.ExecuteReader
                        If datos.HasRows Then
                            While datos.Read
                                tabladetalle.Rows(i).Cells("tipo").Value = datos("OC") & " " & datos("PAGADO") & " " & datos("METODO")
                                tabladetalle.Rows(i).Cells("fac").Value = datos("FACTURA")

                            End While
                        End If
                        datos.Close()
                    Next
                End If
            End If
            lblcount.Text = tabladetalle.Rows.Count
            lbltotal.Text = FormatCurrency(suma)
        Catch ex As Exception
            'datos.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub frmReportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estructura_ventana(Me)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Mover_Click(sender As Object, e As EventArgs) Handles Mover.Click
        If tabladetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect Then
            tabladetalle.SelectionMode = DataGridViewSelectionMode.CellSelect
        Else
            tabladetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End If
    End Sub
End Class