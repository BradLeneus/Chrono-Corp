using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Threading.Tasks;
using System.Windows;
using ChronoCorp.Model;
using ChronoCorp.Service;
using ChronoCorp.Interface;

namespace ChronoCorp.ViewModel
{
    public partial class LoginViewModel : ObservableObject
    {
        private readonly IAuthService _authService;

        private readonly IServiceProvider _serviceProvider;

        private readonly IEmployeeService _employeeService;

        [ObservableProperty]
        private string username;

        [ObservableProperty]
        private string password;

        [ObservableProperty]
        private string loginMessage;

        public LoginViewModel(IAuthService authService, IEmployeeService employeeService, IServiceProvider serviceProvider, IMessagerieService messagerieService, ICeduleQuartService ceduleQuartService, IDemandeCongeService demandeCongeService, IFichePaieService fichePaieService, ITypeQuartService typeQuartService)
        {
            _authService = authService;
            _employeeService = employeeService;
            _serviceProvider = serviceProvider;
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
            long userId = await _authService.GetEmployeeIdAsync(Username, Password);
            string role = await _authService.GetEmployeeRoleAsync(Username, Password);

            if (isValid)
            {
                Employee employee = await _employeeService.GetEmployeeByIdAsync(userId);

                LoginMessage = "Connexion réussie";

                MainWindow mainWindow = new MainWindow(role, employee, _serviceProvider);
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
