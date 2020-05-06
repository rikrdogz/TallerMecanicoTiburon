Public Class FacturasAgregarEdit

    Private Sub FacturasAgregarEdit_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()

        End If
    End Sub

    Private Sub FacturasAgregarEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Ncantidad_ValueChanged(sender As Object, e As EventArgs) Handles Ncantidad.ValueChanged

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Ncantidad.Value > 0 Then
            If txtDesc.TextLength > 0 Then
                If NCosto.Value <> 0 Then
                    With FacturasAgregar.TablaDetalle.Rows(Val(lblindex.Text))
                        .Cells("cant").Value = Ncantidad.Value
                        .Cells("np").Value = txtNp.Text
                        .Cells("desc").Value = txtDesc.Text
                        .Cells("costo").Value = NCosto.Value
                        Me.Close()

                    End With


                Else
                    MsgBox("Costo debe ser DIFERENTE a Cero", MsgBoxStyle.Information)
                    NCosto.Focus()
                End If
            Else
                MsgBox("Descripcion debe ser mayor a cero", MsgBoxStyle.Information)
                txtDesc.Focus()
            End If
        Else
            MsgBox("Cantidad debe ser mayor a cero", MsgBoxStyle.Information)
            Ncantidad.Focus()
        End If
    End Sub

    Private Sub seleccionar(sender As Object, e As EventArgs) Handles txtNp.Enter, txtDesc.Enter, NCosto.Enter, Ncantidad.Enter
        sender.select(0, 10000000)
    End Sub

    Private Sub cambiar(sender As Object, e As KeyPressEventArgs) Handles txtNp.KeyPress, txtDesc.KeyPress, NCosto.KeyPress, Ncantidad.KeyPress
        If Asc(e.KeyChar) = 13 Then

            SendKeys.Send("{TAB}")

        End If

    End Sub

    Private Sub txtNp_LostFocus(sender As Object, e As EventArgs) Handles txtNp.LostFocus
        txtNp.Text = Replace(txtNp.Text, "'", "")
        txtNp.Text = Replace(txtNp.Text, Chr(34), "")
    End Sub

    Private Sub txtNp_TextChanged(sender As Object, e As EventArgs) Handles txtNp.TextChanged

    End Sub

    Private Sub txtDesc_LostFocus(sender As Object, e As EventArgs) Handles txtDesc.LostFocus
        txtDesc.Text = Replace(txtDesc.Text, "'", "")
        txtDesc.Text = Replace(txtDesc.Text, Chr(34), "")
    End Sub

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles txtDesc.TextChanged

    End Sub

    Private Sub NCosto_LostFocus(sender As Object, e As EventArgs) Handles NCosto.LostFocus
        If sender.Controls.Item(1).Text = "" Then
            sender.Controls.Item(1).Text = 0
        End If

    End Sub

    Private Sub NCosto_ValueChanged(sender As Object, e As EventArgs) Handles NCosto.ValueChanged

    End Sub
End Class