using System.Windows;
using ChronoCorp.ViewModel;

namespace ChronoCorp.View
{
    public partial class LoginView : Window
    {
        private readonly LoginViewModel _viewModel;

        public LoginView(LoginViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            DataContext = _viewModel;
        }

        private async void OnLoginClick(object sender, RoutedEventArgs e)
        {
            _viewModel.Password = PasswordBox.Password;
            await _viewModel.LoginAsync();

            if (_viewModel.LoginMessage == "Connexion réussie")
            {
                this.Close();
            }
        }

    }
}



