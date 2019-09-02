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
    public partial class IvCustomTitle : UserControl
    {

        public static readonly DependencyProperty IvTitleProperty = DependencyProperty.Register
          ("IvTitle", typeof(string), typeof(IvCustomTitle), new PropertyMetadata(string.Empty));

        public string IvTitle
        {
            get { return (string)GetValue(IvTitleProperty); }
            set { SetValue(IvTitleProperty, value); }
        }

        public IvCustomTitle()
        {
            InitializeComponent();

        }
    }
}
