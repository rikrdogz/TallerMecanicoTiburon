Public Class frmServicio_ArtEDIT

    Private Sub frmServicio_ArtEDIT_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()

        End If
    End Sub



    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim continuar As Boolean = False
        If NCant.Value > 0 Then
            If txtdesc.TextLength > 0 Then
                If lblventana.Text = "AGREGAR" Then
                    With frmServicio_Agregar.TablaPiezas.Rows(lblindex.Text)
                        .Cells("cant").Value = NCant.Value
                        .Cells("desc").Value = txtdesc.Text
                        .Cells("costo").Value = Ncosto.Value
                        .Cells("precio").Value = Nprecio.Value
                        .Cells("mano").Value = NMano.Value

                        Me.Close()

                    End With
                End If
                If lblventana.Text = "SER_EDIT" Then
                    With frmServicio_Editar.TablaPiezas.Rows(lblindex.Text)
                        .Cells("cant").Value = NCant.Value
                        .Cells("desc").Value = txtdesc.Text
                        .Cells("costo").Value = Ncosto.Value
                        .Cells("precio").Value = Nprecio.Value
                        .Cells("mano").Value = NMano.Value
                        Me.Close()

                    End With
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

    Private Sub seleccionar(sender As Object, e As EventArgs) Handles NCant.Enter
        sender.select(0, 10000000)

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()

    End Sub

    Private Sub frmServicio_ArtEDIT_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub sumar_Valores()
        Dim v_cant As Integer
        Dim p_mano As Decimal
        Dim p_precio As Decimal
        v_cant = NCant.Value
        p_mano = NMano.Value
        p_precio = Nprecio.Value
        lblsuma_text.Text = "Suma (x" & v_cant & "):"
        lblsuma_valor.Text = (p_mano + p_precio) * v_cant
        lblsuma_valor.Text = FormatCurrency(Val(lblsuma_valor.Text))

    End Sub

    Private Sub frmServicio_ArtEDIT_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtdesc.Focus()

    End Sub

    Private Sub txtdesc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtdesc.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True
            btnGuardar.Focus()

        End If
    End Sub

    Private Sub txtdesc_TextChanged(sender As Object, e As EventArgs) Handles txtdesc.TextChanged

    End Sub

    Private Sub Ncosto_GotFocus(sender As Object, e As EventArgs) Handles Ncosto.GotFocus
        Ncosto.Select(0, 1000)
    End Sub

    Private Sub Ncosto_ValueChanged(sender As Object, e As EventArgs) Handles Ncosto.ValueChanged
        sumar_Valores()
    End Sub

    Private Sub Nprecio_GotFocus(sender As Object, e As EventArgs) Handles Nprecio.GotFocus
        Nprecio.Select(0, 10000)
    End Sub

    Private Sub Nprecio_LostFocus(sender As Object, e As EventArgs) Handles Nprecio.LostFocus
        If sender.Controls.Item(1).Text = "" Then
            sender.Controls.Item(1).Text = 0
        End If
    End Sub

    Private Sub Nprecio_ValueChanged(sender As Object, e As EventArgs) Handles Nprecio.ValueChanged
        sumar_Valores()
    End Sub

    Private Sub NMano_GotFocus(sender As Object, e As EventArgs) Handles NMano.GotFocus
        NMano.Select(0, 1000)
    End Sub

    Private Sub NMano_LostFocus(sender As Object, e As EventArgs) Handles NMano.LostFocus
        If sender.Controls.Item(1).Text = "" Then
            sender.Controls.Item(1).Text = 0
        End If
    End Sub

    Private Sub NMano_ValueChanged(sender As Object, e As EventArgs) Handles NMano.ValueChanged
        sumar_Valores()
    End Sub

    Private Sub NCant_LostFocus(sender As Object, e As EventArgs) Handles NCant.LostFocus
        If sender.Controls.Item(1).Text = "" Then
            sender.Controls.Item(1).Text = 0
        End If
    End Sub

    Private Sub NCant_ValueChanged(sender As Object, e As EventArgs) Handles NCant.ValueChanged
        sumar_Valores()

    End Sub
End Class