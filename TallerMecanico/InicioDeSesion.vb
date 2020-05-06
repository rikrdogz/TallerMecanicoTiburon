Imports System.Data.OleDb
Public Class InicioDeSesion
    Dim CONEX As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\bd\conexion.mdb;Persist Security Info=False;Jet OLEDB:Database Password=ricardo777")
    Dim COMANDO As New OleDbCommand
    Dim registro As OleDbDataReader
    Private listaUser As New List(Of String)
    Private listaPASS As New List(Of String)
    Private listaBD As New List(Of String)

    Public tablaid As New List(Of Integer)
    Private TablaUsuario As New List(Of String)
    Public tablaPass As New List(Of String)
    Dim t As Integer = 0

    Private Sub InicioDeSesion_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        con.Close()

    End Sub

    Private Sub InicioDeSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar_bd()


        mostrar_users()
        CbData.SelectedIndex = 0
        CBUsuario.Focus()

    End Sub
    Private Sub conectar_bd()
        Try

            CONEX.Open()


        Catch ex As Exception
            lblinfo.Text = "Conexion no establecida, compruebe el archivo | Basededatos |"

        End Try
    End Sub
    Private Sub mostrar_users()

        Try

            ' CONEX.Open()
            COMANDO.Connection = CONEX

            COMANDO.CommandText = "SELECT * FROM config"


            registro = COMANDO.ExecuteReader
            If registro.HasRows Then
                While registro.Read

                    listaUser.Add(registro("user"))
                    listaPASS.Add(registro("pass").ToString)
                    CbData.Items.Add(registro("servidor"))
                    listaBD.Add(registro("bd"))
                End While
            End If
            registro.Close()
            COMANDO.CommandText = "SELECT valor FROM licencia where id=1"
            registro = COMANDO.ExecuteReader
            If registro.HasRows Then
                While registro.Read
                    If registro("valor") = 0 Then
                        MsgBox("Licencia de Software a Caducado!", MsgBoxStyle.Critical)
                        End
                    End If
                    If registro("valor") = 1 Then
                        MsgBox("Licencia de Software por expirar!", MsgBoxStyle.Critical)
                    End If
      

                End While

            End If
            If Not registro.IsClosed Then registro.Close()


        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click
        Dim IdUsuario As Integer

        If CbData.SelectedIndex >= 0 Then
            If CBUsuario.SelectedIndex >= 0 Or CBUsuario.Text.Length > 0 Then

                Try
                    IdUsuario = ValidarInicioSession()

                    barra.Show()
                    M_server = CbData.Text
                    M_user = listaUser.Item(CbData.SelectedIndex)
                    M_pass = listaPASS.Item(CbData.SelectedIndex)
                    M_data = listaBD.Item(CbData.SelectedIndex)

                    MDIPrincipal.lblidUser.Text = IdUsuario
                    MDIPrincipal.TabPage.TabPages.Clear()

                    VisualizarPestañas(LeerPermisosUsuario(IdUsuario))
                    conectar()
                    Me.Hide()

                    MDIPrincipal.lblUser.Text = CBUsuario.Text
                    If CbData.SelectedIndex <> 0 Then
                        MDIPrincipal.tiempo.Start()
                    Else
                        MDIPrincipal.tiempo.Stop()

                    End If
                    CBUsuario.Focus()
                    MDIPrincipal.Show()
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Permiso / Usuario")
                End Try


             
            Else
                CBUsuario.Focus()
            End If

        End If

    End Sub

    Private Function ValidarInicioSession() As Integer

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResulado As New DataTable
        Dim IdUsuario As Integer

        consulta = "SELECT id FROM usuarios WHERE name='" & CBUsuario.Text & "' AND pass ='" & txtPass.Text & "'"
        tablaResulado = tool.ObtenerTabla(consulta)
        If tablaResulado.Rows.Count > 0 Then
            Integer.TryParse(tablaResulado.Rows(0).Item("id").ToString, IdUsuario)
        Else
            Throw New Exception("El usuario / Contraseña no son correctos")
        End If

        Return IdUsuario
    End Function

    Private Sub VisualizarPestañas(ByVal UsuarioPermiso As UsuarioPermisoModel)

        MDIPrincipal.TabPage.TabPages.Clear()

        If UsuarioPermiso.pfacturas Then MDIPrincipal.TabPage.TabPages.Add(MDIPrincipal.tabFacturas)
        If UsuarioPermiso.particulos Then MDIPrincipal.TabPage.TabPages.Add(MDIPrincipal.tabArticulos)

        If UsuarioPermiso.ptermogas Then MDIPrincipal.TabPage.TabPages.Add(MDIPrincipal.TabTermo)
        If UsuarioPermiso.pconfiguracion Then MDIPrincipal.TabPage.TabPages.Add(MDIPrincipal.TabConfigurar)
        If UsuarioPermiso.pmodificarfac Then
            MDIPrincipal.TabPage.TabPages.Add(MDIPrincipal.TabCFDI)
        Else
            MDIPrincipal.btnPagar.Hide()
            MDIPrincipal.BtnPagos.Hide()
            MDIPrincipal.btnDeudas.Hide()
            MDIPrincipal.btnAgregar_prov.Hide()
            frmProveedores.btnagregar.Hide()
            frmProveedores.btnEdit.Hide()
            Facturas.btnCancelarFAC.Hide()
            Facturas.btnINV.Hide()
            frmServicio.btnCambiarATQ.Hide()
        End If

        If Not UsuarioPermiso.pusuarios Then
            MDIPrincipal.btnUsuarios.Hide()
            frmServicio.btnCambiarATQ.Hide()
            frmAutos.btnCotizar.Hide()
        End If


    End Sub

    Private Function LeerPermisosUsuario(IdUsuario As Integer) As UsuarioPermisoModel

        Dim tool As New Herramienta
        Dim consulta As String = ""
        Dim tablaResultado As New DataTable
        Dim UsuarioPermiso As New UsuarioPermisoModel

        If IdUsuario = 0 Then
            Throw New Exception("No se establecio IdUsuario")
        End If

        consulta = "SELECT pfacturas, particulos, ptermogas, pconfiguracion, pmodificarfac, pusuarios FROM usuarios WHERE id=" & IdUsuario
        tablaResultado = tool.ObtenerTabla(consulta)

        If tablaResultado.Rows.Count > 0 Then
            With UsuarioPermiso
                .IdUsuario = IdUsuario
                .particulos = tablaResultado.Rows(0).Item("particulos")
                .pconfiguracion = tablaResultado.Rows(0).Item("pconfiguracion")
                .pfacturas = tablaResultado.Rows(0).Item("pfacturas")
                .ptermogas = tablaResultado.Rows(0).Item("ptermogas")
                .pmodificarfac = tablaResultado.Rows(0).Item("pmodificarfac")
                .pusuarios = tablaResultado.Rows(0).Item("pusuarios")
            End With

            Return UsuarioPermiso
        End If

        Return Nothing

    End Function
    Private Sub txtPass_GotFocus(sender As Object, e As EventArgs) Handles txtPass.GotFocus
        txtPass.BackColor = Color.White
    End Sub

    Private Sub txtPass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            If txtPass.TextLength > 0 Then
                btnaceptar.PerformClick()
            End If
        End If
    End Sub

    Private Sub CBUsuario_DrawItem(sender As Object, e As DrawItemEventArgs) Handles CBUsuario.DrawItem
        e = New DrawItemEventArgs(e.Graphics, e.Font, e.Bounds, e.Index, e.State, e.ForeColor, Color.DarkBlue)
    End Sub

    Private Sub CBUsuario_GotFocus(sender As Object, e As EventArgs) Handles CBUsuario.GotFocus
        CBUsuario.BackColor = Color.White
    End Sub



    Private Sub CBUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBUsuario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            e.Handled = True
            If CBUsuario.SelectedIndex >= 0 Then
                txtPass.Focus()

            End If
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        End
    End Sub
    Private Sub Iniciar_conexion()
        If CbData.SelectedIndex >= 0 Then
            M_server = CbData.Text
            M_user = listaUser.Item(CbData.SelectedIndex)
            M_pass = listaPASS.Item(CbData.SelectedIndex)
            M_data = listaBD.Item(CbData.SelectedIndex)
            leer_user()
            CBUsuario.Focus()
        End If
    End Sub
    Private Sub tiempo_Tick(sender As Object, e As EventArgs) Handles tiempo.Tick
        t += 1
        If t = 3 Then
            Iniciar_conexion()
        End If
        If t = 10 Then
            ingresoPanel.Visible = True
            tiempo.Stop()

        End If
    End Sub

    Private Sub CbData_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbData.SelectedIndexChanged
        If t > 2 Then
            Iniciar_conexion()
        End If

    End Sub

    Private Sub InicioDeSesion_Shown(sender As Object, e As EventArgs) Handles Me.Shown
 

    End Sub

    Private Sub CBUsuario_LostFocus(sender As Object, e As EventArgs) Handles CBUsuario.LostFocus
        CBUsuario.BackColor = Color.Gainsboro

    End Sub

    Private Sub CBUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBUsuario.SelectedIndexChanged

    End Sub

    Private Sub txtPass_LostFocus(sender As Object, e As EventArgs) Handles txtPass.LostFocus
        txtPass.BackColor = Color.Gainsboro

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        btnConnect.Hide()
        conectar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        respaldar("inicio")
    End Sub

    Private Sub LinkActualizarSistema_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkActualizarSistema.LinkClicked
        Process.Start(Application.StartupPath & "\ActualizadorSistema.exe")

    End Sub
End Class