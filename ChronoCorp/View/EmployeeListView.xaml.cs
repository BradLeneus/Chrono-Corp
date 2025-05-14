using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ChronoCorp.Data;
using ChronoCorp.Interface;
using ChronoCorp.Model;
using ChronoCorp.Service;
using ChronoCorp.ViewModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ChronoCorp.View
{
    /// <summary>
    /// Logique d'interaction pour EmployeeListView.xaml
    /// </summary>
    public partial class EmployeeListView : UserControl
    {
        private readonly EmployeeListViewModel _viewModel;

        public EmployeeListView()
        {
            InitializeComponent();
            DataContext = _viewModel;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAllEmployees();
        }
    }
}



