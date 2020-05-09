using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacturacionCFDI.Modelo
{
    public class CamionModel
    {
        public int Id { get; set; }
        public string anterior { get; set; }
        public string nuevo { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string serie { get; set; }
        public string placas { get; set; }
        public string year { get; set; }
        public string texto { get; set; }
        public bool Activo { get; set; }

    }
}
