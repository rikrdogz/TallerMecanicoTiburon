using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturacionCFDI.Modelo
{
    class JsonRespuestaModel
    {
        public string status { get; set; }
        public string response { get; set; }
        public int total { get; set; }
        public List<FacturaModel> data { get; set; }

    }
}
