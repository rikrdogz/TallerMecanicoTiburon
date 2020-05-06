Public Class frmAviso

    Private Sub btnCLose_Click(sender As Object, e As EventArgs) Handles btnCLose.Click
        btnCLose.Text = "cancelar"
        Me.Close()

    End Sub

    Private Sub btnSI_Click(sender As Object, e As EventArgs) Handles btnSI.Click
        btnSI.Text = "continuar"
        Me.Close()

    End Sub
End Class