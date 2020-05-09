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

namespace FacturacionCFDI.Facturas
{
    /// <summary>
    /// Lógica de interacción para frmFacturarCotizacion.xaml
    /// </summary>
    /// 
    
    public partial class frmFacturarCotizacion : Page
    {
        List<ConceptosFacturasModel> ListaConceptosFacturasCFDI = new List<ConceptosFacturasModel>();
        public frmFacturarCotizacion(Modelo.CotizacionModel cotizacion)
        {
            InitializeComponent();
            foreach(Modelo.CotizacionDetalleModel concepto in cotizacion.detalles)
            {
                ListaConceptosFacturasCFDI.Add(new ConceptosFacturasModel()
                {
                     Cantidad = concepto.cantidad,
                      Descripcion = concepto.descripcion,
                       ValorUnitario = concepto.valor
                });
            }
            GridConceptos.ItemsSource = ListaConceptosFacturasCFDI;
            CalcularImporte();
        }
        private void CalcularImporte()
        {
            decimal importe = 0;
            try
            {
                List<ConceptosFacturasModel> ListaConceptosLocal = new List<ConceptosFacturasModel>();
                ListaConceptosLocal = (List<ConceptosFacturasModel>)GridConceptos.ItemsSource;
                if (ListaConceptosLocal != null)
                {
                    foreach (ConceptosFacturasModel conceptoLocal in ListaConceptosLocal)
                    {
                        importe = conceptoLocal.Cantidad * conceptoLocal.ValorUnitario;
                        conceptoLocal.Importe = importe;
                    }
                    GridConceptos.ItemsSource = ListaConceptosLocal;
                    CollectionViewSource.GetDefaultView(GridConceptos.ItemsSource).Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problema");
                throw;
            }
            


        }
        
    }
}
