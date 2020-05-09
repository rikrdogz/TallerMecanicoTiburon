using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturacionCFDI.Facturas
{
    public class ImpuestosTrasladosModel
    {
        public decimal Base { get; set; }
        public string Impuesto { get; set; }
        public string TipoFactor { get; set; }
        public decimal TasaOCuota { get; set; }
        public decimal Importe { get; set; }
    }
}
