using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using $rootnamespace$.ViewModel;

namespace $rootnamespace$.IvCustomControl
{
    /// <summary>
    /// Interaction logic for IvCustomPanelStartStop.xaml
    /// </summary>
    public partial class IvCustomPanelStartStop : UserControl
    {
        //public static readonly DependencyProperty IvPanelStartStopViewModelProperty = DependencyProperty.Register
        // ("IvPanelStartStopViewModel", typeof(IvCustomPanelStartStopViewModel), typeof(IvCustomPanelStartStop), new PropertyMetadata(new IvCustomPanelStartStopViewModel()));

        //public IvCustomPanelStartStopViewModel IvPanelStartStopViewModel
        //{
        //    get { return (IvCustomPanelStartStopViewModel)GetValue(IvPanelStartStopViewModelProperty); }
        //    set { SetValue(IvPanelStartStopViewModelProperty, value); }
        //}

        //public IvCustomPanelStartStop()
        //{
        //    InitializeComponent();
        //}

        public static readonly DependencyProperty IvPanelStartStopViewModelProperty = DependencyProperty.Register
        ("IvPanelStartStopViewModel", typeof(ObservableCollection<IvCustomPanelStartStopViewModel>), typeof(IvCustomPanelStartStop), new PropertyMetadata(new ObservableCollection<IvCustomPanelStartStopViewModel>()));

        public ObservableCollection <IvCustomPanelStartStopViewModel> IvPanelStartStopViewModel
        {
            get { return (ObservableCollection<IvCustomPanelStartStopViewModel>)GetValue(IvPanelStartStopViewModelProperty); }
            set { SetValue(IvPanelStartStopViewModelProperty, value); }
        }


        public IvCustomPanelStartStop()
        {
            InitializeComponent();
        }

        
    }
}
