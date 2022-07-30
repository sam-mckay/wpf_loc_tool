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
    public partial class DesginStringView : Page
    {
        public DesginStringView()
        {
            InitializeComponent();

            ObservableCollection<LocString> locStrings = GetData();

            StringsDataGrid.DataContext = locStrings;
            TestDG.DataContext = locStrings;
        }

        private ObservableCollection<LocString> GetData()
        {
            ObservableCollection<LocString> data = new ObservableCollection<LocString>();
            foreach (LocString locString in LocRecords.LocStrings)
            {
                data.Add(locString);
            }
            return data;
        }
        

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }

        private void StringsDataGrid_AddingNewItem(object sender, AddingNewItemEventArgs e)
        {
            //Strings.Add(new LocString("","",""));
        }

        private void StringsDataGrid_InitializingNewItem(object sender, InitializingNewItemEventArgs e)
        {
            LocString newLocString = new LocString("", "", "");
            LocRecords.LocStrings.Add(newLocString);
            //Strings.Add(newLocString);
        }
    }
}
