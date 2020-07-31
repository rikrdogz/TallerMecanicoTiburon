Imports System.Net.Mail

Public Class frmConfigCorreos
    Private Sub btnGuardarCorreo_Click(sender As Object, e As EventArgs) Handles btnGuardarCorreo.Click
        Dim continuar As Boolean = True
        Dim correoInput As String = txtCorreo.Text.Trim

        Try
            If (correoInput.Length = 0) Then
                continuar = False
            End If
            If (txtNombre.Text.Trim.Length = 0) Then
                continuar = False
            End If
            If continuar Then
                'validar

                Dim herramienta As New Herramienta
                herramienta.EsCorreoValido(correoInput)
                herramienta.ActualizarDatos(
                    "INSERT INTO config_todogas_correos (correo, nombre, activo) VALUES ('" & correoInput & "', '" & txtNombre.Text.Trim & "', 1) ")
                ObtenerCorreosTG()
                LimpiarCampos()
            Else
                MessageBox.Show("no se ingresaron datos en los campos ")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try


    End Sub
    Public Sub LimpiarCampos()
        txtCorreo.Clear()
        txtNombre.Clear()
    End Sub
    Public Sub ObtenerCorreosTG()
        Dim herramienta As New Herramienta
        Dim consulta As String
        Dim tabla As New DataTable

        GridCorreos.Rows.Clear()

        consulta = "SELECT * FROM config_todogas_correos"

        tabla = herramienta.ObtenerTabla(consulta)

        For Each xRow As DataRow In tabla.Rows

            GridCorreos.Rows.Add(xRow.Item("idcorreo"),
                                 xRow.Item("correo"), xRow.Item("nombre"), xRow.Item("activo"), "borrar")
        Next

        consulta = "SELECT codigo, valor FROM config_correo where codigo='CORREO_PARA'"
        tabla = herramienta.ObtenerTabla(consulta)
        If tabla.Rows.Count = 0 Then
            MsgBox("No se encontro codigo y valor del correo para")
            Return
        End If


        txtCorreoPara.Text = tabla.Rows(0).Item("Valor").ToString()


    End Sub

    Private Sub GridCorreos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridCorreos.CellContentClick

        Dim varidcorreo As Integer = 0

        Try
            If (e.RowIndex >= 0 And e.ColumnIndex >= 0) Then
                If (e.ColumnIndex <> acciones.Index) Then
                    Return
                End If
                Integer.TryParse(GridCorreos.Rows.Item(e.RowIndex).Cells(idcorreo.Name).Value.ToString, varidcorreo)

                If MessageBox.Show("Desea eliminar el correo", "eliminar correo", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                    Dim tool As New Herramienta
                    Dim consulta As String
                    consulta = "DELETE FROM config_todogas_correos WHERE idcorreo=" & varidcorreo.ToString
                    tool.ActualizarDatos(consulta)
                    ObtenerCorreosTG()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub frmConfigCorreos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerCorreosTG()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim tool As New Herramienta
        Dim consulta As String

        Try
            tool.EsCorreoValido(txtCorreoPara.Text.Trim)
            consulta = "UPDATE config_correo SET valor ='" & txtCorreoPara.Text.Trim & "' WHERE codigo = 'CORREO_PARA'"
            tool.ActualizarDatos(consulta)
            MsgBox("correo principal actualizado", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try




    End Sub
End Class