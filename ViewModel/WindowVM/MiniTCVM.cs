using Commander.ViewModel.ControlVM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


        //private string leftPath;

        //public string LeftPath
        //{
        //    get
        //    {
        //        return leftPath;
        //    }
        //    set
        //    {
        //        leftPath = value;
        //        OnPropertyChanged(nameof(LeftPath));
        //    }
        //}

        //private string rightPath;

        //public string RightPath
        //{
        //    get
        //    {
        //        return rightPath;
        //    }
        //    set
        //    {
        //        rightPath = value;
        //        OnPropertyChanged(nameof(RightPath));
        //    }
        //}

        //private int leftSelectedDriveIndex;

        //public int LeftSelectedDriveIndex
        //{
        //    get
        //    {
        //        return leftSelectedDriveIndex;
        //    }
        //    set
        //    {
        //        leftInsideIterator = -1;
        //        leftSelectedDriveIndex = value;
        //        LeftPath = Drives[LeftSelectedDriveIndex];
        //        LeftRefresh();
        //        OnPropertyChanged(nameof(LeftSelectedDriveIndex));
        //    }
        //}

        //private int rightSelectedDriveIndex;

        //public int RightSelectedDriveIndex
        //{
        //    get
        //    {
        //        return rightSelectedDriveIndex;
        //    }
        //    set
        //    {
        //        rightSelectedDriveIndex = value;
        //        RightPath = Drives[RightSelectedDriveIndex];
        //        RightRefresh();
        //        OnPropertyChanged(nameof(RightSelectedDriveIndex));
        //    }
        //}

        //private List<string> drives;

        //public List<string> Drives
        //{
        //    get
        //    {
        //        return drives;
        //    }
        //    private set
        //    {
        //        drives = value;
        //        OnPropertyChanged(nameof(Drives));
        //    }
        //}

        //private List<string> rightContent;

        //public List<string> RightContent
        //{
        //    get
        //    {
        //        return rightContent;
        //    }
        //    set
        //    {
        //        rightContent = value;
        //        OnPropertyChanged(nameof(RightContent));
        //    }
        //}

        //private List<string> leftContent;

        //public List<string> LeftContent
        //{
        //    get
        //    {
        //        return leftContent;
        //    }
        //    set
        //    {
        //        leftContent = value;
        //        OnPropertyChanged(nameof(LeftContent));
        //    }
        //}

        //private int leftSelectedContentIndex;

        //public int LeftSelectedContentIndex
        //{
        //    get
        //    {
        //        return leftSelectedContentIndex;
        //    }
        //    set
        //    {
        //        leftSelectedContentIndex = value;
        //        if (leftSelectedContentIndex != -1)
        //        {
        //            if (leftInsideIterator == 0)//drive folder
        //            {
        //                if (leftSelectedContentIndex < leftFoldersCount) //selected folder
        //                {
        //                    Console.WriteLine("Folder");
        //                    LeftPath = leftContentPaths[leftSelectedContentIndex + 1];
        //                    leftInsideIterator++;
        //                    LeftRefresh();
        //                }
        //                else //selected file
        //                {
        //                    Console.WriteLine("File");
        //                }
        //            }
        //            else if ((leftInsideIterator > 0)) //deep folder
        //            {
        //                if (leftSelectedContentIndex == 0) //folder up
        //                {
        //                    Console.WriteLine("Folder up");
        //                    LeftPath += "..";
        //                    leftInsideIterator--;
        //                    LeftRefresh();

        //                }
        //                if (leftSelectedContentIndex <= leftFoldersCount) //selected folder
        //                {
        //                    Console.WriteLine("Folder");
        //                    LeftPath = leftContentPaths[leftSelectedContentIndex];
        //                    leftInsideIterator++;
        //                    LeftRefresh();
        //                }
        //                else //selected file
        //                {

        //                }
        //            }
        //            else
        //            {
        //                Console.WriteLine("-1");
        //                leftInsideIterator = 0;
        //            }
        //        }
        //        OnPropertyChanged(nameof(LeftSelectedContentIndex));
        //    }
        //}


        //private List<string> leftContentPaths;
        //private int leftInsideIterator = -1;
        //private int leftFoldersCount;
        ////private List<string> rightContentPaths;


        //public MiniTCVM()
        //{
        //    Drives = Directory.GetLogicalDrives().OfType<string>().ToList();

        //    RightSelectedDriveIndex = 1;
        //    LeftSelectedDriveIndex = 1;

        //    LeftPath = Drives[LeftSelectedDriveIndex];
        //    RightPath = Drives[RightSelectedDriveIndex];

        //    LeftRefresh();
        //    RightRefresh();

        //}

        //private void LeftRefresh()
        //{
        //    List<string> folders = Directory.GetDirectories(LeftPath).OfType<string>().ToList();
        //    leftFoldersCount = folders.Count;
        //    List<string> files = Directory.GetFiles(LeftPath).OfType<string>().ToList();
        //    leftContentPaths = folders.Concat(files).ToList();


        //    for (int i = 0; i < folders.Count; i++)
        //    {
        //        folders[i] = "<" + folders[i][0] + ">" + folders[i].Substring(3);
        //    }

        //    for (int i = 0; i < files.Count; i++)
        //    {
        //        files[i] = files[i].Substring(3);
        //    }

        //    LeftContent = folders.Concat(files).ToList();
        //    if (leftInsideIterator != 0)
        //    {
        //        LeftContent.Insert(0, "...");
        //    }
        //}

        //private void RightRefresh()
        //{
        //    RightContent = Directory.GetDirectories(RightPath).OfType<string>().ToList();

        //}

    }
}
