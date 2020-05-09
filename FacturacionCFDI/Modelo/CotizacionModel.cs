using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturacionCFDI.Modelo
{
    public class CotizacionModel
    {
        public int id { get; set; }
        public int numero { get; set; }
        public string estado { get; set; }
        public string tipo { get; set; }
        public string camion { get; set; }
        public DateTime fecha { get; set; }
        public DateTime fecha_cot { get; set; }
        public decimal total { get; set; }
        public decimal valor { get; set; }
        public string para { get; set; }
        public int ncamion { get; set; }
        public string marca { get; set; }
        public string nuevo { get; set; }
        public string anterior { get; set; }
        public string OC { get; set; }
        public string FACTURA { get; set; }
        public string ss { get; set; }
        public List<CotizacionDetalleModel> detalles { get; set; }
    }
}
