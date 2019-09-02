using DxRed_UI_Diagnostico.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using Ternium.Ivision.UI.Library.ControlsUI.Dialogs.IvMsgDialog;
using Ternium.Ivision.UI.Library.MVVM.Core;
using Ternium.Ivision.Windows.Library.Iv_RtServerClient;

namespace DxRed_UI_Diagnostico.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private System.Timers.Timer timer;
        Random rnd = new Random();
        string sector;
        private string title;

        private List<Host> listHosts;
        private Host hostSeleccionado;

        private Configuraciones cfg = new Configuraciones();

        private string tasa10AB = "";
        private string tasa16AB = "";
        private string pingActual = "";

        private int vientoDireccion = 0;
        private Tag tagVientoDireccion = new Tag();

        private string pngClima = "";

        private readonly Dispatcher _disp;

        private IvRtServerClient classRts = new IvRtServerClient();

        public List<Host> ListHosts
        {
            get
            {
                return listHosts;
            }
            set
            {
                if (value != listHosts)
                {
                    listHosts = value;
                    RaisePropertyChanged(() => ListHosts);
                }
            }
        }

        public Host HostSeleccionado
        {
            get { return hostSeleccionado; }
            set
            {
                if (value != hostSeleccionado)
                {
                    hostSeleccionado = value;
                    RaisePropertyChanged(() => HostSeleccionado);
                    ActualizarHostCambioCombo();
                }
            }
        }

        public string DescripcionSeleccionada
        {
            get { return hostSeleccionado.DescripcionHost; }
            set
            {
                if (value != hostSeleccionado.DescripcionHost)
                {
                    hostSeleccionado.DescripcionHost = value;
                    RaisePropertyChanged(() => DescripcionSeleccionada);
                }
            }
        }

        public string IpSeleccionada
        {
            get { return hostSeleccionado.IpHost; }
            set
            {
                if (value != hostSeleccionado.IpHost)
                {
                    hostSeleccionado.IpHost = value;
                    RaisePropertyChanged(() => IpSeleccionada);
                }
            }
        }

        public string MedicionABSeleccionada
        {
            get 
            {
                if (hostSeleccionado.HabilitarAnchoBanda == 1)
                    return "CONTÍNUA";
                else
                    if (hostSeleccionado.HabilitarAnchoBanda == 2)
                        return "BAJO DEMANDA";
                    else
                        return "NO";
            }
            set
            {
                if (value != Convert.ToString(hostSeleccionado.HabilitarAnchoBanda))
                {
                    hostSeleccionado.HabilitarAnchoBanda = Convert.ToInt16(value);
                    RaisePropertyChanged(() => MedicionABSeleccionada);
                }
            }
        }

        public string MuestreoABSeleccionado
        {
            get { return Convert.ToString(hostSeleccionado.PeriodoMuestreoAnchoBandaMilisegundos + " ms"); }
            set
            {
                if (value != Convert.ToString(hostSeleccionado.PeriodoMuestreoAnchoBandaMilisegundos))
                {
                    hostSeleccionado.PeriodoMuestreoAnchoBandaMilisegundos = Convert.ToInt16(value);
                    RaisePropertyChanged(() => MuestreoABSeleccionado);
                }
            }
        }

        public string ModoFallaABSeleccionado
        {
            get { return hostSeleccionado.ModoFallaAnchoBanda; }
            set
            {
                if (value != hostSeleccionado.ModoFallaAnchoBanda)
                {
                    hostSeleccionado.ModoFallaAnchoBanda = value;
                    RaisePropertyChanged(() => ModoFallaABSeleccionado);
                }
            }
        }

        public string ComunidadABSeleccionada
        {
            get { return Convert.ToString(hostSeleccionado.ComunidadAnchoBanda); }
            set
            {
                if (value != Convert.ToString(hostSeleccionado.ComunidadAnchoBanda))
                {
                    hostSeleccionado.ComunidadAnchoBanda = value;
                    RaisePropertyChanged(() => ComunidadABSeleccionada);
                }
            }
        }

        public string TimeoutABSeleccionado
        {
            get { return Convert.ToString(hostSeleccionado.TimeOutAnchoBanda + " ms"); }
            set
            {
                if (value != Convert.ToString(hostSeleccionado.TimeOutAnchoBanda))
                {
                    hostSeleccionado.TimeOutAnchoBanda = Convert.ToInt16(value);
                    RaisePropertyChanged(() => TimeoutABSeleccionado);
                }
            }
        }

        public string TimeoutPingSeleccionado
        {
            get { return Convert.ToString(hostSeleccionado.TimeOutPing + " ms"); }
            set
            {
                if (value != Convert.ToString(hostSeleccionado.TimeOutPing))
                {
                    hostSeleccionado.TimeOutPing = Convert.ToInt16(value);
                    RaisePropertyChanged(() => TimeoutPingSeleccionado);
                }
            }
        }

        public string HerramientaSeleccionada
        {
            get { return Convert.ToString(hostSeleccionado.HerramientoAcceso); }
            set
            {
                if (value != Convert.ToString(hostSeleccionado.HerramientoAcceso))
                {
                    hostSeleccionado.HerramientoAcceso = value;
                    RaisePropertyChanged(() => HerramientaSeleccionada);
                }
            }
        }

        public string ReintentosABSeleccionado
        {
            get { return Convert.ToString(hostSeleccionado.CountRetryAnchoBanda); }
            set
            {
                if (value != Convert.ToString(hostSeleccionado.CountRetryAnchoBanda))
                {
                    hostSeleccionado.CountRetryAnchoBanda = Convert.ToInt16(value);
                    RaisePropertyChanged(() => ReintentosABSeleccionado);
                }
            }
        }

        public string MedicionPingSeleccionado
        {
            get 
            {
                if (hostSeleccionado.HabilitarPing == 1)
                    return "CONTÍNUA";
                else
                    if (hostSeleccionado.HabilitarPing == 2)
                        return "BAJO DEMANDA";
                    else
                        return "NO";
            }
            set
            {
                if (value != Convert.ToString(hostSeleccionado.HabilitarPing))
                {
                    hostSeleccionado.HabilitarPing = Convert.ToInt16(value);
                    RaisePropertyChanged(() => MedicionPingSeleccionado);
                }
            }
        }

        public string MuestreoPingSeleccionado
        {
            get { return Convert.ToString(hostSeleccionado.PeriodoMuestreoPingMilisegundos + " ms"); }
            set
            {
                if (value != Convert.ToString(hostSeleccionado.PeriodoMuestreoPingMilisegundos))
                {
                    hostSeleccionado.PeriodoMuestreoPingMilisegundos = Convert.ToInt16(value);
                    RaisePropertyChanged(() => MuestreoPingSeleccionado);
                }
            }
        }

        public string BufferPingSeleccionado
        {
            get { return Convert.ToString(hostSeleccionado.BufferSizePing + " Bytes"); }
            set
            {
                if (value != Convert.ToString(hostSeleccionado.BufferSizePing))
                {
                    hostSeleccionado.BufferSizePing = Convert.ToInt16(value);
                    RaisePropertyChanged(() => BufferPingSeleccionado);
                }
            }
        }

        public string TagTasa10Seleccionado
        {
            get { return hostSeleccionado.TagTasa10; }
            set
            {
                if (value != hostSeleccionado.TagTasa10)
                {
                    hostSeleccionado.TagTasa10 = value;
                    RaisePropertyChanged(() => TagTasa10Seleccionado);
                }
            }
        }

        public string TagTasa16Seleccionado
        {
            get { return hostSeleccionado.TagTasa16; }
            set
            {
                if (value != hostSeleccionado.TagTasa16)
                {
                    hostSeleccionado.TagTasa16 = value;
                    RaisePropertyChanged(() => TagTasa16Seleccionado);
                }
            }
        }

        public string TagPingSeleccionado
        {
            get { return hostSeleccionado.TagPing; }
            set
            {
                if (value != hostSeleccionado.TagPing)
                {
                    hostSeleccionado.TagPing = value;
                    RaisePropertyChanged(() => TagPingSeleccionado);
                }
            }
        }

        public string Tasa10AB
        {
            get { return tasa10AB; }
            set
            {
                if (value != tasa10AB)
                {
                    tasa10AB = value;
                    RaisePropertyChanged(() => Tasa10AB);
                }
            }
        }

        public string Tasa16AB
        {
            get { return tasa16AB; }
            set
            {
                if (value != tasa16AB)
                {
                    tasa16AB = value;
                    RaisePropertyChanged(() => Tasa16AB);
                }
            }
        }

        public string Ping
        {
            get { return pingActual; }
            set
            {
                if (value != pingActual)
                {
                    pingActual = value;
                    RaisePropertyChanged(() => Ping);
                }
            }
        }

        public int VientoDireccion
        {
            get { return vientoDireccion; }
            set
            {
                if (value != vientoDireccion)
                {
                    vientoDireccion = value;
                    RaisePropertyChanged(() => VientoDireccion);
                }
            }
        }

        public string PngClima
        {
            get { return pngClima; }
            set
            {
                if (value != pngClima)
                {
                    pngClima = value;
                    RaisePropertyChanged(() => PngClima);
                }
            }
        }

        public MainViewModel(string island)
        {
            // Inicializacion del proceso
            cfg.Init(island);

            listHosts = Constantes.Defines.listHosts;

            //HostSeleccionado = listHosts.First();

            // Inicializo RtServer
            classRts.IvRtServer_Init();
            
            // Inicializo e instalncio el bucle de comparación
            _disp = Application.Current.Dispatcher;

            // Genero los hilos para refresco de información
            var refresh_tags = new Thread(tm_refresco_tags);

            // Defino el tag de direccion del viento
            tagVientoDireccion.TagIv = "DXRED.Clima.Viento_Direccion";

            // Inicio los hilos para refresco de información
            refresh_tags.Start();
            
            sector = island;
        }

        private void tm_refresco_tags()
        {
            string host = "";
            byte cert;
            int tSleep;
            double tasa10, tasa16, ping;
            
            Tag tagSolicitudMuestreoAnchoBandaTmp = new Tag();
            Tag tagSolicitudMuestreoPingTmp = new Tag();

            Tag tagClimaImagen = new Tag();

        }

        private void ActualizarHostCambioCombo()
        {
            RaisePropertyChanged(() => DescripcionSeleccionada);
            RaisePropertyChanged(() => IpSeleccionada);
            RaisePropertyChanged(() => MedicionABSeleccionada);
            RaisePropertyChanged(() => MuestreoABSeleccionado);
            RaisePropertyChanged(() => ModoFallaABSeleccionado);
            RaisePropertyChanged(() => MedicionPingSeleccionado);
            RaisePropertyChanged(() => MuestreoPingSeleccionado);
            RaisePropertyChanged(() => BufferPingSeleccionado);
            RaisePropertyChanged(() => TagTasa10Seleccionado);
            RaisePropertyChanged(() => TagTasa16Seleccionado);
            RaisePropertyChanged(() => TagPingSeleccionado);

            RaisePropertyChanged(() => ComunidadABSeleccionada);
            RaisePropertyChanged(() => TimeoutABSeleccionado);
            RaisePropertyChanged(() => TimeoutPingSeleccionado);
            RaisePropertyChanged(() => HerramientaSeleccionada);
        }

        public ICommand AbrirInfoTagTasa10
        {
            get
            {
                return new RelayCommand(s => EjecutarAbrirInfoTag(TagTasa10Seleccionado));
            }
        }

        public ICommand AbrirInfoTagTasa16
        {
            get
            {
                return new RelayCommand(s => EjecutarAbrirInfoTag(TagTasa16Seleccionado));
            }
        }

        public ICommand AbrirInfoTagPing
        {
            get
            {
                return new RelayCommand(s => EjecutarAbrirInfoTag(TagPingSeleccionado));
            }
        }

        public void EjecutarAbrirInfoTag(string pTagIv)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = @"IvInfoTag.exe";
            startInfo.Arguments = @"-t " + pTagIv;
            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            Process process = new Process();
            process.StartInfo = startInfo;

            process.Start();
        }

        public ICommand AbrirHerramientaAcceso
        {
            get
            {
                return new RelayCommand(s => EjecutarAbrirHerramientaAcceso());
            }
        }

        public void EjecutarAbrirHerramientaAcceso()
        {
            if (hostSeleccionado.HerramientoAcceso != "")
            {
                if (hostSeleccionado.HerramientoAcceso == "WINBOX")
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = @"powershell.exe";
                    startInfo.Arguments = @"& 'C:\Program Files\TerniumAuto\DXRED\Apps\WINBOX.exe' " + hostSeleccionado.DireccionAcceso + " " + hostSeleccionado.UsuarioAcceso + " " + hostSeleccionado.ClaveAcceso;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.RedirectStandardError = true;
                    startInfo.UseShellExecute = false;
                    startInfo.CreateNoWindow = true;
                    Process process = new Process();
                    process.StartInfo = startInfo;

                    process.Start();       
                }
                else
                {
                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = @"powershell.exe";
                    startInfo.Arguments = @"& 'C:\Program Files\TerniumAuto\DXRED\Apps\WEB.lnk' -ArgumentList " + hostSeleccionado.DireccionAcceso;
                    startInfo.RedirectStandardOutput = true;
                    startInfo.RedirectStandardError = true;
                    startInfo.UseShellExecute = false;
                    startInfo.CreateNoWindow = true;
                    Process process = new Process();
                    process.StartInfo = startInfo;

                    process.Start();
                }
            }
            else
            {
                IvMessageBox.Show("No hay una herramienta configurada", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        public ICommand AbrirWindguru
        {
            get
            {
                return new RelayCommand(s => EjecutarAbrirWindguru());
            }
        }

        public void EjecutarAbrirWindguru()
        {
            try 
	        {	        
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @"powershell.exe";
                startInfo.Arguments = @"& 'C:\Program Files\TerniumAuto\DXRED\Apps\WEB.lnk' -ArgumentList https://www.windguru.cz/246825";
                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;
                startInfo.UseShellExecute = false;
                startInfo.CreateNoWindow = true;
                Process process = new Process();
                process.StartInfo = startInfo;

                process.Start();
	        }
	        catch (Exception)
	        {
                IvMessageBox.Show("Error al abrir el navegador", "Error", MessageBoxButton.OK, MessageBoxImage.Error);

		        throw;
	        }
        }
    }
}
