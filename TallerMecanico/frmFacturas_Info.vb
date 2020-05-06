Public Class frmFacturas_Info

    Private Sub btnsi_Click(sender As Object, e As EventArgs) Handles btnsi.Click
        FacturasAgregar.Guardar()
        Me.Close()

    End Sub

    Private Sub btnno_Click(sender As Object, e As EventArgs) Handles btnno.Click
        Me.Close()

    End Sub
End Class