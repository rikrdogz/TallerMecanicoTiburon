Imports MySql.Data.MySqlClient
Imports System.IO

Module modulo
    Public con As MySqlConnection
    Public cmd As New MySqlCommand
    Public datos As MySqlDataReader


    Public M_server As String = ""
    Public M_user As String = ""
    Public M_pass As String = ""
    Public M_data As String = ""
    Dim sentencia As String = ""
    Public ventana_ancho As Integer = 800
    Public ventana_alto As Integer = 800
    Dim carpeta As String = Application.StartupPath.ToString & "\respaldos"

    '****************************************************************************
    'MODIFICACION 23 JUNIO 2018 :
    ' Se agregará modificacion de cotizacion y ubicacion de articulos
    '****************************************************************************
    Public Sub Modificaciones_de_tablas()
        Try
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
            If con.State = ConnectionState.Open Then
                cmd.Connection = con
                cmd.CommandText = "ALTER TABLE articulos ADD ubicacion varchar(25) default ''"


                If cmd.ExecuteNonQuery Then
                    MsgBox("Tabla articulos modificado por primera vez, + Ubicación")
                End If
            Else
                MsgBox("No se puede conectar a la base de datos", MsgBoxStyle.Information, "Modificacion de tablas")
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub conectar()
        InicioDeSesion.barra.Value = 0
        con = New MySqlConnection

        sentencia = "Persist Security Info=True;server=" & M_server & "; user=" & M_user & "; password=" & M_pass & "; database=" & M_data & "; Port=3306;Connect Timeout=100;Convert Zero Datetime=True"

        con.ConnectionString = sentencia
        Try
            InicioDeSesion.barra.Value += 10
            MDIPrincipal.lblestado.Text = "Conectando..."
            If con.State = ConnectionState.Closed Then
                InicioDeSesion.barra.Value += 20
                MDIPrincipal.lblestado.Text = "Conectando..."
                con.Open()

            End If
            If con.State = ConnectionState.Open Then
                InicioDeSesion.barra.Value = 100
                MDIPrincipal.lblestado.Text = "Conectado! a :" & M_data

            Else

                MDIPrincipal.lblestado.Text = "No Conecto"
            End If
        Catch ex As Exception

            MDIPrincipal.lblestado.Text = "No Conecto"
            MsgBox(ex.Message, MsgBoxStyle.Information, "Conectar")
        End Try
        con.Close()
    End Sub
    Private Function verificar_columnas_bd() As String

        Try
            cmd.CommandText = "SELECT ubicacion FROM articulos LIMIT 1"
            datos = cmd.ExecuteReader
            If Not datos.HasRows Then
                Return "no hay ubicacion en articulos"


            End If
            Return "ok"
        Catch ex As Exception
            Modificaciones_de_tablas()
            Return "No hay ubicacion en articulos, vuelva a abrir el sistema"
        End Try

    End Function
    Public Sub leer_user()
        con = New MySqlConnection
        sentencia = "Persist Security Info=True;server=" & M_server & "; user=" & M_user & "; password=" & M_pass & "; database=" & M_data & "; Port=3306;Connect Timeout=100"
        con.ConnectionString = sentencia

        InicioDeSesion.CBUsuario.Items.Clear()
        InicioDeSesion.tablaid.Clear()
        InicioDeSesion.tablaPass.Clear()

        Try

            If con.State = ConnectionState.Closed Then
                InicioDeSesion.lblinfo.Text = "Abriendo conexión ..."
                con.Open()

            End If
            If con.State = ConnectionState.Open Then
                InicioDeSesion.lblinfo.Text = "Listo, ¡Conectado! a: " & M_data
                InicioDeSesion.ingresoPanel.Show()
                cmd.Connection = con
                cmd.CommandText = "SELECT * FROM usuarios"
                datos = cmd.ExecuteReader
                If datos.HasRows Then
                    While datos.Read
                        InicioDeSesion.tablaid.Add(datos("id"))
                        InicioDeSesion.CBUsuario.Items.Add(datos("name"))
                        InicioDeSesion.tablaPass.Add(datos("pass"))

                    End While
                End If

                datos.Close()

                cmd.CommandText = "SELECT saldo,id_proveedor,proveedor,cant_unidad FROM articulos_movimiento limit 1"
                datos = cmd.ExecuteReader
                If datos.HasRows Then
                Else
                    MsgBox("No hay campo saldo")
                End If
                datos.Close()

                Dim mensaje As String = verificar_columnas_bd()
                If Not mensaje = "ok" Then
                    MsgBox(mensaje)
                End If
                


            Else

            End If
            con.Close()
        Catch ex As Exception
            InicioDeSesion.btnConnect.Show()
            InicioDeSesion.lblinfo.Text = "Detalle de conexión!"
            MDIPrincipal.lblestado.Text = "No Conecto"
            MsgBox(ex.Message, MsgBoxStyle.Information, "Conectar_USER")
        End Try
        con.Close()
    End Sub
    Public Sub estructura_ventana(ventana As Windows.Forms.Form)
        ventana.StartPosition = FormStartPosition.Manual
        ventana.Top = 0
        ventana.ControlBox = False
        If (MDIPrincipal.Width - 50) > 400 Then
            ventana.Width = MDIPrincipal.Width - 25
            ventana.Height = MDIPrincipal.Height - 200
        Else
            ventana.Width = 500
            ventana.Height = 500

        End If

        ventana_alto = ventana.Height
        ventana_ancho = ventana.Width
    End Sub
    Public Sub Insertar_Movimiento_Modulo(ventana As String, folio As String, ID_DET As Integer, idnp As Integer, np As String, tipo_mov As String, tipo_art As String, cant As Integer, fecha As Date, descripcion As String, existencia As Integer, saldo As Integer, id_proveedor As Integer, proveedor As String, cant_unidad As Integer, motivo As String)
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


        cmd.CommandText = "INSERT INTO articulos_movimiento (ventana,folio,id_det,id_np,np,tipo_mov,tipo_art,cant,fecha,descripcion,existencia,saldo,id_proveedor,proveedor,cant_unidad,motivo) VALUES (" & valores & ")"
        cmd.ExecuteNonQuery()


    End Sub

End Module
