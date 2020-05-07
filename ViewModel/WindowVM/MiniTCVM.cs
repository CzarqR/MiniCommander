using Commander.ViewModel.Commands;
using Commander.ViewModel.ControlVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Commander.ViewModel.WindowVM
{
    class MiniTCVM : BaseVM
    {

        private ObservableCollection<PanelTCVM> panels;

        public ObservableCollection<PanelTCVM> Panels
        {
            get
            {
                return panels;
            }
            set
            {
                panels = value;
                OnPropertyChanged(nameof(Panels));
            }
        }

        private ICommand copyCommand;

        public ICommand CopyCommand
        {
            get
            {
                return copyCommand ?? (copyCommand = new CommandHandler(Copy, CanCopy));
            }
        }

        private void Copy()
        {
            Console.WriteLine("copy");
        }

        private bool CanCopy()
        {
            if (!string.IsNullOrEmpty(LeftPanel.SelectedFile))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private readonly PanelTCVM LeftPanel = new PanelTCVM();
        private readonly PanelTCVM RightPanel = new PanelTCVM();


        public MiniTCVM()
        {
            Panels = new ObservableCollection<PanelTCVM>
            {
                LeftPanel,
                RightPanel
            };

        }



    }
}
