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

namespace Commander.View
{

    public partial class PanelTCControl : UserControl
    {

        #region properties



        public string Path
        {
            get
            {
                return (string)GetValue(PathProperty);
            }
            set
            {
                SetValue(PathProperty, value);
            }
        }

        public static readonly DependencyProperty PathProperty =
            DependencyProperty.Register("Path", typeof(string), typeof(PanelTCControl), new PropertyMetadata(null));



        public List<string> Drives
        {
            get
            {
                return (List<string>)GetValue(DrivesProperty);
            }
            set
            {
                SetValue(DrivesProperty, value);
            }
        }

        public static readonly DependencyProperty DrivesProperty =
            DependencyProperty.Register("Drives", typeof(List<string>), typeof(PanelTCControl), new PropertyMetadata(null));




        public List<string> PathContent
        {
            get
            {
                return (List<string>)GetValue(PathContentProperty);
            }
            set
            {
                SetValue(PathContentProperty, value);
            }
        }

        public static readonly DependencyProperty PathContentProperty =
            DependencyProperty.Register("PathContent", typeof(List<string>), typeof(PanelTCControl), new PropertyMetadata(null));





        public int SelectedDriveIndex
        {
            get
            {
                return (int)GetValue(SelectedDriveIndexProperty);
            }
            set
            {
                SetValue(SelectedDriveIndexProperty, value);
            }
        }

        public static readonly DependencyProperty SelectedDriveIndexProperty =
            DependencyProperty.Register("SelectedDriveIndex", typeof(int), typeof(PanelTCControl), new PropertyMetadata(null));




        public ICommand SelectPath
        {
            get
            {
                return (ICommand)GetValue(SelectPathProperty);
            }
            set
            {
                SetValue(SelectPathProperty, value);
            }
        }

        public static readonly DependencyProperty SelectPathProperty =
            DependencyProperty.Register("SelectPath", typeof(ICommand), typeof(PanelTCControl), new PropertyMetadata(null));




        //public int SelectedContentIndex
        //{
        //    get
        //    {
        //        return (int)GetValue(SelectedContentIndexProperty);
        //    }
        //    set
        //    {
        //        SetValue(SelectedContentIndexProperty, value);
        //    }
        //}

        //public static readonly DependencyProperty SelectedContentIndexProperty =
        //    DependencyProperty.Register("SelectedContentIndex", typeof(int), typeof(PanelTCControl), new PropertyMetadata(null));







        #endregion

        public PanelTCControl()
        {
            InitializeComponent();

        }
    }
}
