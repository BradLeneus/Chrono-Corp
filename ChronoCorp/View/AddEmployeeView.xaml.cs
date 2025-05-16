using System.Windows;
using System.Windows.Controls;
using ChronoCorp.ViewModel;

namespace ChronoCorp.View
{
    /// <summary>
    /// Logique d'interaction pour AddEmployeeView.xaml
    /// </summary>
    public partial class AddEmployeeView : UserControl
    {
        private readonly AddEmployeeViewModel _viewModel;

        public AddEmployeeView(AddEmployeeViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
        }

        private async void OnSaveClick(object sender, RoutedEventArgs e)
        {
            await _viewModel.SaveAsync();
        }
    }
}
