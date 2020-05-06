Public Class frmFacturaAbonar

    Dim GridIndex As Integer
    Dim vEsNotaCredito As Boolean
    Dim vAbonoMaximo As Decimal
    Public valorNuevoAbonar As Decimal
    Public Sub New(indexGrid As Integer, ByVal abonoMaximo As Decimal, esNotaCredito As Boolean, ByVal folio As String)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        GridIndex = indexGrid
        vEsNotaCredito = esNotaCredito
        vAbonoMaximo = abonoMaximo
        lblFolio.Text = folio.ToArray
        lblSaldoPendiente.Text = abonoMaximo.ToString
        Try
            NAbonar.Value = abonoMaximo
        Catch ex As Exception

        End Try
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub frmFacturaAbonar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        NAbonar.Focus()
        NAbonar.Select()

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        If NAbonar.Value = 0 Then
            MsgBox("el valor a abonar debe ser diferente de cero", MsgBoxStyle.Exclamation)
            Return
        End If

        If vEsNotaCredito Then
            If NAbonar.Value > 0 Then
                MsgBox("En Notas de credito, debe ser menor a cero", MsgBoxStyle.Exclamation)
                Return
            End If
            If NAbonar.Value < vAbonoMaximo Then
                MsgBox("En Notas de credito, debe ser mayor o igual a " & vAbonoMaximo.ToString, MsgBoxStyle.Exclamation)
                Return
            End If
        Else
            If NAbonar.Value > vAbonoMaximo Then
                MsgBox("En Facturas, debe ser menor o igual a " & vAbonoMaximo.ToString, MsgBoxStyle.Exclamation)
                Return
            End If
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        valorNuevoAbonar = NAbonar.Value
        Me.Close()

    End Sub
End Class