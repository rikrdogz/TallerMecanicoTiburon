using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionCFDI.Facturas
{
    public class TotalModel
    {
        public decimal Subtotal { get; set; }
        public IvaValoresModel IvaValores { get; set; }
        public decimal  IvaImporte { get; set; }
        public decimal Total { get; set; }
    }
}
