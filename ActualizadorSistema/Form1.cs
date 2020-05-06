using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActualizadorSistema
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool ProcesoEliminado = false;
            
            BoxEventos.Items.Clear();

            try
            {
                string NombreArchivoActualizar = "TallerMecanico.exe";
                string URLaDescargar = @txtUrlArchivo.Text.ToString() + @"\" + NombreArchivoActualizar;
                string NuevaUbicacionArchivo = Application.StartupPath + @"\" + NombreArchivoActualizar;
                BoxEventos.Items.Add("Buscando proceso...");
                foreach (Process p in Process.GetProcesses())
                {

                    if (p.ProcessName == "TallerMecanico")
                    {
                        BoxEventos.Items.Add("Sistema encontrado");
                        try
                        {
                            p.Kill();
                            BoxEventos.Items.Add("Sistema detenido.");
                        }
                        catch (Exception)
                        {

                            BoxEventos.Items.Add("no se pudo detener la app, favor de cerrar y volver a continuar.");
                        }
                        
                        
                        ProcesoEliminado = true;
                    }

                }
                if (ProcesoEliminado)
                {
                    WebClient ArchivoCliente;
                    ArchivoCliente = new WebClient();
                    System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    BoxEventos.Items.Add("Descargando Archivo...");
                    BoxEventos.Items.Add("URL a buscar: " + URLaDescargar);
                    BoxEventos.Items.Add("Nueva ubicación a buscar: " + NuevaUbicacionArchivo);
                    ArchivoCliente.DownloadFile(@URLaDescargar, @NuevaUbicacionArchivo);
                    ArchivoCliente.Dispose();

                    BoxEventos.Items.Add("Sistema Actualizado correctamente");
                    MessageBox.Show("Sistema Actualizado", "App", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("No se encontro el sistema para Actualizarlo", "App", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                BoxEventos.Items.Add("Error 1: " +  ex.Message);
                if (ex.Source != null)
                {
                    BoxEventos.Items.Add("Error 3: " + ex.Source);
                }
                
                
            }





        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
