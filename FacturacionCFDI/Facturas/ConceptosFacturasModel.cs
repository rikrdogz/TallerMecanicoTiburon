using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturacionCFDI.Facturas
{
    public class ConceptosFacturasModel
    {
        public string ClaveProdServ { get; set; }
        public decimal Cantidad { get; set; }
        public string ClaveUnidad { get; set; }
        public string  Unidad { get; set; }
        public decimal ValorUnitario { get; set; }
        public string Descripcion { get; set; }
        public decimal Descuento { get; set; }
        public ImpuestosTrasladosModel Impuestos { get; set; }
        //public decimal Importe { get; set; }
    }
}
