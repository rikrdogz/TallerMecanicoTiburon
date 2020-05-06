Public Class frmServicio_AddManual

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim continuar As Boolean = False
        If txtdesc.TextLength > 0 Then
            If Ncosto.Value > 0 Then
                continuar = True
            Else
                If MsgBox("¿Deseas agregar renglon sin COSTO?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    continuar = True
                Else
                    continuar = False
                End If
            End If
            If continuar Then
                If Nmano.Value > 0 Then
                    continuar = True
                Else
                    If MsgBox("¿Deseas agregar renglon sin MANO?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        continuar = True
                    Else
                        continuar = False
                    End If
                End If
            End If
            If continuar Then
                If Nprecio.Value > 0 Then
                    continuar = True
                Else
                    If MsgBox("¿Deseas agregar renglon sin PRECIO?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        continuar = True
                    Else
                        continuar = False
                    End If
                End If
            End If
            'AGREGAR RENGLON
            If continuar Then
                If lblVentana.Text = "AGREGAR" Then
                    'ventana Serv
                    frmServicio_Agregar.TablaPiezas.Rows.Add(0, NCant.Value, 0, "SERVICIO", txtdesc.Text, 0, Ncosto.Value, Nprecio.Value, Nmano.Value, 0, 0, "REAL")

                    Me.Close()
                End If
                If lblVentana.Text = "EDIT_SER" Then
                    frmServicio_Editar.TablaPiezas.Rows.Add(0, 0, 0, "SERVICIO", txtdesc.Text, NCant.Value, 0, Ncosto.Value, Nprecio.Value, Nmano.Value, 0, "REAL")
                    Me.Close()
                End If
                If lblVentana.Text = "EDIT_COT" Then
                    frmCotizacion_Editar.TablaPiezas.Rows.Add(0, 0, 0, NCant.Value, txtdesc.Text, Ncosto.Value, Nprecio.Value, Nmano.Value, 0, 0, "REAL")
                    Me.Close()
                End If
                If lblVentana.Text = "ADD_COT" Then
                    frmCotizacionNuevoEdtar.TablaPiezas.Rows.Add(0, 0, "SERVICIO", NCant.Value, txtdesc.Text, Ncosto.Value, Nprecio.Value, Nmano.Value, 0, 0, "AGREGADO (*)")
                    Me.Close()

                End If
            End If
        End If

    End Sub

    Private Sub seleccionar(sender As Object, e As EventArgs) Handles Nprecio.Enter, Nmano.Enter, Ncosto.Enter, NCant.Enter
        sender.select(0, 1000000)
    End Sub

    Private Sub frmServicio_AddManual_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()

        End If
        If e.KeyCode = Keys.F5 Then
            btnmasIVA.PerformClick()

        End If
    End Sub


    Private Sub frmServicio_AddManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Siguiente(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub cambiar(sender As Object, e As KeyPressEventArgs) Handles txtdesc.KeyPress, Nprecio.KeyPress, Nmano.KeyPress, Ncosto.KeyPress, NCant.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub btnmasIVA_Click(sender As Object, e As EventArgs) Handles btnmasIVA.Click
        If Ncosto.Value > 0 Then
            Ncosto.Value *= 1.16
            Ncosto.Focus()
        End If
    End Sub

    Private Sub Ncosto_LostFocus(sender As Object, e As EventArgs) Handles Ncosto.LostFocus
        If sender.Controls.Item(1).Text = "" Then
            sender.Controls.Item(1).Text = 0
        End If
    End Sub

    Private Sub Ncosto_ValueChanged(sender As Object, e As EventArgs) Handles Ncosto.ValueChanged

    End Sub

    Private Sub Nmano_LostFocus(sender As Object, e As EventArgs) Handles Nmano.LostFocus
        If sender.Controls.Item(1).Text = "" Then
            sender.Controls.Item(1).Text = 0
        End If
    End Sub

    Private Sub Nmano_ValueChanged(sender As Object, e As EventArgs) Handles Nmano.ValueChanged

    End Sub

    Private Sub Nprecio_LostFocus(sender As Object, e As EventArgs) Handles Nprecio.LostFocus
        If sender.Controls.Item(1).Text = "" Then
            sender.Controls.Item(1).Text = 0
        End If
    End Sub

    Private Sub Nprecio_ValueChanged(sender As Object, e As EventArgs) Handles Nprecio.ValueChanged

    End Sub
End Class