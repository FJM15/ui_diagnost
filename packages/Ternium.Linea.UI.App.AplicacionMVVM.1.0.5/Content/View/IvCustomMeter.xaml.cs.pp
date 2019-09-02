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
    /// Interaction logic for PanelAutoManual.xaml
    /// </summary>
    public partial class IvCustomMeter : UserControl
    {
       
        public static readonly DependencyProperty IvTagMeterProperty = DependencyProperty.Register
          ("IvTagMeter", typeof(string), typeof(IvCustomMeter), new PropertyMetadata(string.Empty));

        public string IvTagMeter
        {
            get { return (string)GetValue(IvTagMeterProperty); }
            set { SetValue(IvTagMeterProperty, value); }
        }

        public IvCustomMeter()
        {
            InitializeComponent();
        }
    }
}
