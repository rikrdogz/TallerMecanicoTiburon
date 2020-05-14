using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionCFDI.Facturas
{
    public class SerieCFDIModel
    {
        public int SerieID { get; set; }
        public string SerieName { get; set; }
        public string SerieType { get; set; }
    }
    public class DataSerieCFDI
    {
        public string status { get; set; }
        public List<SerieCFDIModel> data { get; set; }
    }
}

