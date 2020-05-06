Public Class frmServicio_Info

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btncerrar.Click
        Me.Close()

    End Sub

    Private Sub frmServicio_Info_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub

    Private Sub frmServicio_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class