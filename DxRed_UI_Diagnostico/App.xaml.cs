using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Ternium.Ivision.UI.Library.ControlsUI.Dialogs;
using Ternium.Ivision.Windows.Library.Iv_Common;
using DxRed_UI_Diagnostico.ViewModel;

namespace DxRed_UI_Diagnostico
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            int c = 0;
            string island = string.Empty;

            //new SplashScreen("Resources/Images/logo.png").Show(true);

            while ((c = GetOpt.GetOptions(e.Args, "+s:t:p:")) != (-1))
            {
                switch (c)
                {
                    case 's':
                        island = GetOpt.Text;
                        break;
                }
            }

            if (string.IsNullOrEmpty(island))
            {
                MessageDialog md = new MessageDialog("Error, no se encuentra el parámetro  -s [Isla] \r", "Error al iniciar la aplicación");
                md.Width = 500;
                md.Height = 250;
                md.ShowDialog();
                Application.Current.Shutdown();
            }

            MainWindow mn = new MainWindow();
            mn.DataContext = new MainViewModel( island);
            mn.Show();
        }
    }
}
