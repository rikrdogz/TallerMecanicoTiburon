Public Class frmProveedorAgregar

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub frmProveedorAgregar_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        txtProveedor.Clear()
        txtTele.Clear()
        cbCredito.SelectedIndex = -1
        CBtipo.SelectedIndex = -1

    End Sub

    Private Sub frmProveedorAgregar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then

            Me.Close()

        End If
    End Sub

    Private Sub frmProveedorAgregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim continuar As Boolean = False
        Dim valores As String = ""
        If txtProveedor.TextLength > 0 Then
            If CBtipo.SelectedIndex >= 0 Then
                If cbCredito.SelectedIndex >= 0 Then
                    Try
                        If con.State = ConnectionState.Closed Then
                            con.Open()
                        End If

                        If con.State = ConnectionState.Open Then
                            cmd.Connection = con
                            cmd.CommandText = "SELECT proveedor FROM proveedores WHERE proveedor='" & txtProveedor.Text & "'"
                            datos = cmd.ExecuteReader
                            If datos.HasRows Then
                                continuar = False
                                MsgBox("Ya existe este proveedor", MsgBoxStyle.Information)
                            Else
                                continuar = True
                            End If
                            datos.Close()
                            If continuar Then
                                valores &= "'" & txtProveedor.Text & "',"
                                valores &= "'" & txtTele.Text & "',"
                                valores &= "'" & CBtipo.Text & "',"
                                valores &= "'" & cbCredito.Text & "'"

                                cmd.CommandText = "INSERT INTO proveedores (proveedor,telefono,tipo,credito) VALUES (" & valores & ")"
                                If cmd.ExecuteNonQuery Then
                                    MsgBox("Proveedor Actualizado", MsgBoxStyle.Information)
                                    Me.Close()
                                    frmProveedores.CargarProveedores()
                                    frmProveedores.tablaProveedores.Rows(frmProveedores.tablaProveedores.Rows.Count - 1).Selected = True

                                End If
                            End If
                        End If
                    Catch ex As Exception
                        datos.Close()

                        MsgBox(ex.Message, MsgBoxStyle.Information)
                    End Try
                Else
                    MsgBox("Seleccione si maneja credito con este proveedor", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Seleccione tipo de proveedor", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Ingrese nombre del proveedor unico", MsgBoxStyle.Information)
        End If
    End Sub
End Class