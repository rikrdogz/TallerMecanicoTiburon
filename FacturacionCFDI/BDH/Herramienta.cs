using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace FacturacionCFDI.BDH
{
    class Herramienta
    {
        public static string ServidorAPIDB = "http://vidachiapas.com/api/";
        public static WebRequest respuesta;
        public string LeerTabla(string consulta)
        {
            //WebRequest respuesta;
            string ResultadoConsulta = string.Empty;
            respuesta = WebRequest.Create(ServidorAPIDB + consulta);
            respuesta.ContentType = "application/json";
            //respuesta.Method = "GET";
            //respuesta.Proxy = null;
            using (WebResponse response = respuesta.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);
                    var json = reader.ReadToEnd();
                    ResultadoConsulta = json;

                }

            }
            return ResultadoConsulta;
        }
        public string  RevisarTiemposAPI(string consulta)
        {
            
            string ResultadoConsulta = string.Empty;
            
            respuesta = WebRequest.Create(ServidorAPIDB + consulta);
            respuesta.ContentType = "application/json";
            respuesta.Method = "GET";
            respuesta.Proxy = null;
            using (WebResponse response = respuesta.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream);
                    var json = reader.ReadToEnd();
                    ResultadoConsulta = json;

                }

            }
            return ResultadoConsulta;
        }
    }
}
