using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionCFDI.Facturas
{
    public class DatosTimbradoModel
    {
        public ReceptorModel Receptor { get; set; }
        public string TipoDocumento { get; set; }
        public string UsoCFDI { get; set; }
        public string Redondeo { get; set; }
        public List<ConceptosFacturasModel> Conceptos { get; set; }
        public string FormaPago { get; set; }
        public string MetodoPago { get; set; }
        public string Moneda { get; set; }
        public string CondicionesDePago { get; set; }
        public int Serie { get; set; }
        public bool EnviarCorreo { get; set; }
        public string InvoiceComments { get; set; }
    }
    public class ReceptorModel
    {
        public string UID { get; set; }

    }
    
}
