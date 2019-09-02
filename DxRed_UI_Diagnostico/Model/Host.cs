using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxRed_UI_Diagnostico.Model
{
    public class Host
    {
        private string nombreHost = "";
        
        public string NombreHost
        {
            get
            {
                return nombreHost;
            }
            set
            {
                nombreHost = value;
            }
        }

        private string descripcionHost = "";
        
        public string DescripcionHost
        {
            get
            {
                return descripcionHost;
            }
            set
            {
                descripcionHost = value;
            }
        }

        private string ipHost = "";
        
        public string IpHost
        {
            get
            {
                return ipHost;
            }
            set
            {
                ipHost = value;
            }
        }

        private int habilitarAnchoBanda = 0;
        
        public int HabilitarAnchoBanda
        {
            get
            {
                return habilitarAnchoBanda;
            }
            set
            {
                habilitarAnchoBanda = value;
            }
        }

        private int periodoMuestreoAnchoBandaMilisegundos = 0;
        
        public int PeriodoMuestreoAnchoBandaMilisegundos
        {
            get
            {
                return periodoMuestreoAnchoBandaMilisegundos;
            }
            set
            {
                periodoMuestreoAnchoBandaMilisegundos = value;
            }
        }

        private string comunidadAnchoBanda = "";
        
        public string ComunidadAnchoBanda
        {
            get
            {
                return comunidadAnchoBanda;
            }
            set
            {
                comunidadAnchoBanda = value;
            }
        }

        private int portAnchoBanda = 0;
        
        public int PortAnchoBanda
        {
            get
            {
                return portAnchoBanda;
            }
            set
            {
                portAnchoBanda = value;
            }
        }

        private int timeOutAnchoBanda = 0;
        
        public int TimeOutAnchoBanda
        {
            get
            {
                return timeOutAnchoBanda;
            }
            set
            {
                timeOutAnchoBanda = value;
            }
        }

        private int countRetryAnchoBanda = 0;
        
        public int CountRetryAnchoBanda
        {
            get
            {
                return countRetryAnchoBanda;
            }
            set
            {
                countRetryAnchoBanda = value;
            }
        }

        private int portTasa10AnchoBanda = 0;
        
        public int PortTasa10AnchoBanda
        {
            get
            {
                return portTasa10AnchoBanda;
            }
            set
            {
                portTasa10AnchoBanda = value;
            }
        }

        private int portTasa16AnchoBanda = 0;
        
        public int PortTasa16AnchoBanda
        {
            get
            {
                return portTasa16AnchoBanda;
            }
            set
            {
                portTasa16AnchoBanda = value;
            }
        }

        private int portTasa5AnchoBanda = 0;
        
        public int PortTasa5AnchoBanda
        {
            get
            {
                return portTasa5AnchoBanda;
            }
            set
            {
                portTasa5AnchoBanda = value;
            }
        }

        private string tagTasa10 = "";
        
        public string TagTasa10
        {
            get
            {
                return tagTasa10;
            }
            set
            {
                tagTasa10 = value;
            }
        }

        private string tagTasa16 = "";
        
        public string TagTasa16
        {
            get
            {
                return tagTasa16;
            }
            set
            {
                tagTasa16 = value;
            }
        }

        private string modoFallaAnchoBanda = "";
        
        public string ModoFallaAnchoBanda
        {
            get
            {
                return modoFallaAnchoBanda;
            }
            set
            {
                modoFallaAnchoBanda = value;
            }
        }

        private int habilitarPing = 0;
        
        public int HabilitarPing
        {
            get
            {
                return habilitarPing;
            }
            set
            {
                habilitarPing = value;
            }
        }

        private int periodoMuestreoPingMilisegundos = 0;
        
        public int PeriodoMuestreoPingMilisegundos
        {
            get
            {
                return periodoMuestreoPingMilisegundos;
            }
            set
            {
                periodoMuestreoPingMilisegundos = value;
            }
        }

        private int bufferSizePing = 0;
        
        public int BufferSizePing
        {
            get
            {
                return bufferSizePing;
            }
            set
            {
                bufferSizePing = value;
            }
        }

        private int timeOutPing = 0;
        
        public int TimeOutPing
        {
            get
            {
                return timeOutPing;
            }
            set
            {
                timeOutPing = value;
            }
        }

        private string tagPing = "";
        
        public string TagPing
        {
            get
            {
                return tagPing;
            }
            set
            {
                tagPing = value;
            }
        }

        private string tagErrorConexion = "";

        public string TagErrorConexion
        {
            get
            {
                return tagErrorConexion;
            }
            set
            {
                tagErrorConexion = value;
            }
        }

        private int maxAnchoBanda = 0;

        public int MaxAnchoBanda
        {
            get
            {
                return maxAnchoBanda;
            }
            set
            {
                maxAnchoBanda = value;
            }
        }

        private int maxPing = 0;

        public int MaxPing
        {
            get
            {
                return maxPing;
            }
            set
            {
                maxPing = value;
            }
        }

        private string herramientoAcceso = "";

        public string HerramientoAcceso
        {
            get
            {
                return herramientoAcceso;
            }
            set
            {
                herramientoAcceso = value;
            }
        }

        private string direccionAcceso = "";

        public string DireccionAcceso
        {
            get
            {
                return direccionAcceso;
            }
            set
            {
                direccionAcceso = value;
            }
        }

        private string usuarioAcceso = "";

        public string UsuarioAcceso
        {
            get
            {
                return usuarioAcceso;
            }
            set
            {
                usuarioAcceso = value;
            }
        }

        private string claveAcceso = "";

        public string ClaveAcceso
        {
            get
            {
                return claveAcceso;
            }
            set
            {
                claveAcceso = value;
            }
        }

        public Host(string pNombreHost, string pDescripcionHost, string pHost, int pHabilitarAnchoBanda, int pPeriodoMuestreoAnchoBandaMilisegundos, string pComunidadAnchoBanda, int pPortAnchoBanda, int pTimeOutAnchoBanda, int pCountRetryAnchoBanda, int pPortTasa10AnchoBanda, int pPortTasa16AnchoBanda, int pPortTasa5AnchoBanda, string pTagTasa10, string pTagTasa16, string pModoFallaAnchoBanda, int pHabilitarPing, int pPeriodoMuestreoPingMilisegundos, int pBufferSizePing, int pTimeOutPing, string pTagPing, string pTagErrorConexion, int pMaxAnchoBanda, int pMaxPing, int pCantidadPingPerdidosErrorConexion, string pHerramientoAcceso, string pDireccionAcceso, string pUsuarioAcceso, string pClaveAcceso)
        {
            nombreHost = pNombreHost;
            descripcionHost = pDescripcionHost;
            ipHost = pHost;
            habilitarAnchoBanda = pHabilitarAnchoBanda;
            periodoMuestreoAnchoBandaMilisegundos = pPeriodoMuestreoAnchoBandaMilisegundos;
            comunidadAnchoBanda = pComunidadAnchoBanda;
            portAnchoBanda = pPortAnchoBanda;
            timeOutAnchoBanda = pTimeOutAnchoBanda;
            countRetryAnchoBanda = pCountRetryAnchoBanda;
            portTasa10AnchoBanda = pPortTasa10AnchoBanda;
            portTasa16AnchoBanda = pPortTasa16AnchoBanda;
            portTasa5AnchoBanda = pPortTasa5AnchoBanda;
            tagTasa10 = pTagTasa10;
            tagTasa16 = pTagTasa16;
            modoFallaAnchoBanda = pModoFallaAnchoBanda;
            habilitarPing = pHabilitarPing;
            periodoMuestreoPingMilisegundos = pPeriodoMuestreoPingMilisegundos;
            bufferSizePing = pBufferSizePing;
            timeOutPing = pTimeOutPing;
            tagPing = pTagPing;
            tagErrorConexion = pTagErrorConexion;
            herramientoAcceso = pHerramientoAcceso;
            direccionAcceso = pDireccionAcceso;
            usuarioAcceso = pUsuarioAcceso;
            claveAcceso = pClaveAcceso;

            maxAnchoBanda = pMaxAnchoBanda;
            maxPing = pMaxPing;
        }
    }
}
