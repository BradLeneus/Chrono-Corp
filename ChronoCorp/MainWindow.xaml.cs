using ChronoCorp.Data;
using ChronoCorp.Model;
using ChronoCorp.Service;
using ChronoCorp.ViewModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ChronoCorp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly EmployeeService _employeeService;

        public MainWindow()
        {
            InitializeComponent();

            var dataProvider = new EmployeeDataProvider();
            _employeeService = new EmployeeService(dataProvider);

            // user pour test
            var emp = new EmployeeCredentials { IdEmployee = 432401, Role = "Employé" };
            var rh = new EmployeeCredentials { IdEmployee = 438412, Role = "Ressources humaines" };
            var gest = new EmployeeCredentials { IdEmployee = 330152, Role = "Gestionnaire" };

            LoadEmployee(emp);
        }

        public async void LoadEmployee(EmployeeCredentials credentials)
        {
            var employee = await _employeeService.GetEmployeeByIdAsync(credentials.IdEmployee);

            if (employee == null)
            {
                MessageBox.Show("Employé non trouvé !");
                return;
            }

            DataContext = new MainViewModel(credentials, employee);
        }
    }
}