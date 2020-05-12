using Newtonsoft.Json;
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
        Facturas.TotalModel DatosTotales = new TotalModel();
        public frmFacturarCotizacion(Modelo.CotizacionModel cotizacion)
        {
            InitializeComponent();

            //seleccionando 1 elemento
            BoxFormaPagos.SelectedIndex = 0;
            BoxIva.SelectedIndex = 0;

            foreach (Modelo.CotizacionDetalleModel concepto in cotizacion.detalles)
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

            List<Facturas.FormaPagoModel> listaFormaPagos = new List<FormaPagoModel>();
            listaFormaPagos.Add(new FormaPagoModel() { codigo = "01", descripcion = "Efectivo" });
            listaFormaPagos.Add(new FormaPagoModel() { codigo = "03", descripcion = "Transferencia electrónica de fondos" });
            listaFormaPagos.Add(new FormaPagoModel() { codigo = "99", descripcion = "Por Definir" });
            BoxFormaPagos.ItemsSource = listaFormaPagos;

            List<Facturas.IvaValoresModel> ListaIvaValores = new List<IvaValoresModel>();
            ListaIvaValores.Add(new IvaValoresModel() { CodigoImpuesto = "002", Descripcion = "FEDERAL 16%", IvaTasa = 0.16m });
            ListaIvaValores.Add(new IvaValoresModel() { CodigoImpuesto = "002", Descripcion = "FEDERAL 8%", IvaTasa = 0.08m });
            BoxIva.ItemsSource = ListaIvaValores;




        }
        private void CalcularImporte()
        {
            DatosTotales = new TotalModel();
            decimal IvaTasa = 0;
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
                        DatosTotales.Subtotal = DatosTotales.Subtotal + importe;
                    }
                    GridConceptos.ItemsSource = ListaConceptosLocal;
                    CollectionViewSource.GetDefaultView(GridConceptos.ItemsSource).Refresh();

                    Facturas.IvaValoresModel IvaValor = (Facturas.IvaValoresModel)BoxIva.SelectedItem;

                    if (IvaValor != null)
                    {
                        lblIvaTasa.Content = IvaValor.IvaTasa.ToString();
                        IvaTasa = IvaValor.IvaTasa;
                    }
                    else
                    {
                        lblIvaTasa.Content = "0.00";
                        IvaTasa = 0;
                    }
                    DatosTotales.IvaImporte = DatosTotales.Subtotal * IvaTasa;
                    DatosTotales.Total = DatosTotales.Subtotal + DatosTotales.IvaImporte;
                    lblSubtotal.Content = DatosTotales.Subtotal.ToString("C");
                    lblIvaImporte.Content = DatosTotales.IvaImporte.ToString("C");
                    lblTotal.Content = DatosTotales.Total.ToString("C");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problema");
                throw;
            }



        }

        private void BoxIva_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            CalcularImporte();
        }

        private void BtnFacturar_Click(object sender, RoutedEventArgs e)
        {
            BDH.HerramientaSAT herramientaSAT = new BDH.HerramientaSAT();
            try
            {
                string DatosString = string.Empty;
                DatosTimbradoModel datosTimbrado = new DatosTimbradoModel()
                {
                    conceptos = CalcularImpuestos(),
                    CondicionesDePago = "Pago en una sola exhibición",
                    EnviarCorreo = false,
                    FormaPago = "01",
                    InvoiceComments = "",
                    MetodoPago = "PUE",
                    Moneda = "MXN",
                    Receptor = new ReceptorModel()
                    {
                        UID = ""
                    },
                    Redondeo = 2,
                    Serie = "1",
                    TipoDocumento = "factura",
                    UsoCFDI = "P01"

                };


                DatosString = JsonConvert.SerializeObject(datosTimbrado);
                herramientaSAT.LeerTablaPOST("create", DatosString);


            }
            catch (Exception)
            {

                throw;
            }
        }
        private List<ConceptosFacturasModel> CalcularImpuestos()
        {
            List<ConceptosFacturasModel> ListaConceptosLocal = null;
            try
            {
                ListaConceptosLocal = new List<ConceptosFacturasModel>();
                ListaConceptosLocal = (List<ConceptosFacturasModel>)GridConceptos.ItemsSource;
                if (ListaConceptosLocal == null)
                {
                    throw new Exception("No se hay conceptos para facturar");
                }
                Facturas.IvaValoresModel IvaValor = (Facturas.IvaValoresModel)BoxIva.SelectedItem;

                if (IvaValor == null)
                {
                    throw new Exception("No se selecciono el IVA a manejar");
                }
                foreach (ConceptosFacturasModel conceptoLocal in ListaConceptosLocal)
                {
                    conceptoLocal.Impuestos = new ImpuestosTrasladosModel();
                    conceptoLocal.Impuestos.Traslados = new TrasladosModel();
                    conceptoLocal.Impuestos.Traslados.Base = conceptoLocal.Importe;
                    conceptoLocal.Impuestos.Traslados.Impuesto = "002";
                    conceptoLocal.Impuestos.Traslados.TipoFactor = "Tasa";
                    conceptoLocal.Impuestos.Traslados.TasaOCuota = IvaValor.IvaTasa;
                    conceptoLocal.Impuestos.Traslados.Importe = conceptoLocal.Importe * IvaValor.IvaTasa;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Problema", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            return ListaConceptosLocal;
        }
    }
}
