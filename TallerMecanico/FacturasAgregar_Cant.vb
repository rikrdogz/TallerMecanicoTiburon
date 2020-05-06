Public Class FacturasAgregar_Cant

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FacturasAgregar.TablaDetalle.Rows(FacturasAgregar.index_tabla).Cells("c_unidad").Value = 1
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        FacturasAgregar.TablaDetalle.Rows(FacturasAgregar.index_tabla).Cells("c_unidad").Value = Ncant.Value
        Me.Close()
    End Sub

    Private Sub FacturasAgregar_Cant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ncant.Select(0, 1000)
    End Sub

    Private Sub Ncant_KeyDown(sender As Object, e As KeyEventArgs) Handles Ncant.KeyDown
        If e.KeyCode = Keys.Enter Then
            Beep()
            btnAceptar.Focus()


        End If
    End Sub

    Private Sub Ncant_LostFocus(sender As Object, e As EventArgs) Handles Ncant.LostFocus
        If sender.Controls.Item(1).Text = "" Then
            sender.Controls.Item(1).Text = 1
        End If
    End Sub

    Private Sub Ncant_ValueChanged(sender As Object, e As EventArgs) Handles Ncant.ValueChanged

    End Sub
End Class