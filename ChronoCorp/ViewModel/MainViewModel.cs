using ChronoCorp.Model;
using ChronoCorp.Service;
using ChronoCorp.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ChronoCorp.ViewModel
{
    public partial class MainViewModel : ObservableObject, INavigationService
    {
        [ObservableProperty]
        private ObservableCollection<MenuItemModel> menuItems;

        [ObservableProperty]
        private object currentView;

        private readonly EmployeeCredentials credentials;

        [ObservableProperty]
        private Employee employee;

        // A RETIRER QUAND APRES AVOIR AJUSTE VIEWMODELS
        public User currentUser = null;

        public MainViewModel(EmployeeCredentials empCreds, Employee employee)
        {
            credentials = empCreds;
            Employee = employee;
            LoadMenuItems();
            CurrentView = new HomeView
            {
                DataContext = new HomeViewModel(Employee, credentials.Role, this)
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


            if (credentials.Role != "Gestionnaire")
            {
                MenuItems.Add(new MenuItemModel { Title = "Mon horaire", Command = null });
                MenuItems.Add(new MenuItemModel { Title = "Voir mon horaire", Command = OpenScheduleCommand });
                MenuItems.Add(new MenuItemModel { Title = "Pointer ma présence", Command = OpenClockingCommand });
                MenuItems.Add(new MenuItemModel { Title = "Poser une demande congé", Command = OpenMyLeaveRequestCommand });
                MenuItems.Add(new MenuItemModel { Title = "Voir mes fiches de paie", Command = OpenPaySlipsCommand });

                if (credentials.Role == "Ressources humaines")
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
                DataContext = new HomeViewModel(employee, credentials.Role, this)
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
                DataContext = new MyEmployeesViewModel(Employee)
            });
        }
        
        
        [RelayCommand]
        private void OpenMyLeaveRequest()
        {
            NavigateTo(new MyLeaveRequestView
            {
                DataContext = new MyLeaveRequestViewModel(currentUser)
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
