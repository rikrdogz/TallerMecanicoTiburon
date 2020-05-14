using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
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

namespace FacturacionCFDI.Cotizacion
{
    /// <summary>
    /// Lógica de interacción para frmListaCotizaciones.xaml
    /// </summary>
    public partial class frmListaCotizaciones : Page
    {
        public frmListaCotizaciones()
        {
            InitializeComponent();
        }

        private void BtnObtenerFacturas_Click(object sender, RoutedEventArgs e)
        {
            BDH.Herramienta herramienta = new BDH.Herramienta();
            Stopwatch sw = new Stopwatch();
            
            string ResultadoConsulta = string.Empty;
            this.Cursor = Cursors.AppStarting;
              
            
            sw.Start();
            ResultadoConsulta = herramienta.LeerTabla("cotizacion/listacotizaciones");
            //ResultadoConsulta = herramienta.RevisarTiemposAPI("cotizacion/listacotizaciones");


            if (ResultadoConsulta != string.Empty)
            {
                //existe resultado
                try
                {
                    List<Modelo.CotizacionModel> listaCotizaciones = JsonConvert.DeserializeObject<List<Modelo.CotizacionModel
                    >>(ResultadoConsulta);
                    GridCotizaciones.ItemsSource = listaCotizaciones;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
            sw.Stop();
            lbltiempo.Content = "Tiempo: " + sw.ElapsedMilliseconds.ToString();
            this.Cursor = Cursors.Arrow;

        }

        private void BtnFacturarCot_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Button btnCotInfo = (Button)sender;
                List<Modelo.CotizacionModel> listaCotizacionesSource = (List<Modelo.CotizacionModel>)GridCotizaciones.ItemsSource;
                Modelo.CotizacionModel cotizacion = (Modelo.CotizacionModel)btnCotInfo.DataContext;
                cotizacion.camion = "MODIFICADO";
                //listaCotizacionesSource.Add(new Modelo.CotizacionModel() { nuevo = "x1", camion = "nuevo", numero = 16 });
                CollectionViewSource.GetDefaultView(GridCotizaciones.ItemsSource).Refresh();
                // Facturas.frmFacturarCotizacion frmFacturar 
                if (cotizacion != null)
                {
                    MainWindow xMain = Window.GetWindow(this) as MainWindow;
                    xMain._MainFrame.Navigate(new Facturas.frmFacturarCotizacion(cotizacion));
                }
                else
                {
                    MessageBox.Show("El modelo esta vacio");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            

        }

        private void BtnVerClientes_Click(object sender, RoutedEventArgs e)
        {
            MainWindow xMain = Window.GetWindow(this) as MainWindow;
            xMain._MainFrame.Navigate(new ClientesCFDI.frmListaClientesCFDI());
        }
    }
}
