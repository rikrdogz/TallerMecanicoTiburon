using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionCFDI.Facturas
{
    public class FacturaTimbradoModel
    {
        public string response { get; set; }
        public string message { get; set; }
        public string UUID { get; set; }
        public string uid { get; set; }
        public SATFacturaModel SAT { get; set; }
        public INVFacturaModel INV { get; set; }
        public string invoice_uid { get; set; }
    }
    public class SATFacturaModel
    {
        public string UUID { get; set; }
        public DateTime FechaTimbrado { get; set; }
        public string NoCertificadoSAT { get; set; }
        public string Version { get; set; }
        public string SelloSat { get; set; }
        public string SelloCFD { get; set; }
    }
    public class INVFacturaModel
    {
        public string Serie { get; set; }
        public string Folio { get; set; }

    }
    
}
