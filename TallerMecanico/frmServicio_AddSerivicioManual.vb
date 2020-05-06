Public Class frmServicio_AddSerivicioManual

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim continuar As Boolean = False
        If NCant.Value > 0 Then
            If txtdesc.TextLength > 0 Then
                If Nprecio.Value > 0 Then
                    If Ncosto.Value > 0 Then
                        If Nmano.Value > 0 Then
                            continuar = True
                        Else
                            If MsgBox("¿Deseas continuar con Mano de Obra en Cero (0)?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                continuar = True
                            Else
                                Nmano.Focus()
                                Nmano.Select(0, 100000)
                                continuar = False
                            End If
                        End If
                        If continuar Then

                            frmServicio_Agregar.TablaPiezas.Rows.Add(0, "SERV", "SER-MANUAL", txtdesc.Text, NCant.Value, Nprecio.Value, 0, Nmano.Value, 0, 0, Ncosto.Value)

                            Me.Close()

                        End If
                    Else
                        MsgBox("Ingrese Costo", MsgBoxStyle.Information)
                        Ncosto.Focus()
                        Ncosto.Select(0, 10000)
                    End If

                Else
                    MsgBox("Precio debe ser mayor a Cero", MsgBoxStyle.Information)
                    Nprecio.Focus()

                End If
            Else
                MsgBox("Ingrese Descripcion", MsgBoxStyle.Information)
                txtdesc.Focus()
            End If
     
        Else
            MsgBox("Cantidad debe ser mayor a Cero", MsgBoxStyle.Information)
            NCant.Focus()
        End If
    End Sub

    Private Sub frmServicio_AddSerivicioManual_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()

        End If
    End Sub

    Private Sub frmServicio_AddSerivicioManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class