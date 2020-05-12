using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionCFDI.Facturas
{
    public class IvaValoresModel
    {
        public string CodigoImpuesto { get; set; }
        public decimal IvaTasa { get; set; }
        public string Descripcion { get; set; }
    }
}
