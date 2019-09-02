using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxRed_UI_Diagnostico.Model
{
    public class Constantes
    {
        public static int P_ERROR = -1;
        public static string STRING_PROCESS_NAME = "DxRed_Monitor";
        public static string PATH_CFG_FILE_XML_CD = "C:\\Program Files\\TerniumAuto\\{0}\\Cfg\\{1}.xml";
        public static string STRING_SECCION_FILE_XML = "Host";

        public struct Defines
        {
            public static List<Host> listHosts = new List<Host>();
        }

    }
}
