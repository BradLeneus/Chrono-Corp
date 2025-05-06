using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ChronoCorp.Services;
using System.Threading.Tasks;
using System.Windows;

namespace ChronoCorp.ViewModel
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly AuthService _authService;

        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        private string loginMessage;

        public LoginViewModel()
        {
            _authService = new AuthService();
        }

        [RelayCommand]
        public async Task LoginAsync()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                LoginMessage = "Veuillez remplir tous les champs.";
                return;
            }

            bool isValid = await _authService.AuthenticateAsync(Username, Password);

            if (isValid)
            {
                LoginMessage = "Connexion réussie";

                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();

                Application.Current.Windows[0]?.Close();
            }
            else
            {
                LoginMessage = "Identifiants invalides.";
            }
        }
    }
}
