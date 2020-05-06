Public Class frmFacturas_Det

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        lbltitulo.Text = "cancelando..."
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCON.Click
        Me.Close()
        btnCON.Hide()

        lbltitulo.Text = "Inv Aplicado"
    End Sub

    Private Sub frmFacturas_Det_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class