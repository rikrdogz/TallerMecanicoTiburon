Public Class frmCotizacion_RenglonEdit

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If lblventana.Text = "EDIT_COT" Then
            With frmCotizacion_Editar.TablaPiezas.Rows(Val(lblindex.Text))
                .Cells("cant").Value = NCant.Value
                .Cells("desc").Value = txtdesc.Text
                .Cells("costo").Value = Ncosto.Value
                .Cells("precio").Value = Nprecio.Value
                .Cells("mano").Value = Nmano.Value
            End With
            Me.Close()
        End If
        If lblventana.Text = "ADD_COT" Then
            With frmCotizacionNuevoEdtar.TablaPiezas.Rows(Val(lblindex.Text))
                .Cells("cant").Value = NCant.Value
                .Cells("desc").Value = txtdesc.Text
                .Cells("costo").Value = Ncosto.Value
                .Cells("precio").Value = Nprecio.Value
                .Cells("mano").Value = Nmano.Value
            End With
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub siguiente(sender As Object, e As KeyPressEventArgs) Handles txtdesc.KeyPress, Nprecio.KeyPress, Nmano.KeyPress, Ncosto.KeyPress, NCant.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub SELECCIONAR(sender As Object, e As EventArgs) Handles Nprecio.Enter, Nmano.Enter, Ncosto.Enter, NCant.Enter
        sender.select(0, 10000)
    End Sub

    Private Sub frmCotizacion_RenglonEdit_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub

    Private Sub frmCotizacion_RenglonEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class