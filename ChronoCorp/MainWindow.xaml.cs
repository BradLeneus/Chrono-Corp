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

        private readonly IMessagerieService _messagerieService;

        private readonly ICeduleQuartService _ceduleQuartService;

        private readonly IDemandeCongeService _demandeCongeService;

        private readonly IFichePaieService _fichePaieService;

        private readonly ITypeQuartService _typeQuartService;

        public MainWindow(String role, Employee employee, IServiceProvider serviceProvider)
        {
            InitializeComponent();

            _employeeService = serviceProvider.GetRequiredService<IEmployeeService>();
            _messagerieService = serviceProvider.GetRequiredService<IMessagerieService>();
            _ceduleQuartService = serviceProvider.GetRequiredService<ICeduleQuartService>();
            _demandeCongeService = serviceProvider.GetRequiredService<IDemandeCongeService>();
            _fichePaieService = serviceProvider.GetRequiredService<IFichePaieService>();
            _typeQuartService = serviceProvider.GetRequiredService<ITypeQuartService>();

            DataContext = new MainViewModel(role, employee, _employeeService, _messagerieService, _ceduleQuartService, _demandeCongeService, _fichePaieService, _typeQuartService);
        }
    }
}