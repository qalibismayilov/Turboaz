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
using System.Windows.Shapes;
using WpfApp16.ViewModels;

namespace WpfApp3.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
            DataContext = new MainViewModel(); 
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainViewModel? viewModel = DataContext as MainViewModel;
            if (viewModel != null)
            {
                int selectedIndex = combo.SelectedIndex;

         
                marka.Text = viewModel.MarkaNames[selectedIndex];
                model.Text = viewModel.ModelNames[selectedIndex];
                year.Text = viewModel.YearNames[selectedIndex];
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainViewModel? viewModel = DataContext as MainViewModel;
            if (viewModel != null)
            {
                int selectedIndex = combo.SelectedIndex;
                
                viewModel.MarkaNames.RemoveAt(selectedIndex);
                viewModel.ModelNames.RemoveAt(selectedIndex);
                viewModel.YearNames.RemoveAt(selectedIndex);

                marka.Text = "";
                model.Text = "";
                year.Text = "";
            }
        }
    }
}
