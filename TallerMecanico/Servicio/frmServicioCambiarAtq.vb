Public Class frmServicioCambiarAtq

    Private IdServicio As Integer
    Private IdAuto As Integer

    Public Sub New(PIdServicio As Integer, PidAuto As Integer, ByVal PInfoCamion As String)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        IdServicio = PIdServicio
        IdAuto = PidAuto
        lblIDatq.Text = IdAuto.ToString
        lblIdServicio.Text = IdServicio
        lblInfoCamion.Text = PInfoCamion
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Private Sub frmServicioCambiarAtq_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ObtenerCamiones()
    End Sub



    Private Sub ObtenerCamiones()

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable

        If IdAuto = 0 Then
            Return
        End If

        Try
            consulta = "SELECT id, nuevo, anterior, activo, texto, marca, year FROM autos WHERE activo =1 AND id NOT  IN (" & IdAuto & ")"

            tablaResultado = tool.ObtenerTabla(consulta)

            If tablaResultado.Rows.Count > 0 Then
                For Each xRow As DataRow In tablaResultado.Rows
                    GridCamiones.Rows.Add(xRow.Item("id"), xRow.Item("nuevo"), xRow.Item("anterior"), xRow.Item("activo"), xRow.Item("texto"), xRow.Item("marca"), xRow.Item("year"))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

        

    End Sub

    Private Sub btnCambiar_Click(sender As Object, e As EventArgs) Handles btnCambiar.Click

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable
        Dim comando As New MySql.Data.MySqlClient.MySqlCommand
        Dim transaccionActualizar As MySql.Data.MySqlClient.MySqlTransaction = Nothing
        Dim indexAuto As Integer
        Dim infoCamion As String = ""
        Dim NuevoIdAuto As Integer
        Dim nuevaMarca As String = ""
        Dim nuevoAño As String = ""
        Dim nuevoAtq As String = ""
        Dim nuevoRuta As String = ""
        Dim nuevoTexto As String = ""

        If GridCamiones.Rows.Count = 0 Then
            Return
        End If

        If GridCamiones.CurrentRow Is Nothing Then
            Return
        End If

        If GridCamiones.CurrentRow.Index <= -1 Then
            Return
        End If

        indexAuto = GridCamiones.CurrentRow.Index
        Integer.TryParse(GridCamiones.Rows(indexAuto).Cells(ColIdCamion.Name).Value.ToString, NuevoIdAuto)

        If NuevoIdAuto = 0 Then
            Return
        End If

        With GridCamiones.Rows(indexAuto)
            nuevoAtq = .Cells(ColAtq.Name).Value.ToString
            nuevoRuta = .Cells(ColRuta.Name).Value.ToString
            infoCamion = nuevoAtq & " " & nuevoRuta
            infoCamion &= " " & nuevotexto
            nuevaMarca = .Cells(ColMarca.Name).Value.ToString
            nuevoTexto = .Cells(ColTexto.Name).Value.ToString
            nuevoAño = .Cells(ColAño.Name).Value.ToString
        End With

        comando.Connection = New MySql.Data.MySqlClient.MySqlConnection
        comando.Connection.ConnectionString = con.ConnectionString
        comando.Connection.Open()
        Try
            transaccionActualizar = comando.Connection.BeginTransaction
            comando.Transaction = transaccionActualizar

            consulta = "UPDATE servicios SET ncamion=" & NuevoIdAuto & ", camion='" & infoCamion & "', marca='" & nuevaMarca & "', year = '" & nuevoAño & "', nuevo = '" & nuevoAtq & "',  anterior ='" & nuevoRuta & "'  WHERE id =" & IdServicio
            If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                consulta = "UPDATE servicios_detalle SET nuevo='" & nuevoAtq & "', anterior='" & nuevoRuta & "', idauto = " & NuevoIdAuto & " WHERE folio=" & IdServicio
                If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then
                    consulta = "UPDATE servicios_cotdetalle SET camion=" & NuevoIdAuto & " WHERE id_servicio=" & IdServicio
                    If tool.ActualizarDatosTransaccion(transaccionActualizar, consulta) Then

                        transaccionActualizar.Commit()

                        MsgBox("Actualizado", MsgBoxStyle.Information)
                    Else
                        If MsgBox("¿este servicio no tiene cotizacion desea continuar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            transaccionActualizar.Commit()
                            MsgBox("Actualizado", MsgBoxStyle.Information)
                        Else
                            Throw New Exception("los datos se regresaron a los valores originales")
                        End If
                    End If
                Else
                    Throw New Exception("no se actualizo detalle")
                End If
            Else
                Throw New Exception("no se pudo actualizar servicio")

            End If
        Catch ex As Exception
            If transaccionActualizar IsNot Nothing Then
                If transaccionActualizar.Connection IsNot Nothing Then
                    transaccionActualizar.Rollback()
                End If
            End If
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try
     
    End Sub
End Class