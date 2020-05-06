Public Class frmProveedor_edit

    Private Sub frmProveedor_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmProveedor_edit_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        cargar_datos()
    End Sub
    Private Sub cargar_datos()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If con.State = ConnectionState.Open Then
                cmd.Connection = con
                cmd.CommandText = "select * from proveedores where id=" & lblid.Text
                datos = cmd.ExecuteReader
                If datos.HasRows Then
                    While datos.Read
                        txtProveedor.Text = datos("proveedor")
                        txtTele.Text = datos("telefono")
                        cbCredito.SelectedItem = datos("credito")
                        CBtipo.SelectedItem = datos("tipo")
                        cboIva.SelectedItem = datos("Iva").ToString
                    End While
                End If
                datos.Close()
                con.Clone()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtProveedor.TextLength > 2 Then
            Try
                If con.State = ConnectionState.Closed Then
                    con.Open()
                End If
                If con.State = ConnectionState.Open Then
                    cmd.Connection = con
                    cmd.CommandText = "UPDATE proveedores SET proveedor='" & txtProveedor.Text & "', telefono='" & txtTele.Text & "',tipo='" & CBtipo.Text & "', credito='" & cbCredito.Text & "', iva=" & cboIva.Text & " WHERE id=" & lblid.Text
                    If cmd.ExecuteNonQuery Then
                        MsgBox("Actualizado", MsgBoxStyle.Information)
                    End If
                    con.Clone()
                End If
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Information, "Insertar")
            End Try
        Else
            MsgBox("Ingrese nombre del proveedor mayor a 2 caracteres")
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub
End Class