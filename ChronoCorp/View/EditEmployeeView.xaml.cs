using System.Windows;
using System.Windows.Controls;
using ChronoCorp.ViewModel;

namespace ChronoCorp.View
{
    /// <summary>
    /// Interaction logic for EditEmployeeView.xaml
    /// </summary>
    public partial class EditEmployeeView : UserControl
    {
        private readonly EditEmployeeViewModel _viewModel;

        public EditEmployeeView(EditEmployeeViewModel viewModel)
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
