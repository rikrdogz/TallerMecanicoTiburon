using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturacionCFDI.Modelo
{
    public class CotizacionDetalleModel
    {
        public int numero { get; set; }
        public int id_servicio { get; set; }
        public int camion { get; set; }
        public DateTime fecha { get; set; }
        public decimal valor { get; set; }
        public int idpieza { get; set; }
        public string np { get; set; }
        public string descripcion { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal costo { get; set; }
        public int ncotizacion { get; set; }
        public string tipo { get; set; }
        public decimal mano { get; set; }
    }
}
