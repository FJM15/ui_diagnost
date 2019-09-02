using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ternium.Ivision.UI.Library.MVVM.Core;

namespace $rootnamespace$.ViewModel
{
    public class IvCustomPanelAutoManualViewModel : ViewModelBase
    {
        private string ivTitle;
        public string IvTitle
        {
            get { return ivTitle; }
            set
            {
                if (ivTitle != value)
                {
                    ivTitle = value;
                    RaisePropertyChanged(() => IvTitle);
                }
            }
        }
        
        private string ivTagStatus;
        public string IvTagStatus
        {
            get { return ivTagStatus; }
            set {
                if (ivTagStatus != value)
                {
                    ivTagStatus = value;
                    RaisePropertyChanged(() => IvTagStatus);
                }
            }
        }
        
        private string ivTagAuto;
        public string IvTagAuto
        {
            get { return ivTagAuto; }
            set {
                if (ivTagAuto != value)
                {
                    ivTagAuto = value;
                    RaisePropertyChanged(() => IvTagAuto);
                }
            }
        }
        
        private string ivTagManual;
        public string IvTagManual
        {
            get { return ivTagManual; }
            set {
                if (ivTagManual != value)
                {
                    ivTagManual = value;
                    RaisePropertyChanged(() => IvTagManual);
                } 
            }
        }
    
        public IvCustomPanelAutoManualViewModel()
        {
         
        }
    }
}
