Public Class frmConfig

    Private Sub frmConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NIvaCot.Value = My.Settings.Iva

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        My.Settings.Iva = NIvaCot.Value

    End Sub
End Class