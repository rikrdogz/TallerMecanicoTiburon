using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FacturacionCFDI.ClientesCFDI
{
    /// <summary>
    /// Lógica de interacción para frmListaClientesCFDI.xaml
    /// </summary>
    public partial class frmListaClientesCFDI : Page
    {
        public frmListaClientesCFDI()
        {
            InitializeComponent();
        }

        private void BtnObtenerClientes_Click(object sender, RoutedEventArgs e)
        {
            Modelo.DataClienteModel dataCliente = new Modelo.DataClienteModel();
            List<Modelo.ClienteCFDIModel> ListaclienteCFDIs = new List<Modelo.ClienteCFDIModel>();
            try
            {
                string DatosRecibido;
                BDH.HerramientaSAT herramientaSAT = new BDH.HerramientaSAT();
                 DatosRecibido = herramientaSAT.LeerTabla("api/v1/clients");
                dataCliente = JsonConvert.DeserializeObject<Modelo.DataClienteModel>(DatosRecibido);
                BoxClientes.ItemsSource = dataCliente.data;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"problema", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }
    }
}
