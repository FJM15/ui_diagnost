using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Ivision
using Ternium.Ivision.Windows.Library.Iv_RtServerClient;

namespace DxRed_UI_Diagnostico.Model
{
    public class Tag
    {
        public string TagIv { get; set; }
        public string Descripcion { get; set; }
        public double Valor { get; set; }
        public string ValorTexto { get; set; }

        public IvRtServerClient rtServerClient = new IvRtServerClient();

        public Tag()
        {
            rtServerClient.IvRtServer_Init();
        }

        public double leerTag()
        {
            double valorTag;
            byte cert;

            //Obtengo valor del TAG especificado
            rtServerClient.IvRtServer_GetNumeric(TagIv, out valorTag, out cert, null);

            Valor = valorTag;

            return valorTag;
        }

        public int escribirTag(double valor)
        {
            int result;

            //Escribo valor del TAG especificado

            result = rtServerClient.IvRtServer_SetNumeric(TagIv, valor, null);

            if (result == -1001)
                rtServerClient.IvRtServer_AddSetReal(TagIv, valor, null);

            return result;
        }

        public string leerTagTexto()
        {
            string host = "", valorTagTexto = "";

            //Obtengo valor del TAG especificado
            rtServerClient.IvRtServer_GetText(TagIv, out valorTagTexto, host);

            ValorTexto = valorTagTexto;

            return valorTagTexto;
        }

        public int escribirTagTexto(string valorTexto)
        {
            int result;

            //Escribo valor del TAG especificado
            result = rtServerClient.IvRtServer_SetText(TagIv, valorTexto, null);

            if (result == -1001)
                rtServerClient.IvRtServer_AddSetText(TagIv, valorTexto, null);

            return result;
        }
    }
}
