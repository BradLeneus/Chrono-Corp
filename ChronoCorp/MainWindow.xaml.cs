using ChronoCorp.Data;
using ChronoCorp.Interface;
using ChronoCorp.Model;
using ChronoCorp.Service;
using ChronoCorp.ViewModel;
using Microsoft.Extensions.DependencyInjection;
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
        private readonly IEmployeeService _employeeService;

        public MainWindow(String role, Employee employee, IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _employeeService = serviceProvider.GetRequiredService<IEmployeeService>();

            DataContext = new MainViewModel(role, employee, _employeeService);
        }

        //public async void LoadEmployee(EmployeeCredentials credentials)
        //{
        //    var employee = await _employeeService.GetEmployeeByIdAsync(credentials.Id);

        //    if (employee == null)
        //    {
        //        MessageBox.Show("Employé non trouvé !");
        //        return;
        //    }

        //    DataContext = new MainViewModel(credentials.Role, employee, _employeeService);
        //}
    }
}