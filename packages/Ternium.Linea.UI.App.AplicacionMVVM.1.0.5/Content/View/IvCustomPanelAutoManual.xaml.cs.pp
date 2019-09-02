using System;
using System.Collections.Generic;
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
    /// Interaction logic for IvCustomPanelAutoManual.xaml
    /// </summary>
    public partial class IvCustomPanelAutoManual : UserControl
    {
        public static readonly DependencyProperty IvPanelAutoManualViewModelProperty = DependencyProperty.Register
         ("IvPanelAutoManualViewModel", typeof(IvCustomPanelAutoManualViewModel), typeof(IvCustomPanelAutoManual), new PropertyMetadata(new IvCustomPanelAutoManualViewModel()));

        public IvCustomPanelAutoManualViewModel IvPanelAutoManualViewModel
        {
            get { return (IvCustomPanelAutoManualViewModel)GetValue(IvPanelAutoManualViewModelProperty); }
            set { SetValue(IvPanelAutoManualViewModelProperty, value); }
        }
       
        public IvCustomPanelAutoManual()
        {
            InitializeComponent();

            this.Loaded += IvCustomPanelAutoManual_Loaded;
        }

        void IvCustomPanelAutoManual_Loaded(object sender, RoutedEventArgs e)
        {
            var a = sender as IvCustomPanelAutoManual;
            a.DataContext = IvPanelAutoManualViewModel;
        }
    }
}
