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

namespace FacturacionCFDI
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            lblServerSAT.Content = BDH.HerramientaSAT.ServidorApiSAT;
            if (BDH.HerramientaSAT.ServidorApiSAT == "http://devfactura.in/")
            {
                
                this.Background = Brushes.Yellow;
            }
        }

        private void _MainFrame_Loaded(object sender, RoutedEventArgs e)
        {
            _MainFrame.Navigate(new ListaFacturas());
        }

        private void BtnIrACotizaciones_Click(object sender, RoutedEventArgs e)
        {
            _MainFrame.Navigate(new Cotizacion.frmListaCotizaciones());
        }

        private void BtnIrAFacturasCFDI_Click(object sender, RoutedEventArgs e)
        {
            _MainFrame.Navigate(new ListaFacturas());
        }

        private void BtnIrACamiones_Click(object sender, RoutedEventArgs e)
        {
            _MainFrame.Navigate(new camiones.frmListaCamiones());
        }

        private void BtnIrAConfigGAS_Click(object sender, RoutedEventArgs e)
        {
            _MainFrame.Navigate(new configuracion.frmConfigTodogas());
        }
    }
}
