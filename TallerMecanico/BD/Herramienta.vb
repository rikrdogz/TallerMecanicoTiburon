Imports MySql.Data.MySqlClient
Public Class Herramienta
    Private conexion As MySqlConnection
    Private comando As New MySqlCommand
    Private LectorDatos As MySqlDataReader

    Public Function ObtenerTabla(consulta As String) As DataTable

        Dim tablaDatos As New DataTable

        comando = New MySqlCommand

        Try
            comando.Connection = New MySqlConnection
            comando.Connection.ConnectionString = con.ConnectionString

            comando.Connection.Open()

            If comando.Connection.State = ConnectionState.Open Then
                comando.CommandText = consulta
                LectorDatos = comando.ExecuteReader
                tablaDatos.Load(LectorDatos)

            Else
                Throw New Exception("No se pudo establecer la conexión al servidor de datos")
            End If

        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally

            If LectorDatos IsNot Nothing Then
                If LectorDatos.IsClosed = False Then
                    LectorDatos.Close()
                End If
            End If

            If comando.Connection IsNot Nothing Then
                If comando.Connection.State = ConnectionState.Open Then
                    comando.Connection.Close()
                End If
            End If
        End Try

        Return tablaDatos

    End Function

    Public Function ActualizarDatosTransaccion(ByRef theTransaccion As MySqlTransaction, ByVal consulta As String) As Boolean

        comando.Transaction = theTransaccion
        comando.Connection = theTransaccion.Connection
        comando.CommandText = consulta

        If comando.ExecuteNonQuery Then


            Return True
        End If

        Return False

    End Function

    Public Function ActualizarDatos(ByVal consulta As String) As Boolean


        comando.Connection = New MySqlConnection
        comando.Connection.ConnectionString = con.ConnectionString
        comando.Connection.Open()
        comando.CommandText = consulta

        If comando.ExecuteNonQuery Then
            Return True
        End If

        Return False

    End Function

    Public Function ObtenerTablaTransaccion(ByRef theTransaccion As MySqlTransaction, ByVal consulta As String) As DataTable

        Dim tablaDatos As New DataTable

        comando = New MySqlCommand

        Try
            comando.Transaction = theTransaccion
            comando.Connection = theTransaccion.Connection


            comando.CommandText = consulta
            LectorDatos = comando.ExecuteReader
            tablaDatos.Load(LectorDatos)


        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally

            If LectorDatos IsNot Nothing Then
                If LectorDatos.IsClosed = False Then
                    LectorDatos.Close()
                End If
            End If


        End Try

        Return tablaDatos

    End Function

    Public Function Insertar_Movimiento_ModuloTransaccion(ventana As String, folio As String, ID_DET As Integer, idnp As Integer, np As String, tipo_mov As String, tipo_art As String, cant As Integer, fecha As Date, descripcion As String, existencia As Integer, saldo As Integer, id_proveedor As Integer, proveedor As String, cant_unidad As Integer, motivo As String, ByRef theTransaccion As MySqlTransaction) As Boolean
        'VENTANA= NOMBRE VENTANA EJ FACTURA, NOTACRED, INVENTARIO_MANUAL,SERVICIO_ADD,SERVICIO_EDIT
        'FOLIO= NUMERO EJ # DE FACTURA O NOTA, 0 EN MANUAL, # SERVICIO
        'ID_dET EJE: linea de factura, 
        'id es autoincremental es unico
        Dim valores As String = ""
        valores &= "'" & ventana & "',"
        valores &= "'" & folio & "',"
        valores &= ID_DET & ","
        valores &= idnp & ","
        valores &= "'" & np & "',"
        valores &= "'" & tipo_mov & "',"
        valores &= "'" & tipo_art & "',"
        valores &= cant & ","
        valores &= "'" & Format(fecha, "yyyy/MM/dd") & "',"
        valores &= "'" & descripcion & "',"
        valores &= existencia & ","
        valores &= saldo & ","
        valores &= id_proveedor & ","
        valores &= "'" & proveedor & "',"
        valores &= cant_unidad & ","
        valores &= "'" & motivo & "'"


        comando.Transaction = theTransaccion
        comando.Connection = theTransaccion.Connection
        comando.CommandText = "INSERT INTO articulos_movimiento (ventana,folio,id_det,id_np,np,tipo_mov,tipo_art,cant,fecha,descripcion,existencia,saldo,id_proveedor,proveedor,cant_unidad,motivo) VALUES (" & valores & ")"

        If comando.ExecuteNonQuery Then
            Return True
        End If
        Return False


    End Function

    Public Function AplicarABonoFactura(idpago As Integer, idfactura As Integer, valorAbonado As Decimal, valorPendiente As Decimal, transaccionActualizar As MySqlTransaction) As Boolean

        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        If idfactura = 0 Then
            Throw New Exception("el ID de la factura debe ser mayor a cero")
        End If

        If idpago = 0 Then
            Throw New Exception("el ID del pago debe ser mayor a cero")
        End If

        comando = New MySqlCommand

        Try
            comando.Transaction = transaccionActualizar
            comando.Connection = transaccionActualizar.Connection

            consulta = "SELECT saldopendiente, folio FROM factura WHERE id=" & idfactura
            tablaResultado = Me.ObtenerTablaTransaccion(transaccionActualizar, consulta)
            If tablaResultado.Rows.Count > 0 Then
                If valorPendiente <> tablaResultado.Rows(0).Item("saldopendiente") Then
                    Throw New Exception("el valor pendiente no coincide con el saldo pendiente en el sistema valor pendiente mandado: " & valorPendiente & " factura:" & tablaResultado.Rows(0).Item("folio"))
                End If
            Else
                Throw New Exception("no hay factura para comparar saldo pendiente")
            End If

            consulta = "INSERT INTO facturas_pagodetalle (idpago, idfactura, abonado)"
            consulta &= " VALUES (" & idpago & ", " & idfactura & ", " & valorAbonado & ")"
            comando.CommandText = consulta
            If comando.ExecuteNonQuery() Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return False

    End Function
End Class
