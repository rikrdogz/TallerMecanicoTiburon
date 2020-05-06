Imports System.Net
Imports System.Net.Mail
Imports System.IO

Public Class frmEnviarCotizacion
    Dim SMTP_correo As New SmtpClient
    Dim Email As String = ""
    Dim PassWord As String = ""
    Dim CorreoCliente As String = String.Empty

    Dim NombreDelCorreo As String = String.Empty

    Public Sub New(NumeroCotizacion As Integer, ByVal ATQ As String, ByVal TextoAnterior As String, ByVal RutaAnterior As String)

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        lblNumCotizacion.Text = NumeroCotizacion
        txtAsunto.Text = "COTIZACIÓN " & lblNumCotizacion.Text & " | ATQ " & ATQ & " " & TextoAnterior & " " & RutaAnterior
        txtCuerpoCorreo.Text = "Buen día, adjunto cotización " & lblNumCotizacion.Text
        ObtenerDatosSMTP()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub EnviarCotizacion()

        btnEnviar.Enabled = False
        Dim Credenciales As NetworkCredential
        Dim ArchivoAdjunto As Attachment
        Dim CuerpoCorreo As New MailMessage
        Dim UbicacionArchivo As String
        Try

            Credenciales = New NetworkCredential()
            Credenciales.UserName = Email
            Credenciales.Password = PassWord
            SMTP_correo.Credentials = New NetworkCredential(Email, PassWord)
            CuerpoCorreo.From = New MailAddress(Email, NombreDelCorreo)
            CuerpoCorreo.Sender = New MailAddress(Email, NombreDelCorreo)
            CuerpoCorreo.To.Add(CorreoCliente)
            CuerpoCorreo.Subject = txtAsunto.Text
            CuerpoCorreo.Body = txtCuerpoCorreo.Text

            'Adjuntar archivo
            UbicacionArchivo = Application.StartupPath & "\cot\cot" & lblNumCotizacion.Text & ".xlsx"
            If Not File.Exists(UbicacionArchivo) Then
                MessageBox.Show("No se encontro el archivo para adjuntar en el correo: " & UbicacionArchivo, "Problemas Archivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            ArchivoAdjunto = New Attachment(UbicacionArchivo)
            CuerpoCorreo.Attachments.Add(ArchivoAdjunto)

            SMTP_correo.Send(CuerpoCorreo)
            MessageBox.Show("Correo enviado, favor revisar en su correo la seccion de ENVIADOS", "Correo", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Problema de onterner información de correo")
            btnEnviar.Enabled = True
        End Try

    End Sub
    Private Sub ObtenerDatosSMTP()

        Dim consulta As String = ""
        Dim tool As New Herramienta
        Dim tablaResultado As New DataTable

        Try
            consulta = "SELECT * FROM config_correo"
            tablaResultado = tool.ObtenerTabla(consulta)

            'Es SSL
            SMTP_correo.EnableSsl = True

            For Each xRow As DataRow In tablaResultado.Rows
                Select Case xRow.Item("codigo")
                    Case "CORREO_SERVIDOR"
                        SMTP_correo.Host = xRow.Item("Valor").ToString
                    Case "CORREO_PUERTO"
                        SMTP_correo.Port = xRow.Item("Valor").ToString
                    Case "CORREO_SMTP"
                        Email = xRow.Item("Valor").ToString
                    Case "CORREO_CONTRA"
                        PassWord = xRow.Item("Valor").ToString
                    Case "CORREO_PARA"
                        CorreoCliente = xRow.Item("Valor").ToString
                    Case "CORREO_NOMBRE"
                        NombreDelCorreo = xRow.Item("Valor").ToString
                End Select
            Next

            lblCorreoDe.Text = Email
            lblCorreo.Text = CorreoCliente


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Problema de onterner información de correo")
        End Try



    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub frmEnviarCotizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click

        If MessageBox.Show("¿Desea enviar por correo la cotización?", "Envio de correo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            EnviarCotizacion()
        End If

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class