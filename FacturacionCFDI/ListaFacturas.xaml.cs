using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace FacturacionCFDI
{
    /// <summary>
    /// Lógica de interacción para ListaFacturas.xaml
    /// </summary>
    public partial class ListaFacturas : Page
    {
        public ListaFacturas()
        {
            InitializeComponent();
        }

        private void BtnObtenerFacturas_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch sw = new Stopwatch();
            this.Cursor = Cursors.AppStarting;
            WebRequest respuesta;
            bool DatosRecibidos = false;
            Modelo.JsonRespuestaModel ResultadoConsulta;
            try
            {
                
                
                sw.Start();
                respuesta = WebRequest.Create("http://devfactura.in/api/v3/cfdi33/list");
                respuesta.ContentType = "application/json";
                respuesta.Headers.Add("F-PLUGIN", "9d4095c8f7ed5785cb14c0e3b033eeb8252416ed");
                respuesta.Headers.Add("F-API-KEY", "JDJ5JDEwJDkvM21jRTlEdXJkY2pGRmJMdVlCQ2V1MWJxendHMnR2QXhWdE5IOXZlOVN6WEV2enY3Smxp");
                respuesta.Headers.Add("F-SECRET-KEY", "JDJ5JDEwJG1jMUduQWdNMzcuLnRLTGU2L1Bjb2VXMS5WUnVuOXouei9ydjlxSktyUjVQSjMuS2puTmxD");
                
                using (WebResponse response = respuesta.GetResponse())
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        StreamReader reader = new StreamReader(stream);
                        var json = reader.ReadToEnd();
                        ResultadoConsulta = JsonConvert.DeserializeObject<Modelo.JsonRespuestaModel>(json);
                        if (ResultadoConsulta != null)
                        {
                            if (ResultadoConsulta.data != null)
                            {
                                DatosRecibidos = true;
                            }
                        }

                    }

                }
                sw.Stop();
                lbltiempo.Content = "Tiempo: " + sw.ElapsedMilliseconds.ToString();
                this.Cursor = Cursors.Arrow;
                if (DatosRecibidos)
                {

                    GridFacturas.ItemsSource = ResultadoConsulta.data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
               

        }
    }
}
