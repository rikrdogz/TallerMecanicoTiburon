Imports MySql.Data.MySqlClient
Public Class frmUltimosServicios
    Public xCon As MySqlConnection
    Public xCmd As New MySqlCommand
    Public xDatos As MySqlDataReader

    Private Sub frmUltimosServicios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuscarPorMovimiento()
        estructura_ventana(Me)
    End Sub

    Private Sub BuscarPorMovimiento()
        Me.Cursor = Cursors.AppStarting
        btnMovimientos.Enabled = False
        TablaMovimientos.Rows.Clear()
        Try
            'busqueda por cantidad de movimientos
            xCmd.Connection = New MySqlConnection
            xCmd.Connection.ConnectionString = con.ConnectionString
            xCmd.Connection.Open()
            xCmd.CommandText = "SELECT * FROM servicios_detalle INNER JOIN autos ON servicios_detalle.idauto = autos.Id order by servicios_detalle.id desc LIMIT " & NCantidadMovimientos.Value

            xDatos = xCmd.ExecuteReader

            If xDatos.HasRows Then
                While xDatos.Read
                    TablaMovimientos.Rows.Add(
                        xDatos("id"),
                        xDatos("cant"),
                        xDatos("descripcion"),
                        xDatos("fecha"),
                        xDatos("id_inv"),
                        xDatos("marcado"),
                        xDatos("nuevo") + " " + xDatos("texto") + " " + xDatos("anterior")
                        )
                End While

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, Me.Text)
        Finally
            If xDatos IsNot Nothing AndAlso xDatos.IsClosed = False Then xDatos.Close()
            If xCmd IsNot Nothing AndAlso xCmd.Connection.State = ConnectionState.Open Then xCmd.Connection.Close()
            btnMovimientos.Enabled = True
            Me.Cursor = Cursors.Default
        End Try



    End Sub

    Private Sub btnMovimientos_Click(sender As Object, e As EventArgs) Handles btnMovimientos.Click
        BuscarPorMovimiento()
    End Sub

    Private Sub frmUltimosServicios_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        estructura_ventana(Me)
    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub
End Class