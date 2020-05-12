using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturacionCFDI.Facturas
{
    class ConceptosCFDIModel
    {
        public string ClaveProdServ { get; set; }
        public string NoIdentificacion { get; set; }
        public string Cantidad { get; set; }
        public string ClaveUnidad { get; set; }
        public string Unidad { get; set; }
        public string Descripcion { get; set; }
        public string ValorUnitario { get; set; }
        public string Importe { get; set; }
        public string Descuento { get; set; }
        public ImpuestosModel Impuestos { get; set; } //modelo

    }
}
