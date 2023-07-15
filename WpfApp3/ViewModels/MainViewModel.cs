using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp3.Command;
using WpfApp3.Views;

namespace WpfApp16.ViewModels
{
    public class MainViewModel
    {
        public ICommand? NewWindow { get; set; }

        public ObservableCollection<string> MarkaNames { get; set; }
        public ObservableCollection<string> ModelNames { get; set; }
        public ObservableCollection<string> YearNames { get; set; }
        public object CarNames { get; internal set; }

        public MainViewModel()
        {
            MarkaNames = new ObservableCollection<string>
            {
                "Mercedes",
                "BMW",
                "Toyota",
                "Ford",
            };
            ModelNames = new ObservableCollection<string>
            {
                "CLS 63",
                "e60",
                "land cruiser",
                "fushion",
            };
            YearNames = new ObservableCollection<string>
            {
                "2003",
                "2008",
                "2015",
                "2017",
            };

            NewWindow = new RelayCommand(ExecuteNewWindow, CanExecuteNewWindow);
        }
        void ExecuteNewWindow(object? parameter)
        {
            AddView addview = new AddView();
            addview.ShowDialog();
        }
        bool CanExecuteNewWindow(object? parameter)
        {
            return true;
        }
    }
}
