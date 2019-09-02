using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Input;
using Ternium.Ivision.UI.Library.MVVM.Core;
using $rootnamespace$.IvCustomControl;

namespace $rootnamespace$.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private System.Timers.Timer timer;
        Random rnd = new Random();
        string islandModel;
        long counter = 0;
        private string ivMeterValue = "=12";
        private string title;

    //    public MainWindow xy = null;

        IvCustomPanelAutoManualViewModel demo;

        public IvCustomPanelAutoManualViewModel Demo
        {
            get { return demo; }
            set
            {
                demo = value;
                RaisePropertyChanged(() => Demo);
            }
        }
        public string Title
        {
            get { return title; }
            set
            {
                if (title != value)
                {
                    title = value;
                    RaisePropertyChanged(() => Title);
                }
            }
        }

        public string IvMeterValue
        {
            get { return ivMeterValue; }
            set
            {
                if (ivMeterValue != value)
                {
                    ivMeterValue = value;
                    RaisePropertyChanged(() => IvMeterValue);
                }
            }
        }


        private ICommand changeIsland;
        public ICommand ChangeIsland
        {
            get { return changeIsland = new RelayCommand(s => OnChangeIsland()); }
        }

        public MainViewModel(string island)
        {

            islandModel = island;
            timer = new System.Timers.Timer();
            timer.Interval = 500;
            timer.Elapsed += timer_Elapsed;
            timer.Start();



        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            counter++;
            Title = islandModel + ": " + counter.ToString();
            if (Demo != null)
            {
                if (counter % 16 == 0)
                    Demo.IvTagStatus = "=0";

                if (counter % 16 == 4)
                    Demo.IvTagStatus = "=1";

                if (counter % 16 == 8)
                    Demo.IvTagStatus = "=2";

                if (counter % 16 == 12)
                    Demo.IvTagStatus = "=3";

            }


        }

        private void OnChangeIsland()
        {

            islandModel = "NEW ISLAND";

        }
    }
}
