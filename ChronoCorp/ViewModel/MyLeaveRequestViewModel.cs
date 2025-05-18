using ChronoCorp.Interface;
using ChronoCorp.Model;
using ChronoCorp.View;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;

namespace ChronoCorp.ViewModel
{
    public partial class MyLeaveRequestViewModel : ObservableObject
    {
        private readonly IDemandeCongeService _demandeCongeService;

        [ObservableProperty]
        private Employee employee;

        [ObservableProperty]
        private object currentLeaveView;

        [ObservableProperty]
        private ObservableCollection<DemandeConge> leaveRequest = new();

        public MyLeaveRequestViewModel(Employee employee, IDemandeCongeService demandeCongeService)
        {
            Employee = employee;
            _demandeCongeService = demandeCongeService;
            _ = LoadMyLeaveRequest(employee);

            CurrentLeaveView = new CheckLeaveStatusView
            {
                DataContext = new CheckLeaveStatusViewModel(Employee)
            };
        }

        private async Task LoadMyLeaveRequest(Employee employee)
        {
            var leaveRequestList = await _demandeCongeService.GetDemandeCongeListByIdEmetteur(employee.Id);
            LeaveRequest = new ObservableCollection<DemandeConge>(leaveRequestList);
        }

        [RelayCommand]
        private void OpenNewLeaveRequestView()
        {
            CurrentLeaveView = new NewLeaveView
            {
                DataContext = new NewLeaveViewModel(Employee, _demandeCongeService) 
            };
        }
    }

}
