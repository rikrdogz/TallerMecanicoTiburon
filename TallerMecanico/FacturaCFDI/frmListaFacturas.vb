Imports System.IO
Imports System.Net
Imports Newtonsoft.Json
Public Class frmListaFacturas

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub btnObtenerFacturas_Click(sender As Object, e As EventArgs) Handles btnObtenerFacturas.Click
        Dim respuesta As HttpWebRequest

        Try

            respuesta = WebRequest.Create("http://devfactura.in/api/v3/cfdi33/list")
            respuesta.ContentType = "application/json"
            respuesta.Headers.Add("F-PLUGIN", "9d4095c8f7ed5785cb14c0e3b033eeb8252416ed")
            respuesta.Headers.Add("F-API-KEY", "JDJ5JDEwJDkvM21jRTlEdXJkY2pGRmJMdVlCQ2V1MWJxendHMnR2QXhWdE5IOXZlOVN6WEV2enY3Smxp")
            respuesta.Headers.Add("F-SECRET-KEY", "JDJ5JDEwJG1jMUduQWdNMzcuLnRLTGU2L1Bjb2VXMS5WUnVuOXouei9ydjlxSktyUjVQSjMuS2puTmxD")

            Using response As HttpWebResponse = respuesta.GetResponse
                Using stream As Stream = response.GetResponseStream()
                    Using reader As StreamReader = New StreamReader(stream)
                        Dim json = reader.ReadToEnd
                        Dim ResultadoConsulta = JsonConvert.DeserializeObject(Of ModeloJsonRespuesta)(json)


                        If ResultadoConsulta.data IsNot Nothing Then

                            GridFacturas.DataSource = ResultadoConsulta.data
                            GridFacturas.Refresh()

                        End If

                        
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ImagenUrl As New WebClient
        Try
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12
            ImagenUrl.DownloadFile("https://media.sproutsocial.com/uploads/2017/02/10x-featured-social-media-image-size.png", Application.StartupPath.ToString & "\Imagen.png")
            ImagenUrl.Dispose()

            PictureBox1.ImageLocation = Application.StartupPath.ToString & "\Imagen.png"
            PictureBox1.Load()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim AbrirArchivo As New OpenFileDialog
        Dim NombreArchivoSubir As String
        If AbrirArchivo.ShowDialog() = DialogResult.OK Then
            NombreArchivoSubir = AbrirArchivo.FileName
            Dim urlSubir As String
            urlSubir = "ftp.vidachiapas.com/public_html/imagestiburon/" & NombreArchivoSubir
            Dim procesoFTP As FtpWebRequest = FtpWebRequest.Create(urlSubir)
            procesoFTP.Method = WebRequestMethods.Ftp.UploadFile
            procesoFTP.Credentials = New NetworkCredential("vidachia", "")

        End If

        
    End Sub
End Class