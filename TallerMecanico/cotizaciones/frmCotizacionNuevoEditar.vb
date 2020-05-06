Public Class frmCotizacionNuevoEditar

    Private Sub frmCotizacionNuevoEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estructura_ventana(Me)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class