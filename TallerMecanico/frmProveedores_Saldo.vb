Public Class frmProveedores_Saldo

    Private Sub frmProveedores_Saldo_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()

        End If
    End Sub

    Private Sub frmProveedores_Saldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        estructura_ventana(Me)
        Cargar_Provedores()
    End Sub
    Public Sub Cargar_Provedores()
        Dim agregar As Boolean = True
        Dim consulta As String = ""
        Dim tool As New Herramienta
        Dim tablaResultado As New DataTable

        Try

            consulta = "SELECT idproveedor, proveedor,total FROM factura WHERE estado='PENDIENTE' order by idproveedor"
            tablaProveedor.Rows.Clear()
            tablaResultado = tool.ObtenerTabla(consulta)
            If tablaResultado.Rows.Count > 0 Then
                For Each xRow As DataRow In tablaResultado.Rows
                    If tablaProveedor.Rows.Count = 0 Then
                        tablaProveedor.Rows.Add(xRow.Item("idproveedor"), xRow.Item("proveedor"))

                    Else
                        For i = 0 To tablaProveedor.Rows.Count - 1
                            If Not tablaProveedor.Rows(i).Cells("idproveedor").Value = xRow.Item("idproveedor") Then
                                agregar = True
                            Else
                                agregar = False
                            End If
                        Next
                        If agregar Then
                            tablaProveedor.Rows.Add(xRow.Item("idproveedor"), xRow.Item("proveedor"))
                        End If
                    End If
                Next
            End If
            Sumar_Saldos()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub
    Private Sub Sumar_Saldos()
        Dim sumar As Decimal
        Dim consulta As String = ""
        Dim tool As New Herramienta
        Dim tablaResultado As New DataTable

        If tablaProveedor.Rows.Count > 0 Then
            Try
                For Each xRowProveedor As DataGridViewRow In tablaProveedor.Rows
                    sumar = 0

                    consulta = "SELECT * from facturas WHERE "
                    For Each xRow As DataGridViewRow In tabla_Factura.Rows
                        sumar += Val(xRow.Cells(ColTotalFac.Name).Value)
                    Next
                Next
               

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Exclamation)
            End Try
        End If

    End Sub

    Private Sub tablaProveedor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaProveedor.CellClick

    End Sub

    Private Sub tablaProveedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablaProveedor.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cargar_Provedores()
    End Sub


    Private Sub tablaProveedor_SelectionChanged(sender As Object, e As EventArgs) Handles tablaProveedor.SelectionChanged

        Dim consulta As String = ""
        Dim tool As New Herramienta
        Dim tablaResultado As New DataTable

        If tablaProveedor.Rows.Count > 0 Then
            If tablaProveedor.SelectedCells.Count > 0 And datos.IsClosed Then
                Dim i As Integer = tablaProveedor.CurrentRow.Index
                Try

                    consulta = "SELECT * FROM factura WHERE idproveedor=" & tablaProveedor.Rows(i).Cells("idproveedor").Value & " AND estado='PENDIENTE'"
                    tabla_Factura.Rows.Clear()
                    tablaResultado = tool.ObtenerTabla(consulta)
                    If tablaResultado.Rows.Count > 0 Then
                        For Each xRow As DataRow In tablaResultado.Rows
                            tabla_Factura.Rows.Add(xRow.Item("id"), xRow.Item("folio"), xRow.Item("total"), xRow.Item("observacion"), xRow.Item("fecha"))
                        Next
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Information)
                End Try
            End If

        End If
    End Sub
End Class