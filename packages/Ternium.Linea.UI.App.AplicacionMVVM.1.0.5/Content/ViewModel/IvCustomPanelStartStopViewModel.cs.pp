using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Ternium.Ivision.UI.Library.MVVM.Core;

namespace $rootnamespace$.ViewModel
{
    public class IvCustomPanelStartStopViewModel : ViewModelBase
    {
        
        private string ivTitle="Titulo";
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
        
        private string ivTagStatus="=0";
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
        
        private string ivTagStart;
        public string IvTagStart
        {
            get { return ivTagStart; }
            set {
                if (ivTagStart != value)
                {
                    ivTagStart = value;
                   RaisePropertyChanged(() => IvTagStart);
                }
            }
        }
        
        private string ivTagStop;
        public string IvTagStop
        {
            get { return ivTagStop; }
            set {
                if (ivTagStop != value)
                {
                    ivTagStop = value;
                    RaisePropertyChanged(() => IvTagStop);
                } 
            }
        }

        private int ivRow=0;

        public int IvRow
        {
            get { return ivRow; }
            set
            {
                if (ivRow != value)
                {
                    ivRow = value;
                    RaisePropertyChanged(() => IvRow);
                }
            }
        }

        private int ivColumn= 0;

        public int IvColumn
        {
            get { return ivColumn; }
            set {

                if (ivColumn != value)
                {
                    ivColumn = value;
                    RaisePropertyChanged(() => IvColumn);
                }
            }
        }

        public IvCustomPanelStartStopViewModel()
        {
         
        }
    }
}
