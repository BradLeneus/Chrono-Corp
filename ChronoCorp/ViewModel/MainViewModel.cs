using ChronoCorp.Interface;
using ChronoCorp.Model;
using ChronoCorp.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ChronoCorp.ViewModel
{
    public partial class MainViewModel : ObservableObject, INavigationService, IMainViewModel
    {
        [ObservableProperty]
        private ObservableCollection<MenuItemModel> menuItems;

        [ObservableProperty]
        private object currentView;

        [ObservableProperty]
        private Employee currentEmployee;

        private readonly string _role;

        private readonly IEmployeeService _employeeService;

        private readonly IMessagerieService _messagerieService;

        private readonly ICeduleQuartService _ceduleQuartService;

        private readonly IDemandeCongeService _demandeCongeService;

        private readonly IFichePaieService _fichePaieService;

        private readonly ITypeQuartService _typeQuartService;

        public ICommand SaveCommand => throw new NotImplementedException();

        public MainViewModel(string role, Employee employee, IEmployeeService employeeService, IMessagerieService messagerieService, ICeduleQuartService ceduleQuartService, IDemandeCongeService demandeCongeService, IFichePaieService fichePaieService, ITypeQuartService typeQuartService)
        {
            _role = role;
            CurrentEmployee = employee;
            _employeeService = employeeService;
            _messagerieService = messagerieService;
            _ceduleQuartService = ceduleQuartService;
            _demandeCongeService = demandeCongeService;
            _fichePaieService = fichePaieService;
            _typeQuartService = typeQuartService;
            LoadMenuItems();
            CurrentView = new HomeView
            {
                DataContext = new
                HomeViewModel(CurrentEmployee, _role, this, _messagerieService, _fichePaieService, _demandeCongeService, _ceduleQuartService)
            };
        }

        public void NavigateTo(object view)
        {
            CurrentView = view;
        }

        private void LoadMenuItems()
        {
            MenuItems = new ObservableCollection<MenuItemModel>();

            MenuItems.Add(new MenuItemModel { Title = "Home", Command = OpenHomeCommand });


            if (_role != "Gestionnaire")
            {
                MenuItems.Add(new MenuItemModel { Title = "Voir mon horaire", Command = OpenScheduleCommand });
                MenuItems.Add(new MenuItemModel { Title = "Pointer ma présence", Command = OpenClockingCommand });
                MenuItems.Add(new MenuItemModel { Title = "Poser une demande congé", Command = OpenMyLeaveRequestCommand });
                MenuItems.Add(new MenuItemModel { Title = "Voir mes fiches de paie", Command = OpenPaySlipsCommand });

                if (_role == "Ressources humaines")
                {
                    MenuItems.Add(new MenuItemModel { Title = "Voir la liste des employés", Command = OpenEmployeeListCommand });
                    MenuItems.Add(new MenuItemModel { Title = "Ajouter un employé", Command = OpenAddEmployeeCommand });
                }
            }
            else
            {
                MenuItems.Add(new MenuItemModel { Title = "Voir mon horaire", Command = OpenScheduleCommand });
                MenuItems.Add(new MenuItemModel { Title = "Pointer ma présence", Command = OpenClockingCommand });
                MenuItems.Add(new MenuItemModel { Title = "Voir mes fiches de paie", Command = OpenPaySlipsCommand });
                MenuItems.Add(new MenuItemModel { Title = "Voir mes employés", Command = OpenMyEmployeesCommand });
                MenuItems.Add(new MenuItemModel { Title = "Gestion des horaires", Command = OpenScheduleManagementCommand });
                MenuItems.Add(new MenuItemModel { Title = "Gestion des pointages et des paies", Command = OpenClockingManagementCommand });
                MenuItems.Add(new MenuItemModel { Title = "Demandes de congé", Command = OpenMyEmployeesLeaveRequestCommand });
            }
        }

        [RelayCommand]
        private void OpenHome()
        {
            NavigateTo(new HomeView
            {
                DataContext = new HomeViewModel(CurrentEmployee, _role, this, _messagerieService, _fichePaieService, _demandeCongeService, _ceduleQuartService)
            });
        }

        [RelayCommand]
        private void OpenAddEmployee()
        {
            var vm = new AddEmployeeViewModel(_employeeService);
            NavigateTo(new AddEmployeeView(vm));
        }

        [RelayCommand]
        public void OpenEditEmployee(Employee employee)
        {
            var vm = new EditEmployeeViewModel(_employeeService);
            vm.LoadEmployee(employee);
            NavigateTo(new EditEmployeeView(vm));
        }

        [RelayCommand]
        private void OpenClockingManagement()
        {
            NavigateTo(new ClockingManagementView
            {
                DataContext = new ClockingManagementViewModel(_ceduleQuartService, _fichePaieService)
            });
        }


        [RelayCommand]
        private void OpenClocking()
        {
            NavigateTo(new ClockingView
            {
                DataContext = new ClockingViewModel(CurrentEmployee, _ceduleQuartService)
            });
        }

        [RelayCommand]
        private void OpenEmployeeList()
        {
            var listVm = new EmployeeListViewModel(new Employee
            {
                Prenom = "",
                Nom = "",
                Courriel = "",
                Telephone = "",
                Departement = "",
                Poste = ""
            }, _employeeService);

            var employeeListView = new EmployeeListView(listVm, this);
            NavigateTo(employeeListView);
        }

        [RelayCommand]
        private void OpenMyEmployeesLeaveRequest()
        {
            NavigateTo(new MyEmployeesLeaveRequestView
            {
                DataContext = new MyEmployeesLeaveRequestViewModel(CurrentEmployee, _demandeCongeService)
            });
        }

        [RelayCommand]
        private void OpenMyEmployees()
        {
            NavigateTo(new MyEmployeesView
            {
                DataContext = new MyEmployeesViewModel(CurrentEmployee, _employeeService)
            });
        }


        [RelayCommand]
        private void OpenMyLeaveRequest()
        {
            NavigateTo(new MyLeaveRequestView
            {
                DataContext = new MyLeaveRequestViewModel(CurrentEmployee, _demandeCongeService)
            });
        }


        [RelayCommand]
        private void OpenPaySlips()
        {
            NavigateTo(new PaySlipsView
            {
                DataContext = new PaySlipsViewModel(CurrentEmployee, _fichePaieService)
            });
        }

        [RelayCommand]
        private void OpenScheduleManagement()
        {
            var vm = new ScheduleManagementViewModel(_ceduleQuartService, _employeeService);
            var view = new ScheduleManagementView { DataContext = vm };
            NavigateTo(view);
            _ = vm.LoadEmployees();
        }

        [RelayCommand]
        private void OpenSchedule()
        {
            NavigateTo(new ScheduleView
            {
                DataContext = new ScheduleViewModel(CurrentEmployee, _ceduleQuartService)
            });
        }
    }
}