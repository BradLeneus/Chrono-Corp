using System.Windows.Controls;
using ChronoCorp.Service;
using ChronoCorp.Data; // Ajoutez ce using pour ApplicationDbContext
using ChronoCorp.ViewModel;

namespace ChronoCorp.View
{
    public partial class ScheduleView : UserControl
    {
        public ScheduleView()
        {
            InitializeComponent();
            var dbContext = new ApplicationDbContext(); // Instanciez le DbContext ici
            var ceduleQuartService = new CeduleQuartService(dbContext);
            var employeeService = new EmployeeService(dbContext);
            this.DataContext = new ScheduleManagementViewModel(ceduleQuartService, employeeService);
        }
    }
}