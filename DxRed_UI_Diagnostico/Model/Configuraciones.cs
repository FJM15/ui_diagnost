using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Ternium.Ivision.Windows.Library.Iv_Common;
using Ternium.Ivision.Windows.Library.Iv_Log.Classes;

namespace DxRed_UI_Diagnostico.Model
{
    public class Configuraciones
    {
        public String sector = "DXRED";

        // Metodo de inicializacion (Lee el cfg)
        public void Init(string isla)
        {
            string path = string.Empty;

            path = string.Format(Constantes.PATH_CFG_FILE_XML_CD, sector, Constantes.STRING_PROCESS_NAME);

            Constantes.Defines.listHosts = LeeCfg(path);
        }

        // Lectura del XML de configuracion 
        public List<Host> LeeCfg(string path)
        {
            List<Host> listHostsTmp = new List<Host>();
            XDocument xDoc = new XDocument();

            string nombreHost = "", descripcionHost = "", ipHost = "", comunidadAnchoBanda = "", tagTasa10 = "", tagTasa16 = "", modoFallaAnchoBanda = "", tagPing = "", tagErrorConexion = "", herramientoAcceso = "", direccionAcceso = "", usuarioAcceso = "", claveAcceso = "";
            int habilitarAnchoBanda = 0, periodoMuestreoAnchoBandaMilisegundos = 0, portAnchoBanda = 0, timeOutAnchoBanda = 0, countRetryAnchoBanda = 0, portTasa10AnchoBanda = 0, portTasa16AnchoBanda = 0, portTasa5AnchoBanda = 0, habilitarPing = 0, periodoMuestreoPingMilisegundos = 0, bufferSizePing = 0, timeOutPing = 0, maxAnchoBanda = 0, maxPing = 0, cantidadPingPerdidosErrorConexion = 0;

            try
            {
                if (File.Exists(path))
                {
                    xDoc = XDocument.Load(path);

                    var lstAux = (from item in xDoc.Descendants(Constantes.STRING_SECCION_FILE_XML)
                                  select new
                                  {
                                      nombreHost = item.Element("Nombre_Host").Value,
                                      descripcionHost = item.Element("Descripcion_Host").Value,
                                      ipHost = item.Element("Ip_Host").Value,

                                      anchoBanda = item.Descendants("Ancho_Banda") != null ? (from l in item.Descendants("Ancho_Banda").ToList()
                                                                                              select new
                                                                                              {
                                                                                                  habilitarAnchoBanda = l.Element("Habilitar_Medicion_Ancho_Banda").Value,
                                                                                                  periodoMuestreoAnchoBandaMilisegundos = l.Element("Periodo_Muestreo_Consulta_Ancho_Banda").Value,
                                                                                                  comunidadAnchoBanda = l.Element("Comunidad_Consulta_Ancho_Banda").Value,
                                                                                                  portAnchoBanda = l.Element("Puerto_Consulta_Ancho_Banda").Value,
                                                                                                  timeOutAnchoBanda = l.Element("TimeOut_Consulta_Ancho_Banda").Value,
                                                                                                  countRetryAnchoBanda = l.Element("Cantidad_Reintentos_Consulta_Ancho_Banda").Value,
                                                                                                  portTasa10AnchoBanda = l.Element("Puerto_Consulta_Tasa_10_Ancho_Banda").Value,
                                                                                                  portTasa16AnchoBanda = l.Element("Puerto_Consulta_Tasa_16_Ancho_Banda").Value,
                                                                                                  portTasa5AnchoBanda = l.Element("Puerto_Consulta_Tasa_5_Ancho_Banda").Value,
                                                                                                  maxAnchoBanda = l.Element("Maximo_Valor_Estimado_Ancho_Banda").Value,
                                                                                                  modoFallaAnchoBanda = l.Element("Modo_Falla_Medicion_Ancho_Banda").Value,
                                                                                              }
                                                                                            ).FirstOrDefault() : null,

                                      ping = item.Descendants("Ping") != null ? (from l in item.Descendants("Ping").ToList()
                                                                                 select new
                                                                                 {
                                                                                     habilitarPing = l.Element("Habilitar_Medicion_Ping").Value,
                                                                                     periodoMuestreoPingMilisegundos = l.Element("Periodo_Muestreo_Consulta_Ping").Value,
                                                                                     bufferSizePing = l.Element("BufferSize_Consulta_Ping").Value,
                                                                                     timeOutPing = l.Element("TimeOut_Consulta_Ping").Value,
                                                                                     maxPing = l.Element("Maximo_Valor_Estimado_Ping").Value,
                                                                                     cantidadPingPerdidosErrorConexion = l.Element("Cantidad_Pings_Perdidos_Error_Conexion").Value,
                                                                                 }
                                      ).FirstOrDefault() : null,

                                      acceso = item.Descendants("Acceso") != null ? (from l in item.Descendants("Acceso").ToList()
                                                                                     select new
                                                                                     {
                                                                                         herramientaAcceso = l.Element("Herramienta_Acceso").Value,
                                                                                         direccionAcceso = l.Element("Direccion_Acceso").Value,
                                                                                         usuarioAcceso = l.Element("Ususario_Acceso").Value,
                                                                                         claveAcceso = l.Element("Clave_Acceso").Value,
                                                                                     }
                                    ).FirstOrDefault() : null,

                                  }).ToList();

                    foreach (var lv0 in lstAux)
                    {
                        nombreHost = lv0.nombreHost;
                        descripcionHost = lv0.descripcionHost;
                        ipHost = lv0.ipHost;

                        if (lv0.anchoBanda != null)
                        {
                            habilitarAnchoBanda = Int32.Parse(lv0.anchoBanda.habilitarAnchoBanda);
                            periodoMuestreoAnchoBandaMilisegundos = Int32.Parse(lv0.anchoBanda.periodoMuestreoAnchoBandaMilisegundos);
                            comunidadAnchoBanda = lv0.anchoBanda.comunidadAnchoBanda;
                            portAnchoBanda = Int32.Parse(lv0.anchoBanda.portAnchoBanda);
                            timeOutAnchoBanda = Int32.Parse(lv0.anchoBanda.timeOutAnchoBanda);
                            countRetryAnchoBanda = Int32.Parse(lv0.anchoBanda.countRetryAnchoBanda);
                            portTasa10AnchoBanda = Int32.Parse(lv0.anchoBanda.portTasa10AnchoBanda);
                            portTasa16AnchoBanda = Int32.Parse(lv0.anchoBanda.portTasa16AnchoBanda);
                            portTasa5AnchoBanda = Int32.Parse(lv0.anchoBanda.portTasa5AnchoBanda);
                            maxAnchoBanda = Int32.Parse(lv0.anchoBanda.maxAnchoBanda);
                            modoFallaAnchoBanda = lv0.anchoBanda.modoFallaAnchoBanda;

                            tagTasa10 = "DXRED." + lv0.nombreHost + ".Tasa_10";
                            tagTasa16 = "DXRED." + lv0.nombreHost + ".Tasa_16";
                        }
                        else
                        {
                            habilitarAnchoBanda = 0;
                            periodoMuestreoAnchoBandaMilisegundos = 0;
                            comunidadAnchoBanda = "-";
                            portAnchoBanda = 0;
                            timeOutAnchoBanda = 0;
                            countRetryAnchoBanda = 0;
                            portTasa10AnchoBanda = 0;
                            portTasa16AnchoBanda = 0;
                            portTasa5AnchoBanda = 0;
                            maxAnchoBanda = 0;
                            modoFallaAnchoBanda = "-";

                            tagTasa10 = "-";
                            tagTasa16 = "-";
                        }

                        if (lv0.ping != null)
                        {
                            habilitarPing = Int32.Parse(lv0.ping.habilitarPing);
                            periodoMuestreoPingMilisegundos = Int32.Parse(lv0.ping.periodoMuestreoPingMilisegundos);
                            bufferSizePing = Int32.Parse(lv0.ping.bufferSizePing);
                            timeOutPing = Int32.Parse(lv0.ping.timeOutPing);
                            maxPing = Int32.Parse(lv0.ping.maxPing);
                            cantidadPingPerdidosErrorConexion = Int32.Parse(lv0.ping.cantidadPingPerdidosErrorConexion);

                            tagPing = "DXRED." + lv0.nombreHost + ".Ping";
                            tagErrorConexion = "DXRED." + lv0.nombreHost + ".Error_Conexion";
                        }
                        else
                        {
                            habilitarPing = 0;
                            periodoMuestreoPingMilisegundos = 0;
                            bufferSizePing = 0;
                            timeOutPing = 0;
                            maxPing = 0;
                            cantidadPingPerdidosErrorConexion = 0;

                            tagPing = "-";
                            tagErrorConexion = "-";
                        }

                        if (lv0.acceso != null)
                        {
                            herramientoAcceso = lv0.acceso.herramientaAcceso;
                            direccionAcceso = lv0.acceso.direccionAcceso;
                            usuarioAcceso = lv0.acceso.usuarioAcceso;
                            claveAcceso = lv0.acceso.claveAcceso;
                        }
                        else
                        {
                            herramientoAcceso = "";
                            direccionAcceso = "";
                            usuarioAcceso = "";
                            claveAcceso = "";
                        }

                        Console.WriteLine("##############################################");
                        Console.WriteLine("Nombre_Host: " + nombreHost);
                        Console.WriteLine("Descripcion_Host: " + descripcionHost);
                        Console.WriteLine("Ip_Host: " + ipHost);
                        Console.WriteLine("Habilitar_Medicion_Ancho_Banda: " + habilitarAnchoBanda);
                        Console.WriteLine("Periodo_Muestreo_Consulta_Ancho_Banda: " + periodoMuestreoAnchoBandaMilisegundos);
                        Console.WriteLine("Comunidad_Consulta_Ancho_Banda: " + comunidadAnchoBanda);
                        Console.WriteLine("Puerto_Consulta_Ancho_Banda: " + portAnchoBanda);
                        Console.WriteLine("TimeOut_Consulta_Ancho_Banda: " + timeOutAnchoBanda);
                        Console.WriteLine("Cantidad_Reintentos_Consulta_Ancho_Banda: " + countRetryAnchoBanda);
                        Console.WriteLine("Puerto_Consulta_Tasa_10_Ancho_Banda: " + portTasa10AnchoBanda);
                        Console.WriteLine("Puerto_Consulta_Tasa_16_Ancho_Banda: " + portTasa16AnchoBanda);
                        Console.WriteLine("Puerto_Consulta_Tasa_5_Ancho_Banda: " + portTasa5AnchoBanda);
                        Console.WriteLine("Maximo_Valor_Estimado_Ancho_Banda: " + maxAnchoBanda);
                        Console.WriteLine("Modo_Falla_Medicion_Ancho_Banda: " + modoFallaAnchoBanda);
                        Console.WriteLine("Habilitar_Medicion_Ping: " + habilitarPing);
                        Console.WriteLine("Periodo_Muestreo_Consulta_Ping: " + periodoMuestreoPingMilisegundos);
                        Console.WriteLine("BufferSize_Consulta_Ping: " + bufferSizePing);
                        Console.WriteLine("TimeOut_Consulta_Ping: " + timeOutPing);
                        Console.WriteLine("Maximo_Valor_Estimado_Ping: " + maxPing);

                        listHostsTmp.Add(new Host(nombreHost, descripcionHost, ipHost, habilitarAnchoBanda, periodoMuestreoAnchoBandaMilisegundos, comunidadAnchoBanda, portAnchoBanda, timeOutAnchoBanda, countRetryAnchoBanda, portTasa10AnchoBanda, portTasa16AnchoBanda, portTasa5AnchoBanda, tagTasa10, tagTasa16, modoFallaAnchoBanda, habilitarPing, periodoMuestreoPingMilisegundos, bufferSizePing, timeOutPing, tagPing, tagErrorConexion, maxAnchoBanda, maxPing, cantidadPingPerdidosErrorConexion, herramientoAcceso, direccionAcceso, usuarioAcceso, claveAcceso));
                    }

                    Console.WriteLine("##############################################");
                    Console.WriteLine("LeeCfg: Archivo" + path + " leido correctamente");
                }
                else
                {
                    Console.WriteLine("##############################################");
                    Console.WriteLine("Error no se encuentra el archivo " + path, EventLogEntryType.Error);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("##############################################");
                Console.WriteLine("{0}: [" + ex.StackTrace + "], [" + ex.Source + "], [" + ex.Message + "]", Constantes.STRING_PROCESS_NAME);
            }
            return listHostsTmp;
        }
    }
}
