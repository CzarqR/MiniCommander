using Commander.ViewModel.Commands;
using Commander.ViewModel.WindowVM;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Commander.ViewModel.ControlVM
{
    class PanelTCVM : BaseVM
    {
        private string path;

        public string Path
        {
            get
            {
                return path;
            }
            set
            {
                path = value;
                UpdateContent();
                OnPropertyChanged(nameof(Path));
            }
        }

        private int selectedDriveIndex;

        public int SelectedDriveIndex
        {
            get
            {
                return selectedDriveIndex;
            }
            set
            {
                selectedDriveIndex = value;
                Path = Drivers[SelectedDriveIndex];
                Console.WriteLine(Path);
                OnPropertyChanged(nameof(SelectedDriveIndex));
            }
        }

        private List<string> drivers;

        public List<string> Drivers
        {
            get
            {
                return drivers;
            }
            set
            {
                drivers = value;
                OnPropertyChanged(nameof(Drivers));
            }
        }

        private List<string> content;
        public List<string> Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
                OnPropertyChanged(nameof(Content));
            }
        }

        private ICommand pathSelectCommand;

        public ICommand PathSelectCommand
        {
            get
            {
                return pathSelectCommand ?? (pathSelectCommand = new CommandHandler(Click, () => { return true; }));
            }

        }

        public void Click()
        {
            Console.WriteLine("SELECTED");
        }


        private List<string> contentOriginal;
        private int foldersCount;

        public PanelTCVM()
        {
            Drivers = Directory.GetLogicalDrives().OfType<string>().ToList();
            SelectedDriveIndex = 1; //todo, change to 0 after testing
            Path = Drivers[SelectedDriveIndex];
        }

        private void UpdateContent()
        {
            Console.WriteLine("Update");
            List<string> folders = Directory.GetDirectories(Path).OfType<string>().ToList();
            foldersCount = folders.Count;
            List<string> files = Directory.GetFiles(Path).OfType<string>().ToList();
            contentOriginal = folders.Concat(files).ToList();


            for (int i = 0; i < folders.Count; i++)
            {
                folders[i] = "<" + folders[i][0] + ">" + folders[i].Substring(3);
            }

            for (int i = 0; i < files.Count; i++)
            {
                files[i] = files[i].Substring(3);
            }

            Content = folders.Concat(files).ToList();

            //if (leftInsideIterator != 0)
            //{
            //    LeftContent.Insert(0, "...");
            //}

        }



    }
}
