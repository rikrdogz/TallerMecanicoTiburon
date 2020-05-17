using FacturacionCFDI.Facturas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace FacturacionCFDI.configuracion
{
    /// <summary>
    /// Lógica de interacción para frmConfigTodogas.xaml
    /// </summary>
    public partial class frmConfigTodogas : Page
    {
        public  frmConfigTodogas()
        {
            InitializeComponent();
            //ObtenerClientes();
            TareasInformacion();
            //ObtenerSeriesCFDI();
            //ObtenerIvas();
            //leerconfigtodogas();
        }
        private class DatosGuardarJson
        {
            public DatosDetalleJson campos { get; set; }
        }
        private class DatosDetalleJson
        {
            public Modelo.ClienteCFDIModel cliente { get; set; }
            public Facturas.SerieCFDIModel serie { get; set; }
            public Modelo.CfdiIvaModel IvaCfdi { get; set; }
        }
        private async void TareasInformacion()
        {
            var detalleInfo = await Task.Run(() =>
            {
                return leerconfigtodogas();
            });
            if (detalleInfo.cliente != null)
            {
                txtUIDCliente.Text = detalleInfo.cliente.UID;
                lblRazonSocial.Content = detalleInfo.cliente.RazonSocial;
                lblRFC.Content = detalleInfo.cliente.RFC;
            }
            if (detalleInfo.serie != null)
            {
                lblSerieNombre.Content = detalleInfo.serie.SerieName;
                txtFolioID.Text = detalleInfo.serie.SerieID.ToString();
            }
            StackCargandoInfo.Visibility = Visibility.Collapsed;
            StackInforCargada.Visibility = Visibility.Visible;

            var dataCliente = await Task.Run(() =>
            {
               return  ObtenerClientes();
            });
            BoxClientes.ItemsSource = dataCliente.data;
            var dataSerie = await Task.Run(() =>
            {
                return ObtenerSeriesCFDI();
            });
            BoxSeries.ItemsSource = dataSerie.data;

            var cfdiListaIva = await Task.Run(() =>
            {
                return ObtenerIvas();
            });
            BoxIva.ItemsSource = cfdiListaIva;
            BoxIva.SelectedValue = detalleInfo.IvaCfdi.valor_iva;
            
        }
        private DatosDetalleJson leerconfigtodogas()
        {
            DatosDetalleJson datosDetalle = new DatosDetalleJson();
            
            Modelo.ClienteCFDIModel cliente;
            Facturas.SerieCFDIModel serie;
            Modelo.CfdiIvaModel ivaModel;
            string resultado = string.Empty;
            BDH.Herramienta herramienta = new BDH.Herramienta();
            try
            {
                resultado = herramienta.LeerTabla("cfdi/leerconfigtodogas");
                cliente = JsonConvert.DeserializeObject<Modelo.ClienteCFDIModel>(resultado);
                serie = JsonConvert.DeserializeObject<Facturas.SerieCFDIModel>(resultado);
                ivaModel = JsonConvert.DeserializeObject<Modelo.CfdiIvaModel>(resultado);
                if (cliente !=null)
                {
                    datosDetalle.cliente = new Modelo.ClienteCFDIModel();
                    datosDetalle.cliente = cliente;
                }
                if (serie != null)
                {
                    datosDetalle.serie = new SerieCFDIModel();
                    datosDetalle.serie = serie;
                }
                if (ivaModel != null)
                {
                    datosDetalle.IvaCfdi = new Modelo.CfdiIvaModel();
                    datosDetalle.IvaCfdi = ivaModel;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problema Obtener cliente series", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            return datosDetalle;
        }
        private void GuardarConfiguracion(Button botonGuardar, Modelo.ClienteCFDIModel clienteCFDI, Facturas.SerieCFDIModel serieCFDI, Modelo.CfdiIvaModel IvaSeleccionado)
        {
            string resultado = string.Empty;
            BDH.Herramienta herramienta = new BDH.Herramienta();

            
            try
            {
                DatosGuardarJson camposEnviar = new DatosGuardarJson();
                string DatosJSON = string.Empty;
               
                IvaSeleccionado.activo = 1;
                
                camposEnviar.campos = new DatosDetalleJson();
                camposEnviar.campos.cliente = clienteCFDI;
                camposEnviar.campos.serie = serieCFDI;
                camposEnviar.campos.IvaCfdi = IvaSeleccionado;
                DatosJSON = JsonConvert.SerializeObject(camposEnviar);
                resultado = herramienta.LeerTablaPOST("cfdi/guardarconfigtodogas", DatosJSON);
                Modelo.ClienteCFDIModel camposGuardados;
                camposGuardados = JsonConvert.DeserializeObject<Modelo.ClienteCFDIModel>(resultado);
                if (camposGuardados?.RazonSocial != null)
                {
                    
                    botonGuardar.Dispatcher.Invoke(() =>
                    {
                        botonGuardar.Content = "Guardado!";
                        botonGuardar.IsEnabled = true;
                    });
                    
                }
            }
            catch (Exception ex)
            {
                botonGuardar.Dispatcher.Invoke(() =>
                {
                    botonGuardar.Content = "Guardar";
                    botonGuardar.IsEnabled = true;
                });
                MessageBox.Show(ex.Message, "Problema Guardar", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
        private List<Modelo.CfdiIvaModel> ObtenerIvas()
        {
            string resultado = string.Empty;
            List<Modelo.CfdiIvaModel> cfdiListaIva = null;
            BDH.Herramienta herramienta = new BDH.Herramienta();
            try
            {
                resultado = herramienta.LeerTabla("cfdi/listaiva");
                if (resultado != string.Empty)
                {
                    
                    cfdiListaIva = JsonConvert.DeserializeObject<List<Modelo.CfdiIvaModel>>(resultado);

                    if (cfdiListaIva != null)
                    {
                        //BoxIva.ItemsSource = cfdiListaIva;
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Problema Iva", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            return cfdiListaIva;
        }
        private Modelo.DataClienteModel ObtenerClientes()
        {
            Modelo.DataClienteModel dataCliente = new Modelo.DataClienteModel();
            List<Modelo.ClienteCFDIModel> ListaclienteCFDIs = new List<Modelo.ClienteCFDIModel>();
            try
            {
                string DatosRecibido;
                BDH.HerramientaSAT herramientaSAT = new BDH.HerramientaSAT();
                DatosRecibido = herramientaSAT.LeerTabla("api/v1/clients");
                dataCliente = JsonConvert.DeserializeObject<Modelo.DataClienteModel>(DatosRecibido);
                //BoxClientes.ItemsSource = dataCliente.data;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "problema", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            return dataCliente;
        }

        private void RadioUIDCliente_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RadioButton radioClientes = (RadioButton)sender;
                Modelo.ClienteCFDIModel clienteCFDI = (Modelo.ClienteCFDIModel)radioClientes.DataContext;
                if (clienteCFDI != null)
                {
                    txtUIDCliente.Text = clienteCFDI.UID;
                    lblRFC.Content = clienteCFDI.RFC;
                    lblRazonSocial.Content = clienteCFDI.RazonSocial;
                    BoxClientes.Visibility = Visibility.Collapsed;
                    GridClientes.Visibility = Visibility.Visible;
                    StackCambiarCliente.Visibility = Visibility.Collapsed;
                }
            }
            catch (Exception ex)
            {
                txtUIDCliente.Text = string.Empty;
                lblRFC.Content = string.Empty;
                lblRazonSocial.Content = string.Empty;
                MessageBox.Show(ex.Message, "Problema", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            
        }

        private void BoxClientes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private DataSerieCFDI ObtenerSeriesCFDI()
        {
            string DatosResultado;

            DataSerieCFDI dataSerie = new DataSerieCFDI();
            try
            {
                BDH.HerramientaSAT herramientaSAT = new BDH.HerramientaSAT();
                DatosResultado = herramientaSAT.LeerTabla("/api/v1/series");
                dataSerie = JsonConvert.DeserializeObject<DataSerieCFDI>(DatosResultado);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return dataSerie;

        }

        private void BtnCambiarCliente_Click(object sender, RoutedEventArgs e)
        {
            BoxClientes.Visibility = Visibility.Visible;
            GridClientes.Visibility = Visibility.Collapsed;
            StackCambiarCliente.Visibility = Visibility.Visible;
        }

        private void BtnCambiarSerie_Click(object sender, RoutedEventArgs e)
        {
            BoxSeries.Visibility = Visibility.Visible;
            GridSerie.Visibility = Visibility.Collapsed;
            StackSeries.Visibility = Visibility.Visible;
        }

        private void RadioSerie_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                RadioButton radioSeries = (RadioButton)sender;
                Facturas.SerieCFDIModel SerieCDFI = (SerieCFDIModel)radioSeries.DataContext;
                if (SerieCDFI != null)
                {
                    txtFolioID.Text = SerieCDFI.SerieID.ToString();
                    lblSerieNombre.Content = SerieCDFI.SerieName;
                    
                    BoxSeries.Visibility = Visibility.Collapsed;
                    GridSerie.Visibility = Visibility.Visible;
                    StackSeries.Visibility = Visibility.Collapsed;
                }
            }
            catch (Exception ex)
            {
                txtFolioID.Text = string.Empty;
                lblSerieNombre.Content = string.Empty;
                MessageBox.Show(ex.Message, "Problema", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private async void BtnGuardarConfig_Click(object sender, RoutedEventArgs e)
        {
            btnGuardarConfig.Content = "Guardando...";
            btnGuardarConfig.IsEnabled = false;
            try
            {
                Modelo.ClienteCFDIModel clienteCFDI = new Modelo.ClienteCFDIModel()
                {
                    UID = txtUIDCliente.Text.Trim(),
                    RazonSocial = lblRazonSocial.Content.ToString(),
                    RFC = lblRFC.Content.ToString()
                };
                int IdSerie;

                int.TryParse(txtFolioID.Text.Trim(), out IdSerie);
                Facturas.SerieCFDIModel serieCFDI = new SerieCFDIModel()
                {
                    SerieID = IdSerie,
                    SerieName = lblSerieNombre.Content.ToString()
                };
                Modelo.CfdiIvaModel IvaSeleccionado = null;

                IvaSeleccionado = (Modelo.CfdiIvaModel)BoxIva.SelectedItem;
                await Task.Run(() => GuardarConfiguracion(btnGuardarConfig, clienteCFDI, serieCFDI, IvaSeleccionado));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Problema Tarea", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            
        }
    }
}
