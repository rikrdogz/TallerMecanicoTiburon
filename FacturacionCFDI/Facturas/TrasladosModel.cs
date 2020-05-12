namespace FacturacionCFDI.Facturas
{
     public class TrasladosModel
    {
        public decimal Base { get; set; }
        public string Impuesto { get; set; }
        public string TipoFactor { get; set; }
        public decimal TasaOCuota { get; set; }
        public decimal Importe { get; set; }
    }
}