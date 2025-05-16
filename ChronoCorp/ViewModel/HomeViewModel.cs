using ChronoCorp.Interface;
using ChronoCorp.Model;
using ChronoCorp.View;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows;

namespace ChronoCorp.ViewModel
{
    public partial class HomeViewModel : ObservableObject
    {
        [ObservableProperty]
        private Employee employee;

        [ObservableProperty]
        private string prenom;

        [ObservableProperty]
        private string role;

        [ObservableProperty]
        private int nbrMessages;

        [ObservableProperty]
        private ObservableCollection<MenuItemModel> subMenuItems;

        [ObservableProperty]
        private ObservableCollection<Messagerie> messagesPaie = new(); 

        [ObservableProperty]
        private ObservableCollection<Messagerie> messagesDemandesConge = new(); 

        [ObservableProperty]
        private ObservableCollection<Messagerie> messagesApprobationConge = new();

        [ObservableProperty]
        private Visibility sectionsForEmployeesVisibility;

        [ObservableProperty]
        private Visibility sectionForManagerVisibility;

        private INavigationService _navigationService;

        private IMessagerieService _messagerieService;

        private IFichePaieService _fichePaieService;

        private IDemandeCongeService _demandeCongeService;

        private ICeduleQuartService _ceduleQuartService;

        public HomeViewModel(Employee employee, string role, INavigationService navigationService, IMessagerieService messagerieService, IFichePaieService fichePaieService, IDemandeCongeService demandeCongeService, ICeduleQuartService ceduleQuartService)
        {
            Prenom = employee.Prenom;
            Role = role;
            Employee = employee;
            _navigationService = navigationService;
            _messagerieService = messagerieService;
            _fichePaieService = fichePaieService;
            _demandeCongeService = demandeCongeService;
            _ceduleQuartService = ceduleQuartService;

            LoadSubMenuItemModels();
            LoadNbrMessages(employee);

            if (role == "Gestionnaire")
            {
                _ = LoadLeaveRequestMessages(employee);
                SectionForManagerVisibility = Visibility.Visible;
                SectionsForEmployeesVisibility = Visibility.Collapsed;
            }
            else
            { 
                _ = LoadLeaveApprobationMessages(employee);
                _ = LoadPaySlipsMessages(employee);
                SectionForManagerVisibility = Visibility.Collapsed;
                SectionsForEmployeesVisibility = Visibility.Visible;
            }
        }

        private void LoadSubMenuItemModels()
        {
            SubMenuItems = new ObservableCollection<MenuItemModel>();

            if (Role == "Gestionnaire")
            {
                SubMenuItems.Add(new MenuItemModel { Title = "Gestion des pointages", Command = NavigateToClockingManagementCommand });
                SubMenuItems.Add(new MenuItemModel { Title = "Gestion des horaires", Command = NavigateToScheduleManagementCommand });
            }
            else
            {
                SubMenuItems.Add(new MenuItemModel { Title = "Pointer ma présence", Command = NavigateToScheduleCommand });
                SubMenuItems.Add(new MenuItemModel { Title = "Mon horaire", Command = NavigateToClockingCommand });
            }
        }

        [RelayCommand]
        private void NavigateToMyLeaveRequest()
        {
            _navigationService.NavigateTo(new MyLeaveRequestView
            {
                DataContext = new MyLeaveRequestViewModel(Employee, _demandeCongeService)
            });
        }

        [RelayCommand]
        private void NavigateToMyEmployeesLeaveRequest()
        {
            _navigationService.NavigateTo(new MyEmployeesLeaveRequestView
            {
                DataContext = new MyEmployeesLeaveRequestViewModel(Employee, _demandeCongeService)
            });
        }

        [RelayCommand]
        private void NavigateToMyPaySlips()
        {
            _navigationService.NavigateTo(new PaySlipsView
            {
                DataContext = new PaySlipsViewModel(Employee, _fichePaieService)
            });
        }

        [RelayCommand]
        private void NavigateToClocking()
        {
            _navigationService.NavigateTo(new ClockingView
            {
                DataContext = new ClockingViewModel(Employee, _ceduleQuartService)
            });
        }
        [RelayCommand]
        private void NavigateToScheduleManagement()
        {
            _navigationService.NavigateTo(new ScheduleManagementView
            {
                DataContext = new ScheduleManagementViewModel(_ceduleQuartService)
            });
        }
        [RelayCommand]
        private void NavigateToClockingManagement()
        {
            _navigationService.NavigateTo(new ClockingView
            {
                DataContext = new ClockingManagementViewModel(_ceduleQuartService)
            });
        }
        [RelayCommand]
        private void NavigateToSchedule()
        {
            _navigationService.NavigateTo(new ScheduleView
            {
                DataContext = new ScheduleViewModel(Employee, _ceduleQuartService)
            });
        }

        public async Task LoadPaySlipsMessages(Employee employee)
        {
            var messages = await _messagerieService.GetMessageByTypeMessageAndEmployeeAsync("paie", employee.Id);
            MessagesPaie = new ObservableCollection<Messagerie>(messages);
        }
        public async Task LoadLeaveRequestMessages(Employee employee)
        {
            var messages = await _messagerieService.GetMessageByTypeMessageAndEmployeeAsync("demande_conge", employee.Id);
            MessagesDemandesConge = new ObservableCollection<Messagerie>(messages);
        }
        public async Task LoadLeaveApprobationMessages(Employee employee)
        {
            var messages = await _messagerieService.GetMessageByTypeMessageAndEmployeeAsync("approbation_conge", employee.Id);
            MessagesApprobationConge = new ObservableCollection<Messagerie>(messages);
        }

        public async Task LoadNbrMessages(Employee employee)
        {
            var nbr = await _messagerieService.GetMessageCountByEmployeeAsync(employee.Id);
            NbrMessages = nbr;
        }
    }
}