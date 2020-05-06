Public Class MDIPrincipal
    Dim t As Integer = 0
    Private Sub MDIPrincipal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        con.Close()

        End
    End Sub

    Private Sub MDIPrincipal_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'If MessageBox.Show("¿Desea Cerrar el SISTEMA TIBURON?", "CERRAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
        '    MsgBox("respaldando base de datos...espere")
        '    respaldar("sist_cerrado")
        '    MsgBox("el programa se cerrará", MsgBoxStyle.Information)
        'Else

        '    e.Cancel = True
        'End If
    End Sub

    Private Sub MDIPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        codigo_viejo()
        btnFacturas.Focus()


    End Sub
    Private Sub codigo_viejo()
        Dim ctl As Control
        Dim ctlMDI As MdiClient

        ' Loop through all of the form's controls looking
        ' for the control of type MdiClient.
        For Each ctl In Me.Controls
            Try
                ' Attempt to cast the control to type MdiClient.
                ctlMDI = CType(ctl, MdiClient)

                ' Set the BackColor of the MdiClient control.
                ctlMDI.BackColor = Me.BackColor

            Catch exc As InvalidCastException
                ' Catch and ignore the error if casting failed.
            End Try
        Next



        ' Display a child form to show this is still an MDI application.
        'Dim frm As New pendientes()
        'frm.MdiParent = Me
        'frm.Show()
    End Sub


    Private Sub FACTURASToolStripMenuItem_Click(sender As Object, e As EventArgs)
        For Each Todaventana As Form In Me.MdiChildren
            Todaventana.WindowState = FormWindowState.Minimized
        Next
        Facturas.MdiParent = Me
        Facturas.Width = Me.Width - 4
        Facturas.Height = Me.Height - TabPage.Height
        Facturas.Show()
        Facturas.WindowState = FormWindowState.Normal
    End Sub

    Private Sub toolInfo_Click(sender As Object, e As EventArgs)

    End Sub
    Public Sub CerrarVentanas()
        For Each Todaventana As Form In Me.MdiChildren
            Todaventana.WindowState = FormWindowState.Minimized
        Next
    End Sub

    Private Sub ALTAPROVEEDORESToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnFacturas_Click(sender As Object, e As EventArgs) Handles btnFacturas.Click


        For Each Todaventana As Form In Me.MdiChildren
            If Not Todaventana.Name = "Facturas" Then
                Todaventana.WindowState = FormWindowState.Minimized
            End If

        Next
        Facturas.MdiParent = Me
        Facturas.Width = ventana_ancho
        Facturas.Height = ventana_alto

        Facturas.Show()
        Facturas.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each Todaventana As Form In Me.MdiChildren
            Todaventana.WindowState = FormWindowState.Minimized
        Next
        frmArticuloAgregar.MdiParent = Me
        frmArticuloAgregar.Width = ventana_ancho
        frmArticuloAgregar.Height = ventana_alto
        frmArticuloAgregar.Show()
        frmArticuloAgregar.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For Each Todaventana As Form In Me.MdiChildren
            Todaventana.WindowState = FormWindowState.Minimized
        Next
        frmArticulos.MdiParent = Me
        frmArticulos.Width = ventana_ancho
        frmArticulos.Height = ventana_alto
        frmArticulos.Show()
        frmArticulos.WindowState = FormWindowState.Normal

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        For Each Todaventana As Form In Me.MdiChildren
            Todaventana.WindowState = FormWindowState.Minimized
        Next
        frmAutos.MdiParent = Me
        'frmAutos.Width = ventana_ancho
        'frmAutos.Height = ventana_alto
        frmAutos.Show()
        frmAutos.WindowState = FormWindowState.Normal



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
        For Each Todaventana As Form In Me.MdiChildren
            Todaventana.WindowState = FormWindowState.Minimized
        Next
        frmFacturasPagar.MdiParent = Me
        frmFacturasPagar.Width = ventana_ancho
        frmFacturasPagar.Height = ventana_alto
        frmFacturasPagar.Show()
        frmFacturasPagar.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnFacturasAgregar_Click(sender As Object, e As EventArgs) Handles btnFacturasAgregar.Click
        FacturasSelectProveedor.Dispose()
        For Each Todaventana As Form In Me.MdiChildren

            Todaventana.WindowState = FormWindowState.Minimized


        Next
        FacturasSelectProveedor.lblVentana.Text = "FAC"

        FacturasSelectProveedor.ShowDialog()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnAgregar_prov.Click
        For Each Todaventana As Form In Me.MdiChildren
            Todaventana.WindowState = FormWindowState.Minimized
        Next
    
        frmProveedorAgregar.Show()
        frmProveedorAgregar.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnBuscarNP_Click(sender As Object, e As EventArgs) Handles btnBuscarNP.Click
        For Each Todaventana As Form In Me.MdiChildren
            Todaventana.WindowState = FormWindowState.Minimized
        Next
        frmFacturasBuscarNP.MdiParent = Me
        frmFacturasBuscarNP.Width = ventana_ancho
        frmFacturasBuscarNP.Height = ventana_alto
        frmFacturasBuscarNP.Show()
        frmFacturasBuscarNP.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For Each Todaventana As Form In Me.MdiChildren
            Todaventana.WindowState = FormWindowState.Minimized
        Next
        frmServicio.MdiParent = Me
        frmServicio.Width = ventana_ancho
        frmServicio.Height = ventana_alto
        frmServicio.Show()
        frmServicio.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnproveedores.Click
        For Each Todaventana As Form In Me.MdiChildren
            Todaventana.WindowState = FormWindowState.Minimized
        Next
        frmProveedores.MdiParent = Me
        frmProveedores.Show()
        frmProveedores.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles BtnPagos.Click
        For Each Todaventana As Form In Me.MdiChildren
            Todaventana.WindowState = FormWindowState.Minimized
        Next
        frmFacturas_Pagados.MdiParent = Me
        frmFacturas_Pagados.Width = ventana_ancho
        frmFacturas_Pagados.Height = ventana_alto

        frmFacturas_Pagados.CargarFolios()


        frmFacturas_Pagados.Show()
        frmFacturas_Pagados.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnDeudas.Click
        For Each Todaventana As Form In Me.MdiChildren
            Todaventana.WindowState = FormWindowState.Minimized
        Next
        frmProveedores_Saldo.MdiParent = Me


        frmProveedores_Saldo.Width = ventana_ancho
        frmProveedores_Saldo.Height = ventana_alto
        frmProveedores_Saldo.Show()
        frmProveedores_Saldo.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnNota_Click(sender As Object, e As EventArgs) Handles btnNota.Click
        FacturasSelectProveedor.Dispose()
        FacturasSelectProveedor.lblVentana.Text = "NOTA"
        FacturasSelectProveedor.ShowDialog()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs)
        'frmservicios_Cot.Show()
        conectar()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        For Each Todaventana As Form In Me.MdiChildren
            Todaventana.WindowState = FormWindowState.Minimized
        Next
        frmCotizacion.MdiParent = Me
        frmCotizacion.Width = ventana_ancho
        frmCotizacion.Height = ventana_alto
        frmCotizacion.Show()
        frmCotizacion.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        For Each Todaventana As Form In Me.MdiChildren
            Todaventana.WindowState = FormWindowState.Minimized
        Next
        frmInventario.MdiParent = Me
        frmInventario.Width = ventana_ancho
        frmInventario.Height = ventana_alto
        frmInventario.Show()
        frmInventario.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        For Each Todaventana As Form In Me.MdiChildren
            Todaventana.WindowState = FormWindowState.Minimized
        Next
        frmReportes.MdiParent = Me
        frmReportes.Width = ventana_ancho
        frmReportes.Height = ventana_alto
        frmReportes.Show()
        frmReportes.WindowState = FormWindowState.Normal
    End Sub


    Private Sub btnMantenimiento_Click(sender As Object, e As EventArgs) Handles btnMantenimiento.Click
   
    End Sub


    Private Sub lblestado_Click(sender As Object, e As EventArgs) Handles lblestado.Click
        frmInfo.ShowDialog()

    End Sub



    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        con.Close()
        Me.Hide()
        InicioDeSesion.CBUsuario.SelectedIndex = -1
        InicioDeSesion.txtPass.Clear()
        InicioDeSesion.barra.Value = 0
        InicioDeSesion.Show()
        InicioDeSesion.CBUsuario.Focus()

    End Sub

    Private Sub tiempo_Tick(sender As Object, e As EventArgs) Handles tiempo.Tick
        t += 1
        If M_data <> "sistematiburon" Then
            If t = 4 Then
                Panel1.BackColor = Color.Yellow
                t = 0
            Else
                Panel1.BackColor = Color.White
            End If
           
        Else
            Panel1.BackColor = Color.FromArgb(41, 53, 65)
        End If
       

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        For Each Todaventana As Form In Me.MdiChildren

            Todaventana.WindowState = FormWindowState.Minimized
        Next
        frmUltimosMov.MdiParent = Me
        frmUltimosMov.Show()
        frmUltimosMov.WindowState = FormWindowState.Normal
    End Sub

    Private Sub btnConfigIVA_Click(sender As Object, e As EventArgs) Handles btnConfigIVA.Click
        frmConfig.Show()

    End Sub

    Private Sub btnUltimosServicios_Click(sender As Object, e As EventArgs) Handles btnUltimosServicios.Click
        For Each Todaventana As Form In Me.MdiChildren

            Todaventana.WindowState = FormWindowState.Minimized
        Next
        frmUltimosServicios.MdiParent = Me
        frmUltimosServicios.Show()
        frmUltimosMov.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        frmUsuario.ShowDialog()

    End Sub

    Private Sub btnCfdiListaFacturas_Click(sender As Object, e As EventArgs) Handles btnCfdiListaFacturas.Click
        For Each Todaventana As Form In Me.MdiChildren

            Todaventana.WindowState = FormWindowState.Minimized
        Next
        frmListaFacturas.MdiParent = Me
        frmListaFacturas.Show()
        frmListaFacturas.WindowState = FormWindowState.Normal
    End Sub
End Class
