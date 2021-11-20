using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using Loc.Core;

namespace Loc.UI
{
    /// <summary>
    /// Interaction logic for DesginStringView.xaml
    /// </summary>
    public partial class DesginStringView : Page, INotifyPropertyChanged
    {
        public ObservableCollection<LocString> Strings
        {
            get { return Strings; }
            set 
            { 
                Strings = value;
                NotifyPropertyChanged();
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public DesginStringView()
        {
            InitializeComponent();

            LocRecords.Load();
            Strings = new ObservableCollection<LocString>();
            foreach (LocString locString in LocRecords.LocStrings)
            {
                Strings.Add(locString);
            }
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
