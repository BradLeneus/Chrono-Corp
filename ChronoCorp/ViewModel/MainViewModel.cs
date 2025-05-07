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

        private readonly String _role;

        private readonly IEmployeeService _employeeService;

        public ICommand SaveCommand => throw new NotImplementedException();

        public MainViewModel(String role, Employee employee, IEmployeeService employeeService)
        {
            _role = role;
            CurrentEmployee = employee;
            _employeeService = employeeService;
            LoadMenuItems();
            CurrentView = new HomeView
            {
                DataContext = new HomeViewModel(CurrentEmployee, _role, this)
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
                MenuItems.Add(new MenuItemModel { Title = "Mon horaire", Command = null });
                MenuItems.Add(new MenuItemModel { Title = "Voir mon horaire", Command = OpenScheduleCommand });
                MenuItems.Add(new MenuItemModel { Title = "Pointer ma présence", Command = OpenClockingCommand });
                MenuItems.Add(new MenuItemModel { Title = "Poser une demande congé", Command = OpenMyLeaveRequestCommand });
                MenuItems.Add(new MenuItemModel { Title = "Voir mes fiches de paie", Command = OpenPaySlipsCommand });

                if (_role == "Ressources humaines")
                {
                    MenuItems.Add(new MenuItemModel { Title = "Employés", Command = null });
                    MenuItems.Add(new MenuItemModel { Title = "Voir la liste des employés", Command = OpenEmployeeListCommand });
                    MenuItems.Add(new MenuItemModel { Title = "Ajouter un employé", Command = OpenAddEmployeeCommand });
                }
            } else
            {
                MenuItems.Add(new MenuItemModel { Title = "Mon horaire", Command = null });
                MenuItems.Add(new MenuItemModel { Title = "Voir mon horaire", Command = OpenScheduleCommand });
                MenuItems.Add(new MenuItemModel { Title = "Pointer ma présence", Command = OpenClockingCommand });
                MenuItems.Add(new MenuItemModel { Title = "Voir mes fiches de paie", Command = OpenPaySlipsCommand });
                MenuItems.Add(new MenuItemModel { Title = "Mes employés", Command = null });
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
                DataContext = new HomeViewModel(CurrentEmployee, _role, this)
            });
        }

        [RelayCommand]
        private void OpenProfile()
        {
            NavigateTo(new ProfileView
            {
                //DataContext = new ProfileViewModel(currentUser)
            });
        }

        [RelayCommand]
        private void OpenAddEmployee()
        {
            NavigateTo(new AddEmployeeView
            {
                //DataContext = new ProfileViewModel(currentUser)
            });
        }
        
        [RelayCommand]
        private void OpenClockingManagement()
        {
            NavigateTo(new ClockingManagementView
            {
                //DataContext = new ProfileViewModel(currentUser)
            });
        }
        
        [RelayCommand]
        private void OpenClocking()
        {
            NavigateTo(new ClockingView
            {
                //DataContext = new ProfileViewModel(currentUser)
            });
        }
        
        [RelayCommand]
        private void OpenEmployeeList()
        {
            NavigateTo(new EmployeeListView
            {
                //DataContext = new ProfileViewModel(currentUser)
            });
        }

        [RelayCommand]
        private void OpenMyEmployeesLeaveRequest()
        {
            NavigateTo(new MyEmployeesLeaveRequestView
            {
                //DataContext = new ProfileViewModel(currentUser)
            });
        }

        [RelayCommand]
        private void OpenMyEmployees()
        {
            NavigateTo(new MyEmployeesView
            {
                DataContext = new MyEmployeesViewModel(CurrentEmployee)
            });
        }
        
        
        [RelayCommand]
        private void OpenMyLeaveRequest()
        {
            NavigateTo(new MyLeaveRequestView
            {
                //DataContext = new MyLeaveRequestViewModel(currentUser)
            });
        }
        
        
        [RelayCommand]
        private void OpenPaySlips()
        {
            NavigateTo(new PaySlipsView
            {
                //DataContext = new ProfileViewModel(currentUser)
            });
        }
        
        [RelayCommand]
        private void OpenScheduleManagement()
        {
            NavigateTo(new ScheduleManagementView
            {
                //DataContext = new ProfileViewModel(currentUser)
            });
        }
        
        [RelayCommand]
        private void OpenSchedule()
        {
            NavigateTo(new ScheduleView
            {
                //DataContext = new ProfileViewModel(currentUser)
            });
        }
    }
}
