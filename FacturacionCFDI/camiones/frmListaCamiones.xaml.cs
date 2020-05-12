using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace FacturacionCFDI.camiones
{
    /// <summary>
    /// Lógica de interacción para frmListaCamiones.xaml
    /// </summary>
    public partial class frmListaCamiones : Page
    {
        public frmListaCamiones()
        {
            InitializeComponent();
        }
        private class camposBuscar
        {
            public paramsBuscar campos { get; set; }
        }
        private class paramsBuscar
        {
            public string atq { get; set; }
            public string ruta { get; set; }
            public string marca { get; set; }
            public string anio { get; set; }
            public int activo { get; set; }
        }
        private void BtnObtenerCamiones_Click(object sender, RoutedEventArgs e)
        {
            FacturacionCFDI.BDH.Herramienta herramienta = new BDH.Herramienta();
            Stopwatch sw = new Stopwatch();
            List<Modelo.CamionModel> listaCamiones = new List<Modelo.CamionModel>();
            string ResultadoConsulta = string.Empty;
            try
            {
                sw.Start();
                camposBuscar @params = new camposBuscar();
                string Datos = string.Empty;
                @params.campos = new paramsBuscar();
                @params.campos.atq = txtATQ.Text;
                @params.campos.ruta = txtRuta.Text;
                
                @params.campos.activo = (CheckActivo.IsChecked == true ? 1 : 0);
                Datos = JsonConvert.SerializeObject(@params);
                
                ResultadoConsulta = herramienta.LeerTablaPOST("camiones/buscar", Datos);
                //return;
                if (ResultadoConsulta != string.Empty)
                {
                    listaCamiones = JsonConvert.DeserializeObject<List<Modelo.CamionModel>>(ResultadoConsulta);
                }
                if (listaCamiones != null)
                {
                    BoxCamiones.ItemsSource = listaCamiones;
                }
                sw.Stop();
                lbltiempo.Content = "Tiempo: " + sw.ElapsedMilliseconds.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnVerOpciones_Click(object sender, RoutedEventArgs e)
        {
            Button botonOpciones = sender as Button;
            if (botonOpciones == null)
            {
                return;
            }
            ContextMenu cm =  botonOpciones.ContextMenu;
            if (cm != null)
            {
                cm.PlacementTarget = sender as Button;
                cm.IsOpen = true;
            }
            
        }
    }
}
