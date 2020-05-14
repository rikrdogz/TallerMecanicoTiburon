using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturacionCFDI.Modelo
{
    public class ClienteCFDIModel
    {
        public string UID { get; set; }
        public string RazonSocial { get; set; }
        public string RFC { get; set; }
    }
    public class DataClienteModel
    {
        public string status { get; set; }
        public string response { get; set; }
        public List<ClienteCFDIModel> data { get; set; }
    }
}
