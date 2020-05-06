Public Class frmUsuario

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub frmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerUsuarios()
    End Sub
    Private Sub ObtenerUsuarios()
        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaUsuarios As New DataTable

        consulta = "SELECT * from usuarios order by id"

        tablaUsuarios = tool.ObtenerTabla(consulta)

        If tablaUsuarios.Rows.Count > 0 Then
            For Each xRow As DataRow In tablaUsuarios.Rows
                GridUsuario.Rows.Add(xRow.Item("id"), xRow.Item("name"), xRow.Item("pfacturas"))
            Next
        End If

    End Sub

    Private Sub GridUsuario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridUsuario.CellContentClick

    End Sub

    Private Sub GridUsuario_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridUsuario.CellDoubleClick

        Dim contraseñaNueva As String = ""
        Dim idUser As Integer
        Dim tool As New Herramienta
        Dim consulta As String

        If e.ColumnIndex <= -1 Or e.RowIndex <= -1 Then
            Return
        End If

        Integer.TryParse(GridUsuario.Rows(e.RowIndex).Cells(idUsuario.Name).Value.ToString, idUser)

        If idUser = 0 Then
            MsgBox("no se pudo establecer id usuario")
            Return
        End If

        With GridUsuario.Rows(e.RowIndex)
            If MsgBox("¿desea cambiar la contraseña de ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                contraseñaNueva = InputBox("Contraseña nueva para " & GridUsuario.Rows(e.RowIndex).Cells(Nombre.Name).Value.ToString, "Contraseña")

                If contraseñaNueva <> "" Then
                    Try
                        consulta = "UPDATE usuarios SET pass='" & contraseñaNueva & "' WHERE id=" & idUser
                        If tool.ActualizarDatos(consulta) Then
                            MessageBox.Show("Contraseña actualizada", "usuario", MessageBoxButtons.OK)
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                    End Try
                   
                End If
            End If
        End With


    End Sub
End Class