using ChronoCorp.Data;
using ChronoCorp.Interface;
using ChronoCorp.Model;
using ChronoCorp.Service;
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
        private string prenom;

        [ObservableProperty]
        private string role;

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

        public HomeViewModel(Employee employee, string role, INavigationService navigationService, IMessagerieService messagerieService)
        {
            Prenom = employee.Prenom;
            Role = role;
            _navigationService = navigationService;
            _messagerieService = messagerieService;

            LoadSubMenuItemModels();

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
                DataContext = new MyLeaveRequestViewModel(null)
            });
        }

        [RelayCommand]
        private void NavigateToMyEmployeesLeaveRequest()
        {
            _navigationService.NavigateTo(new MyEmployeesLeaveRequestView
            {
                //DataContext = new MyLeaveRequestViewModel(null)
            });
        }

        [RelayCommand]
        private void NavigateToMyPaySlips()
        {
            _navigationService.NavigateTo(new PaySlipsView
            {
                DataContext = new PaySlipsViewModel(null)
            });
        }

        [RelayCommand]
        private void NavigateToClockingManagement()
        {
            _navigationService.NavigateTo(new ClockingManagementView
            {
                //DataContext = new PaySlipsViewModel(_user)
            });
        }
        [RelayCommand]
        private void NavigateToScheduleManagement()
        {
            _navigationService.NavigateTo(new ScheduleManagementView
            {
                //DataContext = new PaySlipsViewModel(_user)
            });
        }
        [RelayCommand]
        private void NavigateToClocking()
        {
            _navigationService.NavigateTo(new ClockingView
            {
                //DataContext = new PaySlipsViewModel(_user)
            });
        }
        [RelayCommand]
        private void NavigateToSchedule()
        {
            _navigationService.NavigateTo(new ScheduleView
            {
                //DataContext = new PaySlipsViewModel(_user)
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
    }
}