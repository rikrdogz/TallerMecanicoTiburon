using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace FacturacionCFDI.BDH
{
    class HerramientaSAT
    {
        public static string ServidorApiSAT = "http://devfactura.in/api/v3/cfdi33/";
        public static string FPLUGIN = "9d4095c8f7ed5785cb14c0e3b033eeb8252416ed";
        public static string FApiKey = "JDJ5JDEwJDkvM21jRTlEdXJkY2pGRmJMdVlCQ2V1MWJxendHMnR2QXhWdE5IOXZlOVN6WEV2enY3Smxp";
        public static string FSecretKey = "JDJ5JDEwJG1jMUduQWdNMzcuLnRLTGU2L1Bjb2VXMS5WUnVuOXouei9ydjlxSktyUjVQSjMuS2puTmxD";
        //public static string ServidorAPIDB = "http://vidachiapas.com/api/";
        public static WebRequest respuesta;
        public string LeerTabla(string consulta)
        {

            //WebRequest respuesta;
            string ResultadoConsulta = string.Empty;
            respuesta = WebRequest.Create(ServidorApiSAT + consulta);
            respuesta.ContentType = "application/json";
            respuesta.Headers.Add("F-PLUGIN", FPLUGIN);
            respuesta.Headers.Add("F-API-KEY", FApiKey);
            respuesta.Headers.Add("F-SECRET-KEY", FSecretKey);


            //respuesta.Method = "GET";
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
        public string LeerTablaPOST(string consulta, string DataArray)
        {

            //WebRequest respuesta;
            string ResultadoConsulta = string.Empty;
            respuesta = WebRequest.Create(ServidorApiSAT + consulta);
            respuesta.ContentType = "application/json";
            respuesta.Headers.Add("F-PLUGIN", FPLUGIN);
            respuesta.Headers.Add("F-API-KEY", FApiKey);
            respuesta.Headers.Add("F-SECRET-KEY", FSecretKey);
            respuesta.Method = "POST";
            respuesta.Proxy = null;
            using (var streamWriter = new StreamWriter(respuesta.GetRequestStream()))
            {

                streamWriter.Write(DataArray);
            }
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
