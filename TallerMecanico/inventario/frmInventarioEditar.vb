Public Class frmInventarioEditar
    Private IdNumeroParte As Integer
    Private stringNP As String = ""
    Public Sub New(idNP As Integer)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        IdNumeroParte = idNP

        If (IdNumeroParte = 0) Then
            MessageBox.Show("Ocurrio un error al obtener los tabla, favor de volver abrir la ventana")
            Me.Close()
        End If
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmInventarioEditar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.AppStarting
        Try
            CargarInfoNumeroParte()
            CargarArticulosRelacionado()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Me.Cursor = Cursors.Default

        End Try

    End Sub
    Private Sub CargarInfoNumeroParte()

        Dim comando As New MySql.Data.MySqlClient.MySqlCommand
        Dim tabla As MySql.Data.MySqlClient.MySqlDataReader = Nothing

        Try
            comando.Connection = New MySql.Data.MySqlClient.MySqlConnection
            comando.Connection.ConnectionString = con.ConnectionString
            comando.Connection.Open()

            comando.CommandText = " SELECT * FROM articulos_inventario where id =" & IdNumeroParte

            If comando.Connection.State = ConnectionState.Open Then
                tabla = comando.ExecuteReader
                If tabla.HasRows Then
                    While tabla.Read
                        txtNP.Text = tabla("np").ToString
                        txtDescripcion.Text = tabla("descripcion").ToString
                        stringNP = txtDescripcion.Text
                        cboActivo.SelectedItem = tabla("activo").ToString
                    End While
                End If
            Else
                MessageBox.Show("No se pudo conectar al servidor para obtener el np")
            End If



            If comando.Connection.State = ConnectionState.Open Then
                comando.Connection.Close()
                tabla.Close()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally

            If tabla IsNot Nothing AndAlso tabla.IsClosed = False Then
                tabla.Close()
            End If

            If comando.Connection IsNot Nothing AndAlso comando.Connection.State = ConnectionState.Open Then
                comando.Connection.Close()

            End If
        End Try
        

    End Sub
    Private Sub CargarArticulosRelacionado()

        tablaArticulos.Rows.Clear()

        Dim comando As New MySql.Data.MySqlClient.MySqlCommand
        Dim tabla As MySql.Data.MySqlClient.MySqlDataReader = Nothing

        Try
            comando.Connection = New MySql.Data.MySqlClient.MySqlConnection
            comando.Connection.ConnectionString = con.ConnectionString
            comando.Connection.Open()

            If comando.Connection.State = ConnectionState.Open Then
                comando.CommandText = " SELECT * FROM articulos where id_inv = " & IdNumeroParte

                tabla = comando.ExecuteReader

                If tabla.HasRows Then

                    While tabla.Read()
                        tablaArticulos.Rows.Add(tabla("id"), tabla("np").ToString, tabla("descripcion"), Val(tabla("precio")), tabla("costo"), tabla("obser"), tabla("minimo"), tabla("mano"), (Val(tabla("mano")) + Val(tabla("precio"))), tabla("marca"), tabla("modelo"), tabla("year"), tabla("id_inv"), tabla("ubicacion"))
                    End While
                End If
            Else
                MessageBox.Show("No se pudo conectar al servidor para obtener los articulos relacionados")
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally

            If tabla IsNot Nothing AndAlso tabla.IsClosed = False Then
                tabla.Close()
            End If

            If comando.Connection IsNot Nothing AndAlso comando.Connection.State = ConnectionState.Open Then
                comando.Connection.Close()

            End If
        End Try

        



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If String.IsNullOrWhiteSpace(txtNP.Text.Trim) Then
            MessageBox.Show("No se establecio el valor del NP (variable)")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtDescripcion.Text.Trim) Then
            MessageBox.Show("No se establecio el valor de descripción ")
            Return
        End If

        If cboActivo.SelectedIndex = -1 Then
            MessageBox.Show("Debe seleccionar si está activo el inventario ")
            Return
        End If

        'se actualizará el texto de NP
        actualizar()


    End Sub

    Private Sub actualizar()

        Dim comando As New MySql.Data.MySqlClient.MySqlCommand
        Dim tabla As MySql.Data.MySqlClient.MySqlDataReader = Nothing
        Dim transaccionActualizar As MySql.Data.MySqlClient.MySqlTransaction = Nothing

        Try
            comando.Connection = New MySql.Data.MySqlClient.MySqlConnection
            comando.Connection.ConnectionString = con.ConnectionString
            comando.Connection.Open()

            transaccionActualizar = comando.Connection.BeginTransaction()
            comando.Transaction = transaccionActualizar

            If comando.Connection.State = ConnectionState.Open Then
                comando.CommandText = "UPDATE articulos SET np='" & txtNP.Text.Trim & "' WHERE id_inv =" & IdNumeroParte
                If comando.ExecuteNonQuery() Then
                    comando.CommandText = "UPDATE articulos_inventario SET np='" & txtNP.Text.Trim & "', descripcion = '" & txtDescripcion.Text.Trim & "', activo='" & cboActivo.Text & "' WHERE id =" & IdNumeroParte
                    If comando.ExecuteNonQuery() Then
                        transaccionActualizar.Commit()
                        CargarArticulosRelacionado()
                        MessageBox.Show("Número de parte actualizado")
                        Me.Close()

                    End If

                End If

                
            Else
                MessageBox.Show("No se pudo conectar al servidor para actualizar Número de parte")
            End If
        Catch ex As Exception
            

            If transaccionActualizar IsNot Nothing Then
                transaccionActualizar.Rollback()
            End If

            If comando IsNot Nothing AndAlso comando.Connection IsNot Nothing Then
                If comando.Connection.State = ConnectionState.Open Then
                    comando.Connection.Close()
                End If
            End If

            MessageBox.Show(ex.Message)
        Finally

            If tabla IsNot Nothing AndAlso tabla.IsClosed = False Then
                tabla.Close()
            End If

            If comando.Connection IsNot Nothing AndAlso comando.Connection.State = ConnectionState.Open Then
                comando.Connection.Close()

            End If
        End Try
    End Sub
End Class