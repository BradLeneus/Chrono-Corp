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
        private readonly MainViewModel _mainViewModel;

        public EmployeeListView(EmployeeListViewModel viewModel, MainViewModel mainViewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
            _mainViewModel = mainViewModel;
        }

        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.LoadAllEmployees();
        }

        private void EmployeeDataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_viewModel.Employee != null)
            {
                _mainViewModel.OpenEditEmployee(_viewModel.Employee);
            }
        }
    }
}



