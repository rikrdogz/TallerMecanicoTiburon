Public Class frmCotizacion_Reporte

    Private Sub frmCotizacion_Reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sumaReal As Decimal = 0
        Dim sumaAgregado As Decimal = 0
        Dim sumaAnexado As Decimal = 0
        Dim sumaE As Decimal = 0
        Dim sumaF As Decimal = 0
        Dim SumaPendiente As Decimal = 0
        Dim SUMA As Decimal = 0
        Dim continuar As Boolean = True
        Dim sumadetalle As Decimal = 0

        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If con.State = ConnectionState.Open Then
                cmd.Connection = con
                cmd.CommandText = "Select * from servicios where numero >1200 AND FACTURA='' AND OC<>'NOREALIZADO' order by numero desc"
                datos = cmd.ExecuteReader
                tablaCOT.Rows.Clear()
                If datos.HasRows Then
                    While datos.Read
                        suma += datos("valor")
                        tablaCOT.Rows.Add(datos("numero"), "-", datos("camion"), "-", "-", "-", Val(datos("valor")))


                    End While
                End If
                datos.Close()
                If tablaCOT.Rows.Count > 0 And MsgBox("Desglosar detalle?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then


                    Dim i As Integer = 0

                    While Not i = tablaCOT.Rows.Count - 1

                        With tablaCOT
                            If IsNumeric(tablaCOT.Rows(i).Cells("cot").Value.ToString) Then
                                If .Rows(i).Cells("COT").Value > 0 And .Rows(i).Cells("COT").Value <> 0 Then
                                    cmd.CommandText = "SELECT cantidad, descripcion,precio,tipo FROM servicios_cotdetalle WHERE ncotizacion =" & .Rows(i).Cells("COT").Value.ToString
                                    datos = cmd.ExecuteReader
                                    Dim plus As Integer = 0
                                    Dim s As Integer = 0
                                    If datos.HasRows Then
                                        While datos.Read
                                            sumadetalle += ((datos("cantidad") * datos("precio")) * 1.16)

                                            If datos("tipo") = "REAL" Then
                                                sumaReal += (datos("cantidad") * datos("precio"))
                                            ElseIf datos("tipo") = "AGREGADO (*)" Then
                                                sumaAgregado += (datos("cantidad") * datos("precio"))
                                            ElseIf datos("tipo") = "ANEXADO (+)" Then
                                                sumaAnexado += (datos("cantidad") * datos("precio"))
                                            ElseIf datos("tipo") = "E" Then
                                                sumaE += (datos("cantidad") * datos("precio"))
                                            ElseIf datos("tipo") = "F" Then
                                                sumaF += (datos("cantidad") * datos("precio"))
                                            ElseIf datos("tipo") = "PENDIENTE" Then
                                                SumaPendiente += (datos("cantidad") * datos("precio"))
                                            Else
                                                MsgBox(datos("tipo"))
                                            End If
                                            plus = i + 1
                                            s = s + 1

                                            tablaCOT.Rows.Insert(plus, .Rows(i).Cells("COT").Value & "*", datos("cantidad"), datos("descripcion"), datos("precio"), (datos("cantidad") * datos("precio")), datos("tipo"))

                                        End While
                                        If sumadetalle <> .Rows(i).Cells("TOTAL").Value Then
                                            'MsgBox(.Rows(i).Cells("COT").Value)
                                        End If
                                        sumadetalle = 0

                                    End If

                                    plus = i + (s + 1)

                                    tablaCOT.Rows.Insert((plus), "")
                                    s = 0
                                    datos.Close()


                                End If
                            End If

                        End With
                        i += 1
                    End While 'primer bucle

                End If

            End If

            lblcount.Text = tablaCOT.Rows.Count
            lble.Text = FormatCurrency(sumaE * 1.16)
            lblreal.Text = FormatCurrency(sumaReal * 1.16)
            lblagregado.Text = FormatCurrency(sumaAgregado * 1.16)
            lblanexado.Text = FormatCurrency(sumaAnexado*1.16)
            lblF.Text = FormatCurrency(sumaF * 1.16)
            lblPendiente.Text = FormatCurrency(SumaPendiente * 1.16)
            LBLSUMA.Text = FormatCurrency(SUMA)
        Catch ex As Exception
            datos.Close()
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
End Class